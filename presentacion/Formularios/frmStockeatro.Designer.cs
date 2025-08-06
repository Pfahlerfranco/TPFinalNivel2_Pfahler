namespace presentacion
{
    partial class Stockeatro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stockeatro));
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarSM = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarSM = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarSM = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.filtroAvanzandoSM = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbxStock = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbBuscarSimple = new System.Windows.Forms.Label();
            this.txBuscarSimple = new System.Windows.Forms.TextBox();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.cbFiltroAvanzado = new System.Windows.Forms.ComboBox();
            this.btnQuitarFiltro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStock
            // 
            this.dgvStock.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStock.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStock.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStock.Location = new System.Drawing.Point(49, 149);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(643, 381);
            this.dgvStock.TabIndex = 0;
            this.dgvStock.SelectionChanged += new System.EventHandler(this.dgvArticulo_SelectionChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInventario,
            this.menuBuscar,
            this.menuAyuda,
            this.acercaDeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1182, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuInventario
            // 
            this.menuInventario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarSM,
            this.modificarSM,
            this.eliminarSM});
            this.menuInventario.Name = "menuInventario";
            this.menuInventario.Size = new System.Drawing.Size(72, 20);
            this.menuInventario.Text = "Inventario";
            // 
            // agregarSM
            // 
            this.agregarSM.Name = "agregarSM";
            this.agregarSM.Size = new System.Drawing.Size(180, 22);
            this.agregarSM.Text = "Agregar";
            this.agregarSM.Click += new System.EventHandler(this.agregarSM_Click);
            // 
            // modificarSM
            // 
            this.modificarSM.Name = "modificarSM";
            this.modificarSM.Size = new System.Drawing.Size(180, 22);
            this.modificarSM.Text = "Modificar";
            this.modificarSM.Click += new System.EventHandler(this.modificarSM_Click);
            // 
            // eliminarSM
            // 
            this.eliminarSM.Name = "eliminarSM";
            this.eliminarSM.Size = new System.Drawing.Size(180, 22);
            this.eliminarSM.Text = "Eliminar";
            this.eliminarSM.Click += new System.EventHandler(this.eliminarSM_Click);
            // 
            // menuBuscar
            // 
            this.menuBuscar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filtroAvanzandoSM});
            this.menuBuscar.Name = "menuBuscar";
            this.menuBuscar.Size = new System.Drawing.Size(54, 20);
            this.menuBuscar.Text = "Buscar";
            // 
            // filtroAvanzandoSM
            // 
            this.filtroAvanzandoSM.Name = "filtroAvanzandoSM";
            this.filtroAvanzandoSM.Size = new System.Drawing.Size(180, 22);
            this.filtroAvanzandoSM.Text = "Filtro avanzando";
            this.filtroAvanzandoSM.Click += new System.EventHandler(this.filtroAvanzandoSM_Click);
            // 
            // menuAyuda
            // 
            this.menuAyuda.Name = "menuAyuda";
            this.menuAyuda.Size = new System.Drawing.Size(53, 20);
            this.menuAyuda.Text = "Ayuda";
            this.menuAyuda.Click += new System.EventHandler(this.menuAyuda_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // pbxStock
            // 
            this.pbxStock.BackColor = System.Drawing.Color.Honeydew;
            this.pbxStock.Location = new System.Drawing.Point(764, 149);
            this.pbxStock.Name = "pbxStock";
            this.pbxStock.Size = new System.Drawing.Size(365, 381);
            this.pbxStock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxStock.TabIndex = 2;
            this.pbxStock.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbBuscarSimple
            // 
            this.lbBuscarSimple.AutoSize = true;
            this.lbBuscarSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuscarSimple.Location = new System.Drawing.Point(45, 77);
            this.lbBuscarSimple.Name = "lbBuscarSimple";
            this.lbBuscarSimple.Size = new System.Drawing.Size(73, 24);
            this.lbBuscarSimple.TabIndex = 3;
            this.lbBuscarSimple.Text = "Buscar:";
            // 
            // txBuscarSimple
            // 
            this.txBuscarSimple.Location = new System.Drawing.Point(124, 82);
            this.txBuscarSimple.Name = "txBuscarSimple";
            this.txBuscarSimple.Size = new System.Drawing.Size(385, 20);
            this.txBuscarSimple.TabIndex = 4;
            this.txBuscarSimple.TextChanged += new System.EventHandler(this.txBuscarSimple_TextChanged);
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(45, 594);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(161, 24);
            this.lblFiltroAvanzado.TabIndex = 5;
            this.lblFiltroAvanzado.Text = "Filtro Avanzado:";
            this.lblFiltroAvanzado.Visible = false;
            // 
            // cbFiltroAvanzado
            // 
            this.cbFiltroAvanzado.FormattingEnabled = true;
            this.cbFiltroAvanzado.Location = new System.Drawing.Point(212, 597);
            this.cbFiltroAvanzado.Name = "cbFiltroAvanzado";
            this.cbFiltroAvanzado.Size = new System.Drawing.Size(183, 21);
            this.cbFiltroAvanzado.TabIndex = 6;
            this.cbFiltroAvanzado.Visible = false;
            this.cbFiltroAvanzado.SelectionChangeCommitted += new System.EventHandler(this.cbFiltroAvanzado_SelectionChangeCommitted);
            // 
            // btnQuitarFiltro
            // 
            this.btnQuitarFiltro.Location = new System.Drawing.Point(418, 597);
            this.btnQuitarFiltro.Name = "btnQuitarFiltro";
            this.btnQuitarFiltro.Size = new System.Drawing.Size(91, 23);
            this.btnQuitarFiltro.TabIndex = 7;
            this.btnQuitarFiltro.Text = "Quitar";
            this.btnQuitarFiltro.UseVisualStyleBackColor = true;
            this.btnQuitarFiltro.Visible = false;
            this.btnQuitarFiltro.Click += new System.EventHandler(this.btnQuitarFiltro_Click);
            // 
            // Stockeatro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1182, 658);
            this.Controls.Add(this.btnQuitarFiltro);
            this.Controls.Add(this.cbFiltroAvanzado);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.txBuscarSimple);
            this.Controls.Add(this.lbBuscarSimple);
            this.Controls.Add(this.pbxStock);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stockeatro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stockeator";
            this.Load += new System.EventHandler(this.Stockeatro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuInventario;
        private System.Windows.Forms.ToolStripMenuItem agregarSM;
        private System.Windows.Forms.ToolStripMenuItem modificarSM;
        private System.Windows.Forms.ToolStripMenuItem eliminarSM;
        private System.Windows.Forms.ToolStripMenuItem menuBuscar;
        private System.Windows.Forms.ToolStripMenuItem filtroAvanzandoSM;
        private System.Windows.Forms.ToolStripMenuItem menuAyuda;
        private System.Windows.Forms.PictureBox pbxStock;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Label lbBuscarSimple;
        private System.Windows.Forms.TextBox txBuscarSimple;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.ComboBox cbFiltroAvanzado;
        private System.Windows.Forms.Button btnQuitarFiltro;
    }
}

