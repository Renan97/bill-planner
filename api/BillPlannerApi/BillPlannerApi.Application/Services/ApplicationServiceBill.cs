using BillPlannerApi.Application.DTO.DTO;
using BillPlannerApi.Application.Interfaces;
using BillPlannerApi.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillPlannerApi.Application.Services
{
    public class ApplicationServiceBill : IDisposable, IApplicationServiceBill
    {
        private readonly IServiceBill _serviceBill;
        private readonly IMapperBill _mapperBill;

        public ApplicationServiceBill(IServiceBill ServiceBill, IMapperBill MapperBill)
        {
            _serviceBill = ServiceBill;
            _mapperBill = MapperBill;
        }

        public void Add(BillDTO obj)
        {
            var objBill = _mapperBill.MapperToEntity(obj);
            _serviceBill.Add(objBill);
        }

        public void Dispose()
        {
            _serviceBill.Dispose();
        }

        public IEnumerable<BillDTO> GetAll()
        {
            var objBills = _serviceBill.GetAll();
            return _mapperBill.MapperListBills(objBills);
        }

        public BillDTO GetById(int id)
        {
            var objBill = _serviceBill.GetById(id);
            return _mapperBill.MapperToDTO(objBill);
        }

        public void Remove(BillDTO obj)
        {
            var objBill = _mapperBill.MapperToEntity(obj);
            _serviceBill.Remove(objBill);
        }

        public void Update(BillDTO obj)
        {
            var objBill = _mapperBill.MapperToEntity(obj);
            _serviceBill.Update(objBill);
        }
    }
}
