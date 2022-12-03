namespace VIKINGO_PROJECT.Forms.Administrador
{
    partial class Menu_SuperAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_SuperAdmin));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuaioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darBajaDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.BRestaurar = new System.Windows.Forms.Button();
            this.BBackup = new System.Windows.Forms.Button();
            this.BCerrar_sesion = new System.Windows.Forms.Button();
            this.Ladvertencia = new System.Windows.Forms.Label();
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
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuaioToolStripMenuItem,
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
            this.tablaDeUsuariosToolStripMenuItem,
            this.darBajaDeUsuarioToolStripMenuItem});
            this.usuaioToolStripMenuItem.Name = "usuaioToolStripMenuItem";
            this.usuaioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuaioToolStripMenuItem.Text = "Usuario";
            this.usuaioToolStripMenuItem.Click += new System.EventHandler(this.usuaioToolStripMenuItem_Click);
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            this.agregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.agregarUsuarioToolStripMenuItem.Text = "Agregar usuario";
            this.agregarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.agregarUsuarioToolStripMenuItem_Click);
            // 
            // tablaDeUsuariosToolStripMenuItem
            // 
            this.tablaDeUsuariosToolStripMenuItem.Name = "tablaDeUsuariosToolStripMenuItem";
            this.tablaDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.tablaDeUsuariosToolStripMenuItem.Text = "Tabla de usuarios";
            this.tablaDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.tablaDeUsuariosToolStripMenuItem_Click);
            // 
            // darBajaDeUsuarioToolStripMenuItem
            // 
            this.darBajaDeUsuarioToolStripMenuItem.Name = "darBajaDeUsuarioToolStripMenuItem";
            this.darBajaDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.darBajaDeUsuarioToolStripMenuItem.Text = "Modificar usuario";
            this.darBajaDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.darBajaDeUsuarioToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
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
            this.splitContainer2.Panel1.Controls.Add(this.BRestaurar);
            this.splitContainer2.Panel1.Controls.Add(this.BBackup);
            this.splitContainer2.Panel1.Controls.Add(this.BCerrar_sesion);
            this.splitContainer2.Panel1.Controls.Add(this.Ladvertencia);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Size = new System.Drawing.Size(800, 355);
            this.splitContainer2.SplitterDistance = 181;
            this.splitContainer2.TabIndex = 0;
            // 
            // BRestaurar
            // 
            this.BRestaurar.BackColor = System.Drawing.Color.Salmon;
            this.BRestaurar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BRestaurar.Image")));
            this.BRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BRestaurar.Location = new System.Drawing.Point(32, 178);
            this.BRestaurar.Name = "BRestaurar";
            this.BRestaurar.Size = new System.Drawing.Size(143, 59);
            this.BRestaurar.TabIndex = 4;
            this.BRestaurar.Text = "Restaurar";
            this.BRestaurar.UseVisualStyleBackColor = false;
            this.BRestaurar.Click += new System.EventHandler(this.BRestaurar_Click);
            // 
            // BBackup
            // 
            this.BBackup.BackColor = System.Drawing.Color.Navy;
            this.BBackup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BBackup.Image = ((System.Drawing.Image)(resources.GetObject("BBackup.Image")));
            this.BBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BBackup.Location = new System.Drawing.Point(32, 98);
            this.BBackup.Name = "BBackup";
            this.BBackup.Size = new System.Drawing.Size(143, 59);
            this.BBackup.TabIndex = 3;
            this.BBackup.Text = "Backup";
            this.BBackup.UseVisualStyleBackColor = false;
            this.BBackup.Click += new System.EventHandler(this.BBackup_Click);
            // 
            // BCerrar_sesion
            // 
            this.BCerrar_sesion.BackColor = System.Drawing.Color.Red;
            this.BCerrar_sesion.Image = ((System.Drawing.Image)(resources.GetObject("BCerrar_sesion.Image")));
            this.BCerrar_sesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCerrar_sesion.Location = new System.Drawing.Point(32, 294);
            this.BCerrar_sesion.Name = "BCerrar_sesion";
            this.BCerrar_sesion.Size = new System.Drawing.Size(143, 59);
            this.BCerrar_sesion.TabIndex = 2;
            this.BCerrar_sesion.Text = "Cerrar sesión";
            this.BCerrar_sesion.UseVisualStyleBackColor = false;
            this.BCerrar_sesion.Click += new System.EventHandler(this.BCerrar_sesion_Click);
            // 
            // Ladvertencia
            // 
            this.Ladvertencia.AutoSize = true;
            this.Ladvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ladvertencia.ForeColor = System.Drawing.Color.Red;
            this.Ladvertencia.Location = new System.Drawing.Point(15, 249);
            this.Ladvertencia.Name = "Ladvertencia";
            this.Ladvertencia.Size = new System.Drawing.Size(75, 13);
            this.Ladvertencia.TabIndex = 1;
            this.Ladvertencia.Text = "Advertencia";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(31, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar Usuario";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu_SuperAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Menu_SuperAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIKINGO S.R.L";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Ladvertencia;
        private System.Windows.Forms.Button BCerrar_sesion;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.Button BBackup;
        private System.Windows.Forms.ToolStripMenuItem darBajaDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.Button BRestaurar;
    }
}