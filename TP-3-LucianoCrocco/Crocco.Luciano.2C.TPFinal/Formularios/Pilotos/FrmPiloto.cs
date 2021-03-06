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
using ArchivosYSerializacion;
using System.IO;

namespace Formularios
{
    public partial class FrmPiloto : Form
    {
        #region Atributos
        private List<Piloto> pilotosCargados;
        private FrmGenerarPiloto frmGenerarPiloto;
        private FrmPilotoEstadistica frmEstadisticaPiloto;
        private SerializacionXML<List<Piloto>> serializacion;
        private OpenFileDialog openFileDialog;
        public static ListBox ListBoxRef;
        private string path;
        #endregion

        /// <summary>
        /// Constructor del form. Recibe la referencia de la lista de pilotos en memoria.
        /// </summary>
        /// <param name="listaPilotos"></param>
        public FrmPiloto(List<Piloto> listaPilotos)
        {
            InitializeComponent();
            pilotosCargados = listaPilotos;
            ListBoxRef = this.lstPilotos;
            serializacion = new SerializacionXML<List<Piloto>>();
        }
        private void FrmPiloto_Load(object sender, EventArgs e)
        {
            Refrescar(pilotosCargados);
        }

        #region Generar Piloto
        /// <summary>
        /// Genera un formulario para crear un piloto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerarPiloto_Click(object sender, EventArgs e)
        {
            frmGenerarPiloto = new FrmGenerarPiloto(pilotosCargados);
            frmGenerarPiloto.ShowDialog();
        }
        #endregion

        #region Estadisticas
        /// <summary>
        /// Genera un formulario para realizar trabajos estadisticos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            if(pilotosCargados.Count > 0)
            {
                frmEstadisticaPiloto = new FrmPilotoEstadistica(pilotosCargados);
                frmEstadisticaPiloto.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay pilotos cargados en la lista", "Aleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Guardar pilotos
        /// <summary>
        /// Guarda la lista de pilotos que se encuentra actualmente cargada en memoria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarLista_Click(object sender, EventArgs e)
        {
            if (pilotosCargados.Count > 0)
            {
                try
                {
                    path = $"{Environment.CurrentDirectory}\\ListaPilotos.xml";
                    if((File.Exists(path) && MessageBox.Show("Ya se encuentra creado un archivo de pilotos, ¿desea sobreescribirlo?", "Cuidado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) || !File.Exists(path))
                    {
                        serializacion.Guardar(pilotosCargados, path, false);
                        MessageBox.Show($"Archivo correctamente guardado en: {path}", "Guardado correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (GuardarSerializacionException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No hay pilotos cargados en la lista", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        #endregion

        #region Cargar Pilotos
        /// <summary>
        /// Carga una lista de pilotos que el usuario seleccione. Si la lista actual tiene pilotos en memoria se borra al cargar la nueva lista.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccione el archivo a abrir";
            openFileDialog.Filter = "Archivos XML (.xml) |*.xml||*.*";
            List<Piloto> auxList;

            if((pilotosCargados.Count > 0 && MessageBox.Show("Si no se guardo la lista con la cual se encuentra trabajando esta se borrara y se cargara la lista que usted elija.\n ¿Desea continuar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) || pilotosCargados.Count == 0) 
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                    try
                    {
                        auxList = serializacion.Leer(path);
                        this.pilotosCargados.Clear();
                        //Si no hago esto se pierde la referencia en memoria cuando CLR borra los objetos que se utilizaron para serializar.
                        foreach(Piloto item in auxList)
                        {
                            this.pilotosCargados.Add(item);
                        }
                        Refrescar(pilotosCargados);
                        MessageBox.Show("Archivo cargado correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }            
            }
        }
        #endregion

        #region Borrar Piloto
        /// <summary>
        /// Haciendo doble click sobre la lista borra de la memoria un piloto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstPilotos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(pilotosCargados.Count < 1)
            {
                MessageBox.Show("La lista se encuentra vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else
            {
                try
                {
                    pilotosCargados -= pilotosCargados[lstPilotos.SelectedIndex];
                    Refrescar(pilotosCargados);
                }
                catch (PilotoNoEncontradoException ex)
                {
                    MessageBox.Show(ex.Message);
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
        #endregion

        #region Metodos
        /// <summary>
        /// Refresca la lista de pilotos del form
        /// </summary>
        /// <param name="pilotos">Lista de pilotos que queremos mostrar ene l form</param>
        public static void Refrescar(List<Piloto> pilotos)
        {
            FrmPiloto.ListBoxRef.Items.Clear();
            foreach (Piloto item in pilotos)
            {
                FrmPiloto.ListBoxRef.Items.Add(item.MostrarDatos());
            }
        }
        #endregion

    }
}
