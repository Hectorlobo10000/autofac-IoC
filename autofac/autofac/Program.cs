using System;
using Autofac;
using Autofac.Core;

namespace DemoApp
{
    class Program
    {
        private static  IContainer container { get; set; }

        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleOutput>().As<IOutput>();
            builder.RegisterType<TodayWriter>().As<IDateWrite>();
            container = builder.Build();

            WriteDate();
            
        }

        private static void WriteDate()
        {
            using (var scope = container.BeginLifetimeScope())
            {
                var writer = scope.Resolve<IDateWrite>();
                writer.WriteDate();
            }
        }
    }
}
