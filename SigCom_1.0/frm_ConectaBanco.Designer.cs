namespace GUI
{
    partial class frm_ConectaBanco
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
            this.txt_NomeBanco = new System.Windows.Forms.TextBox();
            this.txt_EnderecoServidor = new System.Windows.Forms.TextBox();
            this.txt_UsuarioBanco = new System.Windows.Forms.TextBox();
            this.txt_SenhaBanco = new System.Windows.Forms.TextBox();
            this.txt_PortaBanco = new System.Windows.Forms.TextBox();
            this.btn_TestarConexao = new System.Windows.Forms.Button();
            this.btn_GravarConexao = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ttp_BalaoAjuda = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txt_NomeBanco
            // 
            this.txt_NomeBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomeBanco.Location = new System.Drawing.Point(181, 12);
            this.txt_NomeBanco.MaxLength = 30;
            this.txt_NomeBanco.Name = "txt_NomeBanco";
            this.txt_NomeBanco.Size = new System.Drawing.Size(162, 24);
            this.txt_NomeBanco.TabIndex = 0;
            // 
            // txt_EnderecoServidor
            // 
            this.txt_EnderecoServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EnderecoServidor.Location = new System.Drawing.Point(181, 42);
            this.txt_EnderecoServidor.MaxLength = 30;
            this.txt_EnderecoServidor.Name = "txt_EnderecoServidor";
            this.txt_EnderecoServidor.Size = new System.Drawing.Size(162, 24);
            this.txt_EnderecoServidor.TabIndex = 1;
            // 
            // txt_UsuarioBanco
            // 
            this.txt_UsuarioBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UsuarioBanco.Location = new System.Drawing.Point(181, 72);
            this.txt_UsuarioBanco.MaxLength = 30;
            this.txt_UsuarioBanco.Name = "txt_UsuarioBanco";
            this.txt_UsuarioBanco.Size = new System.Drawing.Size(162, 24);
            this.txt_UsuarioBanco.TabIndex = 2;
            // 
            // txt_SenhaBanco
            // 
            this.txt_SenhaBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SenhaBanco.Location = new System.Drawing.Point(181, 102);
            this.txt_SenhaBanco.MaxLength = 30;
            this.txt_SenhaBanco.Name = "txt_SenhaBanco";
            this.txt_SenhaBanco.Size = new System.Drawing.Size(162, 24);
            this.txt_SenhaBanco.TabIndex = 3;
            this.txt_SenhaBanco.UseSystemPasswordChar = true;
            // 
            // txt_PortaBanco
            // 
            this.txt_PortaBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PortaBanco.Location = new System.Drawing.Point(181, 132);
            this.txt_PortaBanco.MaxLength = 6;
            this.txt_PortaBanco.Name = "txt_PortaBanco";
            this.txt_PortaBanco.Size = new System.Drawing.Size(93, 24);
            this.txt_PortaBanco.TabIndex = 4;
            // 
            // btn_TestarConexao
            // 
            this.btn_TestarConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TestarConexao.Location = new System.Drawing.Point(355, 12);
            this.btn_TestarConexao.Name = "btn_TestarConexao";
            this.btn_TestarConexao.Size = new System.Drawing.Size(229, 44);
            this.btn_TestarConexao.TabIndex = 5;
            this.btn_TestarConexao.Text = "Testar Conexão <Ctrl+T>";
            this.btn_TestarConexao.UseCompatibleTextRendering = true;
            this.btn_TestarConexao.UseVisualStyleBackColor = true;
            // 
            // btn_GravarConexao
            // 
            this.btn_GravarConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GravarConexao.Location = new System.Drawing.Point(355, 62);
            this.btn_GravarConexao.Name = "btn_GravarConexao";
            this.btn_GravarConexao.Size = new System.Drawing.Size(229, 44);
            this.btn_GravarConexao.TabIndex = 6;
            this.btn_GravarConexao.Text = "Gravar/Continuar <Ctrl+S>";
            this.btn_GravarConexao.UseCompatibleTextRendering = true;
            this.btn_GravarConexao.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(355, 110);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(229, 44);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancelar <Esc>";
            this.btn_Cancelar.UseCompatibleTextRendering = true;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome do Banco ....:";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Local do Servidor ..:";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Usuário do Banco .:";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Senha do Banco ....:";
            this.label4.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Porta .....................:";
            this.label5.UseCompatibleTextRendering = true;
            // 
            // ttp_BalaoAjuda
            // 
            this.ttp_BalaoAjuda.IsBalloon = true;
            // 
            // frm_ConectaBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 168);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_GravarConexao);
            this.Controls.Add(this.btn_TestarConexao);
            this.Controls.Add(this.txt_PortaBanco);
            this.Controls.Add(this.txt_SenhaBanco);
            this.Controls.Add(this.txt_UsuarioBanco);
            this.Controls.Add(this.txt_EnderecoServidor);
            this.Controls.Add(this.txt_NomeBanco);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ConectaBanco";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração de Conexão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NomeBanco;
        private System.Windows.Forms.TextBox txt_EnderecoServidor;
        private System.Windows.Forms.TextBox txt_UsuarioBanco;
        private System.Windows.Forms.TextBox txt_SenhaBanco;
        private System.Windows.Forms.TextBox txt_PortaBanco;
        private System.Windows.Forms.Button btn_TestarConexao;
        private System.Windows.Forms.Button btn_GravarConexao;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip ttp_BalaoAjuda;
    }
}