namespace VIKINGO_PROJECT.Forms.Administrador
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuaioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.BCerrar_sesion = new System.Windows.Forms.Button();
            this.Ladvertencia_AU = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 91;
            this.splitContainer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuaioToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuaioToolStripMenuItem
            // 
            this.usuaioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuarioToolStripMenuItem,
            this.tablaDeUsuariosToolStripMenuItem});
            this.usuaioToolStripMenuItem.Name = "usuaioToolStripMenuItem";
            this.usuaioToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.usuaioToolStripMenuItem.Text = "Usuaio";
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            this.agregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarUsuarioToolStripMenuItem.Text = "Agregar usuario";
            this.agregarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.agregarUsuarioToolStripMenuItem_Click);
            // 
            // tablaDeUsuariosToolStripMenuItem
            // 
            this.tablaDeUsuariosToolStripMenuItem.Name = "tablaDeUsuariosToolStripMenuItem";
            this.tablaDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tablaDeUsuariosToolStripMenuItem.Text = "Tabla de usuarios";
            this.tablaDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.tablaDeUsuariosToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarVentasToolStripMenuItem,
            this.estadisticasToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // mostrarVentasToolStripMenuItem
            // 
            this.mostrarVentasToolStripMenuItem.Name = "mostrarVentasToolStripMenuItem";
            this.mostrarVentasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarVentasToolStripMenuItem.Text = "Mostrar ventas";
            this.mostrarVentasToolStripMenuItem.Click += new System.EventHandler(this.mostrarVentasToolStripMenuItem_Click);
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            this.estadisticasToolStripMenuItem.Click += new System.EventHandler(this.estadisticasToolStripMenuItem_Click);
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
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
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
            this.splitContainer2.Panel1.Controls.Add(this.BCerrar_sesion);
            this.splitContainer2.Panel1.Controls.Add(this.Ladvertencia_AU);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Size = new System.Drawing.Size(800, 355);
            this.splitContainer2.SplitterDistance = 181;
            this.splitContainer2.TabIndex = 0;
            // 
            // BCerrar_sesion
            // 
            this.BCerrar_sesion.Location = new System.Drawing.Point(31, 275);
            this.BCerrar_sesion.Name = "BCerrar_sesion";
            this.BCerrar_sesion.Size = new System.Drawing.Size(130, 55);
            this.BCerrar_sesion.TabIndex = 2;
            this.BCerrar_sesion.Text = "Cerrar sesión";
            this.BCerrar_sesion.UseVisualStyleBackColor = true;
            this.BCerrar_sesion.Click += new System.EventHandler(this.BCerrar_sesion_Click);
            // 
            // Ladvertencia_AU
            // 
            this.Ladvertencia_AU.AutoSize = true;
            this.Ladvertencia_AU.Location = new System.Drawing.Point(28, 92);
            this.Ladvertencia_AU.Name = "Ladvertencia_AU";
            this.Ladvertencia_AU.Size = new System.Drawing.Size(64, 13);
            this.Ladvertencia_AU.TabIndex = 1;
            this.Ladvertencia_AU.Text = "Advertencia";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar Usuaio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu_administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_administrador";
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
        private System.Windows.Forms.ToolStripMenuItem usuaioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Ladvertencia_AU;
        private System.Windows.Forms.Button BCerrar_sesion;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaDeUsuariosToolStripMenuItem;
    }
}