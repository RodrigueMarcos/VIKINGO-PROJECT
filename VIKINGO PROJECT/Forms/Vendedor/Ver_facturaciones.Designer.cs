namespace VIKINGO_PROJECT.Forms.Vendedor
{
    partial class Ver_facturaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ver_facturaciones));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.BCerrar = new System.Windows.Forms.Button();
            this.RBHoy = new System.Windows.Forms.RadioButton();
            this.RBTodos = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Facturas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.BPDF = new System.Windows.Forms.Button();
            this.DGV_Detalle = new System.Windows.Forms.DataGridView();
            this.BSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Facturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Detalle)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.BCerrar);
            this.splitContainer1.Panel1.Controls.Add(this.RBHoy);
            this.splitContainer1.Panel1.Controls.Add(this.RBTodos);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.DGV_Facturas);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.BPDF);
            this.splitContainer1.Panel2.Controls.Add(this.DGV_Detalle);
            this.splitContainer1.Panel2.Controls.Add(this.BSalir);
            this.splitContainer1.Size = new System.Drawing.Size(1100, 600);
            this.splitContainer1.SplitterDistance = 233;
            this.splitContainer1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(0, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "*Debes selecionar la fila completa si desea imprimir una factura!!!";
            // 
            // BCerrar
            // 
            this.BCerrar.BackColor = System.Drawing.Color.Tomato;
            this.BCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCerrar.Location = new System.Drawing.Point(967, 25);
            this.BCerrar.Name = "BCerrar";
            this.BCerrar.Size = new System.Drawing.Size(121, 44);
            this.BCerrar.TabIndex = 4;
            this.BCerrar.Text = "Cerrar";
            this.BCerrar.UseVisualStyleBackColor = false;
            this.BCerrar.Click += new System.EventHandler(this.BCerrar_Click);
            // 
            // RBHoy
            // 
            this.RBHoy.AutoSize = true;
            this.RBHoy.Location = new System.Drawing.Point(366, 9);
            this.RBHoy.Name = "RBHoy";
            this.RBHoy.Size = new System.Drawing.Size(66, 17);
            this.RBHoy.TabIndex = 3;
            this.RBHoy.TabStop = true;
            this.RBHoy.Text = "Solo hoy";
            this.RBHoy.UseVisualStyleBackColor = true;
            this.RBHoy.CheckedChanged += new System.EventHandler(this.RBHoy_CheckedChanged);
            // 
            // RBTodos
            // 
            this.RBTodos.AutoSize = true;
            this.RBTodos.Checked = true;
            this.RBTodos.Location = new System.Drawing.Point(204, 9);
            this.RBTodos.Name = "RBTodos";
            this.RBTodos.Size = new System.Drawing.Size(55, 17);
            this.RBTodos.TabIndex = 2;
            this.RBTodos.TabStop = true;
            this.RBTodos.Text = "Todos";
            this.RBTodos.UseVisualStyleBackColor = true;
            this.RBTodos.CheckedChanged += new System.EventHandler(this.RBTodos_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Facturaciones";
            // 
            // DGV_Facturas
            // 
            this.DGV_Facturas.AllowUserToAddRows = false;
            this.DGV_Facturas.AllowUserToDeleteRows = false;
            this.DGV_Facturas.AllowUserToResizeColumns = false;
            this.DGV_Facturas.AllowUserToResizeRows = false;
            this.DGV_Facturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Facturas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV_Facturas.Location = new System.Drawing.Point(0, 90);
            this.DGV_Facturas.Name = "DGV_Facturas";
            this.DGV_Facturas.ReadOnly = true;
            this.DGV_Facturas.Size = new System.Drawing.Size(1100, 143);
            this.DGV_Facturas.TabIndex = 0;
            this.DGV_Facturas.Click += new System.EventHandler(this.DGV_Facturas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Detalle de la factura";
            // 
            // BPDF
            // 
            this.BPDF.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPDF.Image = ((System.Drawing.Image)(resources.GetObject("BPDF.Image")));
            this.BPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BPDF.Location = new System.Drawing.Point(967, 27);
            this.BPDF.Name = "BPDF";
            this.BPDF.Size = new System.Drawing.Size(121, 44);
            this.BPDF.TabIndex = 5;
            this.BPDF.Text = "Generar pdf";
            this.BPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BPDF.UseVisualStyleBackColor = false;
            this.BPDF.Click += new System.EventHandler(this.BPDF_Click);
            // 
            // DGV_Detalle
            // 
            this.DGV_Detalle.AllowUserToAddRows = false;
            this.DGV_Detalle.AllowUserToDeleteRows = false;
            this.DGV_Detalle.AllowUserToResizeColumns = false;
            this.DGV_Detalle.AllowUserToResizeRows = false;
            this.DGV_Detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Detalle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGV_Detalle.Location = new System.Drawing.Point(0, 108);
            this.DGV_Detalle.Name = "DGV_Detalle";
            this.DGV_Detalle.ReadOnly = true;
            this.DGV_Detalle.Size = new System.Drawing.Size(1100, 255);
            this.DGV_Detalle.TabIndex = 3;
            // 
            // BSalir
            // 
            this.BSalir.Location = new System.Drawing.Point(582, 223);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(126, 36);
            this.BSalir.TabIndex = 2;
            this.BSalir.Text = "Salir";
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // Ver_facturaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ver_facturaciones";
            this.Text = "Facturaciones";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Facturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Detalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DGV_Facturas;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_Detalle;
        private System.Windows.Forms.RadioButton RBHoy;
        private System.Windows.Forms.RadioButton RBTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BCerrar;
        private System.Windows.Forms.Button BPDF;
        private System.Windows.Forms.Label label3;
    }
}