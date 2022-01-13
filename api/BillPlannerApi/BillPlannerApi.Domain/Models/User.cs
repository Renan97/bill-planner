using System;
using System.Collections.Generic;
using System.Text;

namespace BillPlannerApi.Domain.Models
{
    public class User: Base
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime SignupDate { get; set; }
        public bool Active { get; set; }
    }
}
