using ProjectAvonale.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjectAvonale.Data
{
    public class DbConnection
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rafas\source\repos\ProjectAvonale\DAO\Database1.mdf;Integrated Security=True";

        public DataTable CarregarFavoritos()
        {
            DataTable dtFavoritos = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connectionString;
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select * from TbFavoritos", conn);
                    // DataSet ds = new DataSet();
                    da.Fill(dtFavoritos);
                    conn.Close();
                    return dtFavoritos;
                }

            }
            catch (Exception ex) { return null; }
        }
        public void InserirFavorito(RepositorioModel model)
        {
            try
            {


                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = connectionString;

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = @"INSERT INTO TbFavoritos
                                           (id
                                            ,name 
                                            ,full_name 
                                            ,html_url 
                                            ,description 
                                            ,forks_url
                                            ,watchers_count
                                            ,updated_at
                                            ,default_branch)
                                     VALUES
                                           (@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8,@param9)";
                        cmd.Parameters.AddWithValue("@param1", model.id);
                        cmd.Parameters.AddWithValue("@param2", model.name);
                        cmd.Parameters.AddWithValue("@param3", model.full_name);
                        cmd.Parameters.AddWithValue("@param4", model.html_url);
                        cmd.Parameters.AddWithValue("@param5", model.description);
                        cmd.Parameters.AddWithValue("@param6", model.forks_url);
                        cmd.Parameters.AddWithValue("@param7", model.watchers_count);
                        cmd.Parameters.AddWithValue("@param8", model.updated_at);
                        cmd.Parameters.AddWithValue("@param9", model.default_branch);

                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex) { }
                    }
                }
            }
            catch (Exception ex) { }
        }

        //public class TbFavoritos
        //{
        //    public string id = "id";
        //    public string name = "name";
        //    public string full_name = "full_name";
        //    public string html_url = "html_url";
        //    public string description = "description";
        //    public string forks_url = "forks_url";
        //    public string watchers_count = "watchers_count";
        //    public string updated_at = "updated_at";
        //    public string default_branch = "default_branch";
        //}
    }
}
