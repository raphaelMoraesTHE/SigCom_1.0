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

namespace SigCom_1._0
{
    public partial class frm_CadastroUsuario : Form
    {
        public frm_CadastroUsuario()
        {
            InitializeComponent();
        }
        
        private void frm_CadastroUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sigcomDataSet.a_usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.a_usuarioTableAdapter.Fill(this.sigcomDataSet.a_usuario);            
        }
    }
}
