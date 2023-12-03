using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunTakip
{
    public partial class FrmSatislar : Form
    {
        public FrmSatislar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbUrun;Integrated Security=True");

        DataSet1TableAdapters.TblSatislarTableAdapter ds = new DataSet1TableAdapters.TblSatislarTableAdapter();

        private void TarihDonustur()
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }
      
        private void bttnListele_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("EXECUTE SatisListesi", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            TarihDonustur();
        }

        private void FrmSatislar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM TblUrunler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbUrun.DisplayMember = "UrunAd";
            cmbUrun.ValueMember = "UrunId";
            cmbUrun.DataSource = dt;
            TarihDonustur();

            dataGridView1.DataSource = ds.SatisListesi();
        }

        private void bttnKaydet_Click(object sender, EventArgs e)
        {
            ds.SatisEkle(int.Parse(cmbUrun.SelectedValue.ToString()), int.Parse(txtMusteri.Text), byte.Parse(txtAdet.Text),
                decimal.Parse(txtFiyat.Text), decimal.Parse(txtToplam.Text), DateTime.Parse(dateTimePicker1.Text));
            MessageBox.Show("Satış başarıyla yapıldı");
            TarihDonustur();
        }

        int adet;
        double fiyat, toplam;
        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
            if (txtAdet.Text == "")
            {          
                txtToplam.Text = 0.ToString();
            }
            else
            {
                adet = Convert.ToInt16(txtAdet.Text);
                toplam = adet * fiyat;
                txtToplam.Text = toplam.ToString();
            }
        }

        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {
            if (txtFiyat.Text == "")
            {
                txtToplam.Text = 0.ToString();
            }
            else
            {
                fiyat = Convert.ToDouble(txtFiyat.Text);
                toplam = adet * fiyat;
                txtToplam.Text = toplam.ToString();
            }
        }

        private void bttnIptalEt_Click(object sender, EventArgs e)
        {
            ds.SatisIptalEt(int.Parse(txtSatisId.Text));
            MessageBox.Show("Satış başarılı bir şekilde iptal edildi");
            TarihDonustur();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSatisId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cmbUrun.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtMusteri.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtAdet.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtFiyat.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtToplam.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();      
        }

        private void bttnGuncelle_Click(object sender, EventArgs e)
        {
            ds.SatisGuncelle(int.Parse(cmbUrun.SelectedValue.ToString()), int.Parse(txtMusteri.Text), byte.Parse(txtAdet.Text),
                decimal.Parse(txtFiyat.Text), decimal.Parse(txtToplam.Text), DateTime.Parse(dateTimePicker1.Text), int.Parse(txtSatisId.Text));
            MessageBox.Show("Satış bilgileri güncellendi");
        }
    }
}
