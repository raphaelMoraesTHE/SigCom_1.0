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
    public class BLL_SaldoCaixa
    {
        DAO_SaldoCaixa saldoCaixa_DAO = null;

        private DAOConfiguraConexaoPostgres conexao;

        public BLL_SaldoCaixa(DAOConfiguraConexaoPostgres cx)
        {
            this.conexao = cx;
        }

        public void grava_SaldoCaixa(ModeloSaldoCaixa saldoCaixa)
        {
            try
            {
                if (saldoCaixa.Descricao.Trim().Length == 0)
                {
                    throw new Exception("Não é possivel gravar com campos vazio.");
                }
                saldoCaixa.Descricao = saldoCaixa.Descricao.ToUpper();

                saldoCaixa_DAO = new DAO_SaldoCaixa(conexao);
                saldoCaixa_DAO.grava_SaldoCaixa(saldoCaixa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void altera_SaldoCaixa(ModeloSaldoCaixa saldoCaixa)
        {
            try
            {
                if (saldoCaixa.Codigo <= 0)
                {
                    throw new Exception("É nescessário informar o código");
                }

                if (saldoCaixa.Descricao.Trim().Length == 0)
                {
                    throw new Exception("Não é possivel gravar com campos vazio.");
                }
                saldoCaixa.Descricao = saldoCaixa.Descricao.ToUpper();

                saldoCaixa_DAO = new DAO_SaldoCaixa(conexao);
                saldoCaixa_DAO.altera_SaldoCaixa(saldoCaixa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir_SaldoCaixa(int codigo)
        {
            try
            {
                saldoCaixa_DAO = new DAO_SaldoCaixa(conexao);
                saldoCaixa_DAO.excluir_SaldoCaixa(codigo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_SaldoCaixa_Nome(String pesquisa)
        {
            try
            {
                saldoCaixa_DAO = new DAO_SaldoCaixa(conexao);
                return saldoCaixa_DAO.pesquisa_SaldoCaixa_Nome(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_SaldoCaixa_Codigo(int pesquisa)
        {
            try
            {
                saldoCaixa_DAO = new DAO_SaldoCaixa(conexao);
                return saldoCaixa_DAO.pesquisa_SaldoCaixa_Codigo(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable lista_SaldoCaixa()
        {
            try
            {
                saldoCaixa_DAO = new DAO_SaldoCaixa(conexao);
                return saldoCaixa_DAO.lista_SaldoCaixa();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloSaldoCaixa informaProximoCodigo()
        {
            try
            {
                saldoCaixa_DAO = new DAO_SaldoCaixa(conexao);
                return saldoCaixa_DAO.informaProximoCodigo();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloSaldoCaixa carregaModeloSaldoCaixa(int codigo)
        {
            try
            {
                saldoCaixa_DAO = new DAO_SaldoCaixa(conexao);
                return saldoCaixa_DAO.carregaModeloCaixa(codigo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
