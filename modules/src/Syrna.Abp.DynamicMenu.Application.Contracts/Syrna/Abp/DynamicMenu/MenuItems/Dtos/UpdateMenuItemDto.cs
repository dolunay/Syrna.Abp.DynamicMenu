using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.ObjectExtending;

namespace Syrna.Abp.DynamicMenu.MenuItems.Dtos
{
    [Serializable]
    public class UpdateMenuItemDto : CreateOrUpdateMenuItemDto, IHasConcurrencyStamp
    {
        public string ConcurrencyStamp { get; set; }
    }
}