namespace kutuphaneUI
{
    partial class KitapEkle
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
            this.kitapAdiEtiketi = new System.Windows.Forms.Label();
            this.yazarEtiketi = new System.Windows.Forms.Label();
            this.turEtiketi = new System.Windows.Forms.Label();
            this.sayfaEtiketi = new System.Windows.Forms.Label();
            this.kitapAdiGirdisi = new System.Windows.Forms.TextBox();
            this.yazarGirdisi = new System.Windows.Forms.TextBox();
            this.turGirdisi = new System.Windows.Forms.TextBox();
            this.sayfaGirdisi = new System.Windows.Forms.TextBox();
            this.kitapEkleButonu = new System.Windows.Forms.Button();
            this.kitapListesi = new System.Windows.Forms.ListBox();
            this.kitapDuzenleButonu = new System.Windows.Forms.Button();
            this.kitapSilButonu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kitapAdiEtiketi
            // 
            this.kitapAdiEtiketi.AutoSize = true;
            this.kitapAdiEtiketi.Location = new System.Drawing.Point(29, 109);
            this.kitapAdiEtiketi.Name = "kitapAdiEtiketi";
            this.kitapAdiEtiketi.Size = new System.Drawing.Size(71, 20);
            this.kitapAdiEtiketi.TabIndex = 0;
            this.kitapAdiEtiketi.Text = "Kitap Adı";
            // 
            // yazarEtiketi
            // 
            this.yazarEtiketi.AutoSize = true;
            this.yazarEtiketi.Location = new System.Drawing.Point(29, 153);
            this.yazarEtiketi.Name = "yazarEtiketi";
            this.yazarEtiketi.Size = new System.Drawing.Size(44, 20);
            this.yazarEtiketi.TabIndex = 1;
            this.yazarEtiketi.Text = "Yazar";
            // 
            // turEtiketi
            // 
            this.turEtiketi.AutoSize = true;
            this.turEtiketi.Location = new System.Drawing.Point(29, 193);
            this.turEtiketi.Name = "turEtiketi";
            this.turEtiketi.Size = new System.Drawing.Size(30, 20);
            this.turEtiketi.TabIndex = 2;
            this.turEtiketi.Text = "Tür";
            // 
            // sayfaEtiketi
            // 
            this.sayfaEtiketi.AutoSize = true;
            this.sayfaEtiketi.Location = new System.Drawing.Point(28, 231);
            this.sayfaEtiketi.Name = "sayfaEtiketi";
            this.sayfaEtiketi.Size = new System.Drawing.Size(45, 20);
            this.sayfaEtiketi.TabIndex = 3;
            this.sayfaEtiketi.Text = "Sayfa";
            // 
            // kitapAdiGirdisi
            // 
            this.kitapAdiGirdisi.Location = new System.Drawing.Point(118, 106);
            this.kitapAdiGirdisi.Name = "kitapAdiGirdisi";
            this.kitapAdiGirdisi.Size = new System.Drawing.Size(125, 27);
            this.kitapAdiGirdisi.TabIndex = 4;
            // 
            // yazarGirdisi
            // 
            this.yazarGirdisi.Location = new System.Drawing.Point(118, 150);
            this.yazarGirdisi.Name = "yazarGirdisi";
            this.yazarGirdisi.Size = new System.Drawing.Size(125, 27);
            this.yazarGirdisi.TabIndex = 5;
            // 
            // turGirdisi
            // 
            this.turGirdisi.Location = new System.Drawing.Point(118, 190);
            this.turGirdisi.Name = "turGirdisi";
            this.turGirdisi.Size = new System.Drawing.Size(125, 27);
            this.turGirdisi.TabIndex = 6;
            // 
            // sayfaGirdisi
            // 
            this.sayfaGirdisi.Location = new System.Drawing.Point(118, 228);
            this.sayfaGirdisi.Name = "sayfaGirdisi";
            this.sayfaGirdisi.Size = new System.Drawing.Size(125, 27);
            this.sayfaGirdisi.TabIndex = 7;
            // 
            // kitapEkleButonu
            // 
            this.kitapEkleButonu.Location = new System.Drawing.Point(85, 315);
            this.kitapEkleButonu.Name = "kitapEkleButonu";
            this.kitapEkleButonu.Size = new System.Drawing.Size(158, 71);
            this.kitapEkleButonu.TabIndex = 8;
            this.kitapEkleButonu.Text = "Ekle";
            this.kitapEkleButonu.UseVisualStyleBackColor = true;
            this.kitapEkleButonu.Click += new System.EventHandler(this.kitakEkleButonu_Click);
            // 
            // kitapListesi
            // 
            this.kitapListesi.FormattingEnabled = true;
            this.kitapListesi.ItemHeight = 20;
            this.kitapListesi.Location = new System.Drawing.Point(468, 109);
            this.kitapListesi.Name = "kitapListesi";
            this.kitapListesi.Size = new System.Drawing.Size(265, 244);
            this.kitapListesi.TabIndex = 9;
            // 
            // kitapDuzenleButonu
            // 
            this.kitapDuzenleButonu.Location = new System.Drawing.Point(755, 109);
            this.kitapDuzenleButonu.Name = "kitapDuzenleButonu";
            this.kitapDuzenleButonu.Size = new System.Drawing.Size(120, 44);
            this.kitapDuzenleButonu.TabIndex = 10;
            this.kitapDuzenleButonu.Text = "Düzenle";
            this.kitapDuzenleButonu.UseVisualStyleBackColor = true;
            this.kitapDuzenleButonu.Click += new System.EventHandler(this.kitapDuzenleButonu_Click);
            // 
            // kitapSilButonu
            // 
            this.kitapSilButonu.Location = new System.Drawing.Point(755, 193);
            this.kitapSilButonu.Name = "kitapSilButonu";
            this.kitapSilButonu.Size = new System.Drawing.Size(120, 44);
            this.kitapSilButonu.TabIndex = 11;
            this.kitapSilButonu.Text = "Sil";
            this.kitapSilButonu.UseVisualStyleBackColor = true;
            this.kitapSilButonu.Click += new System.EventHandler(this.kitapSilButonu_Click);
            // 
            // KitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.kitapSilButonu);
            this.Controls.Add(this.kitapDuzenleButonu);
            this.Controls.Add(this.kitapListesi);
            this.Controls.Add(this.kitapEkleButonu);
            this.Controls.Add(this.sayfaGirdisi);
            this.Controls.Add(this.turGirdisi);
            this.Controls.Add(this.yazarGirdisi);
            this.Controls.Add(this.kitapAdiGirdisi);
            this.Controls.Add(this.sayfaEtiketi);
            this.Controls.Add(this.turEtiketi);
            this.Controls.Add(this.yazarEtiketi);
            this.Controls.Add(this.kitapAdiEtiketi);
            this.Name = "KitapEkle";
            this.Text = "KitapEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label kitapAdiEtiketi;
        private Label yazarEtiketi;
        private Label turEtiketi;
        private Label sayfaEtiketi;
        private TextBox kitapAdiGirdisi;
        private TextBox yazarGirdisi;
        private TextBox turGirdisi;
        private TextBox sayfaGirdisi;
        private Button kitapEkleButonu;
        private ListBox kitapListesi;
        private Button kitapDuzenleButonu;
        private Button kitapSilButonu;
    }
}