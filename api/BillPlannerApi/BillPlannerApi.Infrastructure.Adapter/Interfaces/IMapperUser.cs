using BillPlannerApi.Application.DTO.DTO;
using BillPlannerApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillPlannerApi.Infrastructure.Adapter.Interfaces
{
    public interface IMapperUser
    {
        User MapperToEntity(UserDTO userDTO);
        IEnumerable<UserDTO> MapperListUsers(IEnumerable<User> user);
        UserDTO MapperToDTO(User user);
    }
}
