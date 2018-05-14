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
        }

        
    }
}
