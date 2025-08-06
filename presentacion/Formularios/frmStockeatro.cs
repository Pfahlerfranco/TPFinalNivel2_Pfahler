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
using presentacion.Formularios;

namespace presentacion
{
    public partial class Stockeatro : Form
    {

        private List<Articulo> listaArticulos;

        public Stockeatro()
        {
            InitializeComponent();
        }

        private void Stockeatro_Load(object sender, EventArgs e)
        {
            cargar();
            //    cboCampo.Items.Add("Número");         VER QUE VA ACA
            //    cboCampo.Items.Add("Nombre");
            //    cboCampo.Items.Add("Descripción");
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStock.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvStock.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }

        }

        private void cargar()
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulos = negocio.listar();
                dgvStock.DataSource = listaArticulos;
                ocultarColumnas();
                if (listaArticulos.Count > 0)
                    cargarImagen(listaArticulos[0].ImagenUrl);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvStock.Columns["ImagenUrl"].Visible = false;
            dgvStock.Columns["Id"].Visible = false;
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxStock.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxStock.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }


       //-------------------------------------------------------

        private void agregarSM_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void modificarSM_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvStock.CurrentRow.DataBoundItem;

            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void eliminarSM_Click(object sender, EventArgs e)
        {
            if (dgvStock.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvStock.CurrentRow.DataBoundItem;

                string mensaje = $"¿Estás seguro que querés eliminar el artículo \"{seleccionado.Nombre}\" de la categoría \"{seleccionado.Categoria.Descripcion}\"?";
                DialogResult resultado = MessageBox.Show(mensaje, "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    ArticuloNegocio negocio = new ArticuloNegocio();
                    try
                    {
                        negocio.eliminar(seleccionado.Id);
                        MessageBox.Show("Artículo eliminado correctamente.");
                        cargar(); // Actualiza el DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccioná un artículo para eliminar.");
            }
        }
        private void txBuscarSimple_TextChanged(object sender, EventArgs e)
        {
            string filtro = txBuscarSimple.Text.ToLower();

            List<Articulo> listaFiltrada = listaArticulos.FindAll(
                x => x.Nombre.ToLower().Contains(filtro) ||
                     x.Codigo.ToLower().Contains(filtro) ||
                     x.Descripcion.ToLower().Contains(filtro)
            );

            dgvStock.DataSource = null;
            dgvStock.DataSource = listaFiltrada;
            ocultarColumnas();

        }

        private void filtroAvanzandoSM_Click(object sender, EventArgs e)
        {
            lblFiltroAvanzado.Visible = true;
            cbFiltroAvanzado.Visible = true;
            cbFiltroAvanzado.Items.Clear();

            // Podés elegir si querés mostrar marcas o categorías (acá ejemplo con Categoría)
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            cbFiltroAvanzado.DataSource = categoriaNegocio.listar();
            cbFiltroAvanzado.DisplayMember = "Descripcion";
            cbFiltroAvanzado.ValueMember = "Id";

            btnQuitarFiltro.Visible = true;
        }

        private void cbFiltroAvanzado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbFiltroAvanzado.SelectedItem is Categoria seleccionada)
            {
                List<Articulo> filtrada = listaArticulos.FindAll(x => x.Categoria.Id == seleccionada.Id);
                dgvStock.DataSource = null;
                dgvStock.DataSource = filtrada;
                ocultarColumnas();
            }
        }

        private void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            /*cbFiltroAvanzado.Visible = false;
            lblFiltroAvanzado.Visible = false;
            cbFiltroAvanzado.DataSource = null;
            txBuscarSimple.Text = "";
            dgvStock.DataSource = listaArticulos;
            ocultarColumnas();*/

            cbFiltroAvanzado.Visible = false;
            lblFiltroAvanzado.Visible = false;
            btnQuitarFiltro.Visible = false; // lo ocultamos de nuevo

            cbFiltroAvanzado.DataSource = null;
            txBuscarSimple.Text = "";

            dgvStock.DataSource = listaArticulos;
            ocultarColumnas();
        }

        private void menuAyuda_Click(object sender, EventArgs e)
        {
            //aca va info de ayuda
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //aca va la info mia
        }
    }
}
