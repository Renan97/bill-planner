using BillPlannerApi.Domain.Core.Interfaces.Repositorys;
using BillPlannerApi.Domain.Models;
using BillPlannerApi.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillPlannerApi.Infrastructure.Repository.Repositorys
{
    public class RepositoryBill : RepositoryBase<Bill>, IRepositoryBill
    {
        private readonly SqlContext _context;
        public RepositoryBill(SqlContext Context) : base(Context)
        {
            _context = Context;
        }
    }
}
