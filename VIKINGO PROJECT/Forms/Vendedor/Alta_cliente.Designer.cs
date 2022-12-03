namespace VIKINGO_PROJECT.Forms.Vendedor
{
    partial class Alta_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alta_cliente));
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LTelefono = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.LDireccion = new System.Windows.Forms.Label();
            this.LCiudad = new System.Windows.Forms.Label();
            this.LGenero = new System.Windows.Forms.Label();
            this.LTipo = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBContacto = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBDireccion = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.LDni = new System.Windows.Forms.Label();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.CBGenero = new System.Windows.Forms.ComboBox();
            this.CBTipo = new System.Windows.Forms.ComboBox();
            this.agregar_ciudad = new System.Windows.Forms.LinkLabel();
            this.LAdvertencia = new System.Windows.Forms.Label();
            this.DGClientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TBCiudad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(346, 99);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(56, 13);
            this.LApellido.TabIndex = 0;
            this.LApellido.Text = "Apellido:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(346, 146);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(54, 13);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "Nombre:";
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.Location = new System.Drawing.Point(346, 194);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(53, 13);
            this.LTelefono.TabIndex = 2;
            this.LTelefono.Text = "Tel/Cel:";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmail.Location = new System.Drawing.Point(346, 243);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(41, 13);
            this.LEmail.TabIndex = 3;
            this.LEmail.Text = "Email:";
            // 
            // LDireccion
            // 
            this.LDireccion.AutoSize = true;
            this.LDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDireccion.Location = new System.Drawing.Point(594, 99);
            this.LDireccion.Name = "LDireccion";
            this.LDireccion.Size = new System.Drawing.Size(65, 13);
            this.LDireccion.TabIndex = 4;
            this.LDireccion.Text = "Dirección:";
            // 
            // LCiudad
            // 
            this.LCiudad.AutoSize = true;
            this.LCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCiudad.Location = new System.Drawing.Point(594, 59);
            this.LCiudad.Name = "LCiudad";
            this.LCiudad.Size = new System.Drawing.Size(50, 13);
            this.LCiudad.TabIndex = 5;
            this.LCiudad.Text = "Ciudad:";
            // 
            // LGenero
            // 
            this.LGenero.AutoSize = true;
            this.LGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGenero.Location = new System.Drawing.Point(594, 147);
            this.LGenero.Name = "LGenero";
            this.LGenero.Size = new System.Drawing.Size(52, 13);
            this.LGenero.TabIndex = 6;
            this.LGenero.Text = "Género:";
            // 
            // LTipo
            // 
            this.LTipo.AutoSize = true;
            this.LTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTipo.Location = new System.Drawing.Point(594, 200);
            this.LTipo.Name = "LTipo";
            this.LTipo.Size = new System.Drawing.Size(36, 13);
            this.LTipo.TabIndex = 7;
            this.LTipo.Text = "Tipo:";
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(410, 143);
            this.TBNombre.MaxLength = 30;
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(118, 20);
            this.TBNombre.TabIndex = 3;
            this.TBNombre.TextChanged += new System.EventHandler(this.TBNombre_TextChanged);
            this.TBNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_letras_KeyPress);
            // 
            // TBContacto
            // 
            this.TBContacto.Location = new System.Drawing.Point(410, 191);
            this.TBContacto.MaxLength = 16;
            this.TBContacto.Name = "TBContacto";
            this.TBContacto.Size = new System.Drawing.Size(118, 20);
            this.TBContacto.TabIndex = 4;
            this.TBContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numerico_KeyPress);
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(410, 240);
            this.TBEmail.MaxLength = 30;
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(118, 20);
            this.TBEmail.TabIndex = 5;
            // 
            // TBDireccion
            // 
            this.TBDireccion.Location = new System.Drawing.Point(664, 99);
            this.TBDireccion.MaxLength = 30;
            this.TBDireccion.Name = "TBDireccion";
            this.TBDireccion.Size = new System.Drawing.Size(118, 20);
            this.TBDireccion.TabIndex = 7;
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(410, 95);
            this.TBApellido.MaxLength = 30;
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(118, 20);
            this.TBApellido.TabIndex = 2;
            this.TBApellido.TextChanged += new System.EventHandler(this.TBApellido_TextChanged);
            this.TBApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_letras_KeyPress);
            // 
            // BCancelar
            // 
            this.BCancelar.BackColor = System.Drawing.Color.Tomato;
            this.BCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BCancelar.Image")));
            this.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCancelar.Location = new System.Drawing.Point(410, 283);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(134, 44);
            this.BCancelar.TabIndex = 10;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.BackColor = System.Drawing.Color.LimeGreen;
            this.BGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BGuardar.Image")));
            this.BGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGuardar.Location = new System.Drawing.Point(630, 283);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(134, 44);
            this.BGuardar.TabIndex = 11;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = false;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.Location = new System.Drawing.Point(346, 58);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(33, 13);
            this.LDni.TabIndex = 18;
            this.LDni.Text = "DNI:";
            // 
            // TBDni
            // 
            this.TBDni.Location = new System.Drawing.Point(410, 55);
            this.TBDni.MaxLength = 9;
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(118, 20);
            this.TBDni.TabIndex = 1;
            this.TBDni.TextChanged += new System.EventHandler(this.TBDni_TextChanged);
            this.TBDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numerico_KeyPress);
            // 
            // CBGenero
            // 
            this.CBGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBGenero.FormattingEnabled = true;
            this.CBGenero.Location = new System.Drawing.Point(664, 147);
            this.CBGenero.Name = "CBGenero";
            this.CBGenero.Size = new System.Drawing.Size(121, 21);
            this.CBGenero.TabIndex = 8;
            // 
            // CBTipo
            // 
            this.CBTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTipo.FormattingEnabled = true;
            this.CBTipo.Location = new System.Drawing.Point(664, 196);
            this.CBTipo.Name = "CBTipo";
            this.CBTipo.Size = new System.Drawing.Size(121, 21);
            this.CBTipo.TabIndex = 9;
            // 
            // agregar_ciudad
            // 
            this.agregar_ciudad.AutoSize = true;
            this.agregar_ciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_ciudad.Location = new System.Drawing.Point(811, 55);
            this.agregar_ciudad.Name = "agregar_ciudad";
            this.agregar_ciudad.Size = new System.Drawing.Size(51, 13);
            this.agregar_ciudad.TabIndex = 22;
            this.agregar_ciudad.TabStop = true;
            this.agregar_ciudad.Text = "Agregar";
            this.agregar_ciudad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.agregar_ciudad_LinkClicked);
            // 
            // LAdvertencia
            // 
            this.LAdvertencia.AutoSize = true;
            this.LAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.LAdvertencia.Location = new System.Drawing.Point(594, 249);
            this.LAdvertencia.Name = "LAdvertencia";
            this.LAdvertencia.Size = new System.Drawing.Size(75, 13);
            this.LAdvertencia.TabIndex = 23;
            this.LAdvertencia.Text = "Advertencia";
            // 
            // DGClientes
            // 
            this.DGClientes.AllowUserToAddRows = false;
            this.DGClientes.AllowUserToDeleteRows = false;
            this.DGClientes.AllowUserToOrderColumns = true;
            this.DGClientes.AllowUserToResizeColumns = false;
            this.DGClientes.AllowUserToResizeRows = false;
            this.DGClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGClientes.Location = new System.Drawing.Point(0, 411);
            this.DGClientes.Name = "DGClientes";
            this.DGClientes.ReadOnly = true;
            this.DGClientes.Size = new System.Drawing.Size(1100, 189);
            this.DGClientes.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Clientes registrados";
            // 
            // TBCiudad
            // 
            this.TBCiudad.Location = new System.Drawing.Point(664, 58);
            this.TBCiudad.Name = "TBCiudad";
            this.TBCiudad.Size = new System.Drawing.Size(118, 20);
            this.TBCiudad.TabIndex = 6;
            // 
            // Alta_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.ControlBox = false;
            this.Controls.Add(this.TBCiudad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGClientes);
            this.Controls.Add(this.LAdvertencia);
            this.Controls.Add(this.agregar_ciudad);
            this.Controls.Add(this.CBTipo);
            this.Controls.Add(this.CBGenero);
            this.Controls.Add(this.TBDni);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.TBApellido);
            this.Controls.Add(this.TBDireccion);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.TBContacto);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.LTipo);
            this.Controls.Add(this.LGenero);
            this.Controls.Add(this.LCiudad);
            this.Controls.Add(this.LDireccion);
            this.Controls.Add(this.LEmail);
            this.Controls.Add(this.LTelefono);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.LApellido);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alta_cliente";
            this.Text = "Nuevo cliente";
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label LDireccion;
        private System.Windows.Forms.Label LCiudad;
        private System.Windows.Forms.Label LGenero;
        private System.Windows.Forms.Label LTipo;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBContacto;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBDireccion;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.TextBox TBDni;
        private System.Windows.Forms.ComboBox CBGenero;
        private System.Windows.Forms.ComboBox CBTipo;
        private System.Windows.Forms.LinkLabel agregar_ciudad;
        private System.Windows.Forms.Label LAdvertencia;
        private System.Windows.Forms.DataGridView DGClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBCiudad;
    }
}