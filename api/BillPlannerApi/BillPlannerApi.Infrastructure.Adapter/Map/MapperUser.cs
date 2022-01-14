using BillPlannerApi.Application.DTO.DTO;
using BillPlannerApi.Domain.Models;
using BillPlannerApi.Infrastructure.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillPlannerApi.Infrastructure.Adapter.Map
{
    public class MapperUser:IMapperUser
    {
        #region Properties
        List<UserDTO> userDTOs = new List<UserDTO>();
        #endregion

        #region Methods
        public User MapperToEntity(UserDTO userDTO)
        {
            User user = new User
            {
                Id = userDTO.Id,
                FirstName = userDTO.FirstName,
                LastName = userDTO.LastName,
                Email = userDTO.Email
            };
            return user;
        }

        public IEnumerable<UserDTO> MapperListUsers(IEnumerable<User> users)
        {
            foreach (var item in users)
            {
                UserDTO userDTO = new UserDTO
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Email = item.Email
                };
                userDTOs.Add(userDTO);
            }
            return userDTOs;
        }

        public UserDTO MapperToDTO(User user)
        {
            UserDTO userDTO = new UserDTO
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email
            };
            return userDTO;
        }
        #endregion
    }
}
