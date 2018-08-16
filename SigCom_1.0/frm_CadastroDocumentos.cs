using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using Model;
using BLL;

namespace GUI
{
    public partial class frm_CadastroDocumentos : Form
    {
        DAOConfiguraConexaoPostgres cx = null;

        string operacao;
        public string codigo = null;

        public frm_CadastroDocumentos()
        {
            InitializeComponent();
        }

        private void frm_CadastroDocumentos_Load(object sender, EventArgs e)
        {
            this.altera_Botoes(1);
            this.desabilita_Campos();
            this.popula_Grid();
            cbx_PesquisarDocumento.SelectedIndex = 0;
        }

        public void popula_Grid()
        {
            try
            {
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_Documentos bll = new BLL_Documentos(cx);

                dgv_CadastroDocumento.DataSource = bll.lista_Documentos();

                //Definição de layout das colunas e cabeçalho do dataGrid.
                dgv_CadastroDocumento.RowHeadersWidth = 24;
                dgv_CadastroDocumento.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dgv_CadastroDocumento.Columns[0].HeaderText = "Código";
                dgv_CadastroDocumento.Columns[0].Width = 60;
                dgv_CadastroDocumento.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_CadastroDocumento.Columns[1].HeaderText = "Descrição";
                dgv_CadastroDocumento.Columns[1].Width = 750;
                dgv_CadastroDocumento.Columns[2].HeaderText = "Ord.Venc.";
                dgv_CadastroDocumento.Columns[2].Width = 80;                
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar caixa " + erro);
            }
        }

        public void desabilita_Campos()
        {
            txb_CodigoDocumento.ReadOnly = true;
            txb_DescricaoTipoDocumento.ReadOnly = true;
            chb_AtivoInativoDocumento.Enabled = false;
            chb_BaixaOrdVencDocumento.Enabled = false;            
        }

        public void habilita_Campos()
        {
            txb_CodigoDocumento.ReadOnly = false;
            txb_DescricaoTipoDocumento.ReadOnly = false;
            chb_AtivoInativoDocumento.Enabled = true;
            chb_BaixaOrdVencDocumento.Enabled = true;
        }

        public void limpa_Campos()
        {
            txb_CodigoDocumento.Clear();
            txb_DescricaoTipoDocumento.Clear();
            chb_AtivoInativoDocumento.Refresh();
            chb_BaixaOrdVencDocumento.Refresh();            
        }

        public void altera_Botoes(int op)
        {
            //op = operações que serão realizadas com os botoes
            // 1 = preparar os botoes para inserir / localizar
            // 2 = preparar os botoes para inserir / alterar um registro
            // 3 = preparar a tela para excluir / alterar

            btn_NovoDocumento.Enabled = false;
            btn_AlterarDocumento.Enabled = false;
            btn_PesquisarDocumento.Enabled = false;
            btn_ExcluirDocumento.Enabled = false;
            btn_GravarDocumento.Enabled = false;
            //btn_ImprimirCaixa.Enabled     = false;
            btn_Cancelar.Enabled = false;

            if (op == 1)
            {
                btn_NovoDocumento.Enabled = true;
                btn_PesquisarDocumento.Enabled = true;
                this.desabilita_Campos();
            }

            if (op == 2)
            {
                btn_GravarDocumento.Enabled = true;
                btn_Cancelar.Enabled = true;
                this.habilita_Campos();
            }

            if (op == 3)
            {
                btn_AlterarDocumento.Enabled = true;
                btn_ExcluirDocumento.Enabled = true;
                btn_Cancelar.Enabled = true;
                this.desabilita_Campos();
            }
        }

        private void btn_NovoDocumento_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.altera_Botoes(2);
            this.limpa_Campos();
            //this.habilita_Campos();
            tabControl1.SelectTab(1);
            txb_CodigoDocumento.Focus();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            frm_CadastroDocumentos_Load(sender, e);
            tabControl1.SelectTab(0);
        }

