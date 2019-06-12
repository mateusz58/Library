using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
//btnUpdate.Enabled = true;
//btnSave.Enabled = false;
//btnDelete.Enabled = true;
namespace WindowsFormsApplication2
{
    public partial class frmBookInfo : Form
    {
      
        private void wyswietl(string sql,ComboBox c)
        {

            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            int i = 0;
         
           
            
            connection = new SqlConnection(Program.constring);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                c.DataSource = ds.Tables[0];
                c.ValueMember = "nazwa";
                c.DisplayMember = "nazwa";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        //void wyswietl(string komenda)
        //{



        //    SqlConnection conDatabase = new SqlConnection(Program.constring);

        //    SqlCommand cmdDatabase = new SqlCommand(komenda, conDatabase);




        //    try
        //    {
        //        SqlDataAdapter sda = new SqlDataAdapter();
        //        sda.SelectCommand = cmdDatabase;
        //        DataTable dbdataset = new DataTable();
        //        sda.Fill(dbdataset);
        //        BindingSource bSource = new BindingSource();

        //        bSource.DataSource = dbdataset;
        //        cmbCategory.DataSource = bSource;
        //        cmbCategory
        //        sda.Update(dbdataset);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }﻿
          
        //}

        public frmBookInfo()
        {
            InitializeComponent();
            wyswietl("SELECT *FROM Gatunek",cmbCategory);
            wyswietl("SELECT *FROM dostawca", cmbPublisher);
        }
        SqlCommand cmd = null;
        public static string GetCode(int maxSize)
        {
            char[] chars = new char[70];
            chars = "123456789".ToCharArray();

            byte[] bytes = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();

            crypto.GetNonZeroBytes(bytes);
            bytes = new byte[maxSize];
            crypto.GetNonZeroBytes(bytes);

            StringBuilder results = new StringBuilder();

            foreach (byte b in bytes)
            {
                results.Append(chars[b % (chars.Length)]);
            }
            return results.ToString();

        }
        public void ClearAll()
        {
            txtBookId.Text = "";
            txtTitle.Text = "";
            txtAuthor.Text = "";
            //txtPublisher.Text = "";
            cmbCategory.SelectedIndex = -1;
            nudQuantity.Value = 1;
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            txtTitle.Focus();

        }
        private void Autocomplete()
        {
            try
            {


                SqlConnection connect = new SqlConnection(Program.constring);
                connect.Open();
                SqlCommand sampleCmd = new SqlCommand("select * from ksiazka", connect);
                SqlDataAdapter da = new SqlDataAdapter(sampleCmd);
                DataSet ds = new DataSet();
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();

                da.Fill(ds, "ksiazki");
                int cnt = 0;
                for (cnt = 0; cnt < ds.Tables[0].Rows.Count - 1; cnt++)
                {
                    col.Add(ds.Tables[0].Rows[cnt]["tytul"].ToString());
                }
                txtTitle.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtTitle.AutoCompleteCustomSource = col;
                txtTitle.AutoCompleteMode = AutoCompleteMode.Suggest;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBookInfo_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnNew.Enabled = true;
            Autocomplete();
            
            //cmbCategory.SelectedIndex = -1;
            try
            {
                SqlConnection connect = new SqlConnection(Program.constring);
                connect.Open();
                string selectQry = "select distinct RTRIM(category) from tblcategory";
                cmd = new SqlCommand(selectQry, connect);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = null;
                DataTable dTable = null;

                ds = new DataSet("ds");
                da.Fill(ds);
                dTable = ds.Tables[0];
                cmbCategory.Items.Clear();
                foreach (DataRow row in dTable.Rows)
                {
                    cmbCategory.Items.Add(row[0].ToString());
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    
        //private void frmBookInfo_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    frmMain frmMain = new frmMain();
        //    this.Hide();
        //    //frmMain.Show();
        //}

        private void delete_records()
        {
            try
            {
                int row_affected = 0;
                SqlConnection connect = new SqlConnection(Program.constring);
                connect.Open();
                string deleteQry = "delete from ksiazki where idksiazki=@bid";
                cmd = new SqlCommand(deleteQry, connect);

                cmd.Parameters.Add(new SqlParameter("@bid", SqlDbType.VarChar)).Value = txtBookId.Text;

                row_affected = cmd.ExecuteNonQuery();
                if (row_affected > 0)
                {
                    MessageBox.Show("Ksiazka została usunięta za bazy danych...!", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Autocomplete();
                    ClearAll();
                }
                else
                {
                    MessageBox.Show("Brak książki w bazie...!", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                    Autocomplete();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //private void btnGetAll_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    frmBookRecords frmBR = new frmBookRecords();
        //    frmBR.Show();
        //}

        void wartosztabeli(string komenda4, TextBox t, SqlConnection con) // "SELECT idZamowienia AS LastID FROM Zamowienia WHERE idZamowienia = @@Identity"
        {
            //string wartoscid;
         //= "SELECT idZamowienia AS LastID FROM Zamowienia WHERE idZamowienia = @@Identity";//pobranie id ostatniego dodanego zamowienia
            //SqlConnection con = new SqlConnection(Program.constring);
            //Console.WriteLine(komenda4);


            //Console.WriteLine("Wywolanie procedury");

       
            SqlCommand cmd3 = new SqlCommand(komenda4,con);

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
                    
            }catch(Exception ex)
            {
                Console.WriteLine("Funkcja wartoszid BLAD:"+ex.Message);
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
            }catch(Exception ex)
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
            
        //  void wartosztabeli(string komenda4, DateTime t)  // "SELECT idZamowienia AS LastID FROM Zamowienia WHERE idZamowienia = @@Identity"
        //{
        //    string wartoscid;
        //    //= "SELECT idZamowienia AS LastID FROM Zamowienia WHERE idZamowienia = @@Identity";//pobranie id ostatniego dodanego zamowienia
        //    SqlConnection con = new SqlConnection(Program.constring);
        //    Console.WriteLine(komenda4);


              

        //    con.Open();
        //    SqlCommand cmd3 = new SqlCommand(komenda4, con);

        //    SqlDataAdapter sda = new SqlDataAdapter();
        //    sda.SelectCommand = cmd3;
        //    DataTable dbdataset = new DataTable();
        //    sda.Fill(dbdataset);
        //    sda.Update(dbdataset);

        //    foreach (DataRow row in dbdataset.Rows)
        //    {
        //        t.Text = row[0].ToString();

        //        //wartoscid


        //    }




        //}

        private void txtBookId_TextChanged(object sender, EventArgs e)
        {//"SELECT idZamowienia AS LastID FROM Zamowienia WHERE idZamowienia = @@Identity"


   

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Update();
        }

        private void frmBookInfo_Load_1(object sender, EventArgs e)
        {

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

        private void delete_records(string sql, TextBox t, string kolumna, string tabela)////////////////////usuniecie rekordu         Przyklad poprawnego argumentu delete from [User] where [Username]=@uname
        {
            int row_affected = 0;
            SqlConnection connect = new SqlConnection(Program.constring);
            connect.Open();
            //string deleteQry = @uname";
            SqlCommand cmd = new SqlCommand(sql, connect);

            cmd.Parameters.Add(new SqlParameter("@uname", SqlDbType.VarChar)).Value = t.Text;


            row_affected = cmd.ExecuteNonQuery();

            if (row_affected > 0)
            {
                MessageBox.Show("Ksiazka o podanym kodzie kreskowym została usunięta z bazy towarowej..!", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Autocomplete(kolumna, tabela);
                t.Clear();
            }
            else
            {
                MessageBox.Show("Brak książki o podanym kodzie kreskowym w bazie towarowej", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                t.Clear();
                Autocomplete(kolumna, tabela);
            }

        }

     
        private void frmBookInfo_Load_2(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.ksiazka' table. You can move, or remove it, as needed.
            this.ksiazkaTableAdapter1.Fill(this.database1DataSet.ksiazka);
            // TODO: This line of code loads data into the 'database1DataSet1.ksiazka' table. You can move, or remove it, as needed.
            this.ksiazkaTableAdapter.Fill(this.database1DataSet1.ksiazka);

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            int x1 = 0;
            int j2 = 0;
            string x2 = "";
            try
            {
                if (txtBookId.Text == "")
                {
                    MessageBox.Show("Nie podałeś kodu produktu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Czy jesteś pewien ,że chcesz usunąć podaną ilość produktów z magazynu?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    SqlConnection connect = new SqlConnection(Program.constring);
                    connect.Open();
                     string j = nudQuantity.Value.ToString();
                    int j1 = Convert.ToInt32(j);

                    j2 = wartosztabeli("SELECT [Ilość] FROM [Barcode] WHERE [Kod kreskowy]='" + txtBookId.Text + "'", x1, connect);


                    Console.WriteLine("Pobrana ilosc z kodu kreskowego"+j2);

                    if(j1>j2)
                    {
                        MessageBox.Show("Nie można usunąć z Magazynu więcej produktów niż jest na stanie");
                        connect.Close();
                        return;

                    }
                    
                    //string deleteQry = @uname";
                    SqlCommand cmd = new SqlCommand("UPDATE [Barcode] SET [Ilość]=[Ilość]-@arg1 WHERE [Kod kreskowy]=@arg2 and Ilość>0", connect);
                   


                    
                    cmd.Parameters.Add(new SqlParameter("@arg1", SqlDbType.Int)).Value = j1;////j1-jest to wartosc z nudquanity
                    cmd.Parameters.Add(new SqlParameter("@arg2", SqlDbType.VarChar)).Value = txtBookId.Text;
                    cmd.ExecuteNonQuery();

                    wartosztabeli("SELECT [Ilośc] FROM ksiazki WHERE kod='" + txtBookId.Text + "'", Ilosc, connect);

                    connect.Close();
                    Console.WriteLine("Sukces");
                }
            }
            catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);

                
                }
                
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            int sprawdzenie;
            int cos = 0;
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Podaj nazwę książki.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
                return;
            }
            if (txtAuthor.Text == "")
            {
                MessageBox.Show("Podaj autora książki", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthor.Focus();
                return;
            }
            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz gatunek ksiazki.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCategory.Focus();
                return;
            }


            //if (nudQuantity.Value <= 0)
            //{
            //    MessageBox.Show("Please enter quantity of books.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    nudQuantity.Focus();
            //    return;

            //}
            try
            {



                //SqlCommand cmd2 = new SqlCommand();



                //txtBookId.Text = "B" + GetCode(5);
                SqlConnection connect = new SqlConnection(Program.constring);
                connect.Open();
                int j = 0;
                Console.WriteLine("Wartosc z boxu" + cmbPublisher.SelectedValue);

                Console.WriteLine("Wartosc z gatunku" + cmbCategory.SelectedValue);

                string insert2 = "SELECT iddostawca FROM dostawca WHERE nazwa='" + cmbPublisher.SelectedValue.ToString() + "'";
                j=wartosztabeli(insert2, j, connect);


                connect.Close();
                //Console.WriteLine("Pobrana wartosc dostawcy=" + j);
                //musze 
                //int j1;


                //string ISPN;
                //string Title;
                //string Author;
                //string Cena;


           string ISPN=Regex.Replace(txtISPN.Text.ToString(), @"\s+", "");
           string Title= Regex.Replace(txtTitle.Text.ToString(), @"\s+", "");
           string Author= Regex.Replace(txtAuthor.Text.ToString(), @"\s+", "");
           string Gatunek =Regex.Replace(cmbCategory.SelectedValue.ToString(), @"\s+", "");
           //string Rodzaj = Regex.Replace(cmbRodzajOkladki.SelectedValue.ToString(), @"\s+", "");
             

                double cenaa;
                string cena = txtCena.Text.ToString();
                //(double) cenaa = Convert.ToDouble(txtCena.Text);

                Console.WriteLine("Wartosc Pola Cena to" + txtCena.Text);

                if (Double.TryParse(cena, out cenaa) == true)//////////
                {
                    Console.WriteLine("Sukces");
                    Console.WriteLine(cenaa);
                }
                if (Double.TryParse(cena, out cenaa) == false)
                {
                    Console.WriteLine("Porazka");

                }


               // Console.ReadLine();


                int rows = 0;

               // Console.ReadLine();
                connect.Open();
                try
                {
                    //string insert = "insert into ksiazka(Kod,Tytuł,Autor,Gatunek,Cena,ISPN,Gatunek,[Rodzaj Okładki]) values(@b_id,@b_t,@au,@pu,@cat,@rodzaj,@data)";
                    string insert = "insert into ksiazka(ISPN,tytul,autor,cena,iddostawca,[Rodzaj Okładki],Gatunek) values(@ISPN,@tytul,@au,@cena,@iddostawca,@rodzaj,@cat)";
                    cmd = new SqlCommand(insert, connect);

                    cmd.Parameters.Add(new SqlParameter("@ISPN", SqlDbType.Int)).Value = ISPN; //ISPN.Text;//IPSN dodane
                    cmd.Parameters.Add(new SqlParameter("@tytul", SqlDbType.VarChar)).Value = Title;// txtTitle.Text;///tytul dodany
                    cmd.Parameters.Add(new SqlParameter("@au", SqlDbType.VarChar)).Value = Author;// txtAuthor.Text;//autor dodany
                    cmd.Parameters.Add(new SqlParameter("@cena", SqlDbType.Float)).Value = cenaa;//cena dodane
                    cmd.Parameters.Add(new SqlParameter("@cat", SqlDbType.VarChar)).Value = Gatunek;//cmbCategory.SelectedValue;//gatunek dodany
                    cmd.Parameters.Add(new SqlParameter("@rodzaj", SqlDbType.VarChar)).Value = "Twarda"; //rodzaj dodany


                    //cmbRodzajOkladki.SelectedValue.ToString();
                    //cmd.Parameters.Add(new SqlParameter("@qua", SqlDbType.Date)).Value = dateTime;

                    //cmd.Parameters.Add(new SqlParameter("@data", SqlDbType.Date)).Value = dateTime;

                    cmd.Parameters.Add(new SqlParameter("@iddostawca", SqlDbType.Int)).Value = j; //wartosztabeli(insert2, j, connect);

                    rows = cmd.ExecuteNonQuery();

                }catch(Exception ex)
                {
                    Console.WriteLine("Kontynuuj");

                }


                // Console.WriteLine(" ID=1 Pobrana wartosc rows to" + rows);
               // connect.Close();

                    // Console.WriteLine("Porbrana wartosc"+wartosztabeli(insert2, j, connect));
                    //Console.ReadLine();
                //}
                //catch (SqlException ex)
                //{

                //    Console.WriteLine("KOD1" + ex.Message);

                //}



                
                 
                    Console.WriteLine("Sprawdzenie triggera wartosc rows: " + rows);


                 

                //sprawdzenie=Convert.ToInt32(sprawdzenie1);


                //if (Int32.TryParse(sprawdzenie2, out sprawdzenie) == true)//////////
                //{
                //    Console.WriteLine("Sukces");
                //    Console.WriteLine(sprawdzenie);
                //}
                //if (Int32.TryParse(sprawdzenie2, out sprawdzenie) == false)
                //{
                //    Console.WriteLine("Porazka");

                //}

               //sprawdzenie = 0;

            

           

                //Console.ReadLine();



                if (rows > 0)////////////////Jezeli aozstal wywolany trigger to dodajemy barcode dodano nową wartośc to dodaje nowe kody kreskowe
                {
                    Console.WriteLine("Bez wywolania triggera");

                    string xx = nudQuantity.Text.ToString();
                    int liczba;

                    if (Int32.TryParse(xx, out liczba) == true)//////////
                    {
                        Console.WriteLine("Sukces");
                        Console.WriteLine(liczba);
                    }
                    if (Int32.TryParse(xx, out liczba) == false)
                    {
                        Console.WriteLine("Porazka");

                    }


                  string insert3 = "insert into Barcode values(@arg1,@arg2,@arg3)";

                string Bookid = Regex.Replace(txtBookId.Text.ToString(), @"\s+", "");

                    cmd = new SqlCommand(insert3, connect);

                    cmd.Parameters.Add(new SqlParameter("@arg1", SqlDbType.VarChar)).Value = Bookid;//IPSN dodane
                    cmd.Parameters.Add(new SqlParameter("@arg2", SqlDbType.Int)).Value = wartosztabeli("SELECT idksiazki AS LastID FROM ksiazka WHERE idksiazki = @@Identity", cos, connect);
                    cmd.Parameters.Add(new SqlParameter("@arg3", SqlDbType.Int)).Value = liczba;///tytul dodany



                    //cmd.Parameters.Add(new SqlParameter("@pu", SqlDbType.VarChar)).Value = txtPublisher.Text;
                    //cmd.Parameters.Add(new SqlParameter("@cat", SqlDbType.VarChar)).Value = cmbCategory.SelectedItem;
                    //cmd.Parameters.Add(new SqlParameter("@qua", SqlDbType.Int)).Value = nudQuantity.Value;

                    //cmd.Parameters.Add(new SqlParameter("@qua", SqlDbType.Int)).Value = nudQuantity.Value;

                    int row=cmd.ExecuteNonQuery();

                    if (row > 0)
                    {

                        MessageBox.Show("Ksiazka zostala dodana ....!", "Book Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connect.Close();
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Blad nie udalo sie");

                        ClearAll();
                        //cmd.Dispose();
                        connect.Close();
                        return;
                    }
                }



                else
                {

                    Console.WriteLine("Wywolanie triggera");


                   string xx=nudQuantity.Text.ToString();
                    int liczba2;

                   if (Int32.TryParse(xx, out liczba2) == true)//////////
                {
                    Console.WriteLine("Sukces");
                    Console.WriteLine(liczba2);
                }
                if (Int32.TryParse(xx, out liczba2) == false)
                {
                    Console.WriteLine("Porazka");

                }
                string Bookid2 = Regex.Replace(txtBookId.Text.ToString(), @"\s+", "");

                    //string insert4="SELECT idksiazki WHERE"


                string insert3 = "UPDATE Barcode SET [Ilość]=[Ilość]+" + liczba2 + " WHERE [Kod kreskowy]='" + Bookid2 + "'";



                    cmd = new SqlCommand(insert3, connect);

                    cmd.Parameters.Add(new SqlParameter("@arg1", SqlDbType.VarChar)).Value = Bookid2;//IPSN dodane
                    //cmd.Parameters.Add(new SqlParameter("@arg2", SqlDbType.Int)).Value = wartosztabeli("SELECT idksiazki FROM Barcode B WHERE idksiazki = @@Identity", cos, connect);
                    cmd.Parameters.Add(new SqlParameter("@arg3", SqlDbType.Int)).Value = liczba2;///tytul dodany


                    //Console.WriteLine("Ksiazka zostala dodana z uzyciem triggera");

                    int row = cmd.ExecuteNonQuery();

                    if (row > 0)
                    {
                        
                        string ILOSC = Regex.Replace(Ilosc.Text.ToString(), @"\s+", "");
                        int ILOSC2 = Convert.ToInt32(ILOSC);

                        int final = ILOSC2 + liczba2;

                        Ilosc.Text = "" + final;

                       


                        
                        MessageBox.Show("Ksiazka zostala dodana ....!", "Book Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connect.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Blad nie udalo sie!");
                        connect.Close();
                        return;

                    }
                   



                }

            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnNew_Click_1(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {


            string kod = Regex.Replace(txtBookId.Text.ToString(), @"\s+", "");
            string ISPN = Regex.Replace(txtISPN.Text.ToString(), @"\s+", "");
            string Title = Regex.Replace(txtTitle.Text.ToString(), @"\s+", "");
            string Author = Regex.Replace(txtAuthor.Text.ToString(), @"\s+", "");
            string Gatunek = Regex.Replace(cmbCategory.SelectedValue.ToString(), @"\s+", "");
            //string Rodzaj = Regex.Replace(cmbRodzajOkladki.SelectedValue.ToString(), @"\s+", "");
            string wydawca= Regex.Replace(cmbPublisher.SelectedValue.ToString(), @"\s+", "");
            string Rodzaj = cmbRodzajOkladki.SelectedText.ToString();
            double cenaa;
            string cena = Regex.Replace(txtCena.Text.ToString(), @"\s+", "");
            cenaa = Convert.ToDouble(cena);
            int ISPNN = Convert.ToInt32(ISPN);







            if (txtTitle.Text == "")
            {
                MessageBox.Show("Podaj tytul książki.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
                return;
            }
            if (txtAuthor.Text == "")
            {
                MessageBox.Show("Podaj autora książki.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthor.Focus();
                return;
            }
            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Wybierz kategorię.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCategory.Focus();
                return;
            }
         
            //if (nudQuantity.Value <= 0)
            //{
            //    MessageBox.Show("Please enter quantity of books.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    nudQuantity.Focus();
            //    return;
            //}

            try
            {
                SqlConnection connect = new SqlConnection(Program.constring);
                connect.Open();

                int j=0;

                int k =0;
                int j1=wartosztabeli("SELECT idksiazki FROM Barcode B WHERE B.[Kod kreskowy]='" + kod + "'",j,connect);//////////idksiazki
                int k1 = wartosztabeli("SELECT iddostawca FROM dostawca d WHERE d.nazwa='" + wydawca + "'",k,connect);///////////iddostawcy
                Console.WriteLine("wartosc iddostawca to:" + k1);
                Console.WriteLine("wartosc idksiazki to:" + j1);
                //Console.ReadLine();
                string updateQry = "update ksiazka set tytul=@btitle,autor=@auth,iddostawca=@publ,Gatunek=@cate,ISPN=@ISPN,[Rodzaj Okładki]=@rodzaj,cena=@cena where idksiazki="+j1;
                cmd = new SqlCommand(updateQry, connect);
                //cmd.Parameters.Add(new SqlParameter("@bid", SqlDbType.VarChar)).Value = kod;
                cmd.Parameters.Add(new SqlParameter("@btitle", SqlDbType.VarChar)).Value = Title;
                cmd.Parameters.Add(new SqlParameter("@auth", SqlDbType.VarChar)).Value = Author;
                cmd.Parameters.Add(new SqlParameter("@publ", SqlDbType.Int)).Value = k1;
                cmd.Parameters.Add(new SqlParameter("@cate", SqlDbType.VarChar)).Value = Gatunek;
                cmd.Parameters.Add(new SqlParameter("@ISPN", SqlDbType.Int)).Value = ISPNN;
                cmd.Parameters.Add(new SqlParameter("@rodzaj", SqlDbType.VarChar)).Value = Rodzaj;
                cmd.Parameters.Add(new SqlParameter("@cena", SqlDbType.Float)).Value = cenaa;
                //cmd.Parameters.Add(new SqlParameter("@data", SqlDbType.Date)).Value = dateTime;



                //cmd.Parameters.Add(new SqlParameter("@bookid", SqlDbType.Int)).Value = j1;

                //cmd.Parameters.Add(new SqlParameter("@qua", SqlDbType.Int)).Value = nudQuantity.Value;
               


                cmd.ExecuteNonQuery();
                MessageBox.Show("Informacje o ksiazce zostaly zaktualizowane.", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
                connect.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbRodzajOkladki_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ksiazkaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtkod_TextChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("Sprawdz to 2");


            SqlConnection con = new SqlConnection(Program.constring);

            con.Open();
    


                wartosztabeli("SELECT Tytuł FROM ksiazki WHERE kod='" + txtBookId.Text + "'", txtTitle,con);
                wartosztabeli("SELECT autor FROM ksiazki WHERE kod='" + txtBookId.Text + "'", txtAuthor,con);
                wartosztabeli("SELECT Gatunek FROM ksiazki WHERE kod='" + txtBookId.Text + "'", cmbCategory,con);
                wartosztabeli("SELECT Cena FROM ksiazki WHERE kod='" + txtBookId.Text + "'", txtCena,con);
                wartosztabeli("SELECT ISPN FROM ksiazki WHERE kod='" + txtBookId.Text + "'", txtISPN,con);
                wartosztabeli("SELECT [Rodzaj Okładki] FROM ksiazki WHERE kod='" + txtBookId.Text + "'", cmbRodzajOkladki,con);
                wartosztabeli("SELECT [Nazwa dostawcy] FROM ksiazki WHERE kod='" + txtBookId.Text + "'", cmbPublisher,con);


                wartosztabeli("SELECT [Ilośc] FROM ksiazki WHERE kod='" + txtBookId.Text + "'", Ilosc, con);



                con.Close();
             

            if(txtBookId.Text=="")
            {
                txtTitle.Clear();
                txtAuthor.Clear();
                txtISPN.Clear();
                txtCena.Clear();
                Ilosc.Text = "0";

            }
            if(txtTitle.Text=="")
            {
                Ilosc.Text = "0";

            }


        }

        private void cmbISPN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int zero=0;
            int row_affected = 0;
            int row_affected2 = 0;
            SqlConnection connect = new SqlConnection(Program.constring);
            connect.Open();
            int zero1=wartosztabeli("SELECT idksiazki FROM [Barcode] WHERE [Kod kreskowy]='" + txtBookId.Text + "'", zero, connect);
            //string deleteQry = @uname";
            SqlCommand cmd = new SqlCommand("DELETE FROM Barcode WHERE [Kod kreskowy]='" + txtBookId.Text + "'", connect);
            SqlCommand cmd2 = new SqlCommand("DELETE FROM ksiazka WHERE idksiazki=@arg1", connect);

            //cmd.Parameters.Add(new SqlParameter("@arg1", SqlDbType.VarChar)).Value = txtBookId.Text;

            cmd2.Parameters.Add(new SqlParameter("@arg1", SqlDbType.Int)).Value = zero1;

           
           
            row_affected = cmd.ExecuteNonQuery();
            row_affected2 = cmd2.ExecuteNonQuery();

            if (row_affected > 0 && row_affected2 > 0)
            {
                MessageBox.Show("Ksiazka o podanym kodzie kreskowym została usunięta z bazy towarowej..!", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Autocomplete(kolumna, tabela);
                txtBookId.Clear();
                txtAuthor.Clear();
                txtCena.Clear();
                txtTitle.Clear();
                txtISPN.Clear();
                Ilosc.Text = "0";
                connect.Close();
               
            }
            else
            {
                MessageBox.Show("Brak książki o podanym kodzie kreskowym w bazie towarowej", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connect.Close();
                //t.Clear();
                //Autocomplete(kolumna, tabela);
            }
        }

 

    }
}
