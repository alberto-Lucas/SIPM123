using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula5
{
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
            AutoValidate = AutoValidate.Disable;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Validar cancelamento
            if (MessageBox.Show(
                "Deseja realmente descartar as alterações?", 
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) 
                == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            //validar o campo txtNome
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                //Cancela a execução da rotina
                e.Cancel = true;
                errProvider.SetError(txtNome,
                    "Preencha o nome.");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtNome, "");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Registro salvo com sucesso.",
                    "Informção", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("É necessário o preenchimento " +
                    "de todos os campos obrigatórios.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
