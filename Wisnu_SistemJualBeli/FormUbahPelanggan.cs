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
    public partial class FormUbahPelanggan : Form
    {
        public FormUbahPelanggan()
        {
            InitializeComponent();
        }
        List<Pelanggan> listpelanggan = new List<Pelanggan>();
        private void buttonUbah_Click(object sender, EventArgs e)
        {
            Pelanggan pelagn = new Pelanggan(int.Parse(textBoxKodePelanggan.Text), textBoxNamaPelanggan.Text, textBoxAlamat.Text, textBoxTelepon.Text);
            
            string hasil = Pelanggan.UbahData(pelagn);

            if (hasil == "1")
            {
                MessageBox.Show("Pelanggan telah diubah.", "Informasi");
                textBoxKodePelanggan.Text = "";
                textBoxNamaPelanggan.Text = "";
                textBoxAlamat.Text = "";
                textBoxTelepon.Text = "";
                textBoxKodePelanggan.Focus();
            }
            else
            {
                MessageBox.Show("Gagal mengubah pelanggan. Pesan kesalahan : " + hasil);
            }
        }

        private void FormUbahPelanggan_Load(object sender, EventArgs e)
        {
            textBoxKodePelanggan.MaxLength = 2;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonkosong_Click(object sender, EventArgs e)
        {
            textBoxKodePelanggan.Text = "";
            textBoxNamaPelanggan.Text = "";
            textBoxAlamat.Text = "";
            textBoxTelepon.Text = "";
        }

        private void textBoxKodePelanggan_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKodePelanggan.Text.Length <= textBoxKodePelanggan.MaxLength)
            {
                listpelanggan.Clear();
                string hasilbaca = Pelanggan.BacaData("KodePelanggan", textBoxKodePelanggan.Text, listpelanggan);
                if (hasilbaca == "1")
                {
                    if (listpelanggan.Count > 0)
                    {
                        textBoxNamaPelanggan.Text = listpelanggan[0].Nama;
                        textBoxAlamat.Text = listpelanggan[0].Alamat;
                        textBoxTelepon.Text = listpelanggan[0].Telepon;
                        textBoxNamaPelanggan.Focus();
                        textBoxAlamat.Focus();
                        textBoxTelepon.Focus();
                    }
                    else
                    {
                        MessageBox.Show(" Kode Pelanggan tidak ditemukan. proses Ubah Data tidak bisa dilakukan.");
                        textBoxNamaPelanggan.Text = "";
                        textBoxTelepon.Text = "";
                        textBoxAlamat.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show(" perintah sql gagal di jalankan. pesan kesalahan = " + hasilbaca);
                }
            }
        }
    }
}
