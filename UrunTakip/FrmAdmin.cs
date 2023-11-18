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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbUrun;Integrated Security=True");

        private void bttnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM TblAdmin WHERE KullaniciAdi=@KullaniciAdi " +
                "AND Sifre=@Sifre", baglanti);
            komut.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@Sifre", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmYonlendirme frm = new FrmYonlendirme();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifrenizi yanlış girdiniz.\n\tLütfen tekrar deneyiniz.");
            }
            baglanti.Close();
        }
    }
}
