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
    public class DAO_Funcionario
    {
        private DAOConfiguraConexaoPostgres conexao_Postgres;

        public DAO_Funcionario(DAOConfiguraConexaoPostgres conexao)
        {
            this.conexao_Postgres = conexao;
        }

        public void grava_Funcionario(ModeloFuncionario funcionario)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "INSERT INTO" +
                                 " a_funcionario " +
                                 "(c_dtcadastro, c_filial, c_nome, c_apelido, c_endereco, c_endnumero, c_complemento, c_bairro, c_cep, c_telefone, c_celular, c_fax," +
                                  " c_codmunicipio, c_cpf, c_identidade, c_cnh, c_cnhcategoria, c_cnhvalidade, c_nascimento, c_ctps, c_dtadmissao, c_dtafastamento," + 
                                  " c_inativo, c_observacao, c_comisav, c_comisap, c_comisren)" +
                                  " VALUES " +
                                  "(@dtcadastro, @filial, @nome, @apelido, @endereco, @endnumero, @complemento, @bairro, @cep, @telefone, @celular, @fax," +
                                  " @codmunicipio, @cpf, @identidade, @cnh, @cnhcategoria, @cnhvalidade, @nascimento, @ctps, @dtadmissao, @dtafastamento," +
                                  " @inativo, @observacao, @comisav, @comisap, @comisren)" +
                                  "RETURNING c_codigo;";

                cmd.Parameters.AddWithValue("@dtcadastro", funcionario.DataCadastro);
                cmd.Parameters.AddWithValue("@filial", funcionario.Filial);
                cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
                cmd.Parameters.AddWithValue("@apelido", funcionario.Apelido);
                cmd.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                cmd.Parameters.AddWithValue("@endnumero", funcionario.EndNumero);
                cmd.Parameters.AddWithValue("@complemento", funcionario.Complemento);
                cmd.Parameters.AddWithValue("@bairro", funcionario.Bairro);
                cmd.Parameters.AddWithValue("@cep", funcionario.Cep);
                cmd.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                cmd.Parameters.AddWithValue("@celular", funcionario.Celular);
                cmd.Parameters.AddWithValue("@fax", funcionario.Fax);
                cmd.Parameters.AddWithValue("@codmunicipio", funcionario.CodMunicipio);
                cmd.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                cmd.Parameters.AddWithValue("@identidade", funcionario.Identidade);
                cmd.Parameters.AddWithValue("@cnh", funcionario.Cnh);
                cmd.Parameters.AddWithValue("@cnhcategoria", funcionario.CnhCategoria);
                cmd.Parameters.AddWithValue("@inativo", funcionario.Inativo);
                cmd.Parameters.AddWithValue("@observacao", funcionario.Observacao);
                cmd.Parameters.AddWithValue("@comisav", funcionario.ComissaoAvista);
                cmd.Parameters.AddWithValue("@comisap", funcionario.ComissaoAprazo);
                cmd.Parameters.AddWithValue("@comisren", funcionario.ComissaoRenegociacao);
                cmd.Parameters.AddWithValue("@ctps", funcionario.Ctps);
                //cmd.Parameters.AddWithValue("@cnhvalidade", funcionario.DataCnhValidade);
                if (funcionario.DataCnhValidade == null)
                {
                    cmd.Parameters.AddWithValue("@cnhvalidade", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@cnhvalidade", funcionario.DataCnhValidade);
                }

                //cmd.Parameters.AddWithValue("@nascimento", funcionario.DataNascimento);
                if (funcionario.DataNascimento == null)
                {
                    cmd.Parameters.AddWithValue("@nascimento", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@nascimento", funcionario.DataNascimento);
                }                

                //cmd.Parameters.AddWithValue("@dtadmissao", funcionario.DataAdmissao);
                if (funcionario.DataAdmissao == null)
                {
                    cmd.Parameters.AddWithValue("@dtadmissao", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@dtadmissao", funcionario.DataAdmissao);
                }

                //cmd.Parameters.AddWithValue("@dtafastamento", funcionario.DataAfastamento);
                if (funcionario.DataAfastamento == null)
                {
                    cmd.Parameters.AddWithValue("@dtafastamento", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@dtafastamento", funcionario.DataAfastamento);
                }

                conexao_Postgres.Conectar();
                funcionario.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
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

        public void altera_Funcionario(ModeloFuncionario funcionario)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "UPDATE " +
                                  "a_funcionario " +
                                  "SET " +
                                  "c_filial = @filial, c_nome = @nome, c_apelido = @apelido, c_endereco = @endereco, c_endnumero = @endnumero, c_complemento = @complemento, " + 
                                  "c_bairro = @bairro, c_cep = @cep, c_telefone = @telefone, c_celular = @celular, c_fax = @fax, c_codmunicipio = @codmunicipio, c_cpf = @cpf, " + 
                                  "c_identidade = @identidade, c_cnh = @cnh, c_cnhcategoria = @cnhcategoria, c_cnhvalidade = @cnhvalidade, c_nascimento = @nascimento, c_ctps = @ctps, " + 
                                  "c_dtadmissao = @dtadmissao, c_dtafastamento = @dtafastamento, c_inativo = @inativo, c_observacao = @observacao, c_comisav = @comisav, " + 
                                  "c_comisap = @comisap, c_comisren = @comisren " +
                                  "WHERE " +
                                  "c_codigo = @codigo;";

                cmd.Parameters.AddWithValue("@codigo", funcionario.Codigo);
                cmd.Parameters.AddWithValue("@dtcadastro", funcionario.DataCadastro);
                cmd.Parameters.AddWithValue("@filial", funcionario.Filial);
                cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
                cmd.Parameters.AddWithValue("@apelido", funcionario.Apelido);
                cmd.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                cmd.Parameters.AddWithValue("@endnumero", funcionario.EndNumero);
                cmd.Parameters.AddWithValue("@complemento", funcionario.Complemento);
                cmd.Parameters.AddWithValue("@bairro", funcionario.Bairro);
                cmd.Parameters.AddWithValue("@cep", funcionario.Cep);
                cmd.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                cmd.Parameters.AddWithValue("@celular", funcionario.Celular);
                cmd.Parameters.AddWithValue("@fax", funcionario.Fax);
                cmd.Parameters.AddWithValue("@codmunicipio", funcionario.CodMunicipio);
                cmd.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                cmd.Parameters.AddWithValue("@identidade", funcionario.Identidade);
                cmd.Parameters.AddWithValue("@cnh", funcionario.Cnh);
                cmd.Parameters.AddWithValue("@cnhcategoria", funcionario.CnhCategoria);
                cmd.Parameters.AddWithValue("@inativo", funcionario.Inativo);
                cmd.Parameters.AddWithValue("@observacao", funcionario.Observacao);
                cmd.Parameters.AddWithValue("@comisav", funcionario.ComissaoAvista);
                cmd.Parameters.AddWithValue("@comisap", funcionario.ComissaoAprazo);
                cmd.Parameters.AddWithValue("@comisren", funcionario.ComissaoRenegociacao);
                cmd.Parameters.AddWithValue("@ctps", funcionario.Ctps);
                //cmd.Parameters.AddWithValue("@cnhvalidade", funcionario.DataCnhValidade);
                if (funcionario.DataCnhValidade == null)
                {
                    cmd.Parameters.AddWithValue("@cnhvalidade", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@cnhvalidade", funcionario.DataCnhValidade);
                }

                //cmd.Parameters.AddWithValue("@nascimento", funcionario.DataNascimento);
                if (funcionario.DataNascimento == null)
                {
                    cmd.Parameters.AddWithValue("@nascimento", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@nascimento", funcionario.DataNascimento);
                }

                //cmd.Parameters.AddWithValue("@dtadmissao", funcionario.DataAdmissao);
                if (funcionario.DataAdmissao == null)
                {
                    cmd.Parameters.AddWithValue("@dtadmissao", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@dtadmissao", funcionario.DataAdmissao);
                }

                //cmd.Parameters.AddWithValue("@dtafastamento", funcionario.DataAfastamento);
                if (funcionario.DataAfastamento == null)
                {
                    cmd.Parameters.AddWithValue("@dtafastamento", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@dtafastamento", funcionario.DataAfastamento);
                }

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

        public void excluir_Funcionario(int codigo)
        {
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conexao_Postgres.ObjetoConexao;
                cmd.CommandText = "DELETE FROM a_funcionario WHERE c_codigo = @codigo;";

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

        public DataTable pesquisa_Funcionario_Nome(String pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_nome, c_dtcadastro, c_apelido, c_endereco, c_bairro, c_cep, c_telefone, c_celular, c_identidade, c_cpf, c_comisav, c_comisap, c_comisren FROM a_funcionario WHERE c_nome LIKE '" + pesquisa + "%'", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_Funcionario_Codigo(int pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_nome, c_dtcadastro, c_apelido, c_endereco, c_bairro, c_cep, c_telefone, c_celular, c_identidade, c_cpf, c_comisav, c_comisap, c_comisren FROM a_funcionario WHERE c_codigo = " + pesquisa, conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable pesquisa_Funcionario_Cpf(String pesquisa)
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_nome, c_dtcadastro, c_apelido, c_endereco, c_bairro, c_cep, c_telefone, c_celular, c_identidade, c_cpf, c_comisav, c_comisap, c_comisren FROM a_funcionario WHERE c_cpf = '" + pesquisa + "';", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public DataTable lista_Funcionario()
        {
            try
            {
                DataTable tabela = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT c_codigo, c_nome, c_dtcadastro, c_apelido, c_endereco, c_bairro, c_cep, c_telefone, c_celular, c_identidade, c_cpf, c_comisav, c_comisap, c_comisren FROM a_funcionario ORDER BY c_codigo", conexao_Postgres.StringDeConexaoPostgres);

                da.Fill(tabela);

                return tabela;
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public ModeloFuncionario informaProximoCodigo()
        {
            ModeloFuncionario modelo = new ModeloFuncionario();
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = conexao_Postgres.ObjetoConexao;
            cmd.CommandText = "SELECT last_value + 1 as proximo from a_funcionario_c_codigo_seq;";

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

        public ModeloFuncionario carregaModeloFuncionario(int codigo)
        {
            ModeloFuncionario modelo = new ModeloFuncionario();
            NpgsqlCommand cmd = new NpgsqlCommand();

            cmd.Connection = conexao_Postgres.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM a_funcionario WHERE c_codigo = @codigo;";

            cmd.Parameters.AddWithValue("@codigo", codigo);

            conexao_Postgres.Conectar();
            NpgsqlDataReader dt = cmd.ExecuteReader();
            if (dt.HasRows)
            {
                dt.Read();
                modelo.Codigo = Convert.ToInt32(dt["c_codigo"]);
                modelo.DataCadastro = Convert.ToDateTime(dt["c_dtcadastro"]);
                modelo.Filial = Convert.ToInt32(dt["c_filial"]);
                modelo.Nome = Convert.ToString(dt["c_nome"]);
                modelo.Apelido = Convert.ToString(dt["c_apelido"]);                
                modelo.Endereco = Convert.ToString(dt["c_endereco"]);
                modelo.EndNumero = Convert.ToString(dt["c_endnumero"]);
                modelo.Complemento = Convert.ToString(dt["c_complemento"]);
                modelo.Bairro = Convert.ToString(dt["c_bairro"]);
                modelo.Cep = Convert.ToString(dt["c_cep"]);
                modelo.Telefone = Convert.ToString(dt["c_telefone"]);
                modelo.Celular = Convert.ToString(dt["c_celular"]);
                modelo.Fax = Convert.ToString(dt["c_fax"]);
                modelo.CodMunicipio = Convert.ToInt32(dt["c_codmunicipio"]);
                modelo.Cpf = Convert.ToString(dt["c_cpf"]);
                modelo.Identidade = Convert.ToString(dt["c_identidade"]);
                modelo.Cnh = Convert.ToString(dt["c_cnh"]);
                modelo.CnhCategoria = Convert.ToString(dt["c_cnhcategoria"]);                
                modelo.DataCnhValidade = Convert.ToDateTime(dt["c_cnhvalidade"]);
                modelo.DataNascimento = Convert.ToDateTime(dt["c_nascimento"]);
                modelo.Ctps = Convert.ToString(dt["c_ctps"]);
                modelo.DataAdmissao = Convert.ToDateTime(dt["c_dtadmissao"]);
                modelo.DataAfastamento = Convert.ToDateTime(dt["c_dtafastamento"]);
                modelo.Inativo = Convert.ToBoolean(dt["c_inativo"]);
                modelo.Observacao = Convert.ToString(dt["c_observacao"]);
                modelo.ComissaoAvista = Convert.ToDouble(dt["c_comisav"]);
                modelo.ComissaoAprazo = Convert.ToDouble(dt["c_comisap"]);
                modelo.ComissaoRenegociacao = Convert.ToDouble(dt["c_comisren"]);
            }

            conexao_Postgres.Desconectar();

            return modelo;
        }
    }
}
