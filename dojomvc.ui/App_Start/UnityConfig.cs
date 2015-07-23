﻿using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DojoMvc.Ui.Controllers;
using DojoMvc.Business;

namespace DojoMvc.Ui.App_Start
{
    public class UnityConfig
    {
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            IUnityContainer container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            ContainerBootstrapper.RegisterType(container);
            container.RegisterType<ProductController>();
        }
    }
}