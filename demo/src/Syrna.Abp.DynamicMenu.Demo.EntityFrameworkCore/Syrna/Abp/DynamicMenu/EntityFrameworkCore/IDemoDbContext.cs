using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Syrna.Abp.DynamicMenu.MenuItems;

namespace Syrna.Abp.DynamicMenu.EntityFrameworkCore
{
    [ConnectionStringName(DynamicMenuDbProperties.ConnectionStringName)]
    public interface IDemoDbContext : IEfCoreDbContext
    {
    }
}
