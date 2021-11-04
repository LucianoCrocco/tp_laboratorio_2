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
    public partial class FrmPiloto : Form
    {
        List<Piloto> pilotosCargados;
        FrmGenerarPiloto frmGenerarPiloto;
        public FrmPiloto()
        {
            InitializeComponent();
            pilotosCargados = new List<Piloto>();
        }

        private void btnGenerarPiloto_Click(object sender, EventArgs e)
        {
            frmGenerarPiloto = new FrmGenerarPiloto(pilotosCargados);
            frmGenerarPiloto.Show();
        }
    }
}
