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


namespace A1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnCategorySave_Click(object sender, EventArgs e)
        {
            CategoryDAO categoryDAO = new CategoryDAO();
            Category category = new Category();

            category.Name = tbCategoryName.Text;

            categoryDAO.insert(category);
            dataGridCategory.DataSource = CategoryDAO.returnDataSource();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'a1DataSet.withdrawal' table. You can move, or remove it, as needed.
            this.withdrawalTableAdapter.Fill(this.a1DataSet.withdrawal);
            // TODO: This line of code loads data into the 'a1DataSet.entry' table. You can move, or remove it, as needed.
            this.entryTableAdapter.Fill(this.a1DataSet.entry);
            // TODO: This line of code loads data into the 'a1DataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.a1DataSet.product);
            // TODO: This line of code loads data into the 'a1DataSet.category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.a1DataSet.category);
            // TODO: This line of code loads data into the 'a1DataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.a1DataSet.user);

        }

        private void btnUserSave_Click(object sender, EventArgs e)
        {
            UserDAO userDAO = new UserDAO();
            User user = new User();

            user.Name = tbUserName.Text;
            user.Cpf = tbUserCPF.Text;
            user.Email = tbUserEmail.Text;
            user.Password = tbUserPassword.Text;
            user.Telephone = tbUserPassword.Text;
            user.TypeUser = (TypeUser)cbUserType.SelectedValue;

            userDAO.insert(user);
            btnUserClear_Click(sender, e);

        }

        private void btnUserClear_Click(object sender, EventArgs e)
        {

            tbUserName.Text = "";
            tbUserCPF.Text = "";
            tbUserEmail.Text = "";
            tbUserPassword.Text = "";
            tbUserPassword.Text = "";
            cbUserType.SelectedIndex = 0;

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void tabPageSubCategory_Click(object sender, EventArgs e)
        {

        }
    }
}
