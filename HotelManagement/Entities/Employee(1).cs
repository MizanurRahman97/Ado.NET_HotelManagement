using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Entities
{
    public class Employee
    {
        public int employeeId { get; set; }
        public string employeeFullName { get; set; }    
        public string employeeUserName { get; set;}
        public string employeeaddress { get; set;}
        public string email { get; set; }
        public string employeeNID { get; set; }
        public string employeePassword { get; set; }
        public string ImagePath { get; set;}
        public string IsActive { get; set;} 
    }
}
