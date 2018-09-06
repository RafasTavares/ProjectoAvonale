using System;
using System.Collections.Generic;
using System.Data;

namespace DAO.services
{
    public class DbConnection
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rafas\source\repos\ProjectAvonale\DAO\Database1.mdf;Integrated Security=True";



       

        public static List<TbFavoritos> CarregarFavoritos()
        {
            List<TbFavoritos> favoritos = new List<TbFavoritos>();

            try
            {
               
            }
            catch (Exception ex) { return null; }

            return favoritos;
        }

        public class TbFavoritos
        {
            public string id = "id";
            public string name = "name";
            public string full_name = "full_name";
            public string html_url = "html_url";
            public string description = "description";
            public string forks_url = "forks_url";
            public string watchers_count = "watchers_count";
            public string updated_at = "updated_at";
            public string default_branch = "default_branch";
        }
    }
}
