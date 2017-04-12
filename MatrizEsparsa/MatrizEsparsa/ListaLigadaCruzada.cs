﻿// RA: 16163 - Davi Oliveira da Silva
// RA: 16196 - Vitor Menezes Bartier dos Anjos
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
        int linhas, colunas;
        Celula cabecaPrincipal;

        // Retorno quando a célula não está guardada na matriz esparsa
        public static int ValorPadrao = 0;

        /// <summary>
        /// Retorna o número de linhas que a matriz esparsa contém.
        /// </summary>
        public int Linhas
        {
            get { return linhas; }
        }

        /// <summary>
        /// Retorna o número de colunas que a matriz esparsa contém.
        /// </summary>
        public int Colunas
        {
            get { return colunas; }
        }

        /// <summary>
        /// Retorna verdadeiro se cabecaPrincipal == null (indica que não há estrutuda da matriz esparsa).
        /// </summary>
        public bool EstaDesalocada
        {
            get { return this.cabecaPrincipal == null; }
        }

        /// <summary>
        /// Construtor da matriz esparsa. Recebe a quantidade de linhas e colunas que
        /// a matriz deverá conter. Cria a estrutura da matriz esparsa (células cabeça).
        /// </summary>
        /// <param name="linhas"></param>
        /// <param name="colunas"></param>
        public ListaLigadaCruzada(int linhas, int colunas)
        {
            if (linhas <= 0 || colunas <= 0)
                throw new ArgumentOutOfRangeException("Quantidade de linhas/colunas não podem ser 0 ou negativo.");

            this.linhas  = linhas;
            this.colunas = colunas;

            cabecaPrincipal = new Celula(null, -1, -1);

            // inicia o percurso para criar as linhas da matriz
            Celula percurso = cabecaPrincipal;

            for (int i = 0; i < linhas; i++)
            {
                Celula linhaCabeca  = new Celula(null, i, -1);

                percurso.Abaixo  = linhaCabeca;
                percurso.Direita = percurso;
                percurso         = percurso.Abaixo;
            }
            percurso.Abaixo  = cabecaPrincipal;
            percurso.Direita = percurso;

            // inicia outro percurso para criar as colunas da matriz
            percurso = cabecaPrincipal;

            for (int i = 0; i < colunas; i++)
            {
                Celula colunaCabeca = new Celula(null, -1, i);

                // verifica se é a cabecaPrincipal para não perder
                // a lista das linhas
                if (percurso != cabecaPrincipal)
                    percurso.Abaixo = percurso;

                percurso.Direita = colunaCabeca;
                percurso         = percurso.Direita;
            }
            percurso.Abaixo  = percurso;
            percurso.Direita = cabecaPrincipal;
        }

        /// <summary>
        /// Insere uma célula com um valor passado como parâmetro na linha e coluna especificados.
        /// </summary>
        /// <param name="elemento"></param>
        /// <param name="linha"></param>
        /// <param name="coluna"></param>
        /// <remarks>Cria uma célula no lugar que conterá o valor diferente de 0.</remarks>
        public void InserirElemento(double elemento, int linha, int coluna)
        {
            if (linha  < 0 || linha  >= this.Linhas ||
                coluna < 0 || coluna >= this.Colunas)
                throw new ArgumentOutOfRangeException("Linha/Coluna estão fora do intervalo de inserção.");

            // não será guardado elementos com o ValorPadrao
            if (elemento == ValorPadrao)
                throw new ArgumentException("O elemento de inserção não deve ser 0.");

            Celula colunaCabeca = cabecaPrincipal;
            Celula linhaCabeca  = cabecaPrincipal;

            for (int j = 0; j <= coluna; j++)
                colunaCabeca = colunaCabeca.Direita;
            
            for (int i = 0; i <= linha; i++) 
                linhaCabeca = linhaCabeca.Abaixo;

            Celula anterior = linhaCabeca;
            Celula atual    = linhaCabeca.Direita;

            while (atual.Coluna < coluna && atual.Coluna != -1)
            {
                anterior = atual;
                atual    = atual.Direita;
            }

            if (ValorDe(linha, coluna) == 0)
            {

                Celula insercao = new Celula(elemento, linha, coluna);

                anterior.Direita = insercao;
                insercao.Direita = atual;

                Celula colunaAnterior = colunaCabeca;
                Celula percursoColuna = colunaCabeca.Abaixo;

                while (percursoColuna.Abaixo != colunaCabeca && percursoColuna.Linha < linha)
                {
                    colunaAnterior = percursoColuna;
                    percursoColuna = percursoColuna.Abaixo;
                }
                insercao.Abaixo       = percursoColuna;
                colunaAnterior.Abaixo = insercao;
            }
            else
                atual.Valor = elemento; // apenas altera o valor da célula já existente
        }

        /// <summary>
        /// Retorna o valor de uma célula no lugar da linha/coluna.
        /// </summary>
        /// <param name="linha"></param>
        /// <param name="coluna"></param>
        /// <returns>Valor double contido na célula.</returns>
        public double ValorDe(int linha, int coluna)
        {
            if (linha < 0 || coluna < 0 ||
                linha >= Linhas || coluna >= Colunas)
                throw new ArgumentOutOfRangeException("Linha ou coluna estão foras do intervalo de pesquisa.");

            Celula linhaCabeca = cabecaPrincipal;

            for (int i = 0; i <= linha; i++)
                linhaCabeca = linhaCabeca.Abaixo;

            // percorre as colunas da linha para posicionar na célula e retornar o valor correspondente
            Celula percursoColuna = linhaCabeca.Direita;

            while (percursoColuna.Coluna < coluna && percursoColuna.Direita != linhaCabeca)
                percursoColuna = percursoColuna.Direita;

            if (percursoColuna.Coluna != coluna)
                return ValorPadrao;

            return (double)percursoColuna.Valor;
        }

        /// <summary>
        /// Remove uma célula onde está linha/coluna.
        /// </summary>
        /// <param name="linha"></param>
        /// <param name="coluna"></param>
        public bool RemoverEm(int linha, int coluna)
        {
            if (linha  < 0  || linha  >= Linhas ||
                coluna < 0  || coluna >= Colunas)
                throw new ArgumentOutOfRangeException("Linha ou Coluna fora do intervalo de remoção");
            
            if (ValorDe(linha, coluna) == ValorPadrao)
                return false; // não há nada para remover

            Celula colunaCabeca = cabecaPrincipal;
            Celula linhaCabeca  = cabecaPrincipal;

            for (int j = 0; j <= coluna; j++)
                colunaCabeca = colunaCabeca.Direita;

            for (int i = 0; i <= linha; i++)
                linhaCabeca = linhaCabeca.Abaixo;

            Celula anterior = linhaCabeca;
            Celula atual    = linhaCabeca.Direita; // atual posicionará na célula que será removida

            while (atual.Coluna < coluna && atual.Coluna != -1)
            {
                anterior = atual;
                atual = atual.Direita;
            }

            anterior.Direita = atual.Direita;

            // percorre as colunas para acertar as ligações necessárias
            Celula percursoColuna = colunaCabeca;

            while (percursoColuna.Abaixo != atual)
                percursoColuna = percursoColuna.Abaixo;

            percursoColuna.Abaixo = atual.Abaixo;

            return true;
        }

        /// <summary>
        /// Soma o valor K a todos os elementos da coluna
        /// </summary>
        /// <param name="k">Valor que será somado na célula das colunas</param>
        /// <param name="coluna">Coluna que será somada</param>
        public void SomarNaColuna(double k, int coluna)
        {
            if (coluna < 0 || coluna >= Colunas)
                throw new ArgumentException("Coluna inválida.");

            if (k == 0)
                throw new ArgumentException("Verifique se K é diferente de 0.");

            double elementoAtual = 0;
            for (int i=0; i<Linhas; i++)
            {
                elementoAtual = ValorDe(i, coluna);
                if (elementoAtual + k == 0)
                {
                    RemoverEm(i, coluna);
                    continue;
                }
                InserirElemento(elementoAtual + k, i, coluna);
            }
        }

        /// <summary>
        /// Representa em um componente DataGridView a matriz esparsa.
        /// </summary>
        /// <param name="gridView"></param>
        public void ExibirDataGridView(DataGridView gridView)
        {
            // A matriz esparsa pode ser representada em vários componentes de DataGridView, portanto
            // foi dado a responsabilidade para a classe ListaLigadaCruzada para inserir no componente
            // os valores das células. A leitura, sendo possível de vários arquivos (.txt, .xml, etc) foi
            // mantido a responsabilidade para a aplicação.

            if (gridView == null)
                throw new ArgumentException("gridView utilizado é nulo.");

            gridView.Columns.Clear();
            gridView.Rows.Clear();

            // cria o cabeçalho das colunas
            for (int i = 0; i < this.Colunas; i++)
                gridView.Columns.Add(i.ToString(), i.ToString());

            string[] linhaMatriz = new string[this.Colunas];

            // percorre as linhas da matriz e insere no gridView
            for (int j = 0; j < this.Linhas; j++)
            {
                for (int k = 0; k < this.Colunas; k++)
                {
                    linhaMatriz[k] = this.ValorDe(j, k).ToString();
                }
                gridView.Rows.Add(linhaMatriz);
                gridView.Rows[j].HeaderCell.Value = j.ToString(); // adiciona cabeçalho da linha
            }
            gridView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders);
            gridView.AutoResizeColumns();
        }

        /// <summary>
        /// Exclui a matriz e desaloca da memória as células.
        /// </summary>
        public void ApagarMatriz()
        {
            cabecaPrincipal = null;
            linhas          = 0;
            colunas         = 0;
        }

        /// <summary>
        /// Faz a soma de duas matrizes esparsas.
        /// </summary>
        /// <param name="outraMatriz"></param>
        /// <returns>Uma matriz esparsa representando a soma.</returns>
        public ListaLigadaCruzada SomarMatrizes(ListaLigadaCruzada outraMatriz)
        {
            if (this.linhas != outraMatriz.linhas || this.colunas != outraMatriz.colunas)
                throw new ArgumentException("As Matrizes dever ser de mesma dimensão!");

            ListaLigadaCruzada soma = new ListaLigadaCruzada(this.linhas, this.colunas);

            Celula atual = this.cabecaPrincipal.Abaixo.Direita;

            // Copia a matriz this na matriz soma
            for (int l = 0; l < this.linhas; l++)
            {
                for (int c = atual.Coluna; c >= 0; c = atual.Coluna)
                {
                    if (atual.Valor != null)
                    {
                        atual = atual.Direita;
                        soma.InserirElemento(this.ValorDe(l, c), l, c);
                    }
                }
                atual = atual.Abaixo.Direita;
            }

            atual = outraMatriz.cabecaPrincipal.Abaixo.Direita;

            for (int l = 0; l < outraMatriz.linhas; l++)
            {
                for (int c = atual.Coluna; c >= 0; c = atual.Coluna)
                    if (atual.Valor != null)
                    {
                        double elem = soma.ValorDe(l, c) != 0 ? soma.ValorDe(l, c) + outraMatriz.ValorDe(l, c)
                                                                : outraMatriz.ValorDe(l, c);

                        soma.InserirElemento(elem, l, c);
                        atual = atual.Direita;
                    }
                atual = atual.Abaixo.Direita;
            }

            return soma;
        }

        /// <summary>
        /// Faz a multiplicação de duas matrizes esparsas.
        /// </summary>
        /// <param name="outraMatriz"></param>
        /// <returns>Uma matriz esparsa representando a multiplicação.</returns>
        public ListaLigadaCruzada MultiplicarMatrizes(ListaLigadaCruzada outraMatriz)
        {
            if (this.Colunas != outraMatriz.Linhas)
                throw new ArgumentException("Número de colunas de uma matriz deve ser igual o número de linhas da outra");

            ListaLigadaCruzada matrizResultado;

            matrizResultado = new ListaLigadaCruzada(this.Linhas, outraMatriz.Colunas);


            double total = 0;
            for (int i = 0; i < this.Linhas; i++)
            {
                for (int j = 0; j < outraMatriz.Colunas; j++)
                {
                    total = 0;
                    int k;
                    for (k = 0; k < this.Colunas; k++)
                    {
                        total += this.ValorDe(i, k) * outraMatriz.ValorDe(k, j);
                    }
                    if (total != 0)
                    {
                        matrizResultado.InserirElemento(total, i, j);
                    }
                }
            }

            return matrizResultado;
        }

        /// <summary>
        /// Representa a matriz esparsa com as células que são diferentes de ValorPadrao.
        /// </summary>
        /// <returns>String com o valor e as coordenadas das células diferente de ValorPadrao.</returns>
        public override string ToString()
        {
            String ret = "{ ";

            Celula linhaCabeca = cabecaPrincipal.Abaixo;

            while (linhaCabeca != cabecaPrincipal)
            {
                Celula percursoLinha = linhaCabeca.Direita;

                while (percursoLinha != linhaCabeca)
                {
                    ret += percursoLinha.ToString() + (percursoLinha.Direita != linhaCabeca ? ", " : " ");

                    percursoLinha = percursoLinha.Direita;
                }

                linhaCabeca = linhaCabeca.Abaixo;
            }
            return ret + "}";
        }
    }
}
