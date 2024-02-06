
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

namespace Tienda
{
    public partial class Tienda : Form
        
    {
        private List<articulos> listaArticulos;
        public Tienda()
        {
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            NegocioArticulos negocio = new NegocioArticulos();
            try
            {
                
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["UrlImagen"].Visible = false;
                dgvArticulos.Columns["_IdArticulo"].Visible = false;
                CargarImagen(listaArticulos[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Codigo");
            cboCampo.Items.Add("Nombre"); 

        }

        private void CargarImagen(string url)
        {


            try
            {
                Fotos.Load(url);
            }
            catch (Exception ex)
            {
                Fotos.Load("https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg ");

            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)

        {
            if (dgvArticulos.CurrentRow != null)
            {
                articulos selecionado = (articulos)dgvArticulos.CurrentRow.DataBoundItem;
                CargarImagen(selecionado.UrlImagen);
            }
            
        }

        private void cargar()
        {
            NegocioArticulos negocio = new NegocioArticulos();
            try
            {

                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["UrlImagen"].Visible = false;
                dgvArticulos.Columns["_IdArticulo"].Visible = false;
                CargarImagen(listaArticulos[0].UrlImagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            altaArticulo alta= new altaArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void Fotos_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            articulos selecionado;
            selecionado = (articulos)dgvArticulos.CurrentRow.DataBoundItem;

         

            altaArticulo modificar = new altaArticulo(selecionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            NegocioArticulos negocio = new NegocioArticulos();
            articulos selecionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {

                    selecionado = (articulos)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(selecionado._idArticulo);
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion=cboCampo.SelectedItem.ToString();
            if(opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Igual a");
                cboCriterio.Items.Add("Menor a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Empieza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");

            }
        }
        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Debes cargar el filtro para numéricos...");
                    return true;
                }
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Solo nros para filtrar por un campo numérico...");
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           NegocioArticulos negocio= new NegocioArticulos();
            try
            {
                if (validarFiltro())
                    return;
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvArticulos.DataSource = negocio.filtro(campo,criterio,filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           

        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {


            articulos seleccionado;
            seleccionado = (articulos)dgvArticulos.CurrentRow.DataBoundItem;

            verDetalle detalle = new verDetalle(seleccionado);
            detalle.ShowDialog();
            cargar();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
