using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private string user;
        private string role;

        static string tabela = "ksiazki";

        void wyswietl(string komenda)
        {

            dataGridView1.ClearSelection();

            SqlConnection conDatabase = new SqlConnection(Program.constring);

            SqlCommand cmdDatabase = new SqlCommand(komenda, conDatabase);




            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);

                string temp;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    temp = dataGridView1.Rows[i].Cells[1].FormattedValue.ToString();

                    //Console.WriteLine("wartosci to kodów to:" + dataGridView1.Rows[i].Cells[1].Value);

                    if (temp=="")
                    {
                        //Console.WriteLine("sprawdz to");
                        dataGridView1.Rows[i].Visible = false;

                    }




                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }﻿
          
        }




        public Form1(string user, string role)
        {
            InitializeComponent();
            this.dataGridView1.Hide();
            this.comboBox1.Hide();
            this.textBox2.Hide();
            this.Szukaj.Hide();
           // Login.Text = role;
            this.labSzukaj.Hide();
            this.user = user;
            this.role = role;
            label1.Text = role;
            label2.Text = user;

           

        }


        public Form1()
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.ksiazka' table. You can move, or remove it, as needed.
            this.ksiazkaTableAdapter1.Fill(this.database1DataSet1.ksiazka);
            // TODO: This line of code loads data into the 'database1DataSet.ksiazka' table. You can move, or remove it, as needed.
            this.ksiazkaTableAdapter.Fill(this.database1DataSet.ksiazka);

        }

        private void ksiazkaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ksiazkaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void ksiazkaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Jodb baza_win = new Jodb("(localdb)\\Projects", "Bookstore");
            //dataGridView1.DataSource = baza_win.pobierz_dane("select * from klient");


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

     

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip4_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.labSzukaj.Show();
            this.dataGridView1.Show();
            this.comboBox1.Show();
            this.textBox2.Show();
            this.Szukaj.Show();



            tabela = "dostawca";

            fillwithcolumnname("dostawca");

            wyswietl(" select * from dbo.[dostawca]");



        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        void fillwithcolumnname(string komenda)
        {

            List<string> Array = new List<string>();

            Array.Add("");
            Array.Add("idksiazki");
            Array.Add("ISPN");
            Array.Add("tytul");
            Array.Add("autor");
            Array.Add("datapublikacji");
            Array.Add("cena");
            Array.Add("iddostawca");
            Array.Add("Gatunek");
            Array.Add("Rodzaj Okładki");

            List<string> Array1 = new List<string>();


            Array1.Add("iddostawca");
            Array1.Add("nazwa");

            if (komenda == "ksiazka")
            {


                comboBox1.DataSource = Array;


            }
            if (komenda == "dostawca")
            {


                comboBox1.DataSource = Array1;


            }




        }


        private void button3_Click_1(object sender, EventArgs e)
        {

            this.labSzukaj.Show();
            this.dataGridView1.Show();
            this.comboBox1.Show();
            this.textBox2.Show();
            this.Szukaj.Show();


            tabela = "ksiazka";

            fillwithcolumnname("ksiazka");////wypelnianie kolumny



            //if (comboBox1.SelectedItem == "")
            //{

            wyswietl(" select * from dbo.[ksiazki]");

        }


        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click_1(object sender, EventArgs e)
        {


        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void biodataToolStripMenuItem_Click(object sender, EventArgs e)
        {




            


            this.role = Regex.Replace(this.role, @"\s+", "");




            if (this.role != "Admin")
            {

                MessageBox.Show("Brak uprawnień do przeglądania tej sekcji");

            }

            else
            {
                Useradd ss = new Useradd();

                ss.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dodajUsuńProduktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.role = Regex.Replace(this.role, @"\s+", "");




            if (this.role != "Admin" && this.role != "Magazynier")
            {

                MessageBox.Show("Brak uprawnień do przeglądania tej sekcji");

            }

            else
            {
                frmBookInfo ss = new frmBookInfo();


                ss.Show();
            }


        }

        private void użytkownicyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ss = new AboutBox1();

            ss.Show();


        }

        public static bool IsNumeric(string s)
        {
            int Result;
            return int.TryParse(s, out Result);  // TryParse routines were added in Framework version 2.0.
        }

        private void Szukaj_Click(object sender, EventArgs e)
        {

            try
            {

                var i = comboBox1.SelectedItem;



                string j = i.ToString();

                j = Regex.Replace(j, @"\s+", "");


                if (IsNumeric(j) == true)
                {

                    wyswietl("select * from " + tabela + " WHERE " + i + "=" + textBox2.Text + "");

                }
                else
                {

                    wyswietl("select * from " + tabela + " WHERE " + i + "='" + textBox2.Text + "'");

                }
                //wyswietl("select * from dbo.[ksiazka] WHERE " + i + "=" + textBox2.Text + "");


                Console.WriteLine("select * from " + tabela + " WHERE " + i + "=" + textBox2.Text + "");
            }
            catch (Exception ex)
            {

                Console.WriteLine("kod2"+ex.Message);

            }



        }

        private void dodajKategorięToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.role = Regex.Replace(this.role, @"\s+", "");




            if (this.role != "Admin" && this.role != "Magazynier")
            {

                MessageBox.Show("Brak uprawnień do przeglądania tej sekcji");

            }

            else
            {
                Dodaj_kategorie ss = new Dodaj_kategorie();


                ss.Show();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            this.role = Regex.Replace(this.role, @"\s+", "");




            if (this.role != "Admin" && this.role != "Sprzedawca")
            {

                MessageBox.Show("Brak uprawnień do przeglądania tej sekcji");

            }






            else
            {

                Sprzedaz ss = new Sprzedaz();
                ss.Show();
            }
        }

        private void sprzedazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Historia_sprzedazy ss = new Historia_sprzedazy();
            ss.Show();

          
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            var list = new List<string> { "a", "b", "a", "c", "a", "b" };
            var q = list.GroupBy(x => x)
                        .Select(g => new { Value = g.Key, Count = g.Count() })
                        .OrderByDescending(x => x.Count);

            int i = 0;
            foreach (var x in q)
            {
                Console.WriteLine("Wykonanie petli" + i);
                Console.WriteLine("Value: " + x.Value + " Count: " + x.Count);
                i++;
            }
        }

        private void dodajUsunDostawceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.role = Regex.Replace(this.role, @"\s+", "");

            if (this.role != "Admin" && this.role != "Magazynier")
            {

                MessageBox.Show("Brak uprawnień do przeglądania tej sekcji");

            }

            else
            {
                Dostawca d = new Dostawca();
                d.Show();
            }





           

        }

        private void raportDobowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raport_dobowy ss = new Raport_dobowy();
            ss.Show();

        }

        private void raportMiesięcznyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raport_Miesieczny ss = new Raport_Miesieczny();
            ss.Show();
        }

        private void raportRocznyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raport_Roczny ss = new Raport_Roczny();
            ss.Show();
        }




        //private void button2_Click_2(object sender, EventArgs e)
        //{

        //    List<string>lista1=new List<string>();
        //    List<int>lista2=new List<int>();
        //    Console.WriteLine("\n");

        //    var list = new List<string> { "a", "b", "a", "c", "a", "b" };
        //    var q = list.GroupBy(x => x)
        //                .Select(g => new { Value = g.Key, Count = g.Count() })
        //                .OrderByDescending(x => x.Count);

        //    foreach (var x in q)
        //    {
        //        lista1.Add(x.Value);
        //        lista2.Add(x.Count);
              
        //    }

         
                

        //}
    }

}
