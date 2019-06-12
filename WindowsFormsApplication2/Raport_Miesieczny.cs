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
    public partial class Raport_Miesieczny : Form
    {


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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }﻿
          
        
        }



        public Raport_Miesieczny()
        {
            InitializeComponent();
        }

        private void Raport_Miesieczny_Load(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {

        }
    }
}
