
namespace Nallıhan_Kütüphane_Otomasyon_Sistemi
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.Loading_time = new System.Windows.Forms.Timer(this.components);
            this.Loading_persent = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Farsi Simple Outline", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(131, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 94);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nallıhan\r\nKütüphane Otomasyon Sistemi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.FillColor = System.Drawing.Color.Transparent;
            this.progressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.progressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.progressBar1.Location = new System.Drawing.Point(2, 389);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ProgressColor = System.Drawing.Color.Red;
            this.progressBar1.ProgressColor2 = System.Drawing.Color.Blue;
            this.progressBar1.ShadowDecoration.Parent = this.progressBar1;
            this.progressBar1.Size = new System.Drawing.Size(696, 10);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // Loading_time
            // 
            this.Loading_time.Interval = 50;
            this.Loading_time.Tick += new System.EventHandler(this.Loading_time_Tick);
            // 
            // Loading_persent
            // 
            this.Loading_persent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Loading_persent.BackColor = System.Drawing.Color.Transparent;
            this.Loading_persent.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loading_persent.Location = new System.Drawing.Point(318, 260);
            this.Loading_persent.Name = "Loading_persent";
            this.Loading_persent.Size = new System.Drawing.Size(3, 2);
            this.Loading_persent.TabIndex = 3;
            this.Loading_persent.Text = null;
            this.Loading_persent.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.Loading_persent);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loading";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Loading_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar1;
        private System.Windows.Forms.Timer Loading_time;
        private Guna.UI2.WinForms.Guna2HtmlLabel Loading_persent;
    }
}

