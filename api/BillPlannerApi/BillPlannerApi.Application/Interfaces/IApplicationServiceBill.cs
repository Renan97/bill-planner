using BillPlannerApi.Application.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillPlannerApi.Application.Interfaces
{
    public interface IApplicationServiceBill
    {
        void Add(BillDTO obj);

        BillDTO GetById(int id);

        IEnumerable<BillDTO> GetAll();

        void Update(BillDTO obj);

        void Remove(BillDTO obj);

        void Dispose();
    }
}
