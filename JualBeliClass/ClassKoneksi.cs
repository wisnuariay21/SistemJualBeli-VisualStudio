
using MySql.Data.MySqlClient;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JualBeliClass
{
    public class ClassKoneksi
    {
        #region DATA MEMBER
        private string namaServer;
        private string namaDatabase;
        private string username;
        private string password;
        private MySqlConnection koneksiDB;
        #endregion

        #region PROPERTIES
        public string NamaServer
        {
            get
            {
                return namaServer;
            }

            set
            {
                namaServer = value;
            }
        }

        public string NamaDatabase
        {
            get
            {
                return namaDatabase;
            }

            set
            {
                namaDatabase = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            private get
            {
                return password; //hanya dibaca didalam class
            }

            set
            {
                password = value;
            }
        }

        public MySqlConnection KoneksiDB
        {
            get
            {
                return koneksiDB;
            }

            private set
            {
                koneksiDB = value; //hanya di set didalam class
            }
        }
        #endregion

        #region METHOD
        public string Connect()
        {
            try
            {
                //cek status connection open
                if(KoneksiDB.State == System.Data.ConnectionState.Open)
                {
                    KoneksiDB.Close();
                }
                KoneksiDB.Open();
                return "1"; //artinya sukses connect
            }
            catch (MySqlException e)
            {
                return "Koneksi gagal. Pesan Kesalahan : " + e.Message; //artinya gagal connect
            }
        }

        public void UpdateAppConfig(string connectionString)
        {
            // buka konfigurasi App.Config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Set App.Config pada nama tag koneksi dengan string koneksi yang dimasukkan pengguna
            config.ConnectionStrings.ConnectionStrings["KonfigurasiKoneksi"].ConnectionString = connectionString;

            // Simpan App.Config yang telah diperbarui
            config.Save(ConfigurationSaveMode.Modified, true);

            // Reload App.Config dengan pengaturan yang baru
            ConfigurationManager.RefreshSection("connectionStrings");
        }
        public static string JalankanPerintahDML(string pSql)
        {
            try
            {
                ClassKoneksi k = new ClassKoneksi();
                MySqlCommand c = new MySqlCommand(pSql, k.KoneksiDB);
                c.ExecuteNonQuery();
                return "1";
            }
            catch(MySqlException ex)
            {
                return ex.Message;
            }
        }



        public static MySqlDataReader JalankanPerintahQuery(string pSql)
        {
            ClassKoneksi k = new ClassKoneksi();
            MySqlCommand c = new MySqlCommand(pSql, k.KoneksiDB);
            //Menjalankan perintah MysqlCommand

            MySqlDataReader hasilData = c.ExecuteReader();
            return hasilData;
        }

        public static string GetNamaServer()
        {
            MySqlConnection c = new MySqlConnection();
            c.ConnectionString = ConfigurationManager.ConnectionStrings["KonfigurasiKoneksi"].ConnectionString;
            return c.DataSource;
        }

        public static string GetNamaDatabase()
        {
            MySqlConnection c = new MySqlConnection();
            c.ConnectionString = ConfigurationManager.ConnectionStrings["KonfigurasiKoneksi"].ConnectionString;
            return c.Database;
        }

        #endregion

        #region CONSTRUCTOR

        public ClassKoneksi()
        { 
            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = ConfigurationManager.ConnectionStrings["KonfigurasiKoneksi"].ConnectionString;
            string konek = Connect();
        }

        public ClassKoneksi(string server, string database, string username, string password)
        {
            NamaServer = server;
            NamaDatabase = database;
            Username = username;
            Password = password;

            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = "server=" + NamaServer + "; database=" + NamaDatabase + "; username=" + Username + "; password=" + Password;
            UpdateAppConfig(KoneksiDB.ConnectionString);
            string konek = Connect();
            

        }

        #endregion
    }
}
