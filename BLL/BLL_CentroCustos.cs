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
    public class BLL_CentroCustos
    {
        DAO_CentroCustos ctcustos_DAO = null;

        private DAOConfiguraConexaoPostgres conexao;

        public BLL_CentroCustos(DAOConfiguraConexaoPostgres cx)
        {
            this.conexao = cx;
        }

        public void grava_CentroCustos(ModeloCentroCustos ctcustos)
        {
            try
            {
                if (ctcustos.Descricao.Trim().Length == 0)
                {
                    throw new Exception("Não é possivel gravar com campos vazio.");
                }
                ctcustos.Descricao = ctcustos.Descricao.ToUpper();

                ctcustos_DAO = new DAO_CentroCustos(conexao);
                ctcustos_DAO.grava_CentroCustos(ctcustos);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void altera_CentroCustos(ModeloCentroCustos ctcustos)
        {
            try
            {
                if (ctcustos.Codigo <= 0)
                {
                    throw new Exception("É nescessário informar o código");
                }

                if (ctcustos.Descricao.Trim().Length == 0)
                {
                    throw new Exception("Não é possivel gravar com campos vazio.");
                }
                ctcustos.Descricao = ctcustos.Descricao.ToUpper();

                ctcustos_DAO = new DAO_CentroCustos(conexao);
                ctcustos_DAO.altera_CentroCustoa(ctcustos);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir_CentroCustos(int codigo)
        {
            try
            {
                ctcustos_DAO = new DAO_CentroCustos(conexao);
                ctcustos_DAO.excluir_CentroCustos(codigo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_CentroCustos_Nome(String pesquisa)
        {
            try
            {
                ctcustos_DAO = new DAO_CentroCustos(conexao);
                return ctcustos_DAO.pesquisa_CentroCustos_Nome(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_CentroCustos_Codigo(int pesquisa)
        {
            try
            {
                ctcustos_DAO = new DAO_CentroCustos(conexao);
                return ctcustos_DAO.pesquisa_CentroCustos_Codigo(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable lista_CentroCustos()
        {
            try
            {
                ctcustos_DAO = new DAO_CentroCustos(conexao);
                return ctcustos_DAO.lista_CentroCustos();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloCentroCustos informaProximoCodigo()
        {
            try
            {
                ctcustos_DAO = new DAO_CentroCustos(conexao);
                return ctcustos_DAO.informaProximoCodigo();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloCentroCustos carregaModeloCentroCustos(int codigo)
        {
            try
            {
                ctcustos_DAO = new DAO_CentroCustos(conexao);
                return ctcustos_DAO.carregaModeloCentroCustos(codigo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
