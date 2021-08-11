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
    public partial class FormTambahPegawai : Form
    {
        List<Jabatan> listDataJabatan = new List<Jabatan>();
        public FormTambahPegawai()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTambahPegawai_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            textBoxKode.MaxLength = 11;
            textBoxNama.MaxLength = 45;
            dateTimePickerInfo.Value = DateTime.Now;
            textBoxAlamat.MaxLength = 45;
            comboBoxJabatan.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxNama.Text = "";
            textBoxKode.Enabled = false;
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
                MessageBox.Show("Data Pegawai barang gagal ditampilkan. Pesan Kesalahan : " + hasilBaca);
            }
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
            string hasilTambah = Pegawai.TambahData(classPegawai);
            if (hasilTambah == "1")
            {
                MessageBox.Show("Pegawai telah tersimpan.", "Informasi");
                //FormTambahBarang_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Gagal menambah pegawai. Pesan kesalahan : " + hasilTambah);
            }
        }

        private void buttonkosong_Click(object sender, EventArgs e)
        {
            FormTambahPegawai_Load(sender, e);
        }

        private void comboBoxJabatan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kodeJabatan = comboBoxJabatan.Text;
            string kodeTerbaru;
            string hasilGenerate = Pegawai.GenerateKode(kodeJabatan, out kodeTerbaru);

            if (hasilGenerate == "1")
            {
                textBoxKode.Text = kodeTerbaru;
                textBoxNama.Focus();
            }
            else
            {
                MessageBox.Show("Gagal melakukan generate code. Pesan Kesalahan : " + hasilGenerate);
            }
        }
    }
}
