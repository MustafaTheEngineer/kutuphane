using kutuphane;
using System;
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
    public partial class UyeEkle : Form
    {
        private List<uye> uyeler = new List<uye>();
        private bool ekle = true;

        public UyeEkle()
        {
            InitializeComponent();
            UyeEkle_Load();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void uyeEkleButonu_Click(object sender, EventArgs e)
        {
            if (ekle == true)
                Ekle();
            else
                Duzenle();
        }

        private void Ekle()
        {
            System.Data.SqlClient.SqlConnection sqlConnection1 =
            new System.Data.SqlClient.SqlConnection("Server=.\\SQLEXPRESS;Database=kutuphane;Trusted_Connection=True;");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"INSERT INTO dbo.tblUyeler (Ad,Soyad,Meslek,CezaPuani) VALUES ('{adGirdisi.Text}','{soyadGirdisi.Text}','{meslekGirdisi.Text}',0)";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();

            uyeListesi.DataSource = null;
            uyeListesi.DataSource = uyeler;
            uyeListesi.DisplayMember = "bilgi";
            uyeListesi.ValueMember = "ID";
        }

        private void UyeEkle_Load()
        {
            System.Data.SqlClient.SqlConnection conn =
            new System.Data.SqlClient.SqlConnection("Server=.\\SQLEXPRESS;Database=kutuphane;Trusted_Connection=True;");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"SELECT ID,Ad,Soyad,Meslek,CezaPuani FROM dbo.tblUyeler";
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    uye yeni = new uye
                    {
                        ID = (int)reader["ID"],
                        ad = (string)reader["Ad"],
                        soyad = (string)reader["Soyad"],
                        meslek = (string)reader["Meslek"],
                        cezaPuani = (int)reader["CezaPuani"],
                        bilgi = (string)reader["Ad"]
                        + " " + (string)reader["Soyad"] + " - " + (string)reader["Meslek"],
                    };
                    uyeler.Add(yeni);
                }
            }

            conn.Close();

            uyeListesi.DataSource = uyeler;
            uyeListesi.DisplayMember = "bilgi";
            uyeListesi.ValueMember = "ID";
        }

        private void uyeDuzenleButonu_Click(object sender, EventArgs e)
        {
            ekle = false;
            uyeEkleButonu.Text = "Güncelle";
            adGirdisi.Text = ((uye)uyeListesi.SelectedItem).ad;
            soyadGirdisi.Text = ((uye)uyeListesi.SelectedItem).soyad;
            meslekGirdisi.Text = ((uye)uyeListesi.SelectedItem).meslek;
        }

        private void Duzenle()
        {
            int id = (int)uyeListesi.SelectedValue;

            System.Data.SqlClient.SqlConnection sqlConnection1 =
                new System.Data.SqlClient.SqlConnection("Server=.\\SQLEXPRESS;Database=kutuphane;Trusted_Connection=True;");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"UPDATE dbo.tblUyeler SET Ad = '{adGirdisi.Text}', Soyad = '{soyadGirdisi.Text}',Meslek = '{meslekGirdisi.Text}' WHERE ID={id}";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();

            for (int i = 0; i < uyeler.Count; ++i)
            {
                if (uyeler[i].ID == id)
                {
                    uye yeni = new uye()
                    {
                        ID = id,
                        ad = (string)adGirdisi.Text,
                        soyad = (string)soyadGirdisi.Text,
                        meslek = meslekGirdisi.Text,
                        cezaPuani = uyeler[i].cezaPuani,
                        bilgi = (string)adGirdisi.Text + " " + (string)soyadGirdisi.Text + " - " + (string)meslekGirdisi.Text,
                    };
                    uyeler[i] = yeni;
                    break;
                }
            }

            ekle = true;
            uyeEkleButonu.Text = "Ekle";
            adGirdisi.Text = "";
            soyadGirdisi.Text = "";
            meslekGirdisi.Text = "";

            uyeListesi.DataSource = null;
            uyeListesi.DataSource = uyeler;
            uyeListesi.DisplayMember = "bilgi";
            uyeListesi.ValueMember = "ID";
        }

        private void uyeSilButonu_Click(object sender, EventArgs e)
        {
            if (uyeListesi.SelectedItem == null)
            {
                System.Windows.Forms.MessageBox.Show("Lütfen bir üye seçin");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bu üyeyi silmek istediğinize emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                System.Data.SqlClient.SqlConnection sqlConnection1 =
                new System.Data.SqlClient.SqlConnection("Server=.\\SQLEXPRESS;Database=kutuphane;Trusted_Connection=True;");

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = $"DELETE FROM dbo.tblUyeler WHERE ID={uyeListesi.SelectedValue}";
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();

                uyeler.Remove((uye)uyeListesi.SelectedItem);

                uyeListesi.DataSource = null;
                uyeListesi.DataSource = uyeler;
                uyeListesi.DisplayMember = "bilgi";
                uyeListesi.ValueMember = "ID";
            }
        }
    }
}
