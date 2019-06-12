namespace WindowsFormsApplication2
{
    partial class Useradd
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Create_user = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Display = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.Imie = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.Nazwisko = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Delete = new System.Windows.Forms.Button();
            this.UserDel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ksiazkaTableAdapter1 = new WindowsFormsApplication2.Database1DataSet1TableAdapters.ksiazkaTableAdapter();
            this.database1DataSet1 = new WindowsFormsApplication2.Database1DataSet1();
            this.ksiazkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnpassword = new System.Windows.Forms.Button();
            this.Display.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Create_user
            // 
            this.Create_user.Location = new System.Drawing.Point(160, 425);
            this.Create_user.Name = "Create_user";
            this.Create_user.Size = new System.Drawing.Size(105, 42);
            this.Create_user.TabIndex = 3;
            this.Create_user.Text = "Create user";
            this.Create_user.UseVisualStyleBackColor = true;
            this.Create_user.Click += new System.EventHandler(this.Create_user_Click);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(132, 52);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(167, 26);
            this.Username.TabIndex = 4;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(132, 101);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(167, 26);
            this.Password.TabIndex = 6;
            // 
            // Display
            // 
            this.Display.Controls.Add(this.tabPage1);
            this.Display.Controls.Add(this.tabPage2);
            this.Display.Controls.Add(this.tabPage3);
            this.Display.Controls.Add(this.tabPage4);
            this.Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Display.Location = new System.Drawing.Point(0, 0);
            this.Display.Name = "Display";
            this.Display.SelectedIndex = 0;
            this.Display.Size = new System.Drawing.Size(535, 539);
            this.Display.TabIndex = 7;
            this.Display.SelectedIndexChanged += new System.EventHandler(this.Display_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.cmbRole);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.Imie);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.Create_user);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.email);
            this.tabPage1.Controls.Add(this.telefon);
            this.tabPage1.Controls.Add(this.Nazwisko);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.ConfirmPassword);
            this.tabPage1.Controls.Add(this.Username);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Password);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Mangal", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(412, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Add";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 14);
            this.label9.TabIndex = 18;
            this.label9.Text = "Imie:";
            // 
            // Imie
            // 
            this.Imie.Location = new System.Drawing.Point(132, 248);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(167, 26);
            this.Imie.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "E-mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 14);
            this.label7.TabIndex = 15;
            this.label7.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nazwisko:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(132, 384);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(167, 26);
            this.email.TabIndex = 13;
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(132, 341);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(167, 26);
            this.telefon.TabIndex = 12;
            // 
            // Nazwisko
            // 
            this.Nazwisko.Location = new System.Drawing.Point(132, 291);
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.Size = new System.Drawing.Size(167, 26);
            this.Nazwisko.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Role:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.Location = new System.Drawing.Point(132, 150);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(167, 26);
            this.ConfirmPassword.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.Delete);
            this.tabPage2.Controls.Add(this.UserDel);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(412, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User Del";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(157, 132);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // UserDel
            // 
            this.UserDel.Location = new System.Drawing.Point(98, 83);
            this.UserDel.Name = "UserDel";
            this.UserDel.Size = new System.Drawing.Size(198, 20);
            this.UserDel.TabIndex = 1;
            this.UserDel.TextChanged += new System.EventHandler(this.UserDel_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Type username to delete:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage3.Controls.Add(this.vScrollBar1);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(527, 513);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "View Users";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(501, 42);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(18, 266);
            this.vScrollBar1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 42);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(511, 266);
            this.dataGridView2.TabIndex = 0;
            // 
            // ksiazkaTableAdapter1
            // 
            this.ksiazkaTableAdapter1.ClearBeforeFill = true;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ksiazkaBindingSource
            // 
            this.ksiazkaBindingSource.DataMember = "ksiazka";
            this.ksiazkaBindingSource.DataSource = this.database1DataSet1;
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Sprzedawca",
            "Gość",
            "Administrator",
            "Magazynier"});
            this.cmbRole.Location = new System.Drawing.Point(132, 201);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(167, 22);
            this.cmbRole.TabIndex = 19;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage4.Controls.Add(this.btnpassword);
            this.tabPage4.Controls.Add(this.txtUser);
            this.tabPage4.Controls.Add(this.txtPassword);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(412, 513);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Zmień hasło";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(122, 92);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(167, 20);
            this.txtUser.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(122, 141);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(167, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = " new password:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Username:";
            // 
            // btnpassword
            // 
            this.btnpassword.Location = new System.Drawing.Point(155, 195);
            this.btnpassword.Name = "btnpassword";
            this.btnpassword.Size = new System.Drawing.Size(104, 23);
            this.btnpassword.TabIndex = 11;
            this.btnpassword.Text = "Zmiana hasła";
            this.btnpassword.UseVisualStyleBackColor = true;
            this.btnpassword.Click += new System.EventHandler(this.btnpassword_Click);
            // 
            // Useradd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(535, 539);
            this.Controls.Add(this.Display);
            this.Name = "Useradd";
            this.Text = "User management";
            this.Load += new System.EventHandler(this.Useradd_Load);
            this.Display.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Create_user;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TabControl Display;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ConfirmPassword;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox UserDel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet1TableAdapters.ksiazkaTableAdapter ksiazkaTableAdapter1;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource ksiazkaBindingSource;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox Nazwisko;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Imie;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnpassword;

    }
}