namespace Wisnu_SistemJualBeli
{
    partial class FormHapusJabatan
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
            this.textBoxNamaJabatan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelBerdasarkan = new System.Windows.Forms.Label();
            this.labelJudul = new System.Windows.Forms.Label();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Navy;
            this.buttonKeluar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKeluar.Location = new System.Drawing.Point(566, 244);
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
            this.buttonkosong.Location = new System.Drawing.Point(214, 244);
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
            this.buttonTambah.Location = new System.Drawing.Point(81, 244);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(125, 38);
            this.buttonTambah.TabIndex = 32;
            this.buttonTambah.Text = "HAPUS";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelInfo.Controls.Add(this.textBoxNamaJabatan);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.textBoxId);
            this.panelInfo.Controls.Add(this.labelBerdasarkan);
            this.panelInfo.Location = new System.Drawing.Point(13, 78);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(4);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(679, 145);
            this.panelInfo.TabIndex = 31;
            // 
            // textBoxNamaJabatan
            // 
            this.textBoxNamaJabatan.Location = new System.Drawing.Point(156, 80);
            this.textBoxNamaJabatan.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNamaJabatan.Name = "textBoxNamaJabatan";
            this.textBoxNamaJabatan.Size = new System.Drawing.Size(240, 22);
            this.textBoxNamaJabatan.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama Jabatan";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(156, 36);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(240, 22);
            this.textBoxId.TabIndex = 2;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            // 
            // labelBerdasarkan
            // 
            this.labelBerdasarkan.AutoSize = true;
            this.labelBerdasarkan.Location = new System.Drawing.Point(16, 39);
            this.labelBerdasarkan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBerdasarkan.Name = "labelBerdasarkan";
            this.labelBerdasarkan.Size = new System.Drawing.Size(82, 17);
            this.labelBerdasarkan.TabIndex = 0;
            this.labelBerdasarkan.Text = "Id Jabatan :";
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
            this.labelJudul.Text = "HAPUS JABATAN";
            this.labelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormHapusJabatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 295);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.buttonkosong);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.labelJudul);
            this.Name = "FormHapusJabatan";
            this.Text = "FormHapusJabatan";
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonkosong;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.TextBox textBoxNamaJabatan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelBerdasarkan;
        private System.Windows.Forms.Label labelJudul;
    }
}