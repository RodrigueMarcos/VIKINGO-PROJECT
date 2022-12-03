namespace VIKINGO_PROJECT.Forms.Vendedor
{
    partial class Menu_vendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_vendedor));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Vendedor = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.BListarProducto = new System.Windows.Forms.Button();
            this.BCerrar_sesion = new System.Windows.Forms.Button();
            this.LAdvertencia = new System.Windows.Forms.Label();
            this.BGestionarCliente = new System.Windows.Forms.Button();
            this.BNuevaVenta = new System.Windows.Forms.Button();
            this.BNuevoCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.Vendedor);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip2);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1234, 661);
            this.splitContainer1.SplitterDistance = 94;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1018, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Vendedor
            // 
            this.Vendedor.AutoSize = true;
            this.Vendedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.Vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vendedor.Location = new System.Drawing.Point(1180, 24);
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.Size = new System.Drawing.Size(50, 16);
            this.Vendedor.TabIndex = 4;
            this.Vendedor.Text = "label2";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.facturaciónToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.ayudaToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1230, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoClienteToolStripMenuItem,
            this.gestionarClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.nuevoClienteToolStripMenuItem.Text = "Nuevo cliente";
            this.nuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.nuevoClienteToolStripMenuItem_Click);
            // 
            // gestionarClienteToolStripMenuItem
            // 
            this.gestionarClienteToolStripMenuItem.Name = "gestionarClienteToolStripMenuItem";
            this.gestionarClienteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.gestionarClienteToolStripMenuItem.Text = "Gestionar Cliente";
            this.gestionarClienteToolStripMenuItem.Click += new System.EventHandler(this.gestionarClienteToolStripMenuItem_Click);
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturacionesToolStripMenuItem});
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.facturaciónToolStripMenuItem.Text = "Facturación";
            // 
            // facturacionesToolStripMenuItem
            // 
            this.facturacionesToolStripMenuItem.Name = "facturacionesToolStripMenuItem";
            this.facturacionesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.facturacionesToolStripMenuItem.Text = "Facturaciones";
            this.facturacionesToolStripMenuItem.Click += new System.EventHandler(this.facturacionesToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verProductosToolStripMenuItem});
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.calculadoraToolStripMenuItem.Text = "Productos";
            // 
            // verProductosToolStripMenuItem
            // 
            this.verProductosToolStripMenuItem.Name = "verProductosToolStripMenuItem";
            this.verProductosToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.verProductosToolStripMenuItem.Text = "Ver productos";
            this.verProductosToolStripMenuItem.Click += new System.EventHandler(this.verProductosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.ayudaToolStripMenuItem.Text = "Calculadora";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.BListarProducto);
            this.splitContainer2.Panel1.Controls.Add(this.BCerrar_sesion);
            this.splitContainer2.Panel1.Controls.Add(this.LAdvertencia);
            this.splitContainer2.Panel1.Controls.Add(this.BGestionarCliente);
            this.splitContainer2.Panel1.Controls.Add(this.BNuevaVenta);
            this.splitContainer2.Panel1.Controls.Add(this.BNuevoCliente);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(1234, 563);
            this.splitContainer2.SplitterDistance = 222;
            this.splitContainer2.TabIndex = 0;
            // 
            // BListarProducto
            // 
            this.BListarProducto.BackColor = System.Drawing.Color.Navy;
            this.BListarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.BListarProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BListarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BListarProducto.Image")));
            this.BListarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BListarProducto.Location = new System.Drawing.Point(0, 129);
            this.BListarProducto.Name = "BListarProducto";
            this.BListarProducto.Size = new System.Drawing.Size(218, 43);
            this.BListarProducto.TabIndex = 8;
            this.BListarProducto.Text = "Listar Productos";
            this.BListarProducto.UseVisualStyleBackColor = false;
            this.BListarProducto.Click += new System.EventHandler(this.GestiorCliente_Click);
            // 
            // BCerrar_sesion
            // 
            this.BCerrar_sesion.BackColor = System.Drawing.Color.Red;
            this.BCerrar_sesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BCerrar_sesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BCerrar_sesion.Image = ((System.Drawing.Image)(resources.GetObject("BCerrar_sesion.Image")));
            this.BCerrar_sesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCerrar_sesion.Location = new System.Drawing.Point(0, 516);
            this.BCerrar_sesion.Name = "BCerrar_sesion";
            this.BCerrar_sesion.Size = new System.Drawing.Size(218, 43);
            this.BCerrar_sesion.TabIndex = 3;
            this.BCerrar_sesion.Text = "Cerrar Sesión";
            this.BCerrar_sesion.UseVisualStyleBackColor = false;
            this.BCerrar_sesion.Click += new System.EventHandler(this.BCerrar_sesion_Click);
            // 
            // LAdvertencia
            // 
            this.LAdvertencia.AutoSize = true;
            this.LAdvertencia.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.LAdvertencia.Location = new System.Drawing.Point(10, 250);
            this.LAdvertencia.Name = "LAdvertencia";
            this.LAdvertencia.Size = new System.Drawing.Size(82, 19);
            this.LAdvertencia.TabIndex = 7;
            this.LAdvertencia.Text = "Advertencia";
            // 
            // BGestionarCliente
            // 
            this.BGestionarCliente.BackColor = System.Drawing.Color.Navy;
            this.BGestionarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BGestionarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BGestionarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BGestionarCliente.Image")));
            this.BGestionarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGestionarCliente.Location = new System.Drawing.Point(0, 86);
            this.BGestionarCliente.Name = "BGestionarCliente";
            this.BGestionarCliente.Size = new System.Drawing.Size(218, 43);
            this.BGestionarCliente.TabIndex = 7;
            this.BGestionarCliente.Text = "Gestionar Cliente";
            this.BGestionarCliente.UseVisualStyleBackColor = false;
            this.BGestionarCliente.Click += new System.EventHandler(this.BNuevaVenta_Click);
            this.BGestionarCliente.MouseLeave += new System.EventHandler(this.BNuevaVenta_MouseLeave);
            this.BGestionarCliente.MouseHover += new System.EventHandler(this.BNuevaVenta_MouseHover);
            // 
            // BNuevaVenta
            // 
            this.BNuevaVenta.BackColor = System.Drawing.Color.Navy;
            this.BNuevaVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.BNuevaVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BNuevaVenta.Image = ((System.Drawing.Image)(resources.GetObject("BNuevaVenta.Image")));
            this.BNuevaVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BNuevaVenta.Location = new System.Drawing.Point(0, 43);
            this.BNuevaVenta.Name = "BNuevaVenta";
            this.BNuevaVenta.Size = new System.Drawing.Size(218, 43);
            this.BNuevaVenta.TabIndex = 9;
            this.BNuevaVenta.Text = "Nueva Venta";
            this.BNuevaVenta.UseVisualStyleBackColor = false;
            this.BNuevaVenta.Click += new System.EventHandler(this.BConsulta_Click);
            this.BNuevaVenta.MouseLeave += new System.EventHandler(this.BConsulta_MouseLeave);
            this.BNuevaVenta.MouseHover += new System.EventHandler(this.BConsulta_MouseHover);
            // 
            // BNuevoCliente
            // 
            this.BNuevoCliente.BackColor = System.Drawing.Color.Navy;
            this.BNuevoCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.BNuevoCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BNuevoCliente.Image = ((System.Drawing.Image)(resources.GetObject("BNuevoCliente.Image")));
            this.BNuevoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BNuevoCliente.Location = new System.Drawing.Point(0, 0);
            this.BNuevoCliente.Name = "BNuevoCliente";
            this.BNuevoCliente.Size = new System.Drawing.Size(218, 43);
            this.BNuevoCliente.TabIndex = 6;
            this.BNuevoCliente.Text = "Nuevo Cliente";
            this.BNuevoCliente.UseVisualStyleBackColor = false;
            this.BNuevoCliente.Click += new System.EventHandler(this.BNuevoCliente_Click);
            this.BNuevoCliente.MouseLeave += new System.EventHandler(this.BNuevoCliente_MouseLeave);
            this.BNuevoCliente.MouseHover += new System.EventHandler(this.BNuevoCliente_MouseHover);
            // 
            // Menu_vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu_vendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIKINGO S.R.L";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_vendedor_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button BCerrar_sesion;
        private System.Windows.Forms.Button BNuevaVenta;
        private System.Windows.Forms.Button BNuevoCliente;
        private System.Windows.Forms.Button BGestionarCliente;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verProductosToolStripMenuItem;
        private System.Windows.Forms.Label LAdvertencia;
        private System.Windows.Forms.ToolStripMenuItem gestionarClienteToolStripMenuItem;
        private System.Windows.Forms.Button BListarProducto;
        private System.Windows.Forms.Label Vendedor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}