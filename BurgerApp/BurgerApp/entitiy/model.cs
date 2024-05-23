using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



public class User
{
    [Key]
    public int UserID { get; set; }

    [Required]
    [MaxLength(50)]
    public string Username { get; set; }

    [Required]
    [MaxLength(100)]
    public string Password { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(50)]
    public string LastName { get; set; }

    public bool IsActive { get; set; }
    public DateTime RegistrationDate { get; set; }
    public bool Language { get; set; }
    public int UserType { get; set; }
    [NotMapped]
    public bool logined { get; set; } = false;



    public virtual ICollection<Address> Addresses { get; set; }


    public virtual ICollection<Order> Orders { get; set; }
}

public class Address
{
    [Key]
    public int AddressID { get; set; }

    [Required]
    public int UserID { get; set; }

    [Required]
    [MaxLength(100)]
    public string AddressLine1 { get; set; }

    [MaxLength(100)]
    public string AddressLine2 { get; set; }

    [Required]
    [MaxLength(50)]
    public string City { get; set; }

    [Required]
    [MaxLength(20)]
    public string PostalCode { get; set; }

    [Required]
    [MaxLength(50)]
    public string Country { get; set; }

    public bool IsFavorite { get; set; }
    public bool IsActive { get; set; }

    [ForeignKey("UserID")]
    public User User { get; set; }
}

public class Category
{
    [Key]
    public int CategoryID { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    public string Description { get; set; }
    public bool IsActive { get; set; }
    public string Categoryimg { get; set; }

    public List<Product> Products { get; set; }
}

public class Product
{
    [Key]
    public int ProductID { get; set; }

    [Required]
    public int CategoryID { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    public string Description { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public string Image { get; set; }
    public bool IsActive { get; set; }
    [NotMapped]
    public bool IsSelected { get; set; } = false;
    [NotMapped]
    public int SelectedQuantity { get; set; } = 1;
    [NotMapped]
    public decimal CartTotal { get; set; }

    [ForeignKey("CategoryID")]
    public Category Category { get; set; }
    public virtual ICollection<OrderDetail> OrderDetails { get; set; }
}

public class Order
{
    [Key]
    public int OrderID { get; set; }

    [Required]
    public int UserID { get; set; }

    [Required]
    public int AddressID { get; set; }

    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    [ForeignKey("StatusID")]
    public int StatusID { get; set; }

    [Required]
    public OrderStatus Status { get; set; }

    public User User { get; set; }
    public Address Address { get; set; }
    public virtual ICollection<OrderDetail> OrderDetails { get; set; }
}

public class OrderDetail
{
    [Key]
    public int OrderDetailID { get; set; }

    [Required]
    [ForeignKey("OrderID")]
    public int OrderID { get; set; }

    [Required]
    public int ProductID { get; set; }

    [Required]
    public int Quantity { get; set; }

    [Required]
    public decimal Price { get; set; }

    public Order Order { get; set; }
    public Product Product { get; set; }
}

public class AppSetting
{
    [Key]
    public int SettingID { get; set; }

    [Required]
    [MaxLength(100)]
    public string SettingName { get; set; }

    [Required]
    public string SettingValue { get; set; }
    public DateTime SettingDate { get; set; }
}

public class Log
{
    [Key]
    public int LogID { get; set; }

    public DateTime LogDate { get; set; }

    [Required]
    [MaxLength(20)]
    public string LogLevel { get; set; }

    [Required]
    public string Message { get; set; }
    
    public int UserID { get; set; }

    [ForeignKey("UserID")]
    public User User { get; set; }
}

public class OrderStatus
{
    [Key]
    public int StatusID { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; }

    [MaxLength(100)]
    public string Description { get; set; }
}
