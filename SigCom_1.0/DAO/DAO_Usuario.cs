using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace SigCom_1._0.DAO
{
    class DAO_Usuario
    {
        String conexao_Postgres = @"Server = localhost; Port = 5432; Database = sigcom; User Id = postgres; Password = raphael;";
        NpgsqlConnection conexao = null;

        public List<string> listaUsuario()
        {
            try
            {
                conexao = new NpgsqlConnection(conexao_Postgres);
                NpgsqlCommand sql = new NpgsqlCommand("select c_codigo as codigo, c_nome as nome, c_senha as senha from a_usuario", conexao);

                List<string> usuario = new List<string>();

                conexao.Open();

                NpgsqlDataReader lerDados;
                lerDados = sql.ExecuteReader();

                while (lerDados.Read())
                {
                    usuario.Add(lerDados["codigo"].ToString());
                    usuario.Add(lerDados["nome"].ToString());
                    usuario.Add(lerDados["senha"].ToString());
                }
                return usuario;
            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
            
        }//Fim lista usuario

        public DataTable lista_Usuario()
        {
            try
            {
                conexao = new NpgsqlConnection(conexao_Postgres);
                NpgsqlCommand sql = new NpgsqlCommand("select c_codigo as codigo, c_nome as nome, c_senha as senha from a_usuario", conexao);
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter();
                dataAdapter.SelectCommand = sql;

                DataTable dtUsuario = new DataTable();
                dataAdapter.Fill(dtUsuario);

                return dtUsuario;
            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }//Fim Lista Usuario

        public DataTable pesquisa_Usuario_Nome(string pesquisa)
        {
            try
            {
                conexao = new NpgsqlConnection(conexao_Postgres);
                NpgsqlCommand sql = new NpgsqlCommand("select * from a_usuario where c_nome like " + pesquisa + "%'", conexao);
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter();
                dataAdapter.SelectCommand = sql;

                DataTable dtUsuario = new DataTable();
                dataAdapter.Fill(dtUsuario);

                return dtUsuario;
            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }//Fim Pesquisa usuario por nome

        public DataTable pesquisa_Usuario_Codigo(string pesquisa)
        {
            try
            {
                conexao = new NpgsqlConnection(conexao_Postgres);
                NpgsqlCommand sql = new NpgsqlCommand("select * from a_usuario where c_codigo = " + pesquisa, conexao);
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter();
                dataAdapter.SelectCommand = sql;

                DataTable dtUsuario = new DataTable();
                dataAdapter.Fill(dtUsuario);

                return dtUsuario;
            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }

        public void grava_Usuario(Modelo.ModeloUsuario usuario)
        {
            try
            {
                //Uso @ como identificador de variaveis
                conexao = new NpgsqlConnection(conexao_Postgres);
                NpgsqlCommand sql = new NpgsqlCommand("insert into a_usuario (nome, senha) values (@nome, @senha)", conexao);

                sql.Parameters.AddWithValue("@nome", usuario.Nome);
                sql.Parameters.AddWithValue("@senha", usuario.Senha);

                conexao.Open();
                sql.ExecuteNonQuery();
            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
