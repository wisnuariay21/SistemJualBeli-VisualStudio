namespace Wisnu_SistemJualBeli
{
    partial class FormTambahPelanggan
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
            this.textBoxNamaPelanggan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKode = new System.Windows.Forms.TextBox();
            this.labelBerdasarkan = new System.Windows.Forms.Label();
            this.labelJudul = new System.Windows.Forms.Label();
            this.textBoxalamat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTelepon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKeluar.Location = new System.Drawing.Point(536, 307);
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
            this.buttonkosong.Location = new System.Drawing.Point(184, 307);
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
            this.buttonTambah.Location = new System.Drawing.Point(51, 307);
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
            this.panelInfo.Controls.Add(this.textBoxTelepon);
            this.panelInfo.Controls.Add(this.label3);
            this.panelInfo.Controls.Add(this.textBoxalamat);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.textBoxNamaPelanggan);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.textBoxKode);
            this.panelInfo.Controls.Add(this.labelBerdasarkan);
            this.panelInfo.Location = new System.Drawing.Point(13, 78);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(4);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(679, 196);
            this.panelInfo.TabIndex = 26;
            // 
            // textBoxNamaPelanggan
            // 
            this.textBoxNamaPelanggan.Location = new System.Drawing.Point(156, 64);
            this.textBoxNamaPelanggan.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNamaPelanggan.Name = "textBoxNamaPelanggan";
            this.textBoxNamaPelanggan.Size = new System.Drawing.Size(240, 22);
            this.textBoxNamaPelanggan.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama Pelanggan";
            // 
            // textBoxKode
            // 
            this.textBoxKode.Location = new System.Drawing.Point(156, 20);
            this.textBoxKode.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKode.Name = "textBoxKode";
            this.textBoxKode.Size = new System.Drawing.Size(240, 22);
            this.textBoxKode.TabIndex = 2;
            // 
            // labelBerdasarkan
            // 
            this.labelBerdasarkan.AutoSize = true;
            this.labelBerdasarkan.Location = new System.Drawing.Point(16, 23);
            this.labelBerdasarkan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBerdasarkan.Name = "labelBerdasarkan";
            this.labelBerdasarkan.Size = new System.Drawing.Size(121, 17);
            this.labelBerdasarkan.TabIndex = 0;
            this.labelBerdasarkan.Text = "Kode Pelanggan :";
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
            this.labelJudul.Text = "TAMBAH PELANGGAN";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxalamat
            // 
            this.textBoxalamat.Location = new System.Drawing.Point(156, 106);
            this.textBoxalamat.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxalamat.Name = "textBoxalamat";
            this.textBoxalamat.Size = new System.Drawing.Size(240, 22);
            this.textBoxalamat.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Alamat Pelanggan";
            // 
            // textBoxTelepon
            // 
            this.textBoxTelepon.Location = new System.Drawing.Point(156, 149);
            this.textBoxTelepon.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTelepon.Name = "textBoxTelepon";
            this.textBoxTelepon.Size = new System.Drawing.Size(240, 22);
            this.textBoxTelepon.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telepon";
            // 
            // FormTambahPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 362);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonkosong);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.labelJudul);
            this.Name = "FormTambahPelanggan";
            this.Text = "FormTambahPelanggan";
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonkosong;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.TextBox textBoxNamaPelanggan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKode;
        private System.Windows.Forms.Label labelBerdasarkan;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.TextBox textBoxTelepon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxalamat;
        private System.Windows.Forms.Label label1;
    }
}