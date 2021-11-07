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
using ArchivosYSerializacion;
using Excepciones;
using System.IO;

namespace Formularios
{
    public partial class FrmEscuderiaTC : Form
    {
        FrmGenerarEscuderiaTC frmGenerarEscuderiaTC;
        FrmCargarPilotoTC frmCargarPiloto;
        List<Escuderia> escuderias;
        List<Piloto> pilotos;
        List<EscuderiaTC> escuderiasTurismoCarretera;
        SerializacionJSON<List<EscuderiaTC>> serializacionTC;
        public static ListBox ListBoxRef;
        OpenFileDialog openFileDialog;
        string path;

        public FrmEscuderiaTC(List<Escuderia> escuderias, List<Piloto> pilotos)
        {
            InitializeComponent();
            this.escuderias = escuderias;
            this.pilotos = pilotos;
            ListBoxRef = this.lstEscuderias;
            this.serializacionTC = new SerializacionJSON<List<EscuderiaTC>>();
            escuderiasTurismoCarretera = new List<EscuderiaTC>();
        }

        private void FrmEscuderia_Load(object sender, EventArgs e)
        {
            Refrescar(this.escuderias);

        }

        #region Guardar escuderia TC
        private void btnGuardarLista_Click(object sender, EventArgs e)
        {
            if (escuderias.Count > 0)
            {
                try
                {
                    path = $"{Environment.CurrentDirectory}\\ListaEscuderiasTurismoCarretera.json";
                    if ((File.Exists(path) && MessageBox.Show("Ya se encuentra creado un archivo de escuderias, ¿desea sobreescribirlo?", "Cuidado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) || !File.Exists(path))
                    {
                        foreach(EscuderiaTC escuderiaTC in this.escuderias)
                        {
                            this.escuderiasTurismoCarretera.Add(escuderiaTC);
                        }
                        ((IArchivo<List<EscuderiaTC>>)serializacionTC).Guardar(this.escuderiasTurismoCarretera, path,false);
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
                MessageBox.Show("No hay escuderias cargadas en la lista", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Cargar escuderia TC
        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccione el archivo a abrir";
            openFileDialog.Filter = "Archivos Json (.json) |*.json||*.*";
            List<EscuderiaTC> auxList;

            if ((escuderias.Count > 0 && MessageBox.Show("Si no se guardo la lista con la cual se encuentra trabajando esta se borrara y se cargara la lista que usted elija.\n ¿Desea continuar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) || escuderias.Count == 0)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                    try
                    {
                        auxList = ((IArchivo<List<EscuderiaTC>>)serializacionTC).Leer(path);
                        FrmPrincipal.BorrarAutosTC(escuderias);
                        foreach (EscuderiaTC item in auxList)
                        {
                            this.escuderias.Add(item);
                        }
                        Refrescar(escuderias);
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

        #region Generar Escuderia TC
         
        private void btnGenerarEscuderia_Click(object sender, EventArgs e)
        {
            frmGenerarEscuderiaTC = new FrmGenerarEscuderiaTC(escuderias);
            frmGenerarEscuderiaTC.ShowDialog();
        }
        #endregion

        private void btnCargarPilotos_Click(object sender, EventArgs e)
        {
            if(lstEscuderias.SelectedIndex > 0)
            {
                frmCargarPiloto = new FrmCargarPilotoTC(escuderias, pilotos, lstEscuderias.SelectedIndex);
                frmCargarPiloto.ShowDialog();
            } else
            {
                MessageBox.Show("Seleccione una escuderia de la lista para cargarle un piloto");
            }
        }


        private void lstEscuderias_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (escuderias.Count < 1)
            {
                MessageBox.Show("La lista se encuentra vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    escuderias -= escuderias[lstEscuderias.SelectedIndex];
                    Refrescar(escuderias);
                }
                catch (EscuderiaNoEncontradaException ex)
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

        #region Metodos
        public static void Refrescar(List<Escuderia> escuderias)
        {
            FrmEscuderiaTC.ListBoxRef.Items.Clear();
            foreach (EscuderiaTC item in escuderias)
            {
                FrmEscuderiaTC.ListBoxRef.Items.Add(item.MostrarDatos());
            }
        }
        #endregion
    }
}
