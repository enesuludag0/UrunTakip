using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UrunTakip
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbUrun;Integrated Security=True");

        private void bttnListele_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM TblUrunler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bttnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TblUrunler (UrunAd,Stok,AlisFiyat,SatisFiyat,Kategori)" +
                "VALUES (@UrunAd,@Stok,@AlisFiyat,@SatisFiyat,@Kategori)", baglanti);
            komut.Parameters.AddWithValue("@UrunAd", txtUrunAdi.Text);
            komut.Parameters.AddWithValue("@Stok", numUpDwStok.Value);
            komut.Parameters.AddWithValue("@AlisFiyat", txtAlisFiyati.Text);
            komut.Parameters.AddWithValue("@SatisFiyat", txtSatisFiyati.Text);
            komut.Parameters.AddWithValue("@Kategori", comboBoxKategori.SelectedValue);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün başarılı bir şekilde eklendi");
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM TblKategori", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxKategori.DisplayMember = "KategoriAdi";
            comboBoxKategori.ValueMember = "Id";
            comboBoxKategori.DataSource = dt;
        }

        private void bttnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM TblUrunler WHERE UrunId=@UrunId", baglanti);
            komut.Parameters.AddWithValue("@UrunId", txtUrunId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün başarılı bir şekilde silindi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtUrunAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            numUpDwStok.Value = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            txtAlisFiyati.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtSatisFiyati.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBoxKategori.SelectedValue = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void bttnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE TblUrunler SET UrunAd=@UrunAd, Stok=@Stok," +
                "AlisFiyat=@AlisFiyat, SatisFiyat=@SatisFiyat, Kategori=@Kategori WHERE UrunId=@UrunId", baglanti);
            komut.Parameters.AddWithValue("@UrunAd", txtUrunAdi.Text);
            komut.Parameters.AddWithValue("@Stok", numUpDwStok.Value);
            komut.Parameters.AddWithValue("@AlisFiyat", decimal.Parse(txtAlisFiyati.Text));
            komut.Parameters.AddWithValue("@SatisFiyat", decimal.Parse(txtSatisFiyati.Text));
            komut.Parameters.AddWithValue("@Kategori", comboBoxKategori.SelectedValue);
            komut.Parameters.AddWithValue("@UrunId", txtUrunId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün başarılı bir şekilde güncellendi","Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
