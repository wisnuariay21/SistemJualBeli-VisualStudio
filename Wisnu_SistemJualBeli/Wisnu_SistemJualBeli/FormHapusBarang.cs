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
    public partial class FormHapusBarang : Form
    {
        List<Barang> listBarang = new List<Barang>();
        public FormHapusBarang()
        {
            InitializeComponent();
        }

        private void FormHapusBarang_Load(object sender, EventArgs e)
        {
            textBoxKategoriBarang.Enabled = false;
            textBoxBarcode.Enabled = false;
            textBoxNamaBarang.Enabled = false;
            textBoxHargaJual.Enabled = false;
            textBoxStok.Enabled = false;
        }

        private void textBoxKodeBarang_TextChanged(object sender, EventArgs e)
        {
            if(textBoxKodeBarang.Text.Length == textBoxKodeBarang.MaxLength)
            {
                string hasilBaca = Barang.BacaData("KodeBarang", textBoxKodeBarang.Text, listBarang);
                if(hasilBaca == "1")
                {
                    if(listBarang.Count > 0)
                    {
                        textBoxBarcode.Text = listBarang[0].Barcode;
                        textBoxNamaBarang.Text = listBarang[0].Nama;
                        textBoxHargaJual.Text = listBarang[0].HargaJual.ToString();
                        textBoxStok.Text = listBarang[0].Stok.ToString();
                        textBoxKategoriBarang.Text = listBarang[0].KategoriBarang.KodeKategori + " - " + listBarang[0].KategoriBarang.Nama;
                        textBoxBarcode.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Kode barang tidak ditemukan. Proses ubah data tidak dapat dilakukan");
                    }
                }
                else
                {
                    MessageBox.Show("Perintah Sql gagal dijalankan. Pesan kesalahan = " + hasilBaca);
                }
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            string kodeKategori = textBoxKategoriBarang.Text.Substring(1, 2);
            string namaKategori = textBoxKategoriBarang.Text.Substring(6, textBoxKategoriBarang.Text.Length - 6);
            Kategori kategoriBarang = new Kategori(kodeKategori, namaKategori);

            Barang brng = new Barang();
            textBoxKodeBarang.Text = brng.KodeBarang;
            textBoxBarcode.Text = brng.Barcode;
            textBoxNamaBarang.Text = brng.Nama;

            string hasil = Barang.HapusData(brng);
        }
    }
}
