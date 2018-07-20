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
    public class BLL_CargosFuncoes
    {
        DAO_CargosFuncoes cargosFuncoes_DAO = null;

        private DAOConfiguraConexaoPostgres conexao;

        public BLL_CargosFuncoes(DAOConfiguraConexaoPostgres cx)
        {
            this.conexao = cx;
        }

        public void grava_CargosFuncoes(ModeloCargosFuncoes cargosFuncoes)
        {
            try
            {
                if (cargosFuncoes.Descricao.Trim().Length == 0)
                {
                    throw new Exception("Não é possivel gravar com campos vazio.");
                }
                cargosFuncoes.Descricao = cargosFuncoes.Descricao.ToUpper();

                cargosFuncoes_DAO = new DAO_CargosFuncoes(conexao);
                cargosFuncoes_DAO.grava_CargosFuncoes(cargosFuncoes);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void altera_CargosFuncoes(ModeloCargosFuncoes cargosFuncoes)
        {
            try
            {
                if (cargosFuncoes.Codigo <= 0)
                {
                    throw new Exception("É nescessário informar o código");
                }

                if (cargosFuncoes.Descricao.Trim().Length == 0)
                {
                    throw new Exception("Não é possivel gravar com campos vazio.");
                }
                cargosFuncoes.Descricao = cargosFuncoes.Descricao.ToUpper();

                cargosFuncoes_DAO = new DAO_CargosFuncoes(conexao);
                cargosFuncoes_DAO.altera_CargosFuncoes(cargosFuncoes);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir_CargosFuncoes(int codigo)
        {
            try
            {
                cargosFuncoes_DAO = new DAO_CargosFuncoes(conexao);
                cargosFuncoes_DAO.excluir_CargosFuncoes(codigo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_CargosFuncoes_Nome(String pesquisa)
        {
            try
            {
                cargosFuncoes_DAO = new DAO_CargosFuncoes(conexao);
                return cargosFuncoes_DAO.pesquisa_CargosFuncoes_Nome(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_CargosFuncoes_Codigo(int pesquisa)
        {
            try
            {
                cargosFuncoes_DAO = new DAO_CargosFuncoes(conexao);
                return cargosFuncoes_DAO.pesquisa_CargosFuncoes_Codigo(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable lista_CargosFuncoes()
        {
            try
            {
                cargosFuncoes_DAO = new DAO_CargosFuncoes(conexao);
                return cargosFuncoes_DAO.lista_CargosFuncoes();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloCargosFuncoes informaProximoCodigo()
        {
            try
            {
                cargosFuncoes_DAO = new DAO_CargosFuncoes(conexao);
                return cargosFuncoes_DAO.informaProximoCodigo();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloCargosFuncoes carregaModeloCargosFuncoes(int codigo)
        {
            try
            {
                cargosFuncoes_DAO = new DAO_CargosFuncoes(conexao);
                return cargosFuncoes_DAO.carregaModeloCargosFuncoes(codigo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
