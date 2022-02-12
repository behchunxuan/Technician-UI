using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Technician_UI
{
    internal class Customer
    {
        private string customerID;
        private string username;
        private string orderID;
        private string serviceID;
        private string statusID;
        private string priorityID;
        private string applicationDate;

        // get and set methods
        public string CustomerID { get => customerID; set => customerID = value; }
        public string Username { get => username; set => username = value; }
        public string OrderID { get => orderID; set => orderID = value; }
        public string ServiceID { get => serviceID; set => serviceID = value; }
        public string StatusID { get => statusID; set => statusID = value; }
        public string PriorityID { get => priorityID; set => priorityID = value; }
        public string ApplicationDate { get => applicationDate; set => applicationDate = value; }

        // overload Customer constructors
        public Customer()
        {

        }

        public Customer(string c, string u)
        {
            customerID = c;
            username = u;
        }

        public Customer(string c, string o, string serv, string stat, string p, string d)
        {
            customerID = c;
            orderID = o;  
            serviceID = serv;
            statusID = stat;
            priorityID = p;
            applicationDate = d;
        }

        
    }
}
