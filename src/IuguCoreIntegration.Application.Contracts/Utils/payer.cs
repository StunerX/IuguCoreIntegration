using System;
using System.Collections.Generic;
using System.Text;

namespace IuguCoreIntegration.Utils
{
    public class payer
    {
        public string cpf_cnpj { get; set; }
        public string name { get; set; }
        public string phone_prefix { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public address address { get; set; }
    }
}
