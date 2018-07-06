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
    public class DAO_Caixa
    {
        private DAOConfiguraConexaoPostgres conexao_Postgres;

        public DAO_Caixa(DAOConfiguraConexaoPostgres conexao)
        {
            this.conexao_Postgres = conexao;
        }

        public void grava_Caixa(ModeloCaixa caixa)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "INSERT INTO a_caixa (c_descricao) VALUES (@descricao) RETURNING c_codigo;";

                cmd.Parameters.AddWithValue("@descricao", caixa.Descricao);

                conexao_Postgres.Conectar();
                caixa.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void altera_Caixa(ModeloCaixa caixa)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "UPDATE a_caixa SET c_descricao = @descricao WHERE c_codigo = @codigo;";

                cmd.Parameters.AddWithValue("@descricao", caixa.Descricao);

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

        public void excluir_Caixa(int codigo)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "DELETE FROM a_caixa WHERE c_codigo = @codigo;";

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

        public DataTable pesquisa_Caixa_Nome(String pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT * FROM a_caixa WHERE c_descricao LIKE '" + pesquisa + "%'", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_Caixa_Codigo(int pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT * FROM a_caixa WHERE c_codigo = " + pesquisa, conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable lista_Caixa()
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_descricao FROM a_caixa ORDER BY c_codigo", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloCaixa informaProximoCodigo()
        {
            ModeloCaixa modelo = new ModeloCaixa();
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = conexao_Postgres.ObjetoConexao;
            cmd.CommandText = "SELECT last_value + 1 as proximo from a_caixa_c_codigo_seq;";

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

        public ModeloCaixa carregaModeloCaixa(int codigo)
        {
            ModeloCaixa modelo = new ModeloCaixa();
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = conexao_Postgres.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM a_caixa WHERE c_codigo = @codigo;";

            cmd.Parameters.AddWithValue("@codigo", codigo);

            conexao_Postgres.Conectar();
            NpgsqlDataReader dt = cmd.ExecuteReader();
            if (dt.HasRows)
            {
                dt.Read();
                modelo.Codigo = Convert.ToInt32(dt["c_codigo"]);
                modelo.Descricao = Convert.ToString(dt["c_descricao"]);
            }

            conexao_Postgres.Desconectar();

            return modelo;
        }
    }
}
