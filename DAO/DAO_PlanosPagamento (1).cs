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
    public class DAO_PlanosPagamento
    {
        private DAOConfiguraConexaoPostgres conexao_Postgres;

        public DAO_PlanosPagamento(DAOConfiguraConexaoPostgres conexao)
        {
            this.conexao_Postgres = conexao;
        }

        public void grava_PlanoPagamento(ModeloPlanosPagamento planosPagamento)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "INSERT INTO a_planopagto(c_descricao, c_pagamento, c_abreviacao, c_comissao, c_tpcomissao, c_valminvenda, c_maxdesconto, c_descnota, c_descitem, c_precoprom, " + 
                                                           "c_entrobrigatoria, c_altquantparc, c_altvalparc, c_valintparc, c_tpvencimento, c_maxparcelas, c_primeirovenc, c_limiteprimeirovenc, c_limiteultimovenc, " + 
                                                           "c_vencparcelas, c_minentrada, c_jurosfincomentr, c_jurosfinsement) " + 
                                                           "VALUES " +
                                                           "(@descricao, @pagamento, @abreviacao, @comissao, @tpcomissao, @valminvenda, @maxdesconto, @descnota, @descitem, @precoprom, " +
                                                           "@entrobrigatoria, @altquantparc, @altvalparc, @valintparc, @tpvencimento, @maxparcelas, @primeirovenc, @limiteprimeirovenc, @limiteultimovenc, " +
                                                           "@vencparcelas, @minentrada, @jurosfincomentr, @jurosfinsement) RETURNING c_codigo;";

                cmd.Parameters.AddWithValue("@descricao", planosPagamento.Descricao);
                cmd.Parameters.AddWithValue("@pagamento", planosPagamento.Pagamento);
                cmd.Parameters.AddWithValue("@abreviacao", planosPagamento.Abreviacao);
                cmd.Parameters.AddWithValue("@comissao", planosPagamento.Comissao);
                cmd.Parameters.AddWithValue("@tpcomissao", planosPagamento.TpComissao);
                cmd.Parameters.AddWithValue("@valminvenda", planosPagamento.ValMinVenda);
                cmd.Parameters.AddWithValue("@maxdesconto", planosPagamento.MaxDesconto);
                cmd.Parameters.AddWithValue("@descnota", planosPagamento.DescNota);
                cmd.Parameters.AddWithValue("@descitem", planosPagamento.DescItem);
                cmd.Parameters.AddWithValue("@precoprom", planosPagamento.PrecoProm);
                cmd.Parameters.AddWithValue("@entrobrigatoria", planosPagamento.EntrObrigatoria);
                cmd.Parameters.AddWithValue("@altquantparc", planosPagamento.AltQuantParc);
                cmd.Parameters.AddWithValue("@altvalparc", planosPagamento.AltValParc);
                cmd.Parameters.AddWithValue("@valintparc", planosPagamento.ValIntParc);
                cmd.Parameters.AddWithValue("@tpvencimento", planosPagamento.TpVencimento);
                cmd.Parameters.AddWithValue("@maxparcelas", planosPagamento.MaxParcelas);
                cmd.Parameters.AddWithValue("@primeirovenc", planosPagamento.PrimeiroVenc);
                cmd.Parameters.AddWithValue("@limiteprimeirovenc", planosPagamento.LimitePrimeiroVenc);
                cmd.Parameters.AddWithValue("@limiteultimovenc", planosPagamento.LimiteUltimoVenc);
                cmd.Parameters.AddWithValue("@vencparcelas", planosPagamento.VencParcelas);
                cmd.Parameters.AddWithValue("@minentrada", planosPagamento.MinEntrada);
                cmd.Parameters.AddWithValue("@jurosfincomentr", planosPagamento.JurosFincomEntrada);
                cmd.Parameters.AddWithValue("@jurosfinsement", planosPagamento.JurosFinsemEmtrada);
                
                conexao_Postgres.Conectar();
                planosPagamento.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void altera_PlanoPagamento(ModeloPlanosPagamento planosPagamento)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "UPDATE a_planopagto SET c_descricao = @descricao, c_pagamento = @pagamento, c_abreviacao = @abreviacao, c_comissao = @comissao, c_tpcomissao = @tpcomissao, c_valminvenda = @valminvenda, c_maxdesconto = @maxdesconto, c_descnota = @descnota, c_descitem = @descitem, " +
                                                          "c_precoprom = @precoprom, c_entrobrigatoria = @entrobrigatoria, c_altquantparc = @altquantparc, c_altvalparc = @altvalparc, c_valintparc = @valintparc, c_tpvencimento = @tpvencimento, c_maxparcelas = @maxparcelas, c_primeirovenc = @primeirovenc, " +
                                                          "c_limiteprimeirovenc = @limiteprimeirovenc, c_limiteultimovenc = @limiteultimovenc, c_vencparcelas = @vencparcelas, c_minentrada = @minentrada, c_jurosfincomentr = @jurosfincomentr, c_jurosfinsement = @jurosfinsement " + 
                                                          "WHERE c_codigo = @codigo;";

                cmd.Parameters.AddWithValue("@codigo", planosPagamento.Codigo);
                cmd.Parameters.AddWithValue("@descricao", planosPagamento.Descricao);
                cmd.Parameters.AddWithValue("@pagamento", planosPagamento.Pagamento);
                cmd.Parameters.AddWithValue("@abreviacao", planosPagamento.Abreviacao);
                cmd.Parameters.AddWithValue("@comissao", planosPagamento.Comissao);
                cmd.Parameters.AddWithValue("@tpcomissao", planosPagamento.TpComissao);
                cmd.Parameters.AddWithValue("@valminvenda", planosPagamento.ValMinVenda);
                cmd.Parameters.AddWithValue("@maxdesconto", planosPagamento.MaxDesconto);
                cmd.Parameters.AddWithValue("@descnota", planosPagamento.DescNota);
                cmd.Parameters.AddWithValue("@descitem", planosPagamento.DescItem);
                cmd.Parameters.AddWithValue("@precoprom", planosPagamento.PrecoProm);
                cmd.Parameters.AddWithValue("@entrobrigatoria", planosPagamento.EntrObrigatoria);
                cmd.Parameters.AddWithValue("@altquantparc", planosPagamento.AltQuantParc);
                cmd.Parameters.AddWithValue("@altvalparc", planosPagamento.AltValParc);
                cmd.Parameters.AddWithValue("@valintparc", planosPagamento.ValIntParc);
                cmd.Parameters.AddWithValue("@tpvencimento", planosPagamento.TpVencimento);
                cmd.Parameters.AddWithValue("@maxparcelas", planosPagamento.MaxParcelas);
                cmd.Parameters.AddWithValue("@primeirovenc", planosPagamento.PrimeiroVenc);
                cmd.Parameters.AddWithValue("@limiteprimeirovenc", planosPagamento.LimitePrimeiroVenc);
                cmd.Parameters.AddWithValue("@limiteultimovenc", planosPagamento.LimiteUltimoVenc);
                cmd.Parameters.AddWithValue("@vencparcelas", planosPagamento.VencParcelas);
                cmd.Parameters.AddWithValue("@minentrada", planosPagamento.MinEntrada);
                cmd.Parameters.AddWithValue("@jurosfincomentr", planosPagamento.JurosFincomEntrada);
                cmd.Parameters.AddWithValue("@jurosfinsement", planosPagamento.JurosFinsemEmtrada);

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

        public void excluir_PlanoPagamento(int codigo)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "DELETE FROM a_planopagto WHERE c_codigo = @codigo;";

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

        public DataTable pesquisa_PlanoPagamento_Nome(String pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_descricao, c_pagamento, c_abreviacao, c_comissao, c_valminvenda, c_maxdesconto, c_descnota, c_descitem, c_precoprom, c_jurosfincomentr, c_jurosfinsement FROM a_planopagto WHERE c_descricao LIKE '" + pesquisa + "%'", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_PlanoPagamento_Codigo(int pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_descricao, c_pagamento, c_abreviacao, c_comissao, c_valminvenda, c_maxdesconto, c_descnota, c_descitem, c_precoprom, c_jurosfincomentr, c_jurosfinsement FROM a_planopagto WHERE c_codigo = " + pesquisa, conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable lista_PlanoPagamento()
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_descricao, c_pagamento, c_abreviacao, c_comissao, c_valminvenda, c_maxdesconto, c_descnota, c_descitem, c_precoprom, c_jurosfincomentr, c_jurosfinsement FROM a_planopagto ORDER BY c_codigo", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloPlanosPagamento informaProximoCodigo()
        {
            ModeloPlanosPagamento modelo = new ModeloPlanosPagamento();
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = conexao_Postgres.ObjetoConexao;
            cmd.CommandText = "SELECT last_value + 1 as proximo from a_planopagto_c_codigo_seq;";

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

        public ModeloPlanosPagamento carregaModeloPlanoPagamento(int codigo)
        {
            ModeloPlanosPagamento modelo = new ModeloPlanosPagamento();
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = conexao_Postgres.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM a_planopagto WHERE c_codigo = @codigo;";

            cmd.Parameters.AddWithValue("@codigo", codigo);

            conexao_Postgres.Conectar();
            NpgsqlDataReader dt = cmd.ExecuteReader();
            if (dt.HasRows)
            {
                dt.Read();
                modelo.Codigo = Convert.ToInt32(dt["c_codigo"]);
                modelo.Descricao = Convert.ToString(dt["c_descricao"]);
                modelo.Pagamento = Convert.ToString(dt["c_pagamento"]);
                modelo.Abreviacao = Convert.ToString(dt["c_abreviacao"]);
                modelo.Comissao = Convert.ToDouble(dt["c_comissao"]);
                modelo.TpComissao = Convert.ToString(dt["c_tpcomissao"]);
                modelo.ValMinVenda = Convert.ToDouble(dt["c_valminvenda"]);
                modelo.MaxDesconto = Convert.ToDouble(dt["c_maxdesconto"]);
                modelo.DescNota = Convert.ToBoolean(dt["c_descnota"]);
                modelo.DescItem = Convert.ToBoolean(dt["c_descitem"]);
                modelo.PrecoProm = Convert.ToBoolean(dt["c_precoprom"]);
                modelo.EntrObrigatoria = Convert.ToBoolean(dt["c_entrobrigatoria"]);
                modelo.AltQuantParc = Convert.ToBoolean(dt["c_altquantparc"]);
                modelo.AltValParc = Convert.ToBoolean(dt["c_altvalparc"]);
                modelo.ValIntParc = Convert.ToBoolean(dt["c_valintparc"]);
                modelo.TpVencimento = Convert.ToString(dt["c_tpvencimento"]);
                modelo.MaxParcelas = Convert.ToInt32(dt["c_maxparcelas"]);
                modelo.PrimeiroVenc = Convert.ToInt32(dt["c_primeirovenc"]);
                modelo.LimitePrimeiroVenc = Convert.ToInt32(dt["c_limiteprimeirovenc"]);
                modelo.LimiteUltimoVenc = Convert.ToInt32(dt["c_limiteultimovenc"]);
                modelo.VencParcelas = Convert.ToInt32(dt["c_vencparcelas"]);
                modelo.MinEntrada = Convert.ToDouble(dt["c_minentrada"]);
                modelo.JurosFincomEntrada = Convert.ToDouble(dt["c_jurosfincomentrada"]);
                modelo.JurosFinsemEmtrada = Convert.ToDouble(dt["c_jurosfinsementrada"]);
            }

            conexao_Postgres.Desconectar();

            return modelo;
        }
    }
}
