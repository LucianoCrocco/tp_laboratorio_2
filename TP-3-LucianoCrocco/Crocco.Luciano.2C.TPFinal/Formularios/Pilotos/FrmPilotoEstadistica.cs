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
    public partial class FrmPilotoEstadistica : Form
    {
        //List<Piloto> pilotosCargados;
        PromedioPilotos promedio;
        public FrmPilotoEstadistica(List<Piloto> pilotos)
        {
            InitializeComponent();
           //pilotosCargados = pilotos;
            promedio = new PromedioPilotos(pilotos);
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnMaximo_Click(object sender, EventArgs e)
        {
            Limpiar();
            rchEstadisticas.Text = promedio.MaximoEdad() + "\n" + promedio.MaximoNacionalidad() + "\n" + promedio.MaximoSexo() + "\n" + promedio.MaximoNroCompeticion();
        }

        private void btnMinimo_Click(object sender, EventArgs e)
        {
            Limpiar();
            rchEstadisticas.Text = promedio.MinimoEdad() + "\n" + promedio.MinimoNacionalidad() + "\n" + promedio.MinimoSexo() + "\n" + promedio.MinimoNroCompeticion();
        }

        public void Limpiar()
        {
            rchEstadisticas.Clear();
        }
    }
}
