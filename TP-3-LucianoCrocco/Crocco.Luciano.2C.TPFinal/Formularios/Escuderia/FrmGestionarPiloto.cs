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
    public partial class FrmGestionarPiloto : Form
    {
        private List<Escuderia> escuderias;
        private List<Piloto> pilotos;
        private int index;

        public FrmGestionarPiloto(List<Escuderia> escuderias, List<Piloto> pilotos, int index)
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
            lstPilotosDeLaEscuderia.Items.Clear();
            foreach(Piloto item in escuderias[index].Pilotos)
            {
                lstPilotosDeLaEscuderia.Items.Add(item.MostrarDatos());
            }
            
        }
        public void ListaPilotosDisponibles()
        {
            lstPilotosDisponibles.Items.Clear();
            foreach (Piloto item in pilotos)
            {
                lstPilotosDisponibles.Items.Add(item.MostrarDatos());
            }
        }

        private void lstPilotosDisponibles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(this.escuderias[index].CantidadPilotos > this.escuderias[index].Pilotos.Count)
            {
                try
                {
                    bool ocupado = false;
                    foreach (Escuderia item in escuderias)
                    {
                        foreach (Piloto piloto in item.Pilotos)
                        {
                            if (item == this.pilotos[lstPilotosDisponibles.SelectedIndex])
                            {
                                ocupado = true;
                                MessageBox.Show("El piloto seleccionado ya se encuentra compitiendo en una escudera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        }
                    }
                    if (!ocupado)
                    {
                        this.escuderias[index].Pilotos.Add(this.pilotos[lstPilotosDisponibles.SelectedIndex]);
                        this.ListaPilotosDisponibles();
                        this.ListaPilotosEscuderia();
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("El index seleccionado se encuentra fuera del rango de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                MessageBox.Show($"Se alcanzo el maximo de asientos disponibles de la escuderia ({this.escuderias[index].CantidadPilotos})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           

        }

        private void lstPilotosDeLaEscuderia_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                this.escuderias[index].Pilotos.Remove(this.escuderias[index].Pilotos[lstPilotosDeLaEscuderia.SelectedIndex]);
                this.ListaPilotosDisponibles();
                this.ListaPilotosEscuderia();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("El index seleccionado se encuentra fuera del rango de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
