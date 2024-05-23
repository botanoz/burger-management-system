using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void formTheme1_Click(object sender, EventArgs e)
        {

        }
        appsetings appsetings = new appsetings();
        AppDbContext db = new AppDbContext();
        private void btnlogin_Click(object sender, EventArgs e)
        {
           


            var u = db.Users.FirstOrDefault(x => x.Username == tbusername.TextButton && x.Password == tbpassword.TextButton);

            if (u != null)
            {
                if (u.UserType == 2)
                {
                    Form3 frm3 = new Form3();
                    frm3.Show();
                    this.Hide();
                    return;
                }
                else { 
                int uid = u.UserID; 
                appsetings._userID = u.UserID;
                Form2 frm2 = new Form2(uid,db,appsetings);
                frm2.Show();
                this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
        }

        private void linkcreataccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbusername.Visible = false;
            tbpassword.Visible = false;
            btnlogin.Visible = false;
            linkcreataccount.Visible = false;
            singbtn.Visible = true;
            singemail.Visible = true;
            singfirstname.Visible = true;
            singlastname.Visible = true;
            singpassword.Visible = true;
            singusername.Visible = true;
            dungeonLinkLabel1.Visible = true;

        }

        private void tbusername_Enter(object sender, EventArgs e)
        {

            tbusername.TextButton = "";

        }

        private void tbpassword_Enter(object sender, EventArgs e)
        {
            tbpassword.TextButton = "";
        }

        private void dungeonLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbusername.Visible = true;
            tbpassword.Visible = true;
            btnlogin.Visible = true;
            linkcreataccount.Visible = true;
            singbtn.Visible = false;
            singemail.Visible = false;
            singfirstname.Visible = false;
            singlastname.Visible = false;
            singpassword.Visible = false;
            singusername.Visible = false;
            dungeonLinkLabel1.Visible = false;
        }

        private void singbtn_Click(object sender, EventArgs e)
        {
            var existingUser = db.Users.FirstOrDefault(x => x.Username == singusername.TextButton);

            if (existingUser != null)
            {
                MessageBox.Show("Kullanıcı adı zaten kullanımda!");

            }
            else { 

            User user = new User();
            user.Username = singusername.TextButton;
            user.Password = singpassword.TextButton;
            user.Email = singemail.TextButton;
            user.FirstName = singfirstname.TextButton;
            user.LastName = singlastname.TextButton;
            user.IsActive = true;
            user.RegistrationDate = DateTime.Now;
            user.Language = true;
            user.UserType = 1;
            db.Users.Add(user);
            db.SaveChanges();
            Address address = new Address();
                address.UserID = user.UserID;
                address.AddressLine1 = "Adres satırı 1";
                address.AddressLine2 = "Adres satırı 2";
                address.City = "beşiktaş";
                address.IsActive = true;
                address.Country = "istanbul";
                address.PostalCode = "34353";
                address.IsFavorite = true;
                db.Addresses.Add(address);
                db.SaveChanges();
                tbusername.Visible = true;
            tbpassword.Visible = true;
            btnlogin.Visible = true;
            linkcreataccount.Visible = true;
            singbtn.Visible = false;
            singemail.Visible = false;
            singfirstname.Visible = false;
            singlastname.Visible = false;
            singpassword.Visible = false;
            singusername.Visible = false;
            dungeonLinkLabel1.Visible = false;
            MessageBox.Show("Kullanıcı başarıyla oluşturuldu!");
            }
        }
    }
}
