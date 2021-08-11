namespace Wisnu_SistemJualBeli
{
    partial class FormDaftarKategori
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
            this.labelBerdasarkan = new System.Windows.Forms.Label();
            this.comboBoxBerdasarkan = new System.Windows.Forms.ComboBox();
            this.labelJudul = new System.Windows.Forms.Label();
            this.textBoxBerdasarkan = new System.Windows.Forms.TextBox();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBerdasarkan
            // 
            this.labelBerdasarkan.AutoSize = true;
            this.labelBerdasarkan.Location = new System.Drawing.Point(12, 32);
            this.labelBerdasarkan.Name = "labelBerdasarkan";
            this.labelBerdasarkan.Size = new System.Drawing.Size(73, 13);
            this.labelBerdasarkan.TabIndex = 0;
            this.labelBerdasarkan.Text = "Berdasarkan :";
            // 
            // comboBoxBerdasarkan
            // 
            this.comboBoxBerdasarkan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBerdasarkan.FormattingEnabled = true;
            this.comboBoxBerdasarkan.Items.AddRange(new object[] {
            "Kode Kategori",
            "Nama Kategori"});
            this.comboBoxBerdasarkan.Location = new System.Drawing.Point(91, 29);
            this.comboBoxBerdasarkan.Name = "comboBoxBerdasarkan";
            this.comboBoxBerdasarkan.Size = new System.Drawing.Size(145, 21);
            this.comboBoxBerdasarkan.TabIndex = 1;
            // 
            // labelJudul
            // 
            this.labelJudul.BackColor = System.Drawing.Color.Navy;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelJudul.Location = new System.Drawing.Point(12, 22);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(509, 53);
            this.labelJudul.TabIndex = 3;
            this.labelJudul.Text = "DAFTAR KATEGORI BARANG";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxBerdasarkan
            // 
            this.textBoxBerdasarkan.Location = new System.Drawing.Point(286, 29);
            this.textBoxBerdasarkan.Name = "textBoxBerdasarkan";
            this.textBoxBerdasarkan.Size = new System.Drawing.Size(181, 20);
            this.textBoxBerdasarkan.TabIndex = 2;
            this.textBoxBerdasarkan.TextChanged += new System.EventHandler(this.textBoxBerdasarkan_TextChanged);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelInfo.Controls.Add(this.textBoxBerdasarkan);
            this.panelInfo.Controls.Add(this.labelBerdasarkan);
            this.panelInfo.Controls.Add(this.comboBoxBerdasarkan);
            this.panelInfo.Location = new System.Drawing.Point(12, 78);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(509, 78);
            this.panelInfo.TabIndex = 4;
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Location = new System.Drawing.Point(12, 180);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.Size = new System.Drawing.Size(509, 176);
            this.dataGridViewInfo.TabIndex = 5;
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.Navy;
            this.buttonTambah.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTambah.Location = new System.Drawing.Point(38, 378);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(94, 31);
            this.buttonTambah.TabIndex = 6;
            this.buttonTambah.Text = "TAMBAH";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonUbah
            // 
            this.buttonUbah.BackColor = System.Drawing.Color.Navy;
            this.buttonUbah.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUbah.Location = new System.Drawing.Point(138, 378);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(94, 31);
            this.buttonUbah.TabIndex = 7;
            this.buttonUbah.Text = "UBAH";
            this.buttonUbah.UseVisualStyleBackColor = false;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.BackColor = System.Drawing.Color.Navy;
            this.buttonHapus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHapus.Location = new System.Drawing.Point(247, 378);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(94, 31);
            this.buttonHapus.TabIndex = 8;
            this.buttonHapus.Text = "HAPUS";
            this.buttonHapus.UseVisualStyleBackColor = false;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKeluar.Location = new System.Drawing.Point(402, 378);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(94, 31);
            this.buttonKeluar.TabIndex = 9;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // FormDaftarKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 437);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGridViewInfo);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.labelJudul);
            this.Name = "FormDaftarKategori";
            this.Text = "Daftar Kategori";
            this.Load += new System.EventHandler(this.FormDaftarKategori_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBerdasarkan;
        private System.Windows.Forms.ComboBox comboBoxBerdasarkan;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.TextBox textBoxBerdasarkan;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonKeluar;
    }
}

