using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;

namespace Technician_UI
{
    internal class User
    {
        // To reserve the username from forgot password and used in reset password
        private static string username;
        private string password;
        private string firstName;
        private string lastName;
        private string email;
        private string mobile;

        // get and set methods
        public static string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public string Mobile { get => mobile; set => mobile = value; }
        
        // sql connection to TechieMen database
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TechieMen"].ToString());

        // overload User constructors
        public User()
        {
            
        }

        public User(string u)
        {
            username = u;
        }

        public User(string u, string p)
        {
            username = u;
            password = p;
        }

        public User(string u, string fn, string ln, string e, string m)
        {
            username = u;
            firstName = fn;
            lastName = ln;
            email = e;
            mobile = m;
        }

        public string login()
        {
            string login_stat = null;

            // check the existence of the user
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM UserDetails WHERE Username = '" + username + "' AND Password = '" + password + "'", con);

            con.Open();
            int count = (int)cmd1.ExecuteScalar();

            if (count > 0)
            {
                // Search the role of the user in 4 tables
                SqlCommand cmd2 = new SqlCommand("SELECT 'Admin' AS Role FROM Admin WHERE Username = '" + username + "' " +
                                                    "UNION SELECT 'Technician' AS Role FROM Technician WHERE Username = '" + username + "' " +
                                                    "UNION SELECT 'Customer' AS Role FROM Customer WHERE Username = '" + username + "' " +
                                                    "UNION SELECT 'Receptionist' AS Role FROM Receptionist WHERE Username = '" + username + "' ", con);

                string role = (string)cmd2.ExecuteScalar();

                if (role == "Technician")
                    login_stat = "1";
                else if (role == "Admin")
                    login_stat = "2";
                else if (role == "Customer")
                    login_stat = "3";
                else if (role == "Receptionist")
                    login_stat = "4";
            }

            con.Close();

            return login_stat;
        }

        public string forgot_password()
        {
            string forgot_stat = null;

            // find the existence of the user based on the information provided by the password forgotten user
            SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM UserDetails WHERE Username = '" + username + "' AND FirstName = '" + firstName + "' AND LastName = '" + lastName + "' AND PhoneNumber = '" + mobile + "' AND EmailAddress = '" + email + "' ", con);
            con.Open();

            int count = (int)cmd3.ExecuteScalar();

            if (count > 0)
            {
                Reset_Password reset = new Reset_Password();
                reset.ShowDialog();
            }
            else
                forgot_stat = "Incorrect information provided, Please Try Again";
                
            con.Close();
            return forgot_stat;
        }

        public string reset_password(string c)
        {
            string reset_stat;
            string confirm_password = c;

            // update the password based on the username of the user
            SqlCommand cmd4 = new SqlCommand("UPDATE UserDetails SET Password = '" + confirm_password + "' WHERE Username = '" + username + "'", con);
            con.Open();

            int i = cmd4.ExecuteNonQuery();
            if (i > 0)
            {
                reset_stat = "Reset Password Successfully";
            }
            else
                reset_stat = "Sorry, Reset Password Unsuccessfully";

            con.Close();
            return reset_stat;
        }

        public string[] view_profile_details()
        {
            string[] personal_details = new string[7];

            // find the user details before loading the profile form based on the username
            SqlCommand cmd5 = new SqlCommand("SELECT Password, FirstName, LastName, PhoneNumber, DOB, EmailAddress FROM [UserDetails] WHERE Username = '" + username + "'", con);

            con.Open();

            SqlDataReader rd = cmd5.ExecuteReader();

            while (rd.Read())
            {
                for (int i = 0; i < 6; i++) // adding user details into personal_details
                {
                    if (i == 4) // when i = 4, retrieve the information as datetime format
                    {
                        personal_details[i] = rd.GetDateTime(i).ToString();
                    }
                    else
                        personal_details[i] = rd.GetString(i);
                }
            }

            personal_details[6] = username;

            return personal_details;
        }

        public string update_personal_profile(string[] new_per_details)
        {
            string update_status = null;
            string[] new_personal_details = new_per_details;

            string password = new_personal_details[0];
            string first_name = new_personal_details[1];
            string last_name = new_personal_details[2];
            string mobile = new_personal_details[3];
            DateTime dob = DateTime.ParseExact(new_personal_details[4], "MM/dd/yyyy", CultureInfo.InvariantCulture); // convert the given string into the custom datetime format
            string email = new_personal_details[5];

            string username = new_personal_details[6];

            // update the current user details based on the username
            SqlCommand cmd6 = new SqlCommand("UPDATE [UserDetails] SET Password = '" + password + "', FirstName = '" + first_name + "', LastName = '" + last_name + "', PhoneNumber = '" + mobile + "', DOB = '" + dob + "', EmailAddress = '" + email + "' WHERE Username = '" + username + "'", con);

            con.Open();
            int i = cmd6.ExecuteNonQuery();

            if (i != 0)
            {
                update_status = "Personal Details Updated Successfully";
            }
            else
                update_status = "Failed to update";

            con.Close();
            return update_status;
        }
    }
}
