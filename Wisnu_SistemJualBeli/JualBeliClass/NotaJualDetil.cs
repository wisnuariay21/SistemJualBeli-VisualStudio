//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JualBeliClass
{
    public class NotaJualDetil
    {
        private Barang barang;
        private int jumlah;
        private int harga;

        public int Jumlah
        {
            get { return jumlah; }
            set { jumlah = value; }
        }

        public int Harga
        {
            get { return harga; }
            set { harga = value; }
        }

        public Barang Barang
        {
            get { return barang; }
            set { barang = value; }
        }
        public NotaJualDetil()
        {
            Jumlah = 1;
            Harga = 0;
        }
        public NotaJualDetil(Barang pBarang, int Pjumlah, int Pharga)
        {
            Barang = pBarang;
            Jumlah = Pjumlah;
            Harga = Pharga;
        }

    }


}