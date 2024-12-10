using System.Threading.Tasks;

namespace Syrna.Abp.DynamicMenu.Demo.Data;

public interface IDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
