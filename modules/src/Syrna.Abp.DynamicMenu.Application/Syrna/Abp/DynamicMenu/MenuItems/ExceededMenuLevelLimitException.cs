using Volo.Abp;

namespace Syrna.Abp.DynamicMenu.MenuItems
{
    public sealed class ExceededMenuLevelLimitException : BusinessException
    {
        public ExceededMenuLevelLimitException(int maxLevel)
            : base("Syrna.Abp.DynamicMenu:ExceededMenuLevelLimit")
        {
            Data["MaxLevel"] = maxLevel;
        }
    }
}