using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Syrna.Abp.DynamicMenu.MongoDB
{
    public class DynamicMenuMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public DynamicMenuMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}