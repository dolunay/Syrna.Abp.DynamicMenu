using System;
using System.Linq;
using System.Threading.Tasks;
using Syrna.Abp.DynamicMenu.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Syrna.Abp.DynamicMenu.MenuItems
{
    public class MenuItemRepository : EfCoreRepository<IDynamicMenuDbContext, MenuItem>, IMenuItemRepository
    {
        public MenuItemRepository(IDbContextProvider<IDynamicMenuDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public override async Task<IQueryable<MenuItem>> WithDetailsAsync()
        {
            return (await base.WithDetailsAsync()).IncludeDetails();
        }
    }
}