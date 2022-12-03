namespace VIKINGO_PROJECT.Forms.Administrador
{
    partial class Editar_Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_Empleado));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.LLModificar = new System.Windows.Forms.LinkLabel();
            this.CBActivo = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TBProvincia = new System.Windows.Forms.TextBox();
            this.CBTipoUser = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CBGenero = new System.Windows.Forms.ComboBox();
            this.LGenero = new System.Windows.Forms.Label();
            this.DTFechaNac = new System.Windows.Forms.DateTimePicker();
            this.DTFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LAdvertencia = new System.Windows.Forms.Label();
            this.LUsuario = new System.Windows.Forms.Label();
            this.TBBuscarDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBBuscarApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBRepPassword = new System.Windows.Forms.TextBox();
            this.BModificar = new System.Windows.Forms.Button();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.TBDireccion = new System.Windows.Forms.TextBox();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.TBContacto = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_Usuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TBApellido);
            this.splitContainer1.Panel1.Controls.Add(this.label16);
            this.splitContainer1.Panel1.Controls.Add(this.LLModificar);
            this.splitContainer1.Panel1.Controls.Add(this.CBActivo);
            this.splitContainer1.Panel1.Controls.Add(this.label15);
            this.splitContainer1.Panel1.Controls.Add(this.TBProvincia);
            this.splitContainer1.Panel1.Controls.Add(this.CBTipoUser);
            this.splitContainer1.Panel1.Controls.Add(this.label14);
            this.splitContainer1.Panel1.Controls.Add(this.CBGenero);
            this.splitContainer1.Panel1.Controls.Add(this.LGenero);
            this.splitContainer1.Panel1.Controls.Add(this.DTFechaNac);
            this.splitContainer1.Panel1.Controls.Add(this.DTFechaIngreso);
            this.splitContainer1.Panel1.Controls.Add(this.label13);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.TBRepPassword);
            this.splitContainer1.Panel1.Controls.Add(this.BModificar);
            this.splitContainer1.Panel1.Controls.Add(this.TBPassword);
            this.splitContainer1.Panel1.Controls.Add(this.TBUsuario);
            this.splitContainer1.Panel1.Controls.Add(this.TBDireccion);
            this.splitContainer1.Panel1.Controls.Add(this.TBDni);
            this.splitContainer1.Panel1.Controls.Add(this.TBContacto);
            this.splitContainer1.Panel1.Controls.Add(this.TBEmail);
            this.splitContainer1.Panel1.Controls.Add(this.TBNombre);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DGV_Usuarios);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 339;
            this.splitContainer1.TabIndex = 0;
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(79, 119);
            this.TBApellido.MaxLength = 30;
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(141, 20);
            this.TBApellido.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(4, 126);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 100;
            this.label16.Text = "Apellido: ";
            // 
            // LLModificar
            // 
            this.LLModificar.AutoSize = true;
            this.LLModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLModificar.Location = new System.Drawing.Point(494, 130);
            this.LLModificar.Name = "LLModificar";
            this.LLModificar.Size = new System.Drawing.Size(59, 13);
            this.LLModificar.TabIndex = 10;
            this.LLModificar.TabStop = true;
            this.LLModificar.Text = "Modificar";
            this.LLModificar.Click += new System.EventHandler(this.LLModificar_Click);
            // 
            // CBActivo
            // 
            this.CBActivo.AutoSize = true;
            this.CBActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBActivo.Location = new System.Drawing.Point(667, 292);
            this.CBActivo.Name = "CBActivo";
            this.CBActivo.Size = new System.Drawing.Size(15, 14);
            this.CBActivo.TabIndex = 19;
            this.CBActivo.UseVisualStyleBackColor = true;
            this.CBActivo.Click += new System.EventHandler(this.CBActivo_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(607, 293);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 97;
            this.label15.Text = "Estado:";
            // 
            // TBProvincia
            // 
            this.TBProvincia.Location = new System.Drawing.Point(347, 123);
            this.TBProvincia.MaxLength = 30;
            this.TBProvincia.Name = "TBProvincia";
            this.TBProvincia.ReadOnly = true;
            this.TBProvincia.Size = new System.Drawing.Size(141, 20);
            this.TBProvincia.TabIndex = 9;
            // 
            // CBTipoUser
            // 
            this.CBTipoUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTipoUser.FormattingEnabled = true;
            this.CBTipoUser.Location = new System.Drawing.Point(363, 307);
            this.CBTipoUser.Name = "CBTipoUser";
            this.CBTipoUser.Size = new System.Drawing.Size(121, 21);
            this.CBTipoUser.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(244, 309);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 94;
            this.label14.Text = "Tipo Usuario:";
            // 
            // CBGenero
            // 
            this.CBGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBGenero.FormattingEnabled = true;
            this.CBGenero.Location = new System.Drawing.Point(656, 122);
            this.CBGenero.Name = "CBGenero";
            this.CBGenero.Size = new System.Drawing.Size(121, 21);
            this.CBGenero.TabIndex = 15;
            // 
            // LGenero
            // 
            this.LGenero.AutoSize = true;
            this.LGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGenero.Location = new System.Drawing.Point(592, 130);
            this.LGenero.Name = "LGenero";
            this.LGenero.Size = new System.Drawing.Size(52, 13);
            this.LGenero.TabIndex = 92;
            this.LGenero.Text = "Genero:";
            // 
            // DTFechaNac
            // 
            this.DTFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFechaNac.Location = new System.Drawing.Point(363, 256);
            this.DTFechaNac.Name = "DTFechaNac";
            this.DTFechaNac.Size = new System.Drawing.Size(141, 20);
            this.DTFechaNac.TabIndex = 13;
            // 
            // DTFechaIngreso
            // 
            this.DTFechaIngreso.Enabled = false;
            this.DTFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFechaIngreso.Location = new System.Drawing.Point(363, 204);
            this.DTFechaIngreso.Name = "DTFechaIngreso";
            this.DTFechaIngreso.Size = new System.Drawing.Size(141, 20);
            this.DTFechaIngreso.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(519, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 13);
            this.label13.TabIndex = 88;
            this.label13.Text = "Confirmar contraseña:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.LAdvertencia);
            this.panel1.Controls.Add(this.LUsuario);
            this.panel1.Controls.Add(this.TBBuscarDni);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TBBuscarApellido);
            this.panel1.Controls.Add(this.label3);
            this.panel1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Location = new System.Drawing.Point(136, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 97);
            this.panel1.TabIndex = 87;
            // 
            // LAdvertencia
            // 
            this.LAdvertencia.AutoSize = true;
            this.LAdvertencia.BackColor = System.Drawing.Color.Gray;
            this.LAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.LAdvertencia.Location = new System.Drawing.Point(17, 81);
            this.LAdvertencia.Name = "LAdvertencia";
            this.LAdvertencia.Size = new System.Drawing.Size(75, 13);
            this.LAdvertencia.TabIndex = 44;
            this.LAdvertencia.Text = "Advertencia";
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuario.Location = new System.Drawing.Point(26, 16);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(50, 13);
            this.LUsuario.TabIndex = 0;
            this.LUsuario.Text = "Usuario";
            // 
            // TBBuscarDni
            // 
            this.TBBuscarDni.Location = new System.Drawing.Point(100, 44);
            this.TBBuscarDni.MaxLength = 16;
            this.TBBuscarDni.Name = "TBBuscarDni";
            this.TBBuscarDni.Size = new System.Drawing.Size(141, 20);
            this.TBBuscarDni.TabIndex = 1;
            this.TBBuscarDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numerico_KeyPress);
            this.TBBuscarDni.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBBuscarCUIL_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "DNI:";
            // 
            // TBBuscarApellido
            // 
            this.TBBuscarApellido.Location = new System.Drawing.Point(339, 44);
            this.TBBuscarApellido.MaxLength = 30;
            this.TBBuscarApellido.Name = "TBBuscarApellido";
            this.TBBuscarApellido.Size = new System.Drawing.Size(141, 20);
            this.TBBuscarApellido.TabIndex = 2;
            this.TBBuscarApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_letras_KeyPress);
            this.TBBuscarApellido.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBBuscarApellido_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Apellido:";
            // 
            // TBRepPassword
            // 
            this.TBRepPassword.Location = new System.Drawing.Point(656, 256);
            this.TBRepPassword.MaxLength = 30;
            this.TBRepPassword.Name = "TBRepPassword";
            this.TBRepPassword.Size = new System.Drawing.Size(141, 20);
            this.TBRepPassword.TabIndex = 18;
            // 
            // BModificar
            // 
            this.BModificar.BackColor = System.Drawing.Color.LimeGreen;
            this.BModificar.Image = ((System.Drawing.Image)(resources.GetObject("BModificar.Image")));
            this.BModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BModificar.Location = new System.Drawing.Point(574, 312);
            this.BModificar.Name = "BModificar";
            this.BModificar.Size = new System.Drawing.Size(176, 52);
            this.BModificar.TabIndex = 20;
            this.BModificar.Text = "Modificar";
            this.BModificar.UseVisualStyleBackColor = false;
            this.BModificar.Click += new System.EventHandler(this.BModificar_Click_1);
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(656, 207);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(141, 20);
            this.TBPassword.TabIndex = 17;
            // 
            // TBUsuario
            // 
            this.TBUsuario.Location = new System.Drawing.Point(656, 161);
            this.TBUsuario.MaxLength = 30;
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(141, 20);
            this.TBUsuario.TabIndex = 16;
            // 
            // TBDireccion
            // 
            this.TBDireccion.Location = new System.Drawing.Point(347, 161);
            this.TBDireccion.MaxLength = 30;
            this.TBDireccion.Name = "TBDireccion";
            this.TBDireccion.Size = new System.Drawing.Size(141, 20);
            this.TBDireccion.TabIndex = 11;
            // 
            // TBDni
            // 
            this.TBDni.Location = new System.Drawing.Point(79, 204);
            this.TBDni.MaxLength = 9;
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(141, 20);
            this.TBDni.TabIndex = 5;
            this.TBDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numerico_KeyPress);
            // 
            // TBContacto
            // 
            this.TBContacto.Location = new System.Drawing.Point(79, 255);
            this.TBContacto.MaxLength = 16;
            this.TBContacto.Name = "TBContacto";
            this.TBContacto.Size = new System.Drawing.Size(141, 20);
            this.TBContacto.TabIndex = 6;
            this.TBContacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numerico_KeyPress);
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(80, 302);
            this.TBEmail.MaxLength = 30;
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(141, 20);
            this.TBEmail.TabIndex = 8;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(79, 161);
            this.TBNombre.MaxLength = 30;
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(141, 20);
            this.TBNombre.TabIndex = 4;
            this.TBNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_letras_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(571, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 77;
            this.label12.Text = "Contraseña:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 76;
            this.label11.Text = "DNI:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(590, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 75;
            this.label10.Text = "Usuario:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(226, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "Fecha de Nacimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(233, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "Fecha de ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(244, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(249, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Provincia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Tel/Cel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Nombre:";
            // 
            // DGV_Usuarios
            // 
            this.DGV_Usuarios.AllowUserToAddRows = false;
            this.DGV_Usuarios.AllowUserToDeleteRows = false;
            this.DGV_Usuarios.AllowUserToResizeColumns = false;
            this.DGV_Usuarios.AllowUserToResizeRows = false;
            this.DGV_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Usuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Usuarios.Location = new System.Drawing.Point(0, 0);
            this.DGV_Usuarios.Name = "DGV_Usuarios";
            this.DGV_Usuarios.ReadOnly = true;
            this.DGV_Usuarios.Size = new System.Drawing.Size(800, 107);
            this.DGV_Usuarios.TabIndex = 21;
            this.DGV_Usuarios.DoubleClick += new System.EventHandler(this.DGV_Usuarios_DoubleClick);
            // 
            // Editar_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Editar_Empleado";
            this.Text = "Empleado";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox CBGenero;
        private System.Windows.Forms.Label LGenero;
        private System.Windows.Forms.DateTimePicker DTFechaNac;
        private System.Windows.Forms.DateTimePicker DTFechaIngreso;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LAdvertencia;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.TextBox TBBuscarDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBBuscarApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBRepPassword;
        private System.Windows.Forms.Button BModificar;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.TextBox TBDireccion;
        private System.Windows.Forms.TextBox TBDni;
        private System.Windows.Forms.TextBox TBContacto;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_Usuarios;
        private System.Windows.Forms.ComboBox CBTipoUser;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TBProvincia;
        private System.Windows.Forms.CheckBox CBActivo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.LinkLabel LLModificar;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.Label label16;
    }
}