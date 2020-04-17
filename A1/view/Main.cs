using A1.dao;
using A1.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace A1
{
    public partial class Main : Form
    {
        User user = new User();
        User userUpdate = new User();

        public int idUser;

        public Main()
        {
            InitializeComponent();

            DataTable dtSubCategory = SubcategoryDAO.returnDataSource();
            for (int i = 0; i < dtSubCategory.Rows.Count; i++)
                checkedListBoxSubcategory.Items.Add(dtSubCategory.Rows[i]["name"].ToString());
            
        }

        private void btnCategorySave_Click(object sender, EventArgs e)
        {
            CategoryDAO categoryDAO = new CategoryDAO();
            Category category = new Category();

            category.Name = tbCategoryName.Text;

            categoryDAO.insert(category);
            dataGridCategory.DataSource = CategoryDAO.returnDataSource();
            btnCategoryClear_Click(sender, e);

        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'a1DataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.a1DataSet.product);
            // TODO: This line of code loads data into the 'a1DataSet.subcategory' table. You can move, or remove it, as needed.
            this.subcategoryTableAdapter.Fill(this.a1DataSet.subcategory);
            // TODO: This line of code loads data into the 'a1DataSet.withdrawal' table. You can move, or remove it, as needed.
            this.withdrawalTableAdapter.Fill(this.a1DataSet.withdrawal);
            // TODO: This line of code loads data into the 'a1DataSet.entry' table. You can move, or remove it, as needed.
            this.entryTableAdapter.Fill(this.a1DataSet.entry);
            // TODO: This line of code loads data into the 'a1DataSet.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.a1DataSet.category);
            // TODO: This line of code loads data into the 'a1DataSet.sysuser' table. You can move, or remove it, as needed.
            this.sysuserTableAdapter.Fill(this.a1DataSet.sysuser);
            // TODO: This line of code loads data into the 'a1DataSet.subcategory' table. You can move, or remove it, as needed.
            this.subcategoryTableAdapter.Fill(this.a1DataSet.subcategory);
            // TODO: This line of code loads data into the 'a1DataSet.withdrawal' table. You can move, or remove it, as needed.
            this.withdrawalTableAdapter.Fill(this.a1DataSet.withdrawal);
            // TODO: This line of code loads data into the 'a1DataSet.entry' table. You can move, or remove it, as needed.
            this.entryTableAdapter.Fill(this.a1DataSet.entry);
            // TODO: This line of code loads data into the 'a1DataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.a1DataSet.product);
            // TODO: This line of code loads data into the 'a1DataSet.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.a1DataSet.category);
            // TODO: This line of code loads data into the 'a1DataSet.user' table. You can move, or remove it, as needed.

        }

        private void btnUserSave_Click(object sender, EventArgs e)
        {
            UserDAO userDAO = new UserDAO();

            user.Name = tbUserName.Text;
            user.Cpf = tbUserCPF.Text;
            user.Email = tbUserEmail.Text;
            user.Password = tbUserPassword.Text;
            user.Telephone = tbUserPassword.Text;

            userDAO.insert(user);
            dataGridUser.DataSource = UserDAO.returnDataSource();
            btnUserClear_Click(sender, e);

        }

        private void btnUserClear_Click(object sender, EventArgs e)
        {
            tbUserName.Text = "";
            tbUserCPF.Text = "";
            tbUserEmail.Text = "";
            tbUserPassword.Text = "";
            tbUserTelephone.Text = "";
            cbUserType.Text = "";
        }

        private void btnCategoryClear_Click(object sender, EventArgs e)
        {
            tbCategoryName.Text = "";
        }

        private void btnSubCategorySave_Click(object sender, EventArgs e)
        {
            Subcategory subcategory = new Subcategory();
            SubcategoryDAO subcategoryDAO = new SubcategoryDAO();
            if (subcategory.Category == null)
                subcategory.Category = new Category();

            subcategory.Name = tbSubCategoryName.Text;
            subcategory.Category.Id = (int)cbSubcategoryCategory.SelectedValue;

            subcategoryDAO.insert(subcategory);
            dataGridSubcategory.DataSource = SubcategoryDAO.returnDataSource();
            btnSubCategoryClear_Click(sender, e);

        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {
            ProductDAO productDAO = new ProductDAO();
            Product product = new Product();
            
            if (product.Subcategories == null)
                product.Subcategories = new List<Subcategory>();

            foreach (string word in checkedListBoxSubcategory.CheckedItems)
            {
                DataTable returnDataTableSelect = SubcategoryDAO.returnDataSourceCheckbox(word);
                for (int i = 0; i < returnDataTableSelect.Rows.Count; i++)
                {
                    Subcategory sub = new Subcategory();
                    sub.Id = (int)returnDataTableSelect.Rows[i]["id"];
                    sub.Name = returnDataTableSelect.Rows[i]["name"].ToString();
                    if (sub.Category == null)
                        sub.Category = new Category();
                    sub.Category.Id = (int)returnDataTableSelect.Rows[i]["category_id"];
                    product.Subcategories.Add(sub);
                }
            }

            product.Name = tbProductName.Text;
            product.Label = tbProductLabel.Text;
            product.Price = float.Parse(tbProductPrice.Text.Trim());
            product.QuantityAvailable = int.Parse(tbProductQuantityAvailable.Text.Trim());

            int product_id = productDAO.insertReturned(product);

            foreach (Subcategory sub1 in product.Subcategories)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO product_subcategory(subcategory_id, product_id) values (@subcategory_id, @product_id)";
                cmd.Parameters.AddWithValue("@subcategory_id", sub1.Id);
                cmd.Parameters.AddWithValue("@product_id", product_id);
                Connection.crud(cmd);
            }

            dataGridProduct.DataSource = ProductDAO.returnDataSource();
            btnProductClear_Click(sender, e);
        }

        private void cbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            user.TypeUser = cbUserType.Text;
            userUpdate.TypeUser = cbUserType.Text;
        }

        private void btnSubCategoryClear_Click(object sender, EventArgs e)
        {
            tbSubCategoryName.Text = "";
            cbSubcategoryCategory.Text = "";
        }

        private void btnProductClear_Click(object sender, EventArgs e)
        {
            tbProductName.Text = "";
            tbProductLabel.Text = "";
            tbProductPrice.Text = "";
            tbProductQuantityAvailable.Text = "";
            while (checkedListBoxSubcategory.CheckedIndices.Count > 0)
            {
                checkedListBoxSubcategory.SetItemChecked(checkedListBoxSubcategory.CheckedIndices[0], false);
            }
        }

        private void dataGridUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idUser = (int) dataGridUser.CurrentRow.Cells[0].Value;
            tbUserName.Text = dataGridUser.CurrentRow.Cells[1].Value.ToString();
            tbUserCPF.Text = dataGridUser.CurrentRow.Cells[2].Value.ToString();
            tbUserEmail.Text = dataGridUser.CurrentRow.Cells[3].Value.ToString();
            tbUserPassword.Text = dataGridUser.CurrentRow.Cells[4].Value.ToString();
            tbUserTelephone.Text = dataGridUser.CurrentRow.Cells[5].Value.ToString();
            cbUserType.Text = dataGridUser.CurrentRow.Cells[6].Value.ToString();
        }


        private void btnUserUpdate_Click_1(object sender, EventArgs e)
        {
            UserDAO userDAO = new UserDAO();
            userUpdate.Id = idUser;
            userUpdate.Name = tbUserName.Text;
            userUpdate.Cpf = tbUserCPF.Text;
            userUpdate.Email = tbUserEmail.Text;
            userUpdate.Password = tbUserPassword.Text;
            userUpdate.Telephone = tbUserPassword.Text;

            userDAO.update(userUpdate);
            dataGridUser.DataSource = UserDAO.returnDataSource();
            btnUserClear_Click(sender, e);

        }
    }
}
