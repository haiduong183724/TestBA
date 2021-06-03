using CustomerCors.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmistServer.Object
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        [MISARequired]
        public string EmployeeCode { get; set; }
        [MISARequired]
        public string EmployeeName { get; set; }
        public int? Gender { get; set; }
        [MISARequired]
        public DateTime? DateOfBirth { get; set; } = null;
        public string IdentifyId { get; set; }
        public string Position { get; set; }
        [MISARequired]
        public string CompanyName { get; set; }
        public string BankAccount { get; set; }
        public string BankName { get; set; }
        public string BankBranch { get; set; }
    }   
}
