using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrizEsparsa
{
    public partial class frmMatrizEsparsa : Form
    {
        ListaLigadaCruzada matrizEsparsa;

        public frmMatrizEsparsa()
        {
            InitializeComponent();
        }

        private void frmMatrizEsparsa_Load(object sender, EventArgs e)
        {
            // linhas e colunas iniciarão com o valor 1 (respectivos NumericUpDown)
            int linhas  = Convert.ToInt32(numLinhas.Value);
            int colunas = Convert.ToInt32(numColunas.Value);

            // primeira matriz do programa terá 1 linha e 1 coluna
            matrizEsparsa = new ListaLigadaCruzada(linhas, colunas);
            matrizEsparsa.ExibirDataGridView(dgMatrizEsparsa);
        }

        private void btnLerArquivo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O arquivo deve conter as coordenadas que a matriz terá e depois"    +
                            " as células diferentes de 0 (elemento, linha, coluna). Exemplo: \n" + 
                            " 3 3 \n 10 0 0 \n 15 0 2", "Orientações de arquivo de matriz esparsa:", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                matrizEsparsa = matrizEsparsa.LerArquivo(openFileDialog1.FileName);

                // atualiza os campos necessários
                numLinhas.Value  = matrizEsparsa.Linhas;
                numColunas.Value = matrizEsparsa.Colunas;

                numLinhaPesquisa.Maximum  = numLinhaInsercao.Maximum  = matrizEsparsa.Linhas  - 1;
                numColunaPesquisa.Maximum = numColunaInsercao.Maximum = matrizEsparsa.Colunas - 1;

                matrizEsparsa.ExibirDataGridView(dgMatrizEsparsa);
            }            
        }

        private void btnCriarMatrizEsparsa_Click(object sender, EventArgs e)
        {
            if (numColunas.Value >0 && numLinhas.Value >0 && numColunas.Value<656 && numLinhas.Value<656)
            {
                int linhas  = Convert.ToInt32(numLinhas.Text);
                int colunas = Convert.ToInt32(numColunas.Text);

                matrizEsparsa = new ListaLigadaCruzada(linhas, colunas);
                matrizEsparsa.ExibirDataGridView(dgMatrizEsparsa);

                // atualiza os campos necessários
                numLinhaRemocao.Maximum  = numLinhaPesquisa.Maximum  = numLinhaInsercao.Maximum  = matrizEsparsa.Linhas -1;
                numColunaSoma.Maximum    = numColunaRemocao.Maximum  = numColunaPesquisa.Maximum = numColunaInsercao.Maximum = matrizEsparsa.Colunas -1;
                
                matrizEsparsa.ExibirDataGridView(dgMatrizEsparsa);
            }
            else
                MessageBox.Show("Não é possível criar uma matriz esparsa! Verifique os valores dos campos de linha/coluna", "Atenção!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RA: 16163 - Davi Oliveira \nRA: 16196 - Vitor Bartier", "Sobre:",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInserirElemento_Click(object sender, EventArgs e)
        {
            double elemento;

            if (double.TryParse(txtElementoInsercao.Text, out elemento) && elemento != 0 &&
                numLinhaInsercao.Value>=0  && numColunaInsercao.Value>=0 && !matrizEsparsa.EstaDesalocada)
            {
                int linha  = Convert.ToInt32(numLinhaInsercao.Value);
                int coluna = Convert.ToInt32(numColunaInsercao.Value);

                matrizEsparsa.InserirElemento(elemento, linha, coluna);
                matrizEsparsa.ExibirDataGridView(dgMatrizEsparsa);
            }
            else
                MessageBox.Show("Não é possível inserir um elemento na matriz! " + 
                                " Verifique se os valores dos campos de inserção são válidos ou se há uma matriz.",
                                "Atenção!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCelulasGuardadas_Click(object sender, EventArgs e)
        {
            if (!matrizEsparsa.EstaDesalocada)
                MessageBox.Show(matrizEsparsa.ToString());
            else
                MessageBox.Show("Não é possível mostrar as células guardadas. A matriz está desalocada." +
                                " É necessário gerar uma nova matriz esparsa.", "Atenção!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDesalocarMatriz_Click(object sender, EventArgs e)
        {
            if (!matrizEsparsa.EstaDesalocada)
            {
                matrizEsparsa.ApagarMatriz();
                matrizEsparsa.ExibirDataGridView(dgMatrizEsparsa);
            }
            else
                MessageBox.Show("Não há matriz para desalocar." +
                                " É necessário gerar uma nova matriz esparsa.", "Atenção!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (numLinhaPesquisa.Value>=0 && numColunaPesquisa.Value >=0 && !matrizEsparsa.EstaDesalocada)
            {
                MessageBox.Show("Elemento: " + matrizEsparsa.ValorDe(Convert.ToInt32(numLinhaPesquisa.Value), 
                                                                     Convert.ToInt32(numColunaPesquisa.Value)));
            }
            else
                MessageBox.Show("Não é possível pesquisar com os valores dados." +
                " Verifique se está no intervalo da matriz esparsa ou se há matriz para pesquisar.", "Atenção!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRemoverCelula_Click(object sender, EventArgs e)
        {
            if (!matrizEsparsa.EstaDesalocada && numColunaRemocao.Value >=0 && numLinhaRemocao.Value >=0)
            {
                if (!matrizEsparsa.RemoverEm(Convert.ToInt32(numLinhaRemocao.Value), Convert.ToInt32(numColunaRemocao.Value)))
                    MessageBox.Show("Não há célula nessa coordenada para remover.");
                else
                {
                    matrizEsparsa.ExibirDataGridView(dgMatrizEsparsa);
                    MessageBox.Show("Removido com sucesso.");
                }
            }
            else
                MessageBox.Show("Não é possível remover com os valores dados." +
                " Verifique se está no intervalo da matriz esparsa ou se há matriz para remover uma célula.", "Atenção!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnOperacoes_Click(object sender, EventArgs e)
        {
            frmOperacoes frmOp = new frmOperacoes(this);
            this.Hide();
            frmOp.Show();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double valorSoma = 0;
            if (double.TryParse(txtValorSoma.Text, out valorSoma) && valorSoma!=0)
            {
                matrizEsparsa.SomarNaColuna(valorSoma, Convert.ToInt32(numColunaSoma.Value));
                matrizEsparsa.ExibirDataGridView(dgMatrizEsparsa);
            }
            else
                MessageBox.Show("Não é possível somar na coluna indicada esse valor." +
                " Verifique se os valores são válidos.", "Atenção!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnGitHub_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
