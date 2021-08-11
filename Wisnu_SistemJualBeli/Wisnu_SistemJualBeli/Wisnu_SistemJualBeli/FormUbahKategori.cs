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
    public partial class FormUbahKategori : Form
    {
        public FormUbahKategori()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonsimpan_Click(object sender, EventArgs e)
        {
            Kategori katgor = new Kategori(textBoxKodeKategori.Text, textBoxNamaKategori.Text);
            string hasil = Kategori.UbahData(katgor);

            if(hasil == "1")
            {
                MessageBox.Show("Kategori telah diubah.", "Informasi");
            }
            else
            {
                MessageBox.Show("Gagal mengubah kategori. Pesan kesalahan : " + hasil);
            }
        }

        private void buttonkosong_Click(object sender, EventArgs e)
        {
            textBoxKodeKategori.Text = "";
            textBoxNamaKategori.Text = "";
        }
    }
}
