using UMBIT.MVC.Core.Configurate.LoadPluginsConfigurate.Initializable.Module;

namespace UMBIT.Plugin.InterfaceWeb.Configuracao
{
    public class UMBIT : ModuloInfo
    {
        public static readonly UMBIT MODULO_RH = new UMBIT(
           01,
           "Hello World",
           "fas fa-users",
           EnumeradorDeRecurso.TESTE
       );
        public UMBIT(int identificador, string descricao, string icone, params RecursoInfo[] recursos) : base(identificador, descricao, icone, recursos)
        {
        }
    }
}
