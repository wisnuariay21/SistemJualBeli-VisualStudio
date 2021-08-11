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
    public partial class FormDaftarKategori : Form
    {
        public FormDaftarKategori()
        {
            InitializeComponent();
        }
        List<Kategori> listData = new List<Kategori>();
        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahDaftarKategori form = new FormTambahDaftarKategori();
            form.Owner = this;
            form.ShowDialog();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormUbahKategori form = new FormUbahKategori();
            form.Owner = this;
            form.ShowDialog();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            FormHapusKategoriBarang form = new FormHapusKategoriBarang();
            form.Owner = this;
            form.ShowDialog();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDaftarKategori_Load(object sender, EventArgs e)
        {
            // method data baca / menampilkan semua data
            string hasilBaca = Kategori.BacaData("", "", listData);
            dataGridViewInfo.DataSource = null;
            if(hasilBaca == "1")// sukses baca data
            {
                dataGridViewInfo.DataSource = listData;
            }
            else
            {
                dataGridViewInfo.DataSource = null;
            }
        }

        private void textBoxkriteria_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";
            if(comboBoxKriteria.Text == "Kode Kategori")
            {
                kriteria = "KodeKategori";
            }
            else if(comboBoxKriteria.Text == "Nama")
            {
                kriteria = "Nama";
            }
            string hasil = Kategori.BacaData(kriteria, textBoxkriteria.Text, listData);
            dataGridViewInfo.DataSource = null;
            if(hasil == "1")
            {
                dataGridViewInfo.DataSource = listData;
            }

        }
    }
}
