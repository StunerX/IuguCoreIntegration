using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace IuguCoreIntegration.Invoices
{
    public class InvoiceDto : AuditedEntityDto<Guid>
    {
        public string Message { get; set; }
        public string Error { get; set; }
        public bool Success { get; set; }
        public string Url { get; set; }
        public string Pdf { get; set; }
        public string InvoiceId { get; set; }
        public string LR { get; set; }
    }
}
