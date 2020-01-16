using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace IuguCoreIntegration.Invoices.Interfaces
{
    public interface IInvoiceAppService : ICrudAppService<InvoiceDto, Guid, List<InvoiceDto>, CreateUpdateInvoiceDto, CreateUpdateInvoiceDto>
    {
    }
}
