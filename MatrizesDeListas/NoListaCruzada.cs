using System;

namespace MatrizesDeListas
{
    /// <summary>
    /// Classe dos nós usados na matriz
    /// </summary>
    /// <typeparam name="Dado">Tipo de dado que será armazenado no nó</typeparam>
    class NoListaCruzada<Dado> : IComparable<NoListaCruzada<Dado>> where Dado : IComparable<Dado>
    {
        int col, row;
        Dado info;
        NoListaCruzada<Dado> proxHorz, proxVert;

        /// <summary>
        /// Número da coluna do nó na lista
        /// </summary>
        public int Coluna 
        { 
            get { return this.col; } 
        }

        /// <summary>
        /// Número da linha do nó na lista
        /// </summary>
        public int Linha
        { 
            get { return this.row; } 
        }

        /// <summary>
        /// Informação contida no nó
        /// </summary>
        public Dado Info 
        {
            get { return this.info; }
            set { this.info = value; }
        }

        /// <summary>
        /// Próximo nó da lista na horizontal
        /// </summary>
        public NoListaCruzada<Dado> ProxHorz 
        {
            get { return this.proxHorz; }
            set { this.proxHorz = value; }
        }

        /// <summary>
        /// Próximo nó da lista na vertical
        /// </summary>
        public NoListaCruzada<Dado> ProxVert 
        {
            get { return this.proxVert;  }
            set { this.proxVert = value; }
        }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="col">Número da coluna do nó na matriz</param>
        /// <param name="row">Número da linha do nó na matriz</param>
        /// <param name="info">Dado armazenado no nó</param>
        /// <param name="proxHorz">Próximo nó na horizontal</param>
        /// <param name="proxVert">Próximo nó na vertical</param>
        public NoListaCruzada(int col, int row, Dado info, NoListaCruzada<Dado> proxHorz = null, NoListaCruzada<Dado> proxVert = null) 
        {
            this.col = col;
            this.row = row;
            this.info = info;
            this.proxHorz = proxHorz;
            this.proxVert = proxVert;
        }

        /// <summary>
        /// Compara dois nós
        /// </summary>
        /// <param name="outro">Nó com o qual comparar este</param>
        /// <returns>&gt; 0 se este for maior, 0 se forem iguais e &lt; 0 se este for menor</returns>
        public int CompareTo(NoListaCruzada<Dado> outro)
        {
            return this.info.CompareTo(outro.Info);
        }

        /// <summary>
        /// Converte o objeto em string
        /// </summary>
        /// <returns>Uma representação em string do objeto</returns>
        public override string ToString()
        {
            return this.info.ToString();
        }
    }
}
