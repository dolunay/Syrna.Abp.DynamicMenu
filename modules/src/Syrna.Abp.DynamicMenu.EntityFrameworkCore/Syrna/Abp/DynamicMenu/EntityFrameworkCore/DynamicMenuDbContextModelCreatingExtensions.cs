using Syrna.Abp.DynamicMenu.MenuItems;
using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Syrna.Abp.DynamicMenu.EntityFrameworkCore
{
    public static class DynamicMenuDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpDynamicMenu(
            this ModelBuilder builder,
            Action<DynamicMenuModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new DynamicMenuModelBuilderConfigurationOptions(
                DynamicMenuDbProperties.DbTablePrefix,
                DynamicMenuDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            builder.Entity<MenuItem>(b =>
            {
                b.ToTable(options.TablePrefix + "MenuItems", options.Schema);
                b.ConfigureByConvention();

                /* Configure more properties here */

                b.HasIndex(e => new { e.ParentId });

                b.HasMany(x => x.MenuItems).WithOne().HasForeignKey(x => x.ParentId);
            });
        }
    }
}
