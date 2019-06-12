using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Useradd : Form
    {

        SqlConnection connect1 = null;
        SqlCommand cmd = null;
       
        SqlDataReader reader = null;
        void connect()
            {

                SqlConnection conDatabase = new SqlConnection(Program.constring);
                SqlCommand cmdDatabase = new SqlCommand(" select * from dbo.[User] ;", conDatabase);


                conDatabase.Open();

            }
        void bind()///////sluzy do wyswietlania tabeli na poczatku istnienia
        {

            SqlConnection conDatabase = new SqlConnection(Program.constring);
            SqlCommand cmdDatabase = new SqlCommand(" select * from dbo.[User] ;", conDatabase);


            conDatabase.Open();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView2.DataSource = bSource;
                sda.Update(dbdataset);
                conDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }﻿

       }

        void modify(string i)
        {

            SqlConnection conDatabase = new SqlConnection(Program.constring);
            SqlCommand cmdDatabase = new SqlCommand(i, conDatabase);
           




             

                conDatabase.Open();
                //cmdDatabase.ExecuteReader();

                ////SqlCommand roleAdmin = new SqlCommand("Select [ROLE] from [User] where Username='" + textBox2.Text + "' and Password='" + textBox1.Text + "'", con)
                bind();
                //conDatabase.Close();





            

        }


        public Useradd()
        {
            InitializeComponent();
            bind();
            dataGridView2.Columns[1].Visible = false;
          
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Create_user_Click(object sender, EventArgs e)
        {
            


            if (Password.Text != ConfirmPassword.Text)
            {

                MessageBox.Show("Pola password i confirm password różnią się od siebie");
                Password.Clear();
                ConfirmPassword.Clear();


            }
            if (Password.Text.Length < 4)
            {

                MessageBox.Show("Hasło musi zawierać conajmniej cztery znaki ");
                Password.Focus();
                Password.Clear();
                ConfirmPassword.Clear();

            }

            if(Program.IsValid(email.Text)==false)
            {
                MessageBox.Show("Podałeś zły format adresu e-mail");


            }

            if (Program.Regexcheck(Imie.Text, "@*[A-Z][a-z]+") == false && Program.Regexcheck(Nazwisko.Text, "@*[A-Z][a-z]+") == false)
            {
                MessageBox.Show("Zle imie ,albo nazwisko");


            }
           
            if (Program.Regexcheck(telefon.Text, "@*[0-9]") == false && telefon.Text.Length<9)
            {
                MessageBox.Show("Zly numer telefonu");


            }



            try
            {

                

                SqlConnection con = new SqlConnection(Program.constring);


                con.Open();

                string insert = "insert into [User] (Username,Password,ROLE,Imie,Nazwisko,Telefon,e-mail) values (@usr,@pwd,@usrl,@Imie,@Nazwisko,@Telefon,@email)";
                cmd = new SqlCommand(insert, con);
                cmd.Parameters.Add(new SqlParameter("@usr", SqlDbType.VarChar)).Value = Username.Text;
                cmd.Parameters.Add(new SqlParameter("@pwd", SqlDbType.VarChar)).Value = Password.Text;
                cmd.Parameters.Add(new SqlParameter("@usrl", SqlDbType.VarChar)).Value = cmbRole.Text;
                cmd.Parameters.Add(new SqlParameter("@Imie", SqlDbType.VarChar)).Value = Imie.Text;
                cmd.Parameters.Add(new SqlParameter("@Nazwisko", SqlDbType.VarChar)).Value = Nazwisko.Text;
                cmd.Parameters.Add(new SqlParameter("@Telefon", SqlDbType.Int)).Value = telefon.Text;
                cmd.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar)).Value = email.Text;
               // cmd.Parameters.Add(new SqlParameter("@emp_id", SqlDbType.VarChar)).Value = txtEmp.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("User registered successfully...!", "New User", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmd.Dispose();
                con.Close();
                bind();
             
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);




            }


        }
        

        //public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        private void Autocomplete()
        {
            try
            {
                SqlConnection connect = new SqlConnection(Program.constring);
                connect.Open();
                string selectQry = "select Username from [User]";
                SqlCommand sampleCmd = new SqlCommand(selectQry, connect);
                SqlDataAdapter da = new SqlDataAdapter(sampleCmd);
                DataSet ds = new DataSet();
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                da.Fill(ds, "[User]");

                for (int cnt = 0; cnt < ds.Tables[0].Rows.Count - 1; cnt++)
                {
                    col.Add(ds.Tables[0].Rows[cnt]["Username"].ToString());
                }

               

                connect.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }











        private void delete_records()
        {
            int row_affected = 0;
            SqlConnection connect = new SqlConnection(Program.constring);
            connect.Open();
            string deleteQry = "delete from [User] where [Username]=@uname";
          SqlCommand cmd = new SqlCommand(deleteQry, connect);
         
            cmd.Parameters.Add(new SqlParameter("@uname", SqlDbType.VarChar)).Value = UserDel.Text;
        

            row_affected = cmd.ExecuteNonQuery();

            if (row_affected > 0)
            {
                MessageBox.Show("Użytkownik został usunięty..!", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Autocomplete();
                UserDel.Clear();
            }
            else
            {
                MessageBox.Show("Brak użytkowników o takim loginie", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UserDel.Clear();
                Autocomplete();
            }

        }




        private void Delete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Jesteś pewien ,że chcesz usunąć użytkownika?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                delete_records();
                bind();
            }


        }

        private void UserDel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Role_TextChanged(object sender, EventArgs e)
        {

        }

        private void Useradd_Load(object sender, EventArgs e)
        {

        }

        private void Display_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnpassword_Click(object sender, EventArgs e)
        {



            string User = txtUser.Text;
            string password = txtPassword.Text;

            password = Regex.Replace(password, @"\s+", "");
            User = Regex.Replace(User, @"\s+", "");

            if(password.Length<5)
            {
                Console.WriteLine("Haslo musi zawierać co najmniej 5 znaków");

            }

            SqlConnection con = new SqlConnection(Program.constring);


            con.Open();



            string passwordchange = "Update [User] SET Password=@pwd WHERE Username=@User";
            SqlCommand cmd = new SqlCommand(passwordchange, con);

            cmd.Parameters.Add(new SqlParameter("@pwd", SqlDbType.VarChar)).Value = password;
            cmd.Parameters.Add(new SqlParameter("@User", SqlDbType.VarChar)).Value = User;
 
            cmd.ExecuteNonQuery();


            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Hasło zostało zmienione...!", "Zmiana hasła", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmd.Dispose();
                con.Close();
                bind();
            }
            else
            {
                MessageBox.Show("Brak uzytkownika o takiej nazwie w systemie!", "Zmiana hasła", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmd.Dispose();
                con.Close();
                bind();

                Console.WriteLine();


            }



        }
    }
}
