


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerApp
{
    public class creatadresler
    {
        Panel panel1;
        AppDbContext db;
        int adressdid;
        bool newadress = false;
        int uid;
        public creatadresler(Panel _panel1, AppDbContext _db,int uId)
        {
            appsetings aps = new appsetings();
            aps._userID = uId;
            uid = uId;
            panel1 = _panel1;
            db = _db;
            panel1.Controls.Cast<Control>().ToList().ForEach(x => x.Dispose());

            int e1 = 111;
            int e2 = 143;
            int e4 = 103;
            int e5 = 63;
            int e6 = 125;
            int e8 = 54;

            foreach (var item in db.Addresses.Where(x => x.UserID == aps._userID).ToList())
            {

                ReaLTaiizor.Controls.ForeverTextBox foreverTextBox1 = new ReaLTaiizor.Controls.ForeverTextBox();
                ReaLTaiizor.Controls.LostAcceptButton lostAcceptButton1 = new ReaLTaiizor.Controls.LostAcceptButton();
                ReaLTaiizor.Controls.LostAcceptButton lostAcceptButton2 = new ReaLTaiizor.Controls.LostAcceptButton();
                ReaLTaiizor.Controls.ForeverTextBox foreverTextBox2 = new ReaLTaiizor.Controls.ForeverTextBox();
                ReaLTaiizor.Controls.ForeverTextBox foreverTextBox3 = new ReaLTaiizor.Controls.ForeverTextBox();
                ReaLTaiizor.Controls.ForeverTextBox foreverTextBox4 = new ReaLTaiizor.Controls.ForeverTextBox();
                ReaLTaiizor.Controls.ForeverTextBox foreverTextBox5 = new ReaLTaiizor.Controls.ForeverTextBox();
                ReaLTaiizor.Controls.AirCheckBox airCheckBox1 = new ReaLTaiizor.Controls.AirCheckBox();
                ReaLTaiizor.Controls.LostCancelButton lostCancelButton2 = new ReaLTaiizor.Controls.LostCancelButton();

                panel1.Controls.Add(lostAcceptButton1);
                panel1.Controls.Add(lostAcceptButton2);
                panel1.Controls.Add(foreverTextBox2);
                panel1.Controls.Add(foreverTextBox3);
                panel1.Controls.Add(foreverTextBox4);
                panel1.Controls.Add(foreverTextBox5);
                panel1.Controls.Add(airCheckBox1);
                panel1.Controls.Add(foreverTextBox1);
                panel1.Controls.Add(lostCancelButton2);

                lostCancelButton2.BackColor = Color.Crimson;
                lostCancelButton2.Font = new Font("Segoe UI", 9F);
                lostCancelButton2.ForeColor = Color.White;
                lostCancelButton2.HoverColor = Color.IndianRed;
                lostCancelButton2.Image = null;
                lostCancelButton2.Location = new Point(8, 8);
                lostCancelButton2.Name = "lostCancelButton2";
                lostCancelButton2.Size = new Size(151, 34);
                lostCancelButton2.TabIndex = 29;
                lostCancelButton2.Text = "Yeni Adres Ekle";
                lostCancelButton2.Click += new EventHandler(yeniadres);

                // 
                // airCheckBox1
                // 
                airCheckBox1.Checked = item.IsFavorite;
                airCheckBox1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8=";
                airCheckBox1.Enabled = false;
                airCheckBox1.Font = new Font("Segoe UI", 9F);
                airCheckBox1.Image = null;
                airCheckBox1.Location = new Point(632, e1);
                airCheckBox1.Name = "airCheckBox1";
                airCheckBox1.NoRounding = false;
                airCheckBox1.Size = new Size(17, 17);
                airCheckBox1.TabIndex = 7;
                airCheckBox1.Transparent = false;

                // 
                // foreverTextBox5
                // 
                foreverTextBox5.BackColor = Color.Transparent;
                foreverTextBox5.BaseColor = Color.FromArgb(45, 47, 49);
                foreverTextBox5.BorderColor = Color.FromArgb(35, 168, 109);
                foreverTextBox5.FocusOnHover = false;
                foreverTextBox5.ForeColor = Color.FromArgb(192, 192, 192);
                foreverTextBox5.Location = new Point(350, e2);
                foreverTextBox5.MaxLength = 32767;
                foreverTextBox5.Multiline = false;
                foreverTextBox5.Name = "foreverTextBox5";
                foreverTextBox5.ReadOnly = false;
                foreverTextBox5.Size = new Size(263, 34);
                foreverTextBox5.TabIndex = 6;
                foreverTextBox5.Text = item.Country;
                foreverTextBox5.TextAlign = HorizontalAlignment.Left;
                foreverTextBox5.UseSystemPasswordChar = false;
                foreverTextBox5.Enabled = false;
                // 
                // foreverTextBox4
                // 
                foreverTextBox4.BackColor = Color.Transparent;
                foreverTextBox4.BaseColor = Color.FromArgb(45, 47, 49);
                foreverTextBox4.BorderColor = Color.FromArgb(35, 168, 109);
                foreverTextBox4.FocusOnHover = false;
                foreverTextBox4.ForeColor = Color.FromArgb(192, 192, 192);
                foreverTextBox4.Location = new Point(63, e2);
                foreverTextBox4.MaxLength = 32767;
                foreverTextBox4.Multiline = false;
                foreverTextBox4.Name = "foreverTextBox4";
                foreverTextBox4.ReadOnly = false;
                foreverTextBox4.Size = new Size(281, 34);
                foreverTextBox4.TabIndex = 5;
                foreverTextBox4.Text = item.City;
                foreverTextBox4.TextAlign = HorizontalAlignment.Left;
                foreverTextBox4.UseSystemPasswordChar = false;
                foreverTextBox4.Enabled = false;
                // 
                // foreverTextBox3
                // 
                foreverTextBox3.BackColor = Color.Transparent;
                foreverTextBox3.BaseColor = Color.FromArgb(45, 47, 49);
                foreverTextBox3.BorderColor = Color.FromArgb(35, 168, 109);
                foreverTextBox3.FocusOnHover = false;
                foreverTextBox3.ForeColor = Color.FromArgb(192, 192, 192);
                foreverTextBox3.Location = new Point(63, e4);
                foreverTextBox3.MaxLength = 32767;
                foreverTextBox3.Multiline = false;
                foreverTextBox3.Name = "foreverTextBox3";
                foreverTextBox3.ReadOnly = false;
                foreverTextBox3.Size = new Size(550, 34);
                foreverTextBox3.TabIndex = 4;
                foreverTextBox3.Text = item.AddressLine2;
                foreverTextBox3.TextAlign = HorizontalAlignment.Left;
                foreverTextBox3.UseSystemPasswordChar = false;
                foreverTextBox3.Enabled = false;
                // 
                // foreverTextBox2
                // 
                foreverTextBox2.BackColor = Color.Transparent;
                foreverTextBox2.BaseColor = Color.FromArgb(45, 47, 49);
                foreverTextBox2.BorderColor = Color.FromArgb(35, 168, 109);
                foreverTextBox2.FocusOnHover = false;
                foreverTextBox2.ForeColor = Color.FromArgb(192, 192, 192);
                foreverTextBox2.Location = new Point(63, e5);
                foreverTextBox2.MaxLength = 32767;
                foreverTextBox2.Multiline = false;
                foreverTextBox2.Name = "foreverTextBox2";
                foreverTextBox2.ReadOnly = false;
                foreverTextBox2.Size = new Size(550, 34);
                foreverTextBox2.TabIndex = 3;
                foreverTextBox2.Text = item.AddressLine1;
                foreverTextBox2.TextAlign = HorizontalAlignment.Left;
                foreverTextBox2.UseSystemPasswordChar = false;
                foreverTextBox2.Enabled = false;
                // 
                // lostAcceptButton2
                // 
                lostAcceptButton2.BackColor = Color.SeaGreen;
                lostAcceptButton2.Font = new Font("Segoe UI", 16F);
                lostAcceptButton2.ForeColor = Color.White;
                lostAcceptButton2.HoverColor = Color.ForestGreen;
                lostAcceptButton2.Image = null;
                lostAcceptButton2.Location = new Point(676, e6);
                lostAcceptButton2.Name = "lostAcceptButton2";
                lostAcceptButton2.Size = new Size(60, 44);
                lostAcceptButton2.TabIndex = 2;
                lostAcceptButton2.Text = "X";
                lostAcceptButton2.Tag = item.AddressID;
                lostAcceptButton2.Click += new EventHandler(deleteadress);
                // 
                // lostAcceptButton1
                // 
                lostAcceptButton1.BackColor = Color.SeaGreen;
                lostAcceptButton1.Font = new Font("Segoe UI", 9F);
                lostAcceptButton1.ForeColor = Color.White;
                lostAcceptButton1.HoverColor = Color.ForestGreen;
                lostAcceptButton1.Image = null;
                lostAcceptButton1.Location = new Point(676, e5);
                lostAcceptButton1.Name = "lostAcceptButton1";
                lostAcceptButton1.Size = new Size(60, 44);
                lostAcceptButton1.TabIndex = 1;
                lostAcceptButton1.Text = "Edit";
                lostAcceptButton1.Tag = item.AddressID;
                lostAcceptButton1.Click += new EventHandler(editadress);
                // 
                // foreverTextBox1
                // 
                foreverTextBox1.BackColor = Color.Transparent;
                foreverTextBox1.BaseColor = Color.FromArgb(45, 47, 49);
                foreverTextBox1.BorderColor = Color.FromArgb(35, 168, 109);
                foreverTextBox1.Enabled = false;
                foreverTextBox1.FocusOnHover = false;
                foreverTextBox1.ForeColor = Color.FromArgb(192, 192, 192);
                foreverTextBox1.Location = new Point(54, e8);
                foreverTextBox1.MaxLength = 32767;
                foreverTextBox1.Multiline = true;
                foreverTextBox1.Name = "foreverTextBox1";
                foreverTextBox1.ReadOnly = false;
                foreverTextBox1.Size = new Size(692, 131);
                foreverTextBox1.TabIndex = 0;
                foreverTextBox1.TextAlign = HorizontalAlignment.Left;
                foreverTextBox1.UseSystemPasswordChar = false;
                e1 += 140;
                e2 += 140;
                e4 += 140;
                e5 += 140;
                e6 += 140;
                e8 += 140;
            }
        }

        private void yeniadres(object? sender, EventArgs e)
        {
            newadress = true;
            padress();

        }

        private void deleteadress(object? sender, EventArgs e)
        {
            appsetings aps = new appsetings();
            aps._userID = uid;
            int adressayisi = db.Addresses.Where(x => x.UserID == aps._userID).Count();
            
            if (adressayisi > 1)
            {
              
                int selectedadressid = Convert.ToInt32((sender as ReaLTaiizor.Controls.LostAcceptButton).Tag);
                db.Addresses.Remove(db.Addresses.FirstOrDefault(x=>x.AddressID== selectedadressid));
                db.SaveChanges();
                db.Addresses.FirstOrDefault(x => x.UserID == aps._userID).IsFavorite = true;
                db.SaveChanges();
                creatadresler ts = new creatadresler(panel1, db,uid);
                
            }
            else
            {
                MessageBox.Show("Kayıtlı Son Adresini Silemezsin!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        ReaLTaiizor.Controls.ForeverTextBox foreverTextBox11 = new ReaLTaiizor.Controls.ForeverTextBox();
        ReaLTaiizor.Controls.CrownTextBox crownTextBox11 = new ReaLTaiizor.Controls.CrownTextBox();
        ReaLTaiizor.Controls.CrownTextBox crownTextBox21 = new ReaLTaiizor.Controls.CrownTextBox();
        ReaLTaiizor.Controls.ForeverTextBox foreverTextBox21 = new ReaLTaiizor.Controls.ForeverTextBox();
        ReaLTaiizor.Controls.CrownTextBox crownTextBox31 = new ReaLTaiizor.Controls.CrownTextBox();
        ReaLTaiizor.Controls.ForeverTextBox foreverTextBox31 = new ReaLTaiizor.Controls.ForeverTextBox();
        ReaLTaiizor.Controls.CrownTextBox crownTextBox41 = new ReaLTaiizor.Controls.CrownTextBox();
        ReaLTaiizor.Controls.ForeverTextBox foreverTextBox41 = new ReaLTaiizor.Controls.ForeverTextBox();
        ReaLTaiizor.Controls.LostCheckBox lostCheckBox11 = new ReaLTaiizor.Controls.LostCheckBox();
        ReaLTaiizor.Controls.LostCancelButton lostCancelButton11 = new ReaLTaiizor.Controls.LostCancelButton();
        private void editadress(object? sender, EventArgs e)
        {
            newadress = false;
            adressdid = Convert.ToInt32((sender as ReaLTaiizor.Controls.LostAcceptButton).Tag);
            padress();
         
        }

        public void padress()
        {
            string adressline1 = "";
            string adressline2 = "";
            string city = "";
            string country = "";
            bool   isfavorite = false;
            appsetings aps = new appsetings();
            aps._userID = uid;

            panel1.Controls.Cast<Control>().ToList().ForEach(x => x.Dispose());
            panel1.Controls.Add(crownTextBox11);
            panel1.Controls.Add(foreverTextBox11);
            panel1.Controls.Add(crownTextBox21);
            panel1.Controls.Add(foreverTextBox21);
            panel1.Controls.Add(crownTextBox31);
            panel1.Controls.Add(foreverTextBox31);
            panel1.Controls.Add(crownTextBox41);
            panel1.Controls.Add(foreverTextBox41);
            panel1.Controls.Add(lostCheckBox11);
            panel1.Controls.Add(lostCancelButton11);

            var _ad = db.Addresses.FirstOrDefault(x => x.UserID == aps._userID && x.IsFavorite == true);
            if(_ad == null) { newadress = true; }
            if (newadress == false)
            {
                var adress = db.Addresses.FirstOrDefault(x => x.AddressID == adressdid);
                adressline1 = adress.AddressLine1;
                adressline2 = adress.AddressLine2;
                city = adress.City;
                country = adress.Country;
                isfavorite = adress.IsFavorite;

            }
            else
            {
                adressline1 = "";
                adressline2 = "";
                city = "";
                country = "";
                isfavorite = false;
            }
           

            // 
            // foreverTextBox1
            // 
            foreverTextBox11.BackColor = Color.Transparent;
            foreverTextBox11.BaseColor = Color.FromArgb(45, 47, 49);
            foreverTextBox11.BorderColor = Color.FromArgb(35, 168, 109);
            foreverTextBox11.FocusOnHover = false;
            foreverTextBox11.ForeColor = Color.FromArgb(192, 192, 192);
            foreverTextBox11.Location = new Point(70, 47);
            foreverTextBox11.MaxLength = 32767;
            foreverTextBox11.Multiline = true;
            foreverTextBox11.Name = "foreverTextBox1";
            foreverTextBox11.ReadOnly = false;
            foreverTextBox11.Size = new Size(601, 80);
            foreverTextBox11.TabIndex = 0;
            foreverTextBox11.Text = "* Adres Line 1 (100)";
            foreverTextBox11.TextAlign = HorizontalAlignment.Left;
            foreverTextBox11.Enabled = false;
            foreverTextBox11.UseSystemPasswordChar = false;
            // 
            // crownTextBox1
            // 
            crownTextBox11.BackColor = Color.FromArgb(69, 73, 74);
            crownTextBox11.BorderStyle = BorderStyle.FixedSingle;
            crownTextBox11.ForeColor = Color.FromArgb(220, 220, 220);
            crownTextBox11.Location = new Point(79, 79);
            crownTextBox11.Multiline = true;
            crownTextBox11.Name = "crownTextBox1";
            crownTextBox11.Size = new Size(586, 41);
            crownTextBox11.TabIndex = 1;
            crownTextBox11.Text = adressline1;
            // 
            // crownTextBox2
            // 
            crownTextBox21.BackColor = Color.FromArgb(69, 73, 74);
            crownTextBox21.BorderStyle = BorderStyle.FixedSingle;
            crownTextBox21.ForeColor = Color.FromArgb(220, 220, 220);
            crownTextBox21.Location = new Point(79, 180);
            crownTextBox21.Multiline = true;
            crownTextBox21.Name = "crownTextBox2";
            crownTextBox21.Size = new Size(586, 43);
            crownTextBox21.TabIndex = 3;
            crownTextBox21.Text = adressline2;
            // 
            // foreverTextBox2
            // 
            foreverTextBox21.BackColor = Color.Transparent;
            foreverTextBox21.BaseColor = Color.FromArgb(45, 47, 49);
            foreverTextBox21.BorderColor = Color.FromArgb(35, 168, 109);
            foreverTextBox21.FocusOnHover = false;
            foreverTextBox21.ForeColor = Color.FromArgb(192, 192, 192);
            foreverTextBox21.Location = new Point(70, 148);
            foreverTextBox21.MaxLength = 32767;
            foreverTextBox21.Multiline = true;
            foreverTextBox21.Name = "foreverTextBox2";
            foreverTextBox21.ReadOnly = false;
            foreverTextBox21.Size = new Size(601, 82);
            foreverTextBox21.TabIndex = 2;
            foreverTextBox21.Text = "Adres Line 2 (100)";
            foreverTextBox21.TextAlign = HorizontalAlignment.Left;
            foreverTextBox21.Enabled = false;
            foreverTextBox21.UseSystemPasswordChar = false;
            // 
            // crownTextBox3
            // 
            crownTextBox31.BackColor = Color.FromArgb(69, 73, 74);
            crownTextBox31.BorderStyle = BorderStyle.FixedSingle;
            crownTextBox31.ForeColor = Color.FromArgb(220, 220, 220);
            crownTextBox31.Location = new Point(79, 278);
            crownTextBox31.Name = "crownTextBox3";
            crownTextBox31.Size = new Size(586, 27);
            crownTextBox31.TabIndex = 5;
            crownTextBox31.Text = city;
            // 
            // foreverTextBox3
            // 
            foreverTextBox31.BackColor = Color.Transparent;
            foreverTextBox31.BaseColor = Color.FromArgb(45, 47, 49);
            foreverTextBox31.BorderColor = Color.FromArgb(35, 168, 109);
            foreverTextBox31.FocusOnHover = false;
            foreverTextBox31.ForeColor = Color.FromArgb(192, 192, 192);
            foreverTextBox31.Location = new Point(70, 246);
            foreverTextBox31.MaxLength = 32767;
            foreverTextBox31.Multiline = true;
            foreverTextBox31.Name = "foreverTextBox3";
            foreverTextBox31.ReadOnly = false;
            foreverTextBox31.Size = new Size(601, 67);
            foreverTextBox31.TabIndex = 4;
            foreverTextBox31.Text = "*İlçe";
            foreverTextBox31.TextAlign = HorizontalAlignment.Left;
            foreverTextBox31.Enabled = false;
            foreverTextBox31.UseSystemPasswordChar = false;

            // 
            // crownTextBox4
            // 
            crownTextBox41.BackColor = Color.FromArgb(69, 73, 74);
            crownTextBox41.BorderStyle = BorderStyle.FixedSingle;
            crownTextBox41.ForeColor = Color.FromArgb(220, 220, 220);
            crownTextBox41.Location = new Point(79, 368);
            crownTextBox41.Name = "crownTextBox4";
            crownTextBox41.Size = new Size(586, 27);
            crownTextBox41.TabIndex = 7;
            crownTextBox41.Text = country;
            // 
            // foreverTextBox4
            // 
            foreverTextBox41.BackColor = Color.Transparent;
            foreverTextBox41.BaseColor = Color.FromArgb(45, 47, 49);
            foreverTextBox41.BorderColor = Color.FromArgb(35, 168, 109);
            foreverTextBox41.FocusOnHover = false;
            foreverTextBox41.ForeColor = Color.FromArgb(192, 192, 192);
            foreverTextBox41.Location = new Point(70, 336);
            foreverTextBox41.MaxLength = 32767;
            foreverTextBox41.Multiline = true;
            foreverTextBox41.Name = "foreverTextBox4";
            foreverTextBox41.ReadOnly = false;
            foreverTextBox41.Size = new Size(601, 67);
            foreverTextBox41.TabIndex = 6;
            foreverTextBox41.Text = "*İl";
            foreverTextBox41.TextAlign = HorizontalAlignment.Left;
            foreverTextBox41.Enabled = false;
            foreverTextBox41.UseSystemPasswordChar = false;
            // 
            // lostCheckBox1
            // 
            lostCheckBox11.BackColor = Color.FromArgb(45, 45, 48);
            lostCheckBox11.Checked = isfavorite;
            lostCheckBox11.CheckedColor = Color.White;
            lostCheckBox11.Font = new Font("Segoe UI", 9F);
            lostCheckBox11.ForeColor = Color.White;
            lostCheckBox11.Location = new Point(502, 421);
            lostCheckBox11.Name = "lostCheckBox1";
            lostCheckBox11.Size = new Size(169, 36);
            lostCheckBox11.TabIndex = 8;
            lostCheckBox11.Text = "Favori Olarak Seç";
            // 
            // lostCancelButton1
            // 
            lostCancelButton11.BackColor = Color.Crimson;
            lostCancelButton11.Font = new Font("Segoe UI", 9F);
            lostCancelButton11.ForeColor = Color.White;
            lostCancelButton11.HoverColor = Color.IndianRed;
            lostCancelButton11.Image = null;
            lostCancelButton11.Location = new Point(279, 507);
            lostCancelButton11.Name = "lostCancelButton1";
            lostCancelButton11.Size = new Size(185, 34);
            lostCancelButton11.TabIndex = 15;
            lostCancelButton11.Text = "Kaydet";
            lostCancelButton11.Click += new EventHandler(kaydet);
        }

        private void kaydet(object? sender, EventArgs e)
        {
            appsetings aps = new appsetings();
            aps._userID = uid;
            AppDbContext _dbb = new AppDbContext();
            if (newadress == true)
            {
                var _ad = _dbb.Addresses.FirstOrDefault(x => x.UserID == aps._userID && x.IsFavorite == true);
                if (lostCheckBox11.Checked == true && _ad !=null)
                {
                    _dbb.Addresses.Where(x => x.UserID == aps._userID).ToList().ForEach(x => x.IsFavorite = false);
                    _dbb.SaveChanges();
                }
                
                Address ad = new Address();
                ad.AddressLine1 = crownTextBox11.Text;
                ad.AddressLine2 = crownTextBox21.Text;
                ad.City = crownTextBox31.Text;
                ad.Country = crownTextBox41.Text;
                ad.IsFavorite = lostCheckBox11.Checked;
                ad.UserID = aps._userID;
                ad.PostalCode = "0000";
                ad.IsActive = true;
                _dbb.Addresses.Add(ad);
                _dbb.SaveChanges();
                newadress = false;
                
                creatadresler br = new creatadresler(panel1, db, uid);
            }
            else {
                if (lostCheckBox11.Checked == true)
                {
                    db.Addresses.Where(x => x.UserID == aps._userID).ToList().ForEach(x => x.IsFavorite = false);
                    db.SaveChanges();
                }
            db.Addresses.Find(adressdid).AddressLine1 = crownTextBox11.Text;
            db.Addresses.Find(adressdid).AddressLine2 = crownTextBox21.Text;
            db.Addresses.Find(adressdid).City = crownTextBox31.Text;
            db.Addresses.Find(adressdid).Country = crownTextBox41.Text;
            db.Addresses.Find(adressdid).IsFavorite = lostCheckBox11.Checked;
            db.SaveChanges();            
            creatadresler br = new creatadresler(panel1, db, uid);
            }

        }
    }
}
