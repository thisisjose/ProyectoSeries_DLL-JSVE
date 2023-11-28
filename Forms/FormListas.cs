using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoSeries_DLL_JSVE.Clases;

namespace ProyectoSeries_DLL_JSVE.Forms
{
    public partial class FormListas : Form
    {
        private Nodo cabezaLista;
        public FormListas()
        {
            InitializeComponent();
            cabezaLista = null;
            btnEliminarLista.Click += BtnEliminarLista_Click;
            btnOrdenarLista.Click += BtnOrdenarLista_Click;

        }

        //Agregar Lista
        private void btnAgregarLista_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descripcion = txtDescripcion.Text;

            if (int.TryParse(txtNroCapitulos.Text, out int nroCapitulos))
            {
                Serie nuevaSerie = new Serie(nombre, descripcion, nroCapitulos);
                if (AgregarASerie(nuevaSerie))
                {
                    MostrarListas();
                    LimpiarTextBoxes();
                }
                else
                {
                    MessageBox.Show("Error al agregar la serie.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido para el número de capítulos.");
            }
        }

        private bool AgregarASerie(Serie nuevaSerie)
        {
            try
            {
                Nodo nuevoNodo = new Nodo(nuevaSerie);
                nuevoNodo.siguiente = cabezaLista;
                cabezaLista = nuevoNodo;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la serie: {ex.Message}");
                return false;
            }
        }

        private void MostrarListas()
        {
            GridListas.Rows.Clear();

            Nodo nodoActual = cabezaLista;
            while (nodoActual != null)
            {
                Serie serieActual = nodoActual.datos;
                GridListas.Rows.Add(serieActual.nombre, serieActual.descripcion, serieActual.nroCapitulos);
                nodoActual = nodoActual.siguiente;
            }
        }

        private void LimpiarTextBoxes()
        {
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtNroCapitulos.Text = string.Empty;
        }

        private void BtnEliminarLista_Click(object sender, EventArgs e)
        {
            if (GridListas.SelectedRows.Count > 0)
            {
                int indiceFilaSeleccionada = GridListas.SelectedRows[0].Index;

                Nodo nodoActual = ObtenerNodoPorIndice(indiceFilaSeleccionada);

                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar la serie?", "Eliminar Serie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    EliminarSerie(indiceFilaSeleccionada);
                    MostrarListas();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una serie para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Nodo ObtenerNodoPorIndice(int indice)
        {
            Nodo nodoActual = cabezaLista;

            for (int i = 0; i < indice; i++)
            {
                if (nodoActual != null)
                {
                    nodoActual = nodoActual.siguiente;
                }
            }

            return nodoActual;
        }

        private void EliminarSerie(int indice)
        {
            if (indice >= 0 && indice < GridListas.Rows.Count)
            {
                if (indice == 0)
                {
                    cabezaLista = cabezaLista.siguiente;
                }
                else
                {
                    Nodo nodoAnterior = ObtenerNodoPorIndice(indice - 1);
                    Nodo nodoAEliminar = nodoAnterior.siguiente;
                    nodoAnterior.siguiente = nodoAEliminar.siguiente;
                }
            }
        }
        private void BtnOrdenarLista_Click(object sender, EventArgs e)
        {
            OrdenarLista();
            MostrarListas();
        }

        private void OrdenarLista()
        {
            if (cabezaLista != null)
            {
                Nodo actual = cabezaLista;

                while (actual != null)
                {
                    Nodo minimo = EncontrarMinimo(actual);
                    Swap(actual, minimo);
                    actual = actual.siguiente;
                }
            }
        }

        private Nodo EncontrarMinimo(Nodo inicio)
        {
            Nodo minimo = inicio;
            Nodo actual = inicio.siguiente;

            while (actual != null)
            {
                if (string.Compare(actual.datos.nombre, minimo.datos.nombre) < 0)
                {
                    minimo = actual;
                }

                actual = actual.siguiente;
            }

            return minimo;
        }

        private void Swap(Nodo nodo1, Nodo nodo2)
        {
            Serie temp = nodo1.datos;
            nodo1.datos = nodo2.datos;
            nodo2.datos = temp;
        }
    } 
}
