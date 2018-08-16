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
using BLL;
using Model;

namespace GUI
{
    public partial class frm_CadastroFuncionario : Form
    {
        DAOConfiguraConexaoPostgres cx = null;

        string operacao;
        public int codigo = 0;

        public frm_CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void frm_CadastroFuncionario_Load(object sender, EventArgs e)
        {
            this.altera_Botoes(1);
            this.desabilita_Campos();
            this.popula_Grid();
            cbx_PesquisarFuncionario.SelectedIndex = 0;
        }

        public void popula_Grid()
        {
            try
            {
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_Funcionario bll = new BLL_Funcionario(cx);

                dgv_CadastroFuncionario.DataSource = bll.lista_Funcionario();

                //Definição de layout das colunas e cabeçalho do dataGrid.
                dgv_CadastroFuncionario.RowHeadersWidth = 24;
                dgv_CadastroFuncionario.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dgv_CadastroFuncionario.Columns[0].HeaderText = "Código";
                dgv_CadastroFuncionario.Columns[0].Width = 60;
                dgv_CadastroFuncionario.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_CadastroFuncionario.Columns[1].HeaderText = "Nome";
                dgv_CadastroFuncionario.Columns[1].Width = 450;
                dgv_CadastroFuncionario.Columns[2].HeaderText = "Dt.Cad";
                dgv_CadastroFuncionario.Columns[2].Width = 80;
                dgv_CadastroFuncionario.Columns[3].HeaderText = "Apelido";
                dgv_CadastroFuncionario.Columns[3].Width = 160;
                dgv_CadastroFuncionario.Columns[4].HeaderText = "Endereço";
                dgv_CadastroFuncionario.Columns[4].Width = 260;
                dgv_CadastroFuncionario.Columns[5].HeaderText = "Bairro";
                dgv_CadastroFuncionario.Columns[5].Width = 150;
                dgv_CadastroFuncionario.Columns[6].HeaderText = "CEP";
                dgv_CadastroFuncionario.Columns[6].Width = 80;
                dgv_CadastroFuncionario.Columns[7].HeaderText = "Telefone";
                dgv_CadastroFuncionario.Columns[7].Width = 100;
                dgv_CadastroFuncionario.Columns[8].HeaderText = "Celular";
                dgv_CadastroFuncionario.Columns[8].Width = 100;
                dgv_CadastroFuncionario.Columns[9].HeaderText = "Identidade";
                dgv_CadastroFuncionario.Columns[9].Width = 120;
                dgv_CadastroFuncionario.Columns[10].HeaderText = "CPF";
                dgv_CadastroFuncionario.Columns[10].Width = 110;
                dgv_CadastroFuncionario.Columns[11].HeaderText = "Comiss.Av.";
                dgv_CadastroFuncionario.Columns[11].Width = 90;
                dgv_CadastroFuncionario.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_CadastroFuncionario.Columns[12].HeaderText = "Comiss.Ap.";
                dgv_CadastroFuncionario.Columns[12].Width = 90;
                dgv_CadastroFuncionario.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_CadastroFuncionario.Columns[13].HeaderText = "Comiss.Ren.";
                dgv_CadastroFuncionario.Columns[13].Width = 90;
                dgv_CadastroFuncionario.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao listar usuário " + erro);
            }
        }

        public void desabilita_Campos()
        {            
            txb_AfastamentoFuncionario.ReadOnly = true;
            txb_ApelidoFuncionario.ReadOnly = true;
            txb_BairroFuncionario.ReadOnly = true;
            txb_CelularFuncionario.ReadOnly = true;
            txb_CEPFuncionario.ReadOnly = true;            
            txb_CNHCategoriaFuncionario.ReadOnly = true;
            txb_CNHFuncionario.ReadOnly = true;            
            txb_ComissaoApFuncionario.ReadOnly = true;
            txb_ComissaoAvFuncionario.ReadOnly = true;
            txb_ComissaoRenFuncionario.ReadOnly = true;
            txb_ContratacaoFuncionario.ReadOnly = true;
            txb_CPFFuncionario.ReadOnly = true;
            txb_CTPSFuncionario.ReadOnly = true;            
            txb_EndComplementoFuncionario.ReadOnly = true;
            txb_EnderecoFuncionario.ReadOnly = true;
            txb_EndNumeroFuncionario.ReadOnly = true;
            txb_FoneFaxFuncionario.ReadOnly = true;
            txb_IdentidadeFuncionario.ReadOnly = true;
            txb_NascimentoFuncionario.ReadOnly = true;
            txb_NomeFuncionario.ReadOnly = true;
            txb_ObservacoesFuncionario.ReadOnly = true;            
            txb_TelefoneFuncionario.ReadOnly = true;
            txb_VencimentoCNHFuncionario.ReadOnly = true;
            bte_CodIBGEFuncionario.TextBox.ReadOnly = true;
            bte_FilialFuncionario.TextBox.ReadOnly = true;
            bte_FuncaoFuncionario.TextBox.ReadOnly = true;
            bte_CodIBGEFuncionario.Enabled = false;
            bte_FilialFuncionario.Enabled = false;
            bte_FuncaoFuncionario.Enabled = false;
            btn_CodIBGEFuncionario.Enabled = false;
            btn_FilialFuncionario.Enabled = false;
            btn_FuncaoFuncionario.Enabled = false;
            chb_AtivoInativoFuncionario.Enabled = false;
        }

