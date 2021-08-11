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
    public partial class FormHapusJabatan : Form
    {
        List<Jabatan> listJabatan = new List<Jabatan>();
        public FormHapusJabatan()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonkosong_Click(object sender, EventArgs e)
        {
            textBoxId.Text = "";
            textBoxNamaJabatan.Text = "";
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Jabatan jabat = new Jabatan();
                jabat.IdJabatan = textBoxId.Text;
                jabat.NamaJabatan = textBoxNamaJabatan.Text;
                string hasil = Jabatan.HapusData(jabat);

                if (hasil == "1")
                {
                    MessageBox.Show("Data telah terhapus");
                    textBoxId.Text = "";
                    textBoxNamaJabatan.Text = "";
                }
                else
                {
                    MessageBox.Show("Data gagal terhapus " + hasil);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            if (textBoxId.Text.Length == textBoxId.MaxLength)
            {
                string hasilbaca = Jabatan.BacaData("IdJabatan", textBoxId.Text, listJabatan);
                if (hasilbaca == "1")
                {
                    if (listJabatan.Count > 0)
                    {
                        textBoxId.Text = listJabatan[0].IdJabatan;
                        textBoxId.Focus();
                    }
                    else
                    {
                        MessageBox.Show(" kode kategori tidak ditemukan. proses Ubah Data tidak bisa dilakukan.");
                        textBoxId.Text = "";
                        textBoxId.Focus();
                    }
                }
                else
                {
                    MessageBox.Show(" Data gagal diubah. pesan kesalahan = " + hasilbaca);
                    textBoxId.Text = "";
                    textBoxNamaJabatan.Text = "";
                    textBoxId.Focus();
                }
            }
        }
    }
}
