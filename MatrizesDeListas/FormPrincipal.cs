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
    public partial class FormPrincipal : Form
    {
        Matriz matrizA, matrizB, resultado;

        /// <summary>
        /// Matriz A
        /// </summary>
        public Matriz MatrizA
        {
            get { return matrizA; }

            set
            {
                matrizA = value;
                MostrarMatriz(matrizA, gridA);
            }
        }

        /// <summary>
        /// Matriz B
        /// </summary>
        public Matriz MatrizB
        {
            get { return matrizB; }

            set
            {
                matrizB = value;
                MostrarMatriz(matrizB, gridB);
            }
        }

        /// <summary>
        /// Matriz Resultado
        /// </summary>
        public Matriz Resultado
        {
            get { return resultado; }

            set
            {
                resultado = value;
                MostrarMatriz(resultado, gridResultado);
            }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public FormPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento de edição de uma célula do GridView, altera o valor correspondente na matriz
        /// </summary>
        /// <param name="sender">GridView editado</param>
        /// <param name="e">Parâmetros do evento</param>
        private void grid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Matriz m;
            if (sender.Equals(gridA))
                m = matrizA;
            else
                m = matrizB;

            DataGridView grid = (DataGridView)sender;

            double v = 0.0;
            double.TryParse((grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value ?? "").ToString(), out v);
            m[e.RowIndex, e.ColumnIndex] = v;

            MostrarMatriz(m, grid);
        }
        
        /// <summary>
        /// Evento de clique no botão de criação da matriz A
        /// </summary>
        private void btnCriarMatrizA_Click(object sender, EventArgs e)
        {
            FormCriarMatriz frmCriarMatriz = new FormCriarMatriz();

            if (frmCriarMatriz.ShowDialog() == DialogResult.OK)
            {
                MatrizA = frmCriarMatriz.Matriz;

                btnLiberarMatrizA.Enabled = btnSalvarA.Enabled = btnSomarKColunaA.Enabled = true;
                btnSomar.Enabled = btnMultiplicar.Enabled = matrizB != null;
            }

            frmCriarMatriz.Dispose();
        }

        /// <summary>
        /// Evento de clique no botão de criação da matriz B
        /// </summary>
        private void btnCriarMatrizB_Click(object sender, EventArgs e)
        {
            FormCriarMatriz frmCriarMatriz = new FormCriarMatriz();

            if (frmCriarMatriz.ShowDialog() == DialogResult.OK)
            {
                MatrizB = frmCriarMatriz.Matriz;

                btnLiberarMatrizB.Enabled = btnSalvarB.Enabled = btnSomarKColunaB.Enabled = true;
                btnSomar.Enabled = btnMultiplicar.Enabled = matrizA != null;
            }

            frmCriarMatriz.Dispose();
        }

        /// <summary>
        /// Soma as matrizes e mostra o resultado
        /// </summary>
        private void btnSomar_Click(object sender, EventArgs e)
        {
            try
            {
                Resultado = MatrizA + MatrizB;
                btnSalvarResultado.Enabled = true;
                lblResultado.Text = "Resultado (Soma):";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Multiplica as matrizes e mostra o resultado
        /// </summary>
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                Resultado = MatrizA * MatrizB;
                btnSalvarResultado.Enabled = true;
                lblResultado.Text = "Resultado (Multiplicação):";
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }

        /// <summary>
        /// Libera a matriz A
        /// </summary>
        private void btnLiberarMatrizA_Click(object sender, EventArgs e)
        {
            MatrizA = null;
            gridA.Rows.Clear();
            gridA.Columns.Clear();

            btnLiberarMatrizA.Enabled = btnSalvarA.Enabled = btnSomarKColunaA.Enabled = btnSomar.Enabled = btnMultiplicar.Enabled = false;
        }

        /// <summary>
        /// Soma uma constante K à coluna C da matriz A
        /// </summary>
        private void btnSomarKColunaA_Click(object sender, EventArgs e)
        {
            FormSomarK frmSomarK = new FormSomarK();
            frmSomarK.ColunaMax = MatrizA.NumeroDeColunas;

            if (frmSomarK.ShowDialog() == DialogResult.OK)
            {
                MatrizA.SomarNaColuna(frmSomarK.Coluna, frmSomarK.K);
                MostrarMatriz(MatrizA, gridA);
            }

            frmSomarK.Dispose();
        }

        /// <summary>
        /// Evento de adição de coluna a um grid
        /// Redimensiona as colunas para um tamanho aceitável
        /// </summary>
        private void grid_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.Width = 32;
        }
        
        /// <summary>
        /// Evento de adição de linha a um grid
        /// Redimensiona a linha para um tamanho aceitável
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < e.RowCount; i++)
                (sender as DataGridView).Rows[i + e.RowIndex].Height = 32;
        }

        /// <summary>
        /// Libera a matriz B
        /// </summary>
        private void btnLiberarMatrizB_Click(object sender, EventArgs e)
        {
            MatrizB = null;
            gridB.Rows.Clear();
            gridB.Columns.Clear();

            btnLiberarMatrizB.Enabled = btnSalvarB.Enabled = btnSomarKColunaB.Enabled = btnSomar.Enabled = btnMultiplicar.Enabled = false;
        }

        /// <summary>
        /// Salva a matriz A em um arquivo
        /// </summary>
        private void btnSalvarA_Click(object sender, EventArgs e)
        {
            if (dlgSalvar.ShowDialog() == DialogResult.OK)
                SalvarMatriz(matrizA, dlgSalvar.FileName);
        }

        /// <summary>
        /// Salva a matriz B em um arquivo
        /// </summary>
        private void btnSalvarB_Click(object sender, EventArgs e)
        {
            if (dlgSalvar.ShowDialog() == DialogResult.OK)
                SalvarMatriz(matrizB, dlgSalvar.FileName);
        }

        /// <summary>
        /// Salva a matriz resultado em um arquivo
        /// </summary>
        private void btnSalvarResultado_Click(object sender, EventArgs e)
        {
            if (dlgSalvar.ShowDialog() == DialogResult.OK)
                SalvarMatriz(resultado, dlgSalvar.FileName);
        }

        /// <summary>
        /// Soma uma constante K à coluna C da matriz B
        /// </summary>
        private void btnSomarKColunaB_Click(object sender, EventArgs e)
        {
            FormSomarK frmSomarK = new FormSomarK();
            frmSomarK.ColunaMax = MatrizB.NumeroDeColunas;

            if (frmSomarK.ShowDialog() == DialogResult.OK)
            {
                MatrizB.SomarNaColuna(frmSomarK.Coluna, frmSomarK.K);
                MostrarMatriz(MatrizB, gridB);
            }

            frmSomarK.Dispose();
        }        

        /// <summary>
        /// Salva uma matriz em um arquivo
        /// </summary>
        /// <param name="matriz">Matriz a ser salva</param>
        /// <param name="filename">Nome do arquivo onde salvar a matriz</param>
        private void SalvarMatriz(Matriz matriz, string filename)
        {
            XmlDocument document = new XmlDocument();
            XmlElement noMatriz = document.CreateElement("Matriz");

            for (int l = 0; l < matriz.NumeroDeLinhas; l++)
            {
                for (int c = 0; c < matriz.NumeroDeColunas; c++)
                {
                    if (matriz[l, c] == 0) continue;

                    XmlElement noCelula = document.CreateElement("Celula");
                    noCelula.SetAttribute("linha", l.ToString());
                    noCelula.SetAttribute("coluna", c.ToString());
                    noCelula.InnerText = matriz[l, c].ToString();

                    noMatriz.AppendChild(noCelula);
                }
            }

            document.AppendChild(noMatriz);
            document.Save(filename);
        }

        /// <summary>
        /// Mostra uma matriz num grid view
        /// </summary>
        /// <param name="matriz">Matriz a ser mostrada</param>
        /// <param name="grid">Grid onde mostrar</param>
        private void MostrarMatriz(Matriz matriz, DataGridView grid)
        {
            if (matriz == null) return;

            // Adiciona só as colunas que faltam no grid (evita mudar o tamanho do grid toda vez
            // que mostra a matriz)
            for (int i = grid.Columns.Count; i < matriz.NumeroDeColunas; i++)
                grid.Columns.Add("col" + i.ToString(), (i + 1).ToString());

            // Adiciona só as linhas que faltam no grid (evita mudar o tamanho do grid toda vez
            // que mostra a matriz)
            for (int i = grid.Rows.Count; i < matriz.NumeroDeLinhas; i++)
                grid.Rows.Add();

            // Escreve o valor de cada posição da matriz na posição correspondente no grid
            for (int l = 0; l < matriz.NumeroDeLinhas; l++)
                for (int c = 0; c < matriz.NumeroDeColunas; c++)
                    grid.Rows[l].Cells[c].Value = matriz[l, c].ToString();
        }
    }
}
