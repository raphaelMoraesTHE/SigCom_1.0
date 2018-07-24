using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Npgsql;
using System.Data;

namespace DAO
{
    public class DAO_SaldoCaixa
    {
        private DAOConfiguraConexaoPostgres conexao_Postgres;

        public DAO_SaldoCaixa(DAOConfiguraConexaoPostgres conexao)
        {
            this.conexao_Postgres = conexao;
        }

        public void grava_SaldoCaixa(ModeloSaldoCaixa saldoCaixa)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "INSERT INTO a_saldocaixa (c_descricao, c_tiposaldo, c_tef, c_prazo, c_inativo) VALUES (@descricao, @tiposaldo, @tef, @prazo, @inativo) RETURNING c_codigo;";

                cmd.Parameters.AddWithValue("@descricao", saldoCaixa.Descricao);
                cmd.Parameters.AddWithValue("@tiposaldo", saldoCaixa.TipoSaldo);
                cmd.Parameters.AddWithValue("@tef", saldoCaixa.Tef);
                cmd.Parameters.AddWithValue("@prazo", saldoCaixa.Prazo);
                cmd.Parameters.AddWithValue("@inativo", saldoCaixa.Inativo);

                conexao_Postgres.Conectar();
                saldoCaixa.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void altera_SaldoCaixa(ModeloSaldoCaixa saldoCaixa)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "UPDATE a_saldocaixa SET c_descricao = @descricao, c_tiposaldo = @tiposaldo, c_tef = @tef, c_prazo = @prazo, c_inativo = @inativo WHERE c_codigo = @codigo;";

                cmd.Parameters.AddWithValue("@codigo", saldoCaixa.Codigo);
                cmd.Parameters.AddWithValue("@descricao", saldoCaixa.Descricao);
                cmd.Parameters.AddWithValue("@tiposaldo", saldoCaixa.TipoSaldo);
                cmd.Parameters.AddWithValue("@tef", saldoCaixa.Tef);
                cmd.Parameters.AddWithValue("@prazo", saldoCaixa.Prazo);
                cmd.Parameters.AddWithValue("@inativo", saldoCaixa.Inativo);

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

        public void excluir_SaldoCaixa(int codigo)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "DELETE FROM a_saldocaixa WHERE c_codigo = @codigo;";

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

        public DataTable pesquisa_SaldoCaixa_Nome(String pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_descricao, c_tiposaldo, c_tef, c_prazo, c_inativo FROM a_saldocaixa WHERE c_descricao LIKE '" + pesquisa + "%'", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
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
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_descricao, c_tiposaldo, c_tef, c_prazo, c_inativo FROM a_saldocaixa WHERE c_codigo = " + pesquisa, conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
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
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_descricao, c_tiposaldo, c_tef, c_prazo, c_inativo FROM a_saldocaixa ORDER BY c_codigo", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloSaldoCaixa informaProximoCodigo()
        {
            ModeloSaldoCaixa modelo = new ModeloSaldoCaixa();
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = conexao_Postgres.ObjetoConexao;
            cmd.CommandText = "SELECT last_value + 1 as proximo from a_saldocaixa_c_codigo_seq;";

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

        public ModeloSaldoCaixa carregaModeloCaixa(int codigo)
        {
            ModeloSaldoCaixa modelo = new ModeloSaldoCaixa();
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = conexao_Postgres.ObjetoConexao;
            cmd.CommandText = "SELECT c_codigo, c_descricao, c_tiposaldo, c_tef, c_prazo, c_inativo FROM a_saldocaixa WHERE c_codigo = @codigo;";

            cmd.Parameters.AddWithValue("@codigo", codigo);

            conexao_Postgres.Conectar();
            NpgsqlDataReader dt = cmd.ExecuteReader();
            if (dt.HasRows)
            {
                dt.Read();
                modelo.Codigo = Convert.ToInt32(dt["c_codigo"]);
                modelo.Descricao = Convert.ToString(dt["c_descricao"]);
                modelo.TipoSaldo = Convert.ToString(dt["c_tiposaldo"]);
                modelo.Tef = Convert.ToBoolean(dt["c_tef"]);
                modelo.Prazo = Convert.ToBoolean(dt["c_prazo"]);
                modelo.Inativo = Convert.ToBoolean(dt["c_inativo"]);
            }

            conexao_Postgres.Desconectar();

            return modelo;
        }
    }
}