        public void habilita_Campos()
        {
            txb_AfastamentoFuncionario.ReadOnly = false;
            txb_ApelidoFuncionario.ReadOnly = false;
            txb_BairroFuncionario.ReadOnly = false;
            txb_CelularFuncionario.ReadOnly = false;
            txb_CEPFuncionario.ReadOnly = false;
            txb_CNHCategoriaFuncionario.ReadOnly = false;
            txb_CNHFuncionario.ReadOnly = false;            
            txb_ComissaoApFuncionario.ReadOnly = false;
            txb_ComissaoAvFuncionario.ReadOnly = false;
            txb_ComissaoRenFuncionario.ReadOnly = false;
            txb_ContratacaoFuncionario.ReadOnly = false;
            txb_CPFFuncionario.ReadOnly = false;
            txb_CTPSFuncionario.ReadOnly = false;
            txb_EndComplementoFuncionario.ReadOnly = false;
            txb_EnderecoFuncionario.ReadOnly = false;
            txb_EndNumeroFuncionario.ReadOnly = false;
            txb_FoneFaxFuncionario.ReadOnly = false;
            txb_IdentidadeFuncionario.ReadOnly = false;
            txb_NascimentoFuncionario.ReadOnly = false;
            txb_NomeFuncionario.ReadOnly = false;
            txb_ObservacoesFuncionario.ReadOnly = false;
            txb_TelefoneFuncionario.ReadOnly = false;
            txb_VencimentoCNHFuncionario.ReadOnly = false;
            bte_CodIBGEFuncionario.Enabled = true;            
            bte_FilialFuncionario.Enabled = true;
            bte_FuncaoFuncionario.Enabled = true;
            btn_CodIBGEFuncionario.Enabled = true;
            btn_FilialFuncionario.Enabled = true;
            btn_FuncaoFuncionario.Enabled = true;
            chb_AtivoInativoFuncionario.Enabled = true;
        }

        public void limpa_Campos()
        {
            txb_AfastamentoFuncionario.Clear();
            txb_ApelidoFuncionario.Clear();
            txb_BairroFuncionario.Clear();
            txb_CelularFuncionario.Clear();
            txb_CEPFuncionario.Clear();
            txb_CNHCategoriaFuncionario.Clear();
            txb_CNHFuncionario.Clear();
            txb_CodigoFuncionario.Clear();            
            txb_ContratacaoFuncionario.Clear();
            txb_CPFFuncionario.Clear();
            txb_CTPSFuncionario.Clear();
            txb_EndComplementoFuncionario.Clear();
            txb_EnderecoFuncionario.Clear();
            txb_EndNumeroFuncionario.Clear();
            txb_FoneFaxFuncionario.Clear();
            txb_IdentidadeFuncionario.Clear();
            txb_NascimentoFuncionario.Clear();
            txb_NomeFuncionario.Clear();
            txb_ObservacoesFuncionario.Clear();
            txb_TelefoneFuncionario.Clear();
            txb_VencimentoCNHFuncionario.Clear();
            bte_CodIBGEFuncionario.ResetText();
            bte_FilialFuncionario.ResetText();
            bte_FuncaoFuncionario.ResetText();
            chb_AtivoInativoFuncionario.Checked = false;
            txb_ComissaoApFuncionario.Text = "0,00";
            txb_ComissaoAvFuncionario.Text = "0,00";
            txb_ComissaoRenFuncionario.Text = "0,00";
        }

