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
    public partial class FormUbahPegawai : Form
    {
        List<Jabatan> listDataJabatan = new List<Jabatan>();
        List<Pegawai> listHasilData = new List<Pegawai>();
        public FormUbahPegawai()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            int indexDipilihUser = comboBoxJabatan.SelectedIndex;

            Jabatan jabatanPg = listDataJabatan[indexDipilihUser];
            Pegawai classPegawai = new Pegawai();
            classPegawai.KodePegawai = int.Parse(textBoxKode.Text);
            classPegawai.Nama = textBoxNama.Text;
            classPegawai.TglLahir = dateTimePickerInfo.Value.Date;
            classPegawai.Alamat = textBoxAlamat.Text;
            classPegawai.Gaji = int.Parse(textBoxGaji.Text);
            classPegawai.Username = textBoxUsername.Text;
            classPegawai.Password = textBoxPassword.Text;
            classPegawai.Jabatan = jabatanPg;
            string hasilTambah = Pegawai.UbahData(classPegawai);

            if (hasilTambah == "1")
            {
                MessageBox.Show("Pegawai telah diubah.", "Informasi");
            }
            else
            {
                MessageBox.Show("Gagal mengubah Pegawai. Pesan kesalahan : " + hasilTambah);
            }
        }

        private void FormUbahPegawai_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            textBoxKode.MaxLength = 11;
            textBoxNama.MaxLength = 45;
           dateTimePickerInfo.Value = DateTime.Now;
            textBoxAlamat.MaxLength = 45;
            comboBoxJabatan.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxNama.Text = "";
            textBoxAlamat.Text = "";
            textBoxGaji.Text = "0";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxGaji.TextAlign = HorizontalAlignment.Right;

            string hasilBaca = Jabatan.BacaData("", "", listDataJabatan);
            if (hasilBaca == "1")
            {
                comboBoxJabatan.Items.Clear();
                for (int i = 0; i < listDataJabatan.Count; i++)
                {
                    comboBoxJabatan.Items.Add(listDataJabatan[i].IdJabatan + " - " + listDataJabatan[i].NamaJabatan);
                }
            }
            else
            {
                MessageBox.Show("Data Jabatan barang gagal ditampilkan. Pesan Kesalahan : " + hasilBaca);
            }
        }

        private void buttonkosong_Click(object sender, EventArgs e)
        {
            FormUbahPegawai_Load(sender, e);
        }

        private void textBoxKode_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKode.Text.Length <= textBoxKode.MaxLength)
            {
                listHasilData.Clear();
                string hasilBaca = Pegawai.BacaData("KodePegawai", textBoxKode.Text, listHasilData);
                if (hasilBaca == "1")
                {
                    if (listHasilData.Count > 0)
                    {
                       textBoxNama.Text = listHasilData[0].Nama;
                        textBoxAlamat.Text = listHasilData[0].Alamat;
                        dateTimePickerInfo.Value = listHasilData[0].TglLahir.Date;
                        textBoxAlamat.Text = listHasilData[0].Alamat.ToString();
                        textBoxGaji.Text = listHasilData[0].Gaji.ToString();
                        textBoxUsername.Text = listHasilData[0].Username.ToString();
                        textBoxPassword.Text = listHasilData[0].Password.ToString();
                        comboBoxJabatan.Text = listHasilData[0].Jabatan.IdJabatan + " - " + listHasilData[0].Jabatan.NamaJabatan;
                       textBoxNama.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Kode Pegawai tidak ditemukan. Proses Ubah Data tidak bisa ditemukan. ");
                    }
                }
                else
                {
                    MessageBox.Show("Perintah SQL gagal dijalankan. Pesan kesalahan = " + hasilBaca);
                }
            }
        }
    }
}
