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
    public class BLL_Empresa
    {
        DAO_Empresa empresa_DAO = null;

        private DAOConfiguraConexaoPostgres conexao;

        public BLL_Empresa(DAOConfiguraConexaoPostgres cx)
        {
            this.conexao = cx;
        }

        public void grava_Empresa(ModeloEmpresa empresa)
        {
            try
            {
                if (empresa.Nome.Trim().Length == 0)
                {
                    throw new Exception("Não é possivel gravar com campos vazio.");
                }
                empresa.Nome = empresa.Nome.ToUpper();

                empresa_DAO = new DAO_Empresa(conexao);
                empresa_DAO.grava_Empresa(empresa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void altera_Empresa(ModeloEmpresa empresa)
        {
            try
            {
                if (empresa.Codigo <= 0)
                {
                    throw new Exception("É nescessário informar o código");
                }

                if (empresa.Nome.Trim().Length == 0)
                {
                    throw new Exception("Não é possivel gravar com campos vazio.");
                }
                //empresa.Nome = empresa.Nome.ToUpper();

                empresa_DAO = new DAO_Empresa(conexao);
                empresa_DAO.altera_Empresa(empresa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir_Empresa(int codigo)
        {
            try
            {
                empresa_DAO = new DAO_Empresa(conexao);
                empresa_DAO.excluir_Empresa(codigo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_Empresa_Nome(String pesquisa)
        {
            try
            {
                empresa_DAO = new DAO_Empresa(conexao);
                return empresa_DAO.pesquisa_Empresa_Nome(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_Empresa_Codigo(int pesquisa)
        {
            try
            {
                empresa_DAO = new DAO_Empresa(conexao);
                return empresa_DAO.pesquisa_Empresa_Codigo(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_Empresa_Cnpj(String pesquisa)
        {
            try
            {
                empresa_DAO = new DAO_Empresa(conexao);
                return empresa_DAO.pesquisa_Empresa_Cnpj(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable lista_Empresa()
        {
            try
            {
                empresa_DAO = new DAO_Empresa(conexao);
                return empresa_DAO.lista_Empresa();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloEmpresa informaProximoCodigo()
        {
            try
            {
                empresa_DAO = new DAO_Empresa(conexao);
                return empresa_DAO.informaProximoCodigo();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloEmpresa carregaModeloEmpresa(int codigo)
        {
            try
            {
                empresa_DAO = new DAO_Empresa(conexao);
                return empresa_DAO.carregaModeloEmpresa(codigo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
