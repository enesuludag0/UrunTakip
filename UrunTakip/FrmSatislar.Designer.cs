namespace UrunTakip
{
    partial class FrmSatislar
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
            this.bttnGuncelle = new System.Windows.Forms.Button();
            this.bttnIptalEt = new System.Windows.Forms.Button();
            this.bttnKaydet = new System.Windows.Forms.Button();
            this.bttnListele = new System.Windows.Forms.Button();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSatisId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnGuncelle
            // 
            this.bttnGuncelle.Location = new System.Drawing.Point(68, 384);
            this.bttnGuncelle.Name = "bttnGuncelle";
            this.bttnGuncelle.Size = new System.Drawing.Size(136, 40);
            this.bttnGuncelle.TabIndex = 9;
            this.bttnGuncelle.Text = "Güncelle";
            this.bttnGuncelle.UseVisualStyleBackColor = true;
            this.bttnGuncelle.Click += new System.EventHandler(this.bttnGuncelle_Click);
            // 
            // bttnIptalEt
            // 
            this.bttnIptalEt.Location = new System.Drawing.Point(68, 338);
            this.bttnIptalEt.Name = "bttnIptalEt";
            this.bttnIptalEt.Size = new System.Drawing.Size(136, 40);
            this.bttnIptalEt.TabIndex = 8;
            this.bttnIptalEt.Text = "İptal Et";
            this.bttnIptalEt.UseVisualStyleBackColor = true;
            this.bttnIptalEt.Click += new System.EventHandler(this.bttnIptalEt_Click);
            // 
            // bttnKaydet
            // 
            this.bttnKaydet.Location = new System.Drawing.Point(68, 292);
            this.bttnKaydet.Name = "bttnKaydet";
            this.bttnKaydet.Size = new System.Drawing.Size(136, 40);
            this.bttnKaydet.TabIndex = 7;
            this.bttnKaydet.Text = "Kaydet";
            this.bttnKaydet.UseVisualStyleBackColor = true;
            this.bttnKaydet.Click += new System.EventHandler(this.bttnKaydet_Click);
            // 
            // bttnListele
            // 
            this.bttnListele.Location = new System.Drawing.Point(68, 246);
            this.bttnListele.Name = "bttnListele";
            this.bttnListele.Size = new System.Drawing.Size(136, 40);
            this.bttnListele.TabIndex = 6;
            this.bttnListele.Text = "Listele";
            this.bttnListele.UseVisualStyleBackColor = true;
            this.bttnListele.Click += new System.EventHandler(this.bttnListele_Click);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(83, 145);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(154, 24);
            this.txtFiyat.TabIndex = 5;
            this.txtFiyat.TextChanged += new System.EventHandler(this.txtFiyat_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fiyat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Adet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Müşteri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün:";
            // 
            // txtSatisId
            // 
            this.txtSatisId.Location = new System.Drawing.Point(83, 23);
            this.txtSatisId.Name = "txtSatisId";
            this.txtSatisId.Size = new System.Drawing.Size(154, 24);
            this.txtSatisId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Satış ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtMusteri);
            this.groupBox1.Controls.Add(this.cmbUrun);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtToplam);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.bttnGuncelle);
            this.groupBox1.Controls.Add(this.bttnIptalEt);
            this.groupBox1.Controls.Add(this.bttnKaydet);
            this.groupBox1.Controls.Add(this.bttnListele);
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAdet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSatisId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(708, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 433);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(83, 85);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(154, 24);
            this.txtMusteri.TabIndex = 15;
            // 
            // cmbUrun
            // 
            this.cmbUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Location = new System.Drawing.Point(83, 53);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(154, 26);
            this.cmbUrun.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tarih:";
            // 
            // txtToplam
            // 
            this.txtToplam.Enabled = false;
            this.txtToplam.Location = new System.Drawing.Point(83, 175);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Size = new System.Drawing.Size(154, 24);
            this.txtToplam.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Toplam:";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(83, 115);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(154, 24);
            this.txtAdet.TabIndex = 4;
            this.txtAdet.TextChanged += new System.EventHandler(this.txtAdet_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(690, 424);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 205);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 24);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // FrmSatislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 448);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSatislar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSatislar";
            this.Load += new System.EventHandler(this.FrmSatislar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bttnGuncelle;
        private System.Windows.Forms.Button bttnIptalEt;
        private System.Windows.Forms.Button bttnKaydet;
        private System.Windows.Forms.Button bttnListele;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSatisId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.ComboBox cmbUrun;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}