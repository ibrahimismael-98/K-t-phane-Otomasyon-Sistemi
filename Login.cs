using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;

namespace Nallıhan_Kütüphane_Otomasyon_Sistemi
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PFSJNPL\DATA;Initial Catalog=Library;Integrated Security=True");
        public static string user_pass_name;
        public static string user_pass_FamilyName;
        public static string user_pass_Email;

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
             int nHeightEllipse
        );

        Boolean şart;
        int sayı;

        // Giriş

        private void log_login_button_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            şart = int.TryParse(login_email.Text, out sayı);
            if (login_email.Text == "" || login_password.Text == "")
            {
                if (login_email.Text == "")
                {
                    Interaction.Beep();
                    errorProvider1.SetError(login_email, "E-posta alanı boş geçilemez!");
                }
                else if (login_password.Text == "")
                {
                    Interaction.Beep();
                    errorProvider1.SetError(login_password, "Kullanıcı Şifre alanı boş geçilemez!");
                }
            }
            else if (login_password.Text.Length < 5)
            {
                Interaction.Beep();
                errorProvider1.SetError(login_password, "Kullanıcı Şifre alanı en az 5 karakterden oluşmalıdır!");
            }
            else
            {
                if (şart == true)
                {
                    Interaction.Beep();
                    errorProvider1.SetError(login_email, "E-posta alanı sadece sayılardan oluşmazdır!");
                }
                else
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select * from Employees where Email='" + login_email.Text + "' and Password='" + login_password.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        con.Open();
                        SqlCommand scom = new SqlCommand("select * from Employees where Email = '" + login_email.Text + "' and Password = '" + login_password.Text + "'", con);
                        SqlDataReader reader = scom.ExecuteReader();
                        reader.Read();
                        user_pass_name = reader["Name"].ToString();
                        user_pass_FamilyName = reader["FamilyName"].ToString();
                        user_pass_Email = reader["Email"].ToString();
                        con.Close();

                        Main_form m_frm = new Main_form();
                        m_frm.Show();
                        this.Hide();
                    }
                    else if (dt.Rows.Count != 1)
                    {
                        MessageBox.Show("Girdiğiniz kullanıcı E-posta ya da şifre yanlış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void login_timer_event(object sender, EventArgs e)
        {
            Login_panel.Left += 40;
            forgot_panel.Left -= 40;
            if (forgot_panel.Left <= 770)
            {
                login_timer.Stop();
            }
        }
        
        private void forgot_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login_timer.Start();
        }

        private void login_exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        //////   Şifremi Unuttum


        public void find_password_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            şart = int.TryParse(forgot_email.Text, out sayı);
            if (forgot_name.Text == "" || forgot_family_name.Text == "" || forgot_T_C.Text == "" || forgot_email.Text == "")
            {
                if (forgot_name.Text == "")
                {
                    Interaction.Beep();
                    errorProvider1.SetError(forgot_name, "Kullanıcı Adı alanı boş geçilemez!");
                }
                else if (forgot_family_name.Text == "")
                {
                    Interaction.Beep();
                    errorProvider1.SetError(forgot_family_name, "Soyad alanı boş geçilemez!");
                }
                else if (forgot_T_C.Text == "")
                {
                    Interaction.Beep();
                    errorProvider1.SetError(forgot_T_C, "TC Kimlik No alanı boş geçilemez!");
                }
                else if (forgot_email.Text == "")
                {
                    Interaction.Beep();
                    errorProvider1.SetError(forgot_email, "E-posta alanı boş geçilemez!");
                }
            }
            else if (forgot_T_C.Text.Length < 11)
            {
                Interaction.Beep();
                errorProvider1.SetError(forgot_T_C, "TC Kimlik No 11 haneden oluşur!");
            }
            else if (şart == true)
            {
                Interaction.Beep();
                errorProvider1.SetError(forgot_email, "E-posta alanı sadece sayılardan oluşmazdır!");
            }

            SqlDataAdapter sda = new SqlDataAdapter("select * from Employees where Name='" + forgot_name.Text + "' and FamilyName='" + forgot_family_name.Text + "'and [T.C]='" + forgot_T_C.Text + "'and Email='" + forgot_email.Text + "'and Birthdate='" + birthdate_TimePicker.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                Label found_password=new Label();
                con.Open();
                SqlCommand scom = new SqlCommand("select * from Employees where Name='" + forgot_name.Text + "' and FamilyName='" + forgot_family_name.Text + "'and [T.C]='" + forgot_T_C.Text + "'and Email='" + forgot_email.Text + "'and Birthdate='" + birthdate_TimePicker.Text + "'", con);
                SqlDataReader reader = scom.ExecuteReader();
                reader.Read();
                found_password.Text = reader["Password"].ToString();
                MessageBox.Show("Şifreniz: " + found_password.Text, "Bulunan Şifre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();

            }
            else if (dt.Rows.Count != 1 && forgot_name.Text != "" && forgot_family_name.Text != "" && forgot_T_C.Text != "" && forgot_email.Text != "" && birthdate_TimePicker.Text!="")
            {
                MessageBox.Show("Girdiğiniz kullanıcı Bilgileri yanlış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void forgot_login_button_Click(object sender, EventArgs e)
        {
            forgot_timer.Start();
        }

        private void forgot_timer_Tick(object sender, EventArgs e)
        {
            Login_panel.Left -= 40;
            forgot_panel.Left += 40;
            if (Login_panel.Left <= 770)
            {
                forgot_timer.Stop();
            }
        }
        
        private void forgot_exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
