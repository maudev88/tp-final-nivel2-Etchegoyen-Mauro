using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace Presentacion
{
    public partial class frmDetalle : Form
    {
        private Articulo articulo = null;
        public frmDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Detalle del Articulo";
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
         try
            {
                
                if (articulo != null)
                {
                    lblCodigo2.Text = articulo.CodigoArticulo;
                    lblNombre2.Text = articulo.Nombre;
                    lblPrecio2.Text = articulo.Precio.ToString();
                    cargarImagen(articulo.Imagen);
                    lblCodigoMarca2.Text = articulo.Marca.ToString();
                    lblMarca2.Text = articulo.Marcas.Descripcion;
                    lblCodigoCategoria2.Text = articulo.Categoria.ToString();
                    lblCategoria2.Text = (articulo.Categorias.Descripcion);
                    lblDescripcion2.Text = articulo.Descripcion;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
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

    }
}
