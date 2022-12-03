namespace VIKINGO_PROJECT.Forms.Vendedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.LAdvertencia = new System.Windows.Forms.Label();
            this.CBProvincia = new System.Windows.Forms.ComboBox();
            this.CBLocalidad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provincia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Localidad:";
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(154, 193);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(128, 42);
            this.BGuardar.TabIndex = 6;
            this.BGuardar.Text = "Agregar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BSalir
            // 
            this.BSalir.Location = new System.Drawing.Point(6, 193);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(128, 42);
            this.BSalir.TabIndex = 7;
            this.BSalir.Text = "Salir";
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // LAdvertencia
            // 
            this.LAdvertencia.AutoSize = true;
            this.LAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.LAdvertencia.Location = new System.Drawing.Point(35, 146);
            this.LAdvertencia.Name = "LAdvertencia";
            this.LAdvertencia.Size = new System.Drawing.Size(75, 13);
            this.LAdvertencia.TabIndex = 8;
            this.LAdvertencia.Text = "Advertencia";
            // 
            // CBProvincia
            // 
            this.CBProvincia.FormattingEnabled = true;
            this.CBProvincia.Location = new System.Drawing.Point(112, 43);
            this.CBProvincia.Name = "CBProvincia";
            this.CBProvincia.Size = new System.Drawing.Size(140, 21);
            this.CBProvincia.TabIndex = 9;
            this.CBProvincia.TextChanged += new System.EventHandler(this.CBProvincia_TextChanged);
            // 
            // CBLocalidad
            // 
            this.CBLocalidad.FormattingEnabled = true;
            this.CBLocalidad.Location = new System.Drawing.Point(112, 91);
            this.CBLocalidad.Name = "CBLocalidad";
            this.CBLocalidad.Size = new System.Drawing.Size(140, 21);
            this.CBLocalidad.TabIndex = 10;
            this.CBLocalidad.TextChanged += new System.EventHandler(this.CBLocalidad_TextChanged);
            this.CBLocalidad.Click += new System.EventHandler(this.CBLocalidad_Click);
            // 
            // Agregar_provincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CBLocalidad);
            this.Controls.Add(this.CBProvincia);
            this.Controls.Add(this.LAdvertencia);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Agregar_provincia";
            this.Text = "Agregar zona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Label LAdvertencia;
        private System.Windows.Forms.ComboBox CBProvincia;
        private System.Windows.Forms.ComboBox CBLocalidad;
    }
}