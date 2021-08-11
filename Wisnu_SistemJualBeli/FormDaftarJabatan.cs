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
    public partial class FormDaftarJabatan : Form
    {
        List<Jabatan> listData = new List<Jabatan>();
        public FormDaftarJabatan()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahJabatan jabatan = new FormTambahJabatan();
            jabatan.Owner = this;
            jabatan.ShowDialog();
        }

        private void FormDaftarJabatan_Load(object sender, EventArgs e)
        {
            try
            {
                string hasilBaca = Jabatan.BacaData("", "", listData);
                dataGridViewInfo.DataSource = null;
                if (hasilBaca == "1")// sukses baca data
                {
                    dataGridViewInfo.DataSource = listData;
                }
                else
                {
                    dataGridViewInfo.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormUbahJabatan jbtn = new FormUbahJabatan();
            jbtn.Owner = this;
            jbtn.ShowDialog();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            FormHapusJabatan hps = new FormHapusJabatan();
            hps.Owner = this;
            hps.ShowDialog();
        }

        private void textBoxkriteria_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";
            if (comboBoxKriteria.Text == "IdJabatan")
            {
                kriteria = "IdJabatan";
            }
            else if (comboBoxKriteria.Text == "Nama")
            {
                kriteria = "Nama";
            }
            string hasil = Jabatan.BacaData(kriteria, textBoxkriteria.Text, listData);
            dataGridViewInfo.DataSource = null;
            if (hasil == "1")
            {
                dataGridViewInfo.DataSource = listData;
            }
        }
    }
}
