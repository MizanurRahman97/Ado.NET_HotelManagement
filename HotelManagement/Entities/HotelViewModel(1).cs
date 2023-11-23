using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Entities
{
    public class HotelViewModel
    {
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public int bookingId { get; set; }
        public int roomId { get; set; }
        public string customerFName { get; set; }
        public string customerLName { get; set; }
        public string customerFathersName { get; set; }
        public string customerMothersName { get; set; }
        public DateTime custDateofBirth { get; set; }
        public string customerNID { get; set; }
        public string customerOccupation { get; set; }
        public string customerPhoneNo { get; set; }
        public string customerEmail { get; set; }
        public DateTime custBookingDate { get; set; }
        public string Employeefullname { get; set; }
        public string EmployeeUserName { get; set; }
        public string EmployeeAddress { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeeNID { get; set; }
        public string EmployeePassword { get; set; }
        public string ImgagePath { get; set; }
        public string roomCategory { get; set;}
    }
}
