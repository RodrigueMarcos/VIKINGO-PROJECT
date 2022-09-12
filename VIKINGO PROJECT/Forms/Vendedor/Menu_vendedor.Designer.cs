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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarUltimoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ultimaFacturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.L_advertencia_nv = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BNuevaVenta = new System.Windows.Forms.Button();
            this.LAdvertencia_NV = new System.Windows.Forms.Label();
            this.BNuevoCliente = new System.Windows.Forms.Button();
            this.LAdvertencia_NC = new System.Windows.Forms.Label();
            this.BConsulta = new System.Windows.Forms.Button();
            this.LAdvertencia_C = new System.Windows.Forms.Label();
            this.BCerrar_sesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip2);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 64;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(687, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 49);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.facturaciónToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.ayudaToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(796, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoClienteToolStripMenuItem,
            this.modificarClienteToolStripMenuItem,
            this.mostrarUltimoClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.nuevoClienteToolStripMenuItem.Text = "Nuevo cliente";
            this.nuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.nuevoClienteToolStripMenuItem_Click);
            // 
            // modificarClienteToolStripMenuItem
            // 
            this.modificarClienteToolStripMenuItem.Name = "modificarClienteToolStripMenuItem";
            this.modificarClienteToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.modificarClienteToolStripMenuItem.Text = "Modificar cliente";
            // 
            // mostrarUltimoClienteToolStripMenuItem
            // 
            this.mostrarUltimoClienteToolStripMenuItem.Name = "mostrarUltimoClienteToolStripMenuItem";
            this.mostrarUltimoClienteToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.mostrarUltimoClienteToolStripMenuItem.Text = "Mostrar ultimo cliente";
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturacionesToolStripMenuItem,
            this.ultimaFacturaciónToolStripMenuItem});
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.facturaciónToolStripMenuItem.Text = "Facturación";
            // 
            // facturacionesToolStripMenuItem
            // 
            this.facturacionesToolStripMenuItem.Name = "facturacionesToolStripMenuItem";
            this.facturacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facturacionesToolStripMenuItem.Text = "Facturaciones";
            this.facturacionesToolStripMenuItem.Click += new System.EventHandler(this.facturacionesToolStripMenuItem_Click);
            // 
            // ultimaFacturaciónToolStripMenuItem
            // 
            this.ultimaFacturaciónToolStripMenuItem.Name = "ultimaFacturaciónToolStripMenuItem";
            this.ultimaFacturaciónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ultimaFacturaciónToolStripMenuItem.Text = "Ultima facturación";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verProductosToolStripMenuItem,
            this.buscarProductosToolStripMenuItem});
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.calculadoraToolStripMenuItem.Text = "Productos";
            // 
            // verProductosToolStripMenuItem
            // 
            this.verProductosToolStripMenuItem.Name = "verProductosToolStripMenuItem";
            this.verProductosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.verProductosToolStripMenuItem.Text = "Ver productos";
            // 
            // buscarProductosToolStripMenuItem
            // 
            this.buscarProductosToolStripMenuItem.Name = "buscarProductosToolStripMenuItem";
            this.buscarProductosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.buscarProductosToolStripMenuItem.Text = "Buscar productos";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.ayudaToolStripMenuItem.Text = "Calculadora";
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
            this.splitContainer2.Panel1.Controls.Add(this.L_advertencia_nv);
            this.splitContainer2.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(800, 382);
            this.splitContainer2.SplitterDistance = 145;
            this.splitContainer2.TabIndex = 0;
            // 
            // L_advertencia_nv
            // 
            this.L_advertencia_nv.AutoSize = true;
            this.L_advertencia_nv.Location = new System.Drawing.Point(10, 62);
            this.L_advertencia_nv.Name = "L_advertencia_nv";
            this.L_advertencia_nv.Size = new System.Drawing.Size(0, 13);
            this.L_advertencia_nv.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BNuevaVenta);
            this.flowLayoutPanel1.Controls.Add(this.LAdvertencia_NV);
            this.flowLayoutPanel1.Controls.Add(this.BNuevoCliente);
            this.flowLayoutPanel1.Controls.Add(this.LAdvertencia_NC);
            this.flowLayoutPanel1.Controls.Add(this.BConsulta);
            this.flowLayoutPanel1.Controls.Add(this.LAdvertencia_C);
            this.flowLayoutPanel1.Controls.Add(this.BCerrar_sesion);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(141, 378);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // BNuevaVenta
            // 
            this.BNuevaVenta.Location = new System.Drawing.Point(3, 3);
            this.BNuevaVenta.Name = "BNuevaVenta";
            this.BNuevaVenta.Size = new System.Drawing.Size(130, 43);
            this.BNuevaVenta.TabIndex = 0;
            this.BNuevaVenta.Text = "Nueva venta";
            this.BNuevaVenta.UseVisualStyleBackColor = true;
            this.BNuevaVenta.Click += new System.EventHandler(this.BNuevaVenta_Click);
            // 
            // LAdvertencia_NV
            // 
            this.LAdvertencia_NV.AutoSize = true;
            this.LAdvertencia_NV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LAdvertencia_NV.Location = new System.Drawing.Point(3, 49);
            this.LAdvertencia_NV.Name = "LAdvertencia_NV";
            this.LAdvertencia_NV.Size = new System.Drawing.Size(64, 13);
            this.LAdvertencia_NV.TabIndex = 5;
            this.LAdvertencia_NV.Text = "Advertencia";
            // 
            // BNuevoCliente
            // 
            this.BNuevoCliente.Location = new System.Drawing.Point(3, 65);
            this.BNuevoCliente.Name = "BNuevoCliente";
            this.BNuevoCliente.Size = new System.Drawing.Size(130, 43);
            this.BNuevoCliente.TabIndex = 1;
            this.BNuevoCliente.Text = "Nuevo Cliente";
            this.BNuevoCliente.UseVisualStyleBackColor = true;
            this.BNuevoCliente.Click += new System.EventHandler(this.BNuevoCliente_Click);
            // 
            // LAdvertencia_NC
            // 
            this.LAdvertencia_NC.AutoSize = true;
            this.LAdvertencia_NC.Location = new System.Drawing.Point(3, 111);
            this.LAdvertencia_NC.Name = "LAdvertencia_NC";
            this.LAdvertencia_NC.Size = new System.Drawing.Size(64, 13);
            this.LAdvertencia_NC.TabIndex = 6;
            this.LAdvertencia_NC.Text = "Advertencia";
            // 
            // BConsulta
            // 
            this.BConsulta.Location = new System.Drawing.Point(3, 127);
            this.BConsulta.Name = "BConsulta";
            this.BConsulta.Size = new System.Drawing.Size(130, 43);
            this.BConsulta.TabIndex = 2;
            this.BConsulta.Text = "Consulta";
            this.BConsulta.UseVisualStyleBackColor = true;
            this.BConsulta.Click += new System.EventHandler(this.BConsulta_Click);
            // 
            // LAdvertencia_C
            // 
            this.LAdvertencia_C.AutoSize = true;
            this.LAdvertencia_C.Location = new System.Drawing.Point(3, 173);
            this.LAdvertencia_C.Name = "LAdvertencia_C";
            this.LAdvertencia_C.Size = new System.Drawing.Size(64, 13);
            this.LAdvertencia_C.TabIndex = 7;
            this.LAdvertencia_C.Text = "Advertencia";
            // 
            // BCerrar_sesion
            // 
            this.BCerrar_sesion.Location = new System.Drawing.Point(3, 189);
            this.BCerrar_sesion.Name = "BCerrar_sesion";
            this.BCerrar_sesion.Size = new System.Drawing.Size(130, 43);
            this.BCerrar_sesion.TabIndex = 3;
            this.BCerrar_sesion.Text = "Cerrar Sesión";
            this.BCerrar_sesion.UseVisualStyleBackColor = true;
            this.BCerrar_sesion.Click += new System.EventHandler(this.BCerrar_sesion_Click);
            // 
            // Menu_vendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_vendedor";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button BCerrar_sesion;
        private System.Windows.Forms.Button BConsulta;
        private System.Windows.Forms.Button BNuevoCliente;
        private System.Windows.Forms.Button BNuevaVenta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarUltimoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ultimaFacturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarProductosToolStripMenuItem;
        private System.Windows.Forms.Label L_advertencia_nv;
        private System.Windows.Forms.Label LAdvertencia_NV;
        private System.Windows.Forms.Label LAdvertencia_NC;
        private System.Windows.Forms.Label LAdvertencia_C;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}