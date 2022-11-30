namespace kutuphaneUI
{
    partial class UyeEkle
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
            this.adGirdisi = new System.Windows.Forms.TextBox();
            this.adEtiketi = new System.Windows.Forms.Label();
            this.soyadEtiketi = new System.Windows.Forms.Label();
            this.meslekEtiketi = new System.Windows.Forms.Label();
            this.soyadGirdisi = new System.Windows.Forms.TextBox();
            this.meslekGirdisi = new System.Windows.Forms.TextBox();
            this.uyeEkleButonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adGirdisi
            // 
            this.adGirdisi.Location = new System.Drawing.Point(360, 119);
            this.adGirdisi.Name = "adGirdisi";
            this.adGirdisi.Size = new System.Drawing.Size(125, 27);
            this.adGirdisi.TabIndex = 0;
            // 
            // adEtiketi
            // 
            this.adEtiketi.AutoSize = true;
            this.adEtiketi.Location = new System.Drawing.Point(293, 122);
            this.adEtiketi.Name = "adEtiketi";
            this.adEtiketi.Size = new System.Drawing.Size(28, 20);
            this.adEtiketi.TabIndex = 1;
            this.adEtiketi.Text = "Ad";
            // 
            // soyadEtiketi
            // 
            this.soyadEtiketi.AutoSize = true;
            this.soyadEtiketi.Location = new System.Drawing.Point(293, 169);
            this.soyadEtiketi.Name = "soyadEtiketi";
            this.soyadEtiketi.Size = new System.Drawing.Size(50, 20);
            this.soyadEtiketi.TabIndex = 2;
            this.soyadEtiketi.Text = "Soyad";
            this.soyadEtiketi.Click += new System.EventHandler(this.label1_Click);
            // 
            // meslekEtiketi
            // 
            this.meslekEtiketi.AutoSize = true;
            this.meslekEtiketi.Location = new System.Drawing.Point(293, 214);
            this.meslekEtiketi.Name = "meslekEtiketi";
            this.meslekEtiketi.Size = new System.Drawing.Size(55, 20);
            this.meslekEtiketi.TabIndex = 3;
            this.meslekEtiketi.Text = "Meslek";
            // 
            // soyadGirdisi
            // 
            this.soyadGirdisi.Location = new System.Drawing.Point(360, 166);
            this.soyadGirdisi.Name = "soyadGirdisi";
            this.soyadGirdisi.Size = new System.Drawing.Size(125, 27);
            this.soyadGirdisi.TabIndex = 4;
            // 
            // meslekGirdisi
            // 
            this.meslekGirdisi.Location = new System.Drawing.Point(360, 211);
            this.meslekGirdisi.Name = "meslekGirdisi";
            this.meslekGirdisi.Size = new System.Drawing.Size(125, 27);
            this.meslekGirdisi.TabIndex = 5;
            // 
            // uyeEkleButonu
            // 
            this.uyeEkleButonu.Location = new System.Drawing.Point(320, 321);
            this.uyeEkleButonu.Name = "uyeEkleButonu";
            this.uyeEkleButonu.Size = new System.Drawing.Size(136, 50);
            this.uyeEkleButonu.TabIndex = 6;
            this.uyeEkleButonu.Text = "Ekle";
            this.uyeEkleButonu.UseVisualStyleBackColor = true;
            this.uyeEkleButonu.Click += new System.EventHandler(this.uyeEkleButonu_Click);
            // 
            // UyeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uyeEkleButonu);
            this.Controls.Add(this.meslekGirdisi);
            this.Controls.Add(this.soyadGirdisi);
            this.Controls.Add(this.meslekEtiketi);
            this.Controls.Add(this.soyadEtiketi);
            this.Controls.Add(this.adEtiketi);
            this.Controls.Add(this.adGirdisi);
            this.Name = "UyeEkle";
            this.Text = "UyeEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox adGirdisi;
        private Label adEtiketi;
        private Label soyadEtiketi;
        private Label meslekEtiketi;
        private TextBox soyadGirdisi;
        private TextBox meslekGirdisi;
        private Button uyeEkleButonu;
    }
}