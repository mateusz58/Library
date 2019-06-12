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
    public partial class Sprzedaz : Form
    {
        static int check = 1;
        List<string> lista;
        List<string> listaid;
        private double wartosc = 0;
       int numboks = 0;
        string wartosc2;
        //void bind(string sql, DataGridView d)///////sluzy do polaczenia datagridview z okreslonymi tabelamo
        //{

        //    SqlConnection conDatabase = new SqlConnection(Program.constring);
        //    SqlCommand cmdDatabase = new SqlCommand(sql, conDatabase);


        //    conDatabase.Open();
        //    try
        //    {
        //        SqlDataAdapter sda = new SqlDataAdapter();
        //        sda.SelectCommand = cmdDatabase;
        //        DataTable dbdataset = new DataTable();
        //        sda.Fill(dbdataset);
        //        BindingSource bSource = new BindingSource();

        //        bSource.DataSource = dbdataset;
        //        d.DataSource = bSource;
        //        sda.Update(dbdataset);
        //        conDatabase.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}
        //
        public static bool IsNumeric(string s)
        {
            int Result;
            return int.TryParse(s, out Result);  // TryParse routines were added in Framework version 2.0.
        }
        static double suma = 0;

        void bind(string komenda, DataGridView d)
        {

            Gridprodukty.ClearSelection();

            SqlConnection conDatabase = new SqlConnection(Program.constring);

            SqlCommand cmdDatabase = new SqlCommand(komenda, conDatabase);

            string temp;



            try
            {

                //string temp;
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();




                //for (int i = dbdataset.Rows.Count - 1; i >= 0; i--)
                //{
                //    DataRow dr = dbdataset.Rows[i];
                //    Console.WriteLine("Pierwsz iteracja"+dr[1]);

                //    if (dr[1].ToString()=="")
                //    {
                //        Console.WriteLine("Wywolanie warunku");
                //        dr.Delete();
                //    }
                //} 






                //Console.WriteLine("Powtórne przieterowanie przez tabele");





                //}
                //dbdataset.Rows[0].IsNull
                bSource.DataSource = dbdataset;
                Gridprodukty.DataSource = bSource;
                sda.Update(dbdataset);

                for (int i = 0; i < Gridprodukty.Rows.Count; i++)
                {
                    temp = Gridprodukty.Rows[i].Cells[1].FormattedValue.ToString();

                    //Console.WriteLine("Wartośc z pierwszej komórki:" + temp);

                    if (temp == "0")
                    {
                        //nsole.WriteLine("sprawdz");
                        Gridprodukty.Rows[i].Visible = false;

                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }﻿
          
        }

        private void searchkod(TextBox t, string sql, DataGridView d)//t to jest parametr ktory szukam w tym przz //sql wywolanoie przykladowe sea/rchkod(txtszukaj,'EXEC kod); 
        {

            try
            {

                var i = t.Text; //comboBox1.SelectedItem;

                string j = i.ToString();

                j = Regex.Replace(j, @"\s+", "");//////////usuniecie spacji


                t.Text = j;

                bind(sql + " " + "'" + j + "'", d);

            }
            catch (Exception ex)
            {

            }


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
                da.Fill(ds, "[User]");

                for (int cnt = 0; cnt < ds.Tables[0].Rows.Count - 1; cnt++)
                {
                    col.Add(ds.Tables[0].Rows[cnt]["Username"].ToString());
                }



                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        public Sprzedaz()
        {
            try
            {
                
                InitializeComponent();

                bind("SELECT *FROM ksiazki", Gridprodukty);

                txtkod.Text = "xxx";

                foreach (DataGridViewColumn c in Gridprodukty.Columns)
                {
                    Gridzamowienia.Columns.Add(c.Clone() as DataGridViewColumn);
                }

                Gridzamowienia.Columns[4].Visible = false;
                Gridzamowienia.Columns[3].Visible = false;
                Gridzamowienia.Columns[0].Visible = false;
                Gridzamowienia.Columns[5].Visible = true;
                Gridzamowienia.Columns[6].Visible = false;
                Gridzamowienia.Columns[7].Visible = false;
                Gridzamowienia.Columns[9].Visible = false;
                Gridzamowienia.Columns[8].Visible = false;

                Gridzamowienia.Columns[3].Visible = true;

                Gridzamowienia.Columns[1].Visible = true;
                Gridzamowienia.Columns[2].Visible = true;

                List<string> lista = new List<string>();

                fillwithcolumnname();

                this.lista = new List<string>();
                this.listaid = new List<string>();
            }catch(Exception ex)
            {


            }

        }

        private void txtkod_TextChanged(object sender, EventArgs e)
        {

            if (txtkod.Text == "")
            {
                bind("SELECT *FROM ksiazki", Gridprodukty);
            }

            else
            {
                searchkod(txtkod, "exec kod", Gridprodukty);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            suma = 0;
            txtSuma.Text = "" + suma;
            this.lista.Clear();
            this.listaid.Clear();
            txtkod.Clear();
            Gridzamowienia.Rows.Clear();

        }

        private void clearGrid(DataGridView view)
        {
            for (int row = 0; row < view.Rows.Count; ++row)
            {
                bool isEmpty = true;
                for (int col = 0; col < view.Columns.Count; ++col)
                {
                    object value = view.Rows[row].Cells[col].Value;
                    if (value != null && value.ToString().Length > 0)
                    {
                        isEmpty = false;
                        break;
                    }
                }
                if (isEmpty)
                {
                    // deincrement (after the call) since we are removing the row
                    view.Rows.RemoveAt(row--);
                }
            }
        }


        double sum(string kolumna, DataGridView d)
        {


            for (int i = 0; i < d.Rows.Count; ++i)
            {
                suma += Convert.ToDouble(d.Rows[i].Cells[kolumna].Value);
            }


            return suma;

        }

        private void btndodaj_Click(object sender, EventArgs e)
        {
            int huj = 0;

            if (numBox.Value <= 0)
            {
                MessageBox.Show("Podaj ilość produktów którą chcesz dodać");
                return;

            }


            Console.WriteLine("Ilosc kolumn" + Gridprodukty.Rows.Count+"");

            if (Gridprodukty.Rows.Count < 1)
            {

                MessageBox.Show("Brak produktu o takim kodzie kreskowym");
                return;

            }
            if (txtkod.Text == "")
            {

                MessageBox.Show("Podaj kod produktu");
                return;

            }

          // Gridprodukty.Rows[0].Cells["Ilość"].Value.ToString();

            if (Int32.TryParse(Gridprodukty.Rows[0].Cells[8].Value.ToString(), out huj) == true)//////////
            {
                Console.WriteLine("Sukces");
                Console.WriteLine(huj);
            }
            if (Int32.TryParse(Gridprodukty.Rows[0].Cells[8].Value.ToString(), out huj) == false)
            {
                Console.WriteLine("Porazka");

            }


      Console.WriteLine("Sprawdz wartosc kolumny Ilosc:"+huj);




            if(huj<=0)
            {
                MessageBox.Show("Brak tego rodzaju produktu w magazynie");
                return;


            }


         if (numBox.Value>huj)
         {
             MessageBox.Show("Nie można sprzedać więcej tego rodzaju produktu niz jest w magazynie");
             return;

         }

         Gridprodukty.Rows[0].Cells[8].Value = huj - numBox.Value;
            
            
                                                       

            Console.WriteLine("wartosc ilosc to" + huj);

            for (int xy = 0; xy < numBox.Value; xy++)
            {

                //int total = 0;
                try
                {
                    //int tmp;



                    //string temporary2;
                    string mes1 = Gridprodukty.Rows[0].Cells[1].Value.ToString();

                    mes1 = Regex.Replace(mes1, @"\s+", "");

                    //if (String.TryParse(mes1, out temporary2) == true)//////////
                    //{
                    //    Console.WriteLine("Sukces");
                    //    Console.WriteLine(temporary2);
                    //}
                    //if (Int32.TryParse(mes1, out temporary2) == false)
                    //{
                    //    Console.WriteLine("Porazka");

                    //}

                    string temporary = txtkod.Text;

                    Regex.Replace(temporary, @"\s+", "");


                    this.lista.Add(temporary);
                    this.listaid.Add(mes1);



                    Console.WriteLine("zawartosc listy");


                    for (int x = 0; x < this.lista.Count; x++)
                    {
                        Console.WriteLine(lista.ElementAt(x));

                    }

                    Console.WriteLine("zawartosc listy nr 2");

                    for (int x = 0; x < this.listaid.Count; x++)
                    {
                        Console.WriteLine(listaid.ElementAt(x));

                    }


                    foreach (DataGridViewRow r in Gridprodukty.Rows)
                    {
                        int index = Gridzamowienia.Rows.Add(r.Clone() as DataGridViewRow);
                        foreach (DataGridViewCell o in r.Cells)
                        {
                            Gridzamowienia.Rows[index].Cells[o.ColumnIndex].Value = o.Value;
                        }
                    }

                    int i = Gridzamowienia.Rows.Count;

                    i = i - 1;

                    //Console.WriteLine("ilosc wierszy " + i);


                    suma = sum("Cena", Gridzamowienia);


                    txtSuma.Text = "" + suma;

                    suma = 0;

                    clearGrid(Gridzamowienia);



                }
                catch (Exception ex)
                {
                    Console.WriteLine("Blad" + ex.Message);
                }

            }

        }
        


        //private double CalculateTotal()
        //{
        //    for (int i = 0; i < Gridzamowienia.Rows.Count; i++)
        //    {
        //        double V = string.IsNullOrEmpty(Gridzamowienia.Rows[i].Cells["Cena"].Value.ToString()) ? 0 : Convert.ToDouble(Gridzamowienia.Rows[i].Cells["Cena"].Value.ToString().Replace('$', ' ').Trim());
        //        Tot += V;
        //    }
        //    return Tot;
        //}

        //private void Gridzamowienia_CellEnter(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        Tot = 0;
        //        Double FinVal = CalculateTotal();
        //        label4.Text = "sffdf";
        //        //label4.Text = FinVal.ToString();
        //    } 
        //}



        private void Gridzamowienia_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btnusun_Click(object sender, EventArgs e)
        {

        }

        private void Gridzamowienia_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                int t;
                double z;
                z = Convert.ToDouble(txtSuma.Text);

                z = z - wartosc;

                //var nazwa = Gridzamowienia.CurrentRow.Cells[1].FormattedValue;

                //txtkod.Text = nazwa.ToString();

                txtkod.Text = wartosc2;



                //var ilosc = Gridzamowienia.CurrentRow.Cells[8].FormattedValue.ToString();


                //txtkod.Text = Gridzamowienia.CurrentRow.Cells[8].Value.ToString();




                if (Int32.TryParse(Gridprodukty.Rows[0].Cells[8].Value.ToString(), out t) == true)//////////
                {
                    Console.WriteLine("Sukces");
                    Console.WriteLine(t);
                }
                if (Int32.TryParse(Gridprodukty.Rows[0].Cells[8].Value.ToString(), out t) == false)
                {
                    Console.WriteLine("Porazka");

                }


               

                t = t + 1;


                Gridprodukty.Rows[0].Cells[8].Value = t;






                txtSuma.Text = "" + z;
                
                wartosc = 0;

                for(int i=0;i<listaid.Count;i++)
                {
                    if(listaid.ElementAt(i).Equals(wartosc2)==true)
                    {
                        listaid.RemoveAt(i);
                    }

                }
              
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Gridzamowienia_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //Console.WriteLine("test nagłówka");
                string nazwaj1;
                string nazwaj2;
                double nazwaj2a;
                var nazwa = Gridzamowienia.CurrentRow.Cells[1].FormattedValue;
                var nazwa1 = Gridzamowienia.CurrentRow.Cells[5].FormattedValue;


                //for (int i = 0; i < 9; i++)
                //{

                //    Console.WriteLine("Wartosci indeksu:" + i + ":" + Gridzamowienia.CurrentRow.Cells[i].FormattedValue + "");

                //}
                ////////Cena to jest ineks 5

                nazwaj1=nazwa.ToString();//////////[Kod kreskowy]
                nazwaj1 = Regex.Replace(nazwaj1, @"\s+", "");

                nazwaj2 = nazwa1.ToString();/////////[Cena]
                nazwaj2 = Regex.Replace(nazwaj2, @"\s+", "");
                nazwaj2a = Convert.ToDouble(nazwaj2);

               
                //nazwaj1=nazwa1.ToString();

               // nazwa = Regex.Replace(nazwa, @"\s+", "");

                wartosc = nazwaj2a;

                

                wartosc2 = nazwaj1;//////////Tuta juz jest pobrany kod

                //Console.WriteLine(nazwa);


                //Console.WriteLine("Pobrane wartości z nagłowka:\n Cena=" + nazwaj2a + "kod=" + nazwaj1 + "\n\n");


            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }

        void fillwithcolumnname()
        {

            List<string> Array = new List<string>();

            Array.Add("");
            Array.Add("Tytuł");
            Array.Add("Autor");
            Array.Add("Cena");
            Array.Add("ISPN");           
            Array.Add("Gatunek");
            


            comboBox1.DataSource = Array;



        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                var i = comboBox1.SelectedItem;



                string j = i.ToString();

                j = Regex.Replace(j, @"\s+", "");


                if (IsNumeric(j) == true)
                {

                    bind("select * from ksiazki WHERE " + i + "=" + textBox2.Text + "",Gridprodukty);

                }
                else
                {

                    bind("select * from  ksiazki WHERE " + i + "='" + textBox2.Text + "'",Gridprodukty);

                }
                //wyswietl("select * from dbo.[ksiazka] WHERE " + i + "=" + textBox2.Text + "");


                //Console.WriteLine("select * from ksiazki WHERE " + i + "=" + textBox2.Text + "");
            }
            catch (Exception ex)
            {



            }
        }
        void dodanierekordu(string sql, TextBox t1, DataGridView d, string arg1)  //////////Przyklad komendy//////////// insert into [Zamowienia] (Username,Password,ROLE) values (@arg1
        {


            try
            {


                SqlConnection con = new SqlConnection(Program.constring);


                con.Open();


                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add(new SqlParameter("@arg1", SqlDbType.VarChar)).Value = t1.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Nowy rekord zostal dodany", "Nowy rekord", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cmd.Dispose();
                //bind(sql, d);

                con.Close();




            }
            catch (Exception ex)
            {

            }
        }


        List<int>usunduplkaty(List<int>inputlist)
        {
            List<int> finalList = new List<int>();
            foreach (int currValue in inputlist)
            {
                if (!finalList.Contains(currValue))
                {
                    finalList.Add(currValue);
                }
            }
            return finalList;


        }




        void wartosztabeli(string komenda4, TextBox t, SqlConnection con) // "SELECT idZamowienia AS LastID FROM Zamowienia WHERE idZamowienia = @@Identity"
        {
            //string wartoscid;
            //= "SELECT idZamowienia AS LastID FROM Zamowienia WHERE idZamowienia = @@Identity";//pobranie id ostatniego dodanego zamowienia
            //SqlConnection con = new SqlConnection(Program.constring);
            Console.WriteLine(komenda4);


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
                    Console.WriteLine("Sukces");
                    Console.WriteLine(t);
                }
                if (Int32.TryParse(h, out t) == false)
                {
                    Console.WriteLine("Porazka");

                }


            }
            wynik = t;

            return wynik;

        }








        private void btnZapisz_Click(object sender, EventArgs e)
        {
            int wartoscid2 = 0;
            string wartoscid="";

            try
            {

                if (Gridzamowienia.Rows.Count < 1)
                {
                    MessageBox.Show("Brak zamowien");
                    return;

                }

                else
                {

                    DateTime dt = DateTime.Now;

                    Console.WriteLine(dt);

                    SqlConnection con = new SqlConnection(Program.constring);


                    con.Open();

                    Console.WriteLine("Ilosc zamowien= " + (Gridzamowienia.Rows.Count));

                    SqlCommand cmd = new SqlCommand("INSERT INTO Zamowienia VALUES(@arg1,@arg2,@arg3)", con);
                    cmd.Parameters.Add(new SqlParameter("@arg2", SqlDbType.Float)).Value = txtSuma.Text;

                    cmd.Parameters.Add(new SqlParameter("@arg1", SqlDbType.Int)).Value = Gridzamowienia.Rows.Count;

                    cmd.Parameters.Add(new SqlParameter("@arg3", SqlDbType.DateTime)).Value = dt;

                    cmd.ExecuteNonQuery();

                    try
                    {

                        //////////////Wtym momecie funkcja na usuniecie duplikatow
                        //string komenda1 = "Select idZamowienia from Zamowienia WHERE Czas='" + dt + "'";
                        //string komenda2 = "Select idZamowienia from Zamowienia WHERE IdZamowienia=2";
                        //string komenda3 = "Select Czas from Zamowienia WHERE IdZamowienia=1004";
                        string komenda4 = "SELECT idZamowienia AS LastID FROM Zamowienia WHERE idZamowienia = @@Identity";//pobranie id ostatniego dodanego zamowienia

                        Console.WriteLine(komenda4);

                        SqlCommand cmd3 = new SqlCommand(komenda4, con);

                        SqlDataAdapter sda = new SqlDataAdapter();
                        sda.SelectCommand = cmd3;
                        DataTable dbdataset = new DataTable();
                        sda.Fill(dbdataset);
                        sda.Update(dbdataset);

                        foreach (DataRow row in dbdataset.Rows)
                        {
                            wartoscid = row[0].ToString();
                        

                        }

                        
                        ///wartoscid = dbdataset.Rows[0].ToString();

                        Console.WriteLine("Wartosc pobranego czasu" + dt);

                        Console.WriteLine("Wartosci ID to= "+wartoscid);
                    

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Blad id =1" + ex.Message);


                    }

                    wartoscid = Regex.Replace(wartoscid, @"\s+", "");/////////Usuniecie spacji

                    if (Int32.TryParse(wartoscid, out wartoscid2) == true)//////////
                    {
                        Console.WriteLine("Sukces");
                        Console.WriteLine(wartoscid2);
                    }
                    if (Int32.TryParse(wartoscid, out wartoscid2) == false)
                    {
                        Console.WriteLine("Porazka");

                    }
                
                    //sda.Update(dbdataset);

                    //Console.WriteLine("Wyswietlenie listy produktow id dodanych przed");



                    //for(int i=0;i<listaid.Count;i++)
                    //{

                    //    Console.WriteLine(listaid.ElementAt(i));

                    //}

                    string test = "";



                    
               
                    Console.WriteLine("\n");

                    var list = listaid;
                    var q = list.GroupBy(x => x)
                                .Select(g => new { Value = g.Key, Count = g.Count() })
                                .OrderByDescending(x => x.Count);
                    try
                    {
                        foreach (var x in q)////////////////usuwanie duplikatow i policzenie wystapienia duplikatow
                        {
                            //Console.WriteLine("wartosc id:" + x.Value + "Ilosc wystapien:" + x.Count);



                            string gz = "";

                            SqlCommand cmd2a = new SqlCommand("INSERT INTO [Szczegóły zamówienia] VALUES(@arg1,@arg2,@arg3,@arg4,@arg5)", con);
                            //SqlCommand cmd2b = new SqlCommand("SELECT *FROM Barcode", con);
                            SqlCommand cmd2c = new SqlCommand("UPDATE Barcode SET [Ilość]=[Ilość]-@Ilosc WHERE [Ilość]>0 and [Kod kreskowy]=@kod", con);
                            // wstaw siwezo wstawiona wartosc zamowiania
                            ////////////////wartoscid2 mnie nie interesuje
                            //cmd2a.Parameters.Add(new SqlParameter("@arg1", SqlDbType.Int)).Value = wartoscid2; ////////Arg1 to powinno byc swiezo wstawiona wartosc id Zamówienia
                            //cmd2a.Parameters.Add(new SqlParameter("@arg2", SqlDbType.VarChar)).Value = x.Value;//////identyfikator produktu
                            //cmd2a.Parameters.Add(new SqlParameter("@arg3", SqlDbType.Int)).Value = x.Count;/////////ilosc produktu

                            //cmd2c.Parameters.Add(new SqlParameter("@parametr", SqlDbType.Int)).Value = x.Count;/////////ilosc produktu
                            string test2 = wartosztabeli(" SELECT tytul FROM ksiazka k WHERE EXISTS(SELECT *FROM Barcode B WHERE k.idksiazki=B.idksiazki and B.[Kod kreskowy]='"+x.Value+"')", gz, con);
                            string test3 = wartosztabeli("SELECT autor FROM ksiazka k WHERE EXISTS(SELECT *FROM Barcode B WHERE k.idksiazki=B.idksiazki and B.[Kod kreskowy]='" + x.Value + "')", gz, con);  
                            
                            //////////autor ksiazki

                            Console.WriteLine("Pobrany tytul to: " + test2);
                            Console.WriteLine("Pobrany autor to: " + test3);
                            //Console.WriteLine("Pobrany Tytuł to: " + test3);




                            cmd2a.Parameters.Add(new SqlParameter("@arg1", SqlDbType.Int)).Value = wartoscid2; ////////Arg1 to powinno byc swiezo wstawiona wartosc id Zamówienia
                            cmd2a.Parameters.Add(new SqlParameter("@arg2", SqlDbType.VarChar)).Value = x.Value;//////identyfikator produktu
                            cmd2a.Parameters.Add(new SqlParameter("@arg3", SqlDbType.Int)).Value = x.Count;/////////ilosc produktu
                            cmd2a.Parameters.Add(new SqlParameter("@arg4", SqlDbType.VarChar)).Value = wartosztabeli(" SELECT tytul FROM ksiazka k WHERE EXISTS(SELECT *FROM Barcode B WHERE k.idksiazki=B.idksiazki and B.[Kod kreskowy]='" + x.Value + "')", gz, con);
                            cmd2a.Parameters.Add(new SqlParameter("@arg5", SqlDbType.VarChar)).Value = wartosztabeli("SELECT autor FROM ksiazka k WHERE EXISTS(SELECT *FROM Barcode B WHERE k.idksiazki=B.idksiazki and B.[Kod kreskowy]='" + x.Value + "')", gz, con);                                //////////autor ksiazki
                            

                            
                            
                            cmd2c.Parameters.Add(new SqlParameter("@Ilosc", SqlDbType.Int)).Value = x.Count;/////////ilosc produktu



                            Console.WriteLine("Wartosc parametru=" + x.Value);


                       


                      



                            cmd2c.Parameters.Add(new SqlParameter("@kod", SqlDbType.VarChar)).Value = x.Value;

                            //string jx = wartosztabeli("SELECT [Kod kreskowy] FROM Barcode WHERE idksiazki=" + wynik5 + "", test, con);

                            //Console.WriteLine("Pobrana wartosc=" + jx);

                            cmd2a.ExecuteNonQuery();
                            //cmd2b.ExecuteNonQuery();
                            cmd2c.ExecuteNonQuery();

                            //Console.WriteLine("Sprawdzenie wykonania sql wartosc:"+cmd2a.ExecuteNonQuery());

                        }
                    }catch(Exception ex)
                    {
                        Console.WriteLine("Blad id =2"+ex.Message);

                    }

                   /////////// MessageBox.Show("Nowy rekord zostal dodany", "Nowy rekord", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtSuma.Clear();

                    cmd.Dispose();

                    Console.WriteLine("finalna lista");
                    //for (int i = 0; i < this.lista.Count; i++)
                    //{
                    //    string tmp;
                    //    tmp = this.lista.ElementAt(i).ToString();

                    //    tmp = Regex.Replace(tmp, @"\s+", "");

                    //    Console.WriteLine(tmp);

                    //     //SqlCommand cmd1 = new SqlCommand
                    //    //SqlCommand cmd1 = new SqlCommand//("DELETE FROM Barcode WHERE [Kod kreskowy]=@arg1", con);
                    //    //cmd1.Parameters.Add(new SqlParameter("@arg1", SqlDbType.VarChar)).Value = tmp;



                    //    //cmd1.ExecuteNonQuery();
                    //}
                    this.lista.Clear();
                    this.listaid.Clear();


                    con.Close();
                    Gridzamowienia.Rows.Clear();
                    txtkod.Clear();
                    bind("SELECT *FROM ksiazki", Gridprodukty);
                    MessageBox.Show("Transakcja została zrealizowana", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("BLAD:"+ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
        //    if (Gridprodukty.DataSource == null)
        //    {
        //        MessageBox.Show("Sorry nothing to export into excel sheet..", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    int rowsTotal = 0;
        //    int colsTotal = 0;
        //    int I = 0;
        //    int j = 0;
        //    int iC = 0;
        //    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor;
        //    Excel.Application xlApp = new Excel.Application();

        //    try
        //    {
        //        Excel.Workbook excelBook = xlApp.Workbooks.Add();
        //        Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelBook.Worksheets[1];
        //        xlApp.Visible = true;

        //        rowsTotal = Gridprodukty.RowCount - 1;
        //        colsTotal = Gridprodukty.Columns.Count - 1;
        //        var _with1 = excelWorksheet;
        //        _with1.Cells.Select();
        //        _with1.Cells.Delete();
        //        for (iC = 0; iC <= colsTotal; iC++)
        //        {
        //            _with1.Cells[1, iC + 1].Value = Gridprodukty.Columns[iC].HeaderText;
        //        }
        //        for (I = 0; I <= rowsTotal - 1; I++)
        //        {
        //            for (j = 0; j <= colsTotal; j++)
        //            {
        //                _with1.Cells[I + 2, j + 1].value = DataGridView1.Rows[I].Cells[j].Value;
        //            }
        //        }
        //        _with1.Rows["1:1"].Font.FontStyle = "Bold";
        //        _with1.Rows["1:1"].Font.Size = 12;

        //        _with1.Cells.Columns.AutoFit();
        //        _with1.Cells.Select();
        //        _with1.Cells.EntireColumn.AutoFit();
        //        _with1.Cells[1, 1].Select();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        //RELEASE ALLOACTED RESOURCES
        //        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        //        xlApp = null;
        //    }
        }

        private void Sprzedaz_Load(object sender, EventArgs e)
        {

        }



        }

       
       


        


      












    }

