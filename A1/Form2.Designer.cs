namespace A1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCategory = new System.Windows.Forms.TabPage();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbUserTelephone = new System.Windows.Forms.TextBox();
            this.tbUserPassword = new System.Windows.Forms.TextBox();
            this.tbUserEmail = new System.Windows.Forms.TextBox();
            this.tbUserCPF = new System.Windows.Forms.TextBox();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUserSave = new System.Windows.Forms.Button();
            this.btnUserUpdate = new System.Windows.Forms.Button();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserClear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCategoryClear = new System.Windows.Forms.Button();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.btnCategoryUpdate = new System.Windows.Forms.Button();
            this.btnCategorySave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCategoryName = new System.Windows.Forms.TextBox();
            this.tabPageSubCategory = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSubCategoryName = new System.Windows.Forms.TextBox();
            this.btnSubCategoryClear = new System.Windows.Forms.Button();
            this.btnSubCategoryDelete = new System.Windows.Forms.Button();
            this.btnSubCategoryUpdate = new System.Windows.Forms.Button();
            this.btnSubCategorySave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbProductLabel = new System.Windows.Forms.TextBox();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.tbProductQuantityAvailable = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageCategory.SuspendLayout();
            this.tabPageUser.SuspendLayout();
            this.tabPageSubCategory.SuspendLayout();
            this.tabPageProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "PATRIOTS STORE";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageUser);
            this.tabControl1.Controls.Add(this.tabPageCategory);
            this.tabControl1.Controls.Add(this.tabPageSubCategory);
            this.tabControl1.Controls.Add(this.tabPageProduct);
            this.tabControl1.Location = new System.Drawing.Point(12, 54);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 384);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPageCategory
            // 
            this.tabPageCategory.Controls.Add(this.label9);
            this.tabPageCategory.Controls.Add(this.tbCategoryName);
            this.tabPageCategory.Controls.Add(this.btnCategoryClear);
            this.tabPageCategory.Controls.Add(this.btnCategoryDelete);
            this.tabPageCategory.Controls.Add(this.btnCategoryUpdate);
            this.tabPageCategory.Controls.Add(this.btnCategorySave);
            this.tabPageCategory.Location = new System.Drawing.Point(4, 22);
            this.tabPageCategory.Name = "tabPageCategory";
            this.tabPageCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategory.Size = new System.Drawing.Size(768, 358);
            this.tabPageCategory.TabIndex = 1;
            this.tabPageCategory.Text = "CATEGORY";
            this.tabPageCategory.UseVisualStyleBackColor = true;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(22, 27);
            this.tbUserName.Multiline = true;
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(240, 28);
            this.tbUserName.TabIndex = 6;
            this.tbUserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbUserTelephone
            // 
            this.tbUserTelephone.Location = new System.Drawing.Point(22, 141);
            this.tbUserTelephone.Multiline = true;
            this.tbUserTelephone.Name = "tbUserTelephone";
            this.tbUserTelephone.Size = new System.Drawing.Size(240, 28);
            this.tbUserTelephone.TabIndex = 7;
            // 
            // tbUserPassword
            // 
            this.tbUserPassword.Location = new System.Drawing.Point(314, 84);
            this.tbUserPassword.Multiline = true;
            this.tbUserPassword.Name = "tbUserPassword";
            this.tbUserPassword.Size = new System.Drawing.Size(240, 28);
            this.tbUserPassword.TabIndex = 8;
            this.tbUserPassword.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tbUserEmail
            // 
            this.tbUserEmail.Location = new System.Drawing.Point(22, 84);
            this.tbUserEmail.Multiline = true;
            this.tbUserEmail.Name = "tbUserEmail";
            this.tbUserEmail.Size = new System.Drawing.Size(240, 28);
            this.tbUserEmail.TabIndex = 9;
            // 
            // tbUserCPF
            // 
            this.tbUserCPF.Location = new System.Drawing.Point(314, 27);
            this.tbUserCPF.Multiline = true;
            this.tbUserCPF.Name = "tbUserCPF";
            this.tbUserCPF.Size = new System.Drawing.Size(240, 28);
            this.tbUserCPF.TabIndex = 10;
            this.tbUserCPF.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // tabPageUser
            // 
            this.tabPageUser.Controls.Add(this.label8);
            this.tabPageUser.Controls.Add(this.btnUserClear);
            this.tabPageUser.Controls.Add(this.btnUserDelete);
            this.tabPageUser.Controls.Add(this.btnUserUpdate);
            this.tabPageUser.Controls.Add(this.btnUserSave);
            this.tabPageUser.Controls.Add(this.label7);
            this.tabPageUser.Controls.Add(this.label6);
            this.tabPageUser.Controls.Add(this.label5);
            this.tabPageUser.Controls.Add(this.label4);
            this.tabPageUser.Controls.Add(this.label3);
            this.tabPageUser.Controls.Add(this.label2);
            this.tabPageUser.Controls.Add(this.tbUserCPF);
            this.tabPageUser.Controls.Add(this.tbUserEmail);
            this.tabPageUser.Controls.Add(this.tbUserPassword);
            this.tabPageUser.Controls.Add(this.tbUserTelephone);
            this.tabPageUser.Controls.Add(this.tbUserName);
            this.tabPageUser.Location = new System.Drawing.Point(4, 22);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUser.Size = new System.Drawing.Size(768, 358);
            this.tabPageUser.TabIndex = 0;
            this.tabPageUser.Text = "USER";
            this.tabPageUser.UseVisualStyleBackColor = true;
            this.tabPageUser.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Telephone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "CPF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "SELECT LIST ENUM";
            // 
            // btnUserSave
            // 
            this.btnUserSave.Location = new System.Drawing.Point(643, 11);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.Size = new System.Drawing.Size(75, 23);
            this.btnUserSave.TabIndex = 17;
            this.btnUserSave.Text = "SAVE";
            this.btnUserSave.UseVisualStyleBackColor = true;
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.Location = new System.Drawing.Point(643, 58);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUserUpdate.TabIndex = 18;
            this.btnUserUpdate.Text = "UPDATE";
            this.btnUserUpdate.UseVisualStyleBackColor = true;
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Location = new System.Drawing.Point(643, 102);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(75, 23);
            this.btnUserDelete.TabIndex = 19;
            this.btnUserDelete.Text = "DELETE";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            // 
            // btnUserClear
            // 
            this.btnUserClear.Location = new System.Drawing.Point(643, 146);
            this.btnUserClear.Name = "btnUserClear";
            this.btnUserClear.Size = new System.Drawing.Size(75, 23);
            this.btnUserClear.TabIndex = 20;
            this.btnUserClear.Text = "CLEAR";
            this.btnUserClear.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(311, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Type:";
            // 
            // btnCategoryClear
            // 
            this.btnCategoryClear.Location = new System.Drawing.Point(654, 29);
            this.btnCategoryClear.Name = "btnCategoryClear";
            this.btnCategoryClear.Size = new System.Drawing.Size(75, 23);
            this.btnCategoryClear.TabIndex = 24;
            this.btnCategoryClear.Text = "CLEAR";
            this.btnCategoryClear.UseVisualStyleBackColor = true;
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.Location = new System.Drawing.Point(553, 29);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCategoryDelete.TabIndex = 23;
            this.btnCategoryDelete.Text = "DELETE";
            this.btnCategoryDelete.UseVisualStyleBackColor = true;
            // 
            // btnCategoryUpdate
            // 
            this.btnCategoryUpdate.Location = new System.Drawing.Point(450, 29);
            this.btnCategoryUpdate.Name = "btnCategoryUpdate";
            this.btnCategoryUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCategoryUpdate.TabIndex = 22;
            this.btnCategoryUpdate.Text = "UPDATE";
            this.btnCategoryUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCategorySave
            // 
            this.btnCategorySave.Location = new System.Drawing.Point(341, 29);
            this.btnCategorySave.Name = "btnCategorySave";
            this.btnCategorySave.Size = new System.Drawing.Size(75, 23);
            this.btnCategorySave.TabIndex = 21;
            this.btnCategorySave.Text = "SAVE";
            this.btnCategorySave.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Name:";
            // 
            // tbCategoryName
            // 
            this.tbCategoryName.Location = new System.Drawing.Point(21, 29);
            this.tbCategoryName.Multiline = true;
            this.tbCategoryName.Name = "tbCategoryName";
            this.tbCategoryName.Size = new System.Drawing.Size(240, 28);
            this.tbCategoryName.TabIndex = 25;
            this.tbCategoryName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // tabPageSubCategory
            // 
            this.tabPageSubCategory.Controls.Add(this.label12);
            this.tabPageSubCategory.Controls.Add(this.label11);
            this.tabPageSubCategory.Controls.Add(this.label10);
            this.tabPageSubCategory.Controls.Add(this.btnSubCategoryName);
            this.tabPageSubCategory.Controls.Add(this.btnSubCategoryClear);
            this.tabPageSubCategory.Controls.Add(this.btnSubCategoryDelete);
            this.tabPageSubCategory.Controls.Add(this.btnSubCategoryUpdate);
            this.tabPageSubCategory.Controls.Add(this.btnSubCategorySave);
            this.tabPageSubCategory.Location = new System.Drawing.Point(4, 22);
            this.tabPageSubCategory.Name = "tabPageSubCategory";
            this.tabPageSubCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubCategory.Size = new System.Drawing.Size(768, 358);
            this.tabPageSubCategory.TabIndex = 2;
            this.tabPageSubCategory.Text = "SUBCATEGORY";
            this.tabPageSubCategory.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Name:";
            // 
            // btnSubCategoryName
            // 
            this.btnSubCategoryName.Location = new System.Drawing.Point(21, 28);
            this.btnSubCategoryName.Multiline = true;
            this.btnSubCategoryName.Name = "btnSubCategoryName";
            this.btnSubCategoryName.Size = new System.Drawing.Size(240, 28);
            this.btnSubCategoryName.TabIndex = 31;
            // 
            // btnSubCategoryClear
            // 
            this.btnSubCategoryClear.Location = new System.Drawing.Point(657, 41);
            this.btnSubCategoryClear.Name = "btnSubCategoryClear";
            this.btnSubCategoryClear.Size = new System.Drawing.Size(75, 23);
            this.btnSubCategoryClear.TabIndex = 30;
            this.btnSubCategoryClear.Text = "CLEAR";
            this.btnSubCategoryClear.UseVisualStyleBackColor = true;
            // 
            // btnSubCategoryDelete
            // 
            this.btnSubCategoryDelete.Location = new System.Drawing.Point(657, 12);
            this.btnSubCategoryDelete.Name = "btnSubCategoryDelete";
            this.btnSubCategoryDelete.Size = new System.Drawing.Size(75, 23);
            this.btnSubCategoryDelete.TabIndex = 29;
            this.btnSubCategoryDelete.Text = "DELETE";
            this.btnSubCategoryDelete.UseVisualStyleBackColor = true;
            // 
            // btnSubCategoryUpdate
            // 
            this.btnSubCategoryUpdate.Location = new System.Drawing.Point(541, 41);
            this.btnSubCategoryUpdate.Name = "btnSubCategoryUpdate";
            this.btnSubCategoryUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnSubCategoryUpdate.TabIndex = 28;
            this.btnSubCategoryUpdate.Text = "UPDATE";
            this.btnSubCategoryUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSubCategorySave
            // 
            this.btnSubCategorySave.Location = new System.Drawing.Point(541, 12);
            this.btnSubCategorySave.Name = "btnSubCategorySave";
            this.btnSubCategorySave.Size = new System.Drawing.Size(75, 23);
            this.btnSubCategorySave.TabIndex = 27;
            this.btnSubCategorySave.Text = "SAVE";
            this.btnSubCategorySave.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(282, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Category:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(282, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "SELECT ENUM CATEGORY";
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.Controls.Add(this.label14);
            this.tabPageProduct.Controls.Add(this.checkedListBox1);
            this.tabPageProduct.Controls.Add(this.label13);
            this.tabPageProduct.Controls.Add(this.button1);
            this.tabPageProduct.Controls.Add(this.button2);
            this.tabPageProduct.Controls.Add(this.button3);
            this.tabPageProduct.Controls.Add(this.button4);
            this.tabPageProduct.Controls.Add(this.label15);
            this.tabPageProduct.Controls.Add(this.label16);
            this.tabPageProduct.Controls.Add(this.label17);
            this.tabPageProduct.Controls.Add(this.label18);
            this.tabPageProduct.Controls.Add(this.label19);
            this.tabPageProduct.Controls.Add(this.tbProductLabel);
            this.tabPageProduct.Controls.Add(this.tbProductPrice);
            this.tabPageProduct.Controls.Add(this.tbProductQuantityAvailable);
            this.tabPageProduct.Controls.Add(this.textBox4);
            this.tabPageProduct.Controls.Add(this.tbProductName);
            this.tabPageProduct.Location = new System.Drawing.Point(4, 22);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduct.Size = new System.Drawing.Size(768, 358);
            this.tabPageProduct.TabIndex = 3;
            this.tabPageProduct.Text = "PRODUCT";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(315, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Quantity Available:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(315, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Label:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 127);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Telephone:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(23, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Price:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(23, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 27;
            this.label19.Text = "Name:";
            // 
            // tbProductLabel
            // 
            this.tbProductLabel.Location = new System.Drawing.Point(318, 29);
            this.tbProductLabel.Multiline = true;
            this.tbProductLabel.Name = "tbProductLabel";
            this.tbProductLabel.Size = new System.Drawing.Size(240, 28);
            this.tbProductLabel.TabIndex = 26;
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Location = new System.Drawing.Point(26, 86);
            this.tbProductPrice.Multiline = true;
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(240, 28);
            this.tbProductPrice.TabIndex = 25;
            // 
            // tbProductQuantityAvailable
            // 
            this.tbProductQuantityAvailable.Location = new System.Drawing.Point(318, 86);
            this.tbProductQuantityAvailable.Multiline = true;
            this.tbProductQuantityAvailable.Name = "tbProductQuantityAvailable";
            this.tbProductQuantityAvailable.Size = new System.Drawing.Size(240, 28);
            this.tbProductQuantityAvailable.TabIndex = 24;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(26, 143);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(240, 28);
            this.textBox4.TabIndex = 23;
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(26, 29);
            this.tbProductName.Multiline = true;
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(240, 28);
            this.tbProductName.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(657, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(657, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 35;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(657, 13);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 34;
            this.button4.Text = "SAVE";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(315, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Image:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(26, 201);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(129, 49);
            this.checkedListBox1.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(23, 185);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Sub Category:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.tabPageCategory.ResumeLayout(false);
            this.tabPageCategory.PerformLayout();
            this.tabPageUser.ResumeLayout(false);
            this.tabPageUser.PerformLayout();
            this.tabPageSubCategory.ResumeLayout(false);
            this.tabPageSubCategory.PerformLayout();
            this.tabPageProduct.ResumeLayout(false);
            this.tabPageProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUser;
        private System.Windows.Forms.TextBox tbUserCPF;
        private System.Windows.Forms.TextBox tbUserEmail;
        private System.Windows.Forms.TextBox tbUserPassword;
        private System.Windows.Forms.TextBox tbUserTelephone;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TabPage tabPageCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUserClear;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Button btnUserUpdate;
        private System.Windows.Forms.Button btnUserSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCategoryName;
        private System.Windows.Forms.Button btnCategoryClear;
        private System.Windows.Forms.Button btnCategoryDelete;
        private System.Windows.Forms.Button btnCategoryUpdate;
        private System.Windows.Forms.Button btnCategorySave;
        private System.Windows.Forms.TabPage tabPageSubCategory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox btnSubCategoryName;
        private System.Windows.Forms.Button btnSubCategoryClear;
        private System.Windows.Forms.Button btnSubCategoryDelete;
        private System.Windows.Forms.Button btnSubCategoryUpdate;
        private System.Windows.Forms.Button btnSubCategorySave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbProductLabel;
        private System.Windows.Forms.TextBox tbProductPrice;
        private System.Windows.Forms.TextBox tbProductQuantityAvailable;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}