namespace Wisnu_SistemJualBeli
{
    partial class FormUbahPegawai
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
            this.textBoxKode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxJabatan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGaji = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerInfo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.labelBerdasarkan = new System.Windows.Forms.Label();
            this.labelJudul = new System.Windows.Forms.Label();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKeluar.Location = new System.Drawing.Point(527, 460);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(125, 38);
            this.buttonKeluar.TabIndex = 34;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonkosong
            // 
            this.buttonkosong.BackColor = System.Drawing.Color.Navy;
            this.buttonkosong.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonkosong.Location = new System.Drawing.Point(175, 460);
            this.buttonkosong.Margin = new System.Windows.Forms.Padding(4);
            this.buttonkosong.Name = "buttonkosong";
            this.buttonkosong.Size = new System.Drawing.Size(125, 38);
            this.buttonkosong.TabIndex = 33;
            this.buttonkosong.Text = "KOSONGI";
            this.buttonkosong.UseVisualStyleBackColor = false;
            this.buttonkosong.Click += new System.EventHandler(this.buttonkosong_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.Navy;
            this.buttonTambah.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTambah.Location = new System.Drawing.Point(42, 460);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(125, 38);
            this.buttonTambah.TabIndex = 32;
            this.buttonTambah.Text = "TAMBAH";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelInfo.Controls.Add(this.textBoxKode);
            this.panelInfo.Controls.Add(this.label7);
            this.panelInfo.Controls.Add(this.comboBoxJabatan);
            this.panelInfo.Controls.Add(this.label6);
            this.panelInfo.Controls.Add(this.textBoxPassword);
            this.panelInfo.Controls.Add(this.label5);
            this.panelInfo.Controls.Add(this.textBoxUsername);
            this.panelInfo.Controls.Add(this.label4);
            this.panelInfo.Controls.Add(this.textBoxGaji);
            this.panelInfo.Controls.Add(this.label3);
            this.panelInfo.Controls.Add(this.textBoxAlamat);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.dateTimePickerInfo);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.textBoxNama);
            this.panelInfo.Controls.Add(this.labelBerdasarkan);
            this.panelInfo.Location = new System.Drawing.Point(13, 78);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(4);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(679, 374);
            this.panelInfo.TabIndex = 31;
            // 
            // textBoxKode
            // 
            this.textBoxKode.Location = new System.Drawing.Point(156, 4);
            this.textBoxKode.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKode.Name = "textBoxKode";
            this.textBoxKode.Size = new System.Drawing.Size(240, 22);
            this.textBoxKode.TabIndex = 17;
            this.textBoxKode.TextChanged += new System.EventHandler(this.textBoxKode_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Kode";
            // 
            // comboBoxJabatan
            // 
            this.comboBoxJabatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxJabatan.FormattingEnabled = true;
            this.comboBoxJabatan.Location = new System.Drawing.Point(156, 325);
            this.comboBoxJabatan.Name = "comboBoxJabatan";
            this.comboBoxJabatan.Size = new System.Drawing.Size(240, 24);
            this.comboBoxJabatan.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 328);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Jabatan";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(156, 274);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(240, 22);
            this.textBoxPassword.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(156, 226);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(240, 22);
            this.textBoxUsername.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Username";
            // 
            // textBoxGaji
            // 
            this.textBoxGaji.Location = new System.Drawing.Point(156, 177);
            this.textBoxGaji.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGaji.Name = "textBoxGaji";
            this.textBoxGaji.Size = new System.Drawing.Size(240, 22);
            this.textBoxGaji.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Gaji";
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(156, 127);
            this.textBoxAlamat.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(240, 22);
            this.textBoxAlamat.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Alamat";
            // 
            // dateTimePickerInfo
            // 
            this.dateTimePickerInfo.Location = new System.Drawing.Point(156, 82);
            this.dateTimePickerInfo.Name = "dateTimePickerInfo";
            this.dateTimePickerInfo.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerInfo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tanggal Lahir";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(156, 43);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(240, 22);
            this.textBoxNama.TabIndex = 2;
            // 
            // labelBerdasarkan
            // 
            this.labelBerdasarkan.AutoSize = true;
            this.labelBerdasarkan.Location = new System.Drawing.Point(16, 46);
            this.labelBerdasarkan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBerdasarkan.Name = "labelBerdasarkan";
            this.labelBerdasarkan.Size = new System.Drawing.Size(45, 17);
            this.labelBerdasarkan.TabIndex = 0;
            this.labelBerdasarkan.Text = "Nama";
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
            this.labelJudul.TabIndex = 30;
            this.labelJudul.Text = "UBAH PEGAWAI";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormUbahPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 513);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonkosong);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.labelJudul);
            this.Name = "FormUbahPegawai";
            this.Text = "FormUbahPegawai";
            this.Load += new System.EventHandler(this.FormUbahPegawai_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonkosong;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.TextBox textBoxKode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxJabatan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxGaji;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAlamat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label labelBerdasarkan;
        private System.Windows.Forms.Label labelJudul;
    }
}