        public void altera_Botoes(int op)
        {
            //op = operações que serão realizadas com os botoes
            // 1 = preparar os botoes para inserir / localizar
            // 2 = preparar os botoes para inserir / alterar um registro
            // 3 = preparar a tela para excluir / alterar

            btn_NovoFuncionario.Enabled = false;
            btn_AlterarFuncionario.Enabled = false;
            btn_PesquisarFuncionario.Enabled = false;
            btn_ExcluirFuncionario.Enabled = false;
            btn_GravarFuncionario.Enabled = false;
            btn_ImprimirFuncionario.Enabled = false;
            btn_Cancelar.Enabled = false;

            if (op == 1)
            {
                btn_NovoFuncionario.Enabled = true;
                btn_PesquisarFuncionario.Enabled = true;
                this.desabilita_Campos();
            }

            if (op == 2)
            {
                btn_GravarFuncionario.Enabled = true;
                btn_Cancelar.Enabled = true;
                //btn_ImprimirFuncionario.Enabled = true;
                this.habilita_Campos();
            }

            if (op == 3)
            {
                btn_AlterarFuncionario.Enabled = true;
                btn_ExcluirFuncionario.Enabled = true;
                btn_Cancelar.Enabled = true;
                btn_ImprimirFuncionario.Enabled = true;
                this.desabilita_Campos();
            }
        }

        private void btn_NovoFuncionario_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.altera_Botoes(2);
            this.limpa_Campos();
            tabControl1.SelectTab(1);
            txb_NomeFuncionario.Focus();

            try
            {
                BLL_Funcionario bll = new BLL_Funcionario(cx);
                ModeloFuncionario modelo = bll.informaProximoCodigo();
                txb_CodigoFuncionario.Text = modelo.Codigo.ToString();
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

        private void btn_AlterarFuncionario_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.altera_Botoes(2);
        }

        private void btn_GravarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                //Leitura dos dados
                ModeloFuncionario obj_Funcionario = new ModeloFuncionario();

                obj_Funcionario.DataCadastro = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                obj_Funcionario.Filial = Convert.ToInt32(bte_FilialFuncionario.Text);
                obj_Funcionario.Nome = txb_NomeFuncionario.Text;
                obj_Funcionario.Apelido = txb_ApelidoFuncionario.Text;
                obj_Funcionario.Endereco = txb_EnderecoFuncionario.Text;
                obj_Funcionario.EndNumero = txb_EndNumeroFuncionario.Text;
                obj_Funcionario.Complemento = txb_EndComplementoFuncionario.Text;
                obj_Funcionario.Bairro = txb_BairroFuncionario.Text;
                obj_Funcionario.Cep = txb_CEPFuncionario.Text;
                obj_Funcionario.Telefone = txb_TelefoneFuncionario.Text;
                obj_Funcionario.Celular = txb_CelularFuncionario.Text;
                obj_Funcionario.Fax = txb_FoneFaxFuncionario.Text;
                obj_Funcionario.CodMunicipio = Convert.ToInt32(bte_CodIBGEFuncionario.Text);
                obj_Funcionario.Cpf = txb_CPFFuncionario.Text;
                obj_Funcionario.Identidade = txb_IdentidadeFuncionario.Text;
                obj_Funcionario.Cnh = txb_CNHFuncionario.Text;
                obj_Funcionario.CnhCategoria = txb_CNHCategoriaFuncionario.Text;               
                obj_Funcionario.Observacao = txb_ObservacoesFuncionario.Text;
                obj_Funcionario.Inativo = Convert.ToBoolean(chb_AtivoInativoFuncionario.Checked);
                obj_Funcionario.ComissaoAvista = Convert.ToDouble(txb_ComissaoAvFuncionario.Text);
                obj_Funcionario.ComissaoAprazo = Convert.ToDouble(txb_ComissaoApFuncionario.Text);
                obj_Funcionario.ComissaoRenegociacao = Convert.ToDouble(txb_ComissaoRenFuncionario.Text);
                obj_Funcionario.CargoFuncao = Convert.ToInt32(bte_FuncaoFuncionario.Text);
                // obj_Funcionario.DataCnhValidade = Convert.ToDateTime(txb_VencimentoCNHFuncionario.Text);
                if (txb_VencimentoCNHFuncionario.Text == "  /  /")
                {
                    string data = null;
                    obj_Funcionario.DataCnhValidade = Convert.ToDateTime(data);
                }
                else
                {
                    obj_Funcionario.DataCnhValidade = Convert.ToDateTime(txb_VencimentoCNHFuncionario.Text);
                }
                //obj_Funcionario.DataNascimento = Convert.ToDateTime(txb_NascimentoFuncionario.Text);
                if (txb_NascimentoFuncionario.Text == "  /  /")
                {
                    string data = null;
                    obj_Funcionario.DataNascimento = Convert.ToDateTime(data);
                }
                else
                {
                    obj_Funcionario.DataNascimento = Convert.ToDateTime(txb_NascimentoFuncionario.Text);
                }
                obj_Funcionario.Ctps = txb_CTPSFuncionario.Text;
                //obj_Funcionario.DataAdmissao = Convert.ToDateTime(txb_ContratacaoFuncionario.Text);
                if (txb_ContratacaoFuncionario.Text == "  /  /")
                {
                    string data = null;
                    obj_Funcionario.DataAdmissao = Convert.ToDateTime(data);
                }
                else
                {
                    obj_Funcionario.DataAdmissao = Convert.ToDateTime(txb_ContratacaoFuncionario.Text);
                }
                //obj_Funcionario.DataAfastamento = Convert.ToDateTime(txb_AfastamentoFuncionario.Text);
                if (txb_AfastamentoFuncionario.Text == "  /  /")
                {
                    string data = null;
                    obj_Funcionario.DataAfastamento = Convert.ToDateTime(data);
                }
                else
                {
                    obj_Funcionario.DataAfastamento = Convert.ToDateTime(txb_AfastamentoFuncionario.Text);
                }

