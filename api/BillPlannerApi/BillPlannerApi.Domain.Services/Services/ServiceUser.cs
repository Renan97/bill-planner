using BillPlannerApi.Domain.Core.Interfaces.Repositorys;
using BillPlannerApi.Domain.Core.Interfaces.Services;
using BillPlannerApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillPlannerApi.Domain.Services.Services
{
    public class ServiceUser : ServiceBase<User>, IServiceUser
    {
        public readonly IRepositoryUser _repositoryUser;
        public ServiceUser(IRepositoryUser RepositoryUser) : base(RepositoryUser)
        {
            _repositoryUser = RepositoryUser;
        }
    }
}
