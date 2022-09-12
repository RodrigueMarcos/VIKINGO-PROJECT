namespace VIKINGO_PROJECT.Forms.Supervisor
{
    partial class Menu_supervisor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoaVencerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoDefectuosoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.LAdvertencia_PC = new System.Windows.Forms.Label();
            this.LAdvertencia_NI = new System.Windows.Forms.Label();
            this.LAdvertencia_AP = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.BVencimiento = new System.Windows.Forms.Button();
            this.BAgregar_lote = new System.Windows.Forms.Button();
            this.BAgregar_producto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 84;
            this.splitContainer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem,
            this.modificarProductoToolStripMenuItem,
            this.productoaVencerToolStripMenuItem,
            this.productoDefectuosoToolStripMenuItem1});
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
            this.productoaVencerToolStripMenuItem.Text = "Producto a vencer";
            this.productoaVencerToolStripMenuItem.Click += new System.EventHandler(this.productoDefectuosoToolStripMenuItem_Click);
            // 
            // productoDefectuosoToolStripMenuItem1
            // 
            this.productoDefectuosoToolStripMenuItem1.Name = "productoDefectuosoToolStripMenuItem1";
            this.productoDefectuosoToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.productoDefectuosoToolStripMenuItem1.Text = "Producto defectuoso";
            this.productoDefectuosoToolStripMenuItem1.Click += new System.EventHandler(this.productoDefectuosoToolStripMenuItem1_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
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
            this.splitContainer2.Panel1.Controls.Add(this.LAdvertencia_PC);
            this.splitContainer2.Panel1.Controls.Add(this.LAdvertencia_NI);
            this.splitContainer2.Panel1.Controls.Add(this.LAdvertencia_AP);
            this.splitContainer2.Panel1.Controls.Add(this.button4);
            this.splitContainer2.Panel1.Controls.Add(this.BVencimiento);
            this.splitContainer2.Panel1.Controls.Add(this.BAgregar_lote);
            this.splitContainer2.Panel1.Controls.Add(this.BAgregar_producto);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(800, 362);
            this.splitContainer2.SplitterDistance = 155;
            this.splitContainer2.TabIndex = 0;
            // 
            // LAdvertencia_PC
            // 
            this.LAdvertencia_PC.AutoSize = true;
            this.LAdvertencia_PC.Location = new System.Drawing.Point(36, 225);
            this.LAdvertencia_PC.Name = "LAdvertencia_PC";
            this.LAdvertencia_PC.Size = new System.Drawing.Size(64, 13);
            this.LAdvertencia_PC.TabIndex = 6;
            this.LAdvertencia_PC.Text = "Advertencia";
            // 
            // LAdvertencia_NI
            // 
            this.LAdvertencia_NI.AutoSize = true;
            this.LAdvertencia_NI.Location = new System.Drawing.Point(36, 155);
            this.LAdvertencia_NI.Name = "LAdvertencia_NI";
            this.LAdvertencia_NI.Size = new System.Drawing.Size(64, 13);
            this.LAdvertencia_NI.TabIndex = 5;
            this.LAdvertencia_NI.Text = "Advertencia";
            // 
            // LAdvertencia_AP
            // 
            this.LAdvertencia_AP.AutoSize = true;
            this.LAdvertencia_AP.Location = new System.Drawing.Point(36, 81);
            this.LAdvertencia_AP.Name = "LAdvertencia_AP";
            this.LAdvertencia_AP.Size = new System.Drawing.Size(64, 13);
            this.LAdvertencia_AP.TabIndex = 4;
            this.LAdvertencia_AP.Text = "Advertencia";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 290);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 58);
            this.button4.TabIndex = 3;
            this.button4.Text = "Cerrar Sesión";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BVencimiento
            // 
            this.BVencimiento.Location = new System.Drawing.Point(10, 165);
            this.BVencimiento.Name = "BVencimiento";
            this.BVencimiento.Size = new System.Drawing.Size(126, 57);
            this.BVencimiento.TabIndex = 2;
            this.BVencimiento.Text = "Producto próximo a caducar";
            this.BVencimiento.UseVisualStyleBackColor = true;
            this.BVencimiento.Click += new System.EventHandler(this.BVencimiento_Click);
            // 
            // BAgregar_lote
            // 
            this.BAgregar_lote.Location = new System.Drawing.Point(10, 97);
            this.BAgregar_lote.Name = "BAgregar_lote";
            this.BAgregar_lote.Size = new System.Drawing.Size(127, 55);
            this.BAgregar_lote.TabIndex = 1;
            this.BAgregar_lote.Text = "Nuevo ingreso";
            this.BAgregar_lote.UseVisualStyleBackColor = true;
            this.BAgregar_lote.Click += new System.EventHandler(this.button2_Click);
            // 
            // BAgregar_producto
            // 
            this.BAgregar_producto.Location = new System.Drawing.Point(12, 21);
            this.BAgregar_producto.Name = "BAgregar_producto";
            this.BAgregar_producto.Size = new System.Drawing.Size(126, 61);
            this.BAgregar_producto.TabIndex = 0;
            this.BAgregar_producto.Text = "Agregar producto";
            this.BAgregar_producto.UseVisualStyleBackColor = true;
            this.BAgregar_producto.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu_supervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_supervisor";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.Button BVencimiento;
        private System.Windows.Forms.Button BAgregar_lote;
        private System.Windows.Forms.Button BAgregar_producto;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoaVencerToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label LAdvertencia_PC;
        private System.Windows.Forms.Label LAdvertencia_NI;
        private System.Windows.Forms.Label LAdvertencia_AP;
        private System.Windows.Forms.ToolStripMenuItem productoDefectuosoToolStripMenuItem1;
    }
}