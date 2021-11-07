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
using Excepciones;
namespace Formularios
{
    public partial class FrmCargarPilotoTC : Form
    {
        List<Escuderia> escuderias; 
        List<Piloto> pilotos; 
        int index;

        public FrmCargarPilotoTC(List<Escuderia> escuderias, List<Piloto> pilotos, int index)
        {
            InitializeComponent();
            this.escuderias = escuderias;
            this.pilotos = pilotos;
            this.index = index;
        }

        private void FrmCargarPiloto_Load(object sender, EventArgs e)
        {
            this.ListaPilotosDisponibles();
            this.ListaPilotosEscuderia();
        }

        public void ListaPilotosEscuderia()
        {
            
            foreach(Piloto item in escuderias[index].Pilotos)
            {
                lstPilotosDeLaEscuderia.Items.Add(item.MostrarDatos());
            }
            
        }
        public void ListaPilotosDisponibles()
        {
            foreach (Piloto item in pilotos)
            {
                lstPilotosDisponibles.Items.Add(item.MostrarDatos());
            }
        }
    }
}
