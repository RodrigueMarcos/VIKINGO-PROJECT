namespace VIKINGO_PROJECT.Forms.Supervisor
{
    partial class Producto_defectuoso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto_defectuoso));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LProducto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBCodigo = new System.Windows.Forms.TextBox();
            this.DGV_productos = new System.Windows.Forms.DataGridView();
            this.CBMotivo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LAdvertencia = new System.Windows.Forms.Label();
            this.BSalir = new System.Windows.Forms.Button();
            this.BAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TBCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBProductoSel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.DGV_productos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.TBProductoSel);
            this.splitContainer1.Panel2.Controls.Add(this.CBMotivo);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.LAdvertencia);
            this.splitContainer1.Panel2.Controls.Add(this.BSalir);
            this.splitContainer1.Panel2.Controls.Add(this.BAgregar);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.TBCantidad);
            this.splitContainer1.Size = new System.Drawing.Size(1100, 600);
            this.splitContainer1.SplitterDistance = 303;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.LProducto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TBNombre);
            this.panel1.Controls.Add(this.TBCodigo);
            this.panel1.Location = new System.Drawing.Point(248, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 76);
            this.panel1.TabIndex = 44;
            // 
            // LProducto
            // 
            this.LProducto.AutoSize = true;
            this.LProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProducto.Location = new System.Drawing.Point(34, 13);
            this.LProducto.Name = "LProducto";
            this.LProducto.Size = new System.Drawing.Size(58, 13);
            this.LProducto.TabIndex = 42;
            this.LProducto.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Codigo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(335, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Nombre:";
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(388, 40);
            this.TBNombre.MaxLength = 30;
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(145, 20);
            this.TBNombre.TabIndex = 26;
            this.TBNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBNombre_KeyUp);
            // 
            // TBCodigo
            // 
            this.TBCodigo.Location = new System.Drawing.Point(109, 40);
            this.TBCodigo.MaxLength = 8;
            this.TBCodigo.Name = "TBCodigo";
            this.TBCodigo.Size = new System.Drawing.Size(145, 20);
            this.TBCodigo.TabIndex = 25;
            this.TBCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCodigo_KeyUp);
            // 
            // DGV_productos
            // 
            this.DGV_productos.AllowUserToAddRows = false;
            this.DGV_productos.AllowUserToDeleteRows = false;
            this.DGV_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_productos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV_productos.Location = new System.Drawing.Point(0, 159);
            this.DGV_productos.Name = "DGV_productos";
            this.DGV_productos.ReadOnly = true;
            this.DGV_productos.Size = new System.Drawing.Size(1100, 144);
            this.DGV_productos.TabIndex = 43;
            this.DGV_productos.Click += new System.EventHandler(this.DGV_productos_Click);
            // 
            // CBMotivo
            // 
            this.CBMotivo.FormattingEnabled = true;
            this.CBMotivo.Location = new System.Drawing.Point(644, 70);
            this.CBMotivo.Name = "CBMotivo";
            this.CBMotivo.Size = new System.Drawing.Size(152, 21);
            this.CBMotivo.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(576, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Motivo:";
            // 
            // LAdvertencia
            // 
            this.LAdvertencia.AutoSize = true;
            this.LAdvertencia.BackColor = System.Drawing.Color.Silver;
            this.LAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.LAdvertencia.Location = new System.Drawing.Point(99, 28);
            this.LAdvertencia.Name = "LAdvertencia";
            this.LAdvertencia.Size = new System.Drawing.Size(75, 13);
            this.LAdvertencia.TabIndex = 53;
            this.LAdvertencia.Text = "Advertencia";
            // 
            // BSalir
            // 
            this.BSalir.BackColor = System.Drawing.Color.SandyBrown;
            this.BSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSalir.Image = ((System.Drawing.Image)(resources.GetObject("BSalir.Image")));
            this.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSalir.Location = new System.Drawing.Point(314, 181);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(166, 44);
            this.BSalir.TabIndex = 52;
            this.BSalir.Text = "Salir";
            this.BSalir.UseVisualStyleBackColor = false;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click_1);
            // 
            // BAgregar
            // 
            this.BAgregar.BackColor = System.Drawing.Color.Red;
            this.BAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BAgregar.Image")));
            this.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAgregar.Location = new System.Drawing.Point(563, 181);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(170, 44);
            this.BAgregar.TabIndex = 51;
            this.BAgregar.Text = "Dar de baja";
            this.BAgregar.UseVisualStyleBackColor = false;
            this.BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(225, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Cantidad:";
            // 
            // TBCantidad
            // 
            this.TBCantidad.Location = new System.Drawing.Point(327, 67);
            this.TBCantidad.MaxLength = 8;
            this.TBCantidad.Name = "TBCantidad";
            this.TBCantidad.Size = new System.Drawing.Size(145, 20);
            this.TBCantidad.TabIndex = 45;
            this.TBCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCantidad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Producto seleccionado:";
            // 
            // TBProductoSel
            // 
            this.TBProductoSel.Enabled = false;
            this.TBProductoSel.Location = new System.Drawing.Point(413, 13);
            this.TBProductoSel.MaxLength = 8;
            this.TBProductoSel.Name = "TBProductoSel";
            this.TBProductoSel.Size = new System.Drawing.Size(306, 20);
            this.TBProductoSel.TabIndex = 56;
            // 
            // Producto_defectuoso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Producto_defectuoso";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_productos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBCodigo;
        private System.Windows.Forms.DataGridView DGV_productos;
        private System.Windows.Forms.Label LAdvertencia;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBCantidad;
        private System.Windows.Forms.ComboBox CBMotivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBProductoSel;
    }
}