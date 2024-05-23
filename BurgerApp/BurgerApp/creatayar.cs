


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerApp
{
    public class creatayar
    {
        ReaLTaiizor.Controls.Panel panel4 = new ReaLTaiizor.Controls.Panel();
        ReaLTaiizor.Controls.Panel panel5 = new ReaLTaiizor.Controls.Panel();
        ReaLTaiizor.Controls.DungeonToggleButton dungeonToggleButton1 = new ReaLTaiizor.Controls.DungeonToggleButton();
        ReaLTaiizor.Controls.ForeverTextBox foreverTextBox6 = new ReaLTaiizor.Controls.ForeverTextBox();
        ReaLTaiizor.Controls.CrownTextBox crownTextBox5 = new ReaLTaiizor.Controls.CrownTextBox();
        ReaLTaiizor.Controls.ForeverTextBox foreverTextBox5 = new ReaLTaiizor.Controls.ForeverTextBox();
        ReaLTaiizor.Controls.CrownTextBox crownTextBox4 = new ReaLTaiizor.Controls.CrownTextBox();
        ReaLTaiizor.Controls.ForeverTextBox foreverTextBox4 = new ReaLTaiizor.Controls.ForeverTextBox();
        ReaLTaiizor.Controls.CrownTextBox crownTextBox3 = new ReaLTaiizor.Controls.CrownTextBox();
        ReaLTaiizor.Controls.ForeverTextBox foreverTextBox3 = new ReaLTaiizor.Controls.ForeverTextBox();
        ReaLTaiizor.Controls.CrownTextBox crownTextBox2 = new ReaLTaiizor.Controls.CrownTextBox();
        ReaLTaiizor.Controls.ForeverTextBox foreverTextBox2 = new ReaLTaiizor.Controls.ForeverTextBox();
        ReaLTaiizor.Controls.CrownTextBox crownTextBox1 = new ReaLTaiizor.Controls.CrownTextBox();
        ReaLTaiizor.Controls.ForeverTextBox foreverTextBox1 = new ReaLTaiizor.Controls.ForeverTextBox();
        ReaLTaiizor.Controls.LostCancelButton lostCancelButton3 = new ReaLTaiizor.Controls.LostCancelButton();
        ReaLTaiizor.Controls.LostCancelButton lostCancelButton2 = new ReaLTaiizor.Controls.LostCancelButton();
        ReaLTaiizor.Controls.LostCancelButton lostCancelButton1 = new ReaLTaiizor.Controls.LostCancelButton();
        ReaLTaiizor.Controls.FoxLabel foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
    
        
        User user;
        AppDbContext _db;
        System.Windows.Forms.Panel _panel1;
        ReaLTaiizor.Controls.Panel _panel4;
        int uid;

        public creatayar(Panel panel1, AppDbContext db, int uID)
        {

            panel1.Controls.Clear();
            appsetings appsetings = new appsetings();
            appsetings._userID = uID;
            uid = uID;
            _panel1 = panel1;
            _panel4 = panel4;
            _db = db;
            user = db.Users.Find(appsetings._userID);
            panel4.Visible = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(39, 51, 63);
            panel4.Controls.Add(lostCancelButton3);
            panel4.Controls.Add(lostCancelButton2);
            panel4.Controls.Add(lostCancelButton1);
            panel4.Controls.Add(dungeonToggleButton1);
            panel4.Controls.Add(foreverTextBox6);
            panel4.Controls.Add(crownTextBox5);
            panel4.Controls.Add(foreverTextBox5);
            panel4.Controls.Add(crownTextBox4);
            panel4.Controls.Add(foreverTextBox4);
            panel4.Controls.Add(crownTextBox3);
            panel4.Controls.Add(foreverTextBox3);
            panel4.Controls.Add(crownTextBox2);
            panel4.Controls.Add(foreverTextBox2);
            panel4.Controls.Add(crownTextBox1);
            panel4.Controls.Add(foreverTextBox1);
           
            panel4.EdgeColor = Color.FromArgb(32, 41, 50);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(801, 582);
            panel4.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel4.TabIndex = 0;
            panel4.Text = "panel4";
            panel1.Controls.Add(panel4);
         
              
                
                
           
            // 
            // lostCancelButton3
            // 
            lostCancelButton3.BackColor = Color.Crimson;
            lostCancelButton3.Font = new Font("Segoe UI", 9F);
            lostCancelButton3.ForeColor = Color.White;
            lostCancelButton3.HoverColor = Color.IndianRed;
            lostCancelButton3.Image = null;
            lostCancelButton3.Location = new Point(182, 8);
            lostCancelButton3.Name = "lostCancelButton3";
            lostCancelButton3.Size = new Size(151, 34);
            lostCancelButton3.TabIndex = 30;
            lostCancelButton3.Text = appsetings.myallorders;
            lostCancelButton3.Click += new EventHandler(gecmissip);
            // 
            // lostCancelButton2
            // 
            lostCancelButton2.BackColor = Color.Crimson;
            lostCancelButton2.Font = new Font("Segoe UI", 9F);
            lostCancelButton2.ForeColor = Color.White;
            lostCancelButton2.HoverColor = Color.IndianRed;
            lostCancelButton2.Image = null;
            lostCancelButton2.Location = new Point(8, 8);
            lostCancelButton2.Name = "lostCancelButton2";
            lostCancelButton2.Size = new Size(151, 34);
            lostCancelButton2.TabIndex = 29;
            lostCancelButton2.Text = appsetings.myalladress;
            lostCancelButton2.Click += new EventHandler(adreslerim);
            // 
            // lostCancelButton1
            // 
            lostCancelButton1.BackColor = Color.Crimson;
            lostCancelButton1.Font = new Font("Segoe UI", 9F);
            lostCancelButton1.ForeColor = Color.White;
            lostCancelButton1.HoverColor = Color.IndianRed;
            lostCancelButton1.Image = null;
            lostCancelButton1.Location = new Point(304, 504);
            lostCancelButton1.Name = "lostCancelButton1";
            lostCancelButton1.Size = new Size(185, 34);
            lostCancelButton1.TabIndex = 15;
            lostCancelButton1.Text = appsetings.save;
            lostCancelButton1.Click += new EventHandler(kaydet);
            // 
            // dungeonToggleButton1
            // 
            dungeonToggleButton1.Location = new Point(338, 408);
            dungeonToggleButton1.Name = "dungeonToggleButton1";
            dungeonToggleButton1.Size = new Size(79, 27);
            dungeonToggleButton1.TabIndex = 21;
            dungeonToggleButton1.Text = "dilyesno";
            dungeonToggleButton1.Toggled = false;
            dungeonToggleButton1.ToggledBackColorA = Color.FromArgb(253, 253, 253);
            dungeonToggleButton1.ToggledBackColorB = Color.FromArgb(240, 238, 237);
            dungeonToggleButton1.ToggledBorderColorA = Color.FromArgb(185, 89, 55);
            dungeonToggleButton1.ToggledBorderColorB = Color.FromArgb(185, 89, 55);
            dungeonToggleButton1.ToggledBorderColorC = Color.FromArgb(181, 181, 181);
            dungeonToggleButton1.ToggledBorderColorD = Color.FromArgb(181, 181, 181);
            dungeonToggleButton1.ToggledColorA = Color.FromArgb(231, 108, 58);
            dungeonToggleButton1.ToggledColorB = Color.FromArgb(236, 113, 63);
            dungeonToggleButton1.ToggledColorC = Color.FromArgb(208, 208, 208);
            dungeonToggleButton1.ToggledColorD = Color.FromArgb(226, 226, 226);
            dungeonToggleButton1.ToggledIOColorA = Color.WhiteSmoke;
            dungeonToggleButton1.ToggledIOColorB = Color.DimGray;
            dungeonToggleButton1.ToggledOnOffColorA = Color.WhiteSmoke;
            dungeonToggleButton1.ToggledOnOffColorB = Color.DimGray;
            dungeonToggleButton1.ToggledYesNoColorA = Color.WhiteSmoke;
            dungeonToggleButton1.ToggledYesNoColorB = Color.DimGray;
            dungeonToggleButton1.Type = ReaLTaiizor.Controls.DungeonToggleButton._Type.YesNo;
            dungeonToggleButton1.Toggled = user.Language;

            // 
            // foreverTextBox6
            // 
            foreverTextBox6.BackColor = Color.Transparent;
            foreverTextBox6.BaseColor = Color.FromArgb(45, 47, 49);
            foreverTextBox6.BorderColor = Color.FromArgb(35, 168, 109);
            foreverTextBox6.Enabled = false;
            foreverTextBox6.FocusOnHover = false;
            foreverTextBox6.ForeColor = Color.FromArgb(192, 192, 192);
            foreverTextBox6.Location = new Point(182, 403);
            foreverTextBox6.MaxLength = 32767;
            foreverTextBox6.Multiline = true;
            foreverTextBox6.Name = "foreverTextBox6";
            foreverTextBox6.ReadOnly = true;
            foreverTextBox6.Size = new Size(240, 37);
            foreverTextBox6.TabIndex = 28;
            foreverTextBox6.Text = appsetings.langsetings;
            foreverTextBox6.TextAlign = HorizontalAlignment.Left;
            foreverTextBox6.UseSystemPasswordChar = false;
            // 
            // crownTextBox5
            // 
            crownTextBox5.BackColor = Color.FromArgb(69, 73, 74);
            crownTextBox5.BorderStyle = BorderStyle.FixedSingle;
            crownTextBox5.ForeColor = Color.FromArgb(220, 220, 220);
            crownTextBox5.Location = new Point(338, 349);
            crownTextBox5.Name = "crownTextBox5";
            crownTextBox5.PasswordChar = '*';
            crownTextBox5.Size = new Size(255, 27);
            crownTextBox5.TabIndex = 25;
            crownTextBox5.Text = user.Password;
            // 
            // foreverTextBox5
            // 
            foreverTextBox5.BackColor = Color.Transparent;
            foreverTextBox5.BaseColor = Color.FromArgb(45, 47, 49);
            foreverTextBox5.BorderColor = Color.FromArgb(35, 168, 109);
            foreverTextBox5.Enabled = false;
            foreverTextBox5.FocusOnHover = false;
            foreverTextBox5.ForeColor = Color.FromArgb(192, 192, 192);
            foreverTextBox5.Location = new Point(182, 345);
            foreverTextBox5.MaxLength = 32767;
            foreverTextBox5.Multiline = true;
            foreverTextBox5.Name = "foreverTextBox5";
            foreverTextBox5.ReadOnly = true;
            foreverTextBox5.Size = new Size(416, 37);
            foreverTextBox5.TabIndex = 26;
            foreverTextBox5.Text = appsetings.password;
            foreverTextBox5.TextAlign = HorizontalAlignment.Left;
            foreverTextBox5.UseSystemPasswordChar = false;
            // 
            // crownTextBox4
            // 
            crownTextBox4.BackColor = Color.FromArgb(69, 73, 74);
            crownTextBox4.BorderStyle = BorderStyle.FixedSingle;
            crownTextBox4.ForeColor = Color.FromArgb(220, 220, 220);
            crownTextBox4.Location = new Point(338, 291);
            crownTextBox4.Name = "crownTextBox4";
            crownTextBox4.Size = new Size(255, 27);
            crownTextBox4.TabIndex = 23;
            crownTextBox4.Text = user.Username;
            // 
            // foreverTextBox4
            // 
            foreverTextBox4.BackColor = Color.Transparent;
            foreverTextBox4.BaseColor = Color.FromArgb(45, 47, 49);
            foreverTextBox4.BorderColor = Color.FromArgb(35, 168, 109);
            foreverTextBox4.Enabled = false;
            foreverTextBox4.FocusOnHover = false;
            foreverTextBox4.ForeColor = Color.FromArgb(192, 192, 192);
            foreverTextBox4.Location = new Point(182, 287);
            foreverTextBox4.MaxLength = 32767;
            foreverTextBox4.Multiline = true;
            foreverTextBox4.Name = "foreverTextBox4";
            foreverTextBox4.ReadOnly = true;
            foreverTextBox4.Size = new Size(416, 37);
            foreverTextBox4.TabIndex = 24;
            foreverTextBox4.Text = appsetings.username;
            foreverTextBox4.TextAlign = HorizontalAlignment.Left;
            foreverTextBox4.UseSystemPasswordChar = false;
            // 
            // crownTextBox3
            // 
            crownTextBox3.BackColor = Color.FromArgb(69, 73, 74);
            crownTextBox3.BorderStyle = BorderStyle.FixedSingle;
            crownTextBox3.ForeColor = Color.FromArgb(220, 220, 220);
            crownTextBox3.Location = new Point(338, 234);
            crownTextBox3.Name = "crownTextBox3";
            crownTextBox3.Size = new Size(255, 27);
            crownTextBox3.TabIndex = 21;
            crownTextBox3.Text = user.Email;
            // 
            // foreverTextBox3
            // 
            foreverTextBox3.BackColor = Color.Transparent;
            foreverTextBox3.BaseColor = Color.FromArgb(45, 47, 49);
            foreverTextBox3.BorderColor = Color.FromArgb(35, 168, 109);
            foreverTextBox3.Enabled = false;
            foreverTextBox3.FocusOnHover = false;
            foreverTextBox3.ForeColor = Color.FromArgb(192, 192, 192);
            foreverTextBox3.Location = new Point(182, 230);
            foreverTextBox3.MaxLength = 32767;
            foreverTextBox3.Multiline = true;
            foreverTextBox3.Name = "foreverTextBox3";
            foreverTextBox3.ReadOnly = true;
            foreverTextBox3.Size = new Size(416, 37);
            foreverTextBox3.TabIndex = 22;
            foreverTextBox3.Text = "Email";
            foreverTextBox3.TextAlign = HorizontalAlignment.Left;
            foreverTextBox3.UseSystemPasswordChar = false;
            // 
            // crownTextBox2
            // 
            crownTextBox2.BackColor = Color.FromArgb(69, 73, 74);
            crownTextBox2.BorderStyle = BorderStyle.FixedSingle;
            crownTextBox2.ForeColor = Color.FromArgb(220, 220, 220);
            crownTextBox2.Location = new Point(338, 173);
            crownTextBox2.Name = "crownTextBox2";
            crownTextBox2.Size = new Size(255, 27);
            crownTextBox2.TabIndex = 19;
            crownTextBox2.Text = user.LastName;
            // 
            // foreverTextBox2
            // 
            foreverTextBox2.BackColor = Color.Transparent;
            foreverTextBox2.BaseColor = Color.FromArgb(45, 47, 49);
            foreverTextBox2.BorderColor = Color.FromArgb(35, 168, 109);
            foreverTextBox2.Enabled = false;
            foreverTextBox2.FocusOnHover = false;
            foreverTextBox2.ForeColor = Color.FromArgb(192, 192, 192);
            foreverTextBox2.Location = new Point(182, 169);
            foreverTextBox2.MaxLength = 32767;
            foreverTextBox2.Multiline = true;
            foreverTextBox2.Name = "foreverTextBox2";
            foreverTextBox2.ReadOnly = true;
            foreverTextBox2.Size = new Size(416, 37);
            foreverTextBox2.TabIndex = 20;
            foreverTextBox2.Text = appsetings.lastname;
            foreverTextBox2.TextAlign = HorizontalAlignment.Left;
            foreverTextBox2.UseSystemPasswordChar = false;
            // 
            // crownTextBox1
            // 
            crownTextBox1.BackColor = Color.FromArgb(69, 73, 74);
            crownTextBox1.BorderStyle = BorderStyle.FixedSingle;
            crownTextBox1.ForeColor = Color.FromArgb(220, 220, 220);
            crownTextBox1.Location = new Point(338, 111);
            crownTextBox1.Name = "crownTextBox1";
            crownTextBox1.Size = new Size(255, 27);
            crownTextBox1.TabIndex = 2;
            crownTextBox1.Text = user.FirstName;
            // 
            // foreverTextBox1
            // 
            foreverTextBox1.BackColor = Color.Transparent;
            foreverTextBox1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverTextBox1.BorderColor = Color.FromArgb(35, 168, 109);
            foreverTextBox1.Enabled = false;
            foreverTextBox1.FocusOnHover = false;
            foreverTextBox1.ForeColor = Color.FromArgb(192, 192, 192);
            foreverTextBox1.Location = new Point(182, 107);
            foreverTextBox1.MaxLength = 32767;
            foreverTextBox1.Multiline = true;
            foreverTextBox1.Name = "foreverTextBox1";
            foreverTextBox1.ReadOnly = true;
            foreverTextBox1.Size = new Size(416, 37);
            foreverTextBox1.TabIndex = 18;
            foreverTextBox1.Text = appsetings.firstname;
            foreverTextBox1.TextAlign = HorizontalAlignment.Left;
            foreverTextBox1.UseSystemPasswordChar = false;

           
        }

        private void adreslerim(object? sender, EventArgs e)
        {
            creatadresler t = new creatadresler(_panel1, _db,uid);
        }

        private void gecmissip(object? sender, EventArgs e)
        {
                 
            creatmyorderlist c = new creatmyorderlist(_panel1, _db, uid);
            

        }

       

        private void kaydet(object? sender, EventArgs e)
        {
          appsetings appsetings = new appsetings();
            user.FirstName = crownTextBox1.Text;
            user.LastName = crownTextBox2.Text;
            user.Email = crownTextBox3.Text;
            user.Username = crownTextBox4.Text;
            user.Password = crownTextBox5.Text;
            user.Language = dungeonToggleButton1.Toggled;
            _db.SaveChanges();
            appsetings.langtr = user.Language;
            
            
            creatayar t = new creatayar(_panel1, _db,uid);
            
            
        }

    }
}
