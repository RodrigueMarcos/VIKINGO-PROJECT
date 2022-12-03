namespace VIKINGO_PROJECT.Forms.Administrador
{
    partial class Modificar_producto
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
            this.label1 = new System.Windows.Forms.Label();
            this.DGVListaProducto = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TBBuscarNom = new System.Windows.Forms.TextBox();
            this.TBBuscarCod = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.LCodigo = new System.Windows.Forms.Label();
            this.BRecargarCat = new System.Windows.Forms.Button();
            this.BRecargarMar = new System.Windows.Forms.Button();
            this.LLCategoria = new System.Windows.Forms.LinkLabel();
            this.LLAgregarMarca = new System.Windows.Forms.LinkLabel();
            this.TBPrecio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.BModificar = new System.Windows.Forms.Button();
            this.TBCodigo = new System.Windows.Forms.TextBox();
            this.LAdvertencia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBStockMin = new System.Windows.Forms.TextBox();
            this.CBMarca = new System.Windows.Forms.ComboBox();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProducto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.DGVListaProducto);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BRecargarCat);
            this.splitContainer1.Panel2.Controls.Add(this.BRecargarMar);
            this.splitContainer1.Panel2.Controls.Add(this.LLCategoria);
            this.splitContainer1.Panel2.Controls.Add(this.LLAgregarMarca);
            this.splitContainer1.Panel2.Controls.Add(this.TBPrecio);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.TBNombre);
            this.splitContainer1.Panel2.Controls.Add(this.BModificar);
            this.splitContainer1.Panel2.Controls.Add(this.TBCodigo);
            this.splitContainer1.Panel2.Controls.Add(this.LAdvertencia);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.TBDescripcion);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.TBStockMin);
            this.splitContainer1.Panel2.Controls.Add(this.CBMarca);
            this.splitContainer1.Panel2.Controls.Add(this.CBCategoria);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 228;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Productos";
            // 
            // DGVListaProducto
            // 
            this.DGVListaProducto.AllowUserToAddRows = false;
            this.DGVListaProducto.AllowUserToDeleteRows = false;
            this.DGVListaProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVListaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListaProducto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGVListaProducto.Location = new System.Drawing.Point(0, 137);
            this.DGVListaProducto.Name = "DGVListaProducto";
            this.DGVListaProducto.ReadOnly = true;
            this.DGVListaProducto.Size = new System.Drawing.Size(800, 91);
            this.DGVListaProducto.TabIndex = 15;
            this.DGVListaProducto.DoubleClick += new System.EventHandler(this.DGVListaProducto_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TBBuscarNom);
            this.panel1.Controls.Add(this.TBBuscarCod);
            this.panel1.Controls.Add(this.LNombre);
            this.panel1.Controls.Add(this.LCodigo);
            this.panel1.Location = new System.Drawing.Point(143, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 101);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Producto";
            // 
            // TBBuscarNom
            // 
            this.TBBuscarNom.Location = new System.Drawing.Point(354, 46);
            this.TBBuscarNom.MaxLength = 30;
            this.TBBuscarNom.Name = "TBBuscarNom";
            this.TBBuscarNom.Size = new System.Drawing.Size(124, 20);
            this.TBBuscarNom.TabIndex = 2;
            this.TBBuscarNom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBBuscarNom_KeyUp);
            // 
            // TBBuscarCod
            // 
            this.TBBuscarCod.Location = new System.Drawing.Point(143, 46);
            this.TBBuscarCod.MaxLength = 8;
            this.TBBuscarCod.Name = "TBBuscarCod";
            this.TBBuscarCod.Size = new System.Drawing.Size(124, 20);
            this.TBBuscarCod.TabIndex = 1;
            this.TBBuscarCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numeros);
            this.TBBuscarCod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBBuscarCod_KeyUp);
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(294, 49);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(54, 13);
            this.LNombre.TabIndex = 7;
            this.LNombre.Text = "Nombre:";
            // 
            // LCodigo
            // 
            this.LCodigo.AutoSize = true;
            this.LCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCodigo.Location = new System.Drawing.Point(87, 49);
            this.LCodigo.Name = "LCodigo";
            this.LCodigo.Size = new System.Drawing.Size(50, 13);
            this.LCodigo.TabIndex = 6;
            this.LCodigo.Text = "Código:";
            // 
            // BRecargarCat
            // 
            this.BRecargarCat.Location = new System.Drawing.Point(654, 64);
            this.BRecargarCat.Name = "BRecargarCat";
            this.BRecargarCat.Size = new System.Drawing.Size(75, 23);
            this.BRecargarCat.TabIndex = 14;
            this.BRecargarCat.Text = "Recargar";
            this.BRecargarCat.UseVisualStyleBackColor = true;
            // 
            // BRecargarMar
            // 
            this.BRecargarMar.Location = new System.Drawing.Point(654, 20);
            this.BRecargarMar.Name = "BRecargarMar";
            this.BRecargarMar.Size = new System.Drawing.Size(75, 23);
            this.BRecargarMar.TabIndex = 12;
            this.BRecargarMar.Text = "Recargar";
            this.BRecargarMar.UseVisualStyleBackColor = true;
            this.BRecargarMar.Click += new System.EventHandler(this.BRecargarMar_Click);
            // 
            // LLCategoria
            // 
            this.LLCategoria.AutoSize = true;
            this.LLCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLCategoria.Location = new System.Drawing.Point(593, 70);
            this.LLCategoria.Name = "LLCategoria";
            this.LLCategoria.Size = new System.Drawing.Size(51, 13);
            this.LLCategoria.TabIndex = 13;
            this.LLCategoria.TabStop = true;
            this.LLCategoria.Text = "Agregar";
            this.LLCategoria.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLCategoria_LinkClicked);
            // 
            // LLAgregarMarca
            // 
            this.LLAgregarMarca.AutoSize = true;
            this.LLAgregarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLAgregarMarca.Location = new System.Drawing.Point(593, 28);
            this.LLAgregarMarca.Name = "LLAgregarMarca";
            this.LLAgregarMarca.Size = new System.Drawing.Size(51, 13);
            this.LLAgregarMarca.TabIndex = 11;
            this.LLAgregarMarca.TabStop = true;
            this.LLAgregarMarca.Text = "Agregar";
            this.LLAgregarMarca.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LLAgregarMarca_LinkClicked);
            // 
            // TBPrecio
            // 
            this.TBPrecio.Location = new System.Drawing.Point(647, 114);
            this.TBPrecio.MaxLength = 30;
            this.TBPrecio.Name = "TBPrecio";
            this.TBPrecio.Size = new System.Drawing.Size(131, 20);
            this.TBPrecio.TabIndex = 9;
            this.TBPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBPrecio_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(593, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Precio:";
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(123, 64);
            this.TBNombre.MaxLength = 30;
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(157, 20);
            this.TBNombre.TabIndex = 4;
            // 
            // BModificar
            // 
            this.BModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BModificar.Location = new System.Drawing.Point(654, 168);
            this.BModificar.Name = "BModificar";
            this.BModificar.Size = new System.Drawing.Size(124, 35);
            this.BModificar.TabIndex = 10;
            this.BModificar.Text = "Modificar";
            this.BModificar.UseVisualStyleBackColor = true;
            this.BModificar.Click += new System.EventHandler(this.BModificar_Click);
            // 
            // TBCodigo
            // 
            this.TBCodigo.Enabled = false;
            this.TBCodigo.Location = new System.Drawing.Point(123, 17);
            this.TBCodigo.MaxLength = 8;
            this.TBCodigo.Name = "TBCodigo";
            this.TBCodigo.Size = new System.Drawing.Size(160, 20);
            this.TBCodigo.TabIndex = 3;
            this.TBCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numeros);
            // 
            // LAdvertencia
            // 
            this.LAdvertencia.AutoSize = true;
            this.LAdvertencia.BackColor = System.Drawing.Color.Silver;
            this.LAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.LAdvertencia.Location = new System.Drawing.Point(33, 179);
            this.LAdvertencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LAdvertencia.Name = "LAdvertencia";
            this.LAdvertencia.Size = new System.Drawing.Size(75, 13);
            this.LAdvertencia.TabIndex = 35;
            this.LAdvertencia.Text = "Advertencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombre:";
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Location = new System.Drawing.Point(123, 113);
            this.TBDescripcion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBDescripcion.MaxLength = 30;
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(160, 20);
            this.TBDescripcion.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Descripción:";
            // 
            // TBStockMin
            // 
            this.TBStockMin.Location = new System.Drawing.Point(418, 113);
            this.TBStockMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBStockMin.MaxLength = 8;
            this.TBStockMin.Name = "TBStockMin";
            this.TBStockMin.Size = new System.Drawing.Size(160, 20);
            this.TBStockMin.TabIndex = 8;
            this.TBStockMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_numeros);
            // 
            // CBMarca
            // 
            this.CBMarca.FormattingEnabled = true;
            this.CBMarca.Items.AddRange(new object[] {
            "Cuidado de la salud",
            "Pesas"});
            this.CBMarca.Location = new System.Drawing.Point(418, 62);
            this.CBMarca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CBMarca.Name = "CBMarca";
            this.CBMarca.Size = new System.Drawing.Size(156, 21);
            this.CBMarca.TabIndex = 7;
            // 
            // CBCategoria
            // 
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Items.AddRange(new object[] {
            "Cuidado de la salud",
            "Pesas"});
            this.CBCategoria.Location = new System.Drawing.Point(418, 20);
            this.CBCategoria.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(156, 21);
            this.CBCategoria.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(324, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Categoria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(303, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Stock minimo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Marca:";
            // 
            // Modificar_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modificar_producto";
            this.Text = "Modificar producto";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProducto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVListaProducto;
        private System.Windows.Forms.TextBox TBBuscarNom;
        private System.Windows.Forms.TextBox TBBuscarCod;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LCodigo;
        private System.Windows.Forms.TextBox TBStockMin;
        private System.Windows.Forms.ComboBox CBMarca;
        private System.Windows.Forms.ComboBox CBCategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BModificar;
        private System.Windows.Forms.Label LAdvertencia;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBPrecio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BRecargarCat;
        private System.Windows.Forms.Button BRecargarMar;
        private System.Windows.Forms.LinkLabel LLCategoria;
        private System.Windows.Forms.LinkLabel LLAgregarMarca;
    }
}