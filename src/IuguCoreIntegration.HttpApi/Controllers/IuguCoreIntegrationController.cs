using IuguCoreIntegration.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace IuguCoreIntegration.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class IuguCoreIntegrationController : AbpController
    {
        protected IuguCoreIntegrationController()
        {
            LocalizationResource = typeof(IuguCoreIntegrationResource);
        }
    }
}