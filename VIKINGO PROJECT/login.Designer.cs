namespace VIKINGO_PROJECT
{
    partial class login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LUsuario = new System.Windows.Forms.Label();
            this.LPAssword = new System.Windows.Forms.Label();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.BSesion = new System.Windows.Forms.Button();
            this.LBienvenido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 261);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Location = new System.Drawing.Point(53, 80);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(96, 13);
            this.LUsuario.TabIndex = 1;
            this.LUsuario.Text = "Ingrese su usuario:";
            // 
            // LPAssword
            // 
            this.LPAssword.AutoSize = true;
            this.LPAssword.Location = new System.Drawing.Point(53, 130);
            this.LPAssword.Name = "LPAssword";
            this.LPAssword.Size = new System.Drawing.Size(115, 13);
            this.LPAssword.TabIndex = 2;
            this.LPAssword.Text = "Ingrese su contraseña:";
            // 
            // TBUsuario
            // 
            this.TBUsuario.Location = new System.Drawing.Point(199, 73);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(100, 20);
            this.TBUsuario.TabIndex = 3;
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(199, 127);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(100, 20);
            this.TBPassword.TabIndex = 4;
            // 
            // BSesion
            // 
            this.BSesion.Location = new System.Drawing.Point(116, 177);
            this.BSesion.Name = "BSesion";
            this.BSesion.Size = new System.Drawing.Size(124, 34);
            this.BSesion.TabIndex = 5;
            this.BSesion.Text = "Iniciar Sesión";
            this.BSesion.UseVisualStyleBackColor = true;
            this.BSesion.Click += new System.EventHandler(this.BSesion_Click);
            // 
            // LBienvenido
            // 
            this.LBienvenido.AutoSize = true;
            this.LBienvenido.Location = new System.Drawing.Point(110, 39);
            this.LBienvenido.Name = "LBienvenido";
            this.LBienvenido.Size = new System.Drawing.Size(130, 13);
            this.LBienvenido.TabIndex = 6;
            this.LBienvenido.Text = "BIENVENIDO A VIKINGO";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.LBienvenido);
            this.Controls.Add(this.BSesion);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBUsuario);
            this.Controls.Add(this.LPAssword);
            this.Controls.Add(this.LUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.Label LPAssword;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Button BSesion;
        private System.Windows.Forms.Label LBienvenido;
    }
}

