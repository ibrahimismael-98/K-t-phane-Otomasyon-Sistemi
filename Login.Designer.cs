
namespace Nallıhan_Kütüphane_Otomasyon_Sistemi
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Login_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.forgot_password_LinkLable = new System.Windows.Forms.LinkLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.login_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.login_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.login_exit = new Guna.UI.WinForms.GunaGradientTileButton();
            this.log_login_button = new Guna.UI.WinForms.GunaGradientTileButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.forgot_panel = new System.Windows.Forms.Panel();
            this.birthdate_label = new System.Windows.Forms.Label();
            this.forgot_family_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.birthdate_TimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.forgot_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.forgot_T_C = new Guna.UI2.WinForms.Guna2TextBox();
            this.forgot_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.forgot_password_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.sig_exit = new Guna.UI.WinForms.GunaGradientTileButton();
            this.forgot_login_button = new Guna.UI.WinForms.GunaGradientTileButton();
            this.find_password = new Guna.UI.WinForms.GunaGradientTileButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_timer = new System.Windows.Forms.Timer(this.components);
            this.forgot_timer = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Login_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.forgot_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_panel
            // 
            this.Login_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(193)))));
            this.Login_panel.Controls.Add(this.label1);
            this.Login_panel.Controls.Add(this.forgot_password_LinkLable);
            this.Login_panel.Controls.Add(this.guna2HtmlLabel1);
            this.Login_panel.Controls.Add(this.login_password);
            this.Login_panel.Controls.Add(this.login_email);
            this.Login_panel.Controls.Add(this.login_exit);
            this.Login_panel.Controls.Add(this.log_login_button);
            this.Login_panel.Location = new System.Drawing.Point(759, 0);
            this.Login_panel.Name = "Login_panel";
            this.Login_panel.Size = new System.Drawing.Size(443, 700);
            this.Login_panel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 666);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Copyright @ 2021 S2Dev.";
            // 
            // forgot_password_LinkLable
            // 
            this.forgot_password_LinkLable.AutoSize = true;
            this.forgot_password_LinkLable.DisabledLinkColor = System.Drawing.Color.Black;
            this.forgot_password_LinkLable.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_password_LinkLable.ForeColor = System.Drawing.Color.Black;
            this.forgot_password_LinkLable.LinkColor = System.Drawing.Color.Cyan;
            this.forgot_password_LinkLable.Location = new System.Drawing.Point(172, 483);
            this.forgot_password_LinkLable.Name = "forgot_password_LinkLable";
            this.forgot_password_LinkLable.Size = new System.Drawing.Size(128, 21);
            this.forgot_password_LinkLable.TabIndex = 4;
            this.forgot_password_LinkLable.TabStop = true;
            this.forgot_password_LinkLable.Text = "Şifremi Unuttum";
            this.forgot_password_LinkLable.VisitedLinkColor = System.Drawing.Color.Black;
            this.forgot_password_LinkLable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgot_password_LinkClicked);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Noto Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Gold;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(47, 36);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(82, 49);
            this.guna2HtmlLabel1.TabIndex = 13;
            this.guna2HtmlLabel1.Text = "Giriş";
            // 
            // login_password
            // 
            this.login_password.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.login_password.BackColor = System.Drawing.Color.Red;
            this.login_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.login_password.BorderColor = System.Drawing.Color.Gold;
            this.login_password.BorderRadius = 15;
            this.login_password.BorderThickness = 3;
            this.login_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_password.DefaultText = "";
            this.login_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.login_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.login_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_password.DisabledState.Parent = this.login_password;
            this.login_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_password.FocusedState.Parent = this.login_password;
            this.login_password.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.ForeColor = System.Drawing.Color.Black;
            this.login_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_password.HoverState.Parent = this.login_password;
            this.login_password.Location = new System.Drawing.Point(75, 298);
            this.login_password.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.login_password.PlaceholderText = "Şifre";
            this.login_password.SelectedText = "";
            this.login_password.ShadowDecoration.Parent = this.login_password;
            this.login_password.Size = new System.Drawing.Size(305, 36);
            this.login_password.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.login_password.TabIndex = 1;
            // 
            // login_email
            // 
            this.login_email.AllowDrop = true;
            this.login_email.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.login_email.BackColor = System.Drawing.Color.Red;
            this.login_email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.login_email.BorderColor = System.Drawing.Color.Gold;
            this.login_email.BorderRadius = 15;
            this.login_email.BorderThickness = 3;
            this.login_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_email.DefaultText = "";
            this.login_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.login_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.login_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_email.DisabledState.Parent = this.login_email;
            this.login_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_email.FocusedState.Parent = this.login_email;
            this.login_email.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_email.ForeColor = System.Drawing.Color.Black;
            this.login_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_email.HoverState.Parent = this.login_email;
            this.login_email.Location = new System.Drawing.Point(75, 215);
            this.login_email.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.login_email.Name = "login_email";
            this.login_email.PasswordChar = '\0';
            this.login_email.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.login_email.PlaceholderText = "E-posta";
            this.login_email.SelectedText = "";
            this.login_email.ShadowDecoration.Parent = this.login_email;
            this.login_email.Size = new System.Drawing.Size(305, 36);
            this.login_email.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.login_email.TabIndex = 0;
            // 
            // login_exit
            // 
            this.login_exit.AnimationHoverSpeed = 0.07F;
            this.login_exit.AnimationSpeed = 0.03F;
            this.login_exit.BackColor = System.Drawing.Color.Transparent;
            this.login_exit.BaseColor1 = System.Drawing.Color.DeepPink;
            this.login_exit.BaseColor2 = System.Drawing.Color.Red;
            this.login_exit.BorderColor = System.Drawing.Color.White;
            this.login_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.login_exit.FocusedColor = System.Drawing.Color.Empty;
            this.login_exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_exit.ForeColor = System.Drawing.Color.White;
            this.login_exit.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.login_exit.Image = null;
            this.login_exit.ImageSize = new System.Drawing.Size(52, 52);
            this.login_exit.Location = new System.Drawing.Point(394, 12);
            this.login_exit.Name = "login_exit";
            this.login_exit.OnHoverBaseColor1 = System.Drawing.Color.Red;
            this.login_exit.OnHoverBaseColor2 = System.Drawing.Color.Maroon;
            this.login_exit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.login_exit.OnHoverForeColor = System.Drawing.Color.White;
            this.login_exit.OnHoverImage = null;
            this.login_exit.OnPressedColor = System.Drawing.Color.Black;
            this.login_exit.Radius = 15;
            this.login_exit.Size = new System.Drawing.Size(33, 33);
            this.login_exit.TabIndex = 5;
            this.login_exit.Text = "X";
            this.login_exit.Click += new System.EventHandler(this.login_exit_Click);
            // 
            // log_login_button
            // 
            this.log_login_button.AnimationHoverSpeed = 0.07F;
            this.log_login_button.AnimationSpeed = 0.03F;
            this.log_login_button.BackColor = System.Drawing.Color.Transparent;
            this.log_login_button.BaseColor1 = System.Drawing.Color.Yellow;
            this.log_login_button.BaseColor2 = System.Drawing.Color.DarkGoldenrod;
            this.log_login_button.BorderColor = System.Drawing.Color.Black;
            this.log_login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log_login_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.log_login_button.FocusedColor = System.Drawing.Color.Empty;
            this.log_login_button.Font = new System.Drawing.Font("Book Antiqua", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_login_button.ForeColor = System.Drawing.Color.Black;
            this.log_login_button.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.log_login_button.Image = null;
            this.log_login_button.ImageSize = new System.Drawing.Size(52, 52);
            this.log_login_button.Location = new System.Drawing.Point(109, 380);
            this.log_login_button.Name = "log_login_button";
            this.log_login_button.OnHoverBaseColor1 = System.Drawing.Color.Gold;
            this.log_login_button.OnHoverBaseColor2 = System.Drawing.Color.DarkGoldenrod;
            this.log_login_button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.log_login_button.OnHoverForeColor = System.Drawing.Color.Black;
            this.log_login_button.OnHoverImage = null;
            this.log_login_button.OnPressedColor = System.Drawing.Color.Black;
            this.log_login_button.Radius = 25;
            this.log_login_button.Size = new System.Drawing.Size(241, 55);
            this.log_login_button.TabIndex = 3;
            this.log_login_button.Text = "Giriş Yap";
            this.log_login_button.Click += new System.EventHandler(this.log_login_button_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.forgot_panel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1199, 700);
            this.panel2.TabIndex = 1;
            // 
            // forgot_panel
            // 
            this.forgot_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.forgot_panel.Controls.Add(this.birthdate_label);
            this.forgot_panel.Controls.Add(this.forgot_family_name);
            this.forgot_panel.Controls.Add(this.birthdate_TimePicker);
            this.forgot_panel.Controls.Add(this.forgot_name);
            this.forgot_panel.Controls.Add(this.forgot_T_C);
            this.forgot_panel.Controls.Add(this.forgot_email);
            this.forgot_panel.Controls.Add(this.forgot_password_label);
            this.forgot_panel.Controls.Add(this.sig_exit);
            this.forgot_panel.Controls.Add(this.forgot_login_button);
            this.forgot_panel.Controls.Add(this.find_password);
            this.forgot_panel.Location = new System.Drawing.Point(1202, 0);
            this.forgot_panel.Name = "forgot_panel";
            this.forgot_panel.Size = new System.Drawing.Size(443, 700);
            this.forgot_panel.TabIndex = 1;
            // 
            // birthdate_label
            // 
            this.birthdate_label.AutoSize = true;
            this.birthdate_label.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdate_label.ForeColor = System.Drawing.Color.White;
            this.birthdate_label.Location = new System.Drawing.Point(70, 346);
            this.birthdate_label.Name = "birthdate_label";
            this.birthdate_label.Size = new System.Drawing.Size(115, 21);
            this.birthdate_label.TabIndex = 25;
            this.birthdate_label.Text = "Doğum tarihi";
            // 
            // forgot_family_name
            // 
            this.forgot_family_name.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.forgot_family_name.BackColor = System.Drawing.Color.Red;
            this.forgot_family_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.forgot_family_name.BorderColor = System.Drawing.Color.Gold;
            this.forgot_family_name.BorderRadius = 15;
            this.forgot_family_name.BorderThickness = 3;
            this.forgot_family_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.forgot_family_name.DefaultText = "";
            this.forgot_family_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.forgot_family_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.forgot_family_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.forgot_family_name.DisabledState.Parent = this.forgot_family_name;
            this.forgot_family_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.forgot_family_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.forgot_family_name.FocusedState.Parent = this.forgot_family_name;
            this.forgot_family_name.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_family_name.ForeColor = System.Drawing.Color.Black;
            this.forgot_family_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.forgot_family_name.HoverState.Parent = this.forgot_family_name;
            this.forgot_family_name.Location = new System.Drawing.Point(232, 154);
            this.forgot_family_name.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.forgot_family_name.Name = "forgot_family_name";
            this.forgot_family_name.PasswordChar = '\0';
            this.forgot_family_name.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.forgot_family_name.PlaceholderText = "Soyad";
            this.forgot_family_name.SelectedText = "";
            this.forgot_family_name.ShadowDecoration.Parent = this.forgot_family_name;
            this.forgot_family_name.Size = new System.Drawing.Size(147, 36);
            this.forgot_family_name.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.forgot_family_name.TabIndex = 7;
            // 
            // birthdate_TimePicker
            // 
            this.birthdate_TimePicker.BackColor = System.Drawing.Color.Transparent;
            this.birthdate_TimePicker.BorderColor = System.Drawing.Color.Lime;
            this.birthdate_TimePicker.BorderRadius = 15;
            this.birthdate_TimePicker.CheckedState.Parent = this.birthdate_TimePicker;
            this.birthdate_TimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.birthdate_TimePicker.FillColor = System.Drawing.Color.Gold;
            this.birthdate_TimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdate_TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdate_TimePicker.HoverState.Parent = this.birthdate_TimePicker;
            this.birthdate_TimePicker.Location = new System.Drawing.Point(191, 343);
            this.birthdate_TimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.birthdate_TimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.birthdate_TimePicker.Name = "birthdate_TimePicker";
            this.birthdate_TimePicker.ShadowDecoration.Parent = this.birthdate_TimePicker;
            this.birthdate_TimePicker.Size = new System.Drawing.Size(188, 36);
            this.birthdate_TimePicker.TabIndex = 10;
            this.birthdate_TimePicker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.birthdate_TimePicker.Value = new System.DateTime(2021, 1, 20, 14, 10, 15, 300);
            // 
            // forgot_name
            // 
            this.forgot_name.AllowDrop = true;
            this.forgot_name.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.forgot_name.BackColor = System.Drawing.Color.Red;
            this.forgot_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.forgot_name.BorderColor = System.Drawing.Color.Gold;
            this.forgot_name.BorderRadius = 15;
            this.forgot_name.BorderThickness = 3;
            this.forgot_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.forgot_name.DefaultText = "";
            this.forgot_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.forgot_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.forgot_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.forgot_name.DisabledState.Parent = this.forgot_name;
            this.forgot_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.forgot_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.forgot_name.FocusedState.Parent = this.forgot_name;
            this.forgot_name.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_name.ForeColor = System.Drawing.Color.Black;
            this.forgot_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.forgot_name.HoverState.Parent = this.forgot_name;
            this.forgot_name.Location = new System.Drawing.Point(74, 154);
            this.forgot_name.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.forgot_name.Name = "forgot_name";
            this.forgot_name.PasswordChar = '\0';
            this.forgot_name.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.forgot_name.PlaceholderText = "Ad";
            this.forgot_name.SelectedText = "";
            this.forgot_name.ShadowDecoration.Parent = this.forgot_name;
            this.forgot_name.Size = new System.Drawing.Size(146, 36);
            this.forgot_name.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.forgot_name.TabIndex = 6;
            // 
            // forgot_T_C
            // 
            this.forgot_T_C.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.forgot_T_C.BackColor = System.Drawing.Color.Red;
            this.forgot_T_C.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.forgot_T_C.BorderColor = System.Drawing.Color.Gold;
            this.forgot_T_C.BorderRadius = 15;
            this.forgot_T_C.BorderThickness = 3;
            this.forgot_T_C.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.forgot_T_C.DefaultText = "";
            this.forgot_T_C.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.forgot_T_C.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.forgot_T_C.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.forgot_T_C.DisabledState.Parent = this.forgot_T_C;
            this.forgot_T_C.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.forgot_T_C.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.forgot_T_C.FocusedState.Parent = this.forgot_T_C;
            this.forgot_T_C.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_T_C.ForeColor = System.Drawing.Color.Black;
            this.forgot_T_C.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.forgot_T_C.HoverState.Parent = this.forgot_T_C;
            this.forgot_T_C.Location = new System.Drawing.Point(74, 215);
            this.forgot_T_C.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.forgot_T_C.Name = "forgot_T_C";
            this.forgot_T_C.PasswordChar = '\0';
            this.forgot_T_C.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.forgot_T_C.PlaceholderText = "T.C Kimlik No";
            this.forgot_T_C.SelectedText = "";
            this.forgot_T_C.ShadowDecoration.Parent = this.forgot_T_C;
            this.forgot_T_C.Size = new System.Drawing.Size(305, 36);
            this.forgot_T_C.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.forgot_T_C.TabIndex = 8;
            // 
            // forgot_email
            // 
            this.forgot_email.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.forgot_email.BackColor = System.Drawing.Color.Red;
            this.forgot_email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.forgot_email.BorderColor = System.Drawing.Color.Gold;
            this.forgot_email.BorderRadius = 15;
            this.forgot_email.BorderThickness = 3;
            this.forgot_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.forgot_email.DefaultText = "";
            this.forgot_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.forgot_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.forgot_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.forgot_email.DisabledState.Parent = this.forgot_email;
            this.forgot_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.forgot_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.forgot_email.FocusedState.Parent = this.forgot_email;
            this.forgot_email.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_email.ForeColor = System.Drawing.Color.Black;
            this.forgot_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.forgot_email.HoverState.Parent = this.forgot_email;
            this.forgot_email.Location = new System.Drawing.Point(74, 276);
            this.forgot_email.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.forgot_email.Name = "forgot_email";
            this.forgot_email.PasswordChar = '\0';
            this.forgot_email.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.forgot_email.PlaceholderText = "E-posta";
            this.forgot_email.SelectedText = "";
            this.forgot_email.ShadowDecoration.Parent = this.forgot_email;
            this.forgot_email.Size = new System.Drawing.Size(305, 36);
            this.forgot_email.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.forgot_email.TabIndex = 9;
            // 
            // forgot_password_label
            // 
            this.forgot_password_label.BackColor = System.Drawing.Color.Transparent;
            this.forgot_password_label.Font = new System.Drawing.Font("Noto Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_password_label.ForeColor = System.Drawing.Color.Gold;
            this.forgot_password_label.Location = new System.Drawing.Point(48, 36);
            this.forgot_password_label.Name = "forgot_password_label";
            this.forgot_password_label.Size = new System.Drawing.Size(283, 49);
            this.forgot_password_label.TabIndex = 14;
            this.forgot_password_label.Text = "Şifremi Unuttum";
            // 
            // sig_exit
            // 
            this.sig_exit.AnimationHoverSpeed = 0.07F;
            this.sig_exit.AnimationSpeed = 0.03F;
            this.sig_exit.BackColor = System.Drawing.Color.Transparent;
            this.sig_exit.BaseColor1 = System.Drawing.Color.DeepPink;
            this.sig_exit.BaseColor2 = System.Drawing.Color.Red;
            this.sig_exit.BorderColor = System.Drawing.Color.White;
            this.sig_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sig_exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.sig_exit.FocusedColor = System.Drawing.Color.Empty;
            this.sig_exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sig_exit.ForeColor = System.Drawing.Color.White;
            this.sig_exit.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.sig_exit.Image = null;
            this.sig_exit.ImageSize = new System.Drawing.Size(0, 0);
            this.sig_exit.Location = new System.Drawing.Point(394, 12);
            this.sig_exit.Name = "sig_exit";
            this.sig_exit.OnHoverBaseColor1 = System.Drawing.Color.Red;
            this.sig_exit.OnHoverBaseColor2 = System.Drawing.Color.Maroon;
            this.sig_exit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.sig_exit.OnHoverForeColor = System.Drawing.Color.White;
            this.sig_exit.OnHoverImage = null;
            this.sig_exit.OnPressedColor = System.Drawing.Color.Black;
            this.sig_exit.Radius = 15;
            this.sig_exit.Size = new System.Drawing.Size(33, 33);
            this.sig_exit.TabIndex = 13;
            this.sig_exit.Text = "X";
            this.sig_exit.Click += new System.EventHandler(this.forgot_exit_Click);
            // 
            // forgot_login_button
            // 
            this.forgot_login_button.AnimationHoverSpeed = 0.07F;
            this.forgot_login_button.AnimationSpeed = 0.03F;
            this.forgot_login_button.BackColor = System.Drawing.Color.Transparent;
            this.forgot_login_button.BaseColor1 = System.Drawing.Color.Yellow;
            this.forgot_login_button.BaseColor2 = System.Drawing.Color.DarkGoldenrod;
            this.forgot_login_button.BorderColor = System.Drawing.Color.Black;
            this.forgot_login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgot_login_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.forgot_login_button.FocusedColor = System.Drawing.Color.Empty;
            this.forgot_login_button.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_login_button.ForeColor = System.Drawing.Color.Black;
            this.forgot_login_button.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.forgot_login_button.Image = null;
            this.forgot_login_button.ImageSize = new System.Drawing.Size(52, 52);
            this.forgot_login_button.Location = new System.Drawing.Point(110, 539);
            this.forgot_login_button.Name = "forgot_login_button";
            this.forgot_login_button.OnHoverBaseColor1 = System.Drawing.Color.Gold;
            this.forgot_login_button.OnHoverBaseColor2 = System.Drawing.Color.DarkGoldenrod;
            this.forgot_login_button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.forgot_login_button.OnHoverForeColor = System.Drawing.Color.Black;
            this.forgot_login_button.OnHoverImage = null;
            this.forgot_login_button.OnPressedColor = System.Drawing.Color.Black;
            this.forgot_login_button.Radius = 25;
            this.forgot_login_button.Size = new System.Drawing.Size(241, 51);
            this.forgot_login_button.TabIndex = 12;
            this.forgot_login_button.Text = "Giriş Yap";
            this.forgot_login_button.Click += new System.EventHandler(this.forgot_login_button_Click);
            // 
            // find_password
            // 
            this.find_password.AnimationHoverSpeed = 0.07F;
            this.find_password.AnimationSpeed = 0.03F;
            this.find_password.BackColor = System.Drawing.Color.Transparent;
            this.find_password.BaseColor1 = System.Drawing.Color.Blue;
            this.find_password.BaseColor2 = System.Drawing.Color.CornflowerBlue;
            this.find_password.BorderColor = System.Drawing.Color.Black;
            this.find_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.find_password.DialogResult = System.Windows.Forms.DialogResult.None;
            this.find_password.FocusedColor = System.Drawing.Color.Empty;
            this.find_password.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Bold);
            this.find_password.ForeColor = System.Drawing.Color.White;
            this.find_password.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.find_password.Image = null;
            this.find_password.ImageSize = new System.Drawing.Size(52, 52);
            this.find_password.Location = new System.Drawing.Point(110, 448);
            this.find_password.Name = "find_password";
            this.find_password.OnHoverBaseColor1 = System.Drawing.Color.MediumBlue;
            this.find_password.OnHoverBaseColor2 = System.Drawing.Color.Navy;
            this.find_password.OnHoverBorderColor = System.Drawing.Color.Red;
            this.find_password.OnHoverForeColor = System.Drawing.Color.White;
            this.find_password.OnHoverImage = null;
            this.find_password.OnPressedColor = System.Drawing.Color.Black;
            this.find_password.Radius = 25;
            this.find_password.Size = new System.Drawing.Size(241, 55);
            this.find_password.TabIndex = 11;
            this.find_password.Text = "şifremi Bul";
            this.find_password.Click += new System.EventHandler(this.find_password_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nallıhan_Kütüphane_Otomasyon_Sistemi.Properties.Resources._19790;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(759, 700);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // login_timer
            // 
            this.login_timer.Interval = 10;
            this.login_timer.Tick += new System.EventHandler(this.login_timer_event);
            // 
            // forgot_timer
            // 
            this.forgot_timer.Interval = 10;
            this.forgot_timer.Tick += new System.EventHandler(this.forgot_timer_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Login
            // 
            this.AcceptButton = this.log_login_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.login_exit;
            this.ClientSize = new System.Drawing.Size(1199, 700);
            this.Controls.Add(this.Login_panel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Login_panel.ResumeLayout(false);
            this.Login_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.forgot_panel.ResumeLayout(false);
            this.forgot_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Login_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaGradientTileButton login_exit;
        private Guna.UI.WinForms.GunaGradientTileButton log_login_button;
        private System.Windows.Forms.Panel forgot_panel;
        private Guna.UI.WinForms.GunaGradientTileButton sig_exit;
        private Guna.UI.WinForms.GunaGradientTileButton forgot_login_button;
        private Guna.UI.WinForms.GunaGradientTileButton find_password;
        private System.Windows.Forms.Timer login_timer;
        private System.Windows.Forms.Timer forgot_timer;
        private Guna.UI2.WinForms.Guna2TextBox login_email;
        private Guna.UI2.WinForms.Guna2TextBox login_password;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox forgot_family_name;
        private Guna.UI2.WinForms.Guna2DateTimePicker birthdate_TimePicker;
        private Guna.UI2.WinForms.Guna2TextBox forgot_name;
        private Guna.UI2.WinForms.Guna2TextBox forgot_T_C;
        private Guna.UI2.WinForms.Guna2TextBox forgot_email;
        private Guna.UI2.WinForms.Guna2HtmlLabel forgot_password_label;
        private System.Windows.Forms.Label birthdate_label;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.LinkLabel forgot_password_LinkLable;
        private System.Windows.Forms.Label label1;
    }
}