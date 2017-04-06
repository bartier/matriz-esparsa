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
        /// Retorna verdadeiro se cabecaPrincipal == null (indica que não há estrutuda da matriz esparsa).
        /// </summary>
        public bool EstaDesalocada
        {
            get { return this.cabecaPrincipal == null; }
        }

        /// <summary>
        /// Construtor da matriz esparsa. Recebe a quantidade de linhas e colunas que
        /// a matriz deverá conter. Cria a estrutura da matriz esparsa (nós-cabeça).
        /// </summary>
        /// <param name="linhas"></param>
        /// <param name="colunas"></param>
        public ListaLigadaCruzada(int linhas, int colunas)
        {
            if (linhas <= 0 || colunas <= 0)
                throw new ArgumentOutOfRangeException("Quantidade de linhas e colunas não podem ser 0 ou negativo.");

            n = linhas;
            m = colunas;

            cabecaPrincipal = new Celula(Convert.ToDouble(null), -1, -1);
            cabecaPrincipal.Direita = cabecaPrincipal;

            // inicia o percurso para criar as linhas da matriz
            Celula atual = cabecaPrincipal;
            for (int i = 0; i < linhas; i++)
            {
                Celula cabeca  = new Celula(Convert.ToDouble(null), i, -1);
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
                Celula cabeca = new Celula(Convert.ToDouble(null), -1, i);
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
            if (linha  < 0 || linha  >= this.Linhas ||
                coluna < 0 || coluna >= this.Colunas)
                throw new ArgumentOutOfRangeException("Linha/Coluna fora do intervalo da matriz para inserir");

            // não será guardado elementos com o ValorPadrao
            if (elemento == ValorPadrao)
                return;

            // percorre as colunas cabeças para achar cabecaColuna
            Celula cabecaColuna = cabecaPrincipal;
            for (int j = 0; j <= coluna; j++)
                cabecaColuna = cabecaColuna.Direita;

            // percorre as linhas cabeças para achar a cabecaLinha
            Celula cabecaLinha = cabecaPrincipal;
            for (int i = 0; i <= linha; i++)
                cabecaLinha = cabecaLinha.Abaixo;

            Celula anterior = cabecaLinha;
            Celula atual    = cabecaLinha.Direita;

            while (atual.Coluna < coluna && atual.Coluna != -1)
            {
                anterior = atual;
                atual = atual.Direita;
            }

            if (ValorDe(linha, coluna) == 0)
            {

                Celula insercao = new Celula(elemento, linha, coluna);

                anterior.Direita = insercao;
                insercao.Direita = atual;


                // percorre a lista circular da coluna para que o último dessa lista
                // comece a apontar para a nova célula inserida
                Celula anteriorColuna = cabecaColuna;
                Celula percursoColuna = cabecaColuna.Abaixo;

                while (percursoColuna.Abaixo != cabecaColuna && percursoColuna.Linha < linha)
                {
                    anteriorColuna = percursoColuna;
                    percursoColuna = percursoColuna.Abaixo;
                }

                insercao.Abaixo = percursoColuna;
                anteriorColuna.Abaixo = insercao;
            }
            else
                atual.Valor = elemento;
        }

        /// <summary>
        /// Lê um arquivo .txt com os dados de uma matriz esparsa.
        /// </summary>
        /// <param name="arquivo"></param>
        public ListaLigadaCruzada LerArquivo(string arquivo)
        {
            StreamReader sr = new StreamReader(arquivo);

            string linhaArq = sr.ReadLine();

            while (linhaArq.Contains("//")) // usado para pular comentários no arquivo
                linhaArq = sr.ReadLine();

            string[] cabecalho = linhaArq.Split(' '); // cabecalho possui as informacoes da coordenada da matriz

            // instancia a matrizEsparsa com as coordenadas no início do arquivo
            ListaLigadaCruzada matrizEsparsa = new ListaLigadaCruzada(Convert.ToInt32(cabecalho[0]), Convert.ToInt32(cabecalho[1]));

            // adiciona as células que estão no arquivo
            while ((linhaArq = sr.ReadLine()) != null)
            {
                if (linhaArq.Contains("//")) // pular comentários
                    continue;

                string[] celula = linhaArq.Split(' ');

                double elemento = Convert.ToDouble(celula[0]);
                int linha = Convert.ToInt32(celula[1]);
                int coluna = Convert.ToInt32(celula[2]);

                matrizEsparsa.InserirElemento(elemento, linha, coluna);
            }
            sr.Close();

            return matrizEsparsa;
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
                linha > Linhas || coluna > Colunas)
                throw new ArgumentOutOfRangeException("Linha e coluna estão foras do intervalo.");

            Celula cabecaLinha = cabecaPrincipal;

            // percorre as linhas
            for (int i = 0; i <= linha; i++)
                cabecaLinha = cabecaLinha.Abaixo;

            // percorre as colunas
            Celula percCol = cabecaLinha.Direita;
            while (percCol.Coluna < coluna && percCol.Direita != cabecaLinha)
                percCol = percCol.Direita;

            if (percCol.Coluna != coluna)
                return ValorPadrao;

            return percCol.Valor;
        }

        /// <summary>
        /// Remove uma célula onde está linha/coluna.
        /// </summary>
        /// <param name="linha"></param>
        /// <param name="coluna"></param>
        public bool RemoverEm(int linha, int coluna)
        {
            if (linha < 0  || linha >= this.Linhas ||
                coluna < 0 || coluna >= this.Colunas)
                throw new ArgumentOutOfRangeException("Linha/Coluna fora do intervalo de remoção");

            // não há célula para remover
            if (ValorDe(linha, coluna) == ValorPadrao)
                return false;

            // percorre as colunas cabeças para achar cabecaColuna
            Celula cabecaColuna = cabecaPrincipal;
            for (int j = 0; j <= coluna; j++)
                cabecaColuna = cabecaColuna.Direita;

            // percorre as linhas cabeças para achar a cabecaLinha
            Celula cabecaLinha = cabecaPrincipal;
            for (int i = 0; i <= linha; i++)
                cabecaLinha = cabecaLinha.Abaixo;

            Celula anterior = cabecaLinha;
            Celula atual    = cabecaLinha.Direita; // atual posiciona na célula que será removida

            while (atual.Coluna < coluna && atual.Coluna != -1)
            {
                anterior = atual;
                atual = atual.Direita;
            }

            anterior.Direita = atual.Direita;

            // percorre as colunas para acertar as ligacoes
            Celula percCol = cabecaColuna;
            while (percCol.Abaixo != atual)
                percCol = percCol.Abaixo;

            percCol.Abaixo = atual.Abaixo;

            //atual = null;
            return true;
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
            gridView.Columns.Clear();
            gridView.Rows.Clear();

            // cria o cabecalho das colunas da matriz
            for (int i = 0; i < this.Colunas; i++)
                gridView.Columns.Add(i.ToString(), i.ToString());



            string[] linha = new string[this.Colunas];

            //gridView.RowHeadersWidth = 50;

            // percorre os valores das linhas e insere no gridView
            for (int j = 0; j < this.Linhas; j++)
            {
                for (int k = 0; k < this.Colunas; k++)
                {
                    linha[k] = this.ValorDe(j, k).ToString();
                }
                gridView.Rows.Add(linha);
                gridView.Rows[j].HeaderCell.Value = j.ToString();
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

            // matriz não existe mais, não há mais linhas
            n = 0;
            m = 0;
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

        /// <summary>
        /// Representa a matriz esparsa com as células que são diferentes de ValorPadrao.
        /// </summary>
        /// <returns>String com o valor e as coordenadas das células diferente de ValorPadrao.</returns>
        public override string ToString()
        {
            String ret = "{ ";

            Celula cabecaLinha = cabecaPrincipal.Abaixo;

            while (cabecaLinha != cabecaPrincipal)
            {
                Celula percLinha = cabecaLinha.Direita;
                while (percLinha != cabecaLinha)
                {
                    ret += percLinha.ToString() + (percLinha.Direita != cabecaLinha ? ", " : " ");

                    percLinha = percLinha.Direita;
                }

                cabecaLinha = cabecaLinha.Abaixo;
            }
            return ret + "}";
        }

    }
}
