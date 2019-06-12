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
    public partial class Raport_dobowy : Form
    {


       // static int sumaIlosci = 0;
        //static int sumakwoty = 0;


        double sum(int kolumna, DataGridView d)
        {
            double suma = 0;

            for (int i = 0; i < d.Rows.Count; ++i)
            {
                suma = suma + Convert.ToDouble(d.Rows[i].Cells[kolumna].Value) * Convert.ToDouble(d.Rows[i].Cells[kolumna +1].Value);
            }


            return suma;

        }


        int sum1(int kolumna, DataGridView d)
        {
            int suma = 0;

            for (int i = 0; i < d.Rows.Count; ++i)
            {
                suma += Convert.ToInt32(d.Rows[i].Cells[kolumna].Value);
            }


            return suma;

        }



        void wyswietl1()
        {
            try
            {
                SqlConnection con = new SqlConnection(Program.constring);
                con.Open();
                SqlCommand cmd = new SqlCommand("EXEC Raport @d1,@d2", con);
                //SqlCommand cmd2 = new SqlCommand("EXEC Raport @d1,@d2", con);
                cmd.Parameters.Add("@d1", SqlDbType.DateTime, 30, "InvoiceDate").Value = dtpInvoiceDateFrom.Value.Date;
                cmd.Parameters.Add("@d2", SqlDbType.DateTime, 30, "InvoiceDate").Value = dtpInvoiceDateTo.Value.Date;
                SqlDataAdapter myDA = new SqlDataAdapter(cmd);
                DataSet myDataSet = new DataSet();
                myDA.Fill(myDataSet, "Invoice_Info");
                dataGridView1.DataSource = myDataSet.Tables["Invoice_Info"].DefaultView;
                label4.Text = sum(2, dataGridView1).ToString();
                label6.Text = sum1(3, dataGridView1).ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

      
     


        public Raport_dobowy()
        {
            InitializeComponent();

          
            //onsole.WriteLine("Czas od:"+dtpInvoiceDateFrom.Text);
            //Console.WriteLine("Czas do:"+dtpInvoiceDateTo.Text);

            //wyswietl("EXEC Raport '" + dtpInvoiceDateFrom.Value.Date + "', '" + dtpInvoiceDateTo.Text + "'");
            

        }

        private void Raport_dobowy_Load(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {

        }

        private void dtpInvoiceDateFrom_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                wyswietl1();
            }catch(Exception ex)
            {


            }


        }

        private void dtpInvoiceDateTo_ValueChanged(object sender, EventArgs e)
        {
            try
            {
              
                //sum1(4, dataGridView1).ToString();
                //wyswietl("EXEC Raport '" + dtpInvoiceDateFrom.Text + "', '" + dtpInvoiceDateTo.Text + "'");
                wyswietl1();
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }

}