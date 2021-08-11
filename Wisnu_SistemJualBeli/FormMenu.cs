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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            
            // agar form utama jadi MDR parent
            this.IsMdiContainer = true;
            // agar bisa maximize
            this.WindowState = FormWindowState.Maximized;

            FormLogin formLogin = new FormLogin();
            formLogin.Owner = this;
            formLogin.ShowDialog();
        }

        public void PengaturanHakAkses(Jabatan pJabatan)
        {
            if(pJabatan.IdJabatan == "J1") //jika pegawai
            {
                masterToolStripMenuItem.Visible = false;
                penjualanToolStripMenuItem.Visible = false;
                pembelianToolStripMenuItem.Visible = true;
                LaporanMasterToolStripMenuItem.Visible = false;
                laporanPenjualanToolStripMenuItem.Visible = false;
                laporanPembelianToolStripMenuItem.Visible = true;
            }
            else if(pJabatan.IdJabatan == "J2") //jika kasir
            {
                masterToolStripMenuItem.Visible = false;
                penjualanToolStripMenuItem.Visible = true;
                pembelianToolStripMenuItem.Visible = false;
                LaporanMasterToolStripMenuItem.Visible = false;
                laporanPenjualanToolStripMenuItem.Visible = true;
                laporanPembelianToolStripMenuItem.Visible = false;
            }
            else if(pJabatan.IdJabatan == "J3")
            {
                masterToolStripMenuItem.Visible = true;
                penjualanToolStripMenuItem.Visible = true;
                pembelianToolStripMenuItem.Visible = true;
                LaporanMasterToolStripMenuItem.Visible = true;
                laporanPenjualanToolStripMenuItem.Visible = true;
                laporanPembelianToolStripMenuItem.Visible = true;
            }
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FormBarang"];

            if (f == null)
            {
                FormDaftarBarang barang = new FormDaftarBarang();
                barang.MdiParent = this;
                barang.Show();
            }
            else
            {
                f.Show();
                f.BringToFront(); // agar form muncul paling depan
            }
        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FormDaftarKategori"];

            if(f == null)
            {
                FormDaftarKategori kategori = new FormDaftarKategori();
                kategori.MdiParent = this;
                kategori.Show();
            }
            else
            {
                f.Show();
                f.BringToFront(); // agar form muncul paling depan
            }

            

        }

        private void pelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["Formpelanggan"];

            if(f == null)
            {
                FormPelanggan pelanggan = new FormPelanggan();
                pelanggan.MdiParent = this;
                pelanggan.Show();
            }
            else
            {
                f.Show();
                f.BringToFront();
            }
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FormPegawai"];

            if(f ==  null)
            {
                FormPegawai pegawai = new FormPegawai();
                pegawai.MdiParent = this;
                pegawai.Show();
            }
            else
            {
                f.Show();
                f.BringToFront();
            }
        }

        private void penjualanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FormNotaJual"];

            if (f == null)
            {
                FormNotaJual jual = new FormNotaJual();
                jual.MdiParent = this;
                jual.Show();

            }
            else
            {
                f.Show();
                f.BringToFront();
            }
        }

        private void pembelianToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FormNotaBeli"];

            if (f == null)
            {
                FormNotaBeli beli = new FormNotaBeli();
                beli.MdiParent = this;
                beli.Show();
            }
            else
            {
                f.Show();
                f.BringToFront();
            }
        }

        private void jabatanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FormDaftarJabatan"];

            if (f == null)
            {
                FormDaftarJabatan daftar = new FormDaftarJabatan();
                daftar.MdiParent = this;
                daftar.Show();
            }
            else
            {
                f.Show();
                f.BringToFront();
            }
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["FormDaftarNotaJual"];

            if (f == null)
            {
                FormDaftarNotaJual daftar = new FormDaftarNotaJual();
                daftar.MdiParent = this;
                daftar.Show();
            }
            else
            {
                f.Show();
                f.BringToFront();
            }
        }
    }
}
