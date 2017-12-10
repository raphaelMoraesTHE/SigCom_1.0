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
            popula_Grid();       
        }
        public void popula_Grid()
        {
            try
            {
                DAO.DAO_Usuario usuario_BLL = new DAO.DAO_Usuario();
                dgv_Usuario.DataSource = usuario_BLL.lista_Usuario();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao listar usuário " + erro);
            }
        }
    }
}
