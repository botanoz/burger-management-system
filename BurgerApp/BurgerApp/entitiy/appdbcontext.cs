using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<AppSetting> AppSettings { get; set; }
    public DbSet<Log> Logs { get; set; }
    public DbSet<OrderStatus> OrderStatuses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Burada veritabanı bağlantı dizesini belirtmelisiniz.
        // Örneğin, SQL Server kullanıyorsanız aşağıdaki gibi olabilir:
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-F9IUGFM;Database=BurgerAppDb;User ID=sa;Password=btn1;TrustServerCertificate=True;Pooling=true;Max Pool Size=200;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // User ve Address arasındaki bire-çok ilişki
        modelBuilder.Entity<User>()
            .HasMany(u => u.Addresses)
            .WithOne(a => a.User)
            .HasForeignKey(a => a.UserID)
            .OnDelete(DeleteBehavior.Restrict); // Kaskad silme işlemini engelle

        // Category ve Product arasındaki bire-çok ilişki
        modelBuilder.Entity<Category>()
            .HasMany(c => c.Products)
            .WithOne(p => p.Category)
            .HasForeignKey(p => p.CategoryID)
            .OnDelete(DeleteBehavior.Restrict); // Kaskad silme işlemini engelle

        // Order ve User arasındaki bire-çok ilişki
        modelBuilder.Entity<Order>()
            .HasOne(o => o.User)
            .WithMany(u => u.Orders)
            .HasForeignKey(o => o.UserID)
            .OnDelete(DeleteBehavior.Restrict); // Kaskad silme işlemini engelle

        // OrderDetail, Order ve Product arasındaki ilişkiler
        modelBuilder.Entity<OrderDetail>()
            .HasOne(od => od.Order)
            .WithMany(o => o.OrderDetails)
            .HasForeignKey(od => od.OrderID)
            .OnDelete(DeleteBehavior.Restrict); // Kaskad silme işlemini engelle

        modelBuilder.Entity<OrderDetail>()
            .HasOne(od => od.Product)
            .WithMany(p => p.OrderDetails)
            .HasForeignKey(od => od.ProductID)
            .OnDelete(DeleteBehavior.Restrict); // Kaskad silme işlemini engelle

        // İlişkileri ve indeksleri özelleştirmek için Fluent API kullanabilirsiniz
        // Örneğin, Username'in benzersiz olması gerektiğini belirtmek için:
        modelBuilder.Entity<User>()
            .HasIndex(u => u.Username)
            .IsUnique();

        // Diğer yapılandırmalarınızı da bu şekilde ekleyebilirsiniz.
    }

}
