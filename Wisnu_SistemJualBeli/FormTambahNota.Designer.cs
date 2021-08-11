namespace Wisnu_SistemJualBeli
{
    partial class FormTambahNota
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
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonCetak = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.labelJudul = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNamaPegawai = new System.Windows.Forms.Label();
            this.labelKodePegawai = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxNota = new System.Windows.Forms.TextBox();
            this.dateTimePickerTanggal = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPelanggan = new System.Windows.Forms.ComboBox();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.labelHarga = new System.Windows.Forms.Label();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.textBoxKode = new System.Windows.Forms.TextBox();
            this.textBoxNamaBarang = new System.Windows.Forms.TextBox();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKeluar.Location = new System.Drawing.Point(551, 514);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(94, 31);
            this.buttonKeluar.TabIndex = 23;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonCetak
            // 
            this.buttonCetak.BackColor = System.Drawing.Color.Navy;
            this.buttonCetak.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCetak.Location = new System.Drawing.Point(131, 514);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(94, 31);
            this.buttonCetak.TabIndex = 21;
            this.buttonCetak.Text = "CETAK";
            this.buttonCetak.UseVisualStyleBackColor = false;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.Navy;
            this.buttonSimpan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSimpan.Location = new System.Drawing.Point(31, 514);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(94, 31);
            this.buttonSimpan.TabIndex = 20;
            this.buttonSimpan.Text = "SIMPAN";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Location = new System.Drawing.Point(9, 260);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.Size = new System.Drawing.Size(652, 234);
            this.dataGridViewInfo.TabIndex = 19;
            // 
            // labelJudul
            // 
            this.labelJudul.BackColor = System.Drawing.Color.Navy;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelJudul.Location = new System.Drawing.Point(10, 7);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(651, 53);
            this.labelJudul.TabIndex = 17;
            this.labelJudul.Text = "TAMBAH NOTA JUAL";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "No Nota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tanggal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Pelanggan";
            // 
            // labelNamaPegawai
            // 
            this.labelNamaPegawai.AutoSize = true;
            this.labelNamaPegawai.Location = new System.Drawing.Point(13, 150);
            this.labelNamaPegawai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNamaPegawai.Name = "labelNamaPegawai";
            this.labelNamaPegawai.Size = new System.Drawing.Size(54, 13);
            this.labelNamaPegawai.TabIndex = 28;
            this.labelNamaPegawai.Text = "Pegawai :";
            // 
            // labelKodePegawai
            // 
            this.labelKodePegawai.AutoSize = true;
            this.labelKodePegawai.Location = new System.Drawing.Point(68, 150);
            this.labelKodePegawai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKodePegawai.Name = "labelKodePegawai";
            this.labelKodePegawai.Size = new System.Drawing.Size(63, 13);
            this.labelKodePegawai.TabIndex = 29;
            this.labelKodePegawai.Text = "Kode Nama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 214);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Barcode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 214);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Kode";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 214);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Nama Barang";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(422, 214);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Harga";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(575, 214);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Jumlah";
            // 
            // textBoxNota
            // 
            this.textBoxNota.Location = new System.Drawing.Point(70, 76);
            this.textBoxNota.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNota.Name = "textBoxNota";
            this.textBoxNota.Size = new System.Drawing.Size(145, 20);
            this.textBoxNota.TabIndex = 35;
            // 
            // dateTimePickerTanggal
            // 
            this.dateTimePickerTanggal.Location = new System.Drawing.Point(70, 108);
            this.dateTimePickerTanggal.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerTanggal.Name = "dateTimePickerTanggal";
            this.dateTimePickerTanggal.Size = new System.Drawing.Size(145, 20);
            this.dateTimePickerTanggal.TabIndex = 36;
            // 
            // comboBoxPelanggan
            // 
            this.comboBoxPelanggan.FormattingEnabled = true;
            this.comboBoxPelanggan.Location = new System.Drawing.Point(446, 75);
            this.comboBoxPelanggan.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPelanggan.Name = "comboBoxPelanggan";
            this.comboBoxPelanggan.Size = new System.Drawing.Size(135, 21);
            this.comboBoxPelanggan.TabIndex = 37;
            this.comboBoxPelanggan.SelectedIndexChanged += new System.EventHandler(this.comboBoxPelanggan_SelectedIndexChanged);
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(446, 110);
            this.textBoxAlamat.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(199, 20);
            this.textBoxAlamat.TabIndex = 38;
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.Location = new System.Drawing.Point(374, 141);
            this.labelHarga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(69, 73);
            this.labelHarga.TabIndex = 39;
            this.labelHarga.Text = "0";
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Location = new System.Drawing.Point(9, 229);
            this.textBoxBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(107, 20);
            this.textBoxBarcode.TabIndex = 40;
            this.textBoxBarcode.TextChanged += new System.EventHandler(this.textBoxBarcode_TextChanged);
            // 
            // textBoxKode
            // 
            this.textBoxKode.Location = new System.Drawing.Point(120, 229);
            this.textBoxKode.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKode.Name = "textBoxKode";
            this.textBoxKode.Size = new System.Drawing.Size(93, 20);
            this.textBoxKode.TabIndex = 41;
            // 
            // textBoxNamaBarang
            // 
            this.textBoxNamaBarang.Location = new System.Drawing.Point(217, 229);
            this.textBoxNamaBarang.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNamaBarang.Name = "textBoxNamaBarang";
            this.textBoxNamaBarang.Size = new System.Drawing.Size(145, 20);
            this.textBoxNamaBarang.TabIndex = 42;
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(381, 229);
            this.textBoxHarga.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(124, 20);
            this.textBoxHarga.TabIndex = 43;
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.Location = new System.Drawing.Point(530, 229);
            this.textBoxJumlah.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(115, 20);
            this.textBoxJumlah.TabIndex = 44;
            this.textBoxJumlah.TextChanged += new System.EventHandler(this.textBoxJumlah_TextChanged);
            this.textBoxJumlah.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxJumlah_KeyDown);
            // 
            // FormTambahNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 563);
            this.Controls.Add(this.textBoxJumlah);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.textBoxNamaBarang);
            this.Controls.Add(this.textBoxKode);
            this.Controls.Add(this.textBoxBarcode);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.textBoxAlamat);
            this.Controls.Add(this.comboBoxPelanggan);
            this.Controls.Add(this.dateTimePickerTanggal);
            this.Controls.Add(this.textBoxNota);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelKodePegawai);
            this.Controls.Add(this.labelNamaPegawai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonCetak);
            this.Controls.Add(this.buttonSimpan);
            this.Controls.Add(this.dataGridViewInfo);
            this.Controls.Add(this.labelJudul);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTambahNota";
            this.Text = "FormTambahNota";
            this.Load += new System.EventHandler(this.FormTambahNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonCetak;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNamaPegawai;
        private System.Windows.Forms.Label labelKodePegawai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxNota;
        private System.Windows.Forms.DateTimePicker dateTimePickerTanggal;
        private System.Windows.Forms.ComboBox comboBoxPelanggan;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.TextBox textBoxKode;
        private System.Windows.Forms.TextBox textBoxNamaBarang;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.TextBox textBoxJumlah;
    }
}