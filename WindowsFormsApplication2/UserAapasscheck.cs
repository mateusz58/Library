




//namespace windowsformsapplication2
//{
//    class useraapasscheck
//    {


//        private void adduser(string username, string password, string confirmpass, string email)
//        {

//            regex regex = new regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

//            match match = regex.match(email);




//            foreach (datarow row in loginsdataset.logins)
//            {

               

//                if (row.itemarray[0].equals(username))
//                {

 

//                    messagebox.show("username already exists");

//                    return;

//                }

//            }





//            if (password != confirmpass)
//            {

//                messagebox.show("passwords do not match");

//            }



//            else if (password.length < 8)
//            {

//                messagebox.show("password must be at least 8 characters long");

//            }



//            else if (!match.success)
//            {

//                messagebox.show("invalid email");

//            }



//            else if (username == null)
//            {

//                messagebox.show("must have username");

//            }

    

//            else
//            {

//                loginsdataset.loginsrow newuserrow = loginsdataset.logins.newloginsrow();



//                string encryptedpass = hashpass(password);

//                newuserrow.username = username;

//                newuserrow.password = encryptedpass;

//                newuserrow.email = email;



//                loginsdataset.logins.rows.add(newuserrow);

//                registerusername.text = string.empty;

//                registerpassword.text = string.empty;

//                registerconfirmpassword.text = string.empty;

//                registeremail.text = string.empty;

//                messagebox.show("thank you for registering!");

//                if (string.isnullorwhitespace(smtpemail) || string.isnullorwhitespace(smtppassword) || string.isnullorwhitespace(smtpaddress) || smtpport <= 0)
//                {

//                    messagebox.show("email configuration is not set up correctly! \ncannot sent email!");



//                }

//                else
//                {

//                    sendmessage(email.tostring(), username.tostring(), password.tostring());

//                }

//            }

//        }












//    }
//}
