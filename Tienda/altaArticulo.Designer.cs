namespace Tienda
{
    partial class altaArticulo
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
            this.codigo = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.Label();
            this.txtcd = new System.Windows.Forms.TextBox();
            this.nombretx = new System.Windows.Forms.TextBox();
            this.descripcionTx = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.precioTxt = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lbUrl = new System.Windows.Forms.Label();
            this.pbxAlta = new System.Windows.Forms.PictureBox();
            this.btnImagenLocal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Location = new System.Drawing.Point(53, 53);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(39, 13);
            this.codigo.TabIndex = 0;
            this.codigo.Text = "codigo";
            this.codigo.Click += new System.EventHandler(this.label1_Click);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(53, 91);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(42, 13);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "nombre";
            // 
            // descripcion
            // 
            this.descripcion.AutoSize = true;
            this.descripcion.Location = new System.Drawing.Point(53, 130);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(61, 13);
            this.descripcion.TabIndex = 2;
            this.descripcion.Text = "descripcion";
            // 
            // txtcd
            // 
            this.txtcd.Location = new System.Drawing.Point(124, 46);
            this.txtcd.Name = "txtcd";
            this.txtcd.Size = new System.Drawing.Size(121, 20);
            this.txtcd.TabIndex = 0;
            // 
            // nombretx
            // 
            this.nombretx.Location = new System.Drawing.Point(124, 84);
            this.nombretx.Name = "nombretx";
            this.nombretx.Size = new System.Drawing.Size(121, 20);
            this.nombretx.TabIndex = 1;
            // 
            // descripcionTx
            // 
            this.descripcionTx.Location = new System.Drawing.Point(124, 123);
            this.descripcionTx.Name = "descripcionTx";
            this.descripcionTx.Size = new System.Drawing.Size(121, 20);
            this.descripcionTx.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(56, 372);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "aceptar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(170, 372);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(124, 248);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 5;
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(124, 293);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 21);
            this.cboMarca.TabIndex = 6;
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(53, 256);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(51, 13);
            this.lbCategoria.TabIndex = 10;
            this.lbCategoria.Text = "categoria";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(53, 301);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(36, 13);
            this.lbMarca.TabIndex = 11;
            this.lbMarca.Text = "marca";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(53, 165);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(36, 13);
            this.lbPrecio.TabIndex = 12;
            this.lbPrecio.Text = "precio";
            // 
            // precioTxt
            // 
            this.precioTxt.Location = new System.Drawing.Point(124, 162);
            this.precioTxt.Name = "precioTxt";
            this.precioTxt.Size = new System.Drawing.Size(121, 20);
            this.precioTxt.TabIndex = 3;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(124, 204);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(121, 20);
            this.txtUrl.TabIndex = 4;
            this.txtUrl.Leave += new System.EventHandler(this.txtUrl_Leave);
            // 
            // lbUrl
            // 
            this.lbUrl.AutoSize = true;
            this.lbUrl.Location = new System.Drawing.Point(53, 207);
            this.lbUrl.Name = "lbUrl";
            this.lbUrl.Size = new System.Drawing.Size(41, 13);
            this.lbUrl.TabIndex = 14;
            this.lbUrl.Text = "imagen";
            // 
            // pbxAlta
            // 
            this.pbxAlta.Location = new System.Drawing.Point(288, 46);
            this.pbxAlta.Name = "pbxAlta";
            this.pbxAlta.Size = new System.Drawing.Size(262, 289);
            this.pbxAlta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAlta.TabIndex = 16;
            this.pbxAlta.TabStop = false;
            // 
            // btnImagenLocal
            // 
            this.btnImagenLocal.Location = new System.Drawing.Point(251, 204);
            this.btnImagenLocal.Name = "btnImagenLocal";
            this.btnImagenLocal.Size = new System.Drawing.Size(21, 20);
            this.btnImagenLocal.TabIndex = 17;
            this.btnImagenLocal.Text = "+";
            this.btnImagenLocal.UseVisualStyleBackColor = true;
            this.btnImagenLocal.Click += new System.EventHandler(this.btnImagenLocal_Click);
            // 
            // altaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tienda.Properties.Resources.Blue_And_White_Modern_Coming_Soon_Twitter_Header__1_;
            this.ClientSize = new System.Drawing.Size(763, 456);
            this.Controls.Add(this.btnImagenLocal);
            this.Controls.Add(this.pbxAlta);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lbUrl);
            this.Controls.Add(this.precioTxt);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.descripcionTx);
            this.Controls.Add(this.nombretx);
            this.Controls.Add(this.txtcd);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.codigo);
            this.Name = "altaArticulo";
            this.Text = "altaArticulo";
            this.Load += new System.EventHandler(this.altaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.TextBox txtcd;
        private System.Windows.Forms.TextBox nombretx;
        private System.Windows.Forms.TextBox descripcionTx;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.TextBox precioTxt;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lbUrl;
        private System.Windows.Forms.PictureBox pbxAlta;
        private System.Windows.Forms.Button btnImagenLocal;
    }
}