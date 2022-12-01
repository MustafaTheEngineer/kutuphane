namespace kutuphaneUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uyeEkleMenuButonu_Click(object sender, EventArgs e)
        {
            UyeEkle uyeEkle = new UyeEkle();
            uyeEkle.Show(this);
        }

        private void kitapEkleMenuButonu_Click(object sender, EventArgs e)
        {
            KitapEkle kitapEkle = new KitapEkle();
            kitapEkle.Show(this);
        }

        private void kitapUyeMenuButonu_Click(object sender, EventArgs e)
        {
            kitapUye kitapUye = new kitapUye();
            kitapUye.Show(this);
        }
    }
}