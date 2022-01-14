using BillPlannerApi.Application.DTO.DTO;
using BillPlannerApi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillPlannerApi.Infrastructure.Adapter.Interfaces
{
    public interface IMapperBill
    {
        Bill MapperToEntity(BillDTO billDTO);
        IEnumerable<BillDTO> MapperListBills(IEnumerable<Bill> bill);
        BillDTO MapperToDTO(Bill bill);
    }
}
