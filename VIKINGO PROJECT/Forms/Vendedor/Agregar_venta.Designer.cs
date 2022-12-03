namespace VIKINGO_PROJECT.Forms.Vendedor
{
    partial class Agregar_venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_venta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BAgregarCli = new System.Windows.Forms.Button();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.TBApeNom = new System.Windows.Forms.TextBox();
            this.CBTipoPago = new System.Windows.Forms.ComboBox();
            this.LTipoPago = new System.Windows.Forms.Label();
            this.CBTipoFac = new System.Windows.Forms.ComboBox();
            this.LAdvertencia = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Bcerrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBStockAct = new System.Windows.Forms.TextBox();
            this.TBPrecio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BBuscarPro = new System.Windows.Forms.Button();
            this.BAgregar = new System.Windows.Forms.Button();
            this.TBCantidad = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBCodigo = new System.Windows.Forms.TextBox();
            this.LCodigo = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LCantidad = new System.Windows.Forms.Label();
            this.LTotal = new System.Windows.Forms.Label();
            this.LDetalle = new System.Windows.Forms.Label();
            this.BGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DGV_Detalle = new System.Windows.Forms.DataGridView();
            this.ID_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.CBTipoPago);
            this.splitContainer1.Panel1.Controls.Add(this.LTipoPago);
            this.splitContainer1.Panel1.Controls.Add(this.CBTipoFac);
            this.splitContainer1.Panel1.Controls.Add(this.LAdvertencia);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.Bcerrar);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.LTotal);
            this.splitContainer1.Panel2.Controls.Add(this.LDetalle);
            this.splitContainer1.Panel2.Controls.Add(this.BGuardar);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.DGV_Detalle);
            this.splitContainer1.Size = new System.Drawing.Size(1100, 600);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BAgregarCli);
            this.panel1.Controls.Add(this.TBDni);
            this.panel1.Controls.Add(this.TBApeNom);
            this.panel1.Location = new System.Drawing.Point(151, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 100);
            this.panel1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "DNI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Información del cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Apellido y nombre:";
            // 
            // BAgregarCli
            // 
            this.BAgregarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregarCli.Image = ((System.Drawing.Image)(resources.GetObject("BAgregarCli.Image")));
            this.BAgregarCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAgregarCli.Location = new System.Drawing.Point(411, 64);
            this.BAgregarCli.Name = "BAgregarCli";
            this.BAgregarCli.Size = new System.Drawing.Size(87, 33);
            this.BAgregarCli.TabIndex = 1;
            this.BAgregarCli.Text = "Agregar";
            this.BAgregarCli.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAgregarCli.UseVisualStyleBackColor = true;
            this.BAgregarCli.Click += new System.EventHandler(this.BAgregarCli_Click);
            // 
            // TBDni
            // 
            this.TBDni.Enabled = false;
            this.TBDni.Location = new System.Drawing.Point(38, 33);
            this.TBDni.MaxLength = 9;
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(100, 20);
            this.TBDni.TabIndex = 4;
            this.TBDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBDni_KeyPress);
            // 
            // TBApeNom
            // 
            this.TBApeNom.Enabled = false;
            this.TBApeNom.Location = new System.Drawing.Point(276, 33);
            this.TBApeNom.MaxLength = 30;
            this.TBApeNom.Name = "TBApeNom";
            this.TBApeNom.Size = new System.Drawing.Size(152, 20);
            this.TBApeNom.TabIndex = 5;
            this.TBApeNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBApeNom_KeyPress);
            // 
            // CBTipoPago
            // 
            this.CBTipoPago.FormattingEnabled = true;
            this.CBTipoPago.Items.AddRange(new object[] {
            "Mayorista",
            "Minorista"});
            this.CBTipoPago.Location = new System.Drawing.Point(811, 132);
            this.CBTipoPago.Name = "CBTipoPago";
            this.CBTipoPago.Size = new System.Drawing.Size(121, 21);
            this.CBTipoPago.TabIndex = 5;
            // 
            // LTipoPago
            // 
            this.LTipoPago.AutoSize = true;
            this.LTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTipoPago.Location = new System.Drawing.Point(723, 132);
            this.LTipoPago.Name = "LTipoPago";
            this.LTipoPago.Size = new System.Drawing.Size(87, 13);
            this.LTipoPago.TabIndex = 12;
            this.LTipoPago.Text = "Tipo de Pago:";
            // 
            // CBTipoFac
            // 
            this.CBTipoFac.FormattingEnabled = true;
            this.CBTipoFac.Items.AddRange(new object[] {
            "Mayorista",
            "Minorista"});
            this.CBTipoFac.Location = new System.Drawing.Point(811, 98);
            this.CBTipoFac.Name = "CBTipoFac";
            this.CBTipoFac.Size = new System.Drawing.Size(121, 21);
            this.CBTipoFac.TabIndex = 4;
            // 
            // LAdvertencia
            // 
            this.LAdvertencia.AutoSize = true;
            this.LAdvertencia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.LAdvertencia.Location = new System.Drawing.Point(0, 206);
            this.LAdvertencia.Name = "LAdvertencia";
            this.LAdvertencia.Size = new System.Drawing.Size(90, 16);
            this.LAdvertencia.TabIndex = 9;
            this.LAdvertencia.Text = "Advertencia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-170, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "label7";
            // 
            // Bcerrar
            // 
            this.Bcerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcerrar.Image = ((System.Drawing.Image)(resources.GetObject("Bcerrar.Image")));
            this.Bcerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bcerrar.Location = new System.Drawing.Point(844, 40);
            this.Bcerrar.Name = "Bcerrar";
            this.Bcerrar.Size = new System.Drawing.Size(87, 36);
            this.Bcerrar.TabIndex = 7;
            this.Bcerrar.Text = "Cerrar";
            this.Bcerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bcerrar.UseVisualStyleBackColor = true;
            this.Bcerrar.Click += new System.EventHandler(this.Bcerrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(722, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tipo Factura:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.TBStockAct);
            this.panel2.Controls.Add(this.TBPrecio);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.BBuscarPro);
            this.panel2.Controls.Add(this.BAgregar);
            this.panel2.Controls.Add(this.TBCantidad);
            this.panel2.Controls.Add(this.TBNombre);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TBCodigo);
            this.panel2.Controls.Add(this.LCodigo);
            this.panel2.Controls.Add(this.LNombre);
            this.panel2.Controls.Add(this.LCantidad);
            this.panel2.Location = new System.Drawing.Point(85, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 56);
            this.panel2.TabIndex = 14;
            // 
            // TBStockAct
            // 
            this.TBStockAct.Enabled = false;
            this.TBStockAct.Location = new System.Drawing.Point(317, 37);
            this.TBStockAct.MaxLength = 8;
            this.TBStockAct.Name = "TBStockAct";
            this.TBStockAct.Size = new System.Drawing.Size(129, 20);
            this.TBStockAct.TabIndex = 16;
            // 
            // TBPrecio
            // 
            this.TBPrecio.Enabled = false;
            this.TBPrecio.Location = new System.Drawing.Point(129, 40);
            this.TBPrecio.MaxLength = 8;
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.Size = new System.Drawing.Size(99, 20);
            this.TBPrecio.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(234, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Stock Actual:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(81, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Precio:";
            // 
            // BBuscarPro
            // 
            this.BBuscarPro.Location = new System.Drawing.Point(452, 19);
            this.BBuscarPro.Name = "BBuscarPro";
            this.BBuscarPro.Size = new System.Drawing.Size(75, 23);
            this.BBuscarPro.TabIndex = 2;
            this.BBuscarPro.Text = "Buscar";
            this.BBuscarPro.UseVisualStyleBackColor = true;
            this.BBuscarPro.Click += new System.EventHandler(this.BBuscarPro_Click);
            // 
            // BAgregar
            // 
            this.BAgregar.Location = new System.Drawing.Point(768, 21);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(75, 23);
            this.BAgregar.TabIndex = 3;
            this.BAgregar.Text = "Agregar";
            this.BAgregar.UseVisualStyleBackColor = true;
            this.BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
            // 
            // TBCantidad
            // 
            this.TBCantidad.Location = new System.Drawing.Point(618, 21);
            this.TBCantidad.MaxLength = 8;
            this.TBCantidad.Name = "TBCantidad";
            this.TBCantidad.Size = new System.Drawing.Size(129, 20);
            this.TBCantidad.TabIndex = 11;
            this.TBCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCantidad_KeyPress);
            // 
            // TBNombre
            // 
            this.TBNombre.Enabled = false;
            this.TBNombre.Location = new System.Drawing.Point(317, 16);
            this.TBNombre.MaxLength = 30;
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(129, 20);
            this.TBNombre.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seleccionar producto";
            // 
            // TBCodigo
            // 
            this.TBCodigo.Enabled = false;
            this.TBCodigo.Location = new System.Drawing.Point(129, 16);
            this.TBCodigo.MaxLength = 8;
            this.TBCodigo.Name = "TBCodigo";
            this.TBCodigo.Size = new System.Drawing.Size(129, 20);
            this.TBCodigo.TabIndex = 9;
            this.TBCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCodigo_KeyPress);
            // 
            // LCodigo
            // 
            this.LCodigo.AutoSize = true;
            this.LCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCodigo.Location = new System.Drawing.Point(81, 19);
            this.LCodigo.Name = "LCodigo";
            this.LCodigo.Size = new System.Drawing.Size(50, 13);
            this.LCodigo.TabIndex = 4;
            this.LCodigo.Text = "Código:";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(264, 19);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(54, 13);
            this.LNombre.TabIndex = 5;
            this.LNombre.Text = "Nombre:";
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantidad.Location = new System.Drawing.Point(556, 24);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(61, 13);
            this.LCantidad.TabIndex = 6;
            this.LCantidad.Text = "Cantidad:";
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotal.ForeColor = System.Drawing.Color.Red;
            this.LTotal.Location = new System.Drawing.Point(807, 300);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(25, 13);
            this.LTotal.TabIndex = 13;
            this.LTotal.Text = "0.0";
            // 
            // LDetalle
            // 
            this.LDetalle.AutoSize = true;
            this.LDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDetalle.Location = new System.Drawing.Point(58, 99);
            this.LDetalle.Name = "LDetalle";
            this.LDetalle.Size = new System.Drawing.Size(47, 13);
            this.LDetalle.TabIndex = 8;
            this.LDetalle.Text = "Detalle";
            // 
            // BGuardar
            // 
            this.BGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BGuardar.Image")));
            this.BGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGuardar.Location = new System.Drawing.Point(562, 289);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(153, 39);
            this.BGuardar.TabIndex = 6;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(745, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total:";
            // 
            // DGV_Detalle
            // 
            this.DGV_Detalle.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Khaki;
            this.DGV_Detalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Detalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_Detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Detalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Detalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_producto,
            this.Nombre,
            this.Descripcion,
            this.Cantidad,
            this.Precio_unitario,
            this.Sub_total,
            this.Eliminar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Detalle.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Detalle.Location = new System.Drawing.Point(44, 115);
            this.DGV_Detalle.Name = "DGV_Detalle";
            this.DGV_Detalle.Size = new System.Drawing.Size(940, 149);
            this.DGV_Detalle.TabIndex = 1;
            this.DGV_Detalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Detalle_CellClick);
            this.DGV_Detalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Detalle_CellEndEdit);
            this.DGV_Detalle.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DGV_Detalle_EditingControlShowing);
            // 
            // ID_producto
            // 
            this.ID_producto.HeaderText = "Codigo";
            this.ID_producto.Name = "ID_producto";
            this.ID_producto.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MaxInputLength = 10;
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio_unitario
            // 
            this.Precio_unitario.HeaderText = "Precio Unitario";
            this.Precio_unitario.Name = "Precio_unitario";
            this.Precio_unitario.ReadOnly = true;
            // 
            // Sub_total
            // 
            this.Sub_total.HeaderText = "Sub total";
            this.Sub_total.Name = "Sub_total";
            this.Sub_total.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            // 
            // Agregar_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agregar_venta";
            this.Text = "Nueva venta";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Detalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGV_Detalle;
        private System.Windows.Forms.TextBox TBApeNom;
        private System.Windows.Forms.TextBox TBDni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button Bcerrar;
        private System.Windows.Forms.Label LAdvertencia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BAgregarCli;
        private System.Windows.Forms.ComboBox CBTipoFac;
        private System.Windows.Forms.ComboBox CBTipoPago;
        private System.Windows.Forms.Label LTipoPago;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.TextBox TBCantidad;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBCodigo;
        private System.Windows.Forms.Label LCodigo;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.Label LDetalle;
        private System.Windows.Forms.Button BBuscarPro;
        private System.Windows.Forms.TextBox TBStockAct;
        private System.Windows.Forms.TextBox TBPrecio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_total;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}