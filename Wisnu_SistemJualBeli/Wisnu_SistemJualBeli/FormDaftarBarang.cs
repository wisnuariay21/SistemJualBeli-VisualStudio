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
    public partial class FormDaftarBarang : Form
    {
        List<Barang> listBarang = new List<Barang>();
        public FormDaftarBarang()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahBarang barang = new FormTambahBarang();
            barang.Owner = this;
            barang.ShowDialog();
        }

        private void FormDaftarBarang_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            comboBoxKriteria.DropDownStyle = ComboBoxStyle.DropDownList;
            //dataGridViewBarang.DataSource = null;
            FormatDataGrid();
            string hasilBaca = Barang.BacaData("", "", listBarang);
            if (hasilBaca == "1")
            {
                dataGridViewInfo.Rows.Clear();
                for (int i = 0; i < listBarang.Count; i++)
                {
                    dataGridViewInfo.Rows.Add(listBarang[i].KodeBarang, listBarang[i].Barcode,
                        listBarang[i].Nama, listBarang[i].HargaJual, listBarang[i].Stok,
                        listBarang[i].KategoriBarang.KodeKategori, listBarang[i].KategoriBarang.Nama);
                }
            }
            else
            {
                dataGridViewInfo.DataSource = null;
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormUbahBarang barang = new FormUbahBarang();
            barang.Owner = this;
            barang.ShowDialog();
        }

        private void FormatDataGrid()
        {
            dataGridViewInfo.Columns.Clear();
            dataGridViewInfo.Columns.Add("KodeBarang", "Kode Barang");
            dataGridViewInfo.Columns.Add("Barcode", "Barcode");
            dataGridViewInfo.Columns.Add("NamaBarang", "Nama Barang");
            dataGridViewInfo.Columns.Add("HargaJual", "Harga Jual");
            dataGridViewInfo.Columns.Add("Stok", "Stok");
            dataGridViewInfo.Columns.Add("KodeKategori", "Kode Kategori");
            dataGridViewInfo.Columns.Add("NamaKategori", "Nama Kategori");

            dataGridViewInfo.Columns["KodeBarang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewInfo.Columns["Barcode"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewInfo.Columns["NamaBarang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewInfo.Columns["HargaJual"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewInfo.Columns["Stok"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewInfo.Columns["KodeKategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewInfo.Columns["NamaKategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewInfo.Columns["HargaJual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewInfo.Columns["Stok"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewInfo.Columns["HargaJual"].DefaultCellStyle.Format = "0,###";

        }

        private void textBoxkriteria_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";
            if (comboBoxKriteria.Text == "Kode Barang")
            {
                kriteria = "B.KodeBarang";
            }
            else if (comboBoxKriteria.Text == "Barcode")
            {
                kriteria = "B.Barcode";
            }
            else if (comboBoxKriteria.Text == "Nama")
            {
                kriteria = "B.Nama";
            }
            else if (comboBoxKriteria.Text == "Harga Jual")
            {
                kriteria = "B.HargaJual";
            }
            else if (comboBoxKriteria.Text == "Stok")
            {
                kriteria = "B.Stok";
            }
            else if (comboBoxKriteria.Text == "Kode Kategori")
            {
                kriteria = "B.KodeKategori";
            }
            else if (comboBoxKriteria.Text == "Nama Kategori")
            {
                kriteria = "K.Nama";
            }
            listBarang.Clear();
            string hasilBaca = Barang.BacaData(kriteria, textBoxkriteria.Text, listBarang);
            if (hasilBaca == "1")
            {
                dataGridViewInfo.Rows.Clear();
                for (int i = 0; i < listBarang.Count; i++)
                {
                    dataGridViewInfo.Rows.Add(listBarang[i].KodeBarang, listBarang[i].Barcode, listBarang[i].Nama, listBarang[i].HargaJual,
                        listBarang[i].Stok, listBarang[i].KategoriBarang.KodeKategori, listBarang[i].KategoriBarang.Nama);
                }
            }
        }

        private void comboBoxKriteria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
