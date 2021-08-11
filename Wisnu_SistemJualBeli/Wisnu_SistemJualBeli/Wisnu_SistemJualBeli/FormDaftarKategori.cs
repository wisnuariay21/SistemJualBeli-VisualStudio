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
        List<Kategori> listData = new List<Kategori>();
        public FormDaftarKategori()
        {
            InitializeComponent();
        }

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
           string hasilBaca = Kategori.BacaData(listData,"","");
           if (hasilBaca == "1")
           {
               dataGridViewInfo.DataSource = listData;
           }
           else
           {
               MessageBox.Show("Gagal membaca data. Pesan kesalahan : " + hasilBaca);
           }
        }

        

        private void textBoxBerdasarkan_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("test");
            string hasilCari = "";
            if (comboBoxBerdasarkan.Text == "Kode Kategori")
            {
                hasilCari = "KodeKategori";
            }
            else if (comboBoxBerdasarkan.Text == "Nama Kategori")
            {
                hasilCari = "Nama";
            }
            string hasilBaca = Kategori.BacaData(listData, textBoxBerdasarkan.Text, comboBoxBerdasarkan.Text);
            if (hasilBaca == "1")
            {
                dataGridViewInfo.DataSource = listData;
                //dataGridViewInfo.DataSource = null;
            }
        }

        
    }
}
