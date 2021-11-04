using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmPrincipal : Form
    {
        FrmEscuderia frmEscuderia;
        FrmPiloto frmPiloto;
        public FrmPrincipal()
        {
            InitializeComponent();
            frmEscuderia = new FrmEscuderia();
        }

        private void btnPilotos_Click(object sender, EventArgs e)
        {
            frmPiloto = new FrmPiloto();
            frmPiloto.Show();
        }
    }
}
