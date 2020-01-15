using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace IuguCoreIntegration.Charges
{
    public class Invoice : AuditedEntity<Guid>
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
