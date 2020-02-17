namespace keyproject
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxid = new System.Windows.Forms.TextBox();
            this.razvis = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.checkfun = new System.Windows.Forms.CheckBox();
            this.checkvis = new System.Windows.Forms.CheckBox();
            this.cbsetor = new System.Windows.Forms.ComboBox();
            this.lblsetor = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblraz = new System.Windows.Forms.Label();
            this.cbchave = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.submit1 = new System.Windows.Forms.Button();
            this.panelfun = new System.Windows.Forms.Panel();
            this.panelvis = new System.Windows.Forms.Panel();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.setorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setorTableAdapter = new keyproject.bdDataSet1TableAdapters.setorTableAdapter();
            this.chaveTableAdapter = new keyproject.bdDataSet1TableAdapters.chaveTableAdapter();
            this.bdDataSet1 = new keyproject.bdDataSet1();
            this.bdDataSet11 = new keyproject.bdDataSet1();
            this.dadosTableAdapter1 = new keyproject.bdDataSetTableAdapters.dadosTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panelfun.SuspendLayout();
            this.panelvis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chaveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adicionar Ocorrência";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtboxid
            // 
            this.txtboxid.Location = new System.Drawing.Point(60, 14);
            this.txtboxid.Name = "txtboxid";
            this.txtboxid.Size = new System.Drawing.Size(135, 20);
            this.txtboxid.TabIndex = 3;
            // 
            // razvis
            // 
            this.razvis.Location = new System.Drawing.Point(75, 62);
            this.razvis.Name = "razvis";
            this.razvis.Size = new System.Drawing.Size(135, 20);
            this.razvis.TabIndex = 4;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(0, 17);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(54, 13);
            this.lblid.TabIndex = 6;
            this.lblid.Text = "ID Ambev";
            // 
            // checkfun
            // 
            this.checkfun.AutoSize = true;
            this.checkfun.Location = new System.Drawing.Point(77, 56);
            this.checkfun.Name = "checkfun";
            this.checkfun.Size = new System.Drawing.Size(81, 17);
            this.checkfun.TabIndex = 7;
            this.checkfun.Text = "Funcionário";
            this.checkfun.UseVisualStyleBackColor = true;
            this.checkfun.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkvis
            // 
            this.checkvis.AutoSize = true;
            this.checkvis.Location = new System.Drawing.Point(175, 56);
            this.checkvis.Name = "checkvis";
            this.checkvis.Size = new System.Drawing.Size(125, 17);
            this.checkvis.TabIndex = 8;
            this.checkvis.Text = "Visitante/Fornecedor";
            this.checkvis.UseVisualStyleBackColor = true;
            this.checkvis.CheckedChanged += new System.EventHandler(this.checkvis_CheckedChanged);
            // 
            // cbsetor
            // 
            this.cbsetor.DataSource = this.setorBindingSource;
            this.cbsetor.DisplayMember = "Setor";
            this.cbsetor.FormattingEnabled = true;
            this.cbsetor.Location = new System.Drawing.Point(61, 57);
            this.cbsetor.Name = "cbsetor";
            this.cbsetor.Size = new System.Drawing.Size(134, 21);
            this.cbsetor.TabIndex = 9;
            this.cbsetor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblsetor
            // 
            this.lblsetor.AutoSize = true;
            this.lblsetor.Location = new System.Drawing.Point(0, 60);
            this.lblsetor.Name = "lblsetor";
            this.lblsetor.Size = new System.Drawing.Size(32, 13);
            this.lblsetor.TabIndex = 10;
            this.lblsetor.Text = "Setor";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(0, 17);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(59, 13);
            this.lblcpf.TabIndex = 11;
            this.lblcpf.Text = "CPF/CNPJ";
            // 
            // lblraz
            // 
            this.lblraz.AutoSize = true;
            this.lblraz.Location = new System.Drawing.Point(-1, 65);
            this.lblraz.Name = "lblraz";
            this.lblraz.Size = new System.Drawing.Size(70, 13);
            this.lblraz.TabIndex = 12;
            this.lblraz.Text = "Razão Social";
            // 
            // cbchave
            // 
            this.cbchave.DataSource = this.chaveBindingSource;
            this.cbchave.DisplayMember = "Chave";
            this.cbchave.FormattingEnabled = true;
            this.cbchave.Location = new System.Drawing.Point(122, 231);
            this.cbchave.Name = "cbchave";
            this.cbchave.Size = new System.Drawing.Size(133, 21);
            this.cbchave.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Chave";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 278);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Data";
            // 
            // submit1
            // 
            this.submit1.Location = new System.Drawing.Point(311, 317);
            this.submit1.Name = "submit1";
            this.submit1.Size = new System.Drawing.Size(75, 23);
            this.submit1.TabIndex = 17;
            this.submit1.Text = "Adicionar";
            this.submit1.UseVisualStyleBackColor = true;
            this.submit1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelfun
            // 
            this.panelfun.Controls.Add(this.lblid);
            this.panelfun.Controls.Add(this.txtboxid);
            this.panelfun.Controls.Add(this.lblsetor);
            this.panelfun.Controls.Add(this.cbsetor);
            this.panelfun.Location = new System.Drawing.Point(62, 125);
            this.panelfun.Name = "panelfun";
            this.panelfun.Size = new System.Drawing.Size(228, 106);
            this.panelfun.TabIndex = 18;
            // 
            // panelvis
            // 
            this.panelvis.Controls.Add(this.txtcpf);
            this.panelvis.Controls.Add(this.razvis);
            this.panelvis.Controls.Add(this.lblcpf);
            this.panelvis.Controls.Add(this.lblraz);
            this.panelvis.Location = new System.Drawing.Point(63, 125);
            this.panelvis.Name = "panelvis";
            this.panelvis.Size = new System.Drawing.Size(228, 106);
            this.panelvis.TabIndex = 19;
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(60, 14);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(135, 20);
            this.txtcpf.TabIndex = 3;
            // 
            // setorBindingSource
            // 
            this.setorBindingSource.DataMember = "setor";
            this.setorBindingSource.DataSource = this.bdDataSet1;
            // 
            // chaveBindingSource
            // 
            this.chaveBindingSource.DataMember = "chave";
            this.chaveBindingSource.DataSource = this.bdDataSet1;
            // 
            // setorTableAdapter
            // 
            this.setorTableAdapter.ClearBeforeFill = true;
            // 
            // chaveTableAdapter
            // 
            this.chaveTableAdapter.ClearBeforeFill = true;
            // 
            // bdDataSet1
            // 
            this.bdDataSet1.DataSetName = "bdDataSet1";
            this.bdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdDataSet11
            // 
            this.bdDataSet11.DataSetName = "bdDataSet1";
            this.bdDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dadosTableAdapter1
            // 
            this.dadosTableAdapter1.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(298, 152);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 352);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.submit1);
            this.Controls.Add(this.panelvis);
            this.Controls.Add(this.panelfun);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbchave);
            this.Controls.Add(this.checkvis);
            this.Controls.Add(this.checkfun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelfun.ResumeLayout(false);
            this.panelfun.PerformLayout();
            this.panelvis.ResumeLayout(false);
            this.panelvis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chaveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxid;
        private System.Windows.Forms.TextBox razvis;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.CheckBox checkfun;
        private System.Windows.Forms.CheckBox checkvis;
        private System.Windows.Forms.ComboBox cbsetor;
        private System.Windows.Forms.Label lblsetor;
        private bdDataSet1 bdDataSet1;
        private System.Windows.Forms.BindingSource setorBindingSource;
        private bdDataSet1TableAdapters.setorTableAdapter setorTableAdapter;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblraz;
        private System.Windows.Forms.ComboBox cbchave;
        private System.Windows.Forms.BindingSource chaveBindingSource;
        private bdDataSet1TableAdapters.chaveTableAdapter chaveTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submit1;
        private System.Windows.Forms.Panel panelfun;
        private System.Windows.Forms.Panel panelvis;
        private System.Windows.Forms.TextBox txtcpf;
        private bdDataSet1 bdDataSet11;
        private bdDataSetTableAdapters.dadosTableAdapter dadosTableAdapter1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}