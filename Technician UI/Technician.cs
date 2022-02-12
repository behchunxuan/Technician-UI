using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Technician_UI
{
    internal class Technician
    {
        private static string technicianID;
        private string username;

        // get and set methods
        public string TechnicianID { get => technicianID; set => technicianID = value; }
        public string Username { get => username; set => username = value; }

        // sql connection to TechieMen database
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TechieMen"].ToString());

        // overload Technician constructors
        public Technician()
        {

        }
        public Technician(string t, string u)
        {
            technicianID = t;
            username = u;
        }
        public static ArrayList viewService()
        {
            con.Open();

            // find the total number of the services
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM [OrderServiceDetails]", con);
            int num = (int)cmd1.ExecuteScalar();

            ArrayList serv_list = new ArrayList();

            // getting the service details from OrderServiceDetails table and ServicePriority table
            SqlCommand cmd2 = new SqlCommand("SELECT [OrderServiceDetails].OrderID, [OrderServiceDetails].StatusID, [OrderServiceDetails].Service_PriorityID, [ServicePriority].ServiceID FROM [OrderServiceDetails] INNER JOIN [ServicePriority] ON [OrderServiceDetails].Service_PriorityID = [ServicePriority].Service_PriorityID; ", con);
            SqlDataReader rd = cmd2.ExecuteReader();

            while (rd.Read())
            {
                // putting all the service details into serv_list
                serv_list.Add(rd.GetString(0));
                serv_list.Add(rd.GetString(3));
                serv_list.Add(rd.GetString(1));
                serv_list.Add(rd.GetString(2));
            }

            con.Close();
            return serv_list;
        }
        public string[] view_order_details(string o, string serv, string stat, string p)
        {
            string[] order_details = new string[6];

            string orderID = o;
            string serviceID = serv;
            string statusID = stat;
            string priorityID = p;  

            // find the customerID based on the orderID
            SqlCommand cmd3 = new SqlCommand("SELECT CustomerID FROM [OrderService] WHERE OrderID = '" + orderID + "'", con);

            // find the applicationDate based on the orderID
            SqlCommand cmd4 = new SqlCommand("SELECT ApplicationDate FROM [OrderServiceDetails] WHERE OrderID = '" + orderID + "'", con);
            
            con.Open();
            string customerID = cmd3.ExecuteScalar().ToString();
            string applicationDate = cmd4.ExecuteScalar().ToString();

            // putting the service details into order_details
            order_details[0] = customerID;
            order_details[1] = orderID;
            order_details[2] = serviceID;
            order_details[3] = statusID;
            order_details[4] = priorityID;
            order_details[5] = applicationDate;


            con.Close();

            return order_details;
            
        }

        public string update_order_details(string o, DateTime d, string desc, string stat)
        {
            string update_status = null;

            // calling the Username get method
            username = User.Username;

            string orderID = o;
            DateTime collectionDate = d;
            string serv_desc = desc;
            string serv_stat = stat;

            // find the technician ID which is updating the service details based on the technician username
            SqlCommand cmd5 = new SqlCommand("SELECT TechnicianID FROM [Technician] WHERE Username = '" + username + "'", con);

            // update the service details made by the technician based on the orderID
            SqlCommand cmd6 = new SqlCommand("UPDATE [OrderServiceDetails] SET StatusID = '" + stat + "', ServiceDescription = '" + serv_desc + "', CollectionDate = '" + collectionDate + "' WHERE OrderID = '" + orderID + "'", con);

            con.Open();

            technicianID = cmd5.ExecuteScalar().ToString();

            // update the technicianID into OrderService table based on the orderID
            SqlCommand cmd7 = new SqlCommand("UPDATE [OrderService] SET TechnicianID = '" + technicianID + "' WHERE OrderID = '" + orderID + "'", con);

            // execute the update commands
            int ind = cmd6.ExecuteNonQuery();
            int ind2 = cmd7.ExecuteNonQuery();

            if (ind != 0 && ind2 != 0)
            {
                update_status = "Service Details Updated Successfully";
            }
            else
                update_status = "Sorry, Failed to Update";

            con.Close();

            return update_status;
        }
    }
}
