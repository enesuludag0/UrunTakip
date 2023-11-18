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

namespace UrunTakip
{
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbUrun;Integrated Security=True");

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            //Toplam Kategori Sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("SELECT COUNT(*) FROM TblKategori", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblToplamKategoriSayisi.Text = dr1[0].ToString();
            }
            baglanti.Close();

            //Toplam Ürün Sayısı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT COUNT(*) FROM TblUrunler", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblToplamUrunSayisi.Text = dr2[0].ToString();
            }
            baglanti.Close();

            //Toplam Beyaz Eşya Sayısı
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("SELECT COUNT(*) FROM TblUrunler WHERE " +
                "Kategori=(SELECT Id FROM TblKategori WHERE KategoriAdi='Beyaz Eşya')", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblBeyazEsyaSayisi.Text = dr3[0].ToString();
            }
            baglanti.Close();

            //Toplam Küçük Ev Aletleri Sayısı
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("SELECT COUNT(*) FROM TblUrunler WHERE " +
                "Kategori=(SELECT Id FROM TblKategori WHERE KategoriAdi='Küçük Ev Aletleri')", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblKucukEvAletleriSayisi.Text = dr4[0].ToString();
            }
            baglanti.Close();

            //En Yüksek Stoklu Ürün
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("SELECT * FROM TblUrunler WHERE" +
                " Stok=(SELECT MAX(Stok) FROM TblUrunler)", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblEnYuksekStokluUrun.Text = dr5["UrunAd"].ToString();
            }
            baglanti.Close();

            //En Düşük Stoklu Ürün
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("SELECT * FROM TblUrunler WHERE" +
                " Stok=(SELECT MIN(Stok) FROM TblUrunler)", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblEnDusukStokluUrun.Text = dr6["UrunAd"].ToString();
            }
            baglanti.Close();

            //Laptop Ürününün Toplam Karı
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("SELECT Stok*(SatisFiyat-AlisFiyat) FROM TblUrunler " +
                "WHERE UrunAd='Laptop'", baglanti);
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                lblLaptopToplamKar.Text = dr7[0].ToString() + " ₺";
            }
            baglanti.Close();

            //Beyaz Eşya Kategorisinde Bulunan Ürünlerin Toplam Karı
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("SELECT SUM(Stok*(SatisFiyat-AlisFiyat)) FROM TblUrunler " +
                "WHERE Kategori = (SELECT Id FROM TblKategori WHERE KategoriAdi = 'Beyaz Eşya')", baglanti);
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                lblBeyazEsyaToplamKar.Text = dr8[0].ToString() + " ₺";
            }
            baglanti.Close();
        }
    }
}
