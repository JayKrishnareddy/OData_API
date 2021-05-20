using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OData_API.Models
{
    public class EmployeeModel
    {
        public int   Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string City { get; set; }
        public int  Pincode { get; set; }
    }
}
