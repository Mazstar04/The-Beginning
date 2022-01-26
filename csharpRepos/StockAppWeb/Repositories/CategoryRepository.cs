using MySql.Data.MySqlClient;
using StockAppWeb.Models;
using System;
using System.Collections.Generic;

namespace StockAppWeb.Repositories
{
 
    public class CategoryRepository
    {
        MySqlConnection conn;
        public List<Category> Categories = new List<Category>();

        public CategoryRepository(MySqlConnection connection)
        {
            conn = connection;

        }
        public List<Category> ListLatestCategories()
        {
            List<Category> Categories = new List<Category>();
            try
            {
                conn.Open();
                string categoryQuery = "Select * from categories ORDER BY created_at DESC LIMIT 5";
                MySqlCommand command = new MySqlCommand(categoryQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        DateTime created_at = reader.GetDateTime(2);
                        Category category = new Category(id, name, created_at);
                        Categories.Add(category);

                    }
                }
                reader.Close();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Categories;
        }
        public List<Category> ListAllCategories()
        {
            List<Category> Categories = new List<Category>();
            try
            {
                conn.Open();
                string categoryQuery = "Select id, name, created_at from categories";
                MySqlCommand command = new MySqlCommand(categoryQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        DateTime created_at = reader.GetDateTime(2);
                        Category category = new Category(id, name, created_at);
                        Categories.Add(category);

                    }
                }
                reader.Close();
                conn.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Categories;
        }
        public Category FindCategory(int id)
        {
            Category category = null;
            try
            {
                conn.Open();
                string categoryQuery = "Select id, name, created_at from categories where id = '" + id + "'";
                MySqlCommand command = new MySqlCommand(categoryQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    {
                        string name = reader.GetString(1);
                        DateTime created_at = reader.GetDateTime(2);
                        category = new Category(id, name, created_at);
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            return category;

        }

        public bool AddCategory(int id, string name, DateTime created_at)
        {
            try
            {
                conn.Open();
                string addCategoryQuery = "Insert into categories (id, name, created_at)values ('" + id + "', '" + name + "', '" + created_at.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                MySqlCommand command = new MySqlCommand(addCategoryQuery, conn);
                int Count = command.ExecuteNonQuery();
                if (Count > 0)
                {
                    conn.Close();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            return false;
        }
        public bool UpdateCategory(int id, string name)
        {
            var category = FindCategory(id);
            if (category == null)
            {
                Console.WriteLine($"category with {id} does not exist");
            }
            try
            {
                conn.Open();
                string updateCategoryQuery = "update categories set name ='" + name + "' where id = '" + id + "'";
                MySqlCommand command = new MySqlCommand(updateCategoryQuery, conn);
                int Count = command.ExecuteNonQuery();
                if (Count > 0)
                {
                    conn.Close();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            return false;
        }

        public bool DeleteCategory(int id)
        {
            var category = FindCategory(id);
            try
            {
                conn.Open();
                string deleteCategoryQuery = "delete from categories where id = '" + id + "'";
                MySqlCommand command = new MySqlCommand(deleteCategoryQuery, conn);
                int Count = command.ExecuteNonQuery();
                if (Count > 0)
                {
                    conn.Close();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
            return false;
        }
    }
}


