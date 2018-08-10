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
    public class DAO_TabCFOP
    {
        private DAOConfiguraConexaoPostgres conexao_Postgres;

        public DAO_TabCFOP(DAOConfiguraConexaoPostgres conexao)
        {
            this.conexao_Postgres = conexao;
        }

        public void grava_CFOP(ModeloTabCFOP cfop)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "INSERT INTO tab_cfop (natureza, descricao, es, dentro, complemento, imobilizado) VALUES (@natureza, @descricao, @es, @dentro, @complemento, @imobilizado) RETURNING id;";

                cmd.Parameters.AddWithValue("@natureza", cfop.Natureza);
                cmd.Parameters.AddWithValue("@descricao", cfop.Descricao);
                cmd.Parameters.AddWithValue("@es", cfop.ES);
                cmd.Parameters.AddWithValue("@dentro", cfop.Dentro);
                cmd.Parameters.AddWithValue("@complemento", cfop.Complemento);
                cmd.Parameters.AddWithValue("@imobilizado", cfop.Imobilizado);

                conexao_Postgres.Conectar();
                cfop.Id = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void altera_CFOP(ModeloTabCFOP cfop)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "UPDATE tab_cfop SET natureza = @natureza, descricao = @descricao, es = @es, dentro = @dentro, complemento = @complemento, imobilizado = @imobilizado WHERE natureza = @natureza;";

                cmd.Parameters.AddWithValue("@id", cfop.Id);
                cmd.Parameters.AddWithValue("@natureza", cfop.Natureza);
                cmd.Parameters.AddWithValue("@descricao", cfop.Descricao);
                cmd.Parameters.AddWithValue("@es", cfop.ES);
                cmd.Parameters.AddWithValue("@dentro", cfop.Dentro);
                cmd.Parameters.AddWithValue("@complemento", cfop.Complemento);
                cmd.Parameters.AddWithValue("@imobilizado", cfop.Imobilizado);

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

        public void excluir_CFOP(string natureza)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "DELETE FROM tab_cfop WHERE natureza = @natureza;";

                cmd.Parameters.AddWithValue("@natureza", natureza);

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

        public DataTable pesquisa_CFOP_Descricao(String pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT natureza, descricao, es, dentro, complemento, imobilizado FROM tab_cfop WHERE descricao LIKE '" + pesquisa + "%'", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_CFOP_Natureza(String pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT natureza, descricao, es, dentro, complemento, imobilizado FROM tab_cfop WHERE natureza LIKE '" + pesquisa + "%'", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable lista_CFOP()
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT natureza, descricao, es, dentro, complemento, imobilizado FROM tab_cfop ORDER BY natureza", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        
        public ModeloTabCFOP carregaModeloTabCFOP(string natureza)
        {
            ModeloTabCFOP modelo = new ModeloTabCFOP();
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = conexao_Postgres.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM tab_cfop WHERE natureza = @natureza;";

            cmd.Parameters.AddWithValue("@natureza", natureza);

            conexao_Postgres.Conectar();
            NpgsqlDataReader dt = cmd.ExecuteReader();
            if (dt.HasRows)
            {
                dt.Read();
                modelo.Natureza = Convert.ToString(dt["natureza"]);
                modelo.Descricao = Convert.ToString(dt["descricao"]);
                modelo.ES = Convert.ToString(dt["es"]);
                modelo.Dentro = Convert.ToString(dt["dentro"]);
                modelo.Complemento = Convert.ToString(dt["complemento"]);
                modelo.Imobilizado = Convert.ToString(dt["imobilizado"]);
            }

            conexao_Postgres.Desconectar();

            return modelo;
        }
    }
}
