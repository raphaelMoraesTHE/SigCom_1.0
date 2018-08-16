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
    public class BLL_Documentos
    {
        DAO_Documentos documentos_DAO = null;

        private DAOConfiguraConexaoPostgres conexao;

        public BLL_Documentos(DAOConfiguraConexaoPostgres cx)
        {
            this.conexao = cx;
        }

        public void grava_Documentos(ModeloDocumentos documentos)
        {
            try
            {
                if (documentos.Descricao.Trim().Length == 0)
                {
                    throw new Exception("Não é possivel gravar com campos vazio.");
                }
                documentos.Descricao = documentos.Descricao.ToUpper();

                documentos_DAO = new DAO_Documentos(conexao);
                documentos_DAO.grava_Documentos(documentos);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void altera_Documentos(ModeloDocumentos documentos)
        {
            try
            {
                if (documentos.Codigo.Length <= 1)
                {
                    throw new Exception("É nescessário informar o código");
                }

                if (documentos.Descricao.Trim().Length == 0)
                {
                    throw new Exception("Não é possivel gravar com campos vazio.");
                }
                documentos.Descricao = documentos.Descricao.ToUpper();

                documentos_DAO = new DAO_Documentos(conexao);
                documentos_DAO.altera_Documentos(documentos);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir_Documentos(String codigo)
        {
            try
            {
                documentos_DAO = new DAO_Documentos(conexao);
                documentos_DAO.excluir_Documentos(codigo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_Documentos_Nome(String pesquisa)
        {
            try
            {
                documentos_DAO = new DAO_Documentos(conexao);
                return documentos_DAO.pesquisa_Documentos_Nome(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_Documentos_Codigo(String pesquisa)
        {
            try
            {
                documentos_DAO = new DAO_Documentos(conexao);
                return documentos_DAO.pesquisa_Documentos_Codigo(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable lista_Documentos()
        {
            try
            {
                documentos_DAO = new DAO_Documentos(conexao);
                return documentos_DAO.lista_Documentos();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable lista_TpDocumento()
        {
            try
            {
                documentos_DAO = new DAO_Documentos(conexao);
                return documentos_DAO.lista_TpDocumento();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        
        public ModeloDocumentos carregaModeloDocumentos(String codigo)
        {
            try
            {
                documentos_DAO = new DAO_Documentos(conexao);
                return documentos_DAO.carregaModeloDocumentos(codigo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
    }
}
