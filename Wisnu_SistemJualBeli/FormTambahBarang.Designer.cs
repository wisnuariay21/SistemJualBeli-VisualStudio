namespace Wisnu_SistemJualBeli
{
    partial class FormTambahBarang
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
            this.buttonkosong = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.textBoxKodeBar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBerdasarkan = new System.Windows.Forms.Label();
            this.labelJudul = new System.Windows.Forms.Label();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxJual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxStok = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKeluar.Location = new System.Drawing.Point(527, 435);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(125, 38);
            this.buttonKeluar.TabIndex = 29;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonkosong
            // 
            this.buttonkosong.BackColor = System.Drawing.Color.Navy;
            this.buttonkosong.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonkosong.Location = new System.Drawing.Point(175, 435);
            this.buttonkosong.Margin = new System.Windows.Forms.Padding(4);
            this.buttonkosong.Name = "buttonkosong";
            this.buttonkosong.Size = new System.Drawing.Size(125, 38);
            this.buttonkosong.TabIndex = 28;
            this.buttonkosong.Text = "KOSONGI";
            this.buttonkosong.UseVisualStyleBackColor = false;
            this.buttonkosong.Click += new System.EventHandler(this.buttonkosong_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.Navy;
            this.buttonTambah.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTambah.Location = new System.Drawing.Point(42, 435);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(125, 38);
            this.buttonTambah.TabIndex = 27;
            this.buttonTambah.Text = "TAMBAH";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelInfo.Controls.Add(this.comboBoxKategori);
            this.panelInfo.Controls.Add(this.textBoxStok);
            this.panelInfo.Controls.Add(this.label5);
            this.panelInfo.Controls.Add(this.textBoxJual);
            this.panelInfo.Controls.Add(this.label4);
            this.panelInfo.Controls.Add(this.textBoxNama);
            this.panelInfo.Controls.Add(this.label3);
            this.panelInfo.Controls.Add(this.textBoxBarcode);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.textBoxKodeBar);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.labelBerdasarkan);
            this.panelInfo.Location = new System.Drawing.Point(13, 78);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(4);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(679, 349);
            this.panelInfo.TabIndex = 26;
            // 
            // textBoxKodeBar
            // 
            this.textBoxKodeBar.Location = new System.Drawing.Point(156, 85);
            this.textBoxKodeBar.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKodeBar.Name = "textBoxKodeBar";
            this.textBoxKodeBar.Size = new System.Drawing.Size(240, 22);
            this.textBoxKodeBar.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kode Barang";
            // 
            // labelBerdasarkan
            // 
            this.labelBerdasarkan.AutoSize = true;
            this.labelBerdasarkan.Location = new System.Drawing.Point(16, 39);
            this.labelBerdasarkan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBerdasarkan.Name = "labelBerdasarkan";
            this.labelBerdasarkan.Size = new System.Drawing.Size(119, 17);
            this.labelBerdasarkan.TabIndex = 0;
            this.labelBerdasarkan.Text = "Kategori Barang :";
            // 
            // labelJudul
            // 
            this.labelJudul.BackColor = System.Drawing.Color.Navy;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelJudul.Location = new System.Drawing.Point(13, 9);
            this.labelJudul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(679, 65);
            this.labelJudul.TabIndex = 25;
            this.labelJudul.Text = "TAMBAH KATEGORI BARANG";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Location = new System.Drawing.Point(156, 127);
            this.textBoxBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(240, 22);
            this.textBoxBarcode.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Barcode";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(156, 174);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(240, 22);
            this.textBoxNama.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nama Barang";
            // 
            // textBoxJual
            // 
            this.textBoxJual.Location = new System.Drawing.Point(156, 219);
            this.textBoxJual.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxJual.Name = "textBoxJual";
            this.textBoxJual.Size = new System.Drawing.Size(240, 22);
            this.textBoxJual.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Harga Jual";
            // 
            // textBoxStok
            // 
            this.textBoxStok.Location = new System.Drawing.Point(156, 264);
            this.textBoxStok.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStok.Name = "textBoxStok";
            this.textBoxStok.Size = new System.Drawing.Size(240, 22);
            this.textBoxStok.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 264);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Stok";
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(156, 39);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(240, 24);
            this.comboBoxKategori.TabIndex = 14;
            this.comboBoxKategori.SelectedIndexChanged += new System.EventHandler(this.comboBoxKategori_SelectedIndexChanged);
            // 
            // FormTambahBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 486);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonkosong);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.labelJudul);
            this.Name = "FormTambahBarang";
            this.Text = "FormTambahBarang";
            this.Load += new System.EventHandler(this.FormTambahBarang_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonkosong;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.TextBox textBoxKodeBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBerdasarkan;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.TextBox textBoxStok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxJual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKategori;
    }
}