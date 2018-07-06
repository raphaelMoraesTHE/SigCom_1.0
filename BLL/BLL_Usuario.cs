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
    public class BLL_Usuario
    {        
        DAO_Usuario usuario_DAO = null;

        private DAOConfiguraConexaoPostgres conexao;

        public bool existe;
        public String mensagem = "";

        public BLL_Usuario(DAOConfiguraConexaoPostgres cx)
        {
            this.conexao = cx;
        }

        public void grava_Usuario(ModeloUsuario usuario)
        {
            try
            {
                if (usuario.Nome.Trim().Length == 0 || usuario.Senha.Trim().Length == 0)
                {
                    throw new Exception("Não é possivel gravar com campos vazio.");
                }
                
                usuario_DAO = new DAO_Usuario(conexao);
                usuario_DAO.grava_Usuario(usuario);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void alterar_Usuario(ModeloUsuario usuario)
        {
            try
            {
                if (usuario.Codigo <= 0)
                {
                    throw new Exception("É nescessário informar o código");
                }

                if (usuario.Nome.Trim().Length == 0 || usuario.Senha.Trim().Length == 0)
                {
                    throw new Exception("Não é possivel gravar com campos vazio.");
                }
                
                usuario_DAO = new DAO_Usuario(conexao);
                usuario_DAO.alterar_Usuario(usuario);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir_Usuario(int codigo)
        {
            try
            {
                usuario_DAO = new DAO_Usuario(conexao);
                usuario_DAO.excluir_Usuario(codigo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_Usuario_Nome(String pesquisa)
        {
            try
            {
                usuario_DAO = new DAO_Usuario(conexao);
                return usuario_DAO.pesquisa_Usuario_Nome(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_Usuario_Codigo(int pesquisa)
        {
            try
            {
                usuario_DAO = new DAO_Usuario(conexao);
                return usuario_DAO.pesquisa_Usuario_Codigo(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable lista_Usuario()
        {
            try
            {
                usuario_DAO = new DAO_Usuario(conexao);
                return usuario_DAO.lista_Usuario();
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }

        public ModeloUsuario informaProximoCodigo()
        {
            try
            {
                usuario_DAO = new DAO_Usuario(conexao);
                return usuario_DAO.informaProximoCodigo();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloUsuario carregaModeloUsuario(int codigo)
        {
            try
            {
                usuario_DAO = new DAO_Usuario(conexao);
                return usuario_DAO.carregaModeloUsuario(codigo);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public bool verifica_Usuario_Login(String login, String senha)
        {            
            try
            {
                usuario_DAO = new DAO_Usuario(conexao);
                existe = usuario_DAO.verifica_Usuario_Login(login, senha);

                if (!usuario_DAO.mensagem.Equals(""))
                {
                    mensagem = usuario_DAO.mensagem;
                }
                return existe;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }        
        
    }
}
