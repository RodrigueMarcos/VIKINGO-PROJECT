namespace VIKINGO_PROJECT.Forms.Vendedor
{
    partial class Agregar_ciudad
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
            this.label3 = new System.Windows.Forms.Label();
            this.TBProvincia = new System.Windows.Forms.TextBox();
            this.TBLocalidad = new System.Windows.Forms.TextBox();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provincia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Localidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
            // 
            // TBProvincia
            // 
            this.TBProvincia.Location = new System.Drawing.Point(112, 40);
            this.TBProvincia.Name = "TBProvincia";
            this.TBProvincia.Size = new System.Drawing.Size(140, 20);
            this.TBProvincia.TabIndex = 3;
            this.TBProvincia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_letra_KeyPress);
            // 
            // TBLocalidad
            // 
            this.TBLocalidad.Location = new System.Drawing.Point(112, 87);
            this.TBLocalidad.Name = "TBLocalidad";
            this.TBLocalidad.Size = new System.Drawing.Size(140, 20);
            this.TBLocalidad.TabIndex = 4;
            this.TBLocalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solo_letra_KeyPress);
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Location = new System.Drawing.Point(112, 132);
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(140, 20);
            this.TBDescripcion.TabIndex = 5;
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
            // Agregar_ciudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.TBDescripcion);
            this.Controls.Add(this.TBLocalidad);
            this.Controls.Add(this.TBProvincia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Agregar_ciudad";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBProvincia;
        private System.Windows.Forms.TextBox TBLocalidad;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BSalir;
    }
}