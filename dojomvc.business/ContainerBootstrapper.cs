using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using DojoMvc.Repository;

namespace DojoMvc.Business
{
    public class ContainerBootstrapper
    {
        public static void RegisterType(IUnityContainer container)
        {
            container.
                RegisterType<IProductRepository, ProductRepository>().
                RegisterType<IProductBusiness, ProductBusiness>();
        }
    }
}
