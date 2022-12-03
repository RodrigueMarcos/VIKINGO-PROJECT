namespace VIKINGO_PROJECT.Forms.Supervisor
{
    partial class Menu_administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_administrador));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LApeNom = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoaVencerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoDefectuosoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productosFaltantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.LAdvertencia = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.BListar = new System.Windows.Forms.Button();
            this.BAgregar_lote = new System.Windows.Forms.Button();
            this.BAgregar_producto = new System.Windows.Forms.Button();
            this.BGestionarCli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.LApeNom);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1234, 661);
            this.splitContainer1.SplitterDistance = 123;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(994, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LApeNom
            // 
            this.LApeNom.AutoSize = true;
            this.LApeNom.Dock = System.Windows.Forms.DockStyle.Right;
            this.LApeNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApeNom.Location = new System.Drawing.Point(1094, 24);
            this.LApeNom.Name = "LApeNom";
            this.LApeNom.Size = new System.Drawing.Size(136, 16);
            this.LApeNom.TabIndex = 1;
            this.LApeNom.Text = "Apellido y Nombre";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1230, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem,
            this.modificarProductoToolStripMenuItem,
            this.productoaVencerToolStripMenuItem,
            this.productoDefectuosoToolStripMenuItem1,
            this.productosFaltantesToolStripMenuItem});
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.productoToolStripMenuItem.Text = "Producto";
            // 
            // agregarProductoToolStripMenuItem
            // 
            this.agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            this.agregarProductoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.agregarProductoToolStripMenuItem.Text = "Agregar producto";
            this.agregarProductoToolStripMenuItem.Click += new System.EventHandler(this.modificarProductosToolStripMenuItem_Click);
            // 
            // modificarProductoToolStripMenuItem
            // 
            this.modificarProductoToolStripMenuItem.Name = "modificarProductoToolStripMenuItem";
            this.modificarProductoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.modificarProductoToolStripMenuItem.Text = "Modificar producto";
            this.modificarProductoToolStripMenuItem.Click += new System.EventHandler(this.productoAVencerToolStripMenuItem_Click);
            // 
            // productoaVencerToolStripMenuItem
            // 
            this.productoaVencerToolStripMenuItem.Name = "productoaVencerToolStripMenuItem";
            this.productoaVencerToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.productoaVencerToolStripMenuItem.Text = "Lista de productos";
            this.productoaVencerToolStripMenuItem.Click += new System.EventHandler(this.productoDefectuosoToolStripMenuItem_Click);
            // 
            // productoDefectuosoToolStripMenuItem1
            // 
            this.productoDefectuosoToolStripMenuItem1.Name = "productoDefectuosoToolStripMenuItem1";
            this.productoDefectuosoToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.productoDefectuosoToolStripMenuItem1.Text = "Producto defectuoso";
            this.productoDefectuosoToolStripMenuItem1.Click += new System.EventHandler(this.productoDefectuosoToolStripMenuItem1_Click);
            // 
            // productosFaltantesToolStripMenuItem
            // 
            this.productosFaltantesToolStripMenuItem.Name = "productosFaltantesToolStripMenuItem";
            this.productosFaltantesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.productosFaltantesToolStripMenuItem.Text = "Productos faltantes";
            this.productosFaltantesToolStripMenuItem.Click += new System.EventHandler(this.productosFaltantesToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verVentasToolStripMenuItem,
            this.estadisticasToolStripMenuItem});
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.calculadoraToolStripMenuItem.Text = "Ventas";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // verVentasToolStripMenuItem
            // 
            this.verVentasToolStripMenuItem.Name = "verVentasToolStripMenuItem";
            this.verVentasToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.verVentasToolStripMenuItem.Text = "Ver ventas";
            this.verVentasToolStripMenuItem.Click += new System.EventHandler(this.verVentasToolStripMenuItem_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            this.estadisticasToolStripMenuItem.Click += new System.EventHandler(this.estadisticasToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.acercaDeToolStripMenuItem.Text = "Calculadora";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.BGestionarCli);
            this.splitContainer2.Panel1.Controls.Add(this.LAdvertencia);
            this.splitContainer2.Panel1.Controls.Add(this.button4);
            this.splitContainer2.Panel1.Controls.Add(this.BListar);
            this.splitContainer2.Panel1.Controls.Add(this.BAgregar_lote);
            this.splitContainer2.Panel1.Controls.Add(this.BAgregar_producto);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(1234, 534);
            this.splitContainer2.SplitterDistance = 239;
            this.splitContainer2.TabIndex = 0;
            // 
            // LAdvertencia
            // 
            this.LAdvertencia.AutoSize = true;
            this.LAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.LAdvertencia.Location = new System.Drawing.Point(3, 262);
            this.LAdvertencia.Name = "LAdvertencia";
            this.LAdvertencia.Size = new System.Drawing.Size(75, 13);
            this.LAdvertencia.TabIndex = 6;
            this.LAdvertencia.Text = "Advertencia";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 483);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 47);
            this.button4.TabIndex = 3;
            this.button4.Text = "Cerrar Sesión";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BListar
            // 
            this.BListar.BackColor = System.Drawing.Color.Navy;
            this.BListar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BListar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BListar.Image = ((System.Drawing.Image)(resources.GetObject("BListar.Image")));
            this.BListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BListar.Location = new System.Drawing.Point(0, 116);
            this.BListar.Name = "BListar";
            this.BListar.Size = new System.Drawing.Size(235, 57);
            this.BListar.TabIndex = 2;
            this.BListar.Text = "Lista de producto";
            this.BListar.UseVisualStyleBackColor = false;
            this.BListar.Click += new System.EventHandler(this.BVencimiento_Click);
            // 
            // BAgregar_lote
            // 
            this.BAgregar_lote.BackColor = System.Drawing.Color.Navy;
            this.BAgregar_lote.Dock = System.Windows.Forms.DockStyle.Top;
            this.BAgregar_lote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregar_lote.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BAgregar_lote.Image = ((System.Drawing.Image)(resources.GetObject("BAgregar_lote.Image")));
            this.BAgregar_lote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAgregar_lote.Location = new System.Drawing.Point(0, 61);
            this.BAgregar_lote.Name = "BAgregar_lote";
            this.BAgregar_lote.Size = new System.Drawing.Size(235, 55);
            this.BAgregar_lote.TabIndex = 1;
            this.BAgregar_lote.Text = "Nuevo ingreso";
            this.BAgregar_lote.UseVisualStyleBackColor = false;
            this.BAgregar_lote.Click += new System.EventHandler(this.button2_Click);
            // 
            // BAgregar_producto
            // 
            this.BAgregar_producto.BackColor = System.Drawing.Color.Navy;
            this.BAgregar_producto.Dock = System.Windows.Forms.DockStyle.Top;
            this.BAgregar_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregar_producto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BAgregar_producto.Image = ((System.Drawing.Image)(resources.GetObject("BAgregar_producto.Image")));
            this.BAgregar_producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAgregar_producto.Location = new System.Drawing.Point(0, 0);
            this.BAgregar_producto.Name = "BAgregar_producto";
            this.BAgregar_producto.Size = new System.Drawing.Size(235, 61);
            this.BAgregar_producto.TabIndex = 0;
            this.BAgregar_producto.Text = "Agregar producto";
            this.BAgregar_producto.UseVisualStyleBackColor = false;
            this.BAgregar_producto.Click += new System.EventHandler(this.button1_Click);
            // 
            // BGestionarCli
            // 
            this.BGestionarCli.BackColor = System.Drawing.Color.Navy;
            this.BGestionarCli.Dock = System.Windows.Forms.DockStyle.Top;
            this.BGestionarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGestionarCli.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BGestionarCli.Image = ((System.Drawing.Image)(resources.GetObject("BGestionarCli.Image")));
            this.BGestionarCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGestionarCli.Location = new System.Drawing.Point(0, 173);
            this.BGestionarCli.Name = "BGestionarCli";
            this.BGestionarCli.Size = new System.Drawing.Size(235, 57);
            this.BGestionarCli.TabIndex = 7;
            this.BGestionarCli.Text = "Gestionar Cliente";
            this.BGestionarCli.UseVisualStyleBackColor = false;
            this.BGestionarCli.Click += new System.EventHandler(this.BGestionarCli_Click);
            // 
            // Menu_administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Menu_administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIKINGO S.R.L";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.Button BListar;
        private System.Windows.Forms.Button BAgregar_lote;
        private System.Windows.Forms.Button BAgregar_producto;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoaVencerToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label LAdvertencia;
        private System.Windows.Forms.ToolStripMenuItem productoDefectuosoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.Label LApeNom;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem productosFaltantesToolStripMenuItem;
        private System.Windows.Forms.Button BGestionarCli;
    }
}