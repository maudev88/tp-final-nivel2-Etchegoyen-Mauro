using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace Presentacion
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;

        private OpenFileDialog archivo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
            Text = "Agregar Artículo";

        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }




        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            try
            {
                cboBoxMarca.DataSource = marcaNegocio.listar();
                cboBoxMarca.ValueMember = "Id";
                cboBoxMarca.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
///////////////////////////////////////////////////////////////////////////////////
            
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cboBoxCategoria.DataSource = categoriaNegocio.listar();
                cboBoxCategoria.ValueMember = "Id";
                cboBoxCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.CodigoArticulo;
                    txtNombre.Text = articulo.Nombre;
                    txtPrecio.Text = articulo.Precio.ToString();
                    txtImagen.Text = articulo.Imagen;
                    cargarImagen(articulo.Imagen);
                    cboBoxMarca.SelectedValue = articulo.Marca;
                    cboBoxCategoria.SelectedValue = articulo.Categoria;
                    txtDescripcion.Text = articulo.Descripcion;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
         
            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.CodigoArticulo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Imagen = txtImagen.Text;
                articulo.Marcas = (Elemento)cboBoxMarca.SelectedItem;
                articulo.Categorias = (Elemento)cboBoxCategoria.SelectedItem;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);



               
                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado Exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado Exitosamente");
                }
                Close();

            }
            catch (Exception ex)
            {
                if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                {
                    MessageBox.Show("Debes cargar el Código");
                }
                else if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Debes cargar el Nombre");
                }

                else if (string.IsNullOrEmpty(txtPrecio.Text))
                {
                    MessageBox.Show("Debes cargar el Precio");
                    
                }
               
                else
                {
                MessageBox.Show(ex.ToString());

                }
            }
        }



        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://imgs.search.brave.com/RDAPZgBGP8vaVEPoPn5B5XAEz0otIgjqy0DcBp1oAPE/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9jZG4y/Lmljb25maW5kZXIu/Y29tL2RhdGEvaWNv/bnMvcGFzdGVsLXN2/Zy1tZWRpYS8xNi9w/aWN0dXJlX2ltYWdl/X3Bob3RvX2VtcHR5/LTUxMi5wbmc");
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true; // Descartar el carácter no numérico (ChatGPT)
            }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
            // No puse la opción de guardar las imágenes porque me pareció que no hacia falta
        }
    }
}
