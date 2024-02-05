using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhoHangXuatNhapKhau.Model
{
    public class DB_Connect
    {
        private static DB_Connect instance;
        public static DB_Connect Instance
        {
            get { if (instance == null) instance = new DB_Connect(); return DB_Connect.instance; }
            private set { DB_Connect.instance = value; }
        }
        private DB_Connect() { }
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }
        public static string GetConnectionString()
        {
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder()
            {
                InitialCatalog = "SQL_QuanLyKhoHangXuatNhapKhau",
                //DataSource = "(local)",
                DataSource = @"LAPTOP-TQ8KSJHP\SQLEXPRESS",
                IntegratedSecurity = true,
                MultipleActiveResultSets = true,
                ConnectTimeout = 0,
                MaxPoolSize = 500,
                TrustServerCertificate = true
            };
            return stringBuilder.ConnectionString;
        }
        public static DataTable Load(string sql)
        {
            DataTable dt = new DataTable();
            string conn_string = GetConnectionString();
            SqlConnection sqlConnect = new SqlConnection(conn_string);
            sqlConnect.Open();
            // Sử dụng để lưu trữ và thực thi câu lệnh sql
            SqlCommand cmd = new SqlCommand(sql, sqlConnect);
            cmd.CommandType = CommandType.Text;
            // Cầu nối giữa dataset và cơ sở dữ liệu
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //Điền thông tin
            da.Fill(dt);
            return dt;
        }
        public static bool ExecuteNonQuery(string sql)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }
    }
}
