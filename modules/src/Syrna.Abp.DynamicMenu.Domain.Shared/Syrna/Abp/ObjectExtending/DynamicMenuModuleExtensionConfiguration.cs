﻿using System;
using Volo.Abp.ObjectExtending.Modularity;

namespace Syrna.Abp.ObjectExtending;

public class DynamicMenuModuleExtensionConfiguration : ModuleExtensionConfiguration
{
    public DynamicMenuModuleExtensionConfiguration ConfigureMenuItem(
        Action<EntityExtensionConfiguration> configureAction)
    {
        return this.ConfigureEntity(
            DynamicMenuModuleExtensionConsts.EntityNames.MenuItem,
            configureAction
        );
    }
}