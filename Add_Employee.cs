using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Nallıhan_Kütüphane_Otomasyon_Sistemi
{
    public partial class Add_Employee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PFSJNPL\DATA;Initial Catalog=Library;Integrated Security=True");

        public Add_Employee()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void books_update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Employees([T.C],name,FamilyName,Email,Password,Phone,Birthdate,Gender)" +
                                    "values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + birthdate.Text + "','" + ComboBox1.Text + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("veri eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Data.ToString(), "eklenmedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
