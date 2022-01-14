using BillPlannerApi.Domain.Core.Interfaces.Repositorys;
using BillPlannerApi.Domain.Models;
using BillPlannerApi.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillPlannerApi.Infrastructure.Repository.Repositorys
{
    public class RepositoryUser : RepositoryBase<User>, IRepositoryUser
    {
        private readonly SqlContext _context;
        public RepositoryUser(SqlContext Context) : base(Context)
        {
            _context = Context;
        }
    }
}
