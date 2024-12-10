using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Syrna.Abp.DynamicMenu.Demo.SettingManagement;

public interface IDemoSettingsAppService : IApplicationService
{
    Task<DemoSettingsDto> GetAsync();

    Task UpdateAsync(UpdateDemoSettingsDto input);
}
