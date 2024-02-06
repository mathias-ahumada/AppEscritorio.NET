using System;
using System.Windows.Forms;
using dominio;
using negocio;

namespace Tienda
{
    public partial class verDetalle : Form
    {
        private articulos artti;

        public verDetalle()
        {
            InitializeComponent();
        }

        public verDetalle(articulos artti)
        {
            InitializeComponent();
            this.artti = artti;
            Text = "Detalle del producto";
        }

        private void verDetalle_Load(object sender, EventArgs e)
        {
            NegocioArticulos negocio = new NegocioArticulos();

            try
            {
                txtCodigo.Text = artti._CodigoArticulo;
                txtDescrip.Text = artti._descripArticulo;
                txtNombre.Text = artti._nombre;
                txtPrecio.Text = artti._precio.ToString("$0,00");
                txtMarca.Text = artti.DescripcionMarca.ToString();
                txtCategoria.Text = artti.DescripcionCategoria.ToString();
              string UrlImagen= artti.UrlImagen;
                cargarImagen(UrlImagen);
                

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulosDetalle.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulosDetalle.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }
    }
}

