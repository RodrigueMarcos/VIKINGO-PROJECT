namespace VIKINGO_PROJECT.Forms.Administrador
{
    partial class Ver_ventas
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBVendedores = new System.Windows.Forms.ComboBox();
            this.LAdvertencia = new System.Windows.Forms.Label();
            this.BBuscar = new System.Windows.Forms.Button();
            this.RBEspecificar = new System.Windows.Forms.RadioButton();
            this.RBTodo = new System.Windows.Forms.RadioButton();
            this.DTHasta = new System.Windows.Forms.DateTimePicker();
            this.DTDesde = new System.Windows.Forms.DateTimePicker();
            this.TBCliente = new System.Windows.Forms.TextBox();
            this.LFecha = new System.Windows.Forms.Label();
            this.LCategoria = new System.Windows.Forms.Label();
            this.L_Producto = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_Facturas = new System.Windows.Forms.DataGridView();
            this.DGV_Detalles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Facturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Detalles)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.CBVendedores);
            this.splitContainer1.Panel1.Controls.Add(this.LAdvertencia);
            this.splitContainer1.Panel1.Controls.Add(this.BBuscar);
            this.splitContainer1.Panel1.Controls.Add(this.RBEspecificar);
            this.splitContainer1.Panel1.Controls.Add(this.RBTodo);
            this.splitContainer1.Panel1.Controls.Add(this.DTHasta);
            this.splitContainer1.Panel1.Controls.Add(this.DTDesde);
            this.splitContainer1.Panel1.Controls.Add(this.TBCliente);
            this.splitContainer1.Panel1.Controls.Add(this.LFecha);
            this.splitContainer1.Panel1.Controls.Add(this.LCategoria);
            this.splitContainer1.Panel1.Controls.Add(this.L_Producto);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 133;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Generar pdf";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Facturaciones";
            // 
            // CBVendedores
            // 
            this.CBVendedores.FormattingEnabled = true;
            this.CBVendedores.Location = new System.Drawing.Point(388, 69);
            this.CBVendedores.Name = "CBVendedores";
            this.CBVendedores.Size = new System.Drawing.Size(121, 21);
            this.CBVendedores.TabIndex = 32;
            this.CBVendedores.DropDown += new System.EventHandler(this.CBVendedores_DropDown);
            this.CBVendedores.Click += new System.EventHandler(this.CBVendedores_Click);
            // 
            // LAdvertencia
            // 
            this.LAdvertencia.AutoSize = true;
            this.LAdvertencia.BackColor = System.Drawing.Color.Silver;
            this.LAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.LAdvertencia.Location = new System.Drawing.Point(61, 93);
            this.LAdvertencia.Name = "LAdvertencia";
            this.LAdvertencia.Size = new System.Drawing.Size(75, 13);
            this.LAdvertencia.TabIndex = 31;
            this.LAdvertencia.Text = "Advertencia";
            // 
            // BBuscar
            // 
            this.BBuscar.Location = new System.Drawing.Point(723, 57);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(58, 23);
            this.BBuscar.TabIndex = 30;
            this.BBuscar.Text = "Buscar";
            this.BBuscar.UseVisualStyleBackColor = true;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // RBEspecificar
            // 
            this.RBEspecificar.AutoSize = true;
            this.RBEspecificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBEspecificar.Location = new System.Drawing.Point(432, 28);
            this.RBEspecificar.Name = "RBEspecificar";
            this.RBEspecificar.Size = new System.Drawing.Size(88, 17);
            this.RBEspecificar.TabIndex = 27;
            this.RBEspecificar.Text = "Especificar";
            this.RBEspecificar.UseVisualStyleBackColor = true;
            this.RBEspecificar.CheckedChanged += new System.EventHandler(this.RBEspecificar_CheckedChanged);
            // 
            // RBTodo
            // 
            this.RBTodo.AutoSize = true;
            this.RBTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTodo.Location = new System.Drawing.Point(175, 25);
            this.RBTodo.Name = "RBTodo";
            this.RBTodo.Size = new System.Drawing.Size(60, 17);
            this.RBTodo.TabIndex = 26;
            this.RBTodo.Text = "Todos";
            this.RBTodo.UseVisualStyleBackColor = true;
            this.RBTodo.CheckedChanged += new System.EventHandler(this.RBTodo_CheckedChanged);
            // 
            // DTHasta
            // 
            this.DTHasta.Checked = false;
            this.DTHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTHasta.Location = new System.Drawing.Point(615, 86);
            this.DTHasta.Name = "DTHasta";
            this.DTHasta.Size = new System.Drawing.Size(102, 20);
            this.DTHasta.TabIndex = 25;
            // 
            // DTDesde
            // 
            this.DTDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTDesde.Location = new System.Drawing.Point(615, 60);
            this.DTDesde.Name = "DTDesde";
            this.DTDesde.Size = new System.Drawing.Size(102, 20);
            this.DTDesde.TabIndex = 24;
            // 
            // TBCliente
            // 
            this.TBCliente.Location = new System.Drawing.Point(175, 68);
            this.TBCliente.MaxLength = 30;
            this.TBCliente.Name = "TBCliente";
            this.TBCliente.Size = new System.Drawing.Size(100, 20);
            this.TBCliente.TabIndex = 22;
            this.TBCliente.TextChanged += new System.EventHandler(this.TBProducto_TextChanged);
            this.TBCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCliente_KeyPress);
            this.TBCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBProducto_KeyUp);
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFecha.Location = new System.Drawing.Point(543, 70);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(66, 13);
            this.LFecha.TabIndex = 21;
            this.LFecha.Text = "Por fecha:";
            // 
            // LCategoria
            // 
            this.LCategoria.AutoSize = true;
            this.LCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCategoria.Location = new System.Drawing.Point(295, 72);
            this.LCategoria.Name = "LCategoria";
            this.LCategoria.Size = new System.Drawing.Size(87, 13);
            this.LCategoria.TabIndex = 20;
            this.LCategoria.Text = "Por vendedor:";
            // 
            // L_Producto
            // 
            this.L_Producto.AutoSize = true;
            this.L_Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Producto.Location = new System.Drawing.Point(39, 72);
            this.L_Producto.Name = "L_Producto";
            this.L_Producto.Size = new System.Drawing.Size(138, 13);
            this.L_Producto.TabIndex = 19;
            this.L_Producto.Text = "Por apellido de cliente:";
            this.L_Producto.Click += new System.EventHandler(this.L_Producto_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.DGV_Facturas);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.DGV_Detalles);
            this.splitContainer2.Size = new System.Drawing.Size(800, 313);
            this.splitContainer2.SplitterDistance = 170;
            this.splitContainer2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Detalle";
            // 
            // DGV_Facturas
            // 
            this.DGV_Facturas.AllowUserToAddRows = false;
            this.DGV_Facturas.AllowUserToDeleteRows = false;
            this.DGV_Facturas.AllowUserToResizeColumns = false;
            this.DGV_Facturas.AllowUserToResizeRows = false;
            this.DGV_Facturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Facturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Facturas.Location = new System.Drawing.Point(0, 0);
            this.DGV_Facturas.Name = "DGV_Facturas";
            this.DGV_Facturas.ReadOnly = true;
            this.DGV_Facturas.Size = new System.Drawing.Size(800, 170);
            this.DGV_Facturas.TabIndex = 0;
            this.DGV_Facturas.Click += new System.EventHandler(this.DGV_Facturas_Click);
            // 
            // DGV_Detalles
            // 
            this.DGV_Detalles.AllowUserToAddRows = false;
            this.DGV_Detalles.AllowUserToDeleteRows = false;
            this.DGV_Detalles.AllowUserToResizeColumns = false;
            this.DGV_Detalles.AllowUserToResizeRows = false;
            this.DGV_Detalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Detalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_Detalles.Location = new System.Drawing.Point(0, 0);
            this.DGV_Detalles.Name = "DGV_Detalles";
            this.DGV_Detalles.ReadOnly = true;
            this.DGV_Detalles.Size = new System.Drawing.Size(800, 139);
            this.DGV_Detalles.TabIndex = 0;
            // 
            // Ver_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ver_ventas";
            this.Text = "Ver_ventas";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Facturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Detalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.RadioButton RBEspecificar;
        private System.Windows.Forms.RadioButton RBTodo;
        private System.Windows.Forms.DateTimePicker DTHasta;
        private System.Windows.Forms.DateTimePicker DTDesde;
        private System.Windows.Forms.TextBox TBCliente;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label LCategoria;
        private System.Windows.Forms.Label L_Producto;
        private System.Windows.Forms.Label LAdvertencia;
        private System.Windows.Forms.ComboBox CBVendedores;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView DGV_Facturas;
        private System.Windows.Forms.DataGridView DGV_Detalles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}