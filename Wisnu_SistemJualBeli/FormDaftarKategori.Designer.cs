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
            this.comboBoxKriteria = new System.Windows.Forms.ComboBox();
            this.labelJudul = new System.Windows.Forms.Label();
            this.textBoxkriteria = new System.Windows.Forms.TextBox();
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
            this.labelBerdasarkan.Location = new System.Drawing.Point(16, 39);
            this.labelBerdasarkan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBerdasarkan.Name = "labelBerdasarkan";
            this.labelBerdasarkan.Size = new System.Drawing.Size(97, 17);
            this.labelBerdasarkan.TabIndex = 0;
            this.labelBerdasarkan.Text = "Berdasarkan :";
            // 
            // comboBoxKriteria
            // 
            this.comboBoxKriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKriteria.FormattingEnabled = true;
            this.comboBoxKriteria.Items.AddRange(new object[] {
            "Kode Kategori",
            "Nama"});
            this.comboBoxKriteria.Location = new System.Drawing.Point(121, 36);
            this.comboBoxKriteria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxKriteria.Name = "comboBoxKriteria";
            this.comboBoxKriteria.Size = new System.Drawing.Size(192, 24);
            this.comboBoxKriteria.TabIndex = 1;
            // 
            // labelJudul
            // 
            this.labelJudul.BackColor = System.Drawing.Color.Navy;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelJudul.Location = new System.Drawing.Point(16, 27);
            this.labelJudul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(679, 65);
            this.labelJudul.TabIndex = 3;
            this.labelJudul.Text = "DAFTAR KATEGORI BARANG";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxkriteria
            // 
            this.textBoxkriteria.Location = new System.Drawing.Point(381, 36);
            this.textBoxkriteria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxkriteria.Name = "textBoxkriteria";
            this.textBoxkriteria.Size = new System.Drawing.Size(240, 22);
            this.textBoxkriteria.TabIndex = 2;
            this.textBoxkriteria.TextChanged += new System.EventHandler(this.textBoxkriteria_TextChanged);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelInfo.Controls.Add(this.textBoxkriteria);
            this.panelInfo.Controls.Add(this.labelBerdasarkan);
            this.panelInfo.Controls.Add(this.comboBoxKriteria);
            this.panelInfo.Location = new System.Drawing.Point(16, 96);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(679, 96);
            this.panelInfo.TabIndex = 4;
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Location = new System.Drawing.Point(16, 200);
            this.dataGridViewInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.Size = new System.Drawing.Size(679, 239);
            this.dataGridViewInfo.TabIndex = 5;
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.Navy;
            this.buttonTambah.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTambah.Location = new System.Drawing.Point(51, 465);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(125, 38);
            this.buttonTambah.TabIndex = 6;
            this.buttonTambah.Text = "TAMBAH";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonUbah
            // 
            this.buttonUbah.BackColor = System.Drawing.Color.Navy;
            this.buttonUbah.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUbah.Location = new System.Drawing.Point(184, 465);
            this.buttonUbah.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(125, 38);
            this.buttonUbah.TabIndex = 7;
            this.buttonUbah.Text = "UBAH";
            this.buttonUbah.UseVisualStyleBackColor = false;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.BackColor = System.Drawing.Color.Navy;
            this.buttonHapus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHapus.Location = new System.Drawing.Point(329, 465);
            this.buttonHapus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(125, 38);
            this.buttonHapus.TabIndex = 8;
            this.buttonHapus.Text = "HAPUS";
            this.buttonHapus.UseVisualStyleBackColor = false;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKeluar.Location = new System.Drawing.Point(536, 465);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(125, 38);
            this.buttonKeluar.TabIndex = 9;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // FormDaftarKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 538);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGridViewInfo);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.labelJudul);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.ComboBox comboBoxKriteria;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.TextBox textBoxkriteria;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonKeluar;
    }
}

