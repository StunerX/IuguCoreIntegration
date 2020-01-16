using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using IuguCoreIntegration.Utils;
using IuguCoreIntegration.Invoices.Interfaces;
using IuguCoreIntegration.Invoices;

namespace IuguCoreIntegration
{
    public class ChargeAppService : ApplicationService, IChargeAppService
    {
        private readonly string Iugu_API_Token = "14650c211491cd2c13d19b809d5cdb51";
        private readonly string Iugu_Password = "";
        private readonly string Iugu_BaseAddress = "https://api.iugu.com/v1";

        private readonly IInvoiceAppService _invoiceAppService;

        public ChargeAppService(IInvoiceAppService invoiceAppService)
        {
            _invoiceAppService = invoiceAppService;
        }

        public async Task<DateTime> GetAsync()
        {
            return await Task.Run(() => DateTime.Now);
        }

        public async Task PostAsync(string token)
        {
            await Task.Run(async () =>
            {
                charge _params = new charge();
                _params.token = token;
                _params.email = "administrativo@escritoriointeligente.com";
                _params.items = new List<item>();
                _params.items.Add(new item()
                {
                    description = "Ressarcimento Plano 3 CNPJ",
                    price_cents = 69999,
                    quantity = 1
                });
                _params.payer = new payer()
                {
                    cpf_cnpj = "91.347.681/0001-14",
                    name = "Severino e Isabelly Casa Noturna Ltda",
                    address = new address()
                    {
                        city = "Birigüi",
                        district = "Vila Isabel Marin",
                        state = "SP",
                        number = "407",
                        street = "Rua Manoel de Carlis",
                        zip_code = "16204-023",
                    },
                    email = "orcamento@severinoeisabellycasanoturnaltda.com.br",
                    phone = "(18) 2998-6706"
                };
                _params.order_id = Guid.NewGuid().ToString();

                var content = JsonConvert.SerializeObject(_params, Formatting.Indented);

                HttpMessageHandler handler = new HttpClientHandler()
                {
                };

                var httpClient = new HttpClient(handler)
                {
                    BaseAddress = new Uri(Iugu_BaseAddress),
                    Timeout = new TimeSpan(0, 2, 0)
                };

                httpClient.DefaultRequestHeaders.Add("ContentType", "application/json");

                var plainTextBytes = System.Text.Encoding.UTF8.GetBytes($"{Iugu_API_Token}:{Iugu_Password}");
                string val = System.Convert.ToBase64String(plainTextBytes);
                httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + val);

                var stringContent = new StringContent(content, UnicodeEncoding.UTF8, "application/json");

                HttpResponseMessage response = httpClient.PostAsync($"{this.Iugu_BaseAddress}/charge", stringContent).Result;

                string responseResult = String.Empty;

                using (StreamReader stream = new StreamReader(response.Content.ReadAsStreamAsync().Result))
                {
                    responseResult = stream.ReadToEnd();

                    try
                    {

                    }
                    catch (Exception)
                    {

                        throw;
                    }

                    var json = JsonConvert.DeserializeObject<invoice>(responseResult);

                    var invoice = new CreateUpdateInvoiceDto()
                    {
                        Message = json.message,
                        InvoiceId = json.invoice_id,
                        Success = json.success,
                        Pdf = json.pdf,
                        Url = json.url,
                    };

                    var result = await _invoiceAppService.CreateAsync(invoice);
                }
            });
        }
    }
}
