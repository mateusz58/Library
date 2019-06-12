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
    public partial class Historia_sprzedazy : Form
    {


        void bind(string komenda, DataGridView d)
        {

            //.ClearSelection();

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
                d.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }﻿
          
        }






        public Historia_sprzedazy()
        {
            InitializeComponent();
            bind("SELECT *FROM Zamowienia", Historiasprzedazy1);
            Historiasprzedazy1.Columns[0].Visible = false;
            //Historiasprzedazy1.Columns[1].



        }

        private void Historia_sprzedazy_Load(object sender, EventArgs e)
        {
         
        }

      
    }
}
