using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        public frm_Principal(string usuario)
        {            
            InitializeComponent();
            tsl_UsuarioLogado.Text = "Usuário: " + usuario;
        }      

        private void frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("A aplicação será encerrada!", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;            
            else
                Application.ExitThread();                
        }

        private void cadastroDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadastroUsuario formularioCadastroUsuario = new frm_CadastroUsuario();
            formularioCadastroUsuario.ShowDialog();
            formularioCadastroUsuario.Dispose();
        }

        private void cadastroDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadastroCaixa formularioCadastroCaixa = new frm_CadastroCaixa();
            formularioCadastroCaixa.ShowDialog();
            formularioCadastroCaixa.Dispose();
        }

        private void saldosDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadastroSaldoCaixa formularioCadastroSaldoCaixa = new frm_CadastroSaldoCaixa();
            formularioCadastroSaldoCaixa.ShowDialog();
            formularioCadastroSaldoCaixa.Dispose();
        }

        private void lojasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadastroEmpresa formularioEmpresa = new frm_CadastroEmpresa();
            formularioEmpresa.ShowDialog();
            formularioEmpresa.Dispose();
        }

        private void cadastroDePerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadastroPerfilUsuario formularioPerfilUsuario = new frm_CadastroPerfilUsuario();
            formularioPerfilUsuario.ShowDialog();
            formularioPerfilUsuario.Dispose();
        }

        private void cadastroDeFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadastroFuncionario formularioFuncionario = new frm_CadastroFuncionario();
            formularioFuncionario.ShowDialog();
            formularioFuncionario.Dispose();
        }

        private void cadastroDeFunçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadastroCargosFuncoes formularioCargosFuncoes = new frm_CadastroCargosFuncoes();
            formularioCargosFuncoes.ShowDialog();
            formularioCargosFuncoes.Dispose();
        }

        private void operaçõesComerciaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_OperacoesComerciais formularioOperacoesComerciais = new frm_OperacoesComerciais();
            formularioOperacoesComerciais.ShowDialog();
            formularioOperacoesComerciais.Dispose();
        }

        private void cFOPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadastroCFOP formularioCFOP = new frm_CadastroCFOP();
            formularioCFOP.ShowDialog();
            formularioCFOP.Dispose();
        }

        private void centroDeCustoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadastroCentroCusto formularioCentroCustos = new frm_CadastroCentroCusto();
            formularioCentroCustos.ShowDialog();
            formularioCentroCustos.Dispose();
        }
    }
}
