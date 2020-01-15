using System;
using System.Collections.Generic;
using System.Text;
using IuguCoreIntegration.Localization;
using Volo.Abp.Application.Services;

namespace IuguCoreIntegration
{
    /* Inherit your application services from this class.
     */
    public abstract class IuguCoreIntegrationAppService : ApplicationService
    {
        protected IuguCoreIntegrationAppService()
        {
            LocalizationResource = typeof(IuguCoreIntegrationResource);
        }
    }
}
