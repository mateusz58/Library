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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {

            try
            {

                SqlConnection con = new SqlConnection(Program.constring);

                


                // string i="Select [ROLE] from [User] Where Username="+textBox2.Text+" and Password="+textBox1.Text;

                //DataTable dt = new DataTable();
                con.Open();

                Console.WriteLine(con.State);

                // SqlCommand cmdDatabase = new SqlCommand("Select * from [User] where Username='"+textBox2.Text+"'",con);


                SqlCommand cmdDatabase = new SqlCommand("Select * from [User] where Username='" + textBox2.Text + "' and Password='" + textBox1.Text + "'", con);//zwrocenie specyficznego elemtu


                SqlCommand roleAdmin = new SqlCommand("Select [ROLE] from [User] where Username='" + textBox2.Text + "' and Password='" + textBox1.Text + "'", con);

                SqlDataReader reader = roleAdmin.ExecuteReader();


                //string j;
                string i = textBox2.Text;
                //j = reader.GetSqlString(1).ToString();


                string role;
                List<string> list = (from IDataRecord r in reader
                                     select (string)r["ROLE"]
                            ).ToList();


                role = list.ElementAt(0);


                Console.WriteLine(role);
                Console.Write("xxx");


                //Console.WriteLine("sprawdz to "+j);
                if (reader.HasRows)
                {




                    Form1 ss = new Form1("Logged as:" + i, role);
                    ss.Show();
                    //((Form)this.MdiParent).Controls["label1"].Text = "You are logged as:" + i;
                    this.Hide();

                }
                else
                {

                    MessageBox.Show("Zła nazwa użytkownika ,lub hasło");
                    textBox1.Clear();
                    textBox2.Clear();

                    Form2 zz = new Form2();

                }

            }catch(Exception ex)
                {
                    MessageBox.Show("Zła nazwa użytkownika ,lub hasło");

                }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
