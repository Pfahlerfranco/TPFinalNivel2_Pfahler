namespace presentacion.Formularios
{
    partial class frmAltaArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAltaArticulo));
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbCod = new System.Windows.Forms.Label();
            this.lbDescrip = new System.Windows.Forms.Label();
            this.lbImage = new System.Windows.Forms.Label();
            this.lbCateg = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txDescrip = new System.Windows.Forms.TextBox();
            this.txCod = new System.Windows.Forms.TextBox();
            this.txImage = new System.Windows.Forms.TextBox();
            this.txPrecio = new System.Windows.Forms.TextBox();
            this.pxbArti = new System.Windows.Forms.PictureBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btAcept = new System.Windows.Forms.Button();
            this.btAddImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pxbArti)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(38, 78);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(91, 24);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbCod
            // 
            this.lbCod.AutoSize = true;
            this.lbCod.BackColor = System.Drawing.Color.Transparent;
            this.lbCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCod.Location = new System.Drawing.Point(38, 132);
            this.lbCod.Name = "lbCod";
            this.lbCod.Size = new System.Drawing.Size(83, 24);
            this.lbCod.TabIndex = 1;
            this.lbCod.Text = "Codigo:";
            // 
            // lbDescrip
            // 
            this.lbDescrip.AutoSize = true;
            this.lbDescrip.BackColor = System.Drawing.Color.Transparent;
            this.lbDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescrip.Location = new System.Drawing.Point(38, 181);
            this.lbDescrip.Name = "lbDescrip";
            this.lbDescrip.Size = new System.Drawing.Size(127, 24);
            this.lbDescrip.TabIndex = 2;
            this.lbDescrip.Text = "Descripcion:";
            // 
            // lbImage
            // 
            this.lbImage.AutoSize = true;
            this.lbImage.BackColor = System.Drawing.Color.Transparent;
            this.lbImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImage.Location = new System.Drawing.Point(38, 325);
            this.lbImage.Name = "lbImage";
            this.lbImage.Size = new System.Drawing.Size(85, 24);
            this.lbImage.TabIndex = 5;
            this.lbImage.Text = "Imagen:";
            // 
            // lbCateg
            // 
            this.lbCateg.AutoSize = true;
            this.lbCateg.BackColor = System.Drawing.Color.Transparent;
            this.lbCateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCateg.Location = new System.Drawing.Point(38, 276);
            this.lbCateg.Name = "lbCateg";
            this.lbCateg.Size = new System.Drawing.Size(105, 24);
            this.lbCateg.TabIndex = 4;
            this.lbCateg.Text = "Categoria:";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.BackColor = System.Drawing.Color.Transparent;
            this.lbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.Location = new System.Drawing.Point(38, 222);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(73, 24);
            this.lbMarca.TabIndex = 3;
            this.lbMarca.Text = "Marca:";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.Location = new System.Drawing.Point(38, 371);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(76, 24);
            this.lbPrecio.TabIndex = 6;
            this.lbPrecio.Text = "Precio:";
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(180, 82);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(129, 20);
            this.txNombre.TabIndex = 0;
            // 
            // txDescrip
            // 
            this.txDescrip.Location = new System.Drawing.Point(180, 181);
            this.txDescrip.Name = "txDescrip";
            this.txDescrip.Size = new System.Drawing.Size(129, 20);
            this.txDescrip.TabIndex = 2;
            // 
            // txCod
            // 
            this.txCod.Location = new System.Drawing.Point(180, 136);
            this.txCod.Name = "txCod";
            this.txCod.Size = new System.Drawing.Size(129, 20);
            this.txCod.TabIndex = 1;
            // 
            // txImage
            // 
            this.txImage.Location = new System.Drawing.Point(180, 325);
            this.txImage.Name = "txImage";
            this.txImage.Size = new System.Drawing.Size(129, 20);
            this.txImage.TabIndex = 5;
            // 
            // txPrecio
            // 
            this.txPrecio.Location = new System.Drawing.Point(180, 375);
            this.txPrecio.Name = "txPrecio";
            this.txPrecio.Size = new System.Drawing.Size(129, 20);
            this.txPrecio.TabIndex = 6;
            // 
            // pxbArti
            // 
            this.pxbArti.BackColor = System.Drawing.Color.LightYellow;
            this.pxbArti.Location = new System.Drawing.Point(357, 78);
            this.pxbArti.Name = "pxbArti";
            this.pxbArti.Size = new System.Drawing.Size(332, 317);
            this.pxbArti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxbArti.TabIndex = 12;
            this.pxbArti.TabStop = false;
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(180, 227);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(129, 21);
            this.cbMarca.TabIndex = 3;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(180, 279);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(129, 21);
            this.cbCategoria.TabIndex = 4;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.White;
            this.btCancel.Location = new System.Drawing.Point(568, 481);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(142, 34);
            this.btCancel.TabIndex = 15;
            this.btCancel.Text = "Cancelar";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btAcept
            // 
            this.btAcept.BackColor = System.Drawing.Color.White;
            this.btAcept.Location = new System.Drawing.Point(399, 481);
            this.btAcept.Name = "btAcept";
            this.btAcept.Size = new System.Drawing.Size(142, 34);
            this.btAcept.TabIndex = 7;
            this.btAcept.Text = "Aceptar";
            this.btAcept.UseVisualStyleBackColor = false;
            this.btAcept.Click += new System.EventHandler(this.btAcept_Click);
            // 
            // btAddImage
            // 
            this.btAddImage.BackColor = System.Drawing.Color.White;
            this.btAddImage.Location = new System.Drawing.Point(315, 322);
            this.btAddImage.Name = "btAddImage";
            this.btAddImage.Size = new System.Drawing.Size(25, 25);
            this.btAddImage.TabIndex = 17;
            this.btAddImage.Text = "+";
            this.btAddImage.UseVisualStyleBackColor = false;
            this.btAddImage.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(722, 527);
            this.Controls.Add(this.btAddImage);
            this.Controls.Add(this.btAcept);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.pxbArti);
            this.Controls.Add(this.txPrecio);
            this.Controls.Add(this.txImage);
            this.Controls.Add(this.txCod);
            this.Controls.Add(this.txDescrip);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbImage);
            this.Controls.Add(this.lbCateg);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbDescrip);
            this.Controls.Add(this.lbCod);
            this.Controls.Add(this.lbNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAltaArticulo";
            this.Text = "frmAltaArticulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pxbArti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCod;
        private System.Windows.Forms.Label lbDescrip;
        private System.Windows.Forms.Label lbImage;
        private System.Windows.Forms.Label lbCateg;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txDescrip;
        private System.Windows.Forms.TextBox txCod;
        private System.Windows.Forms.TextBox txImage;
        private System.Windows.Forms.TextBox txPrecio;
        private System.Windows.Forms.PictureBox pxbArti;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btAcept;
        private System.Windows.Forms.Button btAddImage;
    }
}