using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunTakip
{
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.TblMusteriTableAdapter tb = new DataSet1TableAdapters.TblMusteriTableAdapter();

        private void bttnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tb.MusteriListesi();
        }

        private void bttnKaydet_Click(object sender, EventArgs e)
        {
            tb.MusteriEkle(txtAd.Text, txtSoyad.Text, txtSehir.Text, decimal.Parse(txtBakiye.Text));
            MessageBox.Show("Müşteri sisteme kaydedildi");
        }

        private void bttnSil_Click(object sender, EventArgs e)
        {
            tb.MusteriSil(int.Parse(txtMusteriId.Text));
            MessageBox.Show("Müşteri sistemden silindi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMusteriId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSehir.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtBakiye.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void bttnGuncelle_Click(object sender, EventArgs e)
        {
            tb.MusteriGuncelle(txtAd.Text, txtSoyad.Text, txtSehir.Text, decimal.Parse(txtBakiye.Text), int.Parse(txtMusteriId.Text));
            MessageBox.Show("Müşteri bilgileri güncellendi");
        }

        private void bttnAra_Click(object sender, EventArgs e)
        {
            if (rdbAd.Checked == true)
            {
                dataGridView1.DataSource = tb.AdaGoreListele(txtAranacakKelime.Text);
            }
            if (rdbSoyad.Checked==true)
            {
                dataGridView1.DataSource = tb.SoyadaGoreListele(txtAranacakKelime.Text);
            }
            if (rdbSehir.Checked == true)
            {
                dataGridView1.DataSource = tb.SehireGoreListele (txtAranacakKelime.Text);
            }
        }
    }
}
