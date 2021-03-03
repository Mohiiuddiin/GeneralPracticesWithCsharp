using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using MvcIntroWebApp.Models;

namespace MvcIntroWebApp.Gateway
{
    public class CategoryGateway
    {
        private string connectionString = WebConfigurationManager.
                                           ConnectionStrings["itemDBconString"].
                                           ConnectionString;
        public List<Category> GetAllCategories()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(query, connection);
            
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Category> categories = new List<Category>();
            while (reader.Read())
            {
                Category category = new Category();
                category.Id = Convert.ToInt32(reader["Id"]);
                category.Name = reader["Name"].ToString();
                categories.Add(category);

            }
            connection.Close();
            return categories;
        }
    }
}