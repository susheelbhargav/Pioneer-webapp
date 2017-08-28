using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class EmployeeDetailsmodels
    {
        public int EmployeeId;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public long MobileNumber { get; set; }
        public long AlternateMobileNumber { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string CurrentCountry { get; set; }
        public string HomeCountry { get; set; }
        public long ZipCode { get; set; }

       
    }
}
