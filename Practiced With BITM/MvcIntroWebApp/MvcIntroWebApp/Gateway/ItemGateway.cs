using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using MvcIntroWebApp.Models;

namespace MvcIntroWebApp.Gateway
{
    public class ItemGateway
    {
        private string connectionString = WebConfigurationManager.
                                            ConnectionStrings["itemDBconString"].
                                            ConnectionString;
        public int Save(Item item)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO Item(Name,Price,CategoryId) VALUES(@name,@price,@categoryId)";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@name", item.Name);
            command.Parameters.AddWithValue("@price", item.Price);
            command.Parameters.AddWithValue("@categoryId", item.CategoryId);
            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();
            return rowAffect;
        }

        public Item GetItemById(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Item WHERE Id=@id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            Item item = null;
            reader.Read();
            if (reader.HasRows)
            {

                item = new Item();
                item.Id = Convert.ToInt32(reader["Id"]);
                item.Name = reader["Name"].ToString();
                item.Price = Convert.ToDouble(reader["Price"]);
            }
            connection.Close();
            return item;
        }
    }
}