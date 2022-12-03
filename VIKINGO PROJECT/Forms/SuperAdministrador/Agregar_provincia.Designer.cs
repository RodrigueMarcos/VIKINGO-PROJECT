namespace VIKINGO_PROJECT.Forms.Administrador
{
    partial class Agregar_provincia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_provincia));
            this.LProvincia = new System.Windows.Forms.Label();
            this.LLocalidad = new System.Windows.Forms.Label();
            this.BSalir = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.LAdvertencia = new System.Windows.Forms.Label();
            this.CBProvincia = new System.Windows.Forms.ComboBox();
            this.CBLocalidad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LProvincia
            // 
            this.LProvincia.AutoSize = true;
            this.LProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProvincia.Location = new System.Drawing.Point(34, 63);
            this.LProvincia.Name = "LProvincia";
            this.LProvincia.Size = new System.Drawing.Size(64, 13);
            this.LProvincia.TabIndex = 0;
            this.LProvincia.Text = "Provincia:";
            // 
            // LLocalidad
            // 
            this.LLocalidad.AutoSize = true;
            this.LLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLocalidad.Location = new System.Drawing.Point(34, 120);
            this.LLocalidad.Name = "LLocalidad";
            this.LLocalidad.Size = new System.Drawing.Size(66, 13);
            this.LLocalidad.TabIndex = 1;
            this.LLocalidad.Text = "Localidad:";
            // 
            // BSalir
            // 
            this.BSalir.Image = ((System.Drawing.Image)(resources.GetObject("BSalir.Image")));
            this.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSalir.Location = new System.Drawing.Point(53, 242);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(108, 39);
            this.BSalir.TabIndex = 2;
            this.BSalir.Text = "Salir";
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BGuardar.Image")));
            this.BGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGuardar.Location = new System.Drawing.Point(185, 241);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(108, 39);
            this.BGuardar.TabIndex = 3;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // LAdvertencia
            // 
            this.LAdvertencia.AutoSize = true;
            this.LAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.LAdvertencia.Location = new System.Drawing.Point(37, 176);
            this.LAdvertencia.Name = "LAdvertencia";
            this.LAdvertencia.Size = new System.Drawing.Size(75, 13);
            this.LAdvertencia.TabIndex = 6;
            this.LAdvertencia.Text = "Advertencia";
            // 
            // CBProvincia
            // 
            this.CBProvincia.FormattingEnabled = true;
            this.CBProvincia.Location = new System.Drawing.Point(125, 55);
            this.CBProvincia.Name = "CBProvincia";
            this.CBProvincia.Size = new System.Drawing.Size(151, 21);
            this.CBProvincia.TabIndex = 7;
            this.CBProvincia.TextChanged += new System.EventHandler(this.CBProvincia_TextChanged_1);
            this.CBProvincia.Click += new System.EventHandler(this.CBProvincia_Click);
            // 
            // CBLocalidad
            // 
            this.CBLocalidad.FormattingEnabled = true;
            this.CBLocalidad.Location = new System.Drawing.Point(125, 120);
            this.CBLocalidad.Name = "CBLocalidad";
            this.CBLocalidad.Size = new System.Drawing.Size(151, 21);
            this.CBLocalidad.TabIndex = 8;
            this.CBLocalidad.TextChanged += new System.EventHandler(this.CBLocalidad_TextChanged);
            this.CBLocalidad.Click += new System.EventHandler(this.CBLocalidad_Click);
            // 
            // Agregar_provincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(357, 316);
            this.ControlBox = false;
            this.Controls.Add(this.CBLocalidad);
            this.Controls.Add(this.CBProvincia);
            this.Controls.Add(this.LAdvertencia);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.LLocalidad);
            this.Controls.Add(this.LProvincia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agregar_provincia";
            this.Text = "Agregar zona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LProvincia;
        private System.Windows.Forms.Label LLocalidad;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Label LAdvertencia;
        private System.Windows.Forms.ComboBox CBProvincia;
        private System.Windows.Forms.ComboBox CBLocalidad;
    }
}