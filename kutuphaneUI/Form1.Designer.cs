namespace kutuphaneUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uyeEkleMenuButonu = new System.Windows.Forms.Button();
            this.kitapEkleMenuButonu = new System.Windows.Forms.Button();
            this.kitapUyeMenuButonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uyeEkleMenuButonu
            // 
            this.uyeEkleMenuButonu.AccessibleName = "";
            this.uyeEkleMenuButonu.Location = new System.Drawing.Point(74, 100);
            this.uyeEkleMenuButonu.Name = "uyeEkleMenuButonu";
            this.uyeEkleMenuButonu.Size = new System.Drawing.Size(177, 80);
            this.uyeEkleMenuButonu.TabIndex = 0;
            this.uyeEkleMenuButonu.Text = "Üye Ayarları";
            this.uyeEkleMenuButonu.UseVisualStyleBackColor = true;
            this.uyeEkleMenuButonu.Click += new System.EventHandler(this.uyeEkleMenuButonu_Click);
            // 
            // kitapEkleMenuButonu
            // 
            this.kitapEkleMenuButonu.Location = new System.Drawing.Point(74, 229);
            this.kitapEkleMenuButonu.Name = "kitapEkleMenuButonu";
            this.kitapEkleMenuButonu.Size = new System.Drawing.Size(177, 81);
            this.kitapEkleMenuButonu.TabIndex = 1;
            this.kitapEkleMenuButonu.Text = "Kitap Ayarları";
            this.kitapEkleMenuButonu.UseVisualStyleBackColor = true;
            this.kitapEkleMenuButonu.Click += new System.EventHandler(this.kitapEkleMenuButonu_Click);
            // 
            // kitapUyeMenuButonu
            // 
            this.kitapUyeMenuButonu.AccessibleName = "";
            this.kitapUyeMenuButonu.Location = new System.Drawing.Point(566, 100);
            this.kitapUyeMenuButonu.Name = "kitapUyeMenuButonu";
            this.kitapUyeMenuButonu.Size = new System.Drawing.Size(177, 80);
            this.kitapUyeMenuButonu.TabIndex = 2;
            this.kitapUyeMenuButonu.Text = "Kitap ve Üye";
            this.kitapUyeMenuButonu.UseVisualStyleBackColor = true;
            this.kitapUyeMenuButonu.Click += new System.EventHandler(this.kitapUyeMenuButonu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kitapUyeMenuButonu);
            this.Controls.Add(this.kitapEkleMenuButonu);
            this.Controls.Add(this.uyeEkleMenuButonu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button uyeEkleMenuButonu;
        private Button kitapEkleMenuButonu;
        private Button kitapUyeMenuButonu;
    }
}