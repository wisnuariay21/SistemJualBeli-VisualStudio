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
    public partial class FormTambahNota : Form
    {
        List<Pelanggan> listPelanggan = new List<Pelanggan>();
        List<Barang> listBarang = new List<Barang>();
        public FormTambahNota()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        
        private void FormTambahNota_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            string hasilNoNota;
            string hasilGenerate = NotaJual.GenerateHasilNoNota(out hasilNoNota);
            if(hasilGenerate == "1")
            {
                textBoxNota.Text = hasilNoNota;
            }
            else
            {
                MessageBox.Show("Gagal generate no nota" + hasilGenerate);
            }
            dateTimePickerTanggal.Value = DateTime.Now;
            dateTimePickerTanggal.Enabled = false;
            textBoxBarcode.MaxLength = 13;

            
            string hasilBaca = Pelanggan.BacaData("", "", listPelanggan);
            if (hasilBaca == "1")
            {
                comboBoxPelanggan.Items.Clear();
                for(int i = 0; i<listPelanggan.Count; i++)
                {
                    comboBoxPelanggan.Items.Add(listPelanggan[i].KodePelanggan + " - " + listPelanggan[i].Nama);
                }
            }
            else
            {
                MessageBox.Show("Gagal Baca Data");
            }
            FormMenu frmUtama = (FormMenu)this.Owner.MdiParent;
            labelKodePegawai.Text = frmUtama.LabelKode.Text;
            labelNamaPegawai.Text = frmUtama.labelNama.Text;
            textBoxAlamat.Enabled = false;
        }

        private void textBoxBarcode_TextChanged(object sender, EventArgs e)
        {
            if(textBoxBarcode.Text.Length == textBoxBarcode.MaxLength)
            {
                string hasilbaca = Barang.BacaData("barcode", textBoxBarcode.Text, listBarang);
                if(hasilbaca == "1")
                {
                    if(listBarang.Count > 0)
                    {
                        textBoxKode.Text = listBarang[0].KodeBarang;
                        textBoxNamaBarang.Text = listBarang[0].Nama;
                        textBoxHarga.Text = listBarang[0].HargaJual.ToString();
                        textBoxJumlah.Text = listBarang[0].Stok.ToString();
                        textBoxJumlah.Text = "1";
                        textBoxJumlah.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Barang tidak ditemukan lorek");
                        textBoxBarcode.Text = "";
                    }

                }
                else
                {
                    MessageBox.Show("Perintah SQL gagal dijalankan. Pesan kesalahan = " + hasilbaca);
                }
            }
        }

        private void comboBoxPelanggan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hasil = Pelanggan.BacaData("KodePelanggan", comboBoxPelanggan.Text.Substring(0, 1), listPelanggan);
            if (hasil == "1")
            {
                if (listPelanggan.Count > 0)
                {
                    textBoxAlamat.Text = listPelanggan[0].Alamat;            
                }
                else
                {
                    MessageBox.Show("Kode pelanggan tidak ditemukan");
                    textBoxAlamat.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Perintah Sql gagal Dijalankan. Pesan Kesalahan = " + hasil);
            }
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            NotaJual nota = new NotaJual();
            nota.NoNotaJual = textBoxNota.Text;
            nota.Tanggal = dateTimePickerTanggal.Value;

            Pelanggan p = new Pelanggan();
            p.KodePelanggan = int.Parse(comboBoxPelanggan.Text.Substring(0,1));
            p.Nama = comboBoxPelanggan.Text.Substring(4, comboBoxPelanggan.Text.Length - 4);
            p.Alamat = textBoxAlamat.Text;

            Pegawai peg = new Pegawai();
            peg.KodePegawai = int.Parse(labelKodePegawai.Text);
            peg.Nama = labelNamaPegawai.Text;

            for (int i = 0; i<dataGridViewInfo.Rows.Count; i++)
            {
                Barang brg = new Barang();
                brg.KodeBarang = dataGridViewInfo.Rows[i].Cells["KodeBarang"].Value.ToString();
                brg.Nama = dataGridViewInfo.Rows[i].Cells["NamaBarang"].Value.ToString();
                int harga = int.Parse(dataGridViewInfo.Rows[i].Cells["HargaJual"].Value.ToString());
                int jumlah = int.Parse(dataGridViewInfo.Rows[i].Cells["Jumlah"].Value.ToString());

                nota.TambahDetilBarang(brg, harga, jumlah);
            }
            string hasilTambah = NotaJual.TambahData(nota);
            if (hasilTambah == "1")
            {
                MessageBox.Show("Data nota jual telah tersimpan", "Info");
            }
            else
            {
                MessageBox.Show("Data nota jual gagal tersimpan tersimpan. Pesan Kesalahan : " + hasilTambah, "Kesalahan");
            }

            


        }
        private int HitungGrandTotal()
        {
            int grandTotal = 0;
            for (int i = 0; i < dataGridViewInfo.Rows.Count; i++)
            {
                int subTotal = int.Parse(dataGridViewInfo.Rows[i].Cells["SubTotal"].Value.ToString());
                grandTotal = grandTotal * subTotal;
            }
            return grandTotal;
        }

        private void textBoxJumlah_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int subTotal = int.Parse(textBoxHarga.Text) * int.Parse(textBoxJumlah.Text);
                dataGridViewInfo.Rows.Add(textBoxKode.Text, textBoxNamaBarang.Text, textBoxHarga.Text, textBoxJumlah.Text, subTotal);
                labelHarga.Text = HitungGrandTotal().ToString("0,###");
                textBoxBarcode.Text = "";
                textBoxKode.Text = "";
                textBoxNamaBarang.Text = "";
                textBoxHarga.Text = "";
                textBoxJumlah.Text = "";
                textBoxBarcode.Focus();
            }
        }
        

        private void textBoxJumlah_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
