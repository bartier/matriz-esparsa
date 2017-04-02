using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrizEsparsa
{
    class ListaLigadaCruzada
    {
        // n = linhas
        // m = colunas
        int n, m;

        Celula cabecaPrincipal;

        // valor padrão quando não guarda-se uma célula.
        public static int ValorPadrao = 0;

        /// <summary>
        /// Retorna o número de linhas que a matriz esparsa contém.
        /// </summary>
        public int Linhas
        {
            get { return n; }
        }

        /// <summary>
        /// Retorna o número de colunas que a matriz esparsa contém.
        /// </summary>
        public int Colunas
        {
            get { return m; }
        }

        /// <summary>
        /// Construtor da matriz esparsa. Recebe a quantidade de linhas e colunas que
        /// a matriz deverá conter.
        /// </summary>
        /// <param name="linhas"></param>
        /// <param name="colunas"></param>
        public ListaLigadaCruzada(int linhas, int colunas)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Insere uma célula com um valor passado como parâmetro na linha e coluna especificados.
        /// </summary>
        /// <param name="elemento"></param>
        /// <param name="linha"></param>
        /// <param name="coluna"></param>
        /// <remarks>Cria uma célula no lugar que conterá o valor.</remarks>
        public void InserirElemento(double elemento, int linha, int coluna)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lê um arquivo .txt com os dados de uma matriz esparsa.
        /// </summary>
        /// <param name="arquivo"></param>
        public void LerArquivo(string arquivo)
        {
            throw new NotImplementedException();

            //StreamReader sr = new StreamReader(arquivo);

            //string linha;
            //while ((linha = sr.ReadLine()) != null)
            //{

            //}
            //sr.Close();
        }

        /// <summary>
        /// Retorna o valor de uma célula no lugar da linha/coluna.
        /// </summary>
        /// <param name="linha"></param>
        /// <param name="coluna"></param>
        /// <returns>Valor double contido na célula.</returns>
        public double ValorDe(int linha, int coluna)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Remove uma célula onde está linha/coluna.
        /// </summary>
        /// <param name="linha"></param>
        /// <param name="coluna"></param>
        public void RemoverEm(int linha, int coluna)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Soma em todas as células o valor da constante K.
        /// </summary>
        /// <param name="k"></param>
        /// <param name="coluna"></param>
        public void SomarEmTodos(double k, int coluna)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Representa em um componente DataGridView a matriz esparsa.
        /// </summary>
        /// <param name="gridView"></param>
        public void ExibirDataGridView(DataGridView gridView)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Exclui a matriz e desaloca da memória as células.
        /// </summary>
        public void ApagarMatriz()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Faz a soma de duas matrizes esparsas.
        /// </summary>
        /// <param name="outraMatriz"></param>
        /// <returns>Uma matriz esparsa representando a soma.</returns>
        public ListaLigadaCruzada SomarMatrizes(ListaLigadaCruzada outraMatriz)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Faz a multiplicação de duas matrizes esparsas.
        /// </summary>
        /// <param name="outraMatriz"></param>
        /// <returns>Uma matriz esparsa representando a multiplicação.</returns>
        public ListaLigadaCruzada MultiplicarMatrizes(ListaLigadaCruzada outraMatriz)
        {
            throw new NotImplementedException();
        }

    }
}
