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
    public class BLL_OpComercial
    {
        DAO_OpComercial opComercial_DAO = null;

        private DAOConfiguraConexaoPostgres conexao;

        public BLL_OpComercial(DAOConfiguraConexaoPostgres cx)
        {
            this.conexao = cx;
        }

        public void grava_OpComercial(ModeloOpComerciais opComerciais)
        {
            try
            {
                if (opComerciais.Descricao.Trim().Length == 0)
                {
                    throw new Exception("Não é possivel gravar com campos vazio.");
                }
                opComerciais.Descricao = opComerciais.Descricao.ToUpper();

                opComercial_DAO = new DAO_OpComercial(conexao);
                opComercial_DAO.grava_OpComercial(opComerciais);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void altera_OpComercial(ModeloOpComerciais opComerciais)
        {
            try
            {
                if (opComerciais.Codigo <= 0)
                {
                    throw new Exception("É nescessário informar o código");
                }

                if (opComerciais.Descricao.Trim().Length == 0)
                {
                    throw new Exception("Não é possivel gravar com campos vazio.");
                }
                opComerciais.Descricao = opComerciais.Descricao.ToUpper();

                opComercial_DAO = new DAO_OpComercial(conexao);
                opComercial_DAO.altera_OpComercial(opComerciais);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir_OpComercial(int codigo)
        {
            try
            {
                opComercial_DAO = new DAO_OpComercial(conexao);
                opComercial_DAO.excluir_OpComercial(codigo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_OpComercial_Nome(String pesquisa)
        {
            try
            {
                opComercial_DAO = new DAO_OpComercial(conexao);
                return opComercial_DAO.pesquisa_OpComercial_Nome(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_OpComercial_Codigo(int pesquisa)
        {
            try
            {
                opComercial_DAO = new DAO_OpComercial(conexao);
                return opComercial_DAO.pesquisa_OpComercial_Codigo(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable lista_OpComercial()
        {
            try
            {
                opComercial_DAO = new DAO_OpComercial(conexao);
                return opComercial_DAO.lista_OpComercial();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloOpComerciais informaProximoCodigo()
        {
            try
            {
                opComercial_DAO = new DAO_OpComercial(conexao);
                return opComercial_DAO.informaProximoCodigo();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloOpComerciais carregaModeloOpComercial(int codigo)
        {
            try
            {
                opComercial_DAO = new DAO_OpComercial(conexao);
                return opComercial_DAO.carregaModeloOpComercial(codigo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
