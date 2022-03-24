using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tugas2PABD
{
    class Program
    {

        static void Main(string[] args)
        {
            new Program().InsertData();
        }
        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=NITRO-AN715;Database=ExerciseSatu;User ID=sa;Password=123");
                con.Open();

                SqlCommand cm = new SqlCommand("INSERT INTO Owner (id_Owner, Nama, No_Telpon, id_Klien) VALUES ('224','Alek','0816253627','301')" +
                    "INSERT INTO Owner (id_Owner, Nama, No_Telpon, id_Klien) VALUES ('225','Dimas','0834256748','302')" + "INSERT INTO Owner (id_Owner, Nama, No_Telpon, id_Klien) VALUES ('226','Ihsan','0845398746','303')" +
                    "INSERT INTO Owner (id_Owner, Nama, No_Telpon, id_Klien) VALUES ('227','Paldi','0845362745','304')" + "INSERT INTO Owner (id_Owner, Nama, No_Telpon, id_Klien) VALUES ('228','Akbar','0856748392','305')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data, " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}