                //obj para gravar os dados no banco
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_Funcionario bll = new BLL_Funcionario(cx);

                if (this.operacao == "inserir")
                {
                    bll.grava_Funcionario(obj_Funcionario);
                    MessageBox.Show("Registro gravado com sucesso!\nCodigo: " + obj_Funcionario.Codigo.ToString());
                }
                else
                {
                    obj_Funcionario.Codigo = Convert.ToInt32(txb_CodigoFuncionario.Text);
                    bll.altera_Funcionario(obj_Funcionario);
                }

                //this.popula_Grid();
                //this.limpa_Campos();                
                //this.altera_Botoes(1);
                this.frm_CadastroFuncionario_Load(sender, e);
                tabControl1.SelectTab(0);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar Empresa " + erro);
            }
        }

        private void btn_ExcluirFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_Funcionario bll = new BLL_Funcionario(cx);
                    bll.excluir_Funcionario(Convert.ToInt32(txb_CodigoFuncionario.Text));

                    //this.popula_Grid();
                    //this.limpa_Campos();
                    //this.altera_Botoes(1);
                    this.frm_CadastroFuncionario_Load(sender, e);
                    tabControl1.SelectTab(0);
                }
            }
            catch
            {
                MessageBox.Show("Não é possivel excluir o registro, \nO registro está sendo utilizado em outro local.");
                this.altera_Botoes(3);
            }
        }

        private void btn_PesquisarFuncionario_Click(object sender, EventArgs e)
        {
            cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
            BLL_Funcionario bll = new BLL_Funcionario(cx);
            if (cbx_PesquisarFuncionario.SelectedIndex == 0)//Pequisa empresa por nome (combobox index 0 = Nome)
            {
                dgv_CadastroFuncionario.DataSource = bll.pesquisa_Funcionario_Nome(txb_PesquisaFuncionario.Text);
            }
            if (cbx_PesquisarFuncionario.SelectedIndex == 1)//Pequisa empresa por nome (combobox index 1 = Código)
            {
                if (txb_PesquisaFuncionario.Text.Length <= 0)
                {
                    dgv_CadastroFuncionario.DataSource = bll.pesquisa_Funcionario_Nome(txb_PesquisaFuncionario.Text);
                }
                else
                {
                    try
                    {
                        dgv_CadastroFuncionario.DataSource = bll.pesquisa_Funcionario_Codigo(Convert.ToInt32(txb_PesquisaFuncionario.Text));
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Pesquisa só recebe numeros!" + erro);
                    }

                }
            }
            if (cbx_PesquisarFuncionario.SelectedIndex == 2)//Pequisa empresa por nome (combobox index 2 = CNPJ)
            {
                dgv_CadastroFuncionario.DataSource = bll.pesquisa_Funcionario_Cpf(mtb_PesquisaFuncionario.Text);
            }
        }

        private void dgv_CadastroFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_CadastroFuncionario.Rows[e.RowIndex].Cells[0].Value);
                MessageBox.Show("codigo selecionado = " + codigo.ToString());

                if (codigo != 0)
                {
                    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_Funcionario bll = new BLL_Funcionario(cx);
                    ModeloFuncionario obj_Funcionario = bll.carregaModeloFuncionario(codigo);

                    tabControl1.SelectTab(1);

                    txb_CodigoFuncionario.Text = obj_Funcionario.Codigo.ToString();
                    bte_FilialFuncionario.Text = obj_Funcionario.Filial.ToString();
                    txb_NomeFuncionario.Text = obj_Funcionario.Nome;
                    txb_ApelidoFuncionario.Text = obj_Funcionario.Apelido;
                    txb_EnderecoFuncionario.Text = obj_Funcionario.Endereco;
                    txb_EndNumeroFuncionario.Text = obj_Funcionario.EndNumero;
                    txb_EndComplementoFuncionario.Text = obj_Funcionario.Complemento;
                    txb_BairroFuncionario.Text = obj_Funcionario.Bairro;
                    txb_CEPFuncionario.Text = obj_Funcionario.Cep;
                    txb_TelefoneFuncionario.Text = obj_Funcionario.Telefone;
                    txb_CelularFuncionario.Text = obj_Funcionario.Celular;
                    txb_FoneFaxFuncionario.Text = obj_Funcionario.Fax;
                    bte_CodIBGEFuncionario.Text = obj_Funcionario.CodMunicipio.ToString();
                    txb_CPFFuncionario.Text = obj_Funcionario.Cpf;
                    txb_IdentidadeFuncionario.Text = obj_Funcionario.Identidade;
                    txb_CNHFuncionario.Text = obj_Funcionario.Cnh;
                    txb_CNHCategoriaFuncionario.Text = obj_Funcionario.CnhCategoria;
                    txb_CTPSFuncionario.Text = obj_Funcionario.Ctps;                    
                    txb_ObservacoesFuncionario.Text = obj_Funcionario.Observacao;
                    chb_AtivoInativoFuncionario.Checked = obj_Funcionario.Inativo;
                    txb_ComissaoAvFuncionario.Text = obj_Funcionario.ComissaoAvista.ToString();
                    txb_ComissaoApFuncionario.Text = obj_Funcionario.ComissaoAprazo.ToString();
                    txb_ComissaoRenFuncionario.Text = obj_Funcionario.ComissaoRenegociacao.ToString();
                    bte_FuncaoFuncionario.Text = obj_Funcionario.CargoFuncao.ToString();
                    //txb_VencimentoCNHFuncionario.Text = obj_Funcionario.DataCnhValidade.ToShortDateString();
                    if (obj_Funcionario.DataCnhValidade.ToShortDateString() == "01/01/0001")
                    {
                        txb_VencimentoCNHFuncionario.Text = "";
                    }
                    else
                    {
                        txb_VencimentoCNHFuncionario.Text = obj_Funcionario.DataCnhValidade.ToShortDateString();
                    }
                    //txb_NascimentoFuncionario.Text = obj_Funcionario.DataNascimento.ToShortDateString();
                    if (obj_Funcionario.DataNascimento.ToShortDateString() == "01/01/0001")
                    {
                        txb_NascimentoFuncionario.Text = "";
                    }
                    else
                    {
                        txb_NascimentoFuncionario.Text = obj_Funcionario.DataNascimento.ToShortDateString();
                    }
                    //txb_ContratacaoFuncionario.Text = obj_Funcionario.DataAdmissao.ToShortDateString();
                    if (obj_Funcionario.DataAdmissao.ToShortDateString() == "01/01/0001")
                    {
                        txb_ContratacaoFuncionario.Text = "";
                    }
                    else
                    {
                        txb_ContratacaoFuncionario.Text = obj_Funcionario.DataAdmissao.ToShortDateString();
                    }
                    //txb_AfastamentoFuncionario.Text = obj_Funcionario.DataAfastamento.ToShortDateString();
                    if (obj_Funcionario.DataAfastamento.ToShortDateString() == "01/01/0001")
                    {
                        txb_AfastamentoFuncionario.Text = "";
                    }
                    else
                    {
                        txb_AfastamentoFuncionario.Text = obj_Funcionario.DataAfastamento.ToShortDateString();
                    }

                    //Aqui preenche o textbox caixa usuario conforme o valor definido no campo referente ao numero do caixa
                    BLL_TabMunicipio bll_municipio = new BLL_TabMunicipio(cx);
                    ModeloTabMunicipio modelo_municipio = bll_municipio.carregaModeloMunicipio(Convert.ToInt32(bte_CodIBGEFuncionario.Text));
                    bte_CodIBGEFuncionario.TextBox.Text = modelo_municipio.Codigo.ToString();
                    txb_CidadeFuncionario.Text = modelo_municipio.Nome;
                    txb_UFFuncionario.Text = modelo_municipio.SiglaUF;

                    //Aqui preenche o textbox filial funcionario conforme o valor definido no campo referente ao codigo da filial
                    BLL_Empresa bll_empresa = new BLL_Empresa(cx);
                    ModeloEmpresa modelo_empresa = bll_empresa.carregaModeloEmpresa(Convert.ToInt32(bte_FilialFuncionario.Text));
                    bte_FilialFuncionario.TextBox.Text = modelo_empresa.Codigo.ToString();
                    txb_SiglaFilialFuncionario.Text = modelo_empresa.Sigla;

                    //Aqui preenche o textbox cargo funcionario e os checkbox conforme o valor definido no campo referente ao codigo do cargo
                    BLL_CargosFuncoes bll_CargosFuncoes = new BLL_CargosFuncoes(cx);
                    ModeloCargosFuncoes modelo_CargosFuncoes = bll_CargosFuncoes.carregaModeloCargosFuncoes(Convert.ToInt32(bte_FuncaoFuncionario.Text));
                    bte_FuncaoFuncionario.TextBox.Text = modelo_CargosFuncoes.Codigo.ToString();
                    txb_DescricaoFuncaoFuncionario.Text = modelo_CargosFuncoes.Descricao;
                    chb_FuncaoCobrador.Checked = Convert.ToBoolean(modelo_CargosFuncoes.Cobrador);
                    chb_FuncaoMotorista.Checked = Convert.ToBoolean(modelo_CargosFuncoes.Motorista);
                    chb_FuncaoOutros.Checked = Convert.ToBoolean(modelo_CargosFuncoes.Outros);
                    chb_FuncaoSupervisor.Checked = Convert.ToBoolean(modelo_CargosFuncoes.Supervisor);
                    chb_FuncaoTecnico.Checked = Convert.ToBoolean(modelo_CargosFuncoes.Tecnico);
                    chb_FuncaoVendedor.Checked = Convert.ToBoolean(modelo_CargosFuncoes.Vendedor);

                    this.altera_Botoes(3);
                }
                else
                {
                    limpa_Campos();
                    altera_Botoes(1);
                }
            }
        }

        private void dgv_CadastroFuncionario_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgv_CadastroFuncionario.Rows[e.RowIndex].Cells[0].Value);
                
                if (codigo != 0)
                {
                    cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                    BLL_Funcionario bll = new BLL_Funcionario(cx);
                    ModeloFuncionario obj_Funcionario = bll.carregaModeloFuncionario(codigo);

                    txb_CodigoFuncionario.Text = obj_Funcionario.Codigo.ToString();
                    bte_FilialFuncionario.Text = obj_Funcionario.Filial.ToString();
                    txb_NomeFuncionario.Text = obj_Funcionario.Nome;
                    txb_ApelidoFuncionario.Text = obj_Funcionario.Apelido;
                    txb_EnderecoFuncionario.Text = obj_Funcionario.Endereco;
                    txb_EndNumeroFuncionario.Text = obj_Funcionario.EndNumero;
                    txb_EndComplementoFuncionario.Text = obj_Funcionario.Complemento;
                    txb_BairroFuncionario.Text = obj_Funcionario.Bairro;
                    txb_CEPFuncionario.Text = obj_Funcionario.Cep;
                    txb_TelefoneFuncionario.Text = obj_Funcionario.Telefone;
                    txb_CelularFuncionario.Text = obj_Funcionario.Celular;
                    txb_FoneFaxFuncionario.Text = obj_Funcionario.Fax;
                    bte_CodIBGEFuncionario.Text = obj_Funcionario.CodMunicipio.ToString();
                    txb_CPFFuncionario.Text = obj_Funcionario.Cpf;
                    txb_IdentidadeFuncionario.Text = obj_Funcionario.Identidade;
                    txb_CNHFuncionario.Text = obj_Funcionario.Cnh;
                    txb_CNHCategoriaFuncionario.Text = obj_Funcionario.CnhCategoria;
                    txb_CTPSFuncionario.Text = obj_Funcionario.Ctps;
                    txb_ObservacoesFuncionario.Text = obj_Funcionario.Observacao;
                    chb_AtivoInativoFuncionario.Checked = obj_Funcionario.Inativo;
                    txb_ComissaoAvFuncionario.Text = obj_Funcionario.ComissaoAvista.ToString();
                    txb_ComissaoApFuncionario.Text = obj_Funcionario.ComissaoAprazo.ToString();
                    txb_ComissaoRenFuncionario.Text = obj_Funcionario.ComissaoRenegociacao.ToString();
                    bte_FuncaoFuncionario.Text = obj_Funcionario.CargoFuncao.ToString();
                    //txb_VencimentoCNHFuncionario.Text = obj_Funcionario.DataCnhValidade.ToShortDateString();
                    if (obj_Funcionario.DataCnhValidade.ToShortDateString() == "01/01/0001")
                    {
                        txb_VencimentoCNHFuncionario.Text = "";
                    }
                    else
                    {
                        txb_VencimentoCNHFuncionario.Text = obj_Funcionario.DataCnhValidade.ToShortDateString();
                    }
                    //txb_NascimentoFuncionario.Text = obj_Funcionario.DataNascimento.ToShortDateString();
                    if (obj_Funcionario.DataNascimento.ToShortDateString() == "01/01/0001")
                    {
                        txb_NascimentoFuncionario.Text = "";
                    }
                    else
                    {
                        txb_NascimentoFuncionario.Text = obj_Funcionario.DataNascimento.ToShortDateString();
                    }
                    //txb_ContratacaoFuncionario.Text = obj_Funcionario.DataAdmissao.ToShortDateString();
                    if (obj_Funcionario.DataAdmissao.ToShortDateString() == "01/01/0001")
                    {
                        txb_ContratacaoFuncionario.Text = "";
                    }
                    else
                    {
                        txb_ContratacaoFuncionario.Text = obj_Funcionario.DataAdmissao.ToShortDateString();
                    }
                    //txb_AfastamentoFuncionario.Text = obj_Funcionario.DataAfastamento.ToShortDateString();
                    if (obj_Funcionario.DataAfastamento.ToShortDateString() == "01/01/0001")
                    {
                        txb_AfastamentoFuncionario.Text = "";
                    }
                    else
                    {
                        txb_AfastamentoFuncionario.Text = obj_Funcionario.DataAfastamento.ToShortDateString();
                    }

                    //Aqui preenche o textbox caixa usuario conforme o valor definido no campo referente ao numero do caixa
                    BLL_TabMunicipio bll_municipio = new BLL_TabMunicipio(cx);
                    ModeloTabMunicipio modelo_municipio = bll_municipio.carregaModeloMunicipio(Convert.ToInt32(bte_CodIBGEFuncionario.Text));
                    bte_CodIBGEFuncionario.TextBox.Text = modelo_municipio.Codigo.ToString();
                    txb_CidadeFuncionario.Text = modelo_municipio.Nome;
                    txb_UFFuncionario.Text = modelo_municipio.SiglaUF;

                    //Aqui preenche o textbox filial funcionario conforme o valor definido no campo referente ao codigo da filial
                    BLL_Empresa bll_empresa = new BLL_Empresa(cx);
                    ModeloEmpresa modelo_empresa = bll_empresa.carregaModeloEmpresa(Convert.ToInt32(bte_FilialFuncionario.Text));
                    bte_FilialFuncionario.TextBox.Text = modelo_empresa.Codigo.ToString();
                    txb_SiglaFilialFuncionario.Text = modelo_empresa.Sigla;

                    //Aqui preenche o textbox cargo funcionario e os checkbox conforme o valor definido no campo referente ao codigo do cargo
                    BLL_CargosFuncoes bll_CargosFuncoes = new BLL_CargosFuncoes(cx);
                    ModeloCargosFuncoes modelo_CargosFuncoes = bll_CargosFuncoes.carregaModeloCargosFuncoes(Convert.ToInt32(bte_FuncaoFuncionario.Text));
                    bte_FuncaoFuncionario.TextBox.Text = modelo_CargosFuncoes.Codigo.ToString();
                    txb_DescricaoFuncaoFuncionario.Text = modelo_CargosFuncoes.Descricao;
                    chb_FuncaoCobrador.Checked = Convert.ToBoolean(modelo_CargosFuncoes.Cobrador);
                    chb_FuncaoMotorista.Checked = Convert.ToBoolean(modelo_CargosFuncoes.Motorista);
                    chb_FuncaoOutros.Checked = Convert.ToBoolean(modelo_CargosFuncoes.Outros);
                    chb_FuncaoSupervisor.Checked = Convert.ToBoolean(modelo_CargosFuncoes.Supervisor);
                    chb_FuncaoTecnico.Checked = Convert.ToBoolean(modelo_CargosFuncoes.Tecnico);
                    chb_FuncaoVendedor.Checked = Convert.ToBoolean(modelo_CargosFuncoes.Vendedor);
                }
                else
                {
                    limpa_Campos();
                    altera_Botoes(1);
                }
            }
        }

        private void cbx_PesquisarFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_PesquisarFuncionario.SelectedIndex == 2)
            {
                txb_PesquisaFuncionario.Visible = false;
                txb_PesquisaFuncionario.Clear();
                mtb_PesquisaFuncionario.Visible = true;
                mtb_PesquisaFuncionario.Mask = "999,999,999-99";
                mtb_PesquisaFuncionario.TabIndex = 2;
            }
            else
            {
                txb_PesquisaFuncionario.Visible = true;
                mtb_PesquisaFuncionario.Visible = false;
                mtb_PesquisaFuncionario.Clear();
                txb_PesquisaFuncionario.TabIndex = 2;
            }
        }

        private void btn_CodIBGEFuncionario_Click(object sender, EventArgs e)
        {
            frm_ConsultaRapida frmConsultaRapida = new frm_ConsultaRapida("municipio");
            frmConsultaRapida.ShowDialog();

            if (frmConsultaRapida.codigo != 0)
            {
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_TabMunicipio bll = new BLL_TabMunicipio(cx);
                ModeloTabMunicipio modelo = bll.carregaModeloMunicipio(frmConsultaRapida.codigo);
                bte_CodIBGEFuncionario.TextBox.Text = modelo.Codigo.ToString();
                txb_CidadeFuncionario.Text = modelo.Nome;
                txb_UFFuncionario.Text = modelo.SiglaUF;
            }
            frmConsultaRapida.Dispose();
        }

        private void btn_FilialFuncionario_Click(object sender, EventArgs e)
        {
            frm_ConsultaRapida frmConsultaRapida = new frm_ConsultaRapida("empresa");
            frmConsultaRapida.ShowDialog();

            if (frmConsultaRapida.codigo != 0)
            {
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_Empresa bll = new BLL_Empresa(cx);
                ModeloEmpresa modelo = bll.carregaModeloEmpresa(frmConsultaRapida.codigo);
                bte_FilialFuncionario.TextBox.Text = modelo.Codigo.ToString();
                txb_SiglaFilialFuncionario.Text = modelo.Sigla;
            }
            frmConsultaRapida.Dispose();
        }

        private void btn_FuncaoFuncionario_Click(object sender, EventArgs e)
        {
            frm_ConsultaRapida frmConsultaRapida = new frm_ConsultaRapida("cargosFuncoes");
            frmConsultaRapida.ShowDialog();

            if (frmConsultaRapida.codigo != 0)
            {
                cx = new DAOConfiguraConexaoPostgres(DadosConexaoPostgres.StringDeConexaoPostgres);
                BLL_CargosFuncoes bll = new BLL_CargosFuncoes(cx);
                ModeloCargosFuncoes modelo = bll.carregaModeloCargosFuncoes(frmConsultaRapida.codigo);
                bte_FuncaoFuncionario.TextBox.Text = modelo.Codigo.ToString();
                txb_DescricaoFuncaoFuncionario.Text = modelo.Descricao;
                chb_FuncaoCobrador.Checked = Convert.ToBoolean(modelo.Cobrador);
                chb_FuncaoMotorista.Checked = Convert.ToBoolean(modelo.Motorista);
                chb_FuncaoOutros.Checked = Convert.ToBoolean(modelo.Outros);
                chb_FuncaoSupervisor.Checked = Convert.ToBoolean(modelo.Supervisor);
                chb_FuncaoTecnico.Checked = Convert.ToBoolean(modelo.Tecnico);
                chb_FuncaoVendedor.Checked = Convert.ToBoolean(modelo.Vendedor);
            }
            frmConsultaRapida.Dispose();
        }

        private void btn_ImprimirFuncionario_Click(object sender, EventArgs e)
        {
            //report1.Show();
            //printDialog1.ShowDialog();
        }
        
    }
}
