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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbUrun;Integrated Security=True");

        private void bttnListele_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM TblKategori", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void bttnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TblKategori (KategoriAdi) VALUES (@KategoriAdi)", baglanti);
            komut.Parameters.AddWithValue("@KategoriAdi", txtKategoriAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori ekleme işlemi başarılı bir şekilde gerçekleşti");
        }

        private void bttnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM TblKategori WHERE Id=@Id", baglanti);
            komut.Parameters.AddWithValue("@Id", txtId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori silme işlemi başarılı bir şekilde gerçekleşti");
        }

        private void bttnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE TblKategori SET KategoriAdi=@KategoriAdi WHERE Id=@Id", baglanti);
            komut.Parameters.AddWithValue("@KategoriAdi", txtKategoriAd.Text);
            komut.Parameters.AddWithValue("@Id", txtId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori güncelleme işlemi başarılı bir şekilde gerçekleşti");
        }

        private void bttnAra_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM TblKategori WHERE KategoriAdi=@KategoriAdi", baglanti);
            komut.Parameters.AddWithValue("@KategoriAdi", txtKategoriAd.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtKategoriAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}

//Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DbUrun;Integrated Security=True

