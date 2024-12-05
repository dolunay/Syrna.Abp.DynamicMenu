using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Syrna.Abp.DynamicMenu.EntityFrameworkCore;

[ConnectionStringName("Default")]
public class DemoDbContext(DbContextOptions<DemoDbContext> options) : AbpDbContext<DemoDbContext>(options), IDemoDbContext
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureAbpDynamicMenu();
    }
}
