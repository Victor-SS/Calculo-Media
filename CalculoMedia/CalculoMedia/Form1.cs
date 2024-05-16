using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoMedia
{
    public partial class FrmCalculoMedia : Form
    {
        public FrmCalculoMedia()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtMateria.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNome.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nome;
            string materia;
            decimal nota1;
            decimal nota2;
            decimal resultado;
            string mensagem;

            nome = txtNome.Text;
            materia = txtMateria.Text;
            nota1 = decimal.Parse(txtNota1.Text);
            nota2 = decimal.Parse(txtNota2.Text);
            resultado = (nota1 + nota2) / 2;
            mensagem = nome + ", sua média da matéria " + materia
                + " é " + resultado.ToString("#0.0") + ".\n"
                + "Você está ";

            MessageBoxIcon icon = new MessageBoxIcon();

            if(resultado >= 7)
            {
                mensagem += "Aprovado!";
                icon = MessageBoxIcon.Information;
            }
            else if(resultado < 5)
            {
                mensagem += "Reprovado!";
                icon = MessageBoxIcon.Error;
            }
            else
            {
                mensagem += "em Recuperação!";
                icon = MessageBoxIcon.Warning;
            }

            MessageBox.Show(mensagem, "Cálculo de Média",
                MessageBoxButtons.OK, icon);
        }
    }
}
