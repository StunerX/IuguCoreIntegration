using IuguCoreIntegration.Invoices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users;

namespace IuguCoreIntegration.EntityFrameworkCore
{
    public static class IuguCoreIntegrationDbContextModelCreatingExtensions
    {
        public static void ConfigureIuguCoreIntegration(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */
            builder.Entity<Invoice>(i =>
            {
                i.ToTable("Invoices", IuguCoreIntegrationConsts.DbSchema);
                i.ConfigureByConvention(); //auto configure for the base class props
            });
        }

        public static void ConfigureCustomUserProperties<TUser>(this EntityTypeBuilder<TUser> b)
            where TUser: class, IUser
        {
            //b.Property<string>(nameof(AppUser.MyProperty))...
        }
    }
}