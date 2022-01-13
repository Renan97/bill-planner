using BillPlannerApi.Domain.Core.Interfaces.Repositorys;
using BillPlannerApi.Domain.Core.Interfaces.Services;
using BillPlannerApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillPlannerApi.Domain.Services.Services
{
    public class ServiceBill : ServiceBase<Bill>, IServiceBill
    {
        public readonly IRepositoryBill _repositoryBill;
        public ServiceBill(IRepositoryBill RepositoryBill) : base(RepositoryBill)
        {
            _repositoryBill = RepositoryBill;
        }
    }
}
