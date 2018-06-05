using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestingWindowsService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static void Main()
        {
            var builder = new Autofac.ContainerBuilder();
            builder.RegisterType<Service1>().As<ServiceBase>();   
            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var component = scope.Resolve<Service1>();
            }

            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Service1()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
