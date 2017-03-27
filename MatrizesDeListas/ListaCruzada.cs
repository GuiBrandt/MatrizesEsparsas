using System;

namespace MatrizesDeListas
{
    /// <summary>
    /// Classe para a matriz
    /// </summary>
    /// <typeparam name="Dado">Tipo de dado que será armazenado na matriz</typeparam>
    class Matriz
    {
        int cols, rows;
        NoListaCruzada<double> primeiro;

        /// <summary>
        /// Valor para quando um item na matriz não é definido
        /// </summary>
        const double DEFAULT = 0;

        /// <summary>
        /// Mensagem de erro para quando pede-se um item numa posição fora da matriz
        /// </summary>
        const string OUT_OF_BOUNDS_MSG = "A coordenada especificada não se encontra na matriz";

        /// <summary>
        /// Obtém o número numa determinada posição na matriz
        /// </summary>
        /// <param name="col">Coluna do dado que se deseja obter</param>
        /// <param name="row">Linha do dado que se deseja obter</param>
        /// <returns>O número na posição passada por parâmetro</returns>
        public double this[int col, int row]
        {
            get
            {
                // Se o número de coluna ou o número de linha desejados estiver
                // fora do limite da matriz, o acesso é inválido
                if (col < 0 || row < 0 ||
                    col > NumeroDeColunas || row > NumeroDeLinhas)
                        throw new IndexOutOfRangeException(OUT_OF_BOUNDS_MSG);

                NoListaCruzada<double> atual = this.primeiro;

                // Move o atual para o cabeçalho da coluna desejada
                for (int i = 0; i < col; i++)
                    atual = atual.ProxHorz;
                
                // Move o atual para a linha desejada
                while (atual != null && atual.Linha < row)
                    atual = atual.ProxVert;
                
                // Se a linha de atual bate com a desejada, retorna o atual
                if (atual != null && atual.Linha == row)
                    return atual.Info;

                // Se não encontrou o item na posição desejada, retorna o valor padrão
                return DEFAULT;
            }

            set
            {
                // Se o número de coluna ou o número de linha desejados estiver
                // fora do limite da matriz, o acesso é inválido
                if (col < 0 || row < 0 ||
                    col > NumeroDeColunas || row > NumeroDeLinhas)
                    throw new IndexOutOfRangeException(OUT_OF_BOUNDS_MSG);

                NoListaCruzada<double> atual = this.primeiro;

                // Move o atual para o cabeçalho da coluna desejada
                for (int i = 0; i < col; i++)
                    atual = atual.ProxHorz;

                // Move o atual para a linha desejada
                while (atual != null && atual.Linha < row)
                    atual = atual.ProxVert;

                // Se a linha de atual bate com a desejada, retorna o atual
                if (atual != null && atual.Linha == row)
                    atual.Info = value;
                else
                {
                    NoListaCruzada<double> auxCol = this.primeiro, auxRow = null;

                    while (auxCol.Coluna < col)
                        auxCol = auxCol.ProxHorz;

                    while (auxRow != null && auxRow.Linha < row)
                        auxRow = auxRow.ProxVert;

                    if (auxRow != null && auxRow.Linha == row)
                    {
                        auxRow.Info = value;
                        return;
                    }

                    // Cria o nó para inserir
                    var no = new NoListaCruzada<double>(col, row, value, null, atual.ProxVert);

                    //
                    // Obtenção do próximo item na horizontal
                    //
                    #region GetProxHorz

                    auxCol = this.primeiro;

                    // Move o auxiliar até a coluna à frente do item desejado
                    while (auxCol.Coluna < col + 1)
                        auxCol = auxCol.ProxHorz;

                    for (; auxCol.Coluna < NumeroDeColunas; auxCol = auxCol.ProxHorz)
                    {
                        auxRow = auxCol.ProxVert;

                        if (auxRow == null) continue;

                        // Procura o item na linha desejada da coluna desejada
                        while (auxRow != null || auxRow.Linha < row)
                            auxRow = auxRow.ProxVert;

                        // Se achou um item, este será o próximo na horizontal
                        if (auxRow.Linha == row)
                            break;
                    }

                    NoListaCruzada<double> proxHorz = auxRow.Linha == row ? auxRow : null;

                    no.ProxHorz = proxHorz;

                    #endregion

                    //
                    // Obtenção do item anterior na horizontal
                    //
                    #region GetAntHorz

                    NoListaCruzada<double> antHorz = null;

                    auxCol = this.primeiro;
                    while (auxCol.Coluna < col)
                    {
                        auxRow = auxCol.ProxVert;

                        if (auxRow == null) continue;

                        while (auxRow.Linha < row)
                            auxRow = auxRow.ProxVert;

                        if (auxRow.Linha == row)
                            antHorz = auxRow;

                        auxCol = auxCol.ProxHorz;
                    }

                    antHorz.ProxHorz = no;

                    #endregion

                    atual.ProxVert = no;
                }
            }
        }

        /// <summary>
        /// Número de colunas da matriz
        /// </summary>
        public int NumeroDeColunas
        {
            get { return cols; }
        }

        /// <summary>
        /// Número de linhas da matriz
        /// </summary>
        public int NumeroDeLinhas
        {
            get { return rows; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        public Matriz(int cols, int rows)
        {
            this.cols = cols;
            this.rows = rows;

            this.primeiro = new NoListaCruzada<double>(-1, -1, 0);

            NoListaCruzada<double> aux = null;

            for (int i = rows; i >= 0; --i)
                aux = new NoListaCruzada<double>(-1, i, 0, null, aux);
            primeiro.ProxVert = aux;

            for (int i = cols; i >= 0; --i)
                aux = new NoListaCruzada<double>(-1, i, 0, aux, null);
            primeiro.ProxHorz = aux;
        }
    }
}
