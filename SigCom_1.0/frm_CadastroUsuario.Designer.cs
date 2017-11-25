namespace SigCom_1._0
{
    partial class frm_CadastroUsuario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label c_codigoLabel;
            System.Windows.Forms.Label c_nomeLabel;
            System.Windows.Forms.Label c_senhaLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.a_usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sigcomDataSet = new SigCom_1._0.sigcomDataSet();
            this.a_usuarioTableAdapter = new SigCom_1._0.sigcomDataSetTableAdapters.a_usuarioTableAdapter();
            this.tableAdapterManager = new SigCom_1._0.sigcomDataSetTableAdapters.TableAdapterManager();
            this.c_codigoTextBox = new System.Windows.Forms.TextBox();
            this.c_nomeTextBox = new System.Windows.Forms.TextBox();
            this.c_senhaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            c_codigoLabel = new System.Windows.Forms.Label();
            c_nomeLabel = new System.Windows.Forms.Label();
            c_senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.a_usuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a_usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigcomDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.button5);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(c_senhaLabel);
            this.splitContainer1.Panel1.Controls.Add(this.c_senhaTextBox);
            this.splitContainer1.Panel1.Controls.Add(c_nomeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.c_nomeTextBox);
            this.splitContainer1.Panel1.Controls.Add(c_codigoLabel);
            this.splitContainer1.Panel1.Controls.Add(this.c_codigoTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.a_usuarioDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1232, 768);
            this.splitContainer1.SplitterDistance = 254;
            this.splitContainer1.TabIndex = 0;
            // 
            // a_usuarioDataGridView
            // 
            this.a_usuarioDataGridView.AllowUserToAddRows = false;
            this.a_usuarioDataGridView.AllowUserToDeleteRows = false;
            this.a_usuarioDataGridView.AllowUserToResizeColumns = false;
            this.a_usuarioDataGridView.AllowUserToResizeRows = false;
            this.a_usuarioDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.a_usuarioDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.a_usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.a_usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.a_usuarioDataGridView.DataSource = this.a_usuarioBindingSource;
            this.a_usuarioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.a_usuarioDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.a_usuarioDataGridView.Location = new System.Drawing.Point(0, 0);
            this.a_usuarioDataGridView.MultiSelect = false;
            this.a_usuarioDataGridView.Name = "a_usuarioDataGridView";
            this.a_usuarioDataGridView.ReadOnly = true;
            this.a_usuarioDataGridView.RowTemplate.Height = 24;
            this.a_usuarioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.a_usuarioDataGridView.ShowEditingIcon = false;
            this.a_usuarioDataGridView.Size = new System.Drawing.Size(1232, 510);
            this.a_usuarioDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "c_codigo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.ToolTipText = "00";
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "c_nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Usuário";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // a_usuarioBindingSource
            // 
            this.a_usuarioBindingSource.DataMember = "a_usuario";
            this.a_usuarioBindingSource.DataSource = this.sigcomDataSet;
            // 
            // sigcomDataSet
            // 
            this.sigcomDataSet.DataSetName = "sigcomDataSet";
            this.sigcomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // a_usuarioTableAdapter
            // 
            this.a_usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.a_usuarioTableAdapter = this.a_usuarioTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = SigCom_1._0.sigcomDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // c_codigoLabel
            // 
            c_codigoLabel.AutoSize = true;
            c_codigoLabel.Location = new System.Drawing.Point(23, 63);
            c_codigoLabel.Name = "c_codigoLabel";
            c_codigoLabel.Size = new System.Drawing.Size(65, 17);
            c_codigoLabel.TabIndex = 0;
            c_codigoLabel.Text = "c codigo:";
            // 
            // c_codigoTextBox
            // 
            this.c_codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.a_usuarioBindingSource, "c_codigo", true));
            this.c_codigoTextBox.Location = new System.Drawing.Point(94, 60);
            this.c_codigoTextBox.Name = "c_codigoTextBox";
            this.c_codigoTextBox.Size = new System.Drawing.Size(100, 22);
            this.c_codigoTextBox.TabIndex = 1;
            // 
            // c_nomeLabel
            // 
            c_nomeLabel.AutoSize = true;
            c_nomeLabel.Location = new System.Drawing.Point(30, 106);
            c_nomeLabel.Name = "c_nomeLabel";
            c_nomeLabel.Size = new System.Drawing.Size(58, 17);
            c_nomeLabel.TabIndex = 2;
            c_nomeLabel.Text = "c nome:";
            // 
            // c_nomeTextBox
            // 
            this.c_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.a_usuarioBindingSource, "c_nome", true));
            this.c_nomeTextBox.Location = new System.Drawing.Point(94, 103);
            this.c_nomeTextBox.Name = "c_nomeTextBox";
            this.c_nomeTextBox.Size = new System.Drawing.Size(100, 22);
            this.c_nomeTextBox.TabIndex = 3;
            // 
            // c_senhaLabel
            // 
            c_senhaLabel.AutoSize = true;
            c_senhaLabel.Location = new System.Drawing.Point(303, 67);
            c_senhaLabel.Name = "c_senhaLabel";
            c_senhaLabel.Size = new System.Drawing.Size(62, 17);
            c_senhaLabel.TabIndex = 4;
            c_senhaLabel.Text = "c senha:";
            // 
            // c_senhaTextBox
            // 
            this.c_senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.a_usuarioBindingSource, "c_senha", true));
            this.c_senhaTextBox.Location = new System.Drawing.Point(371, 64);
            this.c_senhaTextBox.Name = "c_senhaTextBox";
            this.c_senhaTextBox.Size = new System.Drawing.Size(100, 22);
            this.c_senhaTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(176, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(258, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(340, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // frm_CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 768);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CadastroUsuario";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_CadastroUsuario";
            this.Load += new System.EventHandler(this.frm_CadastroUsuario_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.a_usuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a_usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigcomDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private sigcomDataSet sigcomDataSet;
        private System.Windows.Forms.BindingSource a_usuarioBindingSource;
        private sigcomDataSetTableAdapters.a_usuarioTableAdapter a_usuarioTableAdapter;
        private sigcomDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView a_usuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox c_senhaTextBox;
        private System.Windows.Forms.TextBox c_nomeTextBox;
        private System.Windows.Forms.TextBox c_codigoTextBox;
    }
}