using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            timer1.Start();
        }
        AppDbContext db = new AppDbContext();
        int totalorders1 = 0;
        decimal totalamount1 = 0;
        decimal todayamount1 = 0;
        int todayorders1 = 0;
        int totalusers1 = 0;
        int totalproducts1 = 0;
        private void Form3_Load(object sender, EventArgs e)
        {
            var orders = db.Orders.Where(x => x.StatusID == 1 || x.StatusID == 2 || x.StatusID == 3).Select(x => new
            {
                x.OrderID,
                UserName = x.User.Username,
                x.OrderDate,
                StatusName = x.Status.Name,
                x.TotalAmount
            }).OrderByDescending(x => x.OrderDate).ToList();
            poisonDataGridView1.DataSource = orders;

            var products = db.Products.Where(x => x.IsActive).Select(x => new
            {
                x.ProductID,
                x.Name,
                x.Price,
                x.StockQuantity,
                Kategori = x.Category.Name,
            }).ToList();
            poisonDataGridView3.DataSource = products;
            var categories = db.Categories.Select(x => new
            {
                x.CategoryID,
                x.Name,
                x.Description
            }).ToList();
            poisonDataGridView4.DataSource = categories;
            var users = db.Users.Select(x => new
            {
                x.UserID,
                x.Username,
                Name = x.FirstName + " " + x.LastName,
                x.Email
            }).ToList();
            poisonDataGridView5.DataSource = users;
            updatepage();
            var katnames = db.Categories.Select(x => x.Name).ToList();
            cbekleurunkat.Items.Clear();
            foreach (var item in katnames)
            {
                cbekleurunkat.Items.Add(item);
            }
            pbekleurun.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void updatepage()
        {
            var alltotalciro = db.Orders.Sum(x => x.TotalAmount);
            var todaytotalciro = db.Orders.Where(x => x.OrderDate.Day == DateTime.Now.Day).Sum(x => x.TotalAmount);
            var totalorder = db.Orders.Count();
            var totaluser = db.Users.Count();
            var totalproduct = db.Products.Count();
            var todayorder = db.Orders.Where(x => x.OrderDate.Day == DateTime.Now.Day).Count();

            if (totalamount1 < alltotalciro)
            {
                totalamount1 += 13;
            }
            else { totalamount1 = alltotalciro; }
            if (todayamount1 < todaytotalciro)
            {
                todayamount1++;
            }
            else { todayamount1 = todaytotalciro; }

            if (totalorders1 < totalorder)
            {
                totalorders1++;
            }
            if (totalusers1 < totaluser)
            {
                totalusers1++;
            }
            if (totalproducts1 < totalproduct)
            {
                totalproducts1++;
            }
            if (todayorders1 < todayorder)
            {
                todayorders1++;
            }


            ltodayorders.Text = todayorders1.ToString();
            alltotal.Text = totalamount1.ToString();
            todaytotal.Text = todayamount1.ToString();
            lordercount.Text = totalorders1.ToString();
            lusercount.Text = totalusers1.ToString();
            lproductcount.Text = totalproducts1.ToString();

        }

        int selectedOrderId;
        private void poisonDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int selectedOrderId = 0;

            // Satır seçili değilse işlem yapma
            if (poisonDataGridView1.CurrentRow == null)
                return;

            selectedOrderId = Convert.ToInt32(poisonDataGridView1.CurrentRow.Cells[0].Value);

            // Buton adını kullanarak mevcut butonu bul
            ReaLTaiizor.Controls.ForeverButton orderstatuss = (ReaLTaiizor.Controls.ForeverButton)tabsip.Controls["orderstatuss"];
            var orderDetails = db.OrderDetails.Where(x => x.OrderID == selectedOrderId).Select(x => new
            {
                x.Product.Name,
                x.Quantity,
                x.Price,
                Total = x.Quantity * x.Price
            }).ToList();
            poisonDataGridView2.DataSource = orderDetails;

            // Eğer mevcut buton yoksa yeni bir buton oluştur
            if (orderstatuss == null)
            {
                orderstatuss = new ReaLTaiizor.Controls.ForeverButton();
                orderstatuss.Name = "orderstatuss";
                orderstatuss.BackColor = Color.Transparent;
                orderstatuss.BaseColor = Color.FromArgb(35, 168, 109);
                orderstatuss.Font = new Font("Segoe UI", 12F);
                orderstatuss.Location = new Point(551, 6);
                orderstatuss.Rounded = false;
                orderstatuss.Size = new Size(150, 28);
                orderstatuss.TabIndex = 3;
                orderstatuss.TextColor = Color.FromArgb(243, 243, 243);
                orderstatuss.Click += orderstatus_Click;
                tabsip.Controls.Add(orderstatuss);
            }

            // Seçili siparişin durumunu al
            int statusid = db.Orders.FirstOrDefault(x => x.OrderID == selectedOrderId)?.StatusID ?? 0;
            string statusName = db.OrderStatuses.FirstOrDefault(x => x.StatusID == statusid)?.Name;

            // Butonun textini güncelle
            if (statusName != null)
            {
                orderstatuss.Text = statusName;

                // Butonun durumuna göre etkinlik ayarla
                if (statusName == "Sipariş Alındı" || statusName == "Hazırlanıyor...")
                    orderstatuss.Enabled = true;
                else
                    orderstatuss.Enabled = false;
            }
        }

        int selectedproductid;
       private void poisonDataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (poisonDataGridView3.CurrentRow != null)
            {
                int currentIndex = poisonDataGridView3.CurrentCell.RowIndex;
                appsetings appsetings = new appsetings();
                selectedproductid = Convert.ToInt32(poisonDataGridView3.CurrentRow.Cells[0].Value);
                var product = db.Products.FirstOrDefault(x => x.ProductID == selectedproductid);

                // product null ise, satırın dizinini güncelle
                if (product == null)
                {
                    if (selectedproductid <= 1)
                    {
                        selectedproductid++;
                        poisonDataGridView3.Rows[currentIndex + 1].Selected = true;
                        product = db.Products.FirstOrDefault(x => x.ProductID == selectedproductid);
                    }
                    else
                    {
                        selectedproductid--;
                        poisonDataGridView3.Rows[currentIndex - 1].Selected = true;
                        product = db.Products.FirstOrDefault(x => x.ProductID == selectedproductid);
                    }
                }

                // product null değilse, verileri güncelle
                if (product != null)
                {
                    pbgorsel.SizeMode = PictureBoxSizeMode.Zoom;
                    pbgorsel.Image = Image.FromFile(appsetings.basepath + product.Image);

                    tbaciklama.Text = product.Description;
                    tbfiyat.Text = product.Price.ToString();
                    tbadet.Text = product.StockQuantity.ToString();
                    tbadi.Text = product.Name;
                    cbkategori.Items.Clear();
                    foreach (var item in db.Categories.ToList())
                    {
                        cbkategori.Items.Add(item.Name);
                    }

                    cbkategori.SelectedItem = db.Categories.FirstOrDefault(x => x.CategoryID == product.CategoryID)?.Name;
                }
            }
        }
        string selectedimgpath;
        private void foreverButtonSticky3_Click(object sender, EventArgs e)
        {
            appsetings appsetings = new appsetings();
            var product = db.Products.Find(selectedproductid);
            product.Name = tbadi.Text;
            product.Price = Convert.ToDecimal(tbfiyat.Text);
            product.StockQuantity = Convert.ToInt32(tbadet.Text);
            product.Description = tbaciklama.Text;
            product.CategoryID = db.Categories.FirstOrDefault(x => x.Name == cbkategori.SelectedItem.ToString()).CategoryID;


            string originalcatname = db.Categories.FirstOrDefault(x => x.Name == cbkategori.SelectedItem.ToString()).Name;
            string transformedcatname = ConvertToCamelCase(originalcatname);
            string productname = ConvertToCamelCase(tbadi.Text);

            if (!string.IsNullOrEmpty(selectedimgpath))
            {

                string imageName = productname + Path.GetExtension(selectedimgpath);
                string destinationPath = Path.Combine(appsetings.basepath, transformedcatname, imageName);
                File.Copy(selectedimgpath, destinationPath, true);
                string dbpath = Path.Combine(transformedcatname, imageName);
                product.Image = dbpath;
            }


            db.SaveChanges();
            goodjob();
        }

        static string ConvertToCamelCase(string text)
        {

            text = text.Replace("Ç", "C").Replace("ç", "c")
                       .Replace("Ğ", "G").Replace("ğ", "g")
                       .Replace("İ", "I").Replace("ı", "i")
                       .Replace("Ö", "O").Replace("ö", "o")
                       .Replace("Ş", "S").Replace("ş", "s")
                       .Replace("Ü", "U").Replace("ü", "u");


            string[] words = Regex.Split(text, @"\s+");


            string camelCase = "";
            foreach (string word in words)
            {
                camelCase += char.ToUpper(word[0]) + word.Substring(1);
            }

            return camelCase;
        }


        private void pbgorsel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Resim Seç",
                Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedimgpath = openFileDialog1.FileName;
                pbgorsel.ImageLocation = selectedimgpath;
            }
        }

        private void poisonDataGridView4_SelectionChanged(object sender, EventArgs e)
        {
            if (poisonDataGridView4.CurrentRow != null)
            {
                int selectedCategoryId;
                if (int.TryParse(poisonDataGridView4.CurrentRow.Cells[0].Value?.ToString(), out selectedCategoryId))
                {
                    var category = db.Categories.Find(selectedCategoryId);
                    if (category != null)
                    {
                        tbkatadi.Text = category.Name;
                        tbkataciklama.Text = category.Description;
                        pbkaticon.SizeMode = PictureBoxSizeMode.Zoom;

                        appsetings appsetings = new appsetings();
                        if (!string.IsNullOrEmpty(category.Categoryimg))
                        {
                            pbkaticon.Image = Image.FromFile(appsetings.basepath + category.Categoryimg);
                        }
                        else
                        {
                           
                            pbkaticon.Image = null;
                        }
                    }
                }
                else
                {
                    
                    int currentIndex = poisonDataGridView4.CurrentCell.RowIndex;
                    int newIndex;
                    if (selectedCategoryId <= 1)
                    {
                        newIndex = currentIndex + 1;
                    }
                    else
                    {
                        newIndex = currentIndex - 1;
                    }

                    
                    if (newIndex >= 0 && newIndex < poisonDataGridView4.Rows.Count)
                    {
                        poisonDataGridView4.Rows[newIndex].Selected = true;
                        poisonDataGridView4.CurrentCell = poisonDataGridView4.Rows[newIndex].Cells[0];
                    }
                }
            }
        }

        private void btnkatgun_Click(object sender, EventArgs e)
        {
            appsetings appsetings = new appsetings();
            int selectedCategoryId = Convert.ToInt32(poisonDataGridView4.CurrentRow.Cells[0].Value);
            var category = db.Categories.FirstOrDefault(x => x.CategoryID == selectedCategoryId);
            category.Name = tbkatadi.Text;
            category.Description = tbkataciklama.Text;
            string originalcatname = tbkatadi.Text;
            string transformedcatname = ConvertToCamelCase(originalcatname);
            string imageName = transformedcatname + Path.GetExtension(selectedimgpath);
            string destinationPath = Path.Combine(appsetings.basepath, imageName);
            File.Copy(selectedimgpath, destinationPath, true);
            string dbpath = Path.Combine(imageName);
            category.Categoryimg = dbpath;
            db.SaveChanges();
            goodjob();

        }

        private void goodjob()
        {
            MessageBox.Show("İşlem Başarılı");
        }

        private void orderstatus_Click(object sender, EventArgs e)
        {
            ReaLTaiizor.Controls.ForeverButton orderstatuss = (ReaLTaiizor.Controls.ForeverButton)sender;
            if (orderstatuss.Text == "Hazırlanıyor...")
            {
                db.Orders.FirstOrDefault(x => x.OrderID == selectedOrderId).StatusID = 3;
                db.SaveChanges();

                orderstatuss.Text = "Sipariş Tamamlandı";
                orderstatuss.Enabled = false;


            }
            else
            if (orderstatuss.Text == "Sipariş Alındı")
            {
                db.Orders.FirstOrDefault(x => x.OrderID == selectedOrderId).StatusID = 2;
                db.SaveChanges();
                orderstatuss.Text = "Hazırlanıyor...";
            }
            var orders = db.Orders.Where(x => x.StatusID == 1 || x.StatusID == 2 || x.StatusID == 3).Select(x => new
            {
                x.OrderID,
                UserName = x.User.Username,
                x.OrderDate,
                StatusName = x.Status.Name,
                x.TotalAmount
            }).OrderByDescending(x => x.OrderDate).ToList();
            poisonDataGridView1.DataSource = orders;

        }

        private void foreverTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbkaticon_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Resim Seç",
                Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedimgpath = openFileDialog1.FileName;
                pbkaticon.ImageLocation = selectedimgpath;
            }
        }

        private void poisonDataGridView5_SelectionChanged(object sender, EventArgs e)
        {
            if (poisonDataGridView5.CurrentRow != null)
            {
                int selectedUserId;
                if (int.TryParse(poisonDataGridView5.CurrentRow.Cells[0].Value?.ToString(), out selectedUserId))
                {
                    var user = db.Users.FirstOrDefault(x => x.UserID == selectedUserId);
                    if (user != null)
                    {
                        tbkulusername.Text = user.Username;
                        tbkulfirstname.Text = user.FirstName;
                        tbkullastname.Text = user.LastName;
                        tbkulemail.Text = user.Email;
                        numkultype.Value = user.UserType;
                    }
                }
                else
                {
               
                    int currentIndex = poisonDataGridView5.CurrentCell.RowIndex;
                    int newIndex;
                    if (selectedUserId <= 1)
                    {
                        newIndex = currentIndex + 1;
                    }
                    else
                    {
                        newIndex = currentIndex - 1;
                    }

                    
                    if (newIndex >= 0 && newIndex < poisonDataGridView5.Rows.Count)
                    {
                        poisonDataGridView5.Rows[newIndex].Selected = true;
                        poisonDataGridView5.CurrentCell = poisonDataGridView5.Rows[newIndex].Cells[0];
                    }
                }
            }
        }


        private void btnkulgun_Click(object sender, EventArgs e)
        {
            int selectedUserId = Convert.ToInt32(poisonDataGridView5.CurrentRow.Cells[0].Value);
            var user = db.Users.FirstOrDefault(x => x.UserID == selectedUserId);
            user.Username = tbkulusername.Text;
            user.FirstName = tbkulfirstname.Text;
            user.LastName = tbkullastname.Text;
            user.Email = tbkulemail.Text;
            user.UserType = Convert.ToInt32(numkultype.Value);
            db.SaveChanges();
            goodjob();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updatepage();
        }

        private void btnekleurun_Click(object sender, EventArgs e)
        {
            appsetings appsetings = new appsetings();

            Product p = new Product();

            p.Name = tbekleurunname.Text;
            p.Price = Convert.ToDecimal(tbekleurunfiyat.Text);
            p.StockQuantity = Convert.ToInt32(tbekleurunstok.Text);
            p.Description = tbekleurunacik.Text;
            p.CategoryID = db.Categories.FirstOrDefault(x => x.Name == cbekleurunkat.SelectedItem.ToString()).CategoryID;
            p.IsActive = true;
            string convertname = ConvertToCamelCase(tbekleurunname.Text);
            string transformedcatname = ConvertToCamelCase(cbekleurunkat.SelectedItem.ToString());
            string imageName = convertname + Path.GetExtension(selectedimgpath);
            string destinationPath = Path.Combine(appsetings.basepath, transformedcatname, imageName);
            File.Copy(selectedimgpath, destinationPath, true);
            p.Image = Path.Combine(transformedcatname, imageName);
            db.Products.Add(p);
            db.SaveChanges();
            tbekleurunname.Text = "";
            tbekleurunfiyat.Text = "";
            tbekleurunstok.Text = "";
            tbekleurunacik.Text = "";
            cbekleurunkat.SelectedIndex = -1;
            pbekleurun.Image = null;
            var products = db.Products.Where(x => x.IsActive).Select(x => new
            {
                x.ProductID,
                x.Name,
                x.Price,
                x.StockQuantity,
                Kategori = x.Category.Name,
            }).ToList();
            poisonDataGridView3.DataSource = products;
            goodjob();

        }

        private void pbekleurun_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Resim Seç",
                Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedimgpath = openFileDialog1.FileName;

                pbekleurun.ImageLocation = selectedimgpath;
            }

        }

        private void btneklekat_Click(object sender, EventArgs e)
        {
            appsetings appsetings = new appsetings();
            Category c = new Category();
            c.Name = tbeklekatname.Text;
            c.Description = tbeklekataciklama.Text;
            string originalcatname = tbeklekatname.Text;
            string transformedcatname = ConvertToCamelCase(originalcatname);
            string imageName = transformedcatname + Path.GetExtension(selectedimgpath);
            string destinationPath = Path.Combine(appsetings.basepath, imageName);
            File.Copy(selectedimgpath, destinationPath, true);
            c.Categoryimg = Path.Combine(imageName);
            db.Categories.Add(c);
            db.SaveChanges();
            tbeklekatname.Text = "";
            tbeklekataciklama.Text = "";
            pbeklekaticon.Image = null;
            var categories = db.Categories.Select(x => new
            {
                x.CategoryID,
                x.Name,
                x.Description
            }).ToList();
            poisonDataGridView4.DataSource = categories;
            goodjob();


        }

        private void pbeklekaticon_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Resim Seç",
                Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedimgpath = openFileDialog1.FileName;

                pbeklekaticon.ImageLocation = selectedimgpath;
            }
        }

        private void btnekleuser_Click(object sender, EventArgs e)
        {
            var existingUser = db.Users.FirstOrDefault(x => x.Username == tbekleusername.Text);
            if (existingUser != null)
            {
                MessageBox.Show("Kullanıcı adı zaten kullanımda!");
            }
            else
            {
                User u = new User();
                u.Username = tbekleusername.Text;
                u.FirstName = tbeklefirstname.Text;
                u.LastName = tbeklelastname.Text;
                u.Email = tbekleemail.Text;
                u.Password = tbeklepassword.Text;
                u.IsActive = true;
                u.RegistrationDate = DateTime.Now;

                u.UserType = Convert.ToInt32(numekleusertype.Value);
                db.Users.Add(u);
                db.SaveChanges();
                tbekleusername.Text = "";
                tbeklefirstname.Text = "";
                tbeklelastname.Text = "";
                tbekleemail.Text = "";
                tbeklepassword.Text = "";
                numekleusertype.Value = 0;
                Address a = new Address();
                a.UserID = u.UserID;
                a.AddressLine1 = "adres yok";
                a.AddressLine2 = "adres yok";
                a.City = "adres yok";
                a.Country = "adres yok";
                a.PostalCode = "00000";
                a.IsActive = true;
                a.IsFavorite = true;
                db.Addresses.Add(a);
                db.SaveChanges();
                var users = db.Users.Select(x => new
                {
                    x.UserID,
                    x.Username,
                    Name = x.FirstName + " " + x.LastName,
                    x.Email
                }).ToList();
                poisonDataGridView5.DataSource = users;
                goodjob();
            }



        }

        private void btnsilurun_Click(object sender, EventArgs e)
        {
            int selectedpro = Convert.ToInt32(poisonDataGridView3.CurrentRow.Cells[0].Value);
            var product = db.Products.FirstOrDefault(x => x.ProductID == selectedpro);

            db.Products.Remove(product);
            db.SaveChanges();
            var products = db.Products.Where(x => x.IsActive).Select(x => new
            {
                x.ProductID,
                x.Name,
                x.Price,
                x.StockQuantity,
                Kategori = x.Category.Name,
            }).ToList();
            poisonDataGridView3.DataSource = products;
            goodjob();
            updatepage();
        }

        private void btnkatsil_Click(object sender, EventArgs e)
        {
            int selectedcat = Convert.ToInt32(poisonDataGridView4.CurrentRow.Cells[0].Value);
            var category = db.Categories.FirstOrDefault(x => x.CategoryID == selectedcat);
            db.Categories.Remove(category);
            db.SaveChanges();
            var categories = db.Categories.Select(x => new
            {
                x.CategoryID,
                x.Name,
                x.Description
            }).ToList();
            poisonDataGridView4.DataSource = categories;
            goodjob();


        }

        private void btnkulsil_Click(object sender, EventArgs e)
        {
            int selecteduser = Convert.ToInt32(poisonDataGridView5.CurrentRow.Cells[0].Value);
            var user = db.Users.FirstOrDefault(x => x.UserID == selecteduser);
            db.Users.Remove(user);
            db.SaveChanges();
            var users = db.Users.Select(x => new
            {
                x.UserID,
                x.Username,
                Name = x.FirstName + " " + x.LastName,
                x.Email
            }).ToList();
            poisonDataGridView5.DataSource = users;
            goodjob();

        }
    }

}
