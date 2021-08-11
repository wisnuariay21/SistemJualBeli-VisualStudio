namespace Wisnu_SistemJualBeli
{
    partial class Formpelanggan
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
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.buttonCari = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.panelInfo.SuspendLayout();
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
            this.labelJudul.Location = new System.Drawing.Point(12, 9);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(509, 53);
            this.labelJudul.TabIndex = 10;
            this.labelJudul.Text = "DAFTAR PELANGGAN";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxBerdasarkan
            // 
            this.textBoxBerdasarkan.Location = new System.Drawing.Point(242, 29);
            this.textBoxBerdasarkan.Name = "textBoxBerdasarkan";
            this.textBoxBerdasarkan.Size = new System.Drawing.Size(144, 20);
            this.textBoxBerdasarkan.TabIndex = 2;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKeluar.Location = new System.Drawing.Point(402, 365);
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
            this.buttonHapus.Location = new System.Drawing.Point(247, 365);
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
            this.buttonUbah.Location = new System.Drawing.Point(138, 365);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(94, 31);
            this.buttonUbah.TabIndex = 14;
            this.buttonUbah.Text = "UBAH";
            this.buttonUbah.UseVisualStyleBackColor = false;
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.Navy;
            this.buttonTambah.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTambah.Location = new System.Drawing.Point(38, 365);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(94, 31);
            this.buttonTambah.TabIndex = 13;
            this.buttonTambah.Text = "TAMBAH";
            this.buttonTambah.UseVisualStyleBackColor = false;
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Location = new System.Drawing.Point(12, 167);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.Size = new System.Drawing.Size(509, 176);
            this.dataGridViewInfo.TabIndex = 12;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelInfo.Controls.Add(this.buttonCari);
            this.panelInfo.Controls.Add(this.textBoxBerdasarkan);
            this.panelInfo.Controls.Add(this.labelBerdasarkan);
            this.panelInfo.Controls.Add(this.comboBoxBerdasarkan);
            this.panelInfo.Location = new System.Drawing.Point(12, 65);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(509, 78);
            this.panelInfo.TabIndex = 11;
            // 
            // buttonCari
            // 
            this.buttonCari.BackColor = System.Drawing.Color.Navy;
            this.buttonCari.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCari.Location = new System.Drawing.Point(392, 23);
            this.buttonCari.Name = "buttonCari";
            this.buttonCari.Size = new System.Drawing.Size(94, 31);
            this.buttonCari.TabIndex = 17;
            this.buttonCari.Text = "CARI";
            this.buttonCari.UseVisualStyleBackColor = false;
            // 
            // Formpelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 415);
            this.Controls.Add(this.labelJudul);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.dataGridViewInfo);
            this.Controls.Add(this.panelInfo);
            this.Name = "Formpelanggan";
            this.Text = "Formpelanggan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBerdasarkan;
        private System.Windows.Forms.ComboBox comboBoxBerdasarkan;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.TextBox textBoxBerdasarkan;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonHapus;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Button buttonCari;
    }
}