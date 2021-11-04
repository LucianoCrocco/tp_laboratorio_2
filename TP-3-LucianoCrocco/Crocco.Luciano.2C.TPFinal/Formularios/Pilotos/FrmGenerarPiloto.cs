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
    public partial class FrmGenerarPiloto : Form
    {
        List<Piloto> pilotosLista;
        public FrmGenerarPiloto(List<Piloto> pilotos)
        {
            InitializeComponent();
            pilotosLista = pilotos;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Piloto piloto = new Piloto(txtBoxNombre.Text, txtBoxApellido.Text, (int)nroEdad.Value, ESexo.Masculino, (int)nroCompeticion.Value, true);
            pilotosLista.Add(piloto);
        }
    }
}
