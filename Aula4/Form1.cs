using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            txtConteudo.Text = txtConteudo.Text.Trim();

            //if (txtConteudo.Text.Trim() == "")
            if (string.IsNullOrEmpty(txtConteudo.Text))
                MessageBox.Show("O campo está vazio!", //Conteudo da mensagem
                                "Atenção!",            //Titulo
                                MessageBoxButtons.OK,   //Botoes
                                MessageBoxIcon.Warning);//Icone
            else
                MessageBox.Show("O valor infomador é: " + txtConteudo.Text);
        }

        private void btnValidar2_Click(object sender, EventArgs e)
        {
            string texto;

            texto = "";

            /*
            if (string.IsNullOrEmpty(texto))
                MessageBox.Show(texto);
            else
                txtConteudo.Text = texto;*/

            if (!string.IsNullOrEmpty(texto))
                txtConteudo.Text = texto;
        }

        private void btnMostrarSenha_Click(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar =
                !cbxMostrarSenha.Checked;
        }

        private void cbxMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtSenha.UseSystemPasswordChar =
                !cbxMostrarSenha.Checked;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            switch (cbbOpcoes.SelectedIndex)
            {
                case 0: MessageBox.Show("Opção Banana");
                    break;
                case 1:
                    MessageBox.Show("Opção Maçã");
                    break;
                case 2:
                    MessageBox.Show("Opção Melão");
                    break;
                case 3:
                    MessageBox.Show("Opção Limão");
                    break;
            }
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nudValor.Value; i++)
                MessageBox.Show(
                    "Tentativa: " + (i+1).ToString());

            //ou
            /*
            for (int i = 1; i <= nudValor.Value; i++)
                MessageBox.Show(
                    "Tentativa: " + i.ToString());*/
        }

        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            lsbFibonacci.Items.Clear();

            int quantidade = 0;

            int num1 = 1;
            int num2 = 1;
            int cont = 1;
            int aux;

            quantidade = (int)nudValor.Value;

            lsbFibonacci.Items.Add(num1);

            while(cont <= quantidade)
            {
                aux = num1 + num2;
                num1 = num2;
                num2 = aux;

                lsbFibonacci.Items.Add(num2);
                cont++;
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int cont = 1;

            while (cont <= nudValor.Value)
            {
                lsbFibonacci.Items.Add(
                    "Tentativa: " + cont.ToString());
                cont++;
            }
        }
    }
}
