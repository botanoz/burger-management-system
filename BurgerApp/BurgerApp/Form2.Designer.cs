namespace BurgerApp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            panel2 = new Panel();
            btnsepetgor = new ReaLTaiizor.Controls.LostCancelButton();
            panel3 = new Panel();
            parrotButton2 = new ReaLTaiizor.Controls.ParrotButton();
            lsepet = new ReaLTaiizor.Controls.SpaceLabel();
            parrotButton1 = new ReaLTaiizor.Controls.ParrotButton();
            formTheme1 = new ReaLTaiizor.Forms.FormTheme();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(32, 41, 50);
            panel1.Location = new Point(271, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(807, 588);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(28, 34, 38);
            panel2.Controls.Add(btnsepetgor);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(parrotButton2);
            panel2.Controls.Add(lsepet);
            panel2.Controls.Add(parrotButton1);
            panel2.Location = new Point(12, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 588);
            panel2.TabIndex = 3;
            // 
            // btnsepetgor
            // 
            btnsepetgor.BackColor = Color.Crimson;
            btnsepetgor.Font = new Font("Segoe UI", 9F);
            btnsepetgor.ForeColor = Color.White;
            btnsepetgor.HoverColor = Color.IndianRed;
            btnsepetgor.Image = null;
            btnsepetgor.Location = new Point(25, 507);
            btnsepetgor.Name = "btnsepetgor";
            btnsepetgor.Size = new Size(185, 34);
            btnsepetgor.TabIndex = 14;
            btnsepetgor.Text = "Sepetim";
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(244, 400);
            panel3.TabIndex = 13;
            // 
            // parrotButton2
            // 
            parrotButton2.BackgroundColor = Color.FromArgb(255, 255, 255);
            parrotButton2.ButtonImage = (Image)resources.GetObject("parrotButton2.ButtonImage");
            parrotButton2.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButton2.ButtonText = "Settings";
            parrotButton2.ClickBackColor = Color.FromArgb(195, 195, 195);
            parrotButton2.ClickTextColor = Color.Black;
            parrotButton2.CornerRadius = 5;
            parrotButton2.Horizontal_Alignment = StringAlignment.Center;
            parrotButton2.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            parrotButton2.HoverTextColor = Color.Black;
            parrotButton2.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButton2.Location = new Point(25, 409);
            parrotButton2.Name = "parrotButton2";
            parrotButton2.Size = new Size(185, 38);
            parrotButton2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButton2.TabIndex = 8;
            parrotButton2.TextColor = Color.Black;
            parrotButton2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButton2.Vertical_Alignment = StringAlignment.Center;
            parrotButton2.Click += parrotButton2_Click;
            // 
            // lsepet
            // 
            lsepet.Customization = "/v7+/yoqKv8=";
            lsepet.Font = new Font("Verdana", 8F);
            lsepet.Image = null;
            lsepet.Location = new Point(29, 539);
            lsepet.Name = "lsepet";
            lsepet.NoRounding = false;
            lsepet.Size = new Size(178, 35);
            lsepet.TabIndex = 7;
            lsepet.TextAlignment = HorizontalAlignment.Center;
            lsepet.Transparent = false;
            // 
            // parrotButton1
            // 
            parrotButton1.BackgroundColor = Color.FromArgb(255, 255, 255);
            parrotButton1.ButtonImage = (Image)resources.GetObject("parrotButton1.ButtonImage");
            parrotButton1.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            parrotButton1.ButtonText = "Logout";
            parrotButton1.ClickBackColor = Color.FromArgb(195, 195, 195);
            parrotButton1.ClickTextColor = Color.Black;
            parrotButton1.CornerRadius = 5;
            parrotButton1.Horizontal_Alignment = StringAlignment.Center;
            parrotButton1.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            parrotButton1.HoverTextColor = Color.Black;
            parrotButton1.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            parrotButton1.Location = new Point(25, 453);
            parrotButton1.Name = "parrotButton1";
            parrotButton1.Size = new Size(185, 38);
            parrotButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            parrotButton1.TabIndex = 6;
            parrotButton1.TextColor = Color.Black;
            parrotButton1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotButton1.Vertical_Alignment = StringAlignment.Center;
            parrotButton1.Click += close_app;
            // 
            // formTheme1
            // 
            formTheme1.BackColor = Color.FromArgb(32, 41, 50);
            formTheme1.Dock = DockStyle.Fill;
            formTheme1.Font = new Font("Segoe UI", 8F);
            formTheme1.ForeColor = Color.FromArgb(142, 142, 142);
            formTheme1.Location = new Point(0, 0);
            formTheme1.Name = "formTheme1";
            formTheme1.Padding = new Padding(3, 28, 3, 28);
            formTheme1.Sizable = false;
            formTheme1.Size = new Size(1090, 650);
            formTheme1.SmartBounds = true;
            formTheme1.StartPosition = FormStartPosition.CenterScreen;
            formTheme1.TabIndex = 4;
            formTheme1.Text = "Burger App";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 650);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(formTheme1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(126, 50);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Burger App";
            TransparencyKey = Color.Fuchsia;
            Load += Form2_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private ReaLTaiizor.Forms.FormTheme formTheme1;
        private ReaLTaiizor.Controls.ParrotButton parrotButton1;
        private ReaLTaiizor.Controls.SpaceLabel lsepet;
        private ReaLTaiizor.Controls.ParrotButton parrotButton2;
        private Panel panel3;
        private ReaLTaiizor.Controls.LostCancelButton btnsepetgor;
        private AntdUI.Carousel carousel1;
    }
}