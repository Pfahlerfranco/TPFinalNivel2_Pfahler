using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.VisualBasic; 
using dominio;
using negocio;

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
            try
            {
                
                CargarCombos();

                if (articulo != null)
                {
                    txNombre.Text = articulo.Nombre;
                    txCod.Text = articulo.Codigo;
                    txDescrip.Text = articulo.Descripcion;

                    
                    if (articulo.Categoria != null)
                        cbCategoria.SelectedValue = articulo.Categoria.Id;
                    if (articulo.Marca != null)
                        cbMarca.SelectedValue = articulo.Marca.Id;

                    txImage.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    txPrecio.Text = articulo.Precio.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
        private void CargarCombos(int? idCategoriaSeleccionar = null, int? idMarcaSeleccionar = null)
        {
            var categoriaNegocio = new CategoriaNegocio();
            var marcaNegocio = new MarcaNegocio();

            cbCategoria.DataSource = categoriaNegocio.listar();
            cbCategoria.ValueMember = "Id";
            cbCategoria.DisplayMember = "Descripcion";

            cbMarca.DataSource = marcaNegocio.listar();
            cbMarca.ValueMember = "Id";
            cbMarca.DisplayMember = "Descripcion";

            if (idCategoriaSeleccionar.HasValue)
                cbCategoria.SelectedValue = idCategoriaSeleccionar.Value;

            if (idMarcaSeleccionar.HasValue)
                cbMarca.SelectedValue = idMarcaSeleccionar.Value;
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
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;

                string imagenParaBD = txImage.Text;

                if (archivo != null && !EsUrl(archivo.FileName))
                {
                    imagenParaBD = CopiarImagenLocal(archivo.FileName);
                }

                articulo.ImagenUrl = imagenParaBD;

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
                if (string.IsNullOrWhiteSpace(imagen))
                    throw new Exception("sin imagen");

                if (EsUrl(imagen))
                {
                    pxbArti.Load(imagen);
                }
                else
                {
                    string ruta = imagen;
                    if (!Path.IsPathRooted(ruta))
                        ruta = Path.Combine(Application.StartupPath, imagen);

                    pxbArti.Load(ruta);
                }
            }
            catch
            {
                pxbArti.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog
            {
                Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.gif;*.bmp",
                RestoreDirectory = true
            };

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txImage.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }

        private string CopiarImagenLocal(string origenAbsoluto)
        {
            if (!File.Exists(origenAbsoluto))
                throw new FileNotFoundException("La imagen de origen no existe.", origenAbsoluto);

            string fileName = Path.GetFileName(origenAbsoluto);
            string carpetaDestino = Path.Combine(Application.StartupPath, "images");
            Directory.CreateDirectory(carpetaDestino);
            string destinoAbsoluto = Path.Combine(carpetaDestino, fileName);

            if (!string.Equals(origenAbsoluto, destinoAbsoluto, StringComparison.OrdinalIgnoreCase))
                File.Copy(origenAbsoluto, destinoAbsoluto, true);

            return Path.Combine("images", fileName);
        }

        private bool EsUrl(string s)
            => !string.IsNullOrEmpty(s) && s.StartsWith("http", StringComparison.OrdinalIgnoreCase);


        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            string desc = Interaction.InputBox("Descripción de la nueva categoría:", "Nueva categoría", "");
            if (string.IsNullOrWhiteSpace(desc)) return;

            try
            {
                var catNeg = new CategoriaNegocio();


                catNeg.agregar(new Categoria { Descripcion = desc });
                CargarCombos();
                var lista = (List<Categoria>)cbCategoria.DataSource;
                var recienCreada = lista.FirstOrDefault(c => string.Equals(c.Descripcion, desc, StringComparison.OrdinalIgnoreCase));
                if (recienCreada != null)
                    cbCategoria.SelectedValue = recienCreada.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo crear la categoría: " + ex.Message);
            }
        }

        private void btnNuevaMarca_Click(object sender, EventArgs e)
        {
            string desc = Interaction.InputBox("Descripción de la nueva marca:", "Nueva marca", "");
            if (string.IsNullOrWhiteSpace(desc)) return;

            try
            {
                var marcaNeg = new MarcaNegocio();

                marcaNeg.agregar(new Marca { Descripcion = desc });
                CargarCombos();
                var lista = (List<Marca>)cbMarca.DataSource;
                var recienCreada = lista.FirstOrDefault(m => string.Equals(m.Descripcion, desc, StringComparison.OrdinalIgnoreCase));
                if (recienCreada != null)
                    cbMarca.SelectedValue = recienCreada.Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo crear la marca: " + ex.Message);
            }
        }
    }
}
