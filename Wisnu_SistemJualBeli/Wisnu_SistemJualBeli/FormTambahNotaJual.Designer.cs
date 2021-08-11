namespace Wisnu_SistemJualBeli
{
    partial class FormTambahNotaJual
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
            this.labelJudul = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.labelGrandTotal = new System.Windows.Forms.Label();
            this.labelKodeNama = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelPegawai = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPelanggan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.textBoxKode = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJudul
            // 
            this.labelJudul.BackColor = System.Drawing.Color.Navy;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelJudul.Location = new System.Drawing.Point(12, 9);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(709, 53);
            this.labelJudul.TabIndex = 26;
            this.labelJudul.Text = "TAMBAH KATEGORI BARANG";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.textBoxJumlah);
            this.panel1.Controls.Add(this.textBoxHarga);
            this.panel1.Controls.Add(this.textBoxNama);
            this.panel1.Controls.Add(this.textBoxKode);
            this.panel1.Controls.Add(this.textBoxBarcode);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridViewInfo);
            this.panel1.Controls.Add(this.labelGrandTotal);
            this.panel1.Controls.Add(this.labelKodeNama);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelPegawai);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxPelanggan);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 517);
            this.panel1.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(630, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Jumlah";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(531, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Harga";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(332, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nama";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(159, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Barcode";
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Location = new System.Drawing.Point(10, 286);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.Size = new System.Drawing.Size(686, 214);
            this.dataGridViewInfo.TabIndex = 12;
            // 
            // labelGrandTotal
            // 
            this.labelGrandTotal.AutoSize = true;
            this.labelGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrandTotal.Location = new System.Drawing.Point(556, 162);
            this.labelGrandTotal.Name = "labelGrandTotal";
            this.labelGrandTotal.Size = new System.Drawing.Size(52, 55);
            this.labelGrandTotal.TabIndex = 11;
            this.labelGrandTotal.Text = "0";
            // 
            // labelKodeNama
            // 
            this.labelKodeNama.AutoSize = true;
            this.labelKodeNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKodeNama.Location = new System.Drawing.Point(108, 97);
            this.labelKodeNama.Name = "labelKodeNama";
            this.labelKodeNama.Size = new System.Drawing.Size(101, 20);
            this.labelKodeNama.TabIndex = 10;
            this.labelKodeNama.Text = "Kode Nama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = ":";
            // 
            // labelPegawai
            // 
            this.labelPegawai.AutoSize = true;
            this.labelPegawai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPegawai.Location = new System.Drawing.Point(6, 97);
            this.labelPegawai.Name = "labelPegawai";
            this.labelPegawai.Size = new System.Drawing.Size(76, 20);
            this.labelPegawai.TabIndex = 8;
            this.labelPegawai.Text = "Pegawai";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(408, 48);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(200, 102);
            this.textBox2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(332, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alamat:";
            // 
            // comboBoxPelanggan
            // 
            this.comboBoxPelanggan.FormattingEnabled = true;
            this.comboBoxPelanggan.Location = new System.Drawing.Point(408, 14);
            this.comboBoxPelanggan.Name = "comboBoxPelanggan";
            this.comboBoxPelanggan.Size = new System.Drawing.Size(192, 21);
            this.comboBoxPelanggan.TabIndex = 5;
            this.comboBoxPelanggan.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pelanggan:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tanggal:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "No.Nota:";
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.Navy;
            this.buttonTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTambah.Location = new System.Drawing.Point(12, 600);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(110, 44);
            this.buttonTambah.TabIndex = 28;
            this.buttonTambah.Text = "SIMPAN";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(135, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 44);
            this.button1.TabIndex = 29;
            this.button1.Text = "CETAK";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(611, 601);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 44);
            this.button2.TabIndex = 30;
            this.button2.Text = "KELUAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.BackColor = System.Drawing.Color.White;
            this.textBoxBarcode.Location = new System.Drawing.Point(10, 256);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(117, 20);
            this.textBoxBarcode.TabIndex = 18;
            this.textBoxBarcode.TextChanged += new System.EventHandler(this.textBoxBarcode_TextChanged);
            // 
            // textBoxKode
            // 
            this.textBoxKode.BackColor = System.Drawing.Color.White;
            this.textBoxKode.Location = new System.Drawing.Point(133, 256);
            this.textBoxKode.Name = "textBoxKode";
            this.textBoxKode.Size = new System.Drawing.Size(117, 20);
            this.textBoxKode.TabIndex = 19;
            // 
            // textBoxNama
            // 
            this.textBoxNama.BackColor = System.Drawing.Color.White;
            this.textBoxNama.Enabled = false;
            this.textBoxNama.Location = new System.Drawing.Point(256, 256);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(257, 20);
            this.textBoxNama.TabIndex = 20;
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.BackColor = System.Drawing.Color.White;
            this.textBoxHarga.Location = new System.Drawing.Point(519, 256);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(89, 20);
            this.textBoxHarga.TabIndex = 21;
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.BackColor = System.Drawing.Color.White;
            this.textBoxJumlah.Location = new System.Drawing.Point(614, 256);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(92, 20);
            this.textBoxJumlah.TabIndex = 22;
            this.textBoxJumlah.TextChanged += new System.EventHandler(this.textBoxJumlah_TextChanged);
            // 
            // FormTambahNotaJual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(733, 657);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelJudul);
            this.Name = "FormTambahNotaJual";
            this.Text = "Tambah Nota Jual";
            this.Load += new System.EventHandler(this.FormTambahNotaJual_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.Label labelGrandTotal;
        private System.Windows.Forms.Label labelKodeNama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelPegawai;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPelanggan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxKode;
        private System.Windows.Forms.TextBox textBoxBarcode;
    }
}