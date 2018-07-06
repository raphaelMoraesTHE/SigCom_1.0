using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using Model;

namespace DAO
{
    public class DAO_Usuario
    {
        private DAOConfiguraConexaoPostgres conexao_Postgres;

        public bool existe;
        public String mensagem = "";

        public DAO_Usuario(DAOConfiguraConexaoPostgres conexao)
        {
            this.conexao_Postgres = conexao;
        }

        public void grava_Usuario(ModeloUsuario usuario)
        {
            try
            {
                //Uso @ como identificador de variaveis
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "INSERT INTO a_usuario (c_nome, c_senha, c_filial, c_dtcadastro, c_caixa, c_email)" + 
                                  " VALUES (@nome, @senha, @filial, @dtcadastro, @caixa, @email) RETURNING c_codigo; ";//select @@IDENTITY; SELECT NEXTVAL(a_usuario_c_codigo_seq)

                cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                cmd.Parameters.AddWithValue("@filial", usuario.Filial);
                cmd.Parameters.AddWithValue("@dtcadastro", usuario.DataCad);
                cmd.Parameters.AddWithValue("@caixa", usuario.Caixa);
                cmd.Parameters.AddWithValue("@email", usuario.Email);

                conexao_Postgres.Conectar();
                usuario.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao_Postgres.Desconectar();
            }
        }

        public void alterar_Usuario(ModeloUsuario usuario)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "UPDATE a_usuario SET c_nome = @nome, c_senha = @senha, c_filial = @filial, c_caixa = @caixa, c_email = @email" + 
                                  " WHERE c_codigo = @codigo;";

                cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                cmd.Parameters.AddWithValue("@filial", usuario.Filial);
                cmd.Parameters.AddWithValue("@codigo", usuario.Codigo);
                cmd.Parameters.AddWithValue("@caixa", usuario.Caixa);
                cmd.Parameters.AddWithValue("@email", usuario.Email);

                conexao_Postgres.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao_Postgres.Desconectar();
            }
        }

        public void excluir_Usuario(int codigo)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "DELETE FROM a_usuario WHERE c_codigo = @codigo;";

                cmd.Parameters.AddWithValue("@codigo", codigo);

                conexao_Postgres.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao_Postgres.Desconectar();
            }
        }

        public DataTable pesquisa_Usuario_Nome(String pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT * FROM a_usuario WHERE c_nome LIKE '" + pesquisa + "%'", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }//Fim Pesquisa usuario por nome

        public DataTable pesquisa_Usuario_Codigo(int pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from a_usuario where c_codigo = " + pesquisa, conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
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
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_dtcadastro, c_filial, c_caixa, c_nome, c_email, c_senha" + 
                                                             " FROM a_usuario ORDER BY c_codigo", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }

        }//Fim Lista Usuario

        public ModeloUsuario informaProximoCodigo()
        {
            ModeloUsuario modelo = new ModeloUsuario();
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = conexao_Postgres.ObjetoConexao;
            cmd.CommandText = "SELECT last_value + 1 as proximo from a_usuario_c_codigo_seq;";

            conexao_Postgres.Conectar();
            NpgsqlDataReader dt = cmd.ExecuteReader();
            if (dt.HasRows)
            {
                dt.Read();
                modelo.Codigo = Convert.ToInt32(dt["proximo"]);
            }

            conexao_Postgres.Desconectar();

            return modelo;
        }

        public ModeloUsuario carregaModeloUsuario(int codigo)
        {
            ModeloUsuario modelo = new ModeloUsuario();
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = conexao_Postgres.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM a_usuario WHERE c_codigo = @codigo;";

            cmd.Parameters.AddWithValue("@codigo", codigo);

            conexao_Postgres.Conectar();
            NpgsqlDataReader dt = cmd.ExecuteReader();
            if (dt.HasRows)
            {
                dt.Read();
                modelo.Codigo = Convert.ToInt32(dt["c_codigo"]);
                modelo.Nome = Convert.ToString(dt["c_nome"]);
                modelo.Senha = Convert.ToString(dt["c_senha"]);
                modelo.Filial = Convert.ToInt32(dt["c_filial"]);
                modelo.DataCad = Convert.ToDateTime(dt["c_dtcadastro"]);
                modelo.Caixa = Convert.ToInt32(dt["c_caixa"]);
                modelo.Email = Convert.ToString(dt["c_email"]);
            }

            conexao_Postgres.Desconectar();

            return modelo;
        }

        public bool verifica_Usuario_Login(String login, String senha)
        {
            ModeloUsuario modelo = new ModeloUsuario();
            NpgsqlCommand cmd = new NpgsqlCommand();

            try
            {
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "SELECT * FROM a_usuario WHERE c_nome = @nome  AND c_senha = @senha;";

                cmd.Parameters.AddWithValue("@nome", login);
                cmd.Parameters.AddWithValue("@senha", senha);

                conexao_Postgres.Conectar();
                NpgsqlDataReader dt = cmd.ExecuteReader();

                if (dt.HasRows)
                {
                    existe = true;
                }

                return existe;
            }
            catch (Exception erro)
            {
                mensagem = "Erro com banco de dados";
                throw erro;
            }
            finally
            {
                conexao_Postgres.Desconectar();
            }
        }
    }
}
