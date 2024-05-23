using static AntdUI.Modal;

namespace BurgerApp
{
    public class creatproduct : appsetings
    {
        int _kategori;
        

        decimal price ;
        
        int selectedbtn;
        decimal total;
        AppDbContext _db = new AppDbContext();



        public creatproduct(Panel panel1, int kategoriID ,AppDbContext db)
        {
            _kategori = kategoriID;
            clearpage(panel1);

            _db = db;
            //kordinat
            int s = 12;
            int m = 12;
            int d = 0;

            foreach (var item in db.Products.Where(x => x.CategoryID == _kategori).ToList())
            {
                if (d >= 3)
                {
                    m += 184;
                    d = 0;
                    s = 12;
                }
                

                Image bgi = Image.FromFile(string.Concat(basepath, item.Image));
                int height = (int)(bgi.Height * 0.35);
                int width = (int)(bgi.Width * 0.35);
                
                var backgroundImage = new Bitmap(bgi,width,height);
                
                price = item.Price;
                Button btn = new Button();
                
                //Color.FromArgb(28, 34, 38);Color.FromArgb(21, 25, 28);
                btn.BackgroundImage = backgroundImage;
                btn.BackgroundImageLayout = ImageLayout.Center;
                btn.Font = new Font("Mongolian Baiti", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
                btn.ForeColor = Color.White;
                btn.Location = new Point(s, m);
                btn.Name = Convert.ToString(item.ProductID);
                btn.Size = new Size(253, 178);
                btn.TabIndex = 1;
                btn.TextAlign = ContentAlignment.TopCenter;
                
                if (item.IsSelected==true)
                {
                    btn.BackColor = Color.FromArgb(21, 25, 28);
                    btn.FlatAppearance.BorderSize = 1;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(220, 20, 60);
                }
                else
                {
                    btn.BackColor = Color.FromArgb(28, 34, 38);
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(28, 34, 38);
                }

                // Butonun textini ürün adı olarak ayarla
                btn.Text = item.Name;
                

                // Ürün fiyatı için Label oluşturulması ve konumlandırılması
                Label lblProductPrice = new Label();
                lblProductPrice.Text ='$'+ item.Price.ToString();
                lblProductPrice.Font = new Font("Mongolian Baiti", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
                lblProductPrice.ForeColor = Color.White;
                lblProductPrice.Location = new Point(s + 180, m + 158); // Sağ alt köşeye hizalama
                lblProductPrice.Size = new Size(63, 20);
                lblProductPrice.TextAlign = ContentAlignment.BottomRight;
                lblProductPrice.BackColor = Color.FromArgb(220, 20, 60);
                
                panel1.Controls.Add(lblProductPrice);

                btn.UseVisualStyleBackColor = false;
                btn.Click += new EventHandler(sepetislemi);
               
                btn.FlatStyle = FlatStyle.Flat;
               
                btn.Tag = item.Price;
               
                panel1.Controls.Add(btn);
                s += 259;
                d++;
            }

        }

       

        private void clearpage(Panel panel1)
        {
            
            panel1.Controls.Clear();
           
            
        }

        public void sepetislemi(object? sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int productid = Convert.ToInt32(clickedButton.Name);
            if (_db.Products.Find(productid).IsSelected == true)
            {
               
                clickedButton.BackColor = Color.FromArgb(28, 34, 38);
                clickedButton.FlatAppearance.BorderSize = 0;
                clickedButton.FlatAppearance.BorderColor = Color.FromArgb(28, 34, 38);
                
                _db.Products.Find(1).CartTotal-=_db.Products.Find(productid).Price *_db.Products.Find(productid).SelectedQuantity;
                _db.Products.Find(productid).SelectedQuantity = 0;
                _db.Products.Find(productid).IsSelected = false;
               

                sepetguncelle();
                
            }
            else
            {


                clickedButton.BackColor = Color.FromArgb(21, 25, 28);
                clickedButton.FlatAppearance.BorderSize = 1;
                clickedButton.FlatAppearance.BorderColor = Color.FromArgb(220, 20, 60);
                _db.Products.Find(productid).IsSelected = true;
                _db.Products.Find(productid).SelectedQuantity = 1;
                _db.Products.Find(1).CartTotal += _db.Products.Find(productid).Price * _db.Products.Find(productid).SelectedQuantity;
                
               
                
                
                sepetguncelle();

            }



        }

        private void sepetguncelle()
        {
            if (_db.Products.Find(1).CartTotal==0)
            {
                _lsepet.Text = sepetmsg;
            }
            else
            {
                _lsepet.Text = sepettotal + _db.Products.Find(1).CartTotal.ToString();
            }
        }

        ReaLTaiizor.Controls.SpaceLabel _lsepet;
        internal void sptgncl(ReaLTaiizor.Controls.SpaceLabel lsepet)
        {
            _lsepet = lsepet;

        }
    }
}
