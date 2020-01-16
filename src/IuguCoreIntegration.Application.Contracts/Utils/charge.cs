using System;
using System.Collections.Generic;
using System.Text;

namespace IuguCoreIntegration.Utils
{
    public class charge
    {
        public string token { get; set; }
        //public string customer_payment_method_id { get; set; }
        //public string restrict_payment_method_id { get; set; }
        //public bool restrict_payment_method { get; set; }
        //public string customer_id { get; set; }
        public string invoice_id { get; set; }
        public string email { get; set; }
        //public int months { get; set; }
        //public int bank_slip_extra_days { get; set; }
        //public bool keep_dunning { get; set; }
        public List<item> items { get; set; }
        public payer payer { get; set; }
        public string order_id { get; set; }

    }
}
