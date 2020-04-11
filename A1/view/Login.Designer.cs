namespace A1
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLoginEmail = new System.Windows.Forms.TextBox();
            this.btnLoginSignIn = new System.Windows.Forms.Button();
            this.btnLoginClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLoginPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PATRIOTS STORE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "EMAIL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD:";
            // 
            // tbLoginEmail
            // 
            this.tbLoginEmail.Location = new System.Drawing.Point(108, 113);
            this.tbLoginEmail.Multiline = true;
            this.tbLoginEmail.Name = "tbLoginEmail";
            this.tbLoginEmail.Size = new System.Drawing.Size(370, 33);
            this.tbLoginEmail.TabIndex = 3;
            this.tbLoginEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnLoginSignIn
            // 
            this.btnLoginSignIn.Location = new System.Drawing.Point(108, 238);
            this.btnLoginSignIn.Name = "btnLoginSignIn";
            this.btnLoginSignIn.Size = new System.Drawing.Size(75, 33);
            this.btnLoginSignIn.TabIndex = 5;
            this.btnLoginSignIn.Text = "SIGN IN";
            this.btnLoginSignIn.UseVisualStyleBackColor = true;
            this.btnLoginSignIn.Click += new System.EventHandler(this.btnLoginSignIn_Click);
            // 
            // btnLoginClear
            // 
            this.btnLoginClear.Location = new System.Drawing.Point(403, 238);
            this.btnLoginClear.Name = "btnLoginClear";
            this.btnLoginClear.Size = new System.Drawing.Size(75, 33);
            this.btnLoginClear.TabIndex = 6;
            this.btnLoginClear.Text = "CLEAR";
            this.btnLoginClear.UseVisualStyleBackColor = true;
            this.btnLoginClear.Click += new System.EventHandler(this.btnLoginClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "LOGIN";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbLoginPassword
            // 
            this.tbLoginPassword.Location = new System.Drawing.Point(108, 188);
            this.tbLoginPassword.Multiline = true;
            this.tbLoginPassword.Name = "tbLoginPassword";
            this.tbLoginPassword.PasswordChar = '*';
            this.tbLoginPassword.Size = new System.Drawing.Size(370, 33);
            this.tbLoginPassword.TabIndex = 9;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 319);
            this.Controls.Add(this.tbLoginPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLoginClear);
            this.Controls.Add(this.btnLoginSignIn);
            this.Controls.Add(this.tbLoginEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLoginEmail;
        private System.Windows.Forms.Button btnLoginSignIn;
        private System.Windows.Forms.Button btnLoginClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLoginPassword;
    }
}

