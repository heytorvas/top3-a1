﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A1.model;
using A1.dao;

namespace A1.dao
{
    public class ProductDAO
    {
        public Product insert(Product product)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO product(image_id, name, label, quantity_available, price) output INSERTED.id values (@image_id, @name, @label, @quantity_available, @price)";
            cmd.Parameters.AddWithValue("@image_id", product.Image.Id);
            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@label", product.Label);
            cmd.Parameters.AddWithValue("@quantity_available", product.QuantityAvailable);
            cmd.Parameters.AddWithValue("@price", product.Price);

            if (Connection.crud(cmd))
                foreach (Subcategory subcategory in product.Subcategories)
                {
                    SubcategoryDAO subcategoryDAO = new SubcategoryDAO();

                    cmd.CommandText = "INSERT INTO product_subcategory(subcategory_id, product_id)" +
                        "output INSERTED.id values ("+ subcategoryDAO.insert(subcategory).Id + "," +
                        product.Id+")";
                }
                return product;
            return null;
        }

        public Product update(Product product)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE product set image_id = @image_id, name = @name, label = @label, quantity_available = @quantity_available, price = price, id = @id where id = @id";
            cmd.Parameters.AddWithValue("@id", product.Id);
            cmd.Parameters.AddWithValue("@image_id", product.Image.Id);
            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@label", product.Label);
            cmd.Parameters.AddWithValue("@quantity_available", product.QuantityAvailable);
            cmd.Parameters.AddWithValue("@price", product.Price);
            if (Connection.crud(cmd))
                return product;
            return null;
        }

        public void delete(Product product)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM product WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", product.Id);
            Connection.crud(cmd);
        }

        public static Product findById(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM product WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = Connection.select(cmd);

            Product product = new Product();
            if (dr.HasRows)
            {
                dr.Read();
                product.Id = (int)dr["id"];
                product.Image.Id = (int)dr["image_id"];
                product.Name = dr["name"].ToString();
                product.Label = dr["label"].ToString();
                product.QuantityAvailable = (int)dr["quantity_available"];
                product.Price = (float)dr["price"];

            }
            else
                product = null;

            return product;
        }

        public List<Product> findAll()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM product";
            SqlDataReader dr = Connection.select(cmd);
            List<Product> products = new List<Product>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dr.Read();
                    Product product = new Product();
                    product.Id = (int)dr["id"];
                    product.Image.Id = (int)dr["image_id"];
                    product.Name = dr["name"].ToString();
                    product.Label = dr["label"].ToString();
                    product.QuantityAvailable = (int)dr["quantity_available"];
                    product.Price = (float)dr["price"];
                    products.Add(product);
                }
            }
            else
                products = null;

            return products;
        }

        public static DataTable returnDataSource()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM product";
            SqlDataReader dr = Connection.select(cmd);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, Connection.connect());
            da.Fill(dt);

            return dt;
        }
    }
}
