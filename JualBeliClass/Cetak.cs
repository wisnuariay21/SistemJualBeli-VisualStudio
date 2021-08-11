using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;

namespace JualBeliClass
{
    public class Cetak
    {
        #region DATAMEMBER
        private Font jenisFont;
        private StreamReader fileCetak;
        private float marginKiri, marginKanan, marginAtas, marginBawah;
        #endregion
        #region PROPERTY
        public Font JenisFont { get => jenisFont; set => jenisFont = value; }
        public StreamReader FileCetak { get => fileCetak; set => fileCetak = value; }
        public float MarginKiri { get => marginKiri; set => marginKiri = value; }
        public float MarginKanan { get => marginKanan; set => marginKanan = value; }
        public float MarginAtas { get => marginAtas; set => marginAtas = value; }
        public float MarginBawah { get => marginBawah; set => marginBawah = value; }
        #endregion
        #region CONSTRUCTOR
        public Cetak(string namaFile)
        {
            FileCetak = new StreamReader(namaFile);
            JenisFont = new Font("Arial", 10);
            MarginKiri = (float)10.5;
            MarginKanan = (float)10.5;
            MarginAtas = (float)10.5;
            MarginBawah = (float)10.5;
        }
        public Cetak(string nnamaf,string ffont, int uukuran, float mKiri, float mKanan,float mAtas, float Mbawah)
        {
            FileCetak = new StreamReader(nnamaf);
            jenisFont = new Font(ffont, uukuran);
            MarginKiri = mKiri;
            MarginKanan = mKanan;
            MarginAtas = mAtas;
            MarginBawah = Mbawah;
        }
        #endregion
        #region METHOD
        public void CetakTulisan (object sender, PrintPageEventArgs e)
        {
            int jumBarisPerHalaman = (int)((e.MarginBounds.Height - MarginBawah) / JenisFont.GetHeight(e.Graphics));
            float y = MarginAtas;
            int jumBaris = 0;
            string tulisanCetak = FileCetak.ReadLine();
            while (jumBaris < jumBarisPerHalaman && tulisanCetak != null)
            {
                y = MarginAtas + (jumBaris * JenisFont.GetHeight(e.Graphics));
                jumBaris++;
                tulisanCetak = FileCetak.ReadLine();
            }
            if (tulisanCetak != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }
        public string CetakKePrinter(string pTipe)
        {

            try
            {
                PrintDocument p = new PrintDocument();
                if (pTipe =="tulisan")
                {
                    p.PrintPage += new PrintPageEventHandler(CetakTulisan);
                }
                p.Print();
                FileCetak.Close();
                return "1";
            }
            catch(Exception e)
            {
                return "Proses cetak gagal. Pesan kesalahan = " + e.Message;
            }
        }
        //public static string CetakNota(string pKriteria, string pNilaiKriteria, string PNamaFile)
        //{
        //    try
        //    {
        //        List<NotaJual> listNotaJual = new List<NotaJual>();
        //        //string hasilBaca = NotaJual 
        //    }
        //}
        #endregion
    }
}
