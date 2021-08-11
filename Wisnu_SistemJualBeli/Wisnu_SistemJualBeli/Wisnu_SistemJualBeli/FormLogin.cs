using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JualBeliClass;

namespace Wisnu_SistemJualBeli
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.Height = 215;
            textBoxServer.Text = "localhost";
            textBoxDatabase.Text = "dbjualbeli_isi";
        }

        private void labelPengaturan_Click(object sender, EventArgs e)
        {
            this.Height = 360;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            ClassKoneksi koneksi = new ClassKoneksi(textBoxServer.Text, textBoxDatabase.Text, textBoxUsername.Text, textBoxPassword.Text);

            string hasilConnect = koneksi.Connect();
            if (hasilConnect == "1")
            {
                MessageBox.Show("Koneksi Berhasil YEAYYY, Selamat Menggunakan Aplikasi Kami");
                this.Owner.Enabled = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("CIEE GABISA LOGIN, SELAMAT YA : " + hasilConnect);
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
