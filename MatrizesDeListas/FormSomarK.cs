using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrizesDeListas
{
    /// <summary>
    /// Classe para o formulário usado para somar K a uma coluna C de uma matriz
    /// </summary>
    internal partial class FormSomarK : Form
    {
        /// <summary>
        /// Valor máximo para o campo "Coluna" do formulário
        /// </summary>
        public int ColunaMax
        {
            get
            {
                return (int)numColuna.Maximum;
            }
            set
            {
                numColuna.Maximum = value;
            }
        }

        /// <summary>
        /// Valor do campo "Coluna" do formulário
        /// </summary>
        public int Coluna
        {
            get
            {
                return (int)numColuna.Value - 1;
            }
        }

        /// <summary>
        /// Valor da constante a ser somada na coluna especificada da matriz
        /// </summary>
        public double K
        {
            get
            {
                return (double)numK.Value;
            }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public FormSomarK()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento de clique no botão OK
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Evento de clique no botão cancelar
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
