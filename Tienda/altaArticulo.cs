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
using System.IO;
using System.Configuration;

namespace Tienda
{
    public partial class altaArticulo : Form
    {
        private articulos Art = null;
        private OpenFileDialog archivo = null;
        public altaArticulo()
        {
            InitializeComponent();
            Text = "Alta articulo";
        }

        public altaArticulo(articulos art)
        {
            InitializeComponent();
            this.Art = art;
            Text = "Modificar";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NegocioArticulos nego = new NegocioArticulos();

            try
            {
                // Validar que el código de artículo y el nombre no estén vacíos
                if (string.IsNullOrWhiteSpace(txtcd.Text) || string.IsNullOrWhiteSpace(nombretx.Text))
                {
                    MessageBox.Show("Debe completar los campos Código de Artículo y Nombre.");
                    return;
                }

                // Validar que el precio solo contenga números
                decimal precio;
                if (!decimal.TryParse(precioTxt.Text, out precio))
                {
                    MessageBox.Show("El precio debe ser un número válido.");
                    return;
                }

                // Si todas las validaciones pasan, procedemos a cargar los datos del artículo
                if (Art == null)
                    Art = new articulos();
                Art._CodigoArticulo = txtcd.Text;
                Art._nombre = nombretx.Text;
                Art._descripArticulo = descripcionTx.Text;
                Art._precio = precio;
                Art.UrlImagen = txtUrl.Text;
                Art.DescripcionCategoria = (Categoria)cboCategoria.SelectedItem;
                Art.DescripcionMarca = (Marca)cboMarca.SelectedItem;

                if (Art._idArticulo != 0)
                {
                    nego.modificar(Art);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    nego.agregarArt(Art);
                    MessageBox.Show("Agregado exitosamente");
                }

                // Copiar el archivo si existe y la URL no contiene "http"
                if (archivo != null && !(txtUrl.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void altaArticulo_Load(object sender, EventArgs e)
        {
            marcaNegocio mar = new marcaNegocio();
            categoriaNegocio cat = new categoriaNegocio();
            try
            {
                cboCategoria.DataSource = cat.listar();
                cboCategoria.ValueMember = "_idCategoria";
                cboCategoria.DisplayMember = "_NombreCategoria";
                cboMarca.ValueMember = "_idMarca";
                cboMarca.DisplayMember = "_nombreMarca";
                cboMarca.DataSource = mar.listar();

                if (Art != null)
                {
                    txtcd.Text = Art._CodigoArticulo;
                    nombretx.Text = Art._nombre;
                    descripcionTx.Text = Art._descripArticulo;
                    precioTxt.Text = Art._precio.ToString();
                    txtUrl.Text = Art.UrlImagen;
                    CargarImagen(Art.UrlImagen);
                    cboCategoria.SelectedValue = Art.DescripcionCategoria._idCategoria;
                    cboMarca.SelectedValue = Art.DescripcionMarca._idMarca;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
        }
        private void CargarImagen(string url)
        {


            try
            {
                pbxAlta.Load(url);
            }
            catch (Exception ex)
            {
                pbxAlta.Load("https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg ");

            }
        }
        private void txtUrl_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtUrl.Text);
        }

        private void btnImagenLocal_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrl.Text = archivo.FileName;
                CargarImagen(archivo.FileName);
              //  File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
            }
        }
    }
}
