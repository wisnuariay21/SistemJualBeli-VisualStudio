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
    public partial class FormHapusPelanggan : Form
    {
        public FormHapusPelanggan()
        {
            InitializeComponent();
        }
        List<Pelanggan> listpelanggan = new List<Pelanggan>();
        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonkosong_Click(object sender, EventArgs e)
        {
            textBoxKode.Text = "";
            textBoxNamaPelanggan.Text = "";
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            DialogResult Delete = MessageBox.Show("Data Pelanggan akan terhapus. apakah anda yakin menghapus ? "
                            , "konfirmasi", MessageBoxButtons.YesNo);
            if (Delete == System.Windows.Forms.DialogResult.Yes)
            {

                Pelanggan p = new Pelanggan(int.Parse(textBoxKode.Text), textBoxNamaPelanggan.Text, textBoxAlamat.Text, textBoxTelepon.Text);
                
                string HasilTambah = Pelanggan.HapusData(p);

                if (HasilTambah == "1")
                {
                    MessageBox.Show("Pelanggan telah dihapus ", "informasi");
                    textBoxKode.Text = "";
                    textBoxNamaPelanggan.Text = "";
                    textBoxAlamat.Text = "";
                    textBoxTelepon.Text = "";
                    textBoxKode.Focus();
                }
                else
                {
                    MessageBox.Show("gagal menghapus Pelanggan. pesan kesalahan : " + HasilTambah);
                }
            }
        }

        private void textBoxKode_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKode.Text.Length <= textBoxKode.MaxLength)
            {
                
                string hasilbaca = Pelanggan.BacaData("KodePelanggan", textBoxKode.Text, listpelanggan);
                if (hasilbaca == "1")
                {
                    if (listpelanggan.Count > 0)
                    {
                        textBoxNamaPelanggan.Text = listpelanggan[0].Nama;
                        textBoxAlamat.Text = listpelanggan[0].Alamat;
                        textBoxTelepon.Text = listpelanggan[0].Telepon;
                        textBoxNamaPelanggan.Focus();
                        
                    }
                    else
                    {
                        MessageBox.Show(" kode Pelanggan tidak ditemukan. proses Ubah Data tidak bisa dilakukan.");
                        textBoxNamaPelanggan.Text = "";
                        textBoxTelepon.Text = "";
                        textBoxAlamat.Text = "";
                        textBoxKode.Focus();
                    }
                }
                else
                {
                    MessageBox.Show(" perintah sql gagal di jalankan. pesan kesalahan = " + hasilbaca);
                    textBoxNamaPelanggan.Text = "";
                    textBoxAlamat.Text = "";
                    textBoxTelepon.Text = "";
                    textBoxKode.Focus();
                }
            }
        }
    }
}
