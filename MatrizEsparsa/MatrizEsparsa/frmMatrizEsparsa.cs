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
            matrizEsparsa = new ListaLigadaCruzada(Convert.ToInt32(numLinhas.Value), Convert.ToInt32(numColunas.Value));

            // atualiza no gridView a matriz criada
            matrizEsparsa.ExibirDataGridView(dgMatrizEsparsa);
        }

        private void btnLerArquivo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O arquivo deve conter as coordenadas que a matriz terá e depois os elementos não nulos. Exemplo: \n" + 
                            " 3 3 \n 10 0 0 \n 15 0 2",
                            "Orientações de arquivo de matriz esparsa:", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                matrizEsparsa = matrizEsparsa.LerArquivo(openFileDialog1.FileName);

                numLinhaPesquisa.Maximum  = numLinhas.Value  = matrizEsparsa.Linhas;
                numColunaPesquisa.Maximum = numColunas.Value = matrizEsparsa.Colunas;

                matrizEsparsa.ExibirDataGridView(dgMatrizEsparsa);
            }            
        }

        private void btnCriarMatrizEsparsa_Click(object sender, EventArgs e)
        {
            if (numColunas.Value >0 || numLinhas.Value >0)
            {
                matrizEsparsa = new ListaLigadaCruzada(Convert.ToInt32(numLinhas.Text), Convert.ToInt32(numColunas.Text));
                matrizEsparsa.ExibirDataGridView(dgMatrizEsparsa);

                numLinhaPesquisa.Maximum  = numLinhaInsercao.Maximum  = matrizEsparsa.Linhas -1;
                numColunaPesquisa.Maximum = numColunaInsercao.Maximum = matrizEsparsa.Colunas -1;
                

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
            double num;
            if (txtElementoInsercao.Text!=""  && double.TryParse(txtElementoInsercao.Text, out num) && numLinhaInsercao.Value>=0 && numColunaInsercao.Value>=0)
            {
                matrizEsparsa.InserirElemento(num, Convert.ToInt32(numLinhaInsercao.Value), 
                                              Convert.ToInt32(numColunaInsercao.Value));

                matrizEsparsa.ExibirDataGridView(dgMatrizEsparsa);
            }
            else
                MessageBox.Show("Não é possível inserir um elemento na matriz! Verifique se os valores dos campos de inserção são válidos.", "Atenção!",
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
            matrizEsparsa.ApagarMatriz();
            matrizEsparsa.ExibirDataGridView(dgMatrizEsparsa);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (numLinhaPesquisa.Value>=0 && numColunaPesquisa.Value >=0 && !matrizEsparsa.EstaDesalocada)
            {
                MessageBox.Show("Elemento: " + matrizEsparsa.ValorDe(Convert.ToInt32(numLinhaPesquisa.Value), 
                                                                     Convert.ToInt32(numColunaPesquisa.Value)));
            }
            else
                MessageBox.Show("Não é pesquisar com os valores dados." +
                " Verifique se está no intervalo da matriz esparsa ou se há matriz para pesquisar.", "Atenção!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
