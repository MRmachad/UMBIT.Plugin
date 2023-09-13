using Microsoft.Extensions.DependencyInjection;
using UMBIT.MVC.Core.Configurate.LoadPluginsConfigurate.Initializable.Module;
using UMBIT.Plugin.Dominio.Interfaces;
using UMBIT.Plugin.Dominio.Servicos;

namespace UMBIT.Plugin.Resgistrator
{
    public class Init : IPluginInitializer
    {
        void IPluginInitializer.Init(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IServicoDePessoa, ServicoDePessoa>();
        }

    }
}
