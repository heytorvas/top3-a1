﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLoginSignIn_Click(object sender, EventArgs e)
        {
            if(tbLoginEmail.Text == "root" && tbLoginPassword.Text == "root")
            {
                Main form2 = new Main();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario não encontrado!");
            }

        }

        private void btnLoginClear_Click(object sender, EventArgs e)
        {
            tbLoginEmail.Text = "";
            tbLoginPassword.Text = "";
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
