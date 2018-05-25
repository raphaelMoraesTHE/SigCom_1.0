using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace GUI
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        string conexao = "Host=localhost;Username=postgres;Password=raphael;Database=sigcom";

        private void frm_Login_Load(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection conectar = new NpgsqlConnection(conexao);
                conectar.Open();
                if (conectar.State == ConnectionState.Open)
                    this.Show();
                conectar.Close();
            }
            catch (Exception)
            {
                frm_ConectaBanco formConectaBanco = new frm_ConectaBanco();
                formConectaBanco.ShowDialog();
            }

        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conectar = new NpgsqlConnection(conexao);
            try
            {
                bool retorno = false;
                
                conectar.Open();

                NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM a_usuario WHERE c_nome = '" + txb_Usuario.Text + "' AND c_senha = '" + txb_Senha.Text + "'", conectar);
                NpgsqlDataReader lerDados = comando.ExecuteReader();

                if (lerDados.Read())
                {
                    retorno = true;
                    frm_Principal formPrincipal = new frm_Principal(txb_Usuario.Text);
                    formPrincipal.Show();

                    MessageBox.Show("Login realizado com sucesso!");
                    this.Hide();
                }
                if (retorno == false)
                {
                    MessageBox.Show("Usuário ou senha incorreto, tente novamente!");
                }

                lerDados.Close();                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao consultar dados empresa." + erro);
                frm_ConectaBanco formConectaBanco = new frm_ConectaBanco();
                formConectaBanco.ShowDialog();
            }
            finally
            {
                conectar.Close();
            }
            
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação?", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            else
                this.Close();           
        }

        //private void frm_Login_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    btn_Cancelar_Click(sender, e);
        //}
    }
}
