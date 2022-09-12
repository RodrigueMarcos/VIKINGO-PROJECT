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
            this.TBCiudad = new System.Windows.Forms.TextBox();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.LDni = new System.Windows.Forms.Label();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.CBGenero = new System.Windows.Forms.ComboBox();
            this.CBTipo = new System.Windows.Forms.ComboBox();
            this.agregar_ciudad = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(150, 53);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(47, 13);
            this.LApellido.TabIndex = 0;
            this.LApellido.Text = "Apellido:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(150, 100);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(47, 13);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "Nombre:";
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Location = new System.Drawing.Point(150, 148);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(45, 13);
            this.LTelefono.TabIndex = 2;
            this.LTelefono.Text = "Tel/Cel:";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Location = new System.Drawing.Point(150, 197);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(35, 13);
            this.LEmail.TabIndex = 3;
            this.LEmail.Text = "Email:";
            // 
            // LDireccion
            // 
            this.LDireccion.AutoSize = true;
            this.LDireccion.Location = new System.Drawing.Point(398, 100);
            this.LDireccion.Name = "LDireccion";
            this.LDireccion.Size = new System.Drawing.Size(55, 13);
            this.LDireccion.TabIndex = 4;
            this.LDireccion.Text = "Dirección:";
            this.LDireccion.Click += new System.EventHandler(this.LDireccion_Click);
            // 
            // LCiudad
            // 
            this.LCiudad.AutoSize = true;
            this.LCiudad.Location = new System.Drawing.Point(398, 60);
            this.LCiudad.Name = "LCiudad";
            this.LCiudad.Size = new System.Drawing.Size(43, 13);
            this.LCiudad.TabIndex = 5;
            this.LCiudad.Text = "Ciudad:";
            // 
            // LGenero
            // 
            this.LGenero.AutoSize = true;
            this.LGenero.Location = new System.Drawing.Point(398, 148);
            this.LGenero.Name = "LGenero";
            this.LGenero.Size = new System.Drawing.Size(45, 13);
            this.LGenero.TabIndex = 6;
            this.LGenero.Text = "Género:";
            // 
            // LTipo
            // 
            this.LTipo.AutoSize = true;
            this.LTipo.Location = new System.Drawing.Point(398, 201);
            this.LTipo.Name = "LTipo";
            this.LTipo.Size = new System.Drawing.Size(31, 13);
            this.LTipo.TabIndex = 7;
            this.LTipo.Text = "Tipo:";
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(214, 97);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(118, 20);
            this.TBNombre.TabIndex = 8;
            this.TBNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_letras_KeyPress);
            // 
            // TBContacto
            // 
            this.TBContacto.Location = new System.Drawing.Point(214, 145);
            this.TBContacto.Name = "TBContacto";
            this.TBContacto.Size = new System.Drawing.Size(118, 20);
            this.TBContacto.TabIndex = 9;
            this.TBContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numerico_KeyPress);
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(214, 194);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(118, 20);
            this.TBEmail.TabIndex = 10;
            // 
            // TBDireccion
            // 
            this.TBDireccion.Location = new System.Drawing.Point(468, 100);
            this.TBDireccion.Name = "TBDireccion";
            this.TBDireccion.Size = new System.Drawing.Size(118, 20);
            this.TBDireccion.TabIndex = 12;
            // 
            // TBCiudad
            // 
            this.TBCiudad.Location = new System.Drawing.Point(468, 53);
            this.TBCiudad.Name = "TBCiudad";
            this.TBCiudad.Size = new System.Drawing.Size(118, 20);
            this.TBCiudad.TabIndex = 13;
            this.TBCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_letras_KeyPress);
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(214, 49);
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(118, 20);
            this.TBApellido.TabIndex = 14;
            this.TBApellido.TextChanged += new System.EventHandler(this.TBApellido_TextChanged);
            this.TBApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_letras_KeyPress);
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(223, 294);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(134, 44);
            this.BCancelar.TabIndex = 16;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(435, 294);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(134, 44);
            this.BGuardar.TabIndex = 17;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(150, 246);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(29, 13);
            this.LDni.TabIndex = 18;
            this.LDni.Text = "DNI:";
            // 
            // TBDni
            // 
            this.TBDni.Location = new System.Drawing.Point(214, 243);
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(118, 20);
            this.TBDni.TabIndex = 19;
            this.TBDni.TextChanged += new System.EventHandler(this.TBDni_TextChanged);
            this.TBDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numerico_KeyPress);
            // 
            // CBGenero
            // 
            this.CBGenero.FormattingEnabled = true;
            this.CBGenero.Location = new System.Drawing.Point(468, 148);
            this.CBGenero.Name = "CBGenero";
            this.CBGenero.Size = new System.Drawing.Size(121, 21);
            this.CBGenero.TabIndex = 20;
            this.CBGenero.Text = "Seleccione...";
            // 
            // CBTipo
            // 
            this.CBTipo.FormattingEnabled = true;
            this.CBTipo.Location = new System.Drawing.Point(468, 197);
            this.CBTipo.Name = "CBTipo";
            this.CBTipo.Size = new System.Drawing.Size(121, 21);
            this.CBTipo.TabIndex = 21;
            this.CBTipo.Text = "Seleccione...";
            // 
            // agregar_ciudad
            // 
            this.agregar_ciudad.AutoSize = true;
            this.agregar_ciudad.Location = new System.Drawing.Point(615, 60);
            this.agregar_ciudad.Name = "agregar_ciudad";
            this.agregar_ciudad.Size = new System.Drawing.Size(44, 13);
            this.agregar_ciudad.TabIndex = 22;
            this.agregar_ciudad.TabStop = true;
            this.agregar_ciudad.Text = "Agregar";
            this.agregar_ciudad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.agregar_ciudad_LinkClicked);
            // 
            // Alta_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.agregar_ciudad);
            this.Controls.Add(this.CBTipo);
            this.Controls.Add(this.CBGenero);
            this.Controls.Add(this.TBDni);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.TBApellido);
            this.Controls.Add(this.TBCiudad);
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
            this.Name = "Alta_cliente";
            this.Text = "Nuevo cliente";
            this.Load += new System.EventHandler(this.Alta_cliente_Load);
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
        private System.Windows.Forms.TextBox TBCiudad;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.TextBox TBDni;
        private System.Windows.Forms.ComboBox CBGenero;
        private System.Windows.Forms.ComboBox CBTipo;
        private System.Windows.Forms.LinkLabel agregar_ciudad;
    }
}