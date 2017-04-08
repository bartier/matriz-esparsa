using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizEsparsa
{
    class Celula
    {
        private double? valor;
        private int linha, coluna;
        private Celula direita, abaixo;

        /// <summary>
        /// Cria uma célula contendo um valor numa determinada coordenada de linha/coluna.
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="linha"></param>
        /// <param name="coluna"></param>
        public Celula(double? valor, int linha, int coluna)
        {
            Valor = valor;
            Linha = linha;
            Coluna = coluna;
        }

        /// <summary>
        /// O valor que a célula guarda.
        /// </summary>
        public double? Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        /// <summary>
        /// A linha que a célula se encontra.
        /// </summary>
        public int Linha
        {
            get { return linha; }
            set { linha = value; }
        }

        /// <summary>
        /// A coluna que a célula se encontra.
        /// </summary>
        public int Coluna
        {
            get { return coluna; }
            set { coluna = value; }
        }

        /// <summary>
        /// Acesso a celula da direita.
        /// </summary>
        public Celula Direita
        {
            get {  return direita; }
            set { direita = value; }
        }

        /// <summary>
        /// Acesso a celula debaixo.
        /// </summary>
        public Celula Abaixo
        {
            get { return abaixo; }
            set { abaixo = value; }
        }

        /// <summary>
        /// Representa a célula na string: (valor, linha, coluna).
        /// </summary>
        /// <returns>(valor, linha, coluna)</returns>
        public override string ToString()
        {
            String ret = "(";

            ret += (this.Valor==null? (double?)0 : this.Valor) + ";" + this.Linha + ";" + this.Coluna;

            return ret + ")";
        }
    }
}