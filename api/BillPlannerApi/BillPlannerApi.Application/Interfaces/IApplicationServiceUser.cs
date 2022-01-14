using BillPlannerApi.Application.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillPlannerApi.Application.Interfaces
{
    public interface IApplicationServiceUser
    {
        void Add(UserDTO obj);
        UserDTO GetById(int id);
        IEnumerable<UserDTO> GetAll();
        void Update(UserDTO obj);

        void Remove(UserDTO obj);

        void Dispose();
    }
}
