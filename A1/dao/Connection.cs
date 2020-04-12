using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1.dao
{
    public class Connection
    {
        public static SqlConnection connect()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-CV43IN8\\SQLEXPRESS;Initial Catalog=a1;Integrated Security=True";
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public static Boolean crud(SqlCommand cmd)
        {
            try
            {
                SqlConnection con = connect();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                return false;
            }
        }

        public static SqlDataReader select(SqlCommand cmd)
        {
            try
            {
                SqlConnection con = connect();
                cmd.Connection = con;
                SqlDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                return dr;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                return null;
            }
        }

        internal static object search(string v)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = v;
            SqlDataReader dr = Connection.select(cmd);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, Connection.connect());
            da.Fill(dt);
            return dt;
        }
    }
}
