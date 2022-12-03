namespace VIKINGO_PROJECT.Forms.Vendedor
{
    partial class Gestionar_cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestionar_cliente));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.TBBuscadorNom = new System.Windows.Forms.TextBox();
            this.TBBuscadorApe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.BActualizar = new System.Windows.Forms.Button();
            this.TBCiudad = new System.Windows.Forms.TextBox();
            this.LAdvertencia = new System.Windows.Forms.Label();
            this.agregar_ciudad = new System.Windows.Forms.LinkLabel();
            this.CBTipo = new System.Windows.Forms.ComboBox();
            this.CBGenero = new System.Windows.Forms.ComboBox();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.LDni = new System.Windows.Forms.Label();
            this.BCancelar = new System.Windows.Forms.Button();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.TBDireccion = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBContacto = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.LTipo = new System.Windows.Forms.Label();
            this.LGenero = new System.Windows.Forms.Label();
            this.LCiudad = new System.Windows.Forms.Label();
            this.LDireccion = new System.Windows.Forms.Label();
            this.LEmail = new System.Windows.Forms.Label();
            this.LTelefono = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.DGClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.BActualizar);
            this.splitContainer1.Panel1.Controls.Add(this.TBCiudad);
            this.splitContainer1.Panel1.Controls.Add(this.LAdvertencia);
            this.splitContainer1.Panel1.Controls.Add(this.agregar_ciudad);
            this.splitContainer1.Panel1.Controls.Add(this.CBTipo);
            this.splitContainer1.Panel1.Controls.Add(this.CBGenero);
            this.splitContainer1.Panel1.Controls.Add(this.TBDni);
            this.splitContainer1.Panel1.Controls.Add(this.LDni);
            this.splitContainer1.Panel1.Controls.Add(this.BCancelar);
            this.splitContainer1.Panel1.Controls.Add(this.TBApellido);
            this.splitContainer1.Panel1.Controls.Add(this.TBDireccion);
            this.splitContainer1.Panel1.Controls.Add(this.TBEmail);
            this.splitContainer1.Panel1.Controls.Add(this.TBContacto);
            this.splitContainer1.Panel1.Controls.Add(this.TBNombre);
            this.splitContainer1.Panel1.Controls.Add(this.LTipo);
            this.splitContainer1.Panel1.Controls.Add(this.LGenero);
            this.splitContainer1.Panel1.Controls.Add(this.LCiudad);
            this.splitContainer1.Panel1.Controls.Add(this.LDireccion);
            this.splitContainer1.Panel1.Controls.Add(this.LEmail);
            this.splitContainer1.Panel1.Controls.Add(this.LTelefono);
            this.splitContainer1.Panel1.Controls.Add(this.LNombre);
            this.splitContainer1.Panel1.Controls.Add(this.LApellido);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DGClientes);
            this.splitContainer1.Size = new System.Drawing.Size(1084, 561);
            this.splitContainer1.SplitterDistance = 405;
            this.splitContainer1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Lista de Clientes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TBBuscadorNom);
            this.panel1.Controls.Add(this.TBBuscadorApe);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TBBuscar);
            this.panel1.Location = new System.Drawing.Point(277, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 81);
            this.panel1.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(360, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Por Nombre:";
            // 
            // TBBuscadorNom
            // 
            this.TBBuscadorNom.Location = new System.Drawing.Point(434, 33);
            this.TBBuscadorNom.Name = "TBBuscadorNom";
            this.TBBuscadorNom.Size = new System.Drawing.Size(100, 20);
            this.TBBuscadorNom.TabIndex = 62;
            this.TBBuscadorNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_letras_KeyPress);
            this.TBBuscadorNom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBBuscadorNom_KeyUp);
            // 
            // TBBuscadorApe
            // 
            this.TBBuscadorApe.Location = new System.Drawing.Point(254, 33);
            this.TBBuscadorApe.Name = "TBBuscadorApe";
            this.TBBuscadorApe.Size = new System.Drawing.Size(100, 20);
            this.TBBuscadorApe.TabIndex = 61;
            this.TBBuscadorApe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_letras_KeyPress);
            this.TBBuscadorApe.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBBuscadorApe_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Por Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Por DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Buscardo";
            // 
            // TBBuscar
            // 
            this.TBBuscar.Location = new System.Drawing.Point(63, 33);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(100, 20);
            this.TBBuscar.TabIndex = 56;
            this.TBBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numerico_KeyPress);
            this.TBBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBBuscar_KeyUp);
            // 
            // BActualizar
            // 
            this.BActualizar.BackColor = System.Drawing.Color.Turquoise;
            this.BActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BActualizar.ForeColor = System.Drawing.Color.Black;
            this.BActualizar.Image = ((System.Drawing.Image)(resources.GetObject("BActualizar.Image")));
            this.BActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BActualizar.Location = new System.Drawing.Point(584, 192);
            this.BActualizar.Name = "BActualizar";
            this.BActualizar.Size = new System.Drawing.Size(134, 44);
            this.BActualizar.TabIndex = 50;
            this.BActualizar.Text = "Actualizar";
            this.BActualizar.UseVisualStyleBackColor = false;
            this.BActualizar.Click += new System.EventHandler(this.BActualizar_Click);
            // 
            // TBCiudad
            // 
            this.TBCiudad.Location = new System.Drawing.Point(703, 49);
            this.TBCiudad.Name = "TBCiudad";
            this.TBCiudad.ReadOnly = true;
            this.TBCiudad.Size = new System.Drawing.Size(118, 20);
            this.TBCiudad.TabIndex = 45;
            // 
            // LAdvertencia
            // 
            this.LAdvertencia.AutoSize = true;
            this.LAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.LAdvertencia.Location = new System.Drawing.Point(195, 181);
            this.LAdvertencia.Name = "LAdvertencia";
            this.LAdvertencia.Size = new System.Drawing.Size(75, 13);
            this.LAdvertencia.TabIndex = 54;
            this.LAdvertencia.Text = "Advertencia";
            // 
            // agregar_ciudad
            // 
            this.agregar_ciudad.AutoSize = true;
            this.agregar_ciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar_ciudad.Location = new System.Drawing.Point(850, 46);
            this.agregar_ciudad.Name = "agregar_ciudad";
            this.agregar_ciudad.Size = new System.Drawing.Size(51, 13);
            this.agregar_ciudad.TabIndex = 53;
            this.agregar_ciudad.TabStop = true;
            this.agregar_ciudad.Text = "Agregar";
            this.agregar_ciudad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.agregar_ciudad_LinkClicked);
            // 
            // CBTipo
            // 
            this.CBTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTipo.FormattingEnabled = true;
            this.CBTipo.Location = new System.Drawing.Point(703, 134);
            this.CBTipo.Name = "CBTipo";
            this.CBTipo.Size = new System.Drawing.Size(121, 21);
            this.CBTipo.TabIndex = 49;
            // 
            // CBGenero
            // 
            this.CBGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBGenero.FormattingEnabled = true;
            this.CBGenero.Location = new System.Drawing.Point(466, 134);
            this.CBGenero.Name = "CBGenero";
            this.CBGenero.Size = new System.Drawing.Size(121, 21);
            this.CBGenero.TabIndex = 48;
            // 
            // TBDni
            // 
            this.TBDni.Location = new System.Drawing.Point(259, 43);
            this.TBDni.MaxLength = 9;
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(118, 20);
            this.TBDni.TabIndex = 35;
            this.TBDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numerico_KeyPress);
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.Location = new System.Drawing.Point(195, 46);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(33, 13);
            this.LDni.TabIndex = 52;
            this.LDni.Text = "DNI:";
            // 
            // BCancelar
            // 
            this.BCancelar.BackColor = System.Drawing.Color.Tomato;
            this.BCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BCancelar.Image")));
            this.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCancelar.Location = new System.Drawing.Point(387, 192);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(134, 44);
            this.BCancelar.TabIndex = 50;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click_1);
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(259, 83);
            this.TBApellido.MaxLength = 30;
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(118, 20);
            this.TBApellido.TabIndex = 37;
            this.TBApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_letras_KeyPress);
            // 
            // TBDireccion
            // 
            this.TBDireccion.Location = new System.Drawing.Point(703, 90);
            this.TBDireccion.MaxLength = 30;
            this.TBDireccion.Name = "TBDireccion";
            this.TBDireccion.Size = new System.Drawing.Size(118, 20);
            this.TBDireccion.TabIndex = 47;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(460, 89);
            this.TBEmail.MaxLength = 30;
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(118, 20);
            this.TBEmail.TabIndex = 42;
            // 
            // TBContacto
            // 
            this.TBContacto.Location = new System.Drawing.Point(460, 40);
            this.TBContacto.MaxLength = 16;
            this.TBContacto.Name = "TBContacto";
            this.TBContacto.Size = new System.Drawing.Size(118, 20);
            this.TBContacto.TabIndex = 40;
            this.TBContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numerico_KeyPress);
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(259, 131);
            this.TBNombre.MaxLength = 30;
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(118, 20);
            this.TBNombre.TabIndex = 39;
            this.TBNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_letras_KeyPress);
            // 
            // LTipo
            // 
            this.LTipo.AutoSize = true;
            this.LTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTipo.Location = new System.Drawing.Point(633, 138);
            this.LTipo.Name = "LTipo";
            this.LTipo.Size = new System.Drawing.Size(36, 13);
            this.LTipo.TabIndex = 46;
            this.LTipo.Text = "Tipo:";
            // 
            // LGenero
            // 
            this.LGenero.AutoSize = true;
            this.LGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGenero.Location = new System.Drawing.Point(396, 134);
            this.LGenero.Name = "LGenero";
            this.LGenero.Size = new System.Drawing.Size(52, 13);
            this.LGenero.TabIndex = 44;
            this.LGenero.Text = "Género:";
            // 
            // LCiudad
            // 
            this.LCiudad.AutoSize = true;
            this.LCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCiudad.Location = new System.Drawing.Point(633, 50);
            this.LCiudad.Name = "LCiudad";
            this.LCiudad.Size = new System.Drawing.Size(50, 13);
            this.LCiudad.TabIndex = 43;
            this.LCiudad.Text = "Ciudad:";
            // 
            // LDireccion
            // 
            this.LDireccion.AutoSize = true;
            this.LDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDireccion.Location = new System.Drawing.Point(633, 90);
            this.LDireccion.Name = "LDireccion";
            this.LDireccion.Size = new System.Drawing.Size(65, 13);
            this.LDireccion.TabIndex = 41;
            this.LDireccion.Text = "Dirección:";
            // 
            // LEmail
            // 
            this.LEmail.AutoSize = true;
            this.LEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmail.Location = new System.Drawing.Point(396, 92);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(41, 13);
            this.LEmail.TabIndex = 38;
            this.LEmail.Text = "Email:";
            // 
            // LTelefono
            // 
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.Location = new System.Drawing.Point(396, 43);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(53, 13);
            this.LTelefono.TabIndex = 36;
            this.LTelefono.Text = "Tel/Cel:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(195, 134);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(54, 13);
            this.LNombre.TabIndex = 34;
            this.LNombre.Text = "Nombre:";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(195, 87);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(56, 13);
            this.LApellido.TabIndex = 33;
            this.LApellido.Text = "Apellido:";
            // 
            // DGClientes
            // 
            this.DGClientes.AllowUserToAddRows = false;
            this.DGClientes.AllowUserToDeleteRows = false;
            this.DGClientes.AllowUserToResizeColumns = false;
            this.DGClientes.AllowUserToResizeRows = false;
            this.DGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGClientes.Location = new System.Drawing.Point(0, 0);
            this.DGClientes.Name = "DGClientes";
            this.DGClientes.ReadOnly = true;
            this.DGClientes.Size = new System.Drawing.Size(1084, 152);
            this.DGClientes.TabIndex = 0;
            this.DGClientes.DoubleClick += new System.EventHandler(this.DGClientes_DoubleClick);
            // 
            // Gestionar_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gestionar_cliente";
            this.Text = "Gestionar_cliente";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.Button BActualizar;
        private System.Windows.Forms.TextBox TBCiudad;
        private System.Windows.Forms.Label LAdvertencia;
        private System.Windows.Forms.LinkLabel agregar_ciudad;
        private System.Windows.Forms.ComboBox CBTipo;
        private System.Windows.Forms.ComboBox CBGenero;
        private System.Windows.Forms.TextBox TBDni;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBDireccion;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBContacto;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label LTipo;
        private System.Windows.Forms.Label LGenero;
        private System.Windows.Forms.Label LCiudad;
        private System.Windows.Forms.Label LDireccion;
        private System.Windows.Forms.Label LEmail;
        private System.Windows.Forms.Label LTelefono;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBBuscadorApe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGClientes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBBuscadorNom;
    }
}