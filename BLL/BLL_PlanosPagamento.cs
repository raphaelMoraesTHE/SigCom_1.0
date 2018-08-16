using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using Model;

namespace BLL
{
    public class BLL_PlanosPagamento
    {
        DAO_PlanosPagamento planosPagamento_DAO = null;

        private DAOConfiguraConexaoPostgres conexao;

        public BLL_PlanosPagamento(DAOConfiguraConexaoPostgres cx)
        {
            this.conexao = cx;
        }

        public void grava_PlanosPagamento(ModeloPlanosPagamento planosPagamento)
        {
            try
            {
                if (planosPagamento.Descricao.Trim().Length == 0)
                {
                    throw new Exception("Não é possivel gravar com campos vazio.");
                }
                planosPagamento.Descricao = planosPagamento.Descricao.ToUpper();

                planosPagamento_DAO = new DAO_PlanosPagamento(conexao);
                planosPagamento_DAO.grava_PlanoPagamento(planosPagamento);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void altera_PlanosPagamento(ModeloPlanosPagamento planosPagamento)
        {
            try
            {
                if (planosPagamento.Codigo <= 0)
                {
                    throw new Exception("É nescessário informar o código");
                }

                if (planosPagamento.Descricao.Trim().Length == 0)
                {
                    throw new Exception("Não é possivel gravar com campos vazio.");
                }
                planosPagamento.Descricao = planosPagamento.Descricao.ToUpper();

                planosPagamento_DAO = new DAO_PlanosPagamento(conexao);
                planosPagamento_DAO.altera_PlanoPagamento(planosPagamento);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir_PlanosPagamento(int codigo)
        {
            try
            {
                planosPagamento_DAO = new DAO_PlanosPagamento(conexao);
                planosPagamento_DAO.excluir_PlanoPagamento(codigo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_PlanosPagamento_Nome(String pesquisa)
        {
            try
            {
                planosPagamento_DAO = new DAO_PlanosPagamento(conexao);
                return planosPagamento_DAO.pesquisa_PlanoPagamento_Nome(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_PlanosPagamento_Codigo(int pesquisa)
        {
            try
            {
                planosPagamento_DAO = new DAO_PlanosPagamento(conexao);
                return planosPagamento_DAO.pesquisa_PlanoPagamento_Codigo(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable lista_PlanosPagamento()
        {
            try
            {
                planosPagamento_DAO = new DAO_PlanosPagamento(conexao);
                return planosPagamento_DAO.lista_PlanoPagamento();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloPlanosPagamento informaProximoCodigo()
        {
            try
            {
                planosPagamento_DAO = new DAO_PlanosPagamento(conexao);
                return planosPagamento_DAO.informaProximoCodigo();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloPlanosPagamento carregaModeloPlanosPagamento(int codigo)
        {
            try
            {
                planosPagamento_DAO = new DAO_PlanosPagamento(conexao);
                return planosPagamento_DAO.carregaModeloPlanoPagamento(codigo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
