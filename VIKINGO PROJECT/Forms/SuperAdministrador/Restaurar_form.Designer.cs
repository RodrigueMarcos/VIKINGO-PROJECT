namespace VIKINGO_PROJECT.Forms.SuperAdministrador
{
    partial class Restaurar_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Restaurar_form));
            this.BRestaurar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BRestaurar
            // 
            this.BRestaurar.BackColor = System.Drawing.Color.Firebrick;
            this.BRestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BRestaurar.Image")));
            this.BRestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BRestaurar.Location = new System.Drawing.Point(277, 202);
            this.BRestaurar.Name = "BRestaurar";
            this.BRestaurar.Size = new System.Drawing.Size(209, 57);
            this.BRestaurar.TabIndex = 1;
            this.BRestaurar.Text = "Restaurar";
            this.BRestaurar.UseVisualStyleBackColor = false;
            this.BRestaurar.Click += new System.EventHandler(this.BRestaurar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Restaurar datos";
            // 
            // Restaurar_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BRestaurar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Restaurar_form";
            this.Text = "Restaurar form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BRestaurar;
        private System.Windows.Forms.Label label1;
    }
}