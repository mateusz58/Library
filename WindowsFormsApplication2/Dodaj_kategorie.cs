using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{

    
    public partial class Dodaj_kategorie : Form
    {

        private const string select = "SELECT *FROM Gatunek";
        public Dodaj_kategorie()
        {
            InitializeComponent();
            bind(GridGatunek, select);
            //Gridzamowienia.Columns[3].Visible = false;
        }


        
        private void button1_Click(object sender, EventArgs e)
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

        private void delete_records(string sql,TextBox t, string kolumna, string tabela)////////////////////usuniecie rekordu         Przyklad poprawnego argumentu delete from [User] where [Username]=@uname
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
                MessageBox.Show("Rekord został usunięty..!", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Autocomplete(kolumna,tabela);
                t.Clear();
            }
            else
            {
                MessageBox.Show("Brak takiego rekordu", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                t.Clear();
                Autocomplete(kolumna,tabela);
            }

        }

       private void bind(DataGridView d,string sql)///////sluzy do wyswietlania tabeli na poczatku istnienia//Przyklad komendy " select * from dbo.[User] ;"
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








        void dodajrekord(string sql,TextBox t1)
            {


                try
                {


                    SqlConnection con = new SqlConnection(Program.constring);


                    con.Open();


                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add(new SqlParameter("@usr", SqlDbType.VarChar)).Value = t1.Text;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dodano nowy Gatunek książki", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    cmd.Dispose();
                    con.Close();
                    bind(GridGatunek,select);



                }
                catch (Exception ex)
                {

                }
            }

        private void butUsun_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text == "")
            {
                MessageBox.Show("Brak gatunku do dodania.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Czy na pewno chcesz usunąć ten gatunek książki?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                delete_records("delete from [Gatunek] WHERE (nazwa)=@uname", txtCategory,"nazwa","Gatunek");
            }
        }

        private void Dodaj_kategorie_Load(object sender, EventArgs e)
        {

        }

    

    }
}
