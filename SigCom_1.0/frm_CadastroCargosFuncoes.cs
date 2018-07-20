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
    public partial class frm_CadastroCargosFuncoes : Form
    {
        DAOConfiguraConexaoPostgres cx = null;

        string operacao;
        public int codigo = 0;

        public frm_CadastroCargosFuncoes()
        {
            InitializeComponent();
        }

        private void frm_CadastroCargosFuncoes_Load(object sender, EventArgs e)
        {
            this.altera_Botoes(1);
            this.desabilita_Campos();
            this.popula_Grid();
            cbx_PesquisarCargosFuncoes.SelectedIndex = 0;
        }

        public void popula_Grid()
        {
            try
            {
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_CargosFuncoes bll = new BLL_CargosFuncoes(cx);

                dgv_CadastroCargosFuncoes.DataSource = bll.lista_CargosFuncoes();

                //Definição de layout das colunas e cabeçalho do dataGrid.
                dgv_CadastroCargosFuncoes.RowHeadersWidth = 24;
                dgv_CadastroCargosFuncoes.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dgv_CadastroCargosFuncoes.Columns[0].HeaderText = "Código";
                dgv_CadastroCargosFuncoes.Columns[0].Width = 60;
                dgv_CadastroCargosFuncoes.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_CadastroCargosFuncoes.Columns[1].HeaderText = "Descrição";
                dgv_CadastroCargosFuncoes.Columns[1].Width = 600;
                dgv_CadastroCargosFuncoes.Columns[2].HeaderText = "Vendedor";
                dgv_CadastroCargosFuncoes.Columns[2].Width = 75;
                dgv_CadastroCargosFuncoes.Columns[3].HeaderText = "Tecnico";
                dgv_CadastroCargosFuncoes.Columns[3].Width = 75;                
                dgv_CadastroCargosFuncoes.Columns[4].HeaderText = "Motorista";
                dgv_CadastroCargosFuncoes.Columns[4].Width = 75;
                dgv_CadastroCargosFuncoes.Columns[5].HeaderText = "Supervisor";
                dgv_CadastroCargosFuncoes.Columns[5].Width = 75;
                dgv_CadastroCargosFuncoes.Columns[6].HeaderText = "Cobrador";
                dgv_CadastroCargosFuncoes.Columns[6].Width = 75;
                dgv_CadastroCargosFuncoes.Columns[7].HeaderText = "Outros";
                dgv_CadastroCargosFuncoes.Columns[7].Width = 75;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar cargos e funções " + erro);
            }
        }

        public void desabilita_Campos()
        {
            txb_DescricaoCargosFuncoes.ReadOnly = true;
            chb_FuncaoCobrador.Enabled = false;
            chb_FuncaoMotorista.Enabled = false;
            chb_FuncaoOutros.Enabled = false;
            chb_FuncaoSupervisor.Enabled = false;
            chb_FuncaoTecnico.Enabled = false;
            chb_FuncaoVendedor.Enabled = false;            
        }

        public void habilita_Campos()
        {
            txb_DescricaoCargosFuncoes.ReadOnly = false;
            chb_FuncaoCobrador.Enabled = true;
            chb_FuncaoMotorista.Enabled = true;
            chb_FuncaoOutros.Enabled = true;
            chb_FuncaoSupervisor.Enabled = true;
            chb_FuncaoTecnico.Enabled = true;
            chb_FuncaoVendedor.Enabled = true;
        }

        public void limpa_Campos()
        {
            txb_DescricaoCargosFuncoes.Clear();
            chb_FuncaoCobrador.Checked = false;
            chb_FuncaoMotorista.Checked = false;
            chb_FuncaoOutros.Checked = false;
            chb_FuncaoSupervisor.Checked = false;
            chb_FuncaoTecnico.Checked = false;
            chb_FuncaoVendedor.Checked = false;
        }

        public void altera_Botoes(int op)
        {
            //op = operações que serão realizadas com os botoes
            // 1 = preparar os botoes para inserir / localizar
            // 2 = preparar os botoes para inserir / alterar um registro
            // 3 = preparar a tela para excluir / alterar

            btn_NovoCargosFuncoes.Enabled = false;
            btn_AlterarCargosFuncoes.Enabled = false;
            btn_PesquisarCargosFuncoes.Enabled = false;
            btn_ExcluirCargosFuncoes.Enabled = false;
            btn_GravarCargosFuncoes.Enabled = false;
            //btn_ImprimirCargosFuncoes.Enabled = false;
            btn_Cancelar.Enabled = false;

            if (op == 1)
            {
                btn_NovoCargosFuncoes.Enabled = true;
                btn_PesquisarCargosFuncoes.Enabled = true;
                this.desabilita_Campos();
            }

            if (op == 2)
            {
                btn_GravarCargosFuncoes.Enabled = true;
                btn_Cancelar.Enabled = true;
                this.habilita_Campos();
            }

            if (op == 3)
            {
                btn_AlterarCargosFuncoes.Enabled = true;
                btn_ExcluirCargosFuncoes.Enabled = true;
                btn_Cancelar.Enabled = true;
                this.desabilita_Campos();
            }
        }

        private void btn_NovoCargosFuncoes_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.altera_Botoes(2);
            this.limpa_Campos();
            //this.habilita_Campos();
            tabControl1.SelectTab(1);
            txb_DescricaoCargosFuncoes.Focus();

            try
            {
                BLL_CargosFuncoes bll = new BLL_CargosFuncoes(cx);
                ModeloCargosFuncoes modelo = bll.informaProximoCodigo();
                txb_CodigoCargosFuncoes.Text = modelo.Codigo.ToString();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Infomar o proximo código " + erro);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.altera_Botoes(1);
            this.limpa_Campos();
            tabControl1.SelectTab(0);
        }

        private void btn_AlterarCargosFuncoes_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.altera_Botoes(2);
            //this.habilita_Campos();
        }

        private void btn_GravarCargosFuncoes_Click(object sender, EventArgs e)
        {
            try
            {
                //Leitura dos dados
                ModeloCargosFuncoes obj_CargosFuncoes = new ModeloCargosFuncoes();

                obj_CargosFuncoes.Descricao = txb_DescricaoCargosFuncoes.Text;
                obj_CargosFuncoes.Cobrador = Convert.ToBoolean(chb_FuncaoCobrador.Checked);
                obj_CargosFuncoes.Motorista = Convert.ToBoolean(chb_FuncaoMotorista.Checked);
                obj_CargosFuncoes.Outros = Convert.ToBoolean(chb_FuncaoOutros.Checked);
                obj_CargosFuncoes.Supervisor = Convert.ToBoolean(chb_FuncaoSupervisor.Checked);
                obj_CargosFuncoes.Tecnico = Convert.ToBoolean(chb_FuncaoTecnico.Checked);
                obj_CargosFuncoes.Vendedor = Convert.ToBoolean(chb_FuncaoVendedor.Checked);

                //obj para gravar os dados no banco
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_CargosFuncoes bll = new BLL_CargosFuncoes(cx);

                if (this.operacao == "inserir")
                {
                    bll.grava_CargosFuncoes(obj_CargosFuncoes);
                    MessageBox.Show("Registro gravado com sucesso!\nCodigo: " + obj_CargosFuncoes.Codigo.ToString());
                }
                else
                {
                    obj_CargosFuncoes.Codigo = Convert.ToInt32(txb_CodigoCargosFuncoes.Text);
                    bll.altera_CargosFuncoes(obj_CargosFuncoes);
                }

                this.popula_Grid();
                this.limpa_Campos();
                //this.desabilita_Campos();
                this.altera_Botoes(1);
                tabControl1.SelectTab(0);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar cargos e funções " + erro);
            }
        }

        private void btn_ExcluirCargosFuncoes_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DAOConfiguraConexaoPostgres cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_CargosFuncoes bll = new BLL_CargosFuncoes(cx);
                    bll.excluir_CargosFuncoes(Convert.ToInt32(txb_CodigoCargosFuncoes.Text));

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

        private void btn_PesquisarCargosFuncoes_Click(object sender, EventArgs e)
        {
            cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
            BLL_CargosFuncoes bll = new BLL_CargosFuncoes(cx);
            if (cbx_PesquisarCargosFuncoes.SelectedIndex == 0)
            {
                dgv_CadastroCargosFuncoes.DataSource = bll.pesquisa_CargosFuncoes_Nome(txb_PesquisaCargosFuncoes.Text);
            }
            if (cbx_PesquisarCargosFuncoes.SelectedIndex == 1)
            {
                if (txb_PesquisaCargosFuncoes.Text.Length <= 0)
                {
                    dgv_CadastroCargosFuncoes.DataSource = bll.pesquisa_CargosFuncoes_Nome(txb_PesquisaCargosFuncoes.Text);
                }
                else
                {
                    try
                    {
                        dgv_CadastroCargosFuncoes.DataSource = bll.pesquisa_CargosFuncoes_Codigo(Convert.ToInt32(txb_PesquisaCargosFuncoes.Text));
                    }
                    catch (Exception erro)
                    {

                        MessageBox.Show("Pesquisa só recebe numeros!" + erro);
                    }
                }
            }
        }

        private void dgv_CadastroCargosFuncoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_CadastroCargosFuncoes.Rows[e.RowIndex].Cells[0].Value);
                MessageBox.Show("codigo selecionado = " + codigo.ToString());

                if (codigo != 0)
                {
                    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_CargosFuncoes bll = new BLL_CargosFuncoes(cx);
                    ModeloCargosFuncoes modelo = bll.carregaModeloCargosFuncoes(codigo);

                    tabControl1.SelectTab(1);

                    txb_CodigoCargosFuncoes.Text = modelo.Codigo.ToString();
                    txb_DescricaoCargosFuncoes.Text = modelo.Descricao;
                    chb_FuncaoCobrador.Checked = Convert.ToBoolean(modelo.Cobrador);
                    chb_FuncaoMotorista.Checked = Convert.ToBoolean(modelo.Motorista);
                    chb_FuncaoOutros.Checked = Convert.ToBoolean(modelo.Outros);
                    chb_FuncaoSupervisor.Checked = Convert.ToBoolean(modelo.Supervisor);
                    chb_FuncaoTecnico.Checked = Convert.ToBoolean(modelo.Tecnico);
                    chb_FuncaoVendedor.Checked = Convert.ToBoolean(modelo.Vendedor);

                    this.altera_Botoes(3);
                }
                else
                {
                    limpa_Campos();
                    altera_Botoes(1);
                }
            }
        }

        private void dgv_CadastroCargosFuncoes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_CadastroCargosFuncoes.Rows[e.RowIndex].Cells[0].Value);

                if (codigo != 0)
                {
                    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_CargosFuncoes bll = new BLL_CargosFuncoes(cx);
                    ModeloCargosFuncoes modelo = bll.carregaModeloCargosFuncoes(codigo);

                    txb_CodigoCargosFuncoes.Text = modelo.Codigo.ToString();
                    txb_DescricaoCargosFuncoes.Text = modelo.Descricao;
                    chb_FuncaoCobrador.Checked = Convert.ToBoolean(modelo.Cobrador);
                    chb_FuncaoMotorista.Checked = Convert.ToBoolean(modelo.Motorista);
                    chb_FuncaoOutros.Checked = Convert.ToBoolean(modelo.Outros);
                    chb_FuncaoSupervisor.Checked = Convert.ToBoolean(modelo.Supervisor);
                    chb_FuncaoTecnico.Checked = Convert.ToBoolean(modelo.Tecnico);
                    chb_FuncaoVendedor.Checked = Convert.ToBoolean(modelo.Vendedor);
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
