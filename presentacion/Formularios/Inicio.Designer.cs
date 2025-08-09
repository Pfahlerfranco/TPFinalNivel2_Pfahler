namespace presentacion.Formularios
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.btInicio = new System.Windows.Forms.Button();
            this.pbxIcono = new System.Windows.Forms.PictureBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lbPassware = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // btInicio
            // 
            this.btInicio.BackColor = System.Drawing.Color.Transparent;
            this.btInicio.Location = new System.Drawing.Point(109, 396);
            this.btInicio.Name = "btInicio";
            this.btInicio.Size = new System.Drawing.Size(199, 58);
            this.btInicio.TabIndex = 0;
            this.btInicio.Text = "Iniciar Sesion";
            this.btInicio.UseVisualStyleBackColor = false;
            this.btInicio.Click += new System.EventHandler(this.btInicio_Click);
            // 
            // pbxIcono
            // 
            this.pbxIcono.Image = ((System.Drawing.Image)(resources.GetObject("pbxIcono.Image")));
            this.pbxIcono.Location = new System.Drawing.Point(136, 45);
            this.pbxIcono.Name = "pbxIcono";
            this.pbxIcono.Size = new System.Drawing.Size(140, 143);
            this.pbxIcono.TabIndex = 1;
            this.pbxIcono.TabStop = false;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.BackColor = System.Drawing.Color.Transparent;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(126, 217);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(150, 24);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "Usuario: admin";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(109, 244);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(199, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(109, 338);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(199, 20);
            this.txtContrasena.TabIndex = 4;
            // 
            // lbPassware
            // 
            this.lbPassware.AutoSize = true;
            this.lbPassware.BackColor = System.Drawing.Color.Transparent;
            this.lbPassware.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassware.Location = new System.Drawing.Point(120, 311);
            this.lbPassware.Name = "lbPassware";
            this.lbPassware.Size = new System.Drawing.Size(178, 24);
            this.lbPassware.TabIndex = 5;
            this.lbPassware.Text = "Contraseña : 1234";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(440, 511);
            this.Controls.Add(this.lbPassware);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.pbxIcono);
            this.Controls.Add(this.btInicio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInicio;
        private System.Windows.Forms.PictureBox pbxIcono;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lbPassware;
    }
}