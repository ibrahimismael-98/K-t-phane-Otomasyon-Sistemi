using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Nallıhan_Kütüphane_Otomasyon_Sistemi
{
    public partial class Main_form : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-PFSJNPL\DATA;Initial Catalog=Library;Integrated Security=True");

        public Main_form()
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

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Çikmak istediğine emin misin?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dr == DialogResult.Yes)
            {
                Login retuern_login = new Login();
                retuern_login.Show();
                this.Hide();
            }
        }

        public void Main_form_Load(object sender, EventArgs e)
        {
            saat_show.Start();
            // TODO: This line of code loads data into the 'libraryDataSet9.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.libraryDataSet9.Employees);
            // TODO: This line of code loads data into the 'libraryDataSet8.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter4.Fill(this.libraryDataSet8.Books);
            // TODO: This line of code loads data into the 'libraryDataSet7.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter3.Fill(this.libraryDataSet7.Books);
            // TODO: This line of code loads data into the 'libraryDataSet6.Lendes' table. You can move, or remove it, as needed.
            this.lendesTableAdapter.Fill(this.libraryDataSet6.Lendes);
            // TODO: This line of code loads data into the 'libraryDataSet5.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter2.Fill(this.libraryDataSet5.Books);
            // TODO: This line of code loads data into the 'libraryDataSet1.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.libraryDataSet1.Students);

            dashbord_panel_small.Visible = true;
            student_panel_small.Visible = false;
            book_panel_small.Visible = false;
            lending_panel_small.Visible = false;
            user_panel.Visible = false;

            // open panel
            dashbord_panel.Visible = true;
            Students_panel.Visible = false;
            books_panel.Visible = false;
            lending_panel.Visible = false;

            dashboard_label.Visible = false;
            students_label.Visible = false;
            books_label.Visible = false;
            lending_label.Visible = false;
            user_panel.Visible = false;

            user_name.Text = Login.user_pass_name;
            user_family_name.Text = Login.user_pass_FamilyName;
            user_email.Text = Login.user_pass_Email;


            // Students count
            count_of_member.Text = studentsBindingSource.Count.ToString();

            //books count
            book_count.Text = booksBindingSource4.Count.ToString();

            //lends count
            sum_dept.Text = lendesBindingSource.Count.ToString();
        }

        private void dashbord_Click(object sender, EventArgs e)
        {
            dashbord_panel_small.Visible = true;
            student_panel_small.Visible = false;
            book_panel_small.Visible = false;
            lending_panel_small.Visible = false;

            // open panel
            dashbord_panel.Visible = true;
            Students_panel.Visible = false;
            books_panel.Visible = false;
            lending_panel.Visible = false;
        }

        private void students_Click_1(object sender, EventArgs e)
        {
            dashbord_panel_small.Visible = false;
            student_panel_small.Visible = true;
            book_panel_small.Visible = false;
            lending_panel_small.Visible = false;

            // open panel
            dashbord_panel.Visible = false;
            Students_panel.Visible = true;
            books_panel.Visible = false;
            lending_panel.Visible = false;

            DataTable dt_students = new DataTable();
            SqlDataAdapter sql_students = new SqlDataAdapter("select * from Students", con);
            sql_students.Fill(dt_students);
            Student_dataGridview.DataSource = dt_students;
            Student_dataGridview.Refresh();
        }

        private void books_Click(object sender, EventArgs e)
        {
            dashbord_panel_small.Visible = false;
            student_panel_small.Visible = false;
            book_panel_small.Visible = true;
            lending_panel_small.Visible = false;

            // open panel
            dashbord_panel.Visible = false;
            Students_panel.Visible = false;
            books_panel.Visible = true;
            lending_panel.Visible = false;

            DataTable dt_books = new DataTable();
            SqlDataAdapter sqld = new SqlDataAdapter("select * from Books", con);
            sqld.Fill(dt_books);
            books_gridview.DataSource = dt_books;
            books_gridview.Refresh();
        }

        private void lending_Click(object sender, EventArgs e)
        {
            dashbord_panel_small.Visible = false;
            student_panel_small.Visible = false;
            book_panel_small.Visible = false;
            lending_panel_small.Visible = true;

            // open panel
            dashbord_panel.Visible = false;
            Students_panel.Visible = false;
            books_panel.Visible = false;
            lending_panel.Visible = true;
        }

        private void user_MouseMove(object sender, MouseEventArgs e)
        {
            user_panel.Visible = true;
        }

        private void dashbord_panel_MouseHover(object sender, EventArgs e)
        {
            user_panel.Visible = false;
        }

        private void menubar_panel_MouseHover(object sender, EventArgs e)
        {
            user_panel.Visible = false;
        }

        private void menubar_MouseHover(object sender, EventArgs e)
        {
            user_panel.Visible = false;
        }

        private void dashbord_MouseMove(object sender, MouseEventArgs e)
        {
            dashboard_label.Visible = true;
            students_label.Visible = false;
            books_label.Visible = false;
            lending_label.Visible = false;
            user_panel.Visible = false;
        }

        private void students_MouseMove(object sender, MouseEventArgs e)
        {
            dashboard_label.Visible = false;
            students_label.Visible = true;
            books_label.Visible = false;
            lending_label.Visible = false;
            user_panel.Visible = false;
        }

        private void books_MouseMove(object sender, MouseEventArgs e)
        {
            dashboard_label.Visible = false;
            students_label.Visible = false;
            books_label.Visible = true;
            lending_label.Visible = false;
            user_panel.Visible = false;
        }

        private void lending_MouseMove(object sender, MouseEventArgs e)
        {
            dashboard_label.Visible = false;
            students_label.Visible = false;
            books_label.Visible = false;
            lending_label.Visible = true;
            user_panel.Visible = false;
        }

        private void guna2CustomGradientPanel8_MouseHover(object sender, EventArgs e)
        {
            user_panel.Visible = false;
        }

        private void Student_dataGridview_MouseMove(object sender, MouseEventArgs e)
        {
            user_panel.Visible = false;
        }

        private void dashbord_MouseLeave(object sender, EventArgs e)
        {
            dashboard_label.Visible = false;
        }

        private void students_MouseLeave(object sender, EventArgs e)
        {
            students_label.Visible = false;
        }

        private void books_MouseLeave(object sender, EventArgs e)
        {
            books_label.Visible = false;
        }

        private void lending_MouseLeave(object sender, EventArgs e)
        {
            lending_label.Visible = false;
        }

        private void guna2CustomGradientPanel16_MouseMove(object sender, MouseEventArgs e)
        {
            user_panel.Visible = false;
        }

        private void guna2PictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            user_panel.Visible = false;
        }

        private void EmployeesDataGridView_MouseMove(object sender, MouseEventArgs e)
        {
            user_panel.Visible = false;
        }

        private void calisan_ekle_MouseMove(object sender, MouseEventArgs e)
        {
            user_panel.Visible = false;
        }

        private void guna2CustomGradientPanel15_MouseMove(object sender, MouseEventArgs e)
        {
            user_panel.Visible = false;
        }

        private void students_insert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Students(Student_no,Name,FamilyName,[T.C],Email,Phone,Birthdate,Gender,Department,Class,Registration_date,Number_books_read,Punished,Explain) " +
                    "values('" + Student_dataGridview.CurrentRow.Cells[0].Value.ToString() + "','" +
                    Student_dataGridview.CurrentRow.Cells[1].Value.ToString() + "','" +
                    Student_dataGridview.CurrentRow.Cells[2].Value.ToString() + "','" +
                    Student_dataGridview.CurrentRow.Cells[3].Value.ToString() + "','" +
                    Student_dataGridview.CurrentRow.Cells[4].Value.ToString() + "','" +
                    Student_dataGridview.CurrentRow.Cells[5].Value.ToString() + "','" +
                    Student_dataGridview.CurrentRow.Cells[6].Value.ToString() + "','" +
                    Student_dataGridview.CurrentRow.Cells[7].Value.ToString() + "','" +
                    Student_dataGridview.CurrentRow.Cells[8].Value.ToString() + "','" +
                    Student_dataGridview.CurrentRow.Cells[9].Value.ToString() + "','" +
                    Student_dataGridview.CurrentRow.Cells[10].Value.ToString() + "','" +
                    Student_dataGridview.CurrentRow.Cells[11].Value.ToString() + "','" +
                    Student_dataGridview.CurrentRow.Cells[12].Value.ToString() + "','" +
                    Student_dataGridview.CurrentRow.Cells[13].Value.ToString() + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                DataTable dt = new DataTable();
                SqlDataAdapter sa = new SqlDataAdapter("select * from Students", con);
                sa.Fill(dt);
                Student_dataGridview.DataSource = dt;
                Student_dataGridview.Refresh();
                MessageBox.Show("Veri Eklendi");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Data.ToString(), "Eklenmedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void students_update_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Güncelleme istediğinizden emin misiniz?", "Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("update Students set " +
                                "Name='" + Student_dataGridview.CurrentRow.Cells[1].Value.ToString() + "', " +
                                "FamilyName='" + Student_dataGridview.CurrentRow.Cells[2].Value.ToString() + "', " +
                                "[T.C]='" + Student_dataGridview.CurrentRow.Cells[3].Value.ToString() + "', " +
                                "Email='" + Student_dataGridview.CurrentRow.Cells[4].Value.ToString() + "'," +
                                "Phone='" + Student_dataGridview.CurrentRow.Cells[5].Value.ToString() + "'," +
                                "Birthdate='" + Student_dataGridview.CurrentRow.Cells[6].Value.ToString() + "'," +
                                "Gender='" + Student_dataGridview.CurrentRow.Cells[7].Value.ToString() + "'," +
                                "Department='" + Student_dataGridview.CurrentRow.Cells[8].Value.ToString() + "'," +
                                "Class='" + Student_dataGridview.CurrentRow.Cells[9].Value.ToString() + "'," +
                                "Registration_date='" + Student_dataGridview.CurrentRow.Cells[10].Value.ToString() + "'," +
                                "Number_books_read='" + Student_dataGridview.CurrentRow.Cells[11].Value.ToString() + "'," +
                                "Punished='" + Student_dataGridview.CurrentRow.Cells[12].Value.ToString() + "'," +
                                "Explain='" + Student_dataGridview.CurrentRow.Cells[13].Value.ToString() + "'" +
                                "where Student_no='" + Student_dataGridview.CurrentRow.Cells[0].Value.ToString() + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DataTable dt = new DataTable();
                    SqlCommand scmd = new SqlCommand();
                    SqlDataAdapter sa = new SqlDataAdapter("select * from Students", con);
                    sa.Fill(dt);
                    Student_dataGridview.DataSource = dt;
                    Student_dataGridview.Refresh();
                    MessageBox.Show("Veri Güncellendi.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Data.ToString(), "Güncellenmedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void students_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Silmek istediğine emin misin?", "Silmek", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("delete Students where Student_no='" + Student_dataGridview.CurrentRow.Cells[0].Value.ToString() + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sqld = new SqlDataAdapter("select * from Students", con);
                    sqld.Fill(dt);
                    Student_dataGridview.DataSource = dt;
                    Student_dataGridview.Refresh();
                    MessageBox.Show("Veri silindi");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Data.ToString(), "Silinmedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // books panel
        private void books_insert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Books(count_book,Barcode,Type,Books_Name,Author,Edition,Pages,Explain,Date,Reader,Score,Note) " +
                    "values('" + books_gridview.CurrentRow.Cells[1].Value.ToString() + "','" +
                    books_gridview.CurrentRow.Cells[2].Value.ToString() + "','" +
                    books_gridview.CurrentRow.Cells[3].Value.ToString() + "','" +
                    books_gridview.CurrentRow.Cells[4].Value.ToString() + "','" +
                    books_gridview.CurrentRow.Cells[5].Value.ToString() + "','" +
                    books_gridview.CurrentRow.Cells[6].Value.ToString() + "','" +
                    books_gridview.CurrentRow.Cells[7].Value.ToString() + "','" +
                    books_gridview.CurrentRow.Cells[8].Value.ToString() + "','" +
                    books_gridview.CurrentRow.Cells[9].Value.ToString() + "','" +
                    books_gridview.CurrentRow.Cells[10].Value.ToString() + "','" +
                    books_gridview.CurrentRow.Cells[11].Value.ToString() + "','" +
                    books_gridview.CurrentRow.Cells[12].Value.ToString() + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                DataTable dt = new DataTable();
                SqlDataAdapter sa = new SqlDataAdapter("select * from Books", con);
                sa.Fill(dt);
                books_gridview.DataSource = dt;
                books_gridview.Refresh();
                MessageBox.Show("Veri eklendi");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Data.ToString(), "Eklenmedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void books_update_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Güncelleme istediğinizden emin misiniz?", "Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("update Books set " +
                                "count_book='" + books_gridview.CurrentRow.Cells[1].Value.ToString() + "'," +
                                "Barcode='" + books_gridview.CurrentRow.Cells[2].Value.ToString() + "', " +
                                "Type='" + books_gridview.CurrentRow.Cells[3].Value.ToString() + "', " +
                                "Books_Name='" + books_gridview.CurrentRow.Cells[4].Value.ToString() + "', " +
                                "Author='" + books_gridview.CurrentRow.Cells[5].Value.ToString() + "', " +
                                "Edition='" + books_gridview.CurrentRow.Cells[6].Value.ToString() + "'," +
                                "Pages='" + books_gridview.CurrentRow.Cells[7].Value.ToString() + "'," +
                                "Explain='" + books_gridview.CurrentRow.Cells[8].Value.ToString() + "'," +
                                "Date='" + books_gridview.CurrentRow.Cells[9].Value.ToString() + "'," +
                                "Reader='" + books_gridview.CurrentRow.Cells[10].Value.ToString() + "'," +
                                "Score='" + books_gridview.CurrentRow.Cells[11].Value.ToString() + "'," +
                                "Note='" + books_gridview.CurrentRow.Cells[12].Value.ToString() + "'" +
                                "where ID='" + books_gridview.CurrentRow.Cells[0].Value.ToString() + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sa = new SqlDataAdapter("select * from Books", con);
                    sa.Fill(dt);
                    books_gridview.DataSource = dt;
                    books_gridview.Refresh();
                    MessageBox.Show("Veri Güncellendi.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Data.ToString(), "Güncellenmedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void books_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Silmek istediğine emin misin?", "Silmek", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("delete Books where ID='" + books_gridview.CurrentRow.Cells[0].Value.ToString() + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sqld = new SqlDataAdapter("select * from Books", con);
                    sqld.Fill(dt);
                    books_gridview.DataSource = dt;
                    books_gridview.Refresh();
                    MessageBox.Show("Veri Silindi");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Data.ToString(), "Silinmedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Label image_path_insert = new Label();

        private void books_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==12)
            {
                if (book_image_openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    image_path_insert.Text = book_image_openFileDialog.FileName;
                }
            }
        }

        private void student_search_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Students where Student_no like '%" + student_search.Text + "%' or Name like '%" + student_search.Text + "%' or FamilyName like '%" + student_search.Text + "%' or [T.C] like '%" + student_search.Text + "%' or Email like '%" + student_search.Text + "%' or Phone like '%" + student_search.Text + "%' or Birthdate like '%" + student_search.Text + "%' or Gender like '%" + student_search.Text + "%' or Department like '%" + student_search.Text + "%' or Class like '%" + student_search.Text + "%' or Registration_date like '%" + student_search.Text + "%' or Number_books_read like '%" + student_search.Text + "%' or Punished like '%" + student_search.Text + "%' or Explain like '%" + student_search.Text + "%'", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            Student_dataGridview.DataSource = dt;
            Student_dataGridview.Refresh();
        }
        
        private void lending_insert_Click(object sender, EventArgs e)
        {
            string user = Login.user_pass_name;

            string Giving_date = DateTime.Now.ToString("MM/dd/yyyy");

            DateTime? Return_date = DateTime.Now.Add(new TimeSpan(15, 0, 0, 0, 0));  // add 15 day

            SqlDataAdapter adp = new SqlDataAdapter("select Student_no from Students where Student_no =" + lending__dataGridview.CurrentRow.Cells[2].Value.ToString(), con);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            SqlDataAdapter adp4 = new SqlDataAdapter("select Student_no,Punished from Students where Student_no =" + lending__dataGridview.CurrentRow.Cells[2].Value.ToString()+ "and Punished ='yok'", con);
            DataTable dt4 = new DataTable();
            adp4.Fill(dt4);

            SqlDataAdapter adp3 = new SqlDataAdapter("select ID,count_book from Books where ID =" + lending__dataGridview.CurrentRow.Cells[1].Value.ToString(), con);
            DataTable dt3 = new DataTable();
            adp3.Fill(dt3);

            SqlDataAdapter adp2 = new SqlDataAdapter("select count_book from Books where ID =" + lending__dataGridview.CurrentRow.Cells[1].Value.ToString()+ "and count_book >='1'", con);
            DataTable dt2 = new DataTable();
            adp2.Fill(dt2);

            if (dt.Rows.Count != 1)
            {
                MessageBox.Show("Yazdığınız öğrenci numarası kayıtlı değil.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dt4.Rows.Count != 1)
            {
                MessageBox.Show("Yazmış olduğunuz öğrenci numarası cezalandırılmış.\n ondan dolayı bir daha kitap ödünç olarak alamaz.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (dt3.Rows.Count != 1)
            {
                MessageBox.Show("Yazdığınız kitap ID kayıtlı değil.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dt2.Rows.Count!=1)
            {
                MessageBox.Show("Yazmış olduğunuz kitap numarası kalmamış.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("insert into Lendes(ID_Book,Student_no,Giving_Date,Return_Date,Employee_Name) " +
                    "values('" + lending__dataGridview.CurrentRow.Cells[1].Value.ToString() + "','" +
                    lending__dataGridview.CurrentRow.Cells[2].Value.ToString() + "','" +
                    Giving_date.ToString() + "','" +
                    Return_date.ToString() + "','" +
                    user.ToString() + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DataTable dt1 = new DataTable();
                    SqlDataAdapter sa = new SqlDataAdapter("select * from Lendes", con);
                    sa.Fill(dt1);
                    lending__dataGridview.DataSource = dt1;
                    lending__dataGridview.Refresh();
                    MessageBox.Show("Veri Eklendi");

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Data.ToString(), "Eklenmedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lending_update_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Güncelleme istediğinizden emin misiniz?", "Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("update Lendes set " +
                                "ID_Book='" + lending__dataGridview.CurrentRow.Cells[1].Value.ToString() + "', " +
                                "Student_no='" + lending__dataGridview.CurrentRow.Cells[2].Value.ToString() + "', " +
                                "Giving_Date='" + lending__dataGridview.CurrentRow.Cells[3].Value.ToString() + "', " +
                                "Return_Date='" + lending__dataGridview.CurrentRow.Cells[4].Value.ToString() + "'," +
                                "Employee_Name='" + lending__dataGridview.CurrentRow.Cells[5].Value.ToString() + "'" +
                                "where ID_Lend ='" + lending__dataGridview.CurrentRow.Cells[0].Value.ToString() + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sa = new SqlDataAdapter("select * from Lendes", con);
                    sa.Fill(dt);
                    lending__dataGridview.DataSource = dt;
                    lending__dataGridview.Refresh();
                    MessageBox.Show("Veri Güncellendi.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Data.ToString(), "Güncellenmedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lending_delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Silmek istediğine emin misin?", "Silmek", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("delete Lendes where ID_Lend='" + lending__dataGridview.CurrentRow.Cells[0].Value.ToString() + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sqld = new SqlDataAdapter("select * from Lendes", con);
                    sqld.Fill(dt);
                    lending__dataGridview.DataSource = dt;
                    lending__dataGridview.Refresh();
                    SqlCommand cmd_b = new SqlCommand("update Books set count_book +=1 where ID ='" + lending__dataGridview.CurrentRow.Cells[1].Value.ToString() + "'", con);
                    con.Open();
                    cmd_b.ExecuteNonQuery();
                    con.Close();


                    MessageBox.Show("Veri Silindi");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Data.ToString(), "Silinmedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lending_search_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Lendes where ID_Lend like '%" + lending_search.Text + "%' or ID_Book like '%" + lending_search.Text + "%' or Student_no like '%" + lending_search.Text + "%' or Employee_Name like '%"+ lending_search.Text + "%' or Giving_Date like '%" + lending_search.Text + "%' or Return_Date like '%" + lending_search.Text + "%'", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            lending__dataGridview.DataSource = dt;
            lending__dataGridview.Refresh();
        }

        private void book_search_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Books where ID like '%" + book_search.Text + "%' or Barcode like '%" + book_search.Text + "%' or Type like '%" + book_search.Text + "%' or Author like '%" + book_search.Text + "%' or Explain like '%" + book_search.Text + "%' or Score like '%" + book_search.Text + "%'or Books_Name like '%" + book_search.Text + "%'", con);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            books_gridview.DataSource = dt;
            books_gridview.Refresh();
        }

        private void saat_show_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.saat.Text = dateTime.ToString("h:mm:ss tt");
            DataTable dt_employees = new DataTable();
            SqlDataAdapter sdp = new SqlDataAdapter("select name,FamilyName,Phone from Employees",con);
            sdp.Fill(dt_employees);
            EmployeesDataGridView.DataSource = dt_employees;
            EmployeesDataGridView.Refresh();
        }

        private void calisan_ekle_Click(object sender, EventArgs e)
        {
            Add_Employee uye_ekle = new Add_Employee();
            uye_ekle.ShowDialog();
        }
    }
}