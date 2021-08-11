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
    public partial class FormTambahDaftarKategori : Form
    {
        public FormTambahDaftarKategori()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonkosong_Click(object sender, EventArgs e)
        {
            textBoxKode.Text = "";
            textBoxNamaKategori.Text = "";
        }

        private void buttonsimpan_Click(object sender, EventArgs e)
        {
            Kategori k = new Kategori(textBoxKode.Text, textBoxNamaKategori.Text);
            string hasil = Kategori.TambahData(k);

            if(hasil == "1")
            {
                MessageBox.Show("Kategori telah tersimpan.", "Informasi");
                textBoxKode.Text = "";
                textBoxNamaKategori.Text = "";
                textBoxKode.Focus();
            }
            else
            {
                MessageBox.Show("Gagal menambah kategori. Pesan kesalahan : " + hasil);
            }
        }
    }
}
