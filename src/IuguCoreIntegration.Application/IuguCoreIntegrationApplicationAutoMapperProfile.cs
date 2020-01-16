using AutoMapper;
using IuguCoreIntegration.Invoices;

namespace IuguCoreIntegration
{
    public class IuguCoreIntegrationApplicationAutoMapperProfile : Profile
    {
        public IuguCoreIntegrationApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Invoice, InvoiceDto>();
            CreateMap<CreateUpdateInvoiceDto, Invoice>();
        }
    }
}
