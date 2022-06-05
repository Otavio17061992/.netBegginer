namespace Academia.DotNet.ProjetoExemplo.WindownsForms.UI
{
    partial class FFormularioInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomeFornecedor = new System.Windows.Forms.Label();
            this.txtNomeFornecedor = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NomeDoContato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.TextBox();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeFornecedor
            // 
            this.lblNomeFornecedor.AutoSize = true;
            this.lblNomeFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFornecedor.Location = new System.Drawing.Point(12, 28);
            this.lblNomeFornecedor.Name = "lblNomeFornecedor";
            this.lblNomeFornecedor.Size = new System.Drawing.Size(122, 13);
            this.lblNomeFornecedor.TabIndex = 1;
            this.lblNomeFornecedor.Text = "Nome do fornecedor";
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(15, 44);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(236, 20);
            this.txtNomeFornecedor.TabIndex = 2;
            this.txtNomeFornecedor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(12, 77);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(61, 13);
            this.lblEndereco.TabIndex = 1;
            this.lblEndereco.Text = "Endereço";
            this.lblEndereco.Click += new System.EventHandler(this.lblEndereco_Click);
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(15, 93);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(361, 20);
            this.textEndereco.TabIndex = 2;
            this.textEndereco.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Contato";
            this.label1.Click += new System.EventHandler(this.lblEndereco_Click);
            // 
            // NomeDoContato
            // 
            this.NomeDoContato.Location = new System.Drawing.Point(15, 143);
            this.NomeDoContato.Name = "NomeDoContato";
            this.NomeDoContato.Size = new System.Drawing.Size(176, 20);
            this.NomeDoContato.TabIndex = 2;
            this.NomeDoContato.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone";
            this.label2.Click += new System.EventHandler(this.lblEndereco_Click);
            // 
            // Telefone
            // 
            this.Telefone.Location = new System.Drawing.Point(15, 196);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(176, 20);
            this.Telefone.TabIndex = 2;
            this.Telefone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Location = new System.Drawing.Point(15, 232);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(236, 44);
            this.botaoSalvar.TabIndex = 3;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.UseVisualStyleBackColor = true;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedores.Location = new System.Drawing.Point(15, 285);
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.Size = new System.Drawing.Size(625, 150);
            this.dgvFornecedores.TabIndex = 4;
            // 
            // FFormularioInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(652, 447);
            this.Controls.Add(this.dgvFornecedores);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.NomeDoContato);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.txtNomeFornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNomeFornecedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FFormularioInicial";
            this.Text = "Tela de Cadastro de Fonercedor";
            this.Load += new System.EventHandler(this.FFormularioInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFornecedor;
        private System.Windows.Forms.TextBox txtNomeFornecedor;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomeDoContato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Telefone;
        private System.Windows.Forms.Button botaoSalvar;
        private System.Windows.Forms.DataGridView dgvFornecedores;
    }
}

