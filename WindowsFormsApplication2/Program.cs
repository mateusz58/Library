using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    static class Program
    {

        public static readonly string constring = "Data Source=(localdb)\\Projects;Initial Catalog=Bookstore;Integrated Security=true";


       public static bool Regexcheck(string strIn,string regex)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(strIn,regex);
        }
        //@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$//przyklad regex


        public static bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

       
      
        
        public static string  Regexspacedelete="[a-zA-Z0-9]+";


        ///

        //bool IsValidEmail(string strIn)
        //{
        //    // Return true if strIn is in valid e-mail format.
        //    return Regex.IsMatch(strIn, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        //}

        //Przykladowe wywolanie 

        /// <summary>
        /// ///////
        /// </summary>
        /// <param name="pageContent"></param>
        /// <param name="regexPattern"></param>
        /// <returns></returns>


        //////////Funkcja ktora moze sie przydac dotyczy tego jak przekonwertowac tekst przy pomocy regex
  

        ///////////////

//////////////////Najprostszy sposob na przekonwertowanie tringa ////Ponizszy przyklad dotyczy usuniecia spacji
     //////////////   LastName = Regex.Replace(LastName, @"\s+", "");


       

        
       //     string i=@"^[^\s][a-zA-Z]*$";

       //public string value="Admin         ";


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        
        static void Main()
        {
           // Console.WriteLine("sprawdz");
           // string format = "62145";

           //if(Regex.IsMatch(format, "@*[0-9]")==true)
           //{

           //    Console.WriteLine("Sukes");

           //}





          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());




           







        }
    }
}
