using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// tools -> NuGet Package Manager -> Package Manager Console
// Install-Package Microsoft.Data.SqlClient
// Install-Package System.Data.SqlClient
// use for database
using System.Data.SqlClient;
using System.Data;

namespace QuanLyKinhDoanh
{
    class clsDatabase
    {
        public static SqlConnection con;
        public static bool OpenConnection()
        {
            try
            {
                con = new SqlConnection("Server=baedontcry;Database=QuanLyDien;uid=mylogin;pwd=mylogin");
                //con = new SqlConnection("Server=baedontcry;Database=QuanLyDien;Integrated Security=True;");
                con.Open();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static bool CloseConnection()
        {
            try
            {
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
