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

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public void PengaturanHakAkses (Jabatan Pjabatan)
        {
            if (Pjabatan.IdJabatan == "J1")
            {
                masterToolStripMenuItem.Visible = false;
                pembelianToolStripMenuItem.Visible = true;
                penjualanToolStripMenuItem.Visible = false;
                laporanPenjualanToolStripMenuItem.Visible = false;
                masterToolStripMenuItem1.Visible = false;
                laporanPenjualanToolStripMenuItem.Visible = true;
            }
            else if (Pjabatan.IdJabatan == "J2")
            {
                masterToolStripMenuItem.Visible = false;
                pembelianToolStripMenuItem.Visible = true;
                penjualanToolStripMenuItem.Visible = false;
                laporanPenjualanToolStripMenuItem.Visible = false;
                masterToolStripMenuItem1.Visible = true;
                laporanPenjualanToolStripMenuItem.Visible = false;
            }
            else if (Pjabatan.IdJabatan == "J3")
            {
                masterToolStripMenuItem.Visible = true;
                pembelianToolStripMenuItem.Visible = true;
                penjualanToolStripMenuItem.Visible = true;
                laporanPenjualanToolStripMenuItem.Visible = true;
                masterToolStripMenuItem1.Visible = true;
                laporanPenjualanToolStripMenuItem.Visible = true;
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
