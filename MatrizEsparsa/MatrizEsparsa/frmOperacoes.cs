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
    public partial class frmOperacoes : Form
    {
        frmMatrizEsparsa frmPrincipal;

        public frmOperacoes(frmMatrizEsparsa frm)
        {
            InitializeComponent();
            frmPrincipal = frm;
        }

        private void frmOperacoes_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPrincipal.Show();
        }
    }
}
