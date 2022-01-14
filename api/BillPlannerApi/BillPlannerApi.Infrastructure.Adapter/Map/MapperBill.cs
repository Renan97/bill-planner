using BillPlannerApi.Application.DTO.DTO;
using BillPlannerApi.Domain.Models;
using BillPlannerApi.Infrastructure.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillPlannerApi.Infrastructure.Adapter.Map
{
    public class MapperBill:IMapperBill
    {
        #region Properties

        List<BillDTO> billDTOs = new List<BillDTO>();

        #endregion

        #region Methods

        public Bill MapperToEntity(BillDTO billDTO)
        {
            Bill bill = new Bill
            {

                Id = billDTO.Id,
                Name = billDTO.Name,
                Value = billDTO.Value
            };

            return bill;

        }

        public IEnumerable<BillDTO> MapperListBills(IEnumerable<Bill> bills)
        {
            foreach (var item in bills)
            {

                BillDTO billDTO = new BillDTO
                {
                    Id = item.Id,
                    Name = item.Name,
                    Value = item.Value

                };

                billDTOs.Add(billDTO);
            }


            return billDTOs;

        }

        public BillDTO MapperToDTO(Bill bill)
        {
            BillDTO billDTO = new BillDTO
            {
                Id = bill.Id,
                Name = bill.Name,
                Value = bill.Value
            };

            return billDTO;

        }

        #endregion
    }
}
