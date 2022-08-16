﻿using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Nallıhan_Kütüphane_Otomasyon_Sistemi
{
    public partial class Loading : Form
    {
        public Loading()
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

        private void Loading_Load(object sender, EventArgs e)
        {
            Loading_time.Start();
        }

        Login logform = new Login();
        private void Loading_time_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == progressBar1.Maximum)
            {
                Loading_time.Stop();
                this.Hide();
                logform.Visible = true;
            }
            else
            {
                progressBar1.Value += 1;
                Loading_persent.Text = progressBar1.Value.ToString() + " %";
                logform.Activate();
                logform.Enabled = true;
            }
        }
    }
}
