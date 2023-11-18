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
    public partial class FrmYonlendirme : Form
    {
        public FrmYonlendirme()
        {
            InitializeComponent();
        }

        private void pnlUrun_Click(object sender, EventArgs e)
        {
            FrmUrun frm = new FrmUrun();
            frm.Show();
        }

        private void pnlKategori_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void pnlİstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik frm = new FrmIstatistik();
            frm.Show();
        }

        private void pnlGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler frm = new FrmGrafikler();
            frm.Show();
        }

        private void pnlLogin_Click(object sender, EventArgs e)
        {
            FrmAdmin frm = new FrmAdmin();
            frm.Show();
            this.Hide();
        }
    }
}
