namespace Wisnu_SistemJualBeli
{
    partial class FormUbahBarang
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
            this.panelInfo = new System.Windows.Forms.Panel();
            this.textBoxKategoriBarang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKodeBarang = new System.Windows.Forms.TextBox();
            this.labelBerdasarkan = new System.Windows.Forms.Label();
            this.labelJudul = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonkosong = new System.Windows.Forms.Button();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.textBoxNamaBarang = new System.Windows.Forms.TextBox();
            this.textBoxHargaJual = new System.Windows.Forms.TextBox();
            this.textBoxStok = new System.Windows.Forms.TextBox();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelInfo.Controls.Add(this.textBoxStok);
            this.panelInfo.Controls.Add(this.textBoxHargaJual);
            this.panelInfo.Controls.Add(this.textBoxNamaBarang);
            this.panelInfo.Controls.Add(this.textBoxBarcode);
            this.panelInfo.Controls.Add(this.label5);
            this.panelInfo.Controls.Add(this.label4);
            this.panelInfo.Controls.Add(this.label3);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.textBoxKategoriBarang);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.textBoxKodeBarang);
            this.panelInfo.Controls.Add(this.labelBerdasarkan);
            this.panelInfo.Location = new System.Drawing.Point(12, 65);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(509, 278);
            this.panelInfo.TabIndex = 31;
            // 
            // textBoxKategoriBarang
            // 
            this.textBoxKategoriBarang.Location = new System.Drawing.Point(117, 65);
            this.textBoxKategoriBarang.Name = "textBoxKategoriBarang";
            this.textBoxKategoriBarang.Size = new System.Drawing.Size(181, 20);
            this.textBoxKategoriBarang.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategori Barang :";
            // 
            // textBoxKodeBarang
            // 
            this.textBoxKodeBarang.Location = new System.Drawing.Point(117, 29);
            this.textBoxKodeBarang.Name = "textBoxKodeBarang";
            this.textBoxKodeBarang.Size = new System.Drawing.Size(181, 20);
            this.textBoxKodeBarang.TabIndex = 2;
            this.textBoxKodeBarang.TextChanged += new System.EventHandler(this.textBoxKodeBarang_TextChanged);
            // 
            // labelBerdasarkan
            // 
            this.labelBerdasarkan.AutoSize = true;
            this.labelBerdasarkan.Location = new System.Drawing.Point(12, 32);
            this.labelBerdasarkan.Name = "labelBerdasarkan";
            this.labelBerdasarkan.Size = new System.Drawing.Size(75, 13);
            this.labelBerdasarkan.TabIndex = 0;
            this.labelBerdasarkan.Text = "Kode Barang :";
            // 
            // labelJudul
            // 
            this.labelJudul.BackColor = System.Drawing.Color.Navy;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelJudul.Location = new System.Drawing.Point(12, 9);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(509, 53);
            this.labelJudul.TabIndex = 30;
            this.labelJudul.Text = "UBAH KATEGORI BARANG";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKeluar.Location = new System.Drawing.Point(403, 349);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(94, 31);
            this.buttonKeluar.TabIndex = 34;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonkosong
            // 
            this.buttonkosong.BackColor = System.Drawing.Color.Navy;
            this.buttonkosong.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonkosong.Location = new System.Drawing.Point(139, 349);
            this.buttonkosong.Name = "buttonkosong";
            this.buttonkosong.Size = new System.Drawing.Size(94, 31);
            this.buttonkosong.TabIndex = 33;
            this.buttonkosong.Text = "KOSONGI";
            this.buttonkosong.UseVisualStyleBackColor = false;
            this.buttonkosong.Click += new System.EventHandler(this.buttonkosong_Click);
            // 
            // buttonUbah
            // 
            this.buttonUbah.BackColor = System.Drawing.Color.Navy;
            this.buttonUbah.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUbah.Location = new System.Drawing.Point(40, 349);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(94, 31);
            this.buttonUbah.TabIndex = 32;
            this.buttonUbah.Text = "UBAH";
            this.buttonUbah.UseVisualStyleBackColor = false;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Barcode :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nama Barang :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Harga Jual :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stok :";
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Location = new System.Drawing.Point(117, 98);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(181, 20);
            this.textBoxBarcode.TabIndex = 10;
            // 
            // textBoxNamaBarang
            // 
            this.textBoxNamaBarang.Location = new System.Drawing.Point(117, 128);
            this.textBoxNamaBarang.Name = "textBoxNamaBarang";
            this.textBoxNamaBarang.Size = new System.Drawing.Size(181, 20);
            this.textBoxNamaBarang.TabIndex = 11;
            // 
            // textBoxHargaJual
            // 
            this.textBoxHargaJual.Location = new System.Drawing.Point(117, 157);
            this.textBoxHargaJual.Name = "textBoxHargaJual";
            this.textBoxHargaJual.Size = new System.Drawing.Size(181, 20);
            this.textBoxHargaJual.TabIndex = 12;
            // 
            // textBoxStok
            // 
            this.textBoxStok.Location = new System.Drawing.Point(117, 190);
            this.textBoxStok.Name = "textBoxStok";
            this.textBoxStok.Size = new System.Drawing.Size(181, 20);
            this.textBoxStok.TabIndex = 13;
            // 
            // FormUbahBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 404);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.labelJudul);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonkosong);
            this.Controls.Add(this.buttonUbah);
            this.Name = "FormUbahBarang";
            this.Text = "FormUbahBarang";
            this.Load += new System.EventHandler(this.FormUbahBarang_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.TextBox textBoxStok;
        private System.Windows.Forms.TextBox textBoxHargaJual;
        private System.Windows.Forms.TextBox textBoxNamaBarang;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKategoriBarang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKodeBarang;
        private System.Windows.Forms.Label labelBerdasarkan;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonkosong;
        private System.Windows.Forms.Button buttonUbah;
    }
}