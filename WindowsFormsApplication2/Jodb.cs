using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication2
{
    class Jodb
    {
        private SqlConnection polaczenie;


        public Jodb(string user, string pass, string instance, string dbdir)
        {
            polaczenie = new SqlConnection();
            polaczenie.ConnectionString = "user id=" + user + ";" +
            "password=" + pass + ";Data Source=" + instance + ";" +
            "Trusted_Connection=no;" +
            "database=" + dbdir + "; " +
            "connection timeout=3";
            polaczenie.Open();


        }

        public Jodb(string instance, string dbdir)
        {
            polaczenie.ConnectionString = "Data Source=" + instance + ";" +
           "Trusted_Connection=yes;" +
           "database=" + dbdir + "; " +
           "connection timeout=3";


        }


        public DataTable pobierz_dane(string q)
        {
            DataTable dt = new DataTable(); // deklaracja i utworzenie instancji obiektu DataTable o nazwie dt
            SqlDataReader dr; // deklaracja obiektu SqlDataReader o nazwie dr
            SqlCommand sqlc; // Deklaracja obiektu SqlCOmmand

            sqlc = new SqlCommand(q);
            sqlc.Connection = this.polaczenie;
            dr = sqlc.ExecuteReader();
            dt.Load(dr);


            return dt;

        }

  



    }

}