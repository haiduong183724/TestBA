using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmistServer.Object
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public int? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IdentifyId { get; set; }
        public string Position { get; set; }
        public string CompanyName { get; set; }
        public string BankAccount { get; set; }
        public string BankName { get; set; }
        public string BankBranch { get; set; }
    }   
}
