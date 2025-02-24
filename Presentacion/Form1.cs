using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace Presentacion
{
    public partial class Form1 : Form

    {
        private List<Articulo> listaArticulos;
        public Form1()
        {
            InitializeComponent();
            Text = "Catálogo de Artículos";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            cboBoxCampo.Items.Add("Categoria");
            cboBoxCampo.Items.Add("Marca");
            cboBoxCampo.Items.Add("Precio");
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.Imagen);
            }
        }

        private void cargar()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                ocultarColumnas();
                cargarImagen(listaArticulos[0].Imagen);
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxArticulo.Load(imagen);
            }
            catch (Exception)
            {

                pictureBoxArticulo.Load("https://imgs.search.brave.com/RDAPZgBGP8vaVEPoPn5B5XAEz0otIgjqy0DcBp1oAPE/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9jZG4y/Lmljb25maW5kZXIu/Y29tL2RhdGEvaWNv/bnMvcGFzdGVsLXN2/Zy1tZWRpYS8xNi9w/aWN0dXJlX2ltYWdl/X3Bob3RvX2VtcHR5/LTUxMi5wbmc");
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Marca"].Visible = false;
            dgvArticulos.Columns["Categoria"].Visible = false;
            dgvArticulos.Columns["Imagen"].Visible = false;
            dgvArticulos.Columns["Imagen"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;

        }

        private void cboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboBoxCampo.SelectedItem.ToString();
            if(opcion == "Categoria" || opcion == "Marca")
            {
                cboBoxCriterio.Items.Clear();
                cboBoxCriterio.Items.Add("Comienza con");
                cboBoxCriterio.Items.Add("Termina con");
                cboBoxCriterio.Items.Add("Contiene");

            }
            else
            {
                cboBoxCriterio.Items.Clear();
                cboBoxCriterio.Items.Add("Mayor a");
                cboBoxCriterio.Items.Add("Menor a");
                cboBoxCriterio.Items.Add("Igual a");
            }
        }

        private bool validarFiltro()
        {
            if(cboBoxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione el campo para filtrar");
                return true;
            }
            if(cboBoxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione el criterio para filtrar");
                return true;
            }
            if(cboBoxCampo.SelectedItem.ToString() == "Precio")
            {
                if(string.IsNullOrEmpty(txtBoxFiltro.Text))
                {
                    MessageBox.Show("Debes cargar el filtro para numéricos");
                    return true;
                }
                if(!(soloNumeros(txtBoxFiltro.Text)))
                {
                    MessageBox.Show("Solo nros para filtrar por un campo numérico");
                    return true;
                }
            }
            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cboBoxCampo.SelectedItem.ToString();
                string criterio = cboBoxCriterio.SelectedItem.ToString();
                string filtro = txtBoxFiltro.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void eliminar(bool logico = true)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("De verdad desea eliminar este producto?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                    if (logico)
                        negocio.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmDetalle mostrar = new frmDetalle(seleccionado);
            mostrar.ShowDialog();
            cargar();
        }

        

        private void textBoxFiltroAvanzado_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = textBoxFiltroAvanzado.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper())
                || x.Marcas.Descripcion.ToUpper().Contains(filtro.ToUpper())
                || x.Categorias.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();

        }
    }
}
