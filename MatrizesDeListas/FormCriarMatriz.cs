using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MatrizesDeListas
{
    /// <summary>
    /// Classe para o formulário de criação de matriz
    /// </summary>
    internal partial class FormCriarMatriz : Form
    {
        /// <summary>
        /// Obtém a matriz criada
        /// </summary>
        public Matriz Matriz { get; private set; }

        /// <summary>
        /// Construtor
        /// </summary>
        public FormCriarMatriz()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento disparado quando o botão OK é clicado
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Matriz = new Matriz((int)numColunas.Value, (int)numLinhas.Value);

            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Evento disparado quando o botão Cancelar é clicado
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Evento disparado quando o botão Ler de Arquivo é clicado
        /// </summary>
        private void btnLerDeArquivo_Click(object sender, EventArgs e)
        {
            if (dlgLerDeArquivo.ShowDialog() == DialogResult.OK)
            {
                this.Matriz = new Matriz((int)numColunas.Value, (int)numLinhas.Value);
                try
                {
                    LerMatrizDeArquivo(dlgLerDeArquivo.FileName);

                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Falha ao ler arquivo XML: " + ex.Message, "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Lê a matriz de um arquivo XML
        /// </summary>
        /// <param name="fileName">Nome do arquivo</param>
        private void LerMatrizDeArquivo (string fileName)
        {
            XmlDocument document = new XmlDocument();
            document.Load(fileName);

            // Obtém o nó raíz do arquivo, se o nó não for do tipo Matriz, lança uma exeção
            XmlNode noMatriz = document.DocumentElement;

            // Obtém a lista de nós filhos (células) e monta a matriz
            XmlNodeList celulas = noMatriz.ChildNodes;

            foreach (XmlNode celula in celulas)
            {
                int linha = Convert.ToInt32(celula.Attributes["linha"].Value) - 1,
                    coluna = Convert.ToInt32(celula.Attributes["coluna"].Value) - 1;
                double valor = Convert.ToDouble(celula.InnerText);

                this.Matriz[linha, coluna] = valor;
            }
        }
    }
}
