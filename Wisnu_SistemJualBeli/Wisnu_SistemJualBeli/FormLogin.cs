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
        List<Pegawai> listPegawai = new List<Pegawai>();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.Height = 215;
            textBoxServer.Text = "localhost";
            textBoxDatabase.Text = "dbjualbeli_isi";
            textBoxPassword.PasswordChar = '*';
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
                string hasilBaca = Pegawai.BacaData("P.username", textBoxUsername.Text, listPegawai);
                if(hasilBaca == "1")
                {
                    if(listPegawai.Count > 0)
                    {
                        FormMenu frmenu = (FormMenu)this.Owner;
                        frmenu.LabelKode.Text = listPegawai[0].KodePegawai.ToString();
                        frmenu.labelNama.Text = listPegawai[0].Nama;
                        frmenu.labelJabatan.Text = listPegawai[0].Jabatan.NamaJabatan;
                    }
                }
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
