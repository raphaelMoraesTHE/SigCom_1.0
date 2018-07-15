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
    public class BLL_Funcionario
    {
        DAO_Funcionario funcionario_DAO = null;

        private DAOConfiguraConexaoPostgres conexao;

        public BLL_Funcionario(DAOConfiguraConexaoPostgres cx)
        {
            this.conexao = cx;
        }

        public void grava_Funcionario(ModeloFuncionario funcionario)
        {
            try
            {
                if (funcionario.Nome.Trim().Length == 0 || funcionario.Apelido.Trim().Length == 0)
                {
                    throw new Exception("Não é possivel gravar com campos vazio.");
                }
                funcionario.Nome = funcionario.Nome.ToUpper();
                //funcionario.DataCnhValidade = funcionario.DataCnhValidade.ToString(DBNull.Value);

                funcionario_DAO = new DAO_Funcionario(conexao);
                funcionario_DAO.grava_Funcionario(funcionario);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void altera_Funcionario(ModeloFuncionario funcionario)
        {
            try
            {
                if (funcionario.Codigo <= 0)
                {
                    throw new Exception("É nescessário informar o código");
                }

                if (funcionario.Nome.Trim().Length == 0)
                {
                    throw new Exception("Não é possivel gravar com campos vazio.");
                }
                
                funcionario_DAO = new DAO_Funcionario(conexao);
                funcionario_DAO.altera_Funcionario(funcionario);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir_Funcionario(int codigo)
        {
            try
            {
                funcionario_DAO = new DAO_Funcionario(conexao);
                funcionario_DAO.excluir_Funcionario(codigo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_Funcionario_Nome(String pesquisa)
        {
            try
            {
                funcionario_DAO = new DAO_Funcionario(conexao);
                return funcionario_DAO.pesquisa_Funcionario_Nome(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_Funcionario_Codigo(int pesquisa)
        {
            try
            {
                funcionario_DAO = new DAO_Funcionario(conexao);
                return funcionario_DAO.pesquisa_Funcionario_Codigo(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_Funcionario_Cpf(String pesquisa)
        {
            try
            {
                funcionario_DAO = new DAO_Funcionario(conexao);
                return funcionario_DAO.pesquisa_Funcionario_Cpf(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable lista_Funcionario()
        {
            try
            {
                funcionario_DAO = new DAO_Funcionario(conexao);
                return funcionario_DAO.lista_Funcionario();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloFuncionario informaProximoCodigo()
        {
            try
            {
                funcionario_DAO = new DAO_Funcionario(conexao);
                return funcionario_DAO.informaProximoCodigo();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloFuncionario carregaModeloFuncionario(int codigo)
        {
            try
            {
                funcionario_DAO = new DAO_Funcionario(conexao);
                return funcionario_DAO.carregaModeloFuncionario(codigo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
