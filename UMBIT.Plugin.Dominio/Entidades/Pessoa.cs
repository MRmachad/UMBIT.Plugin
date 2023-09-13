using UMBIT.Infraestrutura.Core.Database.EF;

namespace UMBIT.Plugin.Dominio.Entidades
{
    public class Pessoa : CoreBaseEntity
    {
        public string Name { get; set; }
        public string Sobrenome { get; set; }
    }
}
