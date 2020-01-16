using IuguCoreIntegration.Invoices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace IuguCoreIntegration.Invoices
{
    public class InvoiceAppService : CrudAppService<Invoice, InvoiceDto, Guid, List<InvoiceDto>, CreateUpdateInvoiceDto, CreateUpdateInvoiceDto>, IInvoiceAppService
    {
        private readonly IRepository<Invoice, Guid> _repository;
        public InvoiceAppService(IRepository<Invoice, Guid> repository) : base(repository)
        {
            _repository = repository;
        }

        

        //public async Task<List<InvoiceDto>> Get()
        //{
        //    var invoices = await _repository.GetListAsync();

        //    var result = ObjectMapper.Map<List<Invoice>, List<InvoiceDto>>(invoices);

        //    return result;
        //}
    }
}
