

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BurgerApp
{
    public class creatsepet : appsetings
    {
        ReaLTaiizor.Controls.LostCancelButton btnsptver = new ReaLTaiizor.Controls.LostCancelButton();
        ReaLTaiizor.Controls.SkyLabel lgonsptAbas = new ReaLTaiizor.Controls.SkyLabel();
        ReaLTaiizor.Controls.Panel pnalSpt = new ReaLTaiizor.Controls.Panel();
        ReaLTaiizor.Controls.MoonLabel lgonspt = new ReaLTaiizor.Controls.MoonLabel();
        ReaLTaiizor.Controls.LostCancelButton btnsptAgun = new ReaLTaiizor.Controls.LostCancelButton();
        ReaLTaiizor.Controls.LostCancelButton btnsptTem = new ReaLTaiizor.Controls.LostCancelButton();
        ReaLTaiizor.Controls.MoonLabel lspttopBas = new ReaLTaiizor.Controls.MoonLabel();
        ReaLTaiizor.Controls.SkyLabel ltopspt = new ReaLTaiizor.Controls.SkyLabel();
        AppDbContext _db;
        Panel _panel1;
        bool _issiparis = false;
        int orderId;
        int uid;
        public creatsepet(Panel panel1,AppDbContext db,int uID)
        {
            panel1.Controls.Clear();
            sptkntrl(panel1, db);
            _userID = uID;
            uid = uID;
            _db = db;
            _panel1 = panel1;
            var _adress = db.Addresses.FirstOrDefault(x => x.UserID == _userID && x.IsFavorite==true);
            if (_adress == null)
            {
                creatadresler ad = new creatadresler(panel1, db, uID);
                
                ad.padress();
            }else
            { 
                // 
                // lgonsptAbas
                // 
            lgonsptAbas.AutoSize = true;
            lgonsptAbas.Font = new Font("Verdana", 6.75F, FontStyle.Bold);
            lgonsptAbas.ForeColor = Color.FromArgb(27, 94, 137);
            lgonsptAbas.Location = new Point(159, 484);
            lgonsptAbas.Name = "lgonsptAbas";
            lgonsptAbas.Size = new Size(92, 14);
            lgonsptAbas.TabIndex = 16;
            lgonsptAbas.Text = _adress.AddressLine1+ "\n" +_adress.AddressLine2 + "\n" +_adress.City+"/"+_adress.Country;


            // 
            // lgonspt
            // 
            lgonspt.AutoSize = true;
            lgonspt.BackColor = Color.Transparent;
            lgonspt.ForeColor = Color.Gray;
            lgonspt.Location = new Point(13, 479);
            lgonspt.Name = "lgonspt";
            lgonspt.Size = new Size(128, 20);
            lgonspt.TabIndex = 15;
            lgonspt.Text = adress;

            
            // 
            // btnsptAgun
            // 
            btnsptAgun.BackColor = Color.Crimson;
            btnsptAgun.Font = new Font("Segoe UI", 9F);
            btnsptAgun.ForeColor = Color.White;
            btnsptAgun.HoverColor = Color.IndianRed;
            btnsptAgun.Image = null;
            btnsptAgun.Location = new Point(17, 540);
            btnsptAgun.Name = "btnsptAgun";
            btnsptAgun.Size = new Size(124, 34);
            btnsptAgun.TabIndex = 14;
            btnsptAgun.Text = updateadress;
            btnsptAgun.Click += new EventHandler((sender, e) =>
            {
                creatadresler ad = new creatadresler(panel1, db, uID);
            });


            // 
            // btnsptTem
            // 
            btnsptTem.BackColor = Color.Crimson;
            btnsptTem.Font = new Font("Segoe UI", 9F);
            btnsptTem.ForeColor = Color.White;
            btnsptTem.HoverColor = Color.IndianRed;
            btnsptTem.Image = null;
            btnsptTem.Location = new Point(523, 540);
            btnsptTem.Name = "btnsptTem";
            btnsptTem.Size = new Size(124, 34);
            btnsptTem.TabIndex = 13;
            btnsptTem.Text = cleanorder;
            btnsptTem.Click += new EventHandler((sender, e) =>
            {
                foreach (var item in db.Products)
                {
                    item.IsSelected = false;
                    item.SelectedQuantity = 0;
                    
                    
                    
                }
                db.Products.Find(1).CartTotal = 0;
                _lsepet.Text = sepetmsg;
                pnalSpt.Controls.Clear();
               
                ltopspt.Text = "$" + db.Products.Find(1).CartTotal.ToString();
                sptkntrl(panel1, db);



            });

            
            // 
            // btnsptver
            // 
            btnsptver.BackColor = Color.Crimson;
            btnsptver.Font = new Font("Segoe UI", 9F);
            btnsptver.ForeColor = Color.White;
            btnsptver.HoverColor = Color.IndianRed;
            btnsptver.Image = null;
            btnsptver.Location = new Point(672, 540);
            btnsptver.Name = "btnsptver";
            btnsptver.Size = new Size(124, 34);
            btnsptver.TabIndex = 12;
            btnsptver.Text = giveorder;
            btnsptver.Click += new EventHandler(siparisver);

            
            // 
            // lspttopBas
            // 
            lspttopBas.AutoSize = true;
            lspttopBas.BackColor = Color.Transparent;
            lspttopBas.ForeColor = Color.Gray;
            lspttopBas.Location = new Point(564, 484);
            lspttopBas.Name = "lspttopBas";
            lspttopBas.Size = new Size(104, 20);
            lspttopBas.TabIndex = 11;
            lspttopBas.Text = sepettotal;

            
            // 
            // ltopspt
            // 
            ltopspt.AutoSize = true;
            ltopspt.Font = new Font("Verdana", 6.75F, FontStyle.Bold);
            ltopspt.ForeColor = Color.FromArgb(27, 94, 137);
            ltopspt.Location = new Point(674, 489);
            ltopspt.Name = "ltopspt";
            ltopspt.Size = new Size(43, 14);
            ltopspt.TabIndex = 10;
            ltopspt.Text = "$" + db.Products.Find(1).CartTotal.ToString();

            sptolstr(panel1,db);

           
            panel1.Controls.Add(pnalSpt);           
            panel1.Controls.Add(lgonsptAbas);
            panel1.Controls.Add(lgonspt);
            panel1.Controls.Add(btnsptAgun);
            panel1.Controls.Add(btnsptTem);
            panel1.Controls.Add(btnsptver);
            panel1.Controls.Add(lspttopBas);
            panel1.Controls.Add(ltopspt);
            }

        }

        private void siparisver(object? sender, EventArgs e)
        {
            Order n = new Order();
            n.OrderDate = DateTime.Now;
            n.UserID = _userID;
            n.AddressID = _db.Addresses.FirstOrDefault(x=> x.UserID== _userID && x.IsFavorite==true).AddressID;
            n.Status = _db.OrderStatuses.Find(1);
            n.TotalAmount = _db.Products.Find(1).CartTotal;
            _db.Orders.Add(n);
            _db.SaveChanges();
            orderId = n.OrderID;
            _issiparis = true;
            foreach (var item in _db.Products)
            {
                if (item.IsSelected)
                {
                    OrderDetail od = new OrderDetail();
                    od.ProductID = item.ProductID;
                    od.Quantity = item.SelectedQuantity;
                    od.Price = item.Price;
                    od.OrderID = orderId; 

                    _db.OrderDetails.Add(od);
                   
                    item.IsSelected = false;
                    item.SelectedQuantity = 0;
                }
            }

            _db.SaveChanges();
            _db.Products.Find(1).CartTotal = 0;
            _lsepet.Text = sepetmsg;
            pnalSpt.Controls.Clear();
            ltopspt.Text = "$" + _db.Products.Find(1).CartTotal.ToString();
            sptkntrl(_panel1, _db);
        }

        private void sptolstr(Panel panel1, AppDbContext db)
        {
            int a1 = 6;
            int b1 = 6;
            int a2 = 69;
            int b2 = 5;
            int a3 = 725;
            int b3 = 5;
            foreach (var item in db.Products)
            {
                if (item.IsSelected == true)
                {

                    ReaLTaiizor.Controls.ForeverNumeric numspt = new ReaLTaiizor.Controls.ForeverNumeric();
                    // 
                    // numspt
                    // 
                    numspt.BaseColor = Color.FromArgb(45, 47, 49);
                    numspt.ButtonColorA = Color.FromArgb(35, 168, 109);
                    numspt.ButtonColorB = Color.White;
                    numspt.ButtonColorC = Color.White;
                    numspt.Font = new Font("Segoe UI", 10F);
                    numspt.ForeColor = Color.Silver;
                    numspt.Location = new Point(a1, b1);
                    numspt.Maximum =10L;
                    numspt.Minimum = 1L;
                    numspt.Name = "numspt";
                    numspt.Size = new Size(59, 34);
                    numspt.TabIndex = 2;
                    numspt.Text = "foreverNumeric1";
                    numspt.Value = item.SelectedQuantity;
                    numspt.ValueChanged += new EventHandler((sender, e) =>
                    {
                        if (item.SelectedQuantity < numspt.Value)
                        {
                            db.Products.Find(1).CartTotal += item.Price;
                            item.SelectedQuantity = (int)numspt.Value;
                            ltopspt.Text = "$" + db.Products.Find(1).CartTotal.ToString();
                            _lsepet.Text = sepettotal + db.Products.Find(1).CartTotal.ToString();
                        }
                        else if (item.SelectedQuantity > numspt.Value)
                        {
                            db.Products.Find(1).CartTotal -= item.Price;
                            item.SelectedQuantity = (int)numspt.Value;
                            ltopspt.Text = "$" + db.Products.Find(1).CartTotal.ToString();
                            _lsepet.Text = sepettotal + db.Products.Find(1).CartTotal.ToString();
                        }


                    });



                    ReaLTaiizor.Controls.ForeverTextBox txtspt = new ReaLTaiizor.Controls.ForeverTextBox();
                    // 
                    // txtspt
                    // 
                    txtspt.BackColor = Color.Transparent;
                    txtspt.BaseColor = Color.FromArgb(45, 47, 49);
                    txtspt.BorderColor = Color.FromArgb(35, 168, 109);
                    txtspt.FocusOnHover = false;
                    txtspt.ForeColor = Color.FromArgb(192, 192, 192);
                    txtspt.Location = new Point(a2, b2);
                    txtspt.MaxLength = 32767;
                    txtspt.Multiline = false;
                    txtspt.Name = "txtspt";
                    txtspt.ReadOnly = true;
                    txtspt.Size = new Size(650, 34);
                    txtspt.TabIndex = 4;
                    txtspt.Text = $"{item.Name}   1 x {"$" + item.Price}";
                    txtspt.TextAlign = HorizontalAlignment.Left;
                    txtspt.Enabled = false;
                    txtspt.UseSystemPasswordChar = false;


                    ReaLTaiizor.Controls.ForeverButton btnXspt = new ReaLTaiizor.Controls.ForeverButton();
                    // 
                    // btnXspt
                    // 
                    btnXspt.BackColor = Color.Transparent;
                    btnXspt.BaseColor = Color.FromArgb(35, 168, 109);
                    btnXspt.Font = new Font("Segoe UI", 12F);
                    btnXspt.Location = new Point(a3, b3);
                    btnXspt.Name = "btnXspt";
                    btnXspt.Rounded = false;
                    btnXspt.Size = new Size(36, 34);
                    btnXspt.TabIndex = 5;
                    btnXspt.Text = "X";
                    btnXspt.TextColor = Color.FromArgb(243, 243, 243);
                    btnXspt.Click += new EventHandler((sender, e) =>
                    {
                        db.Products.Find(1).CartTotal -= item.Price * item.SelectedQuantity;
                        item.IsSelected = false;
                        item.SelectedQuantity = 0;
                        ltopspt.Text = "$" + db.Products.Find(1).CartTotal.ToString();
                        _lsepet.Text = sepettotal + db.Products.Find(1).CartTotal.ToString();
                        pnalSpt.Controls.Remove(btnXspt);
                        pnalSpt.Controls.Remove(txtspt);
                        pnalSpt.Controls.Remove(numspt);
                        pnalSpt.Controls.Clear();
                        sptolstr(panel1, db);
                        if (db.Products.Find(1).CartTotal == 0)
                        {
                           
                            sptkntrl(panel1, db);
                        }
                    });

                    // 
                    // pnalSpt
                    // 
                    pnalSpt.Controls.Add(btnXspt);
                    pnalSpt.Controls.Add(txtspt);
                    pnalSpt.Controls.Add(numspt);
                    pnalSpt.Location = new Point(13, 16);
                    pnalSpt.Name = "pnalSpt";
                    pnalSpt.Size = new Size(783, 460);
                    pnalSpt.TabIndex = 17;
                    pnalSpt.AutoScroll = true;
                    b1 += 40;
                    b2 += 40;
                    b3 += 40;

                }
            }

        }

        private void sptkntrl(Panel panel1, AppDbContext db)
        {
            if (db.Products.Find(1).CartTotal > 0)
            {
                btnsptTem.Visible = true;
                btnsptver.Visible = true;
                ltopspt.Visible = true;
                lspttopBas.Visible = true;
                pnalSpt.Visible = true;
                btnsptAgun.Visible = true;
                lgonspt.Visible = true;
                lgonsptAbas.Visible = true;
            }
            else
            {
                btnsptTem.Visible = false;
                btnsptver.Visible = false;
                ltopspt.Visible = false;
                lspttopBas.Visible = false;
                pnalSpt.Visible = false;
                btnsptAgun.Visible = false;
                lgonspt.Visible = false;
                lgonsptAbas.Visible = false;
                _lsepet.Text = sepetmsg;
                ReaLTaiizor.Controls.SpaceLabel spaceLabel1 = new ReaLTaiizor.Controls.SpaceLabel();
                // 
                // spaceLabel1
                // 
                spaceLabel1.Customization = "/v7+/yoqKv8=";
                spaceLabel1.Font = new Font("Verdana", 8F);
                spaceLabel1.Image = null;
                spaceLabel1.Location = new Point(214, 271);
                spaceLabel1.Name = "spaceLabel1";
                spaceLabel1.NoRounding = false;
                spaceLabel1.Size = new Size(340, 35);
                spaceLabel1.TabIndex = 15;
                if (_issiparis)
                {
                    
                   
                    spaceLabel1.Text = ordermsg+orderId.ToString();
                    _issiparis = false;
                    
                }
                else {
                    
                    
                    spaceLabel1.Text = sepetmsg;
                }
                spaceLabel1.TextAlignment = HorizontalAlignment.Center;
                spaceLabel1.Transparent = false;
                panel1.Controls.Add(spaceLabel1);
            }
        }

        ReaLTaiizor.Controls.SpaceLabel _lsepet = new ReaLTaiizor.Controls.SpaceLabel();
        internal void sptgncl(ReaLTaiizor.Controls.SpaceLabel lsepet)
        {
            _lsepet = lsepet;
        }
    }
    
}
