namespace Wisnu_SistemJualBeli
{
    partial class FormDaftarBarang
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
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.textBoxkriteria = new System.Windows.Forms.TextBox();
            this.labelBerdasarkan = new System.Windows.Forms.Label();
            this.comboBoxKriteria = new System.Windows.Forms.ComboBox();
            this.labelJudul = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKeluar.Location = new System.Drawing.Point(400, 363);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(94, 31);
            this.buttonKeluar.TabIndex = 16;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            // 
            // buttonHapus
            // 
            this.buttonHapus.BackColor = System.Drawing.Color.Navy;
            this.buttonHapus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHapus.Location = new System.Drawing.Point(244, 363);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(94, 31);
            this.buttonHapus.TabIndex = 15;
            this.buttonHapus.Text = "HAPUS";
            this.buttonHapus.UseVisualStyleBackColor = false;
            // 
            // buttonUbah
            // 
            this.buttonUbah.BackColor = System.Drawing.Color.Navy;
            this.buttonUbah.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonUbah.Location = new System.Drawing.Point(136, 363);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(94, 31);
            this.buttonUbah.TabIndex = 14;
            this.buttonUbah.Text = "UBAH";
            this.buttonUbah.UseVisualStyleBackColor = false;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.Navy;
            this.buttonTambah.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTambah.Location = new System.Drawing.Point(36, 363);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(94, 31);
            this.buttonTambah.TabIndex = 13;
            this.buttonTambah.Text = "TAMBAH";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Location = new System.Drawing.Point(10, 148);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.Size = new System.Drawing.Size(509, 194);
            this.dataGridViewInfo.TabIndex = 12;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelInfo.Controls.Add(this.textBoxkriteria);
            this.panelInfo.Controls.Add(this.labelBerdasarkan);
            this.panelInfo.Controls.Add(this.comboBoxKriteria);
            this.panelInfo.Location = new System.Drawing.Point(10, 63);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(509, 78);
            this.panelInfo.TabIndex = 11;
            // 
            // textBoxkriteria
            // 
            this.textBoxkriteria.Location = new System.Drawing.Point(286, 29);
            this.textBoxkriteria.Name = "textBoxkriteria";
            this.textBoxkriteria.Size = new System.Drawing.Size(181, 20);
            this.textBoxkriteria.TabIndex = 2;
            this.textBoxkriteria.TextChanged += new System.EventHandler(this.textBoxkriteria_TextChanged);
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
            // comboBoxKriteria
            // 
            this.comboBoxKriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKriteria.FormattingEnabled = true;
            this.comboBoxKriteria.Items.AddRange(new object[] {
            "Kode Kategori",
            "Nama"});
            this.comboBoxKriteria.Location = new System.Drawing.Point(91, 29);
            this.comboBoxKriteria.Name = "comboBoxKriteria";
            this.comboBoxKriteria.Size = new System.Drawing.Size(145, 21);
            this.comboBoxKriteria.TabIndex = 1;
            this.comboBoxKriteria.SelectedIndexChanged += new System.EventHandler(this.comboBoxKriteria_SelectedIndexChanged);
            // 
            // labelJudul
            // 
            this.labelJudul.BackColor = System.Drawing.Color.Navy;
            this.labelJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelJudul.Location = new System.Drawing.Point(10, 7);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(509, 53);
            this.labelJudul.TabIndex = 10;
            this.labelJudul.Text = "DAFTAR KATEGORI BARANG";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDaftarBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 406);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGridViewInfo);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.labelJudul);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDaftarBarang";
            this.Text = "FormDaftarBarang";
            this.Load += new System.EventHandler(this.FormDaftarBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.TextBox textBoxkriteria;
        private System.Windows.Forms.Label labelBerdasarkan;
        private System.Windows.Forms.ComboBox comboBoxKriteria;
        private System.Windows.Forms.Label labelJudul;
    }
}