using System;
using System.Collections.Generic;
using System.Text;

namespace BillPlannerApi.Application.DTO.DTO
{
    public class UserDTO
    {
        public int? Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
