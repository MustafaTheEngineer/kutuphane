using kutuphane;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneUI
{
    public partial class KitapEkle : Form
    {
        private List<kitap> kitaplar = new List<kitap>();
        private bool ekle = true;
        public KitapEkle()
        {
            InitializeComponent();
            KitapEkle_Load();
        }

        private void kitakEkleButonu_Click(object sender, EventArgs e)
        {
            if (ekle == true)
                Ekle();
            else
                Duzenle();
        }

        private void KitapEkle_Load()
        {
            System.Data.SqlClient.SqlConnection conn =
            new System.Data.SqlClient.SqlConnection("Server=.\\SQLEXPRESS;Database=kutuphane;Trusted_Connection=True;");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"SELECT ID,KitapAdi,Yazar,Tur,Sayfa,Uygunluk FROM dbo.tblKitaplar";
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    kitap yeni = new kitap
                    {
                        ID = (int) reader["ID"],
                        kitapAdi = (string) reader["KitapAdi"],
                        yazar = (string) reader["Yazar"],
                        tur = (string)reader["Tur"],
                        sayfa = (int) reader["Sayfa"],
                        uygunluk = (bool) reader["Uygunluk"],
                    };
                    kitaplar.Add(yeni);
                }
            }

            conn.Close();

            kitapListesi.DataSource= kitaplar;
            kitapListesi.DisplayMember = "KitapAdi";
            kitapListesi.ValueMember = "ID";
        }

        private void Ekle()
        {
            System.Data.SqlClient.SqlConnection sqlConnection1 =
            new System.Data.SqlClient.SqlConnection("Server=.\\SQLEXPRESS;Database=kutuphane;Trusted_Connection=True;");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"INSERT INTO dbo.tblKitaplar (KitapAdi,Yazar,Tur,Sayfa,Uygunluk) VALUES ('{kitapAdiGirdisi.Text}','{yazarGirdisi.Text}','{turGirdisi.Text}',{sayfaGirdisi.Text},1)";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            cmd.CommandText = $"SELECT ID FROM dbo.tblKitaplar WHERE KitapAdi = '{kitapAdiGirdisi.Text}' AND Yazar = '{yazarGirdisi.Text}'";

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    kitap yeni = new kitap
                    {
                        ID = (int)reader["ID"],
                        kitapAdi = kitapAdiGirdisi.Text,
                        yazar = yazarGirdisi.Text,
                        tur = turGirdisi.Text,
                        sayfa = int.Parse(sayfaGirdisi.Text),
                        uygunluk = true,
                    };
                    kitaplar.Add(yeni);
                }
            }

            sqlConnection1.Close();

            kitapListesi.DataSource = null;
            kitapListesi.DataSource = kitaplar;
            kitapListesi.DisplayMember = "KitapAdi";
            kitapListesi.ValueMember = "ID";
        }

        private void kitapSilButonu_Click(object sender, EventArgs e)
        {
            if (kitapListesi.SelectedItem == null)
            {
                System.Windows.Forms.MessageBox.Show("Lütfen bir kitap seçin");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bu kitabı silmek istediğinize emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                System.Data.SqlClient.SqlConnection sqlConnection1 =
                new System.Data.SqlClient.SqlConnection("Server=.\\SQLEXPRESS;Database=kutuphane;Trusted_Connection=True;");

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"DELETE FROM dbo.tblKitaplar WHERE ID={kitapListesi.SelectedValue}";
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();

                kitaplar.Remove((kitap)kitapListesi.SelectedItem);

                kitapListesi.DataSource = null;
                kitapListesi.DataSource = kitaplar;
                kitapListesi.DisplayMember = "KitapAdi";
                kitapListesi.ValueMember = "ID";
            }
        }

        private void kitapDuzenleButonu_Click(object sender, EventArgs e)
        {
            ekle = false;
            kitapEkleButonu.Text = "Güncelle";
            kitapAdiGirdisi.Text = ((kitap)kitapListesi.SelectedItem).kitapAdi;
            yazarGirdisi.Text = ((kitap)kitapListesi.SelectedItem).yazar;
            turGirdisi.Text = ((kitap)kitapListesi.SelectedItem).tur;
            sayfaGirdisi.Text = ((kitap)kitapListesi.SelectedItem).sayfa.ToString();
        }

        private void Duzenle()
        {
            int id = (int) kitapListesi.SelectedValue;

            System.Data.SqlClient.SqlConnection sqlConnection1 =
                new System.Data.SqlClient.SqlConnection("Server=.\\SQLEXPRESS;Database=kutuphane;Trusted_Connection=True;");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"UPDATE dbo.tblKitaplar SET KitapAdi = '{kitapAdiGirdisi.Text}', Yazar = '{yazarGirdisi.Text}',Tur = '{turGirdisi.Text}',Sayfa = '{sayfaGirdisi.Text}' WHERE ID={id}";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();

            kitap yeni = new kitap()
            {
                ID = id,
                kitapAdi = kitapAdiGirdisi.Text,
                yazar = yazarGirdisi.Text,
                tur = turGirdisi.Text,
                sayfa = int.Parse( sayfaGirdisi.Text),
                uygunluk = true
            };

            for (int i=0; i < kitaplar.Count; ++i)
            {
                if (kitaplar[i].ID == id)
                {
                    kitaplar[i] = yeni;
                    break;
                }
            }

            ekle = true;
            kitapEkleButonu.Text = "Ekle";
            kitapAdiGirdisi.Text = "";
            yazarGirdisi.Text = "";
            turGirdisi.Text = "";
            sayfaGirdisi.Text = "";

            kitapListesi.DataSource = null;
            kitapListesi.DataSource = kitaplar;
            kitapListesi.DisplayMember = "KitapAdi";
            kitapListesi.ValueMember = "ID";
        }
    }
}
