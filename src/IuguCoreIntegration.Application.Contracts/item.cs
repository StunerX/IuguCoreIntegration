using System;
using System.Collections.Generic;
using System.Text;

namespace IuguCoreIntegration
{
    public class body
    {
        public string token { get; set; }
        public string email { get; set; }
        public List<item> items { get; set; }
    }
    public class item
    {
        public string description { get; set; }
        public int quantity { get; set; }
        public int price_cents { get; set; } //price_cents tem o padrao 19999 = R$ 199,99
    }
}
