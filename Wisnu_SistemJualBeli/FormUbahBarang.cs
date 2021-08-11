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
    public partial class FormUbahBarang : Form
    {
        List<Barang> listbarang = new List<Barang>();
        public FormUbahBarang()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonkosong_Click(object sender, EventArgs e)
        {
            textBoxBarcode.Text = "";
            textBoxHargaJual.Text = "";
            textBoxKategoriBarang.Text = "";
            textBoxKodeBarang.Text = "";
            textBoxNamaBarang.Text = "";
            textBoxStok.Text = "";
            
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            Barang brng = new Barang();
            brng.KodeBarang = textBoxKodeBarang.Text;
            brng.Barcode = textBoxBarcode.Text;
            brng.Nama = textBoxNamaBarang.Text;
            brng.HargaJual = int.Parse(textBoxHargaJual.Text);
            brng.Stok = int.Parse(textBoxHargaJual.Text);

            Kategori kat = new Kategori();
            kat.KodeKategori = textBoxKategoriBarang.Text.Substring(0, 2);

            string hasil = Barang.UbahData(brng);
            if(hasil == "1")
            {
                MessageBox.Show("Data berhasil diubah");
            }
            else
            {
                MessageBox.Show("Data gagal diubah");
            }

        }

        private void FormUbahBarang_Load(object sender, EventArgs e)
        {
            textBoxKodeBarang.MaxLength = 5;
            textBoxBarcode.MaxLength = 13;
            textBoxNamaBarang.MaxLength = 45;
            textBoxKategoriBarang.Enabled = false;
            textBoxHargaJual.TextAlign = HorizontalAlignment.Right;
            textBoxStok.TextAlign = HorizontalAlignment.Right;
        }

        private void textBoxKodeBarang_TextChanged(object sender, EventArgs e)
        {
            if(textBoxKodeBarang.Text.Length == textBoxKodeBarang.MaxLength)
            {
                string hasilBaca = Barang.BacaData("Kodebarang", textBoxKodeBarang.Text, listbarang);
                if(hasilBaca == "1")
                {
                    if(listbarang.Count > 0)
                    {
                        textBoxBarcode.Text = listbarang[0].Barcode;
                        textBoxNamaBarang.Text = listbarang[0].Nama;
                        textBoxHargaJual.Text = listbarang[0].HargaJual.ToString();
                        textBoxStok.Text = listbarang[0].Stok.ToString();

                        textBoxStok.Enabled = false;
                        textBoxKategoriBarang.Text = listbarang[0].KategoriBarang.KodeKategori + " - " + listbarang[0].KategoriBarang.Nama;
                        textBoxBarcode.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Kode barang tidak ditemukan. Proses ubah data tidak dapat dilakukan");
                    }
                }
                else
                {
                    MessageBox.Show("Perintah SQL gagal dijalankan. Pesan Kesalahan : " + hasilBaca);
                }
            }
        }
    }
}
