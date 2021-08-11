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
    public partial class FormTambahJabatan : Form
    {
        public FormTambahJabatan()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void buttonkosong_Click(object sender, EventArgs e)
        {
            textBoxId.Text = "";
            textBoxNamaJabatan.Text = "";

        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Jabatan jabat = new Jabatan();
                jabat.IdJabatan = textBoxId.Text;
                jabat.NamaJabatan = textBoxNamaJabatan.Text;
                string hasil = Jabatan.TambahData(jabat);

                if (hasil == "1")
                {
                    MessageBox.Show("Data telah tersimpan");
                    textBoxId.Text = "";
                    textBoxNamaJabatan.Text = "";
                }
                else
                {
                    MessageBox.Show("Data gagal tersimpan " + hasil);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
