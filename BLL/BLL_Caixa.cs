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
    public class BLL_Caixa
    {
        DAO_Caixa caixa_DAO = null;

        private DAOConfiguraConexaoPostgres conexao;

        public BLL_Caixa(DAOConfiguraConexaoPostgres cx)
        {
            this.conexao = cx;
        }

        public void grava_Caixa(ModeloCaixa caixa)
        {
            try
            {
                if (caixa.Descricao.Trim().Length == 0)
                {
                    throw new Exception("Não é possivel gravar com campos vazio.");
                }
                caixa.Descricao = caixa.Descricao.ToUpper();

                caixa_DAO = new DAO_Caixa(conexao);
                caixa_DAO.grava_Caixa(caixa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void altera_Caixa(ModeloCaixa caixa)
        {
            try
            {
                if (caixa.Codigo <= 0)
                {
                    throw new Exception("É nescessário informar o código");
                }

                if (caixa.Descricao.Trim().Length == 0)
                {
                    throw new Exception("Não é possivel gravar com campos vazio.");
                }
                caixa.Descricao = caixa.Descricao.ToUpper();

                caixa_DAO = new DAO_Caixa(conexao);
                caixa_DAO.altera_Caixa(caixa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir_Caixa(int codigo)
        {
            try
            {
                caixa_DAO = new DAO_Caixa(conexao);
                caixa_DAO.excluir_Caixa(codigo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_Caixa_Nome(String pesquisa)
        {
            try
            {
                caixa_DAO = new DAO_Caixa(conexao);
                return caixa_DAO.pesquisa_Caixa_Nome(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_Caixa_Codigo(int pesquisa)
        {
            try
            {
                caixa_DAO = new DAO_Caixa(conexao);
                return caixa_DAO.pesquisa_Caixa_Codigo(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable lista_Caixa()
        {
            try
            {
                caixa_DAO = new DAO_Caixa(conexao);
                return caixa_DAO.lista_Caixa();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloCaixa informaProximoCodigo()
        {
            try
            {
                caixa_DAO = new DAO_Caixa(conexao);
                return caixa_DAO.informaProximoCodigo();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloCaixa carregaModeloCaixa(int codigo)
        {
            try
            {
                caixa_DAO = new DAO_Caixa(conexao);
                return caixa_DAO.carregaModeloCaixa(codigo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
