using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UMBIT.Infraestrutura.Core.Database.EF;
using UMBIT.Plugin.Dominio.Entidades;

namespace UMBIT.Plugin.Infra.Data.ConfiguracaoDeEntidades
{
    public class EF_Pessoa : CoreEntityConfigurate<Pessoa>
    {
        public override void ConfigureEntidade(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasIndex(m => m.Id);
        }
    }
}
