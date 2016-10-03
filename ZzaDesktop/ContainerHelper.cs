﻿using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZzaDesktop.Services;

namespace ZzaDesktop
{
    public static class ContainerHelper
    {
        public static IUnityContainer _container;

        static ContainerHelper()
        {
            _container = new UnityContainer();

            _container.RegisterType<ICustomersRepository, CustomersRepository>(new ContainerControlledLifetimeManager());
        }

        public static IUnityContainer Container
        {
            get
            {
                return _container;
            }
        }
    }
}
