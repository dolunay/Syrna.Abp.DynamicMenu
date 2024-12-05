using Volo.Abp;

namespace Syrna.Abp.DynamicMenu.MenuItems
{
    public sealed class NonexistentParentMenuItemException : BusinessException
    {
        public NonexistentParentMenuItemException(string parentId)
            : base("Syrna.Abp.DynamicMenu:NonexistentParentMenuItem")
        {
            Data["ParentId"] = parentId;
        }
    }
}