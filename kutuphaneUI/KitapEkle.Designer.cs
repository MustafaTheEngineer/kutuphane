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
            this.SuspendLayout();
            // 
            // kitapAdiEtiketi
            // 
            this.kitapAdiEtiketi.AutoSize = true;
            this.kitapAdiEtiketi.Location = new System.Drawing.Point(264, 109);
            this.kitapAdiEtiketi.Name = "kitapAdiEtiketi";
            this.kitapAdiEtiketi.Size = new System.Drawing.Size(71, 20);
            this.kitapAdiEtiketi.TabIndex = 0;
            this.kitapAdiEtiketi.Text = "Kitap Adı";
            // 
            // yazarEtiketi
            // 
            this.yazarEtiketi.AutoSize = true;
            this.yazarEtiketi.Location = new System.Drawing.Point(264, 156);
            this.yazarEtiketi.Name = "yazarEtiketi";
            this.yazarEtiketi.Size = new System.Drawing.Size(44, 20);
            this.yazarEtiketi.TabIndex = 1;
            this.yazarEtiketi.Text = "Yazar";
            // 
            // turEtiketi
            // 
            this.turEtiketi.AutoSize = true;
            this.turEtiketi.Location = new System.Drawing.Point(264, 196);
            this.turEtiketi.Name = "turEtiketi";
            this.turEtiketi.Size = new System.Drawing.Size(30, 20);
            this.turEtiketi.TabIndex = 2;
            this.turEtiketi.Text = "Tür";
            // 
            // sayfaEtiketi
            // 
            this.sayfaEtiketi.AutoSize = true;
            this.sayfaEtiketi.Location = new System.Drawing.Point(264, 234);
            this.sayfaEtiketi.Name = "sayfaEtiketi";
            this.sayfaEtiketi.Size = new System.Drawing.Size(45, 20);
            this.sayfaEtiketi.TabIndex = 3;
            this.sayfaEtiketi.Text = "Sayfa";
            // 
            // kitapAdiGirdisi
            // 
            this.kitapAdiGirdisi.Location = new System.Drawing.Point(369, 106);
            this.kitapAdiGirdisi.Name = "kitapAdiGirdisi";
            this.kitapAdiGirdisi.Size = new System.Drawing.Size(125, 27);
            this.kitapAdiGirdisi.TabIndex = 4;
            // 
            // yazarGirdisi
            // 
            this.yazarGirdisi.Location = new System.Drawing.Point(369, 153);
            this.yazarGirdisi.Name = "yazarGirdisi";
            this.yazarGirdisi.Size = new System.Drawing.Size(125, 27);
            this.yazarGirdisi.TabIndex = 5;
            // 
            // turGirdisi
            // 
            this.turGirdisi.Location = new System.Drawing.Point(369, 193);
            this.turGirdisi.Name = "turGirdisi";
            this.turGirdisi.Size = new System.Drawing.Size(125, 27);
            this.turGirdisi.TabIndex = 6;
            // 
            // sayfaGirdisi
            // 
            this.sayfaGirdisi.Location = new System.Drawing.Point(369, 231);
            this.sayfaGirdisi.Name = "sayfaGirdisi";
            this.sayfaGirdisi.Size = new System.Drawing.Size(125, 27);
            this.sayfaGirdisi.TabIndex = 7;
            // 
            // KitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}