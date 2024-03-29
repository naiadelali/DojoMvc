﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using System.Web.Mvc;

namespace DojoMvc.Ui.Support
{
    public class UnityDependencyResolver : IDependencyResolver
    {
        private readonly IUnityContainer container;

        public UnityDependencyResolver(IUnityContainer container)
        {
            this.container = container;
        }

        public object GetService(Type serviceType)
        {
            if (!this.container.IsRegistered(serviceType))
                return null;
            else
                return this.container.Resolve(serviceType); 
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            if (!this.container.IsRegistered(serviceType))
                return new List<object>();
            else
                return this.container.ResolveAll(serviceType);
        }
    }
}