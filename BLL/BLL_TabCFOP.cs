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
    public class BLL_TabCFOP
    {
        DAO_TabCFOP cfop_DAO = null;

        private DAOConfiguraConexaoPostgres conexao;

        public BLL_TabCFOP(DAOConfiguraConexaoPostgres cx)
        {
            this.conexao = cx;
        }

        public void grava_CFOP(ModeloTabCFOP cfop)
        {
            try
            {
                if (cfop.Descricao.Trim().Length == 0 || cfop.Natureza.Trim().Length < 5)
                {
                    throw new Exception("Não é possivel gravar com campos vazio.");
                }
                cfop.Descricao = cfop.Descricao.ToUpper();

                cfop_DAO = new DAO_TabCFOP(conexao);
                cfop_DAO.grava_CFOP(cfop);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void altera_CFOP(ModeloTabCFOP cfop)
        {
            try
            {
                if (cfop.Natureza.Trim().Length < 5)
                {
                    throw new Exception("É nescessário informar a natureza");
                }

                if (cfop.Descricao.Trim().Length == 0)
                {
                    throw new Exception("Não é possivel gravar com campos vazio.");
                }
                cfop.Descricao = cfop.Descricao.ToUpper();

                cfop_DAO = new DAO_TabCFOP(conexao);
                cfop_DAO.altera_CFOP(cfop);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir_CFOP(string natureza)
        {
            try
            {
                cfop_DAO = new DAO_TabCFOP(conexao);
                cfop_DAO.excluir_CFOP(natureza);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_CFOP_Descricao(String pesquisa)
        {
            try
            {
                cfop_DAO = new DAO_TabCFOP(conexao);
                return cfop_DAO.pesquisa_CFOP_Descricao(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_CFOP_Natureza(String pesquisa)
        {
            try
            {
                cfop_DAO = new DAO_TabCFOP(conexao);
                return cfop_DAO.pesquisa_CFOP_Natureza(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable lista_CFOP()
        {
            try
            {
                cfop_DAO = new DAO_TabCFOP(conexao);
                return cfop_DAO.lista_CFOP();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloTabCFOP carregaModeloTabCFOP(string natureza)
        {
            try
            {
                cfop_DAO = new DAO_TabCFOP(conexao);
                return cfop_DAO.carregaModeloTabCFOP(natureza);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
