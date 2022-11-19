using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace WebenionBrowser.Classes.Database
{
    public class databaseConfig
    {

        public static SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\WebonionWebBrowser.mdf;Integrated Security=True");
        public class HistorySettings
        {
            public static void Add(string title, string address, string datetime)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insert into WebonionHistory values(@siteAdi, @siteURLI, @siteTarih)", connection);
                command.Parameters.AddWithValue("@siteAdi", title);
                command.Parameters.AddWithValue("@siteURLI", address);
                command.Parameters.AddWithValue("@siteTarih", datetime);
                command.ExecuteNonQuery();
                connection.Close();
            }

            public static void AllClear()
            {
                connection.Open();
                SqlCommand command = new SqlCommand("truncate table WebonionHistory", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }

            public static void KayıtSil(int numara)
            {
                SqlCommand command = new SqlCommand("DELETE FROM WebonionHistory WHERE id=@numara", connection);
                command.Parameters.AddWithValue("@numara", numara);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        } 
        public class DowloadSettings
        {
            public static void Add(string name, string path, string size, string URL, string dowloadDate, string complete)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insert into WebonionDowload values(@fileName, @yol, @size, @url, @date, @complete)", connection);
                command.Parameters.AddWithValue("@fileName", name);
                command.Parameters.AddWithValue("@yol", path);
                command.Parameters.AddWithValue("@size", size);
                command.Parameters.AddWithValue("@url", URL);
                command.Parameters.AddWithValue("@date", dowloadDate);
                command.Parameters.AddWithValue("@complete", complete);
                command.ExecuteNonQuery();
                connection.Close();
            }

            public static void IndirilenSil(int numara)
            {
                SqlCommand command = new SqlCommand("DELETE FROM WebonionDowload WHERE id=@numara", connection);
                command.Parameters.AddWithValue("@numara", numara);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public class FavoritesSettings
        {
            public static int i = 1;
            public static void Add(string _url, string siteName)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("insert into WebonionFavorites values(@url, @siteName, @number)", connection);
                command.Parameters.AddWithValue("@url", _url);
                command.Parameters.AddWithValue("@siteName", siteName);
                command.Parameters.AddWithValue("@number", i);
                command.ExecuteNonQuery();
                connection.Close();
                i++;
            }

            public static void Kaldir(string url)
            {
                SqlCommand command = new SqlCommand("DELETE FROM WebonionFavorites WHERE URl=@url", connection);
                command.Parameters.AddWithValue("@url", url);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                i--;
            }
        }
    }
}
