﻿using System;
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
            if (linhas <= 0 || colunas <= 0)
                throw new ArgumentOutOfRangeException("Linhas/Colunas não podem ser negativas ou 0");

            n = linhas;
            m = colunas;

            cabecaPrincipal = new Celula(Convert.ToDouble(null), -1, -1);
            cabecaPrincipal.Direita = cabecaPrincipal;

            // inicia o percurso para criar as linhas da matriz
            Celula atual = cabecaPrincipal;
            for (int i = 0; i < linhas; i++)
            {
                Celula cabeca = new Celula(Convert.ToDouble(null), -1, Convert.ToInt32(null));
                cabeca.Direita = cabeca;

                atual.Abaixo  = cabeca;
                atual         = atual.Abaixo;
            }
            // aponta para a primeira cabeca criando a lista circular
            atual.Abaixo = cabecaPrincipal;
            
            // inicia o outro percurso para criar as colunas da matriz
            atual = cabecaPrincipal;
            for (int i = 0; i < colunas; i++)
            {
                Celula cabeca = new Celula(Convert.ToDouble(null), Convert.ToInt32(null), -1);
                cabeca.Abaixo = cabeca;

                // necessita verificar se é a cabecaPrincipal para não perder
                // a lista circular de linhas
                if (atual != cabecaPrincipal)
                    atual.Abaixo = atual;

                atual.Direita = cabeca;
                atual         = atual.Direita;
            }
            // aponta para a primeira cabeca criando a lista circular
            atual.Direita = cabecaPrincipal;
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
            if (linha <= 0 || linha > this.Linhas ||
                coluna <= 0 || coluna > this.Colunas)
                throw new ArgumentOutOfRangeException("Linha/Coluna fora do intervalo da matriz para inserir");

            // percorre as colunas cabeças para achar cabecaColuna
            Celula cabecaColuna = cabecaPrincipal;
            for (int j = 0; j < coluna; j++)
                cabecaColuna = cabecaColuna.Direita;

            // percorre as linhas cabeças para achar a cabecaLinha
            Celula cabecaLinha = cabecaPrincipal;
            for (int i = 0; i < linha; i++)
                cabecaLinha = cabecaLinha.Abaixo;
            
            Celula anterior = cabecaLinha;
            Celula atual    = cabecaLinha.Direita;

            if (atual!=anterior)
                while (atual.Coluna < coluna) 
                {
                    anterior = atual;
                    atual = atual.Direita;
                }

            Celula insercao = new Celula(elemento, linha, coluna);

            anterior.Direita = insercao;
            insercao.Direita = atual;
            insercao.Abaixo = cabecaColuna;


            // percorre a lista circular da coluna para que o último dessa lista
            // comece a apontar para a nova célula inserida
            Celula percursoColuna = cabecaColuna.Abaixo;
            while (percursoColuna.Abaixo != cabecaColuna)
                percursoColuna = percursoColuna.Abaixo;

            percursoColuna.Abaixo = insercao;
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
            if (linha <= 0 || coluna <= 0 ||
                linha > Linhas || coluna > Colunas)
                throw new ArgumentOutOfRangeException("Linha e coluna estão foras do intervalo.");

            Celula celula = cabecaPrincipal;

            // percorre as linhas
            for (int i = 0; i < linha; i++)
                celula = celula.Abaixo;

            // percorre as colunas
            for (int j = 0; j < coluna; j++)
            {
                // se a cabeca aponta para ela mesma não há células guardadas nesta linha
                if (celula.Direita == celula)
                    return ValorPadrao;

                // se a coluna desejada for encontrada retornará o valor
                if (celula.Coluna == coluna)
                    return celula.Valor;

                // se a célula da matriz estiver numa coluna maior que a coluna da célula buscada
                // a célula não está sendo guardada, portanto retorna o valor padrão.
                if (celula.Coluna > coluna)
                    return ValorPadrao;

                // se a coluna da célula for menor que a coluna da célula procurada avança-se até ser igual, maior ou menor
                if (celula.Coluna < coluna)
                    celula = celula.Direita;
            }
            return ValorPadrao;
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

        public override string ToString()
        {
            String ret = "{ ";

            Celula cabecaLinha = cabecaPrincipal.Abaixo;

            while (cabecaLinha != cabecaPrincipal)
            {
                Celula percLinha = cabecaLinha.Direita;
                while (percLinha != cabecaLinha)
                {
                    ret += "(" + percLinha.Linha + "," + percLinha.Coluna +  "," + percLinha.Valor + ")" + (percLinha.Direita!=cabecaLinha? " , " : " ");

                    percLinha = percLinha.Direita;
                }

                cabecaLinha = cabecaLinha.Abaixo;
            }
            return ret + "}";
        }

    }
}
