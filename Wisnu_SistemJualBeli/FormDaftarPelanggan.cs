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
    public partial class FormPelanggan : Form
    {
        public FormPelanggan()
        {
            InitializeComponent();
        }
        List<Pelanggan> listData = new List<Pelanggan>();
        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahPelanggan frm = new FormTambahPelanggan();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormUbahPelanggan frm = new FormUbahPelanggan();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            FormHapusPelanggan frm = new FormHapusPelanggan();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPelanggan_Load(object sender, EventArgs e)
        {
            string hasil = Pelanggan.BacaData("", "", listData);
            if(hasil == "1")
            {
                dataGridViewInfo.DataSource = null;
                dataGridViewInfo.DataSource = listData;
            }
            else
            {
                dataGridViewInfo.DataSource = null;
            }
        }

        private void textBoxBerdasarkan_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";
            if (comboBoxBerdasarkan.Text == "Kode Pelanggan")
            {
                kriteria = "KodePelanggan";
            }
            else if(comboBoxBerdasarkan.Text == "Nama")
            {
                kriteria = "Kriteria";
            }
            else if(comboBoxBerdasarkan.Text == "Alamat")
            {
                kriteria = "Alamat";
            }
            else if(comboBoxBerdasarkan.Text == "Telepon")
            {
                kriteria = "Telepon";
            }
            string hasil = Pelanggan.BacaData(kriteria, textBoxBerdasarkan.Text, listData);
            dataGridViewInfo.DataSource = null;

            if(hasil == "1")
            {
                dataGridViewInfo.DataSource = listData;
            }
        }
    }
}
