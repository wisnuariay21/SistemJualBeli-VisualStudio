namespace Wisnu_SistemJualBeli
{
    partial class FormLogin
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPengaturan = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panelPengaturan = new System.Windows.Forms.Panel();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.textBoxDatabase = new System.Windows.Forms.TextBox();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.labelDatabase = new System.Windows.Forms.Label();
            this.labelServer = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.panelPengaturan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelLogin.Controls.Add(this.buttonKeluar);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.textBoxUsername);
            this.panelLogin.Controls.Add(this.labelPengaturan);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Controls.Add(this.labelUsername);
            this.panelLogin.Location = new System.Drawing.Point(9, 10);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(382, 162);
            this.panelLogin.TabIndex = 0;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.Blue;
            this.buttonKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKeluar.Location = new System.Drawing.Point(260, 98);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(100, 31);
            this.buttonKeluar.TabIndex = 6;
            this.buttonKeluar.Text = "KELUAR";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Blue;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogin.Location = new System.Drawing.Point(125, 98);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 31);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(106, 61);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(254, 20);
            this.textBoxPassword.TabIndex = 4;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(106, 23);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(254, 20);
            this.textBoxUsername.TabIndex = 3;
            // 
            // labelPengaturan
            // 
            this.labelPengaturan.AutoSize = true;
            this.labelPengaturan.ForeColor = System.Drawing.Color.Blue;
            this.labelPengaturan.Location = new System.Drawing.Point(18, 126);
            this.labelPengaturan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPengaturan.Name = "labelPengaturan";
            this.labelPengaturan.Size = new System.Drawing.Size(94, 13);
            this.labelPengaturan.TabIndex = 2;
            this.labelPengaturan.Text = "Pengaturan Lanjut";
            this.labelPengaturan.Click += new System.EventHandler(this.labelPengaturan_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(16, 58);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(86, 20);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password :";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(16, 20);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(91, 20);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username :";
            // 
            // panelPengaturan
            // 
            this.panelPengaturan.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelPengaturan.Controls.Add(this.buttonSimpan);
            this.panelPengaturan.Controls.Add(this.textBoxDatabase);
            this.panelPengaturan.Controls.Add(this.textBoxServer);
            this.panelPengaturan.Controls.Add(this.labelDatabase);
            this.panelPengaturan.Controls.Add(this.labelServer);
            this.panelPengaturan.Location = new System.Drawing.Point(9, 177);
            this.panelPengaturan.Margin = new System.Windows.Forms.Padding(2);
            this.panelPengaturan.Name = "panelPengaturan";
            this.panelPengaturan.Size = new System.Drawing.Size(382, 142);
            this.panelPengaturan.TabIndex = 1;
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.BackColor = System.Drawing.Color.Blue;
            this.buttonSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSimpan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSimpan.Location = new System.Drawing.Point(125, 93);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(100, 31);
            this.buttonSimpan.TabIndex = 7;
            this.buttonSimpan.Text = "SIMPAN";
            this.buttonSimpan.UseVisualStyleBackColor = false;
            // 
            // textBoxDatabase
            // 
            this.textBoxDatabase.Location = new System.Drawing.Point(106, 61);
            this.textBoxDatabase.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDatabase.Name = "textBoxDatabase";
            this.textBoxDatabase.Size = new System.Drawing.Size(254, 20);
            this.textBoxDatabase.TabIndex = 6;
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(106, 23);
            this.textBoxServer.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(254, 20);
            this.textBoxServer.TabIndex = 5;
            // 
            // labelDatabase
            // 
            this.labelDatabase.AutoSize = true;
            this.labelDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatabase.Location = new System.Drawing.Point(16, 58);
            this.labelDatabase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Size = new System.Drawing.Size(87, 20);
            this.labelDatabase.TabIndex = 1;
            this.labelDatabase.Text = "Database :";
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServer.Location = new System.Drawing.Point(16, 20);
            this.labelServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(63, 20);
            this.labelServer.TabIndex = 0;
            this.labelServer.Text = "Server :";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 327);
            this.Controls.Add(this.panelPengaturan);
            this.Controls.Add(this.panelLogin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelPengaturan.ResumeLayout(false);
            this.panelPengaturan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPengaturan;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panelPengaturan;
        private System.Windows.Forms.Button buttonSimpan;
        private System.Windows.Forms.TextBox textBoxDatabase;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Label labelDatabase;
        private System.Windows.Forms.Label labelServer;
    }
}