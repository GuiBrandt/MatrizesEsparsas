/**
 * Matriz.cs
 * 
 * Arquivo da classe para manipulação de matrizes
 * 
 * Guilherme Brandt (RA: 16173)
 * Lucas Hideki (RA: 16186)
 */
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
        Celula head;

        /// <summary>
        /// Valor para quando um item na matriz não é definido
        /// </summary>
        const double DEFAULT = 0;

        /// <summary>
        /// Mensagem de erro para quando pede-se um item numa posição fora da matriz
        /// </summary>
        const string OUT_OF_BOUNDS_MSG = "A coordenada especificada não se encontra na matriz";

        /// <summary>
        /// Obtém ou define o número numa determinada posição na matriz
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

                Celula atual = this.head;

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

                Celula atual = this.head, antVert = this.head;

                // Move o atual para o cabeçalho da coluna desejada
                for (int i = 0; i < col; i++)
                    atual = atual.ProxHorz;

                // Move o atual para a linha desejada
                while (atual != null && atual.Linha < row)
                {
                    antVert = atual;
                    atual = atual.ProxVert;
                }

                // Se a linha de atual bate com a desejada, muda o valor do atual
                // Caso o valor seja nulo (0), não faz isso e segue para a exclusão
                // da célula da matriz
                if (atual != null && atual.Linha == row && value != DEFAULT)
                    atual.Info = value;
                else
                {
                    // Obtém o item anterior na horizontal
                    Celula antHorz = null, aux;

                    aux = this.head;

                    // Move o auxiliar para a linha desejada
                    while (aux.Linha < row)
                        aux = aux.ProxVert;

                    // Move o auxiliar para a maior coluna que seja menor que a 
                    // desejada e tenha uma célula na linha desejada
                    while (aux != null && aux.Coluna < col - 1)
                    {
                        antHorz = aux;
                        aux = aux.ProxHorz;
                    }

                    // Se o valor for 0 e houver uma célula na posição desejada, 
                    // apaga essa célula
                    if (value == DEFAULT && atual.Linha == row)
                    {
                        antVert.ProxVert = atual.ProxVert;
                        antHorz.ProxHorz = atual.ProxHorz;
                    }

                    // Se não, insere uma célula na posição dada
                    else
                    {
                        Celula nova = new Celula(col, row, value, antHorz.ProxHorz, antVert.ProxVert);
                        antHorz.ProxHorz = nova;
                        antVert.ProxVert = nova;
                    }
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
        /// <param name="cols">Número de colunas da matriz</param>
        /// <param name="rows">Número de linhas da matriz</param>
        public Matriz(int cols, int rows)
        {
            this.cols = cols;
            this.rows = rows;

            this.head = new Celula(-1, -1, 0);

            Celula aux = null;

            // Cria os nós cabeça
            for (int i = rows; i >= 0; --i)
                aux = new Celula(-1, i, 0, null, aux);
            head.ProxVert = aux;

            for (int i = cols; i >= 0; --i)
                aux = new Celula(-1, i, 0, aux, null);
            head.ProxHorz = aux;
        }

        /// <summary>
        /// Multiplicação
        /// </summary>
        /// <param name="a">Uma matriz</param>
        /// <param name="b">Outra matriz, com número de linhas igual ao número de colunas da primeira</param>
        /// <returns>O produto das matrizes, será sempre uma matriz com o número de linhas da primeira 
        /// e o número de colunas da segunda</returns>
        public static Matriz operator*(Matriz a, Matriz b)
        {
            // O número de linhas de B tem que ser igual ao número de colunas de A,
            // se não for, as matrizes não são multiplicáveis
            if (b.NumeroDeLinhas != a.NumeroDeColunas)
                throw new Exception("Multiplicação de matrizes inválida");

            Matriz resultado = new Matriz(b.NumeroDeColunas, a.NumeroDeLinhas);

            // Percorre cada linha da matriz A e cada coluna da matriz B para calcular
            // o resultado da multiplicação e montar a matriz resultado
            for (Celula linha = a.head; linha != null; linha = linha.ProxVert)
            {
                for (Celula coluna = b.head; coluna != null; coluna = coluna.ProxHorz)
                {
                    double soma = 0.0;

                    Celula atualA = linha.ProxHorz;
                    Celula atualB = coluna.ProxVert;

                    // Faz a soma dos produtos entre as linha atual em A e a coluna atual em B
                    do
                    {
                        soma += atualA.Info * atualB.Info;

                        atualA = atualA.ProxHorz;
                        atualB = atualB.ProxVert;
                    } while (atualA != null & atualB != null);

                    resultado[coluna.Coluna, linha.Linha] = soma;
                }
            }

            return resultado;
        }

        /// <summary>
        /// Soma
        /// </summary>
        /// <param name="a">Uma matriz</param>
        /// <param name="b">Outra matriz, com as mesmas dimensões da primeira</param>
        /// <returns>A soma das matriz, será sempre uma matriz de dimensão igual à das passadas por
        /// parâmetro</returns>
        public static Matriz operator+(Matriz a, Matriz b)
        {
            // As matrizes têm de ter as mesmas dimensões para a soma
            if (b.NumeroDeColunas != a.NumeroDeColunas || b.NumeroDeLinhas != a.NumeroDeLinhas)
                throw new Exception("Soma de matrizes inválida");

            Matriz resultado = new Matriz(a.NumeroDeColunas, a.NumeroDeLinhas);

            // Percorre cada linha e cada coluna das duas matrizes simultaneamente e soma os valores
            // das matrizes para montar a matriz resultado
            for (
                Celula rowA = a.head, rowB = b.head; 
                rowA != null && rowB != null; 
                rowA = rowA.ProxVert, rowB = rowB.ProxVert
            )
                for (
                    Celula atualA = rowA.ProxHorz, atualB = rowB.ProxHorz;
                    atualA != null && atualB != null;
                    atualA = atualA.ProxHorz, atualB = atualB.ProxHorz
                )
                    resultado[atualA.Coluna, rowA.Linha] = atualA.Info + atualB.Info;

            return resultado;
        }
    }
}
