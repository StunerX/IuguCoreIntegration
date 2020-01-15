using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace IuguCoreIntegration
{
    public interface IChargeAppService : IApplicationService
    {
        Task<DateTime> GetAsync();

        Task PostAsync(string token);
    }
}
