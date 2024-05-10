using UMBIT.MVC.Core.Configurate.LoadPluginsConfigurate.Initializable.Module;

namespace UMBIT.Plugin.InterfaceWeb.Configuracao
{
    public class EnumeradorDeRecurso : RecursoInfo
    {
        public static readonly EnumeradorDeRecurso TESTE = new EnumeradorDeRecurso(
            0101,
            "Teste Recurso",
            "Home",
            "Index",
            true,
            true);
        public EnumeradorDeRecurso(int identificador, string descricao, string controller, string action, bool CompoeMenu, bool CompoeCatalogo) : base(identificador, descricao, controller, action, CompoeMenu, CompoeCatalogo)
        {
        }
    }
}
