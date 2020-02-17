using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keyproject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

         
            panelfun.Visible = false;
            panelvis.Visible = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkfun.Checked == true)
            {
                panelfun.Visible = true;
            }
            else
            {
                panelfun.Visible = false;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdDataSet1.chave'. Você pode movê-la ou removê-la conforme necessário.
            this.chaveTableAdapter.Fill(this.bdDataSet1.chave);
            // TODO: esta linha de código carrega dados na tabela 'bdDataSet1.setor'. Você pode movê-la ou removê-la conforme necessário.
            this.setorTableAdapter.Fill(this.bdDataSet1.setor);

        }

        private void checkvis_CheckedChanged(object sender, EventArgs e)
        {
            if (checkvis.Checked == true)
            {
                panelvis.Visible = true;
            }
            else
            {
                panelvis.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dadosTableAdapter1.Insert(
                Nome: textBox1.Text,
                Funcionario: checkfun.Checked,
                ID_Ambev: null,
                Visitante: checkvis.Checked,
                _CPF_CNPJ: null,
                Razao: razvis.Text,
                Chave: cbchave.Text,
                Data_Entregue: dateTimePicker1.Value,
                Data_Recebido: dateTimePicker1.Value,
                Recebeu: checkBox1.Checked
                ); 

        }
        
        
    }
}
