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
    public partial class Dostawca : Form
    {

        private const string select = "SELECT *FROM dostawca";


        void wartosztabeli(string komenda4, TextBox t, SqlConnection con) // "SELECT idZamowienia AS LastID FROM Zamowienia WHERE idZamowienia = @@Identity"
        {
            //string wartoscid;
            //= "SELECT idZamowienia AS LastID FROM Zamowienia WHERE idZamowienia = @@Identity";//pobranie id ostatniego dodanego zamowienia
            //SqlConnection con = new SqlConnection(Program.constring);
            //Console.WriteLine(komenda4);
            try
            {

                //Console.WriteLine("Wywolanie procedury");


                SqlCommand cmd3 = new SqlCommand(komenda4, con);

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd3;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                sda.Update(dbdataset);

                foreach (DataRow row in dbdataset.Rows)
                {
                    //wartoscid = row[0].ToString();
                    t.Text = row[0].ToString();

                    //wartoscid
                    //Console.WriteLine("wartoscid");

                }

            }catch(Exception ex)
            {

            }


        }
        void wartosztabeli(string komenda4, ComboBox t, SqlConnection con)
        {

            //= "SELECT idZamowienia AS LastID FROM Zamowienia WHERE idZamowienia = @@Identity";//pobranie id ostatniego dodanego zamowienia
            //SqlConnection con = new SqlConnection(Program.constring);
            SqlCommand cmd3 = new SqlCommand(komenda4, con);

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd3;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            sda.Update(dbdataset);

            foreach (DataRow row in dbdataset.Rows)
            {
                t.Text = row[0].ToString();

                //wartoscid


            }




        }
        string wartosztabeli(string komenda4, string t, SqlConnection con)
        {

            //= "SELECT idZamowienia AS LastID FROM Zamowienia WHERE idZamowienia = @@Identity";//pobranie id ostatniego dodanego zamowienia
            //SqlConnection con = new SqlConnection(Program.constring);
            SqlCommand cmd3 = new SqlCommand(komenda4, con);

            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd3;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            sda.Update(dbdataset);
            string z;
            foreach (DataRow row in dbdataset.Rows)
            {
                t = row[0].ToString();

                //wartoscid


            }

            z = t;

            return z;


        }
        int wartosztabeli(string komenda4, int t, SqlConnection con)
        {


            try
            {
                //= "SELECT idZamowienia AS LastID FROM Zamowienia WHERE idZamowienia = @@Identity";//pobranie id ostatniego dodanego zamowienia
                //SqlConnection con = new SqlConnection(Program.constring);
                SqlCommand cmd3 = new SqlCommand(komenda4, con);

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd3;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                sda.Update(dbdataset);
                int wynik;
                string h;

                foreach (DataRow row in dbdataset.Rows)
                {
                    h = row[0].ToString();

                    if (Int32.TryParse(h, out t) == true)//////////
                    {
                        //Console.WriteLine("Sukces");
                        //Console.WriteLine(t);
                    }
                    if (Int32.TryParse(h, out t) == false)
                    {
                        //Console.WriteLine("Porazka");

                    }


                }
                wynik = t;

                return wynik;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Funkcja wartoszid BLAD:" + ex.Message);
                return 0;

            }

        }

        void wartosztabeli(string komenda4, Label t, SqlConnection con)
        {

            try
            {
                //= "SELECT idZamowienia AS LastID FROM Zamowienia WHERE idZamowienia = @@Identity";//pobranie id ostatniego dodanego zamowienia
                //SqlConnection con = new SqlConnection(Program.constring);
                SqlCommand cmd3 = new SqlCommand(komenda4, con);

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd3;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                sda.Update(dbdataset);

                foreach (DataRow row in dbdataset.Rows)
                {
                    t.Text = row[0].ToString();

                    //wartoscid


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }

        int wartosztabeli(string komenda4, int t)
        {
            SqlConnection con = new SqlConnection(Program.constring);

            con.Open();

            try
            {
                //= "SELECT idZamowienia AS LastID FROM Zamowienia WHERE idZamowienia = @@Identity";//pobranie id ostatniego dodanego zamowienia
                //SqlConnection con = new SqlConnection(Program.constring);
                SqlCommand cmd3 = new SqlCommand(komenda4, con);

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmd3;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                sda.Update(dbdataset);
                int wynik;
                string h;

                foreach (DataRow row in dbdataset.Rows)
                {
                    h = row[0].ToString();

                    if (Int32.TryParse(h, out t) == true)//////////
                    {
                        //Console.WriteLine("Sukces");
                        //Console.WriteLine(t);
                    }
                    if (Int32.TryParse(h, out t) == false)
                    {
                        //Console.WriteLine("Porazka");

                    }


                }
                wynik = t;
                con.Close();
                return wynik;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Funkcja wartoszid BLAD:" + ex.Message);
                return 0;

            }

        }





        void Clear()
        {
            txtemail.Clear();
            txtkodpocztowy.Clear();
            txtmiasto.Clear();
            txtkraj.Clear();
            txtnrlokalu.Clear();
            txttelefon.Clear();
            txtulica.Clear();
            //Ilosc.Text = "0";


        }











        private void Autocomplete(string kolumna, string tabela)
        {
            try
            {
                SqlConnection connect = new SqlConnection(Program.constring);
                connect.Open();
                string selectQry = "select " + kolumna + " from " + tabela;
                SqlCommand sampleCmd = new SqlCommand(selectQry, connect);
                SqlDataAdapter da = new SqlDataAdapter(sampleCmd);
                DataSet ds = new DataSet();
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                da.Fill(ds, tabela);

                for (int cnt = 0; cnt < ds.Tables[0].Rows.Count - 1; cnt++)
                {
                    col.Add(ds.Tables[0].Rows[cnt][kolumna].ToString());
                }



                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void delete_records()////////////////////usuniecie rekordu         Przyklad poprawnego argumentu delete from [User] where [Username]=@uname
        {
            try
            {
                string dostawcadousuniecia;
                int row_affected = 0;
                SqlConnection connect = new SqlConnection(Program.constring);
                connect.Open();
                string deleteQry = "DELETE FROM dostawca WHERE nazwa=@arg1";
                SqlCommand cmd = new SqlCommand(deleteQry, connect);
                dostawcadousuniecia = Regex.Replace(txtdostawca.Text, @"\s+", "");

                cmd.Parameters.Add(new SqlParameter("@arg1", SqlDbType.VarChar)).Value = dostawcadousuniecia;


                row_affected = cmd.ExecuteNonQuery();

                


                if (row_affected > 0)
                {
                    MessageBox.Show("Wydawca został usunięty..!", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Autocomplete(kolumna, tabela);
                    //t.Clear();
                    Clear();
                    bind(Griddostawca, select);
                }
                else
                {
                    MessageBox.Show("Brak takiego wydawcy w systemie", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                   // Autocomplete(kolumna, tabela);
                }
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);


            }

        }
        private void bind(DataGridView d, string sql)///////sluzy do wyswietlania tabeli na poczatku istnienia//Przyklad komendy " select * from dbo.[User] ;"
        {

            SqlConnection conDatabase = new SqlConnection(Program.constring);
            SqlCommand cmdDatabase = new SqlCommand(sql, conDatabase);


            conDatabase.Open();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                d.DataSource = bSource;
                sda.Update(dbdataset);
                conDatabase.Close();




             


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }﻿

       }
        void dodajrekord(string sql)
        {


            try
            {


                SqlConnection con = new SqlConnection(Program.constring);


                con.Open();


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@arg1", SqlDbType.VarChar)).Value = txtdostawca.Text;
                cmd.Parameters.Add(new SqlParameter("@arg2", SqlDbType.VarChar)).Value = txtemail.Text;
                cmd.Parameters.Add(new SqlParameter("@arg3", SqlDbType.VarChar)).Value = txtkodpocztowy.Text;
                cmd.Parameters.Add(new SqlParameter("@arg4", SqlDbType.VarChar)).Value = txtmiasto.Text;
                cmd.Parameters.Add(new SqlParameter("@arg5", SqlDbType.VarChar)).Value = txtulica.Text;
                cmd.Parameters.Add(new SqlParameter("@arg6", SqlDbType.VarChar)).Value = txtkraj.Text;
                cmd.Parameters.Add(new SqlParameter("@arg7", SqlDbType.VarChar)).Value = txtkraj.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Dodano nowego wydawcę", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmd.Dispose();
                con.Close();
                bind(Griddostawca, select);

            }
            catch (SqlException ex)
            {
               
                MessageBox.Show(ex.Message);
            }
        }
        void Aktualizacja(string sql)
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.constring);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@arg1", SqlDbType.VarChar)).Value = txtdostawca.Text;
                cmd.Parameters.Add(new SqlParameter("@arg2", SqlDbType.VarChar)).Value = txtemail.Text;
                cmd.Parameters.Add(new SqlParameter("@arg3", SqlDbType.VarChar)).Value = txtkodpocztowy.Text;
                cmd.Parameters.Add(new SqlParameter("@arg4", SqlDbType.VarChar)).Value = txtmiasto.Text;
                cmd.Parameters.Add(new SqlParameter("@arg5", SqlDbType.VarChar)).Value = txtulica.Text;
                cmd.Parameters.Add(new SqlParameter("@arg6", SqlDbType.VarChar)).Value = txtkraj.Text;
                cmd.Parameters.Add(new SqlParameter("@arg7", SqlDbType.VarChar)).Value = txttelefon.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dodano nowego wydawcę", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.Dispose();
                con.Close();
                bind(Griddostawca, select);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Aktualizacja("Update dostawca SET nazwa=@arg1,[e-mail]=@arg2,[Kod pocztowy]=@arg3,Miasto=@arg4,Ulica=@arg5,Kraj=@arg6,Telefon=@arg7 WHERE nazwa=@arg1");
        }
        public Dostawca()
        {
            InitializeComponent();
            bind(Griddostawca,select);
            Griddostawca.Columns[0].Visible = false;
            
        }

      private void button1_Click_1(object sender, EventArgs e)
        {





            if (Program.IsValid(txtemail.Text) == false)
            {
                MessageBox.Show("Podałeś zły format adresu e-mail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }


            if (txtkodpocztowy.Text.Length < 6 || txtkodpocztowy.Text.Length >6 && Regex.IsMatch(txtkodpocztowy.Text, "@*[0-9]")==false)
           {

               Console.WriteLine("Podałes zły kod pocztowy");
               return;

           }
        


            if (Program.Regexcheck(txttelefon.Text, "@*[0-9]") == false && txttelefon.Text.Length < 9)
            {
                MessageBox.Show("Zly numer telefonu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }



            if (txtdostawca.Text == "")
            {
                MessageBox.Show("Podales złe dane", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Czy na pewno chcesz dodac tego wydawcę książek?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                
                string poczta;
                poczta = txtkodpocztowy.Text;
              

                
                dodajrekord("insert into [dostawca] (nazwa,[e-mail],[Kod pocztowy],Miasto,Ulica,Kraj,Telefon) values (@arg1,@arg2,@arg3,@arg4,@arg5,@arg6,@arg7)");
                //dodajrekord("insert into [dostawca] (e-mail) values ")
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (txtdostawca.Text == "")
            {
                MessageBox.Show("Brak dostawcy do usuniecia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Czy na pewno chcesz usunąć  tego wydawcę książek?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                delete_records();
                bind(Griddostawca, select);
                    
            }
        }

        private void Dostawca_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtdostawca_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.constring);

            con.Open();


            wartosztabeli("SELECT e-mail FROM dostawca WHERE nazwa='" + txtdostawca.Text + "'", txtemail, con);
            wartosztabeli("SELECT [Kod pocztowy] FROM dostawca WHERE nazwa='" + txtdostawca.Text + "'", txtkodpocztowy, con);
            wartosztabeli("SELECT [Miasto] FROM dostawca WHERE nazwa='" + txtdostawca.Text + "'", txtmiasto, con);
            wartosztabeli("SELECT Ulica FROM dostawca WHERE nazwa='" + txtdostawca.Text + "'", txtulica, con);
            wartosztabeli("SELECT Kraj FROM dostawca WHERE nazwa='" + txtdostawca.Text + "'", txtkraj, con);
            wartosztabeli("SELECT Telefon FROM dostawca WHERE kod='" + txtdostawca.Text + "'", txttelefon, con);
            //wartosztabeli("SELECT [Nazwa dostawcy] FROM dostawca WHERE kod='" + txtdostawca.Text + "'", cmbPublisher, con);


            con.Close();


            if (txtdostawca.Text == "")
            {
                txtemail.Clear();
                txtkodpocztowy.Clear();
                txtmiasto.Clear();
                txtkraj.Clear();
                txtnrlokalu.Clear();
                txttelefon.Clear();
                txtulica.Clear();
                //Ilosc.Text = "0";

            }
         

        }

       
    }
}
