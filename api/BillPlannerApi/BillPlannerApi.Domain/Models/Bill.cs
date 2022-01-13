using System;
using System.Collections.Generic;
using System.Text;

namespace BillPlannerApi.Domain.Models
{
    public class Bill:Base
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public int TotalInstallments { get; set; }
        public int CurrentInstallment { get; set; }
        public DateTime FinalPaymentDate { get; set; }
        public DateTime ExpectedPaymetDate { get; set; }
        public virtual Bill Bills { get; set; }
    }
}
