using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.ObjectExtending;

namespace Syrna.Abp.DynamicMenu.MenuItems.Dtos
{
    public abstract class CreateOrUpdateMenuItemDto : ExtensibleObject
    {
        [Required]
        [MaxLength(450)]
        public string Id { get; set; }
               
        [MaxLength(450)]
        public string ParentId { get; set; }

        [MaxLength(255)]
        public string DisplayName { get; set; }

        [MaxLength(2048)]
        public string Url { get; set; }

        [MaxLength(2048)]
        public string UrlMvc { get; set; }

        [MaxLength(2048)]
        public string UrlBlazor { get; set; }

        [MaxLength(2048)]
        public string UrlAngular { get; set; }

        [MaxLength(255)]
        public string Permission { get; set; }

        public int? Order { get; set; }

        [MaxLength(255)]
        public string Icon { get; set; }

        [MaxLength(10)]
        public string Target { get; set; }

        public bool InAdministration { get; set; }

        public bool IsPublic { get; set; }

        public bool IsDisabled { get; set; }

        [MaxLength(255)]
        public string LResourceTypeName { get; set; }

        [MaxLength(255)]
        public string LResourceTypeAssemblyName { get; set; }
        
        protected CreateOrUpdateMenuItemDto()
            : base(setDefaultsForExtraProperties: false)
        {
        }
    }
}