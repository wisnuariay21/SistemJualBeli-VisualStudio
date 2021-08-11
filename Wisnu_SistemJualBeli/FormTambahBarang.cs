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
    public partial class FormTambahBarang : Form
    {
        List<Kategori> ListKategori = new List<Kategori>();
        public FormTambahBarang()
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
            textBoxJual.Text = "";
            textBoxKodeBar.Text = "";
            textBoxNama.Text = "";
            textBoxStok.Text = "";
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            
                Barang b = new Barang();
                b.KodeBarang = textBoxKodeBar.Text;
                b.Nama = textBoxNama.Text;
                b.HargaJual = int.Parse(textBoxJual.Text);
                b.Stok = int.Parse(textBoxStok.Text);
                b.Barcode = textBoxBarcode.Text;
                string hasil = Barang.TambahData(b);
                if (hasil == "1")
                {
                    MessageBox.Show("Data berhasil tersimpan.");
                    textBoxBarcode.Text = "";
                    textBoxJual.Text = "";
                    textBoxKodeBar.Text = "";
                    textBoxNama.Text = "";
                    textBoxStok.Text = "";
                }
                else
                {
                    MessageBox.Show("Gagal menambah data");
                }
            
        }

        private void FormTambahBarang_Load(object sender, EventArgs e)
        {
            string hasil = Kategori.BacaData("", "", ListKategori);
            comboBoxKategori.Items.Clear();
            for(int i= 0; i<ListKategori.Count; i++)
            {
                comboBoxKategori.Items.Add(ListKategori[i].KodeKategori + " - " + ListKategori[i].Nama);
            }
        }

        private void comboBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hasil;
            string hasilgenerate = Barang.GenerateKode(comboBoxKategori.Text.Substring(0, 2), out hasil);
            if (hasilgenerate == "1")
            {
                textBoxKodeBar.Text = hasil;
            }
            else
            {
                MessageBox.Show("Gagal Generate Code");
            }
        }
    }
}
