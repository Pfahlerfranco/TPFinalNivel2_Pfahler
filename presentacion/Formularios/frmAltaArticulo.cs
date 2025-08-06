using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;
using dominio;
using negocio;
using System.Configuration;
using System.IO;

namespace presentacion.Formularios
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                MarcaNegocio marcaNegocio = new MarcaNegocio();

                cbCategoria.DataSource = categoriaNegocio.listar();
                cbCategoria.ValueMember = "Id";
                cbCategoria.DisplayMember = "Descripcion";

                cbMarca.DataSource = marcaNegocio.listar();
                cbMarca.ValueMember = "Id";
                cbMarca.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txNombre.Text = articulo.Nombre;
                    txCod.Text = articulo.Codigo;
                    txDescrip.Text = articulo.Descripcion;
                    cbCategoria.SelectedValue = articulo.Categoria.Id;
                    cbMarca.SelectedValue = articulo.Marca.Id;
                    cargarImagen(articulo.ImagenUrl);
                    txPrecio.Text = articulo.Precio.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btAcept_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Nombre = txNombre.Text;
                articulo.Codigo = txCod.Text;
                articulo.Descripcion = txDescrip.Text;              
                articulo.Marca = (Marca)cbMarca.SelectedItem;
                articulo.Categoria= (Categoria)cbCategoria.SelectedItem;
                articulo.ImagenUrl = txImage.Text;
                decimal.TryParse(txPrecio.Text, out decimal precio);
                articulo.Precio = precio;

                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }

                //Guardo imagen si la levantó localmente:
                if (archivo != null && !(txImage.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txImage.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pxbArti.Load(imagen);
            }
            catch
            {
                pxbArti.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txImage.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                //guardo la imagen
                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
            }

        }
    }
}
