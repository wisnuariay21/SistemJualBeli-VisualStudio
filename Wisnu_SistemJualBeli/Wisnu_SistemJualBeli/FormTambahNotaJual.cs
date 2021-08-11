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
    public partial class FormTambahNotaJual : Form
    {
        List<Pelanggan> listpelanggan = new List<Pelanggan>();
        List<Barang> listBarang = new List<Barang>();
        public FormTambahNotaJual()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FormTambahNotaJual_Load(object sender, EventArgs e)
        {
            textBoxBarcode.MaxLength = 13;
            FormatDataGrid();
            
            string hasilBaca = Pelanggan.BacaData("", "", listpelanggan);
            if (hasilBaca == "1")
            {
                comboBoxPelanggan.Items.Clear();
                for (int i = 0; i<listpelanggan.Count; i++)
                {
                    comboBoxPelanggan.Items.Add(listpelanggan[i].KodePelanggan + " - " + listpelanggan[i].Nama);
                }
            }
            else
            {
                MessageBox.Show("Gagal Membaca");
            }
        }

        private void textBoxBarcode_TextChanged(object sender, EventArgs e)
        {
            if (textBoxBarcode.Text.Length == textBoxBarcode.MaxLength)
            {
                string hasil = Barang.BacaData("Barcode", textBoxBarcode.Text, listBarang);
                if (hasil == "1")
                {
                    if (listBarang.Count > 0)
                    {
                        textBoxKode.Text = listBarang[0].KodeBarang;
                        textBoxNama.Text = listBarang[0].Nama;
                        textBoxHarga.Text = listBarang[0].HargaJual.ToString();
                        textBoxJumlah.Text = "1";
                        textBoxJumlah.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Barang tidak ditemukan");
                    }
                }
                else
                {
                    MessageBox.Show("perintah sql gagal dijalankan");
                }
            }
        }

        private void textBoxJumlah_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int subtotal = int.Parse(textBoxHarga.Text) * int.Parse(textBoxJumlah.Text);
                dataGridViewInfo.Rows.Add(textBoxKode.Text, textBoxNama.Text);
            }
        }
        private void FormatDataGrid()
        {
            dataGridViewInfo.Columns.Clear();
            dataGridViewInfo.Columns.Add("KodeBarang", "Kode Barang");
            dataGridViewInfo.Columns.Add("NamaBarang", "Nama Barang");
            dataGridViewInfo.Columns.Add("HargaJual", "Harga Jual");
            dataGridViewInfo.Columns.Add("Jumlah", "Jumlah");
            dataGridViewInfo.Columns.Add("SubTotal", "Sub Total");
           
            dataGridViewInfo.Columns["KodeBarang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewInfo.Columns["NamaBarang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewInfo.Columns["HargaJual"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewInfo.Columns["Jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewInfo.Columns["SubTotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            

            dataGridViewInfo.Columns["Jumlah"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewInfo.Columns["HargaJual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewInfo.Columns["SubTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewInfo.Columns["HargaJual"].DefaultCellStyle.Format = "0,###";
            dataGridViewInfo.Columns["SubTotal"].DefaultCellStyle.Format = "0,###";
            dataGridViewInfo.AllowUserToAddRows = false;

        }
    }
}
