using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerCors.Entity
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        [MISARequired]
        public string CustomerCode { get; set; }
        [MISARequired]
        public string LastName { get; set; }
        public string FullName { get; set; }
        [MISARequired]
        public int? Gender { get; set; }
        public string Address { get; set; }
        [MISARequired]
        public DateTime? DateOfBirth { get; set; } = null;
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Guid CustomerGroupId { get; set; }
        public double? DebitAmout { get; set; }
        public string MemberCardCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyTaxCode { get; set; }
        public int? IsStopFollow { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
