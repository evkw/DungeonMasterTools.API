using Autofac;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyModel;
using Module = Autofac.Module;

namespace DungeonMasterTools.DI
{
    public class DomainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Domain Assembly Retrieval
            var domainAssembly = Assembly.Load(new AssemblyName("DungeonMasterToolsDomain"));
            var testAssembly = Assembly.GetEntryAssembly();

            // Domain Handler DI Registry
            builder.RegisterAssemblyTypes(domainAssembly)
                   .Where(type => type.Name.EndsWith("Handler"))
                   .AsImplementedInterfaces();
        }
    }
}
