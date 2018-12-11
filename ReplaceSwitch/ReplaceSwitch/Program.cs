using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace ReplaceSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = InitializeContainer();

            var report = new Report()
            {
                Name = "Test report",
                ExportFormat = ExportFormat.Xml
            };

            var processorWithSwitch = container.Resolve<ReportProcessorWithSwitch>();

            processorWithSwitch.Process(report);

            var processorWithoutSwitch = container.Resolve<ReportProcessorWithoutSwitch>();

            processorWithoutSwitch.Process(report);
        }

        private static IContainer InitializeContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterAssemblyTypes(typeof(Program).Assembly)
                .AsSelf()
                .AsImplementedInterfaces();

            return builder.Build();
        }
    }
}
