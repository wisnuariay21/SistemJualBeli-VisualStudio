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
        List<Kategori> listkategori = new List<Kategori>();
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
                    textBoxKodeKategori.Text = "";
                    textBoxNamaKategori.Text = "";
                    textBoxKodeKategori.Focus();
                }
                else
                {
                    MessageBox.Show("Gagal menghapus kategori. Pesan kesalahan : " + hasil);
                    textBoxKodeKategori.Text = "";
                    textBoxNamaKategori.Text = "";
                    textBoxKodeKategori.Focus();
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

        private void textBoxKodeKategori_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKodeKategori.Text.Length == textBoxKodeKategori.MaxLength)
            {
                string hasil = Kategori.BacaData("KodeKategori", textBoxKodeKategori.Text, listkategori);
                if (hasil == "1")
                {
                    if (listkategori.Count > 0)
                    {
                        textBoxNamaKategori.Text = listkategori[0].Nama;
                        textBoxNamaKategori.Enabled = false;

                    }
                    else
                    {
                        MessageBox.Show("Kode tidak ditemukan");
                        textBoxNamaKategori.Text = "";
                        textBoxKodeKategori.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("data gagal dihapus. Pesan kesalahan = " + hasil);
                    textBoxKodeKategori.Text = "";
                    textBoxNamaKategori.Text = "";
                    textBoxKodeKategori.Focus();
                }
            }
        }
    }
}
