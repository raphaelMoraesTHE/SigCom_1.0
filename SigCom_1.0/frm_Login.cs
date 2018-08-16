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
using DAO;
using BLL;
using Model;

namespace GUI
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        string conexao = DadosConexaoPostgres.StringDeConexaoPostgres; 
        DAOConfiguraConexaoPostgres cx = null;

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
                MessageBox.Show("Falha ao consultar dados empresa. Por favor verifique os dados da conexão.");
                frm_ConectaBanco formConectaBanco = new frm_ConectaBanco();
                formConectaBanco.ShowDialog();
                formConectaBanco.Dispose();
            }

        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {            
            try
            {
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_Usuario bll = new BLL_Usuario(cx);

                bll.verifica_Usuario_Login(txb_Usuario.Text, txb_Senha.Text);

                if (bll.existe)
                {
                    frm_Principal formPrincipal = new frm_Principal(txb_Usuario.Text);
                    formPrincipal.Show();
                    
                    this.Hide();                    
                    MessageBox.Show("Login realizado com sucesso!");                    
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorreto, tente novamente!");
                }
                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Falha ao consultar dados empresa." + erro);
                frm_ConectaBanco formConectaBanco = new frm_ConectaBanco();
                formConectaBanco.ShowDialog();
                formConectaBanco.Dispose();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação?", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            else
                this.Close();           
        }
        
    }
}
