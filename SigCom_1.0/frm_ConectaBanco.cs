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
    public partial class frm_ConectaBanco : Form
    {
        public frm_ConectaBanco()
        {
            InitializeComponent();
            acaoToolTip();
        }

        public void acaoToolTip()
        {
            this.ttp_BalaoAjuda.SetToolTip(this.txt_NomeBanco, "Digite o nome do Banco de dados.");
            this.ttp_BalaoAjuda.SetToolTip(this.txt_EnderecoServidor, "Digite o endereço IP do Servidor ou localhost se este for o servidor.");
            this.ttp_BalaoAjuda.SetToolTip(this.txt_UsuarioBanco, "Digite o nome do usuário do Banco de Dados.");
            this.ttp_BalaoAjuda.SetToolTip(this.txt_SenhaBanco, "Digite a senha do Banco de dados.");
            this.ttp_BalaoAjuda.SetToolTip(this.txt_PortaBanco, "Digite a porta de comunicação do Banco de dados.");
            this.ttp_BalaoAjuda.SetToolTip(this.btn_TestarConexao, "Clique para testar a conexão com o servidor.");
            this.ttp_BalaoAjuda.SetToolTip(this.btn_GravarConexao, "Clique para salvar os dados da conexão.");
            this.ttp_BalaoAjuda.SetToolTip(this.btn_Cancelar, "Clique para cancelar as configurações.");
        }
    }
}
