﻿using System;
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
        List<Piloto> pilotosCargados;
        FrmGenerarPiloto frmGenerarPiloto;
        FrmPilotoEstadistica frmEstadisticaPiloto;
        Serializacion<List<Piloto>> serializacion;
        public static ListBox ListBoxRef;
        string path;

        public FrmPiloto(List<Piloto> listaPilotos)
        {
            InitializeComponent();
            pilotosCargados = listaPilotos;
            ListBoxRef = this.lstPilotos;
            serializacion = new Serializacion<List<Piloto>>();
        }

        #region Generar Piloto
        private void btnGenerarPiloto_Click(object sender, EventArgs e)
        {
            frmGenerarPiloto = new FrmGenerarPiloto(pilotosCargados);
            frmGenerarPiloto.ShowDialog();
        }
        #endregion

        #region Estadisticas
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
        private void btnGuardarLista_Click(object sender, EventArgs e)
        {
            if (pilotosCargados.Count > 0)
            {
                try
                {
                    path = $"{Environment.CurrentDirectory}\\ListaPilotos.xml";
                    if (File.Exists(path))
                    {
                        if (MessageBox.Show("Ya se encuentra creado un archivo de pilotos, ¿desea sobreescribirlo?", "Cuidado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            serializacion.Guardar(pilotosCargados, path, false);
                            MessageBox.Show($"Archivo correctamente guardado en: {path}", "Guardado correcto", MessageBoxButtons.OK ,MessageBoxIcon.Information);
                        }
                    }
                    else
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
                MessageBox.Show("No hay pilotos cargados en la lista", "Aleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        #endregion

        #region Cargar Pilotos
        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccione el archivo a abrir";
            openFileDialog.Filter = "Archivos XML (.xml) |*.xml||*.*";

            if((pilotosCargados.Count > 0 && MessageBox.Show("Si no se guardo la lista con la cual se encuentra trabajando esta se borrara y se cargara la lista que usted elija.\n ¿Desea Continuar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) || pilotosCargados.Count == 0) 
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                    try
                    {
                        this.pilotosCargados = serializacion.Leer(path);
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

        #region Metodos
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