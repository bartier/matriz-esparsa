// RA: 16163 - Davi Oliveira da Silva
// RA: 16196 - Vitor Menezes Bartier dos Anjos
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MatrizEsparsa
{
    public partial class frmOperacoes : Form
    {
        frmMatrizEsparsa frmPrincipal;

        ListaLigadaCruzada matrizEsparsa1, matrizEsparsa2, matrizEsparsa3;

        public frmOperacoes(frmMatrizEsparsa frm)
        {
            InitializeComponent();
            frmPrincipal = frm;
        }

        private void LerMatriz(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);

                string linhaArquivo = sr.ReadLine();

                while (linhaArquivo.Contains("//")) // usado para pular comentários no arquivo
                    linhaArquivo = sr.ReadLine();

                string[] coordenadas = linhaArquivo.Split(' ');

                int linhas = Convert.ToInt32(coordenadas[0]);
                int colunas = Convert.ToInt32(coordenadas[1]);

                switch (Convert.ToInt32(((Button)sender).Tag))
                {
                    case 0:
                        {
                            matrizEsparsa1 = new ListaLigadaCruzada(linhas, colunas);
                            break;
                        }
                    case 1:
                        {
                            matrizEsparsa2 = new ListaLigadaCruzada(linhas, colunas);
                            break;
                        }
                }

                while ((linhaArquivo = sr.ReadLine()) != null)
                {
                    if (linhaArquivo.Contains("//")) // pular comentários durante a inserção de células
                        continue;

                    string[] celula = linhaArquivo.Split(' ');

                    double elemento = Convert.ToDouble(celula[0]);
                    int linha = Convert.ToInt32(celula[1]);
                    int coluna = Convert.ToInt32(celula[2]);

                    switch (Convert.ToInt32(((Button)sender).Tag))
                    {
                        case 0 :
                            {
                                matrizEsparsa1.InserirElemento(elemento, linha, coluna);

                                // Atualiza os campos necessários
                                numLinhaInsercaoMatriz1.Maximum = matrizEsparsa1.Linhas - 1;
                                numColunaInsercaoMatriz1.Maximum = matrizEsparsa1.Colunas - 1;

                                numLinhasMatriz1.Value = matrizEsparsa1.Linhas;
                                numColunasMatriz1.Value = matrizEsparsa1.Colunas;

                                matrizEsparsa1.ExibirDataGridView(dgMatrizEsparsa1);
                                break;
                            }

                        case 1 :
                            {
                                matrizEsparsa2.InserirElemento(elemento, linha, coluna);

                                // Atualiza os campos necessários
                                numLinhaInsercaoMatriz2.Maximum = matrizEsparsa2.Linhas - 1;
                                numColunaInsercaoMatriz2.Maximum = matrizEsparsa2.Colunas - 1;

                                numLinhasMatriz2.Value = matrizEsparsa2.Linhas;
                                numColunasMatriz2.Value = matrizEsparsa2.Colunas;

                                matrizEsparsa2.ExibirDataGridView(dgMatrizEsparsa2);
                                break;
                            }
                    }
                    
                }
                sr.Close();
            }
        }

        private void SomarMatrizes(object sender, EventArgs e)
        {
            if (!matrizEsparsa1.EstaDesalocada && !matrizEsparsa2.EstaDesalocada &&
                matrizEsparsa1.Colunas==matrizEsparsa2.Colunas && matrizEsparsa1.Linhas==matrizEsparsa2.Linhas)
            {
                matrizEsparsa3 = matrizEsparsa1.SomarMatrizes(matrizEsparsa2);
                matrizEsparsa3.ExibirDataGridView(dgMatrizEsparsa3);

                // atualiza campos necessários
                numLinhasMatriz3.Value  = matrizEsparsa3.Linhas;
                numColunasMatriz3.Value = matrizEsparsa3.Colunas;
            }
            else
                MessageBox.Show("Não é possível somar as matrizes atuais. Verifique se as coordenadas da matriz 1 é igual as coordenadas da matriz 2.",
                                "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MultiplicarMatrizes(object sender, EventArgs e)
        {
            if (!matrizEsparsa1.EstaDesalocada && !matrizEsparsa2.EstaDesalocada && numLinhasMatriz1.Value == numColunasMatriz2.Value)
            {
                matrizEsparsa3 = matrizEsparsa1.MultiplicarMatrizes(matrizEsparsa2);
                matrizEsparsa3.ExibirDataGridView(dgMatrizEsparsa3);
            }
            else
                MessageBox.Show("Não é possível multiplicar as matrizes atuais. Verifique se as linhas da matriz 1 é igual as colunas da matriz 2.",
                                "Atenção:", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCelulasGuardadasMatrizEsparsa3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(matrizEsparsa3.ToString());
        }

        private void InserirElemento(object sender, EventArgs e)
        {
            double elemento;
            switch (Convert.ToInt32(((Button)sender).Tag))
            {
                case 0:
                    {
                        if (double.TryParse(txtElementoInsercaoMatriz1.Text, out elemento) && elemento != 0 &&
    						numLinhaInsercaoMatriz1.Value >= 0 && numColunaInsercaoMatriz1.Value >= 0 && !matrizEsparsa1.EstaDesalocada)
                        {
                            int linha  = Convert.ToInt32(numLinhaInsercaoMatriz1.Value);
                            int coluna = Convert.ToInt32(numColunaInsercaoMatriz1.Value);

                            matrizEsparsa1.InserirElemento(elemento, linha, coluna);
                            matrizEsparsa1.ExibirDataGridView(dgMatrizEsparsa1);
                        }
                        else
                            MessageBox.Show("Não é possível inserir um elemento na matriz! " +
                                            " Verifique se os valores dos campos de inserção são válidos ou se há uma matriz.",
                                            "Atenção!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                case 1:
                    {
                        if (double.TryParse(txtElementoInsercaoMatriz2.Text, out elemento) && elemento != 0 &&
							numLinhaInsercaoMatriz2.Value >= 0 && numColunaInsercaoMatriz2.Value >= 0 && !matrizEsparsa2.EstaDesalocada)
                        {
                            int linha  = Convert.ToInt32(numLinhaInsercaoMatriz2.Value);
                            int coluna = Convert.ToInt32(numColunaInsercaoMatriz2.Value);

                            matrizEsparsa2.InserirElemento(elemento, linha, coluna);
                            matrizEsparsa2.ExibirDataGridView(dgMatrizEsparsa2);
                        }
                        else
                            MessageBox.Show("Não é possível inserir um elemento na matriz! " +
                                            " Verifique se os valores dos campos de inserção são válidos ou se há uma matriz.",
                                            "Atenção!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                case 2:
                    {
                        if (double.TryParse(txtElementoInsercaoMatriz3.Text, out elemento) && elemento != 0 &&
							numLinhaInsercaoMatriz3.Value >= 0 && numColunaInsercaoMatriz3.Value >= 0 && !matrizEsparsa3.EstaDesalocada)
                        {
                            int linha  = Convert.ToInt32(numLinhaInsercaoMatriz3.Value);
                            int coluna = Convert.ToInt32(numColunaInsercaoMatriz3.Value);

                            matrizEsparsa3.InserirElemento(elemento, linha, coluna);
                            matrizEsparsa3.ExibirDataGridView(dgMatrizEsparsa3);
                        }
                        else
                            MessageBox.Show("Não é possível inserir um elemento na matriz! " +
                                            " Verifique se os valores dos campos de inserção são válidos ou se há uma matriz.",
                                            "Atenção!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }
        }

        private void CriarMatriz(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(((Button)sender).Tag))
            {
                case 0 :
                    {
                        if (numColunasMatriz1.Value > 0 && numLinhasMatriz1.Value > 0)
                        {
                            int linhas  = Convert.ToInt32(numLinhasMatriz1.Value);
                            int colunas = Convert.ToInt32(numColunasMatriz1.Value);

                            matrizEsparsa1 = new ListaLigadaCruzada(linhas, colunas);
                            matrizEsparsa1.ExibirDataGridView(dgMatrizEsparsa1);

                            // atualiza os campos necessários
                            numLinhaInsercaoMatriz1.Maximum  = matrizEsparsa2.Linhas - 1;
                            numColunaInsercaoMatriz1.Maximum = matrizEsparsa2.Colunas - 1;
                        }
                        else
                            MessageBox.Show("Não é possível criar a matriz com esses valores! " +
                                            " Verifique se os valores das linhas e colunas são válidos.",
                                            "Atenção!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                case 1:
                    {
                        if (numColunasMatriz2.Value > 0 && numLinhasMatriz2.Value > 0)
                        {
                            int linhas  = Convert.ToInt32(numLinhasMatriz2.Value);
                            int colunas = Convert.ToInt32(numColunasMatriz2.Value);

                            matrizEsparsa2 = new ListaLigadaCruzada(linhas, colunas);
                            matrizEsparsa2.ExibirDataGridView(dgMatrizEsparsa2);

                            // atualiza os campos necessários
                            numLinhaInsercaoMatriz2.Maximum  = matrizEsparsa2.Linhas - 1;
                            numColunaInsercaoMatriz2.Maximum = matrizEsparsa2.Colunas - 1;
                        }
                        else
                            MessageBox.Show("Não é possível criar a matriz com esses valores! " +
                                            " Verifique se os valores das linhas e colunas são válidos.",
                                            "Atenção!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }
        }

        private void frmOperacoes_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPrincipal.Show();
        }

        private void frmOperacoes_Load(object sender, EventArgs e)
        {
            // linhas e colunas iniciarão com o valor 1
            int linhas  = 1;
            int colunas = 1;

            // matrizes do formuláro iniciarão com 1 linha e 1 coluna
            matrizEsparsa1 = new ListaLigadaCruzada(linhas, colunas);
            matrizEsparsa2 = new ListaLigadaCruzada(linhas, colunas);
            matrizEsparsa3 = new ListaLigadaCruzada(linhas, colunas);

            matrizEsparsa1.ExibirDataGridView(dgMatrizEsparsa1);
            matrizEsparsa2.ExibirDataGridView(dgMatrizEsparsa2);
            matrizEsparsa3.ExibirDataGridView(dgMatrizEsparsa3);
        }
    }
}
