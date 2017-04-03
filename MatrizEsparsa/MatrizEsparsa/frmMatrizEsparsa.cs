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

        private void btnCriarMatriz_Click(object sender, EventArgs e)
        {
            matrizEsparsa = new ListaLigadaCruzada(1,1);

            matrizEsparsa.InserirElemento(10, 1, 1);
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RA: 16163 - Davi Oliveira \n" +
                            "RA: 16196 - Vitor Bartier", "Criado por:");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(matrizEsparsa.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(matrizEsparsa.ValorDe(0, 0).ToString());
        }
    }
}
