# Syrna.Abp.DynamicMenu
DynamicMenu module for ABP framework.

[![ABP version](https://img.shields.io/badge/dynamic/xml?style=flat-square&color=yellow&label=abp&query=%2F%2FProject%2FPropertyGroup%2FVoloAbpPackageVersion&url=https%3A%2F%2Fraw.githubusercontent.com%2FDolunay%2FSyrna.Abp.DynamicMenu%2Fmaster%2FDirectory.Packages.props)](https://abp.io)
![build and test](https://img.shields.io/github/actions/workflow/status/dolunay/Syrna.Abp.DynamicMenu/publish.yml?branch=master&style=flat-square)
[![NuGet Download](https://img.shields.io/nuget/dt/Syrna.Abp.DynamicMenu.Application.svg?style=flat-square)](https://www.nuget.org/packages/Syrna.Abp.DynamicMenu.Application)
[![NuGet (with prereleases)](https://img.shields.io/nuget/vpre/Syrna.Abp.DynamicMenu.Application.svg?style=flat-square)](https://www.nuget.org/packages/Syrna.Abp.DynamicMenu.Application) 

An abp module that dynamically creates menu items for ABP UI projects in runtime.

![DynamicMenu](https://github.com/user-attachments/assets/96dd349c-3e29-41f5-8a45-00f6c6cb3ddb)

## Installation

1. Install the following NuGet packages. ([see how](https://github.com/Dolunay/SyrnaAbpGuide/blob/master/docs/How-To.md#add-nuget-packages))

    * Syrna.Abp.DynamicMenu.Application
    * Syrna.Abp.DynamicMenu.Application.Contracts
    * Syrna.Abp.DynamicMenu.Domain
    * Syrna.Abp.DynamicMenu.Domain.Shared
    * Syrna.Abp.DynamicMenu.EntityFrameworkCore
    * Syrna.Abp.DynamicMenu.HttpApi
    * Syrna.Abp.DynamicMenu.HttpApi.Client
    * Syrna.Abp.DynamicMenu.Web
    * Syrna.Abp.DynamicMenu.Blazor
    * Syrna.Abp.DynamicMenu.Blazor.Server
    * Syrna.Abp.DynamicMenu.Blazor.WebAssembly

1. Add `DependsOn(typeof(AbpDynamicMenuXxxModule))` attribute to configure the module dependencies. ([see how](https://github.com/Dolunay/SyrnaAbpGuide/blob/master/docs/How-To.md#add-module-dependencies))

1. Add `builder.ConfigureAbpDynamicMenu();` to the `OnModelCreating()` method in **MyProjectMigrationsDbContext.cs**.

1. Add EF Core migrations and update your database. See: [ABP document](https://docs.abp.io/en/abp/latest/Tutorials/Part-1?UI=MVC&DB=EF#add-database-migration).

## Usage

1. Create a dynamic menu item on the management page.

2. Refresh the page and you can see the menu item you just created.

## Reference

### This project based on [EasyAbp DynamicMenu](https://github.com/EasyAbp/Abp.DynamicMenu)

### Diffrences

1. Demo project created for OpenIddict
2. Demo project extended modules added
2. Blazor modules added
3. Private menu option added to MenuItems
4. MenuItem table refactored for Auditing
