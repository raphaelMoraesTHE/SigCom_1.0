﻿using System;
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
        String conexao_Postgres = @"Server = localhost; Port = 5432; Database = sigcom; User Id = postgres; Password = raphael;";
        NpgsqlConnection conexao = null;

        public List<string> listaUsuario()
        {
            try
            {
                conexao = new NpgsqlConnection(conexao_Postgres);
                NpgsqlCommand sql = new NpgsqlCommand("select c_codigo as Código, c_filial as Filial, c_nome as Nome, c_senha as Senha from a_usuario", conexao);

                List<string> usuario = new List<string>();

                conexao.Open();

                NpgsqlDataReader lerDados;
                lerDados = sql.ExecuteReader();

                while (lerDados.Read())
                {
                    usuario.Add(lerDados["codigo"].ToString());
                    usuario.Add(lerDados["nome"].ToString());
                    usuario.Add(lerDados["senha"].ToString());
                    usuario.Add(lerDados["loja"].ToString());
                }
                return usuario;
            }
            catch (Exception erro)
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
                NpgsqlCommand sql = new NpgsqlCommand("select c_codigo as Código, c_filial as Filial, c_nome as Nome, c_senha as Senha from a_usuario order by c_codigo", conexao);
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter();
                dataAdapter.SelectCommand = sql;

                DataTable dtUsuario = new DataTable();
                dataAdapter.Fill(dtUsuario);

                return dtUsuario;
            }
            catch (Exception erro)
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
            catch (Exception erro)
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
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }

        public void grava_Usuario(ModeloUsuario usuario)
        {
            try
            {
                //Uso @ como identificador de variaveis
                conexao = new NpgsqlConnection(conexao_Postgres);
                NpgsqlCommand sql = new NpgsqlCommand("insert into a_usuario (c_nome, c_senha, c_filial) values (@nome, @senha, @filial)", conexao);

                sql.Parameters.AddWithValue("@nome", usuario.Nome);
                sql.Parameters.AddWithValue("@senha", usuario.Senha);
                sql.Parameters.AddWithValue("@filial", usuario.Filial);

                conexao.Open();
                sql.ExecuteNonQuery();
            }
            catch (Exception erro)
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