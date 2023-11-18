namespace UrunTakip
{
    partial class Form1
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtKategoriAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnListele = new System.Windows.Forms.Button();
            this.bttnKaydet = new System.Windows.Forms.Button();
            this.bttnSil = new System.Windows.Forms.Button();
            this.bttnGuncelle = new System.Windows.Forms.Button();
            this.bttnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(435, 224);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtKategoriAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(362, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(51, 26);
            this.txtId.TabIndex = 3;
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.Location = new System.Drawing.Point(123, 23);
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Size = new System.Drawing.Size(166, 26);
            this.txtKategoriAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı:";
            // 
            // bttnListele
            // 
            this.bttnListele.Location = new System.Drawing.Point(453, 96);
            this.bttnListele.Name = "bttnListele";
            this.bttnListele.Size = new System.Drawing.Size(136, 40);
            this.bttnListele.TabIndex = 2;
            this.bttnListele.Text = "Listele";
            this.bttnListele.UseVisualStyleBackColor = true;
            this.bttnListele.Click += new System.EventHandler(this.bttnListele_Click);
            // 
            // bttnKaydet
            // 
            this.bttnKaydet.Location = new System.Drawing.Point(453, 142);
            this.bttnKaydet.Name = "bttnKaydet";
            this.bttnKaydet.Size = new System.Drawing.Size(136, 40);
            this.bttnKaydet.TabIndex = 3;
            this.bttnKaydet.Text = "Kaydet";
            this.bttnKaydet.UseVisualStyleBackColor = true;
            this.bttnKaydet.Click += new System.EventHandler(this.bttnKaydet_Click);
            // 
            // bttnSil
            // 
            this.bttnSil.Location = new System.Drawing.Point(453, 188);
            this.bttnSil.Name = "bttnSil";
            this.bttnSil.Size = new System.Drawing.Size(136, 40);
            this.bttnSil.TabIndex = 4;
            this.bttnSil.Text = "Sil";
            this.bttnSil.UseVisualStyleBackColor = true;
            this.bttnSil.Click += new System.EventHandler(this.bttnSil_Click);
            // 
            // bttnGuncelle
            // 
            this.bttnGuncelle.Location = new System.Drawing.Point(453, 234);
            this.bttnGuncelle.Name = "bttnGuncelle";
            this.bttnGuncelle.Size = new System.Drawing.Size(136, 40);
            this.bttnGuncelle.TabIndex = 5;
            this.bttnGuncelle.Text = "Güncelle";
            this.bttnGuncelle.UseVisualStyleBackColor = true;
            this.bttnGuncelle.Click += new System.EventHandler(this.bttnGuncelle_Click);
            // 
            // bttnAra
            // 
            this.bttnAra.Location = new System.Drawing.Point(453, 280);
            this.bttnAra.Name = "bttnAra";
            this.bttnAra.Size = new System.Drawing.Size(136, 40);
            this.bttnAra.TabIndex = 6;
            this.bttnAra.Text = "Ara";
            this.bttnAra.UseVisualStyleBackColor = true;
            this.bttnAra.Click += new System.EventHandler(this.bttnAra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(599, 332);
            this.Controls.Add(this.bttnAra);
            this.Controls.Add(this.bttnGuncelle);
            this.Controls.Add(this.bttnSil);
            this.Controls.Add(this.bttnKaydet);
            this.Controls.Add(this.bttnListele);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategoriler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKategoriAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnListele;
        private System.Windows.Forms.Button bttnKaydet;
        private System.Windows.Forms.Button bttnSil;
        private System.Windows.Forms.Button bttnGuncelle;
        private System.Windows.Forms.Button bttnAra;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
    }
}

