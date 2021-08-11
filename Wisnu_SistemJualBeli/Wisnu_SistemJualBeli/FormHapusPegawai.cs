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
using System.Text.RegularExpressions;

namespace Wisnu_SistemJualBeli
{
    public partial class FormHapusPegawai : Form
    {
        List<Jabatan> listDataJabatan = new List<Jabatan>();
        List<Pegawai> listHasilData = new List<Pegawai>();
        public FormHapusPegawai()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show("Data pegawai akan terhapus. Apakah anda yakin ?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (konfirmasi == DialogResult.Yes)
            {
                string hasil = comboBoxJabatan.Text;
                string[] splitter = Regex.Split(hasil, " - ");
                string IdJabtan = splitter[0];
                string nama = splitter[1];
                Jabatan classJabatan = new Jabatan(IdJabtan, nama);

                Pegawai classPegawai = new Pegawai();
                classPegawai.KodePegawai = int.Parse(textBoxKode.Text);
                classPegawai.Nama = textBoxNama.Text;
                classPegawai.TglLahir = dateTimePickerInfo.Value.Date;
                classPegawai.Alamat = textBoxAlamat.Text;
                classPegawai.Gaji = int.Parse(textBoxGaji.Text);
                classPegawai.Username = textBoxUsername.Text;
                classPegawai.Password = textBoxPassword.Text;
                classPegawai.Jabatan = classJabatan;
                string hasilTambah = Pegawai.HapusData(classPegawai);
                if (hasilTambah == "1")
                {
                    MessageBox.Show("Pegawai telah dihapus.", "Informasi");
                }
                else
                {
                    MessageBox.Show("Gagal menghapus pegawai. Pesan kesalahan : " + hasilTambah);
                }
            }
        }

        private void FormHapusPegawai_Load(object sender, EventArgs e)
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
            comboBoxJabatan.Enabled = false;
           textBoxNama.Enabled = false;
            textBoxAlamat.Enabled = false;
            dateTimePickerInfo.Enabled = false;
            textBoxGaji.Enabled = false;
            textBoxUsername.Enabled = false;
            textBoxPassword.Enabled = false;

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

        private void buttonkosong_Click(object sender, EventArgs e)
        {
            FormHapusPegawai_Load(sender, e);
        }
    }
}
