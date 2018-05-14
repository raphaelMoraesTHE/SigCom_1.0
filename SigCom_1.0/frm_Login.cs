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

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            bool retorno = false;            

            NpgsqlConnection conectar = new NpgsqlConnection(conexao);
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
            conectar.Close();
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
