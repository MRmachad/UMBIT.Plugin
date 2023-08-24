using System;
using UMBIT.Infraestrutura.Core.Interfaces.Database;
using UMBIT.Plugin.Dominio.Entidades;
using UMBIT.Plugin.Dominio.Interfaces;

namespace UMBIT.Plugin.Dominio.Servicos
{
    public class ServicoDePessoa : IServicoDePessoa
    {
        public IRepositorio<Pessoa> repositorioPessoa { get; set; }
        public IUnidadeDeTrabalho UnidadeDeTrabalho { get; set; }
        public ServicoDePessoa(IUnidadeDeTrabalho unidadeDeTrabalho)
        {
            this.UnidadeDeTrabalho = unidadeDeTrabalho;
            this.repositorioPessoa = unidadeDeTrabalho.GetRepositorio<Pessoa>();
        }
        public void AtualizeEntidade(Pessoa Entidade)
        {
            try
            {
                this.repositorioPessoa.Atualize(Entidade);
                UnidadeDeTrabalho.SalveAlteracoes();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro Ao atualizar entidade", ex);
            }
        }

        public void Adicione(Pessoa Entidade)
        {
            try
            {
                this.repositorioPessoa.Adicione(Entidade);
                UnidadeDeTrabalho.SalveAlteracoes();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro Ao adicionar entidade", ex);
            }
        }
    }
}
