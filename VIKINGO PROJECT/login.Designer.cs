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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LUsuario = new System.Windows.Forms.Label();
            this.LPAssword = new System.Windows.Forms.Label();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.BSesion = new System.Windows.Forms.Button();
            this.LBienvenido = new System.Windows.Forms.Label();
            this.LAdvertencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 261);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUsuario.Location = new System.Drawing.Point(62, 80);
            this.LUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(147, 18);
            this.LUsuario.TabIndex = 1;
            this.LUsuario.Text = "Ingrese su usuario:";
            // 
            // LPAssword
            // 
            this.LPAssword.AutoSize = true;
            this.LPAssword.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPAssword.Location = new System.Drawing.Point(62, 130);
            this.LPAssword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LPAssword.Name = "LPAssword";
            this.LPAssword.Size = new System.Drawing.Size(171, 18);
            this.LPAssword.TabIndex = 2;
            this.LPAssword.Text = "Ingrese su contraseña:";
            // 
            // TBUsuario
            // 
            this.TBUsuario.Location = new System.Drawing.Point(232, 73);
            this.TBUsuario.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TBUsuario.MaxLength = 30;
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(116, 20);
            this.TBUsuario.TabIndex = 3;
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(232, 127);
            this.TBPassword.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TBPassword.MaxLength = 30;
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '*';
            this.TBPassword.Size = new System.Drawing.Size(116, 20);
            this.TBPassword.TabIndex = 4;
            // 
            // BSesion
            // 
            this.BSesion.BackColor = System.Drawing.Color.Blue;
            this.BSesion.ForeColor = System.Drawing.Color.White;
            this.BSesion.Location = new System.Drawing.Point(129, 200);
            this.BSesion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.BSesion.Name = "BSesion";
            this.BSesion.Size = new System.Drawing.Size(145, 34);
            this.BSesion.TabIndex = 5;
            this.BSesion.Text = "Iniciar Sesión";
            this.BSesion.UseVisualStyleBackColor = false;
            this.BSesion.Click += new System.EventHandler(this.BSesion_Click);
            // 
            // LBienvenido
            // 
            this.LBienvenido.AutoSize = true;
            this.LBienvenido.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBienvenido.Location = new System.Drawing.Point(100, 39);
            this.LBienvenido.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LBienvenido.Name = "LBienvenido";
            this.LBienvenido.Size = new System.Drawing.Size(221, 18);
            this.LBienvenido.TabIndex = 6;
            this.LBienvenido.Text = "BIENVENIDO A VIKINGO";
            // 
            // LAdvertencia
            // 
            this.LAdvertencia.AutoSize = true;
            this.LAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.LAdvertencia.Location = new System.Drawing.Point(65, 165);
            this.LAdvertencia.Name = "LAdvertencia";
            this.LAdvertencia.Size = new System.Drawing.Size(73, 13);
            this.LAdvertencia.TabIndex = 7;
            this.LAdvertencia.Text = "Advertencia";
            this.LAdvertencia.Click += new System.EventHandler(this.LAdvertencia_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(448, 261);
            this.Controls.Add(this.LAdvertencia);
            this.Controls.Add(this.LBienvenido);
            this.Controls.Add(this.BSesion);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBUsuario);
            this.Controls.Add(this.LPAssword);
            this.Controls.Add(this.LUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIKINGO S.R.L";
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
        private System.Windows.Forms.Label LAdvertencia;
    }
}

