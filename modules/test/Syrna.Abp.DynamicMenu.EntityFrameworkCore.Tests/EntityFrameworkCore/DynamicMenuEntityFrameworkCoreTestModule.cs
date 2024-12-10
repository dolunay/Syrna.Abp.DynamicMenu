using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Syrna.Abp.DynamicMenu.Demo.SqlServer.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Sqlite;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.Uow;

namespace Syrna.Abp.DynamicMenu.EntityFrameworkCore
{
    [DependsOn(
        typeof(DynamicMenuTestBaseModule),
        typeof(DemoEntityFrameworkCoreSqlServerModule),
        typeof(AbpEntityFrameworkCoreSqliteModule)
        )]
    public class DynamicMenuEntityFrameworkCoreTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAlwaysDisableUnitOfWorkTransaction();
            var sqliteConnection = CreateDatabaseAndGetConnection();

            Configure<AbpDbContextOptions>(options =>
            {
                options.Configure(abpDbContextConfigurationContext =>
                {
                    abpDbContextConfigurationContext.DbContextOptions.UseSqlite(sqliteConnection);
                });
            });
        }
        
        private static SqliteConnection CreateDatabaseAndGetConnection()
        {
            var connection = new AbpUnitTestSqliteConnection("Data Source=:memory:");
            connection.Open();

            //new SettingManagementDbContext(
            //    new DbContextOptionsBuilder<SettingManagementDbContext>().UseSqlite(connection).Options
            //).GetService<IRelationalDatabaseCreator>().CreateTables();

            //new IdentityDbContext(
            //    new DbContextOptionsBuilder<IdentityDbContext>().UseSqlite(connection).Options
            //).GetService<IRelationalDatabaseCreator>().CreateTables();

            //new OpenIddictDbContext(
            //    new DbContextOptionsBuilder<OpenIddictDbContext>().UseSqlite(connection).Options
            //).GetService<IRelationalDatabaseCreator>().CreateTables();

            //new PermissionManagementDbContext(
            //    new DbContextOptionsBuilder<PermissionManagementDbContext>().UseSqlite(connection).Options
            //).GetService<IRelationalDatabaseCreator>().CreateTables();

            //new DynamicMenuDbContext(
            //    new DbContextOptionsBuilder<DynamicMenuDbContext>().UseSqlite(connection).Options
            //).GetService<IRelationalDatabaseCreator>().CreateTables();

            new DemoMigrationsDbContext(
                new DbContextOptionsBuilder<DemoMigrationsDbContext>().UseSqlite(connection).Options
            ).GetService<IRelationalDatabaseCreator>().CreateTables();

            return connection;
        }
    }
}
