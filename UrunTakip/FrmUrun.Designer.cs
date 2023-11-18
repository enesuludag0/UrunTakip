namespace UrunTakip
{
    partial class FrmUrun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numUpDwStok = new System.Windows.Forms.NumericUpDown();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.bttnGuncelle = new System.Windows.Forms.Button();
            this.bttnSil = new System.Windows.Forms.Button();
            this.bttnKaydet = new System.Windows.Forms.Button();
            this.bttnListele = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwStok)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(690, 451);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numUpDwStok);
            this.groupBox1.Controls.Add(this.comboBoxKategori);
            this.groupBox1.Controls.Add(this.bttnGuncelle);
            this.groupBox1.Controls.Add(this.bttnSil);
            this.groupBox1.Controls.Add(this.bttnKaydet);
            this.groupBox1.Controls.Add(this.bttnListele);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSatisFiyati);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAlisFiyati);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUrunAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUrunId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(708, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 460);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // numUpDwStok
            // 
            this.numUpDwStok.Location = new System.Drawing.Point(115, 98);
            this.numUpDwStok.Name = "numUpDwStok";
            this.numUpDwStok.Size = new System.Drawing.Size(166, 24);
            this.numUpDwStok.TabIndex = 3;
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(115, 213);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(166, 25);
            this.comboBoxKategori.TabIndex = 6;
            // 
            // bttnGuncelle
            // 
            this.bttnGuncelle.Location = new System.Drawing.Point(94, 402);
            this.bttnGuncelle.Name = "bttnGuncelle";
            this.bttnGuncelle.Size = new System.Drawing.Size(136, 40);
            this.bttnGuncelle.TabIndex = 10;
            this.bttnGuncelle.Text = "Güncelle";
            this.bttnGuncelle.UseVisualStyleBackColor = true;
            this.bttnGuncelle.Click += new System.EventHandler(this.bttnGuncelle_Click);
            // 
            // bttnSil
            // 
            this.bttnSil.Location = new System.Drawing.Point(94, 356);
            this.bttnSil.Name = "bttnSil";
            this.bttnSil.Size = new System.Drawing.Size(136, 40);
            this.bttnSil.TabIndex = 9;
            this.bttnSil.Text = "Sil";
            this.bttnSil.UseVisualStyleBackColor = true;
            this.bttnSil.Click += new System.EventHandler(this.bttnSil_Click);
            // 
            // bttnKaydet
            // 
            this.bttnKaydet.Location = new System.Drawing.Point(94, 310);
            this.bttnKaydet.Name = "bttnKaydet";
            this.bttnKaydet.Size = new System.Drawing.Size(136, 40);
            this.bttnKaydet.TabIndex = 8;
            this.bttnKaydet.Text = "Kaydet";
            this.bttnKaydet.UseVisualStyleBackColor = true;
            this.bttnKaydet.Click += new System.EventHandler(this.bttnKaydet_Click);
            // 
            // bttnListele
            // 
            this.bttnListele.Location = new System.Drawing.Point(94, 264);
            this.bttnListele.Name = "bttnListele";
            this.bttnListele.Size = new System.Drawing.Size(136, 40);
            this.bttnListele.TabIndex = 7;
            this.bttnListele.Text = "Listele";
            this.bttnListele.UseVisualStyleBackColor = true;
            this.bttnListele.Click += new System.EventHandler(this.bttnListele_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Kategori:";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(115, 174);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(166, 24);
            this.txtSatisFiyati.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Satış Fiyatı:";
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(115, 136);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(166, 24);
            this.txtAlisFiyati.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Alış Fiyatı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stok:";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(115, 59);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(166, 24);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Adı:";
            // 
            // txtUrunId
            // 
            this.txtUrunId.Location = new System.Drawing.Point(115, 23);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(166, 24);
            this.txtUrunId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün ID:";
            // 
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1016, 474);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUrun";
            this.Text = "FrmUrun";
            this.Load += new System.EventHandler(this.FrmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwStok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnListele;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlisFiyati;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttnGuncelle;
        private System.Windows.Forms.Button bttnSil;
        private System.Windows.Forms.Button bttnKaydet;
        private System.Windows.Forms.NumericUpDown numUpDwStok;
        private System.Windows.Forms.ComboBox comboBoxKategori;
    }
}