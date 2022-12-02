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
    public partial class kitapUye : Form
    {
        List<uye> uyeler = new List<uye>();
        List<kitap> kitaplar = new List<kitap>();
        List<kitap> musaitKitaplar = new List<kitap>();
        List<takip> takipler = new List<takip>();
        List<int> uyeninAldigiKitaplarID = new List<int>();
        List<kitap> uyeninAldigiKitaplar = new List<kitap>();

        public kitapUye()
        {
            InitializeComponent();
            kitapUye_Load();
        }

        private void kitaplarEtiketi_Click(object sender, EventArgs e)
        {

        }

        private void kitapUye_Load()
        {
            uyeleriYukle();
            kitaplarıYukle();
            takipleriYukle();
        }

        private void takipleriYukle()
        {
            System.Data.SqlClient.SqlConnection conn =
            new System.Data.SqlClient.SqlConnection("Server=.\\SQLEXPRESS;Database=kutuphane;Trusted_Connection=True;");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"SELECT ID,UyeID,KitapID,AlimTarihi,TeslimTarihi,GeldigiTarih FROM dbo.tblTakip";
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    takip yeni = new takip
                    {
                        ID = (int)reader["ID"],
                        uyeID = (int)reader["UyeID"],
                        kitapID = (int)reader["KitapID"],
                        alimTarihi = (DateTime)reader["AlimTarihi"],
                        teslimTarihi = (DateTime)reader["TeslimTarihi"],
                        geldigiTarih = Convert.IsDBNull(reader["GeldigiTarih"]) ? null : (DateTime) reader["GeldigiTarih"],
                    };
                    if(yeni.geldigiTarih == null)
                        takipler.Add(yeni);
                }
            }

            conn.Close();

            kitapListesi.DataSource = kitaplar;
            kitapListesi.DisplayMember = "bilgi";
            kitapListesi.ValueMember = "ID";
        }

        private void kitaplarıYukle()
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
                        ID = (int)reader["ID"],
                        kitapAdi = (string)reader["KitapAdi"],
                        yazar = (string)reader["Yazar"],
                        tur = (string)reader["Tur"],
                        sayfa = (int)reader["Sayfa"],
                        uygunluk = (bool)reader["Uygunluk"],
                    };
                    if (yeni.uygunluk == true)
                    {
                        yeni.bilgi = yeni.kitapAdi;
                        musaitKitaplar.Add(yeni);
                    }
                    else
                        yeni.bilgi = yeni.kitapAdi + " - Verildi";

                    kitaplar.Add(yeni);
                }
            }

            conn.Close();

            kitapListesi.DataSource = kitaplar;
            kitapListesi.DisplayMember = "bilgi";
            kitapListesi.ValueMember = "ID";
        }

        private void uyeleriYukle()
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

        private void gunGirdisi_TextChanged(object sender, EventArgs e)
        {

        }

        private void oduncVerButonu_Click(object sender, EventArgs e)
        {
            int uyeID = (int) uyeListesi.SelectedValue;
            int KitapID = (int)kitapListesi.SelectedValue;

            DateTime simdi = DateTime.Now;
            int ay = (ayGirdisi.Text == "") ? simdi.Month : int.Parse(ayGirdisi.Text);
            int gun = (gunGirdisi.Text == "") ? simdi.Day : int.Parse(gunGirdisi.Text);

            if ( ((kitap) kitapListesi.SelectedItem).uygunluk == false)
            {
                System.Windows.Forms.MessageBox.Show("Bu kitap başkası tarafından alınmış");
                return;
            }

            if(((uye) uyeListesi.SelectedItem).cezaPuani > 50)
            {
                System.Windows.Forms.MessageBox.Show("Bu kişinin ceza puanı 50'den fazla olduğu için kitap alamaz");
                return;
            }

            
            DateTime teslim = new DateTime(simdi.Year,ay,gun);
            teslim.AddDays(14);
            string aldigiTarih = $"{ simdi.Year }-{teslim.Month}-{teslim.Day} 00:00:00";
            string teslimTarihi = $"{teslim.Year}-{teslim.Month}-{teslim.Day} {teslim.Hour}:{teslim.Minute}:00";
            System.Data.SqlClient.SqlConnection sqlConnection1 =
            new System.Data.SqlClient.SqlConnection("Server=.\\SQLEXPRESS;Database=kutuphane;Trusted_Connection=True;");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"INSERT INTO dbo.tblTakip (UyeID,KitapID,AlimTarihi,TeslimTarihi) VALUES ('{uyeID}','{KitapID}','{aldigiTarih}','{teslimTarihi}')";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            cmd.CommandText = $"UPDATE dbo.tblKitaplar SET Uygunluk = {0} WHERE ID={KitapID}";
            cmd.ExecuteNonQuery();
            cmd.CommandText = $"SELECT ID,UyeID,KitapID,AlimTarihi,TeslimTarihi,GeldigiTarih FROM dbo.tblTakip WHERE UyeID={uyeID} AND KitapID={KitapID} AND GeldigiTarih IS NULL";

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    takip yeni = new takip
                    {
                        ID = (int)reader["ID"],
                        uyeID = (int)reader["UyeID"],
                        kitapID = (int)reader["KitapID"],
                        alimTarihi = (DateTime) reader["AlimTarihi"],
                        teslimTarihi = (DateTime)reader["TeslimTarihi"],
                        geldigiTarih = null,
                    };
                    takipler.Add(yeni);
                }
            }


            //cmd.CommandText = $"SELECT ID FROM dbo.tblKitaplar WHERE KitapAdi = '{kitapAdiGirdisi.Text}' AND Yazar = '{yazarGirdisi.Text}'";

            //using (SqlDataReader reader = cmd.ExecuteReader())
            //{
            //    if (reader.Read())
            //    {
            //        kitap yeni = new kitap
            //        {
            //            ID = (int)reader["ID"],
            //            kitapAdi = kitapAdiGirdisi.Text,
            //            yazar = yazarGirdisi.Text,
            //            tur = turGirdisi.Text,
            //            sayfa = int.Parse(sayfaGirdisi.Text),
            //            uygunluk = true,
            //        };
            //        kitaplar.Add(yeni);
            //    }
            //}

            sqlConnection1.Close();



            for (int i = 0; i < kitaplar.Count; i++)
            {
                if (kitaplar[i].ID == KitapID)
                {
                    kitaplar[i].uygunluk = false;
                    kitaplar[i].bilgi += " - Verildi";
                    break;
                }
            }

            for (int i = 0; i < musaitKitaplar.Count; i++)
            {
                if(musaitKitaplar[i].ID == KitapID)
                {
                    musaitKitaplar.RemoveAt(i); break;
                }
            }

            kitapListesi.DataSource = null;
            kitapListesi.DataSource = kitaplar;
            kitapListesi.DisplayMember = "bilgi";
            kitapListesi.ValueMember = "ID";
        }

        private void kisininAldigiKontrol_CheckedChanged(object sender, EventArgs e)
        {
            int uyeID = (int)uyeListesi.SelectedValue;

            if (kisininAldigiKontrol.Checked == true)
            {
                foreach (var item in takipler)
                {
                    if(item.uyeID == uyeID)
                    {
                        uyeninAldigiKitaplarID.Add(item.kitapID);
                    }
                }
                for (int i = 0; i < uyeninAldigiKitaplarID.Count; i++)
                {
                    for (int k = 0; k < kitaplar.Count; k++)
                    {
                        if (kitaplar[k].ID == uyeninAldigiKitaplarID[i])
                            uyeninAldigiKitaplar.Add(kitaplar[k]);
                    }
                }
                kitapListesi.DataSource = null;
                kitapListesi.DataSource = uyeninAldigiKitaplar;
                kitapListesi.DisplayMember = "bilgi";
                kitapListesi.ValueMember = "ID";
            }
            else
            {
                uyeninAldigiKitaplar.Clear();
                uyeninAldigiKitaplarID.Clear();

                kitapListesi.DataSource = null;
                kitapListesi.DataSource = kitaplar;
                kitapListesi.DisplayMember = "bilgi";
                kitapListesi.ValueMember = "ID";
            }

        }

        private void iadeButonu_Click(object sender, EventArgs e)
        {
            int kitapID = (int) kitapListesi.SelectedValue;
            int takipID=0;
            int uyeID = 0;
            bool cezaKontrol = false;
            int ceza=0;
            DateTime simdi = DateTime.Now;
            string teslimTarihi = $"{simdi.Year}-{simdi.Month}-{simdi.Day} {simdi.Hour}:{simdi.Minute}:00";

            kitap iade = kitaplar.Find(x => x.ID == kitapID);
            iade.uygunluk = true;
            iade.bilgi = iade.kitapAdi;

            for (int i = 0; i < takipler.Count; i++)
            {
                if (iade.ID == takipler[i].kitapID)
                {
                    if (takipler[i].geldigiTarih > takipler[i].teslimTarihi)
                        cezaKontrol = true;
                    uyeID = takipler[i].uyeID;
                    takipID = takipler[i].ID;
                    takipler[i].geldigiTarih = simdi;
                    takipler.RemoveAt(i);
                    break;
                }
            }

            for (int i = 0; i < uyeninAldigiKitaplarID.Count; i++)
            {
                if (kitapID == uyeninAldigiKitaplarID[i])
                {
                    uyeninAldigiKitaplarID.RemoveAt(i);
                    break;
                }
            }

            for (int i = 0; i < uyeninAldigiKitaplar.Count; i++)
            {
                if (kitapID == uyeninAldigiKitaplar[i].ID)
                {
                    uyeninAldigiKitaplar.RemoveAt(i);
                    break;
                }
            }

            for (int i = 0; i < uyeler.Count; i++)
            {
                if(uyeID == uyeler[i].ID)
                {
                    if (cezaKontrol)
                    {
                        uyeler[i].cezaPuani += 10;
                        ceza = uyeler[i].cezaPuani;
                        cezaKontrol = false;
                        break;
                    }
                    else
                    {
                        ceza = uyeler[i].cezaPuani;
                        break;
                    }
                }
            }

            System.Data.SqlClient.SqlConnection sqlConnection1 =
                new System.Data.SqlClient.SqlConnection("Server=.\\SQLEXPRESS;Database=kutuphane;Trusted_Connection=True;");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"UPDATE dbo.tblKitaplar SET Uygunluk=1 WHERE ID={kitapID}";
            //cmd.CommandText = $"DELETE FROM dbo.tblTakip WHERE KitapID={kitapID}";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            cmd.CommandText = $"UPDATE dbo.tblTakip SET GeldigiTarih='{teslimTarihi}' WHERE ID={takipID}";
            cmd.ExecuteNonQuery();
            cmd.CommandText = $"UPDATE dbo.tblUyeler SET CezaPuani='{ceza}' WHERE ID={uyeID}";
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();

            if(kisininAldigiKontrol.Checked == true)
            {
                kitapListesi.DataSource = null;
                kitapListesi.DataSource = uyeninAldigiKitaplar;
                kitapListesi.DisplayMember = "bilgi";
                kitapListesi.ValueMember = "ID";
            }
            else
            {
                kitapListesi.DataSource = null;
                kitapListesi.DataSource = kitaplar;
                kitapListesi.DisplayMember = "bilgi";
                kitapListesi.ValueMember = "ID";
            }
        }

        private void simdikiZamanButonu_Click(object sender, EventArgs e)
        {
            DateTime simdi = DateTime.Now;
            gunGirdisi.Text = simdi.Day.ToString();
            ayGirdisi.Text = simdi.Month.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                kitapListesi.DataSource = null;
                kitapListesi.DataSource = musaitKitaplar;
                kitapListesi.DisplayMember = "bilgi";
                kitapListesi.ValueMember = "ID";
            }
            else
            {
                kitapListesi.DataSource = null;
                kitapListesi.DataSource = kitaplar;
                kitapListesi.DisplayMember = "bilgi";
                kitapListesi.ValueMember = "ID";
            }
        }
    }
}
