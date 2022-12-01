namespace kutuphaneUI
{
    partial class kitapUye
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
            this.uyeListesi = new System.Windows.Forms.ListBox();
            this.kitapListesi = new System.Windows.Forms.ListBox();
            this.uyelerEtikei = new System.Windows.Forms.Label();
            this.kitaplarEtiketi = new System.Windows.Forms.Label();
            this.oduncVerButonu = new System.Windows.Forms.Button();
            this.alimTarihiEtiketi = new System.Windows.Forms.Label();
            this.gunEtiketi = new System.Windows.Forms.Label();
            this.ayEtiketi = new System.Windows.Forms.Label();
            this.gunGirdisi = new System.Windows.Forms.TextBox();
            this.ayGirdisi = new System.Windows.Forms.TextBox();
            this.kisininAldigiKontrol = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.iadeButonu = new System.Windows.Forms.Button();
            this.simdikiZamanButonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uyeListesi
            // 
            this.uyeListesi.FormattingEnabled = true;
            this.uyeListesi.ItemHeight = 20;
            this.uyeListesi.Location = new System.Drawing.Point(46, 125);
            this.uyeListesi.Name = "uyeListesi";
            this.uyeListesi.Size = new System.Drawing.Size(224, 284);
            this.uyeListesi.TabIndex = 0;
            // 
            // kitapListesi
            // 
            this.kitapListesi.FormattingEnabled = true;
            this.kitapListesi.ItemHeight = 20;
            this.kitapListesi.Location = new System.Drawing.Point(326, 125);
            this.kitapListesi.Name = "kitapListesi";
            this.kitapListesi.Size = new System.Drawing.Size(224, 284);
            this.kitapListesi.TabIndex = 1;
            // 
            // uyelerEtikei
            // 
            this.uyelerEtikei.AutoSize = true;
            this.uyelerEtikei.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uyelerEtikei.Location = new System.Drawing.Point(46, 29);
            this.uyelerEtikei.Name = "uyelerEtikei";
            this.uyelerEtikei.Size = new System.Drawing.Size(68, 28);
            this.uyelerEtikei.TabIndex = 2;
            this.uyelerEtikei.Text = "Üyeler";
            // 
            // kitaplarEtiketi
            // 
            this.kitaplarEtiketi.AutoSize = true;
            this.kitaplarEtiketi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kitaplarEtiketi.Location = new System.Drawing.Point(326, 29);
            this.kitaplarEtiketi.Name = "kitaplarEtiketi";
            this.kitaplarEtiketi.Size = new System.Drawing.Size(80, 28);
            this.kitaplarEtiketi.TabIndex = 3;
            this.kitaplarEtiketi.Text = "Kitaplar";
            this.kitaplarEtiketi.Click += new System.EventHandler(this.kitaplarEtiketi_Click);
            // 
            // oduncVerButonu
            // 
            this.oduncVerButonu.Location = new System.Drawing.Point(590, 259);
            this.oduncVerButonu.Name = "oduncVerButonu";
            this.oduncVerButonu.Size = new System.Drawing.Size(152, 49);
            this.oduncVerButonu.TabIndex = 5;
            this.oduncVerButonu.Text = "Ödünç Ver";
            this.oduncVerButonu.UseVisualStyleBackColor = true;
            this.oduncVerButonu.Click += new System.EventHandler(this.oduncVerButonu_Click);
            // 
            // alimTarihiEtiketi
            // 
            this.alimTarihiEtiketi.AutoSize = true;
            this.alimTarihiEtiketi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alimTarihiEtiketi.Location = new System.Drawing.Point(590, 55);
            this.alimTarihiEtiketi.Name = "alimTarihiEtiketi";
            this.alimTarihiEtiketi.Size = new System.Drawing.Size(103, 28);
            this.alimTarihiEtiketi.TabIndex = 6;
            this.alimTarihiEtiketi.Text = "Alım Tarihi";
            // 
            // gunEtiketi
            // 
            this.gunEtiketi.AutoSize = true;
            this.gunEtiketi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gunEtiketi.Location = new System.Drawing.Point(590, 125);
            this.gunEtiketi.Name = "gunEtiketi";
            this.gunEtiketi.Size = new System.Drawing.Size(48, 28);
            this.gunEtiketi.TabIndex = 7;
            this.gunEtiketi.Text = "Gün";
            // 
            // ayEtiketi
            // 
            this.ayEtiketi.AutoSize = true;
            this.ayEtiketi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ayEtiketi.Location = new System.Drawing.Point(657, 125);
            this.ayEtiketi.Name = "ayEtiketi";
            this.ayEtiketi.Size = new System.Drawing.Size(35, 28);
            this.ayEtiketi.TabIndex = 8;
            this.ayEtiketi.Text = "Ay";
            // 
            // gunGirdisi
            // 
            this.gunGirdisi.Location = new System.Drawing.Point(590, 156);
            this.gunGirdisi.Name = "gunGirdisi";
            this.gunGirdisi.Size = new System.Drawing.Size(48, 27);
            this.gunGirdisi.TabIndex = 9;
            this.gunGirdisi.TextChanged += new System.EventHandler(this.gunGirdisi_TextChanged);
            // 
            // ayGirdisi
            // 
            this.ayGirdisi.Location = new System.Drawing.Point(657, 156);
            this.ayGirdisi.Name = "ayGirdisi";
            this.ayGirdisi.Size = new System.Drawing.Size(48, 27);
            this.ayGirdisi.TabIndex = 10;
            // 
            // kisininAldigiKontrol
            // 
            this.kisininAldigiKontrol.AutoSize = true;
            this.kisininAldigiKontrol.Location = new System.Drawing.Point(46, 442);
            this.kisininAldigiKontrol.Name = "kisininAldigiKontrol";
            this.kisininAldigiKontrol.Size = new System.Drawing.Size(225, 24);
            this.kisininAldigiKontrol.TabIndex = 12;
            this.kisininAldigiKontrol.Text = "Kişinin Aldığı Kitapları Göster";
            this.kisininAldigiKontrol.UseVisualStyleBackColor = true;
            this.kisininAldigiKontrol.CheckedChanged += new System.EventHandler(this.kisininAldigiKontrol_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(326, 442);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(208, 24);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Alınmamış Kitapları Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // iadeButonu
            // 
            this.iadeButonu.Location = new System.Drawing.Point(590, 360);
            this.iadeButonu.Name = "iadeButonu";
            this.iadeButonu.Size = new System.Drawing.Size(152, 49);
            this.iadeButonu.TabIndex = 14;
            this.iadeButonu.Text = "İade";
            this.iadeButonu.UseVisualStyleBackColor = true;
            this.iadeButonu.Click += new System.EventHandler(this.iadeButonu_Click);
            // 
            // simdikiZamanButonu
            // 
            this.simdikiZamanButonu.Location = new System.Drawing.Point(590, 189);
            this.simdikiZamanButonu.Name = "simdikiZamanButonu";
            this.simdikiZamanButonu.Size = new System.Drawing.Size(152, 49);
            this.simdikiZamanButonu.TabIndex = 15;
            this.simdikiZamanButonu.Text = "Şimdiki Zamanı Kullan";
            this.simdikiZamanButonu.UseVisualStyleBackColor = true;
            this.simdikiZamanButonu.Click += new System.EventHandler(this.simdikiZamanButonu_Click);
            // 
            // kitapUye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.simdikiZamanButonu);
            this.Controls.Add(this.iadeButonu);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.kisininAldigiKontrol);
            this.Controls.Add(this.ayGirdisi);
            this.Controls.Add(this.gunGirdisi);
            this.Controls.Add(this.ayEtiketi);
            this.Controls.Add(this.gunEtiketi);
            this.Controls.Add(this.alimTarihiEtiketi);
            this.Controls.Add(this.oduncVerButonu);
            this.Controls.Add(this.kitaplarEtiketi);
            this.Controls.Add(this.uyelerEtikei);
            this.Controls.Add(this.kitapListesi);
            this.Controls.Add(this.uyeListesi);
            this.Name = "kitapUye";
            this.Text = "kitapUye";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox uyeListesi;
        private ListBox kitapListesi;
        private Label uyelerEtikei;
        private Label kitaplarEtiketi;
        private Button oduncVerButonu;
        private Label alimTarihiEtiketi;
        private Label gunEtiketi;
        private Label ayEtiketi;
        private TextBox gunGirdisi;
        private TextBox ayGirdisi;
        private CheckBox kisininAldigiKontrol;
        private CheckBox checkBox1;
        private Button iadeButonu;
        private Button simdikiZamanButonu;
    }
}