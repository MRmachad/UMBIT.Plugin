using UMBIT.Plugin.Dominio.Entidades;

namespace UMBIT.Plugin.Dominio.Interfaces
{
    public interface IServicoDePessoa
    {
        void AtualizeEntidade(Pessoa Entidade);
        void Adicione(Pessoa Entidade);
    }
}
