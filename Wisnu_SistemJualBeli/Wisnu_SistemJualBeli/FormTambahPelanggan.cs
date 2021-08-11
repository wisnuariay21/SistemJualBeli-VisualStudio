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
    public partial class FormTambahPelanggan : Form
    {
        public FormTambahPelanggan()
        {
            InitializeComponent();
        }

        private void buttonkosong_Click(object sender, EventArgs e)
        {
            textBoxKode.Text = "";
            textBoxNamaPelanggan.Text = "";
            textBoxalamat.Text = "";
            textBoxTelepon.Text = "";
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            Pelanggan pelagn = new Pelanggan(int.Parse(textBoxKode.Text), textBoxNamaPelanggan.Text, textBoxalamat.Text, textBoxTelepon.Text);
            
            string hasil = Pelanggan.TambahData(pelagn);

            if (hasil == "1")
            {
                MessageBox.Show("pelanggan telah tersimpan.", "Informasi");
                textBoxKode.Text = "";
                textBoxNamaPelanggan.Text = "";
                textBoxTelepon.Text = "";
                textBoxalamat.Text = "";
                textBoxKode.Focus();
            }
            else
            {
                MessageBox.Show("Gagal menambah pelanggan. Pesan kesalahan : " + hasil);
            }

        }
    }
}
