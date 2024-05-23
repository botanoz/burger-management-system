using BurgerApp.Properties;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AntdUI.Modal;

namespace BurgerApp
{
    public partial class Form2 : Form
    {
        AppDbContext db;
        int uID;
        appsetings appsetings;
        int kategoriID;
        public Form2(int uid, AppDbContext dbb, appsetings appsetingss)
        {
            db = dbb;
            uID = uid;
            appsetings = appsetingss;
            appsetings._userID = uid;
            InitializeComponent();
            appsetings app = new appsetings(uid);

        }

        

        public void Form2_Load(object sender, EventArgs e)
        {
            

            appsetings.langtr = db.Users.FirstOrDefault(x=>x.UserID==appsetings._userID).Language;

            lsepet.Text = appsetings.sepetmsg;
            parrotButton1.ButtonText = appsetings.appclosebtn;
            parrotButton2.ButtonText = appsetings.setingbtn;
            btnsepetgor.Click += new EventHandler(opensepet);
            kategoriID=db.Categories.FirstOrDefault().CategoryID;
            formTheme1.Text = appsetings.appname;

            int e1 = 25;
            int e2 = 10;

            foreach (var item in db.Categories.ToList())

            {
                Bitmap img = new Bitmap(appsetings.basepath + item.Categoryimg);
                ReaLTaiizor.Controls.ParrotButton btn1 = new ReaLTaiizor.Controls.ParrotButton();
                btn1.BackgroundColor = Color.FromArgb(255, 255, 255);
                btn1.ButtonImage = img;
                btn1.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
                btn1.ButtonText = item.Name;
                btn1.ClickBackColor = Color.FromArgb(195, 195, 195);
                btn1.ClickTextColor = Color.Black;
                btn1.CornerRadius = 5;
                btn1.Horizontal_Alignment = StringAlignment.Center;
                btn1.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
                btn1.HoverTextColor = Color.Black;
                btn1.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
                btn1.Location = new Point(e1, e2);
                btn1.Name = item.Name + item.CategoryID;
                btn1.Size = new Size(185, 45);
                btn1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                btn1.TabIndex = 9;
                btn1.TextColor = Color.Black;
                btn1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                btn1.Vertical_Alignment = StringAlignment.Center;
                btn1.Tag = item.CategoryID;
                btn1.Click += new EventHandler(showproduct);
                this.panel3.Controls.Add(btn1);
                e2 += 50;
            }
           showproducts();
        }

        private void showproducts()
        {
            creatproduct t = new creatproduct(this.panel1, kategoriID, db);
            t.sptgncl(lsepet);
        }

        public void opensepet(object? sender, EventArgs e)
        {
            creatsepet t = new creatsepet(this.panel1, db,uID);
            t.sptgncl(lsepet);

        }

        public void showproduct(object? sender, EventArgs e)
        {
            ReaLTaiizor.Controls.ParrotButton clickedButton = sender as ReaLTaiizor.Controls.ParrotButton;
            kategoriID = (int)clickedButton.Tag;
            showproducts();
        }



        public void close_app(object? sender, EventArgs e)
        {
            appsetings appsetings = new appsetings();
            DialogResult rst = MessageBox.Show(appsetings.appclosemsg, appsetings.appcloseheader, MessageBoxButtons.YesNo);
            if (rst == DialogResult.Yes)
            {
                this.Close();
                
                

            }

        }

        private void parrotButton2_Click(object sender, EventArgs e)
        {
            creatayar c = new creatayar(this.panel1,db,uID);
        }
    }
}
