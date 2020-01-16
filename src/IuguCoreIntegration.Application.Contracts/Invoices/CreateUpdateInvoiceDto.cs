using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IuguCoreIntegration.Invoices
{
    public class CreateUpdateInvoiceDto
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
