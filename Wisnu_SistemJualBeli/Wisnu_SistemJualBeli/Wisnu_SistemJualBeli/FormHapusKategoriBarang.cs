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
    public partial class FormHapusKategoriBarang : Form
    {
        public FormHapusKategoriBarang()
        {
            InitializeComponent();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show("Data Kategori akan dihapus. Apakah anda yakin ? ", "Konfirmasi", MessageBoxButtons.YesNo);
            if(konfirmasi == System.Windows.Forms.DialogResult.Yes)
            {
                Kategori katgor = new Kategori(textBoxKodeKategori.Text, textBoxNamaKategori.Text);
                string hasil = Kategori.HapusData(katgor);

                if(hasil == "1")
                {
                    MessageBox.Show("Kategori telah dihapus.", "Informasi");
                }
                else
                {
                    MessageBox.Show("Gagal menghapus kategori. Pesan kesalahan : " + hasil);
                }
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonkosong_Click(object sender, EventArgs e)
        {
            textBoxKodeKategori.Text = "";
            textBoxNamaKategori.Text = "";
        }
    }
}
