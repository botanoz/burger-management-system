

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp
{
   
    public class creatmyorderlist:appsetings
    {
        AppDbContext _db;
        Panel _panel1;
        List<Order> sip;
        //kordinat
        int a1 = 337;
        int a2 = 181;
        int a3 = 540;
        int a4 = 22;
        int a5 = 645;
        int a6 = 13;
        int b1 = 15;
        int b2 = 5;
        int b3 = 92;
        int b4 = 47;
        int b5 = 35;
        int b6 = 56;
        int b7 = 101;
        int d1;
        int d2;

        bool clickedsiparis = false;
        int clickedorderID;
        int uid;



        public creatmyorderlist(Panel panel1, AppDbContext db,int uId)
        {
            _db = db;
            _panel1 = panel1;
            _userID = uId;
            uid = uId;
            sip = _db.Orders.Where(x => x.UserID == _userID).OrderByDescending(x => x.OrderDate).ToList();
            
            panel1.Controls.Clear();

            siparislistele();

        }

        private void siparislistele()
        {

             b1 = 15;
             b2 = 5;


            foreach (var item in sip)
            {

                ReaLTaiizor.Controls.ForeverLabel foreverLabel6 = new ReaLTaiizor.Controls.ForeverLabel();
                ReaLTaiizor.Controls.ForeverLabel foreverLabel7 = new ReaLTaiizor.Controls.ForeverLabel();
                ReaLTaiizor.Controls.ForeverLabel foreverLabel8 = new ReaLTaiizor.Controls.ForeverLabel();
                ReaLTaiizor.Controls.ForeverLabel foreverLabel9 = new ReaLTaiizor.Controls.ForeverLabel();
                ReaLTaiizor.Controls.ForeverLabel foreverLabel10 = new ReaLTaiizor.Controls.ForeverLabel();
                ReaLTaiizor.Controls.ForeverButton foreverButton2 = new ReaLTaiizor.Controls.ForeverButton();
               Color color;
                Color color1= Color.FromArgb(246, 246, 246);
                if (item.StatusID == 2)
                {

                    color = Color.FromArgb(255, 255, 100);
                    color1 = Color.FromArgb(147, 147, 147); 
                }
                else if (item.StatusID == 3)
                {

                    color = Color.FromArgb(255, 128, 128);
                }
                else
                {

                    color = Color.FromArgb(35, 168, 109);
                }
                _panel1.Controls.Add(foreverLabel6);
                _panel1.Controls.Add(foreverLabel7);
                _panel1.Controls.Add(foreverLabel8);
                _panel1.Controls.Add(foreverLabel9);
                _panel1.Controls.Add(foreverLabel10);
                _panel1.Controls.Add(foreverButton2);
                
                //_panel1.Controls.Add(panel6);
                // 
                // foreverLabel6
                // 
                foreverLabel6.AutoSize = true;
                foreverLabel6.BackColor = color;
                foreverLabel6.Font = new Font("Segoe UI", 8F);
                foreverLabel6.ForeColor = color1;
                foreverLabel6.Location = new Point(a1, b1);
                foreverLabel6.Name = "foreverLabel6";
                foreverLabel6.Size = new Size(114, 19);
                foreverLabel6.TabIndex = 12;
                foreverLabel6.Text = _db.OrderStatuses.FirstOrDefault(x=>x.StatusID==item.StatusID).Name;
                // 
                // foreverLabel7
                // 
                foreverLabel7.AutoSize = true;
                foreverLabel7.BackColor = color;
                foreverLabel7.Font = new Font("Segoe UI", 8F);
                foreverLabel7.ForeColor = color1;
                foreverLabel7.Location = new Point(a2, b1);
                foreverLabel7.Name = "foreverLabel7";
                foreverLabel7.Size = new Size(50, 19);
                foreverLabel7.TabIndex = 11;
                foreverLabel7.Text = "$"+item.TotalAmount.ToString();
                // 
                // foreverLabel8
                // 
                int ürüns = 0;
                foreach (var item2 in _db.OrderDetails.Where(x => x.OrderID == item.OrderID).ToList())
                {
                    ürüns += item2.Quantity;
                }
                foreverLabel8.AutoSize = true;
                foreverLabel8.BackColor = color;
                foreverLabel8.Font = new Font("Segoe UI", 8F);
                foreverLabel8.ForeColor = color1;
                foreverLabel8.Location = new Point(a3, b1);
                foreverLabel8.Name = "foreverLabel8";
                foreverLabel8.Size = new Size(42, 19);
                foreverLabel8.TabIndex = 10;
                foreverLabel8.Text = ürüns.ToString()+" Adet Ürün";
                
                // 
                // foreverLabel9
                // 
                foreverLabel9.AutoSize = true;
                foreverLabel9.BackColor = color;
                foreverLabel9.Font = new Font("Segoe UI", 8F);
                foreverLabel9.ForeColor = color1;
                foreverLabel9.Location = new Point(a4, b1);
                foreverLabel9.Name = "foreverLabel9";
                foreverLabel9.Size = new Size(79, 19);
                foreverLabel9.TabIndex = 9;
                foreverLabel9.Text = $"Sipariş No : {item.OrderID}";
                // 
                // foreverLabel10
                // 
                foreverLabel10.AutoSize = true;
                foreverLabel10.BackColor = color;
                foreverLabel10.Font = new Font("Segoe UI", 8F);
                foreverLabel10.ForeColor = color1;
                foreverLabel10.Location = new Point(a5, b1);
                foreverLabel10.Name = "foreverLabel10";
                foreverLabel10.Size = new Size(108, 19);
                foreverLabel10.TabIndex = 8;
                foreverLabel10.Text = item.OrderDate.ToString();
                // 
                // foreverButton2
                // 
               
                foreverButton2.BackColor = Color.Transparent;
                foreverButton2.BaseColor = color;
                foreverButton2.Font = new Font("Segoe UI", 12F);
                foreverButton2.Location = new Point(a6, b2);
                foreverButton2.Name = b1.ToString();
                foreverButton2.Rounded = false;
                foreverButton2.Size = new Size(767, 38);
                foreverButton2.TabIndex = 7;
                foreverButton2.TextColor = Color.FromArgb(243, 243, 243);
                foreverButton2.Tag = item.OrderID.ToString();
                foreverButton2.Click += new EventHandler(siparisdetay);

                if (clickedorderID==item.OrderID)
                {
                    siparisdetayi(foreverButton2);
                    b1 += d2+5;
                    b2 += d2+5;
                }

                b1 +=45;
               b2 +=45;
            }
        }

        private void siparisdetay(object? sender, EventArgs e)
        {
            var orderID = ((ReaLTaiizor.Controls.ForeverButton)sender);
            _panel1.Controls.Clear();
            clickedorderID = Convert.ToInt32(orderID.Tag);
            siparislistele();
            



        }

        private void siparisdetayi(ReaLTaiizor.Controls.ForeverButton? orderID)
        {
            int bkac = Convert.ToInt32(orderID.Name);
            clickedorderID = Convert.ToInt32(orderID.Tag);
            b3 = 84+bkac ;
            b4 = 39 +bkac;
            b5 = 27 +bkac;
            b6 = 48 + bkac ;
            b7 = 92 +bkac ;
            
            
          

            
            ReaLTaiizor.Controls.ForeverLabel foreverLabel14 = new ReaLTaiizor.Controls.ForeverLabel();
            ReaLTaiizor.Controls.ForeverLabel foreverLabel15 = new ReaLTaiizor.Controls.ForeverLabel();
            ReaLTaiizor.Controls.ForeverLabel foreverLabel16 = new ReaLTaiizor.Controls.ForeverLabel();
          
           
            _panel1.Controls.Add(foreverLabel14);
            _panel1.Controls.Add(foreverLabel15);
            _panel1.Controls.Add(foreverLabel16);

          
            
            

            var siparisdetay = _db.OrderDetails.Where(x => x.OrderID == clickedorderID).ToList();
             d1 = _db.OrderDetails.Count(x=>x.OrderID==clickedorderID);
            if (d1 > 1) { 
             d2 = (38 * d1)+65;
            }
            else { 
            d2 = 70;
            }
           
            foreach (var item in siparisdetay)
            {
               
                ReaLTaiizor.Controls.ForeverLabel foreverLabel11 = new ReaLTaiizor.Controls.ForeverLabel();
                ReaLTaiizor.Controls.ForeverLabel foreverLabel12 = new ReaLTaiizor.Controls.ForeverLabel();
                ReaLTaiizor.Controls.ForeverLabel foreverLabel13 = new ReaLTaiizor.Controls.ForeverLabel();
                ReaLTaiizor.Controls.ForeverTextBox foreverTextBox2 = new ReaLTaiizor.Controls.ForeverTextBox();
                _panel1.Controls.Add(foreverLabel11);
                _panel1.Controls.Add(foreverLabel12);
                _panel1.Controls.Add(foreverLabel13);
                _panel1.Controls.Add(foreverTextBox2);


                // 
                // foreverTextBox2
                // 
                foreverTextBox2.BackColor = Color.Transparent;
                foreverTextBox2.BaseColor = Color.FromArgb(45, 47, 49);
                foreverTextBox2.BorderColor = Color.FromArgb(35, 168, 109);
                foreverTextBox2.FocusOnHover = false;
                foreverTextBox2.ForeColor = Color.FromArgb(192, 192, 192);
                foreverTextBox2.Location = new Point(22, b4);
                foreverTextBox2.MaxLength = 32767;
                foreverTextBox2.Multiline = true;
                foreverTextBox2.Name = "foreverTextBox2";
                foreverTextBox2.ReadOnly = false;
                foreverTextBox2.Size = new Size(750, 38);
                foreverTextBox2.TabIndex = 0;
                foreverTextBox2.TextAlign = HorizontalAlignment.Left;
                foreverTextBox2.UseSystemPasswordChar = false;
                foreverTextBox2.Enabled = false;
               
                // 
                // foreverLabel11
                // 
                foreverLabel11.AutoSize = true;
                foreverLabel11.BackColor = Color.FromArgb(45, 47, 49);
                foreverLabel11.Font = new Font("Segoe UI", 8F);
                foreverLabel11.ForeColor = Color.LightGray;
                foreverLabel11.Location = new Point(313, b6);
                foreverLabel11.Name = "foreverLabel11";
                foreverLabel11.Size = new Size(157, 19);
                foreverLabel11.TabIndex = 14;
                foreverLabel11.Text = _db.Products.FirstOrDefault(x=>x.ProductID==item.ProductID).Name;
                // 
                // foreverLabel12
                // 
                foreverLabel12.AutoSize = true;
                foreverLabel12.BackColor = Color.FromArgb(45, 47, 49);
                foreverLabel12.Font = new Font("Segoe UI", 8F);
                foreverLabel12.ForeColor = Color.LightGray;
                foreverLabel12.Location = new Point(710, b6);
                foreverLabel12.Name = "foreverLabel12";
                foreverLabel12.Size = new Size(42, 19);
                foreverLabel12.TabIndex = 15;
                foreverLabel12.Text ="$"+item.Price;
                // 
                // foreverLabel13
                // 
                foreverLabel13.AutoSize = true;
                foreverLabel13.BackColor = Color.FromArgb(45, 47, 49);
                foreverLabel13.Font = new Font("Segoe UI", 8F);
                foreverLabel13.ForeColor = Color.LightGray;
                foreverLabel13.Location = new Point(38, b6);
                foreverLabel13.Name = "foreverLabel13";
                foreverLabel13.Size = new Size(40, 19);
                foreverLabel13.TabIndex = 16;
                foreverLabel13.Text = item.Quantity+" Adet";
                b4 += 45;
                b6 += 45;
            }
            ReaLTaiizor.Controls.ForeverTextBox foreverTextBox1 = new ReaLTaiizor.Controls.ForeverTextBox();
            // 
            // foreverTextBox1
            // 
            foreverTextBox1.BackColor = Color.Transparent;
            foreverTextBox1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverTextBox1.BorderColor = Color.FromArgb(35, 168, 109);
            foreverTextBox1.FocusOnHover = false;
            foreverTextBox1.ForeColor = Color.FromArgb(192, 192, 192);
            foreverTextBox1.Location = new Point(13, b5);
            foreverTextBox1.MaxLength = 32767;
            foreverTextBox1.Multiline = true;
            foreverTextBox1.Name = "foreverTextBox1";
            foreverTextBox1.ReadOnly = false;
            foreverTextBox1.Size = new Size(767, d2);
            foreverTextBox1.TabIndex = 0;
            foreverTextBox1.TextAlign = HorizontalAlignment.Left;
            foreverTextBox1.UseSystemPasswordChar = false;
            foreverTextBox1.Enabled = false;
            _panel1.Controls.Add(foreverTextBox1);


        }
    }

}
