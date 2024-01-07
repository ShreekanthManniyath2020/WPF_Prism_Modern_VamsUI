﻿using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using VamsUI.Vams.PrismDemo.Modules.ModuleName;
using VamsUI.Vams.PrismDemo.Services;
using VamsUI.Vams.PrismDemo.Services.Interfaces;
using VamsUI.Vams.PrismDemo.Views;

namespace VamsUI.Vams.PrismDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleNameModule>();
        }
    }
}
