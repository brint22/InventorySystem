 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Models
{
    public class Employee
    {                                    
        public string EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string NameExtension { get; set; }
        public string Gender { get; set; }
        public string CivilStatus { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateHired { get; set; }
        public string Address { get; set; }
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public int AccountID { get; set; }
        public int ImageID { get; set; }
    }
}
