namespace GUI
{
    partial class frm_CadastroCentroCusto
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
            this.dgv_CadastroCentroCustos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txb_PesquisaCentroCustos = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbx_PesquisarCentroCustos = new System.Windows.Forms.ComboBox();
            this.btn_PesquisarCentroCustos = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txb_DescricaoCentroCustos = new System.Windows.Forms.TextBox();
            this.txb_CodigoCentroCustos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_ImprimirCentroCustos = new System.Windows.Forms.Button();
            this.btn_ExcluirCentroCustos = new System.Windows.Forms.Button();
            this.btn_AlterarCentroCustos = new System.Windows.Forms.Button();
            this.btn_GravarCentroCustos = new System.Windows.Forms.Button();
            this.btn_NovoCentroCustos = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CadastroCentroCustos)).BeginInit();
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
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_CadastroCentroCustos);
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
            // dgv_CadastroCentroCustos
            // 
            this.dgv_CadastroCentroCustos.AllowUserToAddRows = false;
            this.dgv_CadastroCentroCustos.AllowUserToDeleteRows = false;
            this.dgv_CadastroCentroCustos.AllowUserToOrderColumns = true;
            this.dgv_CadastroCentroCustos.AllowUserToResizeColumns = false;
            this.dgv_CadastroCentroCustos.AllowUserToResizeRows = false;
            this.dgv_CadastroCentroCustos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CadastroCentroCustos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_CadastroCentroCustos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CadastroCentroCustos.Location = new System.Drawing.Point(7, 80);
            this.dgv_CadastroCentroCustos.Name = "dgv_CadastroCentroCustos";
            this.dgv_CadastroCentroCustos.ReadOnly = true;
            this.dgv_CadastroCentroCustos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_CadastroCentroCustos.RowTemplate.Height = 24;
            this.dgv_CadastroCentroCustos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_CadastroCentroCustos.Size = new System.Drawing.Size(1227, 585);
            this.dgv_CadastroCentroCustos.StandardTab = true;
            this.dgv_CadastroCentroCustos.TabIndex = 0;
            this.dgv_CadastroCentroCustos.TabStop = false;
            this.dgv_CadastroCentroCustos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CadastroCentroCustos_CellDoubleClick);
            this.dgv_CadastroCentroCustos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CadastroCentroCustos_RowEnter);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.txb_PesquisaCentroCustos);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cbx_PesquisarCentroCustos);
            this.panel2.Controls.Add(this.btn_PesquisarCentroCustos);
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
            // txb_PesquisaCentroCustos
            // 
            this.txb_PesquisaCentroCustos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_PesquisaCentroCustos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_PesquisaCentroCustos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_PesquisaCentroCustos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txb_PesquisaCentroCustos.Location = new System.Drawing.Point(189, 30);
            this.txb_PesquisaCentroCustos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_PesquisaCentroCustos.Name = "txb_PesquisaCentroCustos";
            this.txb_PesquisaCentroCustos.Size = new System.Drawing.Size(976, 27);
            this.txb_PesquisaCentroCustos.TabIndex = 2;
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
            // cbx_PesquisarCentroCustos
            // 
            this.cbx_PesquisarCentroCustos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_PesquisarCentroCustos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_PesquisarCentroCustos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbx_PesquisarCentroCustos.FormattingEnabled = true;
            this.cbx_PesquisarCentroCustos.Items.AddRange(new object[] {
            "Nome",
            "Código"});
            this.cbx_PesquisarCentroCustos.Location = new System.Drawing.Point(3, 29);
            this.cbx_PesquisarCentroCustos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_PesquisarCentroCustos.Name = "cbx_PesquisarCentroCustos";
            this.cbx_PesquisarCentroCustos.Size = new System.Drawing.Size(163, 28);
            this.cbx_PesquisarCentroCustos.TabIndex = 1;
            // 
            // btn_PesquisarCentroCustos
            // 
            this.btn_PesquisarCentroCustos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PesquisarCentroCustos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PesquisarCentroCustos.Location = new System.Drawing.Point(1165, 28);
            this.btn_PesquisarCentroCustos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_PesquisarCentroCustos.Name = "btn_PesquisarCentroCustos";
            this.btn_PesquisarCentroCustos.Size = new System.Drawing.Size(57, 31);
            this.btn_PesquisarCentroCustos.TabIndex = 3;
            this.btn_PesquisarCentroCustos.Text = "Ir";
            this.btn_PesquisarCentroCustos.UseCompatibleTextRendering = true;
            this.btn_PesquisarCentroCustos.UseVisualStyleBackColor = true;
            this.btn_PesquisarCentroCustos.Click += new System.EventHandler(this.btn_PesquisarCentroCustos_Click);
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
            this.panel3.Controls.Add(this.txb_DescricaoCentroCustos);
            this.panel3.Controls.Add(this.txb_CodigoCentroCustos);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(7, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1221, 656);
            this.panel3.TabIndex = 0;
            // 
            // txb_DescricaoCentroCustos
            // 
            this.txb_DescricaoCentroCustos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_DescricaoCentroCustos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_DescricaoCentroCustos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txb_DescricaoCentroCustos.Location = new System.Drawing.Point(24, 107);
            this.txb_DescricaoCentroCustos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_DescricaoCentroCustos.Name = "txb_DescricaoCentroCustos";
            this.txb_DescricaoCentroCustos.Size = new System.Drawing.Size(931, 27);
            this.txb_DescricaoCentroCustos.TabIndex = 5;
            // 
            // txb_CodigoCentroCustos
            // 
            this.txb_CodigoCentroCustos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txb_CodigoCentroCustos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_CodigoCentroCustos.ForeColor = System.Drawing.Color.Red;
            this.txb_CodigoCentroCustos.Location = new System.Drawing.Point(26, 45);
            this.txb_CodigoCentroCustos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_CodigoCentroCustos.Name = "txb_CodigoCentroCustos";
            this.txb_CodigoCentroCustos.ReadOnly = true;
            this.txb_CodigoCentroCustos.Size = new System.Drawing.Size(100, 27);
            this.txb_CodigoCentroCustos.TabIndex = 16;
            this.txb_CodigoCentroCustos.TabStop = false;
            this.txb_CodigoCentroCustos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Descrição";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Código";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.btn_ImprimirCentroCustos);
            this.panel1.Controls.Add(this.btn_ExcluirCentroCustos);
            this.panel1.Controls.Add(this.btn_AlterarCentroCustos);
            this.panel1.Controls.Add(this.btn_GravarCentroCustos);
            this.panel1.Controls.Add(this.btn_NovoCentroCustos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 48);
            this.panel1.TabIndex = 4;
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
            // btn_ImprimirCentroCustos
            // 
            this.btn_ImprimirCentroCustos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ImprimirCentroCustos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImprimirCentroCustos.Location = new System.Drawing.Point(422, 9);
            this.btn_ImprimirCentroCustos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ImprimirCentroCustos.Name = "btn_ImprimirCentroCustos";
            this.btn_ImprimirCentroCustos.Size = new System.Drawing.Size(97, 31);
            this.btn_ImprimirCentroCustos.TabIndex = 20;
            this.btn_ImprimirCentroCustos.Text = "Imprimir";
            this.btn_ImprimirCentroCustos.UseCompatibleTextRendering = true;
            this.btn_ImprimirCentroCustos.UseVisualStyleBackColor = true;
            // 
            // btn_ExcluirCentroCustos
            // 
            this.btn_ExcluirCentroCustos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ExcluirCentroCustos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExcluirCentroCustos.Location = new System.Drawing.Point(320, 9);
            this.btn_ExcluirCentroCustos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ExcluirCentroCustos.Name = "btn_ExcluirCentroCustos";
            this.btn_ExcluirCentroCustos.Size = new System.Drawing.Size(97, 31);
            this.btn_ExcluirCentroCustos.TabIndex = 19;
            this.btn_ExcluirCentroCustos.Text = "Excluir";
            this.btn_ExcluirCentroCustos.UseCompatibleTextRendering = true;
            this.btn_ExcluirCentroCustos.UseVisualStyleBackColor = true;
            this.btn_ExcluirCentroCustos.Click += new System.EventHandler(this.btn_ExcluirCentroCustos_Click);
            // 
            // btn_AlterarCentroCustos
            // 
            this.btn_AlterarCentroCustos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_AlterarCentroCustos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AlterarCentroCustos.Location = new System.Drawing.Point(216, 9);
            this.btn_AlterarCentroCustos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AlterarCentroCustos.Name = "btn_AlterarCentroCustos";
            this.btn_AlterarCentroCustos.Size = new System.Drawing.Size(97, 31);
            this.btn_AlterarCentroCustos.TabIndex = 18;
            this.btn_AlterarCentroCustos.Text = "Alterar";
            this.btn_AlterarCentroCustos.UseCompatibleTextRendering = true;
            this.btn_AlterarCentroCustos.UseVisualStyleBackColor = true;
            this.btn_AlterarCentroCustos.Click += new System.EventHandler(this.btn_AlterarCentroCustos_Click);
            // 
            // btn_GravarCentroCustos
            // 
            this.btn_GravarCentroCustos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_GravarCentroCustos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GravarCentroCustos.Location = new System.Drawing.Point(113, 9);
            this.btn_GravarCentroCustos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GravarCentroCustos.Name = "btn_GravarCentroCustos";
            this.btn_GravarCentroCustos.Size = new System.Drawing.Size(97, 31);
            this.btn_GravarCentroCustos.TabIndex = 17;
            this.btn_GravarCentroCustos.Text = "Gravar";
            this.btn_GravarCentroCustos.UseCompatibleTextRendering = true;
            this.btn_GravarCentroCustos.UseVisualStyleBackColor = true;
            this.btn_GravarCentroCustos.Click += new System.EventHandler(this.btn_GravarCentroCustos_Click);
            // 
            // btn_NovoCentroCustos
            // 
            this.btn_NovoCentroCustos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_NovoCentroCustos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NovoCentroCustos.Location = new System.Drawing.Point(10, 9);
            this.btn_NovoCentroCustos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NovoCentroCustos.Name = "btn_NovoCentroCustos";
            this.btn_NovoCentroCustos.Size = new System.Drawing.Size(97, 31);
            this.btn_NovoCentroCustos.TabIndex = 4;
            this.btn_NovoCentroCustos.Text = "Novo";
            this.btn_NovoCentroCustos.UseCompatibleTextRendering = true;
            this.btn_NovoCentroCustos.UseVisualStyleBackColor = true;
            this.btn_NovoCentroCustos.Click += new System.EventHandler(this.btn_NovoCentroCustos_Click);
            // 
            // frm_CadastroCentroCusto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 750);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CadastroCentroCusto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_CadastroCentroCusto";
            this.Load += new System.EventHandler(this.frm_CadastroCentroCusto_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CadastroCentroCustos)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_CadastroCentroCustos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txb_PesquisaCentroCustos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbx_PesquisarCentroCustos;
        private System.Windows.Forms.Button btn_PesquisarCentroCustos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txb_DescricaoCentroCustos;
        private System.Windows.Forms.TextBox txb_CodigoCentroCustos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_ImprimirCentroCustos;
        private System.Windows.Forms.Button btn_ExcluirCentroCustos;
        private System.Windows.Forms.Button btn_AlterarCentroCustos;
        private System.Windows.Forms.Button btn_GravarCentroCustos;
        private System.Windows.Forms.Button btn_NovoCentroCustos;
    }
}