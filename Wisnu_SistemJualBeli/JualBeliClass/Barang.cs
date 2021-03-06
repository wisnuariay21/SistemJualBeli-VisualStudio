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
using MySql.Data.MySqlClient;

namespace JualBeliClass
{
    public class Barang
    {
        #region DATA MEMBER
        private string kodebarang;
        private string nama;
        private int hargajual;
        private int stok;
        private string barcode;
        private Kategori kategoribarang;
        #endregion

        #region PROPERTIES
        public string KodeBarang
        {
            get { return kodebarang; }
            set
            {     
                    kodebarang = value;
                
                
            }
        }

        public string Nama
        {
            get { return nama; }
            set
            {
                    nama = value;
                
            }
        }

        public int HargaJual
        {
            get { return hargajual; }
            set
            {
                
                    hargajual = value;
               
            }
        }

        public int Stok
        {
            get { return stok; }
            set
            {
                
                    stok = value;
                
            }
        }

        public string Barcode
        {
            get { return barcode; }
            set
            {
                
                    barcode = value;
               
            }
        }

        public Kategori KategoriBarang
	    {
            get { return kategoribarang; }
            set { kategoribarang = value; }
        }
        #endregion

        #region CONSTRUCTOR
        public Barang()
        {
            KodeBarang = "xxxxx";
            Nama = "1234567890123";
            HargaJual = 0;
            Stok = 0;
        }
        public Barang(string xkode, string xnama, int xharga, int xstok, string xbarcode, Kategori xkategori)
        {
            KodeBarang = xkode;
            Nama = xnama;
            HargaJual = xharga;
            Stok = xstok;
            Barcode = xbarcode;
            KategoriBarang = xkategori;
        }
        #endregion

        #region METHOD
        public static string TambahData(Barang PBar)
        {
            string sql = "INSERT INTO barang(KodeBarang,Barcode,Nama,HargaJual,Stock,KodeKategori) VALUES ('" + PBar.KodeBarang + "','" + PBar.Barcode + "','"
                + PBar.Nama.Replace("'", "\\'") + "','" + PBar.HargaJual + "','" + PBar.Stok + "','" + PBar.KategoriBarang.KodeKategori + "')";

            //panggil method JalankanDML
            string hasil = ClassKoneksi.JalankanPerintahDML(sql);
            return hasil;
        }
        public static string UbahData(Barang pBarang)
        {
            string sql = "UPDATE barang SET Barcode = '" + pBarang.Barcode + "', Nama = '" + pBarang.Nama.Replace("'", "\\'") 
                + "', HargaJual = '" + pBarang.HargaJual + "' WHERE KodeBarang = '" + pBarang.KodeBarang + "'";
            string hasil = ClassKoneksi.JalankanPerintahDML(sql);
            return hasil;
        }

        public static string HapusData(Barang pBarang)
        {
            string sql = "DELETE FROM barang WHERE KodeBarang = '" + pBarang.KodeBarang + "'";
            try
            {
                string hasil = ClassKoneksi.JalankanPerintahDML(sql);
                return hasil;
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                {
                    return "Data Tidak Boleh Dihapus Karena Sudah Digunakan";
                }
                else
                {
                    return ex.Message;
                }
            }
            
        }

        public static string BacaData(string kriteria, string nilaikriteria, List<Barang> listhasildata)
        {
            string sql = "";
            if (kriteria == "")
            {
                sql = "SELECT B.KodeBarang, B.Barcode, B.Nama, B.HargaJual, B.Stok, B.KodeKategori, K.Nama AS NamaKategori " +
                    " FROM barang B INNER JOIN kategori K ON B.KodeKategori = K.KodeKategori";
            }
            else
            {
                sql = "SELECT B.KodeBarang, B.Barcode, B.Nama, B.HargaJual, B.Stok, B.KodeKategori, K.Nama AS NamaKategori " +
                    " FROM barang B INNER JOIN kategori K ON B.KodeKategori = K.KodeKategori" +
                    " WHERE " + kriteria + " LIKE '%" + nilaikriteria+"%'";
            }
            try
            {
                MySqlDataReader hasilData = ClassKoneksi.JalankanPerintahQuery(sql);
                listhasildata.Clear();
                while (hasilData.Read() == true)
                {
                    Barang br = new Barang();
                    br.KodeBarang = hasilData.GetValue(0).ToString();
                    br.Barcode = hasilData.GetValue(1).ToString();
                    br.Nama = hasilData.GetValue(2).ToString();
                    br.HargaJual = int.Parse(hasilData.GetValue(3).ToString());
                    br.Stok = int.Parse(hasilData.GetValue(4).ToString());
                    Kategori classKategori = new Kategori(hasilData.GetValue(5).ToString(), hasilData.GetValue(6).ToString());
                    br.KategoriBarang = classKategori;
                    listhasildata.Add(br);
                }
                return "1";
            }
            catch (MySqlException ex)
            {
                return ex.Message + ". Perintah sql : " + sql;
            }
        }
        public static string GenerateKode(string pKodeKategori, out string hasilKode)
        {
            string sql = "SELECT MAX(RIGHT(KodeBarang,3)) FROM barang WHERE KodeKategori= '" + pKodeKategori + "'";
            try
            {
                MySqlDataReader hasilData = ClassKoneksi.JalankanPerintahQuery(sql);
                if (hasilData.Read() == true)
                {
                    int kodeTerbaru = int.Parse(hasilData.GetValue(0).ToString()) + 1;

                    hasilKode = pKodeKategori + kodeTerbaru.ToString().PadLeft(3, '0');
                }
                else
                {
                    hasilKode = pKodeKategori + "001";
                }
                return "1";
            }
            catch (MySqlException ex)
            {
                hasilKode = "";
                return ex.Message;
            }
        }
        public static string UbahStokTerjual(string pKodeBarang, int pJumlahTerjual)
        {
            string sql = "UPDATE barang SET Stok = Stok - " + pJumlahTerjual +
                " WHERE KodeBarang = '" + pKodeBarang + "','";
            string hasil = ClassKoneksi.JalankanPerintahDML(sql);
            return hasil;
        }
        #endregion
    }
}
    


