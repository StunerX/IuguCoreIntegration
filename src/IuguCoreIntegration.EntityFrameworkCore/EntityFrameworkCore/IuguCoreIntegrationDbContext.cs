﻿using Microsoft.EntityFrameworkCore;
using IuguCoreIntegration.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users.EntityFrameworkCore;
using IuguCoreIntegration.Invoices;

namespace IuguCoreIntegration.EntityFrameworkCore
{
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See IuguCoreIntegrationMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class IuguCoreIntegrationDbContext : AbpDbContext<IuguCoreIntegrationDbContext>
    {
        public DbSet<AppUser> Users { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside IuguCoreIntegrationDbContextModelCreatingExtensions.ConfigureIuguCoreIntegration
         */

        public IuguCoreIntegrationDbContext(DbContextOptions<IuguCoreIntegrationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable("AbpUsers"); //Sharing the same table "AbpUsers" with the IdentityUser
                b.ConfigureByConvention();
                b.ConfigureAbpUser();

                //Moved customization to a method so we can share it with the IuguCoreIntegrationMigrationsDbContext class
                b.ConfigureCustomUserProperties();
            });

            /* Configure your own tables/entities inside the ConfigureIuguCoreIntegration method */

            builder.ConfigureIuguCoreIntegration();
        }
    }
}
