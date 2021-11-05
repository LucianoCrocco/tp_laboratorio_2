using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class FrmPrincipal : Form
    {
        FrmEscuderia frmEscuderia;
        FrmPiloto frmPiloto;
        List<Piloto> pilotos;
        List<Escuderia> escuderias;
        public FrmPrincipal()
        {
            InitializeComponent();
            frmEscuderia = new FrmEscuderia();
            pilotos = new List<Piloto>();
            escuderias = new List<Escuderia>();
        }

        private void btnPilotos_Click(object sender, EventArgs e)
        {
            frmPiloto = new FrmPiloto(pilotos);
            frmPiloto.Show();
        }
    }
}
