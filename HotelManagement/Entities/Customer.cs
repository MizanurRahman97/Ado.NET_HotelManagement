using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Entities
{
    public class Customer
    {
        public int customerId { get; set; }
        public string customerFName { get; set; }
        public string customerLName { get; set; }
        public string customerfathersName { get; set; }
        public string customerMothersName { get; set;}
        public DateTime  customerDateofBirth { get; set; }
        public string customerNID { get; set; }
        public string Occupation { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime customerBookingDate { get; set; }
        public string customerBookingTime { get; set;}
        public int employeeId { get; set;}
        
        public int roomId { get; set; }
        public int bookingId { get; set; }
        public string ImagePath { get; set; }

    }
}
