namespace keyproject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bdDataSet = new keyproject.bdDataSet();
            this.dadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dadosTableAdapter = new keyproject.bdDataSetTableAdapters.dadosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionarioDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iDAmbevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitanteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cPFCNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntregueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recebeuDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataRecebidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.funcionarioDataGridViewCheckBoxColumn,
            this.iDAmbevDataGridViewTextBoxColumn,
            this.visitanteDataGridViewCheckBoxColumn,
            this.cPFCNPJDataGridViewTextBoxColumn,
            this.razaoDataGridViewTextBoxColumn,
            this.chaveDataGridViewTextBoxColumn,
            this.dataEntregueDataGridViewTextBoxColumn,
            this.recebeuDataGridViewCheckBoxColumn,
            this.dataRecebidoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dadosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(722, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // bdDataSet
            // 
            this.bdDataSet.DataSetName = "bdDataSet";
            this.bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dadosBindingSource
            // 
            this.dadosBindingSource.DataMember = "dados";
            this.dadosBindingSource.DataSource = this.bdDataSet;
            // 
            // dadosTableAdapter
            // 
            this.dadosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(703, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 60;
            // 
            // funcionarioDataGridViewCheckBoxColumn
            // 
            this.funcionarioDataGridViewCheckBoxColumn.DataPropertyName = "Funcionario";
            this.funcionarioDataGridViewCheckBoxColumn.HeaderText = "Funcionario";
            this.funcionarioDataGridViewCheckBoxColumn.Name = "funcionarioDataGridViewCheckBoxColumn";
            this.funcionarioDataGridViewCheckBoxColumn.ReadOnly = true;
            this.funcionarioDataGridViewCheckBoxColumn.Width = 68;
            // 
            // iDAmbevDataGridViewTextBoxColumn
            // 
            this.iDAmbevDataGridViewTextBoxColumn.DataPropertyName = "ID Ambev";
            this.iDAmbevDataGridViewTextBoxColumn.HeaderText = "ID Ambev";
            this.iDAmbevDataGridViewTextBoxColumn.Name = "iDAmbevDataGridViewTextBoxColumn";
            this.iDAmbevDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDAmbevDataGridViewTextBoxColumn.Width = 73;
            // 
            // visitanteDataGridViewCheckBoxColumn
            // 
            this.visitanteDataGridViewCheckBoxColumn.DataPropertyName = "Visitante";
            this.visitanteDataGridViewCheckBoxColumn.HeaderText = "Visitante";
            this.visitanteDataGridViewCheckBoxColumn.Name = "visitanteDataGridViewCheckBoxColumn";
            this.visitanteDataGridViewCheckBoxColumn.ReadOnly = true;
            this.visitanteDataGridViewCheckBoxColumn.Width = 53;
            // 
            // cPFCNPJDataGridViewTextBoxColumn
            // 
            this.cPFCNPJDataGridViewTextBoxColumn.DataPropertyName = "CPF/CNPJ";
            this.cPFCNPJDataGridViewTextBoxColumn.HeaderText = "CPF/CNPJ";
            this.cPFCNPJDataGridViewTextBoxColumn.Name = "cPFCNPJDataGridViewTextBoxColumn";
            this.cPFCNPJDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPFCNPJDataGridViewTextBoxColumn.Width = 84;
            // 
            // razaoDataGridViewTextBoxColumn
            // 
            this.razaoDataGridViewTextBoxColumn.DataPropertyName = "Razao";
            this.razaoDataGridViewTextBoxColumn.HeaderText = "Razao";
            this.razaoDataGridViewTextBoxColumn.Name = "razaoDataGridViewTextBoxColumn";
            this.razaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.razaoDataGridViewTextBoxColumn.Width = 63;
            // 
            // chaveDataGridViewTextBoxColumn
            // 
            this.chaveDataGridViewTextBoxColumn.DataPropertyName = "Chave";
            this.chaveDataGridViewTextBoxColumn.HeaderText = "Chave";
            this.chaveDataGridViewTextBoxColumn.Name = "chaveDataGridViewTextBoxColumn";
            this.chaveDataGridViewTextBoxColumn.ReadOnly = true;
            this.chaveDataGridViewTextBoxColumn.Width = 63;
            // 
            // dataEntregueDataGridViewTextBoxColumn
            // 
            this.dataEntregueDataGridViewTextBoxColumn.DataPropertyName = "Data Entregue";
            this.dataEntregueDataGridViewTextBoxColumn.HeaderText = "Data Entregue";
            this.dataEntregueDataGridViewTextBoxColumn.Name = "dataEntregueDataGridViewTextBoxColumn";
            this.dataEntregueDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataEntregueDataGridViewTextBoxColumn.Width = 93;
            // 
            // recebeuDataGridViewCheckBoxColumn
            // 
            this.recebeuDataGridViewCheckBoxColumn.DataPropertyName = "Recebeu";
            this.recebeuDataGridViewCheckBoxColumn.HeaderText = "Recebeu";
            this.recebeuDataGridViewCheckBoxColumn.Name = "recebeuDataGridViewCheckBoxColumn";
            this.recebeuDataGridViewCheckBoxColumn.ReadOnly = true;
            this.recebeuDataGridViewCheckBoxColumn.Width = 57;
            // 
            // dataRecebidoDataGridViewTextBoxColumn
            // 
            this.dataRecebidoDataGridViewTextBoxColumn.DataPropertyName = "Data Recebido";
            this.dataRecebidoDataGridViewTextBoxColumn.HeaderText = "Data Recebido";
            this.dataRecebidoDataGridViewTextBoxColumn.Name = "dataRecebidoDataGridViewTextBoxColumn";
            this.dataRecebidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataRecebidoDataGridViewTextBoxColumn.Width = 96;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(622, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(541, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Relatórios";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bdDataSet bdDataSet;
        private System.Windows.Forms.BindingSource dadosBindingSource;
        private bdDataSetTableAdapters.dadosTableAdapter dadosTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn funcionarioDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAmbevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn visitanteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFCNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntregueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn recebeuDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataRecebidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