        private void btn_AlterarDocumento_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.altera_Botoes(2);
            //this.habilita_Campos();
            txb_CodigoDocumento.ReadOnly = true;
        }

        private void btn_GravarDocumento_Click(object sender, EventArgs e)
        {
            try
            {
                //Leitura dos dados
                ModeloDocumentos obj_Documentos = new ModeloDocumentos();

                obj_Documentos.Codigo = txb_CodigoDocumento.Text;
                obj_Documentos.Descricao = txb_DescricaoTipoDocumento.Text;
                obj_Documentos.OrdPag = Convert.ToBoolean(chb_BaixaOrdVencDocumento.Checked);
                obj_Documentos.Inativo = Convert.ToBoolean(chb_AtivoInativoDocumento.Checked);

                //obj para gravar os dados no banco
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_Documentos bll = new BLL_Documentos(cx);

                if (this.operacao == "inserir")
                {
                    bll.grava_Documentos(obj_Documentos);
                    MessageBox.Show("Registro gravado com sucesso!\nCodigo: " + obj_Documentos.Codigo.ToString());
                }
                else
                {
                    obj_Documentos.Codigo = txb_CodigoDocumento.Text;
                    bll.altera_Documentos(obj_Documentos);
                }

                this.popula_Grid();
                this.limpa_Campos();
                //this.desabilita_Campos();
                this.altera_Botoes(1);
                tabControl1.SelectTab(0);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar tipo de documento " + erro);
            }
        }

        private void btn_ExcluirDocumento_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DAOConfiguraConexaoPostgres cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_Documentos bll = new BLL_Documentos(cx);
                    bll.excluir_Documentos(Convert.ToString(txb_CodigoDocumento.Text));

                    this.popula_Grid();
                    this.limpa_Campos();
                    this.altera_Botoes(1);
                    tabControl1.SelectTab(0);
                }
            }
            catch
            {
                MessageBox.Show("Não é possivel excluir o registro, \nO registro está sendo utilizado em outro local.");
                this.altera_Botoes(3);
            }
        }

        private void btn_PesquisarDocumento_Click(object sender, EventArgs e)
        {
            cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
            BLL_Documentos bll = new BLL_Documentos(cx);
            if (cbx_PesquisarDocumento.SelectedIndex == 0)
            {
                dgv_CadastroDocumento.DataSource = bll.pesquisa_Documentos_Nome(txb_PesquisaDocumento.Text);
            }
            if (cbx_PesquisarDocumento.SelectedIndex == 1)
            {
                dgv_CadastroDocumento.DataSource = bll.pesquisa_Documentos_Codigo(txb_PesquisaDocumento.Text);
            }
        }

        private void dgv_CadastroDocumento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToString(dgv_CadastroDocumento.Rows[e.RowIndex].Cells[0].Value);
                MessageBox.Show("codigo selecionado = " + codigo.ToString());

                if (codigo != null)
                {
                    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_Documentos bll = new BLL_Documentos(cx);
                    ModeloDocumentos modelo = bll.carregaModeloDocumentos(codigo);

                    tabControl1.SelectTab(1);

                    txb_CodigoDocumento.Text = modelo.Codigo;
                    txb_DescricaoTipoDocumento.Text = modelo.Descricao;
                    chb_BaixaOrdVencDocumento.Checked = modelo.OrdPag;
                    chb_AtivoInativoDocumento.Checked = modelo.Inativo;

                    this.altera_Botoes(3);
                }
                else
                {
                    limpa_Campos();
                    altera_Botoes(1);
                }
            }
        }

        private void dgv_CadastroDocumento_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToString(dgv_CadastroDocumento.Rows[e.RowIndex].Cells[0].Value);

                if (codigo != null)
                {
                    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_Documentos bll = new BLL_Documentos(cx);
                    ModeloDocumentos modelo = bll.carregaModeloDocumentos(codigo);

                    txb_CodigoDocumento.Text = modelo.Codigo;
                    txb_DescricaoTipoDocumento.Text = modelo.Descricao;
                    chb_BaixaOrdVencDocumento.Checked = modelo.OrdPag;
                    chb_AtivoInativoDocumento.Checked = modelo.Inativo;
                }
                else
                {
                    limpa_Campos();
                    altera_Botoes(1);
                }
            }
        }
    }
}
