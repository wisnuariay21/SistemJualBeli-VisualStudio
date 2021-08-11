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
        List<Kategori> listkategori = new List<Kategori>();
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
                textBoxKodeKategori.Text = "";
                textBoxNamaKategori.Text = "";
                textBoxKodeKategori.Focus();
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

        private void textBoxKodeKategori_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKodeKategori.Text.Length == textBoxKodeKategori.MaxLength)
            { 
                string hasilbaca = Kategori.BacaData("KodeKategori", textBoxKodeKategori.Text, listkategori);
                if (hasilbaca == "1")
                {
                    if (listkategori.Count > 0)
                    {
                        textBoxNamaKategori.Text = listkategori[0].Nama;
                        textBoxNamaKategori.Focus();
                    }
                    else
                    {
                        MessageBox.Show(" kode kategori tidak ditemukan. proses Ubah Data tidak bisa dilakukan.");
                        textBoxNamaKategori.Text = "";
                        textBoxKodeKategori.Focus();
                    }
                }
                else
                {
                    MessageBox.Show(" Data gagal diubah. pesan kesalahan = " + hasilbaca);
                    textBoxKodeKategori.Text = "";
                    textBoxNamaKategori.Text = "";
                    textBoxKodeKategori.Focus();
                }
            }
        }

        private void FormUbahKategori_Load(object sender, EventArgs e)
        {
            textBoxKodeKategori.MaxLength = 2; //membatasi agar kodekatgori 2 digit
        }
    }
}
