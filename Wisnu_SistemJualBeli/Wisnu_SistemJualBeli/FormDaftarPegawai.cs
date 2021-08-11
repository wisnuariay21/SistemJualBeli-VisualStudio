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
    public partial class FormPegawai : Form
    {
        List<Pegawai> listHasilData = new List<Pegawai>();
        public FormPegawai()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahPegawai tmbh = new FormTambahPegawai();
            tmbh.Owner = this;
            tmbh.ShowDialog();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormUbahPegawai ubah = new FormUbahPegawai();
            ubah.Owner = this;
            ubah.ShowDialog();
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            FormHapusPegawai hapus = new FormHapusPegawai();
            hapus.Owner = this;
            hapus.ShowDialog();
        }

        private void FormPegawai_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            dataGridViewInfo.DataSource = null;
            listHasilData.Clear();
            comboBoxBerdasarkan.DropDownStyle = ComboBoxStyle.DropDownList;
            FormatDataGrid();
            string hasilBaca = Pegawai.BacaData("", "", listHasilData);
            if (hasilBaca == "1")
            {
                dataGridViewInfo.Rows.Clear();
                for (int i = 0; i < listHasilData.Count; i++)
                {
                    dataGridViewInfo.Rows.Add(listHasilData[i].KodePegawai, listHasilData[i].Nama,
                        listHasilData[i].TglLahir.Date.ToShortDateString(), listHasilData[i].Alamat, listHasilData[i].Gaji, listHasilData[i].Username,
                        listHasilData[i].Password, listHasilData[i].Jabatan.IdJabatan,
                        listHasilData[i].Jabatan.NamaJabatan);
                }
            }
            else
            {
                dataGridViewInfo.DataSource = null;
            }
        }

        private void FormatDataGrid()
        {
            dataGridViewInfo.Columns.Clear();

            dataGridViewInfo.Columns.Add("KodePegawai", "Kode Pegawai");
            dataGridViewInfo.Columns.Add("Nama", "Nama");
            dataGridViewInfo.Columns.Add("TglLahir", "Tgl Lahir");
            dataGridViewInfo.Columns.Add("Alamat", "Alamat");
            dataGridViewInfo.Columns.Add("Gaji", "Gaji");
            dataGridViewInfo.Columns.Add("Username", "Username");
            dataGridViewInfo.Columns.Add("Password", "Password");
            dataGridViewInfo.Columns.Add("IdJabatan", "Id Jabatan");
            dataGridViewInfo.Columns.Add("NamaJabatan", "Nama Jabatan");

            dataGridViewInfo.Columns["KodePegawai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewInfo.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewInfo.Columns["TglLahir"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewInfo.Columns["Alamat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewInfo.Columns["Gaji"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewInfo.Columns["Username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewInfo.Columns["Password"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
           dataGridViewInfo.Columns["IdJabatan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewInfo.Columns["NamaJabatan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewInfo.Columns["Gaji"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewInfo.Columns["Gaji"].DefaultCellStyle.Format = "0,###";
        }

        private void textBoxBerdasarkan_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";
            if (comboBoxBerdasarkan.Text == "Kode Pegawai")
            {
                kriteria = "p.KodePegawai";
            }
            else if (comboBoxBerdasarkan.Text == "Nama")
            {
                kriteria = "p.Nama";
            }
            else if (comboBoxBerdasarkan.Text == "Tgl Lahir")
            {
                kriteria = "p.TglLahir";
            }
            else if (comboBoxBerdasarkan.Text == "Alamat")
            {
                kriteria = "p.Alamat";
            }
            else if (comboBoxBerdasarkan.Text == "Gaji")
            {
                kriteria = "p.Gaji";
            }
            else if (comboBoxBerdasarkan.Text == "Username")
            {
                kriteria = "p.Username";
            }
            else if (comboBoxBerdasarkan.Text == "Password")
            {
                kriteria = "p.Password";
            }
            else if (comboBoxBerdasarkan.Text == "Id Jabatan")
            {
                kriteria = "p.IdJabatan";
            }
            else if (comboBoxBerdasarkan.Text == "Nama Jabatan")
            {
                kriteria = "j.Nama";
            }
            listHasilData.Clear();
            string hasilBaca = Pegawai.BacaData(kriteria, textBoxBerdasarkan.Text, listHasilData);
            if (hasilBaca == "1")
            {
                dataGridViewInfo.Rows.Clear();
                for (int i = 0; i < listHasilData.Count; i++)
                {
                    dataGridViewInfo.Rows.Add(listHasilData[i].KodePegawai, listHasilData[i].Nama,
                        listHasilData[i].TglLahir, listHasilData[i].Alamat, listHasilData[i].Gaji,
                        listHasilData[i].Username, listHasilData[i].Password,
                        listHasilData[i].Jabatan.IdJabatan, listHasilData[i].Jabatan.NamaJabatan);
                }
            }
        }
    }
}
