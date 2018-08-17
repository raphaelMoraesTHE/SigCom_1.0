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
    public class BLL_Bancos
    {
        DAO_Bancos bancos_DAO = null;

        private DAOConfiguraConexaoPostgres conexao;

        public BLL_Bancos(DAOConfiguraConexaoPostgres cx)
        {
            this.conexao = cx;
        }

        public void grava_Bancos(ModeloBancos bancos)
        {
            try
            {
                if (bancos.Nome.Trim().Length == 0)
                {
                    throw new Exception("Não é possivel gravar com campos vazio.");
                }
                bancos.Nome = bancos.Nome.ToUpper();

                bancos_DAO = new DAO_Bancos(conexao);
                bancos_DAO.grava_Bancos(bancos);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void altera_Bancos(ModeloBancos bancos)
        {
            try
            {
                if (bancos.Codigo <= 0)
                {
                    throw new Exception("É nescessário informar o código");
                }

                if (bancos.Nome.Trim().Length == 0)
                {
                    throw new Exception("Não é possivel gravar com campos vazio.");
                }
                bancos.Nome = bancos.Nome.ToUpper();

                bancos_DAO = new DAO_Bancos(conexao);
                bancos_DAO.altera_Bancos(bancos);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir_Bancos(int codigo)
        {
            try
            {
                bancos_DAO = new DAO_Bancos(conexao);
                bancos_DAO.excluir_Bancos(codigo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_Bancos_Nome(String pesquisa)
        {
            try
            {
                bancos_DAO = new DAO_Bancos(conexao);
                return bancos_DAO.pesquisa_Bancos_Nome(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_Bancos_Codigo(int pesquisa)
        {
            try
            {
                bancos_DAO = new DAO_Bancos(conexao);
                return bancos_DAO.pesquisa_Bancos_Codigo(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable lista_Bancos()
        {
            try
            {
                bancos_DAO = new DAO_Bancos(conexao);
                return bancos_DAO.lista_Bancos();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloBancos informaProximoCodigo()
        {
            try
            {
                bancos_DAO = new DAO_Bancos(conexao);
                return bancos_DAO.informaProximoCodigo();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloBancos carregaModeloBancos(int codigo)
        {
            try
            {
                bancos_DAO = new DAO_Bancos(conexao);
                return bancos_DAO.carregaModeloBancos(codigo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
