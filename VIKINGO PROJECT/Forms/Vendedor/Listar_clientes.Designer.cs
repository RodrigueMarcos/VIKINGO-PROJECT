namespace VIKINGO_PROJECT.Forms.Vendedor
{
    partial class Listar_clientes
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.TBApellido = new System.Windows.Forms.TextBox();
            this.LApellidoBuscar = new System.Windows.Forms.Label();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LApeyNombre = new System.Windows.Forms.Label();
            this.LApeyNom = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LAdvertencia = new System.Windows.Forms.Label();
            this.LNombrePro = new System.Windows.Forms.Label();
            this.BAgregar = new System.Windows.Forms.Button();
            this.LCodigoPro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_clientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DGV_clientes);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 140;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.TBApellido);
            this.panel2.Controls.Add(this.LApellidoBuscar);
            this.panel2.Controls.Add(this.TBDni);
            this.panel2.Location = new System.Drawing.Point(128, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 64);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Buscar:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(61, 35);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(56, 13);
            this.label.TabIndex = 8;
            this.label.Text = "Por DNI:";
            // 
            // TBApellido
            // 
            this.TBApellido.Location = new System.Drawing.Point(356, 32);
            this.TBApellido.MaxLength = 30;
            this.TBApellido.Name = "TBApellido";
            this.TBApellido.Size = new System.Drawing.Size(124, 20);
            this.TBApellido.TabIndex = 11;
            this.TBApellido.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBApellido_KeyUp);
            // 
            // LApellidoBuscar
            // 
            this.LApellidoBuscar.AutoSize = true;
            this.LApellidoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellidoBuscar.Location = new System.Drawing.Point(271, 35);
            this.LApellidoBuscar.Name = "LApellidoBuscar";
            this.LApellidoBuscar.Size = new System.Drawing.Size(79, 13);
            this.LApellidoBuscar.TabIndex = 9;
            this.LApellidoBuscar.Text = "Por Apellido:";
            // 
            // TBDni
            // 
            this.TBDni.Location = new System.Drawing.Point(123, 32);
            this.TBDni.MaxLength = 8;
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(124, 20);
            this.TBDni.TabIndex = 10;
            this.TBDni.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDni_KeyUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.LApeyNombre);
            this.panel1.Controls.Add(this.LApeyNom);
            this.panel1.Controls.Add(this.LDni);
            this.panel1.Controls.Add(this.LAdvertencia);
            this.panel1.Controls.Add(this.LNombrePro);
            this.panel1.Controls.Add(this.BAgregar);
            this.panel1.Controls.Add(this.LCodigoPro);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(128, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 63);
            this.panel1.TabIndex = 13;
            // 
            // LApeyNombre
            // 
            this.LApeyNombre.AutoSize = true;
            this.LApeyNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApeyNombre.ForeColor = System.Drawing.Color.Green;
            this.LApeyNombre.Location = new System.Drawing.Point(284, 28);
            this.LApeyNombre.Name = "LApeyNombre";
            this.LApeyNombre.Size = new System.Drawing.Size(107, 13);
            this.LApeyNombre.TabIndex = 10;
            this.LApeyNombre.Text = "Apellido y nombre";
            // 
            // LApeyNom
            // 
            this.LApeyNom.AutoSize = true;
            this.LApeyNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApeyNom.Location = new System.Drawing.Point(305, 33);
            this.LApeyNom.Name = "LApeyNom";
            this.LApeyNom.Size = new System.Drawing.Size(0, 13);
            this.LApeyNom.TabIndex = 9;
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.ForeColor = System.Drawing.Color.Green;
            this.LDni.Location = new System.Drawing.Point(70, 28);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(24, 13);
            this.LDni.TabIndex = 8;
            this.LDni.Text = "dni";
            // 
            // LAdvertencia
            // 
            this.LAdvertencia.AutoSize = true;
            this.LAdvertencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAdvertencia.ForeColor = System.Drawing.Color.Red;
            this.LAdvertencia.Location = new System.Drawing.Point(35, 47);
            this.LAdvertencia.Name = "LAdvertencia";
            this.LAdvertencia.Size = new System.Drawing.Size(82, 13);
            this.LAdvertencia.TabIndex = 7;
            this.LAdvertencia.Text = "LAdvertencia";
            // 
            // LNombrePro
            // 
            this.LNombrePro.AutoSize = true;
            this.LNombrePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombrePro.Location = new System.Drawing.Point(337, 33);
            this.LNombrePro.Name = "LNombrePro";
            this.LNombrePro.Size = new System.Drawing.Size(0, 13);
            this.LNombrePro.TabIndex = 4;
            // 
            // BAgregar
            // 
            this.BAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAgregar.Location = new System.Drawing.Point(453, 28);
            this.BAgregar.Name = "BAgregar";
            this.BAgregar.Size = new System.Drawing.Size(75, 23);
            this.BAgregar.TabIndex = 6;
            this.BAgregar.Text = "Agregar";
            this.BAgregar.UseVisualStyleBackColor = true;
            this.BAgregar.Click += new System.EventHandler(this.BAgregar_Click);
            // 
            // LCodigoPro
            // 
            this.LCodigoPro.AutoSize = true;
            this.LCodigoPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCodigoPro.Location = new System.Drawing.Point(83, 33);
            this.LCodigoPro.Name = "LCodigoPro";
            this.LCodigoPro.Size = new System.Drawing.Size(0, 13);
            this.LCodigoPro.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellido y nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cliente seleccionado";
            // 
            // DGV_clientes
            // 
            this.DGV_clientes.AllowUserToAddRows = false;
            this.DGV_clientes.AllowUserToDeleteRows = false;
            this.DGV_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_clientes.Location = new System.Drawing.Point(0, 0);
            this.DGV_clientes.Name = "DGV_clientes";
            this.DGV_clientes.ReadOnly = true;
            this.DGV_clientes.Size = new System.Drawing.Size(800, 306);
            this.DGV_clientes.TabIndex = 0;
            this.DGV_clientes.Click += new System.EventHandler(this.DGV_clientes_Click);
            // 
            // Listar_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Listar_clientes";
            this.Text = "Listar_clientes";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LApeyNom;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LAdvertencia;
        private System.Windows.Forms.Label LNombrePro;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.Label LCodigoPro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBApellido;
        private System.Windows.Forms.TextBox TBDni;
        private System.Windows.Forms.Label LApellidoBuscar;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView DGV_clientes;
        private System.Windows.Forms.Label LApeyNombre;
        private System.Windows.Forms.Panel panel2;
    }
}