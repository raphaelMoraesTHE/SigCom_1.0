namespace GUI
{
    partial class frm_CadastroDocumentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_CadastroDocumento = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txb_PesquisaDocumento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbx_PesquisarDocumento = new System.Windows.Forms.ComboBox();
            this.btn_PesquisarDocumento = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chb_AtivoInativoDocumento = new System.Windows.Forms.CheckBox();
            this.chb_BaixaOrdVencDocumento = new System.Windows.Forms.CheckBox();
            this.txb_DescricaoTipoDocumento = new System.Windows.Forms.TextBox();
            this.txb_CodigoDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_ImprimirDocumento = new System.Windows.Forms.Button();
            this.btn_ExcluirDocumento = new System.Windows.Forms.Button();
            this.btn_AlterarDocumento = new System.Windows.Forms.Button();
            this.btn_GravarDocumento = new System.Windows.Forms.Button();
            this.btn_NovoDocumento = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CadastroDocumento)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1248, 702);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_CadastroDocumento);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1240, 671);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Localizar (1)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_CadastroDocumento
            // 
            this.dgv_CadastroDocumento.AllowUserToAddRows = false;
            this.dgv_CadastroDocumento.AllowUserToDeleteRows = false;
            this.dgv_CadastroDocumento.AllowUserToOrderColumns = true;
            this.dgv_CadastroDocumento.AllowUserToResizeColumns = false;
            this.dgv_CadastroDocumento.AllowUserToResizeRows = false;
            this.dgv_CadastroDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CadastroDocumento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_CadastroDocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CadastroDocumento.Location = new System.Drawing.Point(7, 80);
            this.dgv_CadastroDocumento.Name = "dgv_CadastroDocumento";
            this.dgv_CadastroDocumento.ReadOnly = true;
            this.dgv_CadastroDocumento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_CadastroDocumento.RowTemplate.Height = 24;
            this.dgv_CadastroDocumento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_CadastroDocumento.Size = new System.Drawing.Size(1227, 585);
            this.dgv_CadastroDocumento.StandardTab = true;
            this.dgv_CadastroDocumento.TabIndex = 0;
            this.dgv_CadastroDocumento.TabStop = false;
            this.dgv_CadastroDocumento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CadastroDocumento_CellDoubleClick);
            this.dgv_CadastroDocumento.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CadastroDocumento_RowEnter);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txb_PesquisaDocumento);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cbx_PesquisarDocumento);
            this.panel2.Controls.Add(this.btn_PesquisarDocumento);
            this.panel2.Location = new System.Drawing.Point(7, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1227, 66);
            this.panel2.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 25);
            this.label12.TabIndex = 44;
            this.label12.Text = "Pesquisar Por";
            this.label12.UseCompatibleTextRendering = true;
            // 
            // txb_PesquisaDocumento
            // 
            this.txb_PesquisaDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_PesquisaDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_PesquisaDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_PesquisaDocumento.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txb_PesquisaDocumento.Location = new System.Drawing.Point(189, 30);
            this.txb_PesquisaDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_PesquisaDocumento.Name = "txb_PesquisaDocumento";
            this.txb_PesquisaDocumento.Size = new System.Drawing.Size(976, 27);
            this.txb_PesquisaDocumento.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(189, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 25);
            this.label13.TabIndex = 45;
            this.label13.Text = "Digite Aqui";
            this.label13.UseCompatibleTextRendering = true;
            // 
            // cbx_PesquisarDocumento
            // 
            this.cbx_PesquisarDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_PesquisarDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_PesquisarDocumento.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbx_PesquisarDocumento.FormattingEnabled = true;
            this.cbx_PesquisarDocumento.Items.AddRange(new object[] {
            "Nome",
            "Código"});
            this.cbx_PesquisarDocumento.Location = new System.Drawing.Point(3, 29);
            this.cbx_PesquisarDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_PesquisarDocumento.Name = "cbx_PesquisarDocumento";
            this.cbx_PesquisarDocumento.Size = new System.Drawing.Size(163, 28);
            this.cbx_PesquisarDocumento.TabIndex = 1;
            // 
            // btn_PesquisarDocumento
            // 
            this.btn_PesquisarDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PesquisarDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PesquisarDocumento.Location = new System.Drawing.Point(1165, 28);
            this.btn_PesquisarDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_PesquisarDocumento.Name = "btn_PesquisarDocumento";
            this.btn_PesquisarDocumento.Size = new System.Drawing.Size(57, 31);
            this.btn_PesquisarDocumento.TabIndex = 3;
            this.btn_PesquisarDocumento.Text = "Ir";
            this.btn_PesquisarDocumento.UseCompatibleTextRendering = true;
            this.btn_PesquisarDocumento.UseVisualStyleBackColor = true;
            this.btn_PesquisarDocumento.Click += new System.EventHandler(this.btn_PesquisarDocumento_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1240, 671);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastro (2)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.chb_AtivoInativoDocumento);
            this.panel3.Controls.Add(this.chb_BaixaOrdVencDocumento);
            this.panel3.Controls.Add(this.txb_DescricaoTipoDocumento);
            this.panel3.Controls.Add(this.txb_CodigoDocumento);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(7, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1221, 656);
            this.panel3.TabIndex = 0;
            // 
            // chb_AtivoInativoDocumento
            // 
            this.chb_AtivoInativoDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chb_AtivoInativoDocumento.AutoSize = true;
            this.chb_AtivoInativoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_AtivoInativoDocumento.Location = new System.Drawing.Point(36, 197);
            this.chb_AtivoInativoDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chb_AtivoInativoDocumento.Name = "chb_AtivoInativoDocumento";
            this.chb_AtivoInativoDocumento.Size = new System.Drawing.Size(86, 24);
            this.chb_AtivoInativoDocumento.TabIndex = 16;
            this.chb_AtivoInativoDocumento.Text = "Inativo";
            this.chb_AtivoInativoDocumento.UseVisualStyleBackColor = true;
            // 
            // chb_BaixaOrdVencDocumento
            // 
            this.chb_BaixaOrdVencDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chb_BaixaOrdVencDocumento.AutoSize = true;
            this.chb_BaixaOrdVencDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_BaixaOrdVencDocumento.Location = new System.Drawing.Point(36, 169);
            this.chb_BaixaOrdVencDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chb_BaixaOrdVencDocumento.Name = "chb_BaixaOrdVencDocumento";
            this.chb_BaixaOrdVencDocumento.Size = new System.Drawing.Size(472, 24);
            this.chb_BaixaOrdVencDocumento.TabIndex = 13;
            this.chb_BaixaOrdVencDocumento.Text = "Baixa em Ordem de Vencimento (Contas a Receber)";
            this.chb_BaixaOrdVencDocumento.UseVisualStyleBackColor = true;
            // 
            // txb_DescricaoTipoDocumento
            // 
            this.txb_DescricaoTipoDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_DescricaoTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_DescricaoTipoDocumento.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txb_DescricaoTipoDocumento.Location = new System.Drawing.Point(36, 114);
            this.txb_DescricaoTipoDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_DescricaoTipoDocumento.Name = "txb_DescricaoTipoDocumento";
            this.txb_DescricaoTipoDocumento.Size = new System.Drawing.Size(583, 27);
            this.txb_DescricaoTipoDocumento.TabIndex = 5;
            // 
            // txb_CodigoDocumento
            // 
            this.txb_CodigoDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_CodigoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CodigoDocumento.ForeColor = System.Drawing.Color.Red;
            this.txb_CodigoDocumento.Location = new System.Drawing.Point(34, 48);
            this.txb_CodigoDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_CodigoDocumento.Name = "txb_CodigoDocumento";
            this.txb_CodigoDocumento.ReadOnly = true;
            this.txb_CodigoDocumento.Size = new System.Drawing.Size(100, 27);
            this.txb_CodigoDocumento.TabIndex = 16;
            this.txb_CodigoDocumento.TabStop = false;
            this.txb_CodigoDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tipo de Documento";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Código";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.btn_ImprimirDocumento);
            this.panel1.Controls.Add(this.btn_ExcluirDocumento);
            this.panel1.Controls.Add(this.btn_AlterarDocumento);
            this.panel1.Controls.Add(this.btn_GravarDocumento);
            this.panel1.Controls.Add(this.btn_NovoDocumento);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 48);
            this.panel1.TabIndex = 6;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(1133, 9);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(103, 31);
            this.btn_Cancelar.TabIndex = 21;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseCompatibleTextRendering = true;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_ImprimirDocumento
            // 
            this.btn_ImprimirDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ImprimirDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImprimirDocumento.Location = new System.Drawing.Point(422, 9);
            this.btn_ImprimirDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ImprimirDocumento.Name = "btn_ImprimirDocumento";
            this.btn_ImprimirDocumento.Size = new System.Drawing.Size(97, 31);
            this.btn_ImprimirDocumento.TabIndex = 20;
            this.btn_ImprimirDocumento.Text = "Imprimir";
            this.btn_ImprimirDocumento.UseCompatibleTextRendering = true;
            this.btn_ImprimirDocumento.UseVisualStyleBackColor = true;
            // 
            // btn_ExcluirDocumento
            // 
            this.btn_ExcluirDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ExcluirDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExcluirDocumento.Location = new System.Drawing.Point(320, 9);
            this.btn_ExcluirDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ExcluirDocumento.Name = "btn_ExcluirDocumento";
            this.btn_ExcluirDocumento.Size = new System.Drawing.Size(97, 31);
            this.btn_ExcluirDocumento.TabIndex = 19;
            this.btn_ExcluirDocumento.Text = "Excluir";
            this.btn_ExcluirDocumento.UseCompatibleTextRendering = true;
            this.btn_ExcluirDocumento.UseVisualStyleBackColor = true;
            this.btn_ExcluirDocumento.Click += new System.EventHandler(this.btn_ExcluirDocumento_Click);
            // 
            // btn_AlterarDocumento
            // 
            this.btn_AlterarDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_AlterarDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AlterarDocumento.Location = new System.Drawing.Point(216, 9);
            this.btn_AlterarDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AlterarDocumento.Name = "btn_AlterarDocumento";
            this.btn_AlterarDocumento.Size = new System.Drawing.Size(97, 31);
            this.btn_AlterarDocumento.TabIndex = 18;
            this.btn_AlterarDocumento.Text = "Alterar";
            this.btn_AlterarDocumento.UseCompatibleTextRendering = true;
            this.btn_AlterarDocumento.UseVisualStyleBackColor = true;
            this.btn_AlterarDocumento.Click += new System.EventHandler(this.btn_AlterarDocumento_Click);
            // 
            // btn_GravarDocumento
            // 
            this.btn_GravarDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_GravarDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GravarDocumento.Location = new System.Drawing.Point(113, 9);
            this.btn_GravarDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GravarDocumento.Name = "btn_GravarDocumento";
            this.btn_GravarDocumento.Size = new System.Drawing.Size(97, 31);
            this.btn_GravarDocumento.TabIndex = 17;
            this.btn_GravarDocumento.Text = "Gravar";
            this.btn_GravarDocumento.UseCompatibleTextRendering = true;
            this.btn_GravarDocumento.UseVisualStyleBackColor = true;
            this.btn_GravarDocumento.Click += new System.EventHandler(this.btn_GravarDocumento_Click);
            // 
            // btn_NovoDocumento
            // 
            this.btn_NovoDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_NovoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NovoDocumento.Location = new System.Drawing.Point(10, 9);
            this.btn_NovoDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NovoDocumento.Name = "btn_NovoDocumento";
            this.btn_NovoDocumento.Size = new System.Drawing.Size(97, 31);
            this.btn_NovoDocumento.TabIndex = 4;
            this.btn_NovoDocumento.Text = "Novo";
            this.btn_NovoDocumento.UseCompatibleTextRendering = true;
            this.btn_NovoDocumento.UseVisualStyleBackColor = true;
            this.btn_NovoDocumento.Click += new System.EventHandler(this.btn_NovoDocumento_Click);
            // 
            // frm_CadastroDocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 750);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CadastroDocumentos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_CadastroDocumentos";
            this.Load += new System.EventHandler(this.frm_CadastroDocumentos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CadastroDocumento)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_CadastroDocumento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txb_PesquisaDocumento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbx_PesquisarDocumento;
        private System.Windows.Forms.Button btn_PesquisarDocumento;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chb_AtivoInativoDocumento;
        private System.Windows.Forms.CheckBox chb_BaixaOrdVencDocumento;
        private System.Windows.Forms.TextBox txb_DescricaoTipoDocumento;
        private System.Windows.Forms.TextBox txb_CodigoDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_ImprimirDocumento;
        private System.Windows.Forms.Button btn_ExcluirDocumento;
        private System.Windows.Forms.Button btn_AlterarDocumento;
        private System.Windows.Forms.Button btn_GravarDocumento;
        private System.Windows.Forms.Button btn_NovoDocumento;
    }
}