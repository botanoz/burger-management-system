namespace BurgerApp
{
    partial class Form1
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
            formTheme1 = new ReaLTaiizor.Forms.FormTheme();
            dungeonLinkLabel1 = new ReaLTaiizor.Controls.DungeonLinkLabel();
            singbtn = new ReaLTaiizor.Controls.CyberButton();
            singpassword = new ReaLTaiizor.Controls.CyberTextBox();
            singemail = new ReaLTaiizor.Controls.CyberTextBox();
            singlastname = new ReaLTaiizor.Controls.CyberTextBox();
            singfirstname = new ReaLTaiizor.Controls.CyberTextBox();
            singusername = new ReaLTaiizor.Controls.CyberTextBox();
            linkcreataccount = new ReaLTaiizor.Controls.DungeonLinkLabel();
            btnlogin = new ReaLTaiizor.Controls.CyberButton();
            tbpassword = new ReaLTaiizor.Controls.CyberTextBox();
            tbusername = new ReaLTaiizor.Controls.CyberTextBox();
            formTheme1.SuspendLayout();
            SuspendLayout();
            // 
            // formTheme1
            // 
            formTheme1.BackColor = Color.FromArgb(32, 41, 50);
            formTheme1.Controls.Add(dungeonLinkLabel1);
            formTheme1.Controls.Add(singbtn);
            formTheme1.Controls.Add(singpassword);
            formTheme1.Controls.Add(singemail);
            formTheme1.Controls.Add(singlastname);
            formTheme1.Controls.Add(singfirstname);
            formTheme1.Controls.Add(singusername);
            formTheme1.Controls.Add(linkcreataccount);
            formTheme1.Controls.Add(btnlogin);
            formTheme1.Controls.Add(tbpassword);
            formTheme1.Controls.Add(tbusername);
            formTheme1.Dock = DockStyle.Fill;
            formTheme1.Font = new Font("Segoe UI", 8F);
            formTheme1.ForeColor = Color.FromArgb(142, 142, 142);
            formTheme1.Location = new Point(0, 0);
            formTheme1.Name = "formTheme1";
            formTheme1.Padding = new Padding(3, 28, 3, 28);
            formTheme1.Sizable = false;
            formTheme1.Size = new Size(800, 450);
            formTheme1.SmartBounds = false;
            formTheme1.StartPosition = FormStartPosition.CenterScreen;
            formTheme1.TabIndex = 0;
            formTheme1.TabStop = false;
            formTheme1.Text = "Burger App";
            formTheme1.Click += formTheme1_Click;
            // 
            // dungeonLinkLabel1
            // 
            dungeonLinkLabel1.ActiveLinkColor = Color.FromArgb(221, 72, 20);
            dungeonLinkLabel1.Anchor = AnchorStyles.Left;
            dungeonLinkLabel1.AutoSize = true;
            dungeonLinkLabel1.BackColor = Color.Transparent;
            dungeonLinkLabel1.Font = new Font("Segoe UI", 7F);
            dungeonLinkLabel1.LinkBehavior = LinkBehavior.AlwaysUnderline;
            dungeonLinkLabel1.LinkColor = Color.FromArgb(240, 119, 70);
            dungeonLinkLabel1.Location = new Point(325, 385);
            dungeonLinkLabel1.Name = "dungeonLinkLabel1";
            dungeonLinkLabel1.Size = new Size(99, 15);
            dungeonLinkLabel1.TabIndex = 12;
            dungeonLinkLabel1.TabStop = true;
            dungeonLinkLabel1.Text = "Back login screen";
            dungeonLinkLabel1.Visible = false;
            dungeonLinkLabel1.VisitedLinkColor = Color.FromArgb(240, 119, 70);
            dungeonLinkLabel1.LinkClicked += dungeonLinkLabel1_LinkClicked;
            // 
            // singbtn
            // 
            singbtn.Alpha = 20;
            singbtn.Anchor = AnchorStyles.Left;
            singbtn.AutoSize = true;
            singbtn.BackColor = Color.Transparent;
            singbtn.Background = true;
            singbtn.Background_WidthPen = 4F;
            singbtn.BackgroundPen = true;
            singbtn.ColorBackground = Color.FromArgb(37, 52, 68);
            singbtn.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            singbtn.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            singbtn.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            singbtn.ColorLighting = Color.FromArgb(29, 200, 238);
            singbtn.ColorPen_1 = Color.FromArgb(37, 52, 68);
            singbtn.ColorPen_2 = Color.FromArgb(41, 63, 86);
            singbtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            singbtn.Effect_1 = true;
            singbtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            singbtn.Effect_1_Transparency = 25;
            singbtn.Effect_2 = true;
            singbtn.Effect_2_ColorBackground = Color.White;
            singbtn.Effect_2_Transparency = 20;
            singbtn.Font = new Font("Arial", 11F);
            singbtn.ForeColor = Color.FromArgb(245, 245, 245);
            singbtn.Lighting = false;
            singbtn.LinearGradient_Background = false;
            singbtn.LinearGradientPen = false;
            singbtn.Location = new Point(338, 323);
            singbtn.Name = "singbtn";
            singbtn.PenWidth = 15;
            singbtn.Rounding = true;
            singbtn.RoundingInt = 70;
            singbtn.Size = new Size(84, 41);
            singbtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            singbtn.TabIndex = 11;
            singbtn.Tag = "Cyber";
            singbtn.TextButton = "Sing Up";
            singbtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            singbtn.Timer_Effect_1 = 5;
            singbtn.Timer_RGB = 300;
            singbtn.Visible = false;
            singbtn.Click += singbtn_Click;
            // 
            // singpassword
            // 
            singpassword.Alpha = 20;
            singpassword.BackColor = Color.Transparent;
            singpassword.Background_WidthPen = 3F;
            singpassword.BackgroundPen = true;
            singpassword.ColorBackground = Color.FromArgb(37, 52, 68);
            singpassword.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            singpassword.ColorLighting = Color.FromArgb(29, 200, 238);
            singpassword.ColorPen_1 = Color.FromArgb(29, 200, 238);
            singpassword.ColorPen_2 = Color.FromArgb(37, 52, 68);
            singpassword.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            singpassword.Font = new Font("Arial", 8F);
            singpassword.ForeColor = Color.FromArgb(245, 245, 245);
            singpassword.Lighting = false;
            singpassword.LinearGradientPen = false;
            singpassword.Location = new Point(285, 282);
            singpassword.Name = "singpassword";
            singpassword.PenWidth = 15;
            singpassword.RGB = false;
            singpassword.Rounding = true;
            singpassword.RoundingInt = 60;
            singpassword.Size = new Size(182, 35);
            singpassword.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            singpassword.TabIndex = 10;
            singpassword.Tag = "Cyber";
            singpassword.TextButton = "Password";
            singpassword.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            singpassword.Timer_RGB = 300;
            singpassword.Visible = false;
            // 
            // singemail
            // 
            singemail.Alpha = 20;
            singemail.BackColor = Color.Transparent;
            singemail.Background_WidthPen = 3F;
            singemail.BackgroundPen = true;
            singemail.ColorBackground = Color.FromArgb(37, 52, 68);
            singemail.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            singemail.ColorLighting = Color.FromArgb(29, 200, 238);
            singemail.ColorPen_1 = Color.FromArgb(29, 200, 238);
            singemail.ColorPen_2 = Color.FromArgb(37, 52, 68);
            singemail.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            singemail.Font = new Font("Arial", 8F);
            singemail.ForeColor = Color.FromArgb(245, 245, 245);
            singemail.Lighting = false;
            singemail.LinearGradientPen = false;
            singemail.Location = new Point(285, 225);
            singemail.Name = "singemail";
            singemail.PenWidth = 15;
            singemail.RGB = false;
            singemail.Rounding = true;
            singemail.RoundingInt = 60;
            singemail.Size = new Size(182, 35);
            singemail.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            singemail.TabIndex = 9;
            singemail.Tag = "Cyber";
            singemail.TextButton = "Email";
            singemail.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            singemail.Timer_RGB = 300;
            singemail.Visible = false;
            // 
            // singlastname
            // 
            singlastname.Alpha = 20;
            singlastname.BackColor = Color.Transparent;
            singlastname.Background_WidthPen = 3F;
            singlastname.BackgroundPen = true;
            singlastname.ColorBackground = Color.FromArgb(37, 52, 68);
            singlastname.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            singlastname.ColorLighting = Color.FromArgb(29, 200, 238);
            singlastname.ColorPen_1 = Color.FromArgb(29, 200, 238);
            singlastname.ColorPen_2 = Color.FromArgb(37, 52, 68);
            singlastname.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            singlastname.Font = new Font("Arial", 8F);
            singlastname.ForeColor = Color.FromArgb(245, 245, 245);
            singlastname.Lighting = false;
            singlastname.LinearGradientPen = false;
            singlastname.Location = new Point(285, 166);
            singlastname.Name = "singlastname";
            singlastname.PenWidth = 15;
            singlastname.RGB = false;
            singlastname.Rounding = true;
            singlastname.RoundingInt = 60;
            singlastname.Size = new Size(182, 35);
            singlastname.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            singlastname.TabIndex = 8;
            singlastname.Tag = "Cyber";
            singlastname.TextButton = "Lastname";
            singlastname.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            singlastname.Timer_RGB = 300;
            singlastname.Visible = false;
            // 
            // singfirstname
            // 
            singfirstname.Alpha = 20;
            singfirstname.BackColor = Color.Transparent;
            singfirstname.Background_WidthPen = 3F;
            singfirstname.BackgroundPen = true;
            singfirstname.ColorBackground = Color.FromArgb(37, 52, 68);
            singfirstname.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            singfirstname.ColorLighting = Color.FromArgb(29, 200, 238);
            singfirstname.ColorPen_1 = Color.FromArgb(29, 200, 238);
            singfirstname.ColorPen_2 = Color.FromArgb(37, 52, 68);
            singfirstname.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            singfirstname.Font = new Font("Arial", 8F);
            singfirstname.ForeColor = Color.FromArgb(245, 245, 245);
            singfirstname.Lighting = false;
            singfirstname.LinearGradientPen = false;
            singfirstname.Location = new Point(285, 112);
            singfirstname.Name = "singfirstname";
            singfirstname.PenWidth = 15;
            singfirstname.RGB = false;
            singfirstname.Rounding = true;
            singfirstname.RoundingInt = 60;
            singfirstname.Size = new Size(182, 35);
            singfirstname.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            singfirstname.TabIndex = 7;
            singfirstname.Tag = "Cyber";
            singfirstname.TextButton = "Firstname";
            singfirstname.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            singfirstname.Timer_RGB = 300;
            singfirstname.Visible = false;
            // 
            // singusername
            // 
            singusername.Alpha = 20;
            singusername.BackColor = Color.Transparent;
            singusername.Background_WidthPen = 3F;
            singusername.BackgroundPen = true;
            singusername.ColorBackground = Color.FromArgb(37, 52, 68);
            singusername.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            singusername.ColorLighting = Color.FromArgb(29, 200, 238);
            singusername.ColorPen_1 = Color.FromArgb(29, 200, 238);
            singusername.ColorPen_2 = Color.FromArgb(37, 52, 68);
            singusername.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            singusername.Font = new Font("Arial", 8F);
            singusername.ForeColor = Color.FromArgb(245, 245, 245);
            singusername.Lighting = false;
            singusername.LinearGradientPen = false;
            singusername.Location = new Point(285, 61);
            singusername.Name = "singusername";
            singusername.PenWidth = 15;
            singusername.RGB = false;
            singusername.Rounding = true;
            singusername.RoundingInt = 60;
            singusername.Size = new Size(182, 35);
            singusername.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            singusername.TabIndex = 6;
            singusername.Tag = "Cyber";
            singusername.TextButton = "Username";
            singusername.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            singusername.Timer_RGB = 300;
            singusername.Visible = false;
            // 
            // linkcreataccount
            // 
            linkcreataccount.ActiveLinkColor = Color.FromArgb(221, 72, 20);
            linkcreataccount.Anchor = AnchorStyles.Left;
            linkcreataccount.AutoSize = true;
            linkcreataccount.BackColor = Color.Transparent;
            linkcreataccount.Font = new Font("Segoe UI", 7F);
            linkcreataccount.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkcreataccount.LinkColor = Color.FromArgb(240, 119, 70);
            linkcreataccount.Location = new Point(294, 360);
            linkcreataccount.Name = "linkcreataccount";
            linkcreataccount.Size = new Size(154, 15);
            linkcreataccount.TabIndex = 5;
            linkcreataccount.TabStop = true;
            linkcreataccount.Text = "Don't you have an account?";
            linkcreataccount.VisitedLinkColor = Color.FromArgb(240, 119, 70);
            linkcreataccount.LinkClicked += linkcreataccount_LinkClicked;
            // 
            // btnlogin
            // 
            btnlogin.Alpha = 20;
            btnlogin.Anchor = AnchorStyles.Left;
            btnlogin.AutoSize = true;
            btnlogin.BackColor = Color.Transparent;
            btnlogin.Background = true;
            btnlogin.Background_WidthPen = 4F;
            btnlogin.BackgroundPen = true;
            btnlogin.ColorBackground = Color.FromArgb(37, 52, 68);
            btnlogin.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnlogin.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnlogin.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnlogin.ColorLighting = Color.FromArgb(29, 200, 238);
            btnlogin.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnlogin.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnlogin.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnlogin.Effect_1 = true;
            btnlogin.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnlogin.Effect_1_Transparency = 25;
            btnlogin.Effect_2 = true;
            btnlogin.Effect_2_ColorBackground = Color.White;
            btnlogin.Effect_2_Transparency = 20;
            btnlogin.Font = new Font("Arial", 11F);
            btnlogin.ForeColor = Color.FromArgb(245, 245, 245);
            btnlogin.Lighting = false;
            btnlogin.LinearGradient_Background = false;
            btnlogin.LinearGradientPen = false;
            btnlogin.Location = new Point(325, 274);
            btnlogin.Name = "btnlogin";
            btnlogin.PenWidth = 15;
            btnlogin.Rounding = true;
            btnlogin.RoundingInt = 70;
            btnlogin.Size = new Size(84, 41);
            btnlogin.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnlogin.TabIndex = 3;
            btnlogin.Tag = "Cyber";
            btnlogin.TextButton = "Login";
            btnlogin.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnlogin.Timer_Effect_1 = 5;
            btnlogin.Timer_RGB = 300;
            btnlogin.Click += btnlogin_Click;
            // 
            // tbpassword
            // 
            tbpassword.Alpha = 20;
            tbpassword.Anchor = AnchorStyles.Left;
            tbpassword.AutoSize = true;
            tbpassword.BackColor = Color.Transparent;
            tbpassword.Background_WidthPen = 3F;
            tbpassword.BackgroundPen = true;
            tbpassword.ColorBackground = Color.FromArgb(37, 52, 68);
            tbpassword.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            tbpassword.ColorLighting = Color.FromArgb(29, 200, 238);
            tbpassword.ColorPen_1 = Color.FromArgb(29, 200, 238);
            tbpassword.ColorPen_2 = Color.FromArgb(37, 52, 68);
            tbpassword.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            tbpassword.Font = new Font("Arial", 8F);
            tbpassword.ForeColor = Color.FromArgb(245, 245, 245);
            tbpassword.Lighting = false;
            tbpassword.LinearGradientPen = false;
            tbpassword.Location = new Point(269, 200);
            tbpassword.Name = "tbpassword";
            tbpassword.Password = true;
            tbpassword.PenWidth = 15;
            tbpassword.RGB = false;
            tbpassword.Rounding = true;
            tbpassword.RoundingInt = 60;
            tbpassword.Size = new Size(224, 33);
            tbpassword.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            tbpassword.TabIndex = 2;
            tbpassword.Tag = "Cyber";
            tbpassword.TextButton = "Password";
            tbpassword.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            tbpassword.Timer_RGB = 300;
            tbpassword.Enter += tbpassword_Enter;
            // 
            // tbusername
            // 
            tbusername.Alpha = 20;
            tbusername.Anchor = AnchorStyles.Left;
            tbusername.AutoSize = true;
            tbusername.BackColor = Color.Transparent;
            tbusername.Background_WidthPen = 3F;
            tbusername.BackgroundPen = true;
            tbusername.ColorBackground = Color.FromArgb(37, 52, 68);
            tbusername.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            tbusername.ColorLighting = Color.FromArgb(29, 200, 238);
            tbusername.ColorPen_1 = Color.FromArgb(29, 200, 238);
            tbusername.ColorPen_2 = Color.FromArgb(37, 52, 68);
            tbusername.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            tbusername.Font = new Font("Arial", 8F);
            tbusername.ForeColor = Color.FromArgb(245, 245, 245);
            tbusername.Lighting = false;
            tbusername.LinearGradientPen = false;
            tbusername.Location = new Point(269, 140);
            tbusername.Name = "tbusername";
            tbusername.PenWidth = 15;
            tbusername.RGB = false;
            tbusername.Rounding = true;
            tbusername.RoundingInt = 60;
            tbusername.Size = new Size(224, 32);
            tbusername.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            tbusername.TabIndex = 1;
            tbusername.Tag = "Cyber";
            tbusername.TextButton = "Username";
            tbusername.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            tbusername.Timer_RGB = 300;
            tbusername.Enter += tbusername_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(formTheme1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(126, 50);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Burger App";
            TransparencyKey = Color.Fuchsia;
            formTheme1.ResumeLayout(false);
            formTheme1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.FormTheme formTheme1;
        private ReaLTaiizor.Controls.DungeonLinkLabel linkcreataccount;
        private ReaLTaiizor.Controls.CyberButton btnlogin;
        private ReaLTaiizor.Controls.CyberTextBox tbpassword;
        private ReaLTaiizor.Controls.CyberTextBox tbusername;
        private ReaLTaiizor.Controls.CyberButton singbtn;
        private ReaLTaiizor.Controls.CyberTextBox singpassword;
        private ReaLTaiizor.Controls.CyberTextBox singemail;
        private ReaLTaiizor.Controls.CyberTextBox singlastname;
        private ReaLTaiizor.Controls.CyberTextBox singfirstname;
        private ReaLTaiizor.Controls.CyberTextBox singusername;
        private ReaLTaiizor.Controls.DungeonLinkLabel dungeonLinkLabel1;
    }
}