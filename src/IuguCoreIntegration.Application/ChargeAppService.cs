using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace IuguCoreIntegration
{
    public class ChargeAppService : ApplicationService, IChargeAppService
    {
        private readonly string Iugu_API_Token = "14650c211491cd2c13d19b809d5cdb51";
        private readonly string Iugu_Password = "";
        private readonly string Iugu_BaseAddress = "https://api.iugu.com/v1";

        public async Task<DateTime> GetAsync()
        {
            return await Task.Run(() => DateTime.Now);
        }

        public async Task PostAsync(string token)
        {
            await Task.Run(() =>
            {
                body body = new body();
                body.token = token;
                body.email = "teste@teste.com";
                body.items = new List<item>();
                body.items.Add(new item()
                {
                    description = "Ressarcimento Plano 3 CNPJ",
                    price_cents = 1000,
                    quantity = 1
                });

                var content = JsonConvert.SerializeObject(body, Formatting.Indented);

                //JavaScriptSerializer serializer = new JavaScriptSerializer();
                //var content = serializer.Serialize(body);

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
                }
            });
        }
    }
}
