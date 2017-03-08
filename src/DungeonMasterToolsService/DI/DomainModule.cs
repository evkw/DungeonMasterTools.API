using System.Reflection;
using Autofac;
using Module = Autofac.Module;

namespace DungeonMasterToolsService.DI
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
