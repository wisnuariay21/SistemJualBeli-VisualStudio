using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wisnu_SistemJualBeli
{
    public partial class FormDaftarNotaJual : Form
    {
        public FormDaftarNotaJual()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahNotaJual frmtambah = new FormTambahNotaJual();
            frmtambah.Owner = this;
            frmtambah.ShowDialog();
        }
    }
}
