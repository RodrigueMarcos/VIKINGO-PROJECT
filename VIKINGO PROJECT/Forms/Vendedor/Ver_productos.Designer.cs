namespace VIKINGO_PROJECT.Forms.Vendedor
{
    partial class Ver_productos
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
            this.PProductoSelec = new System.Windows.Forms.Panel();
            this.LAdvertencia = new System.Windows.Forms.Label();
            this.LNombrePro = new System.Windows.Forms.Label();
            this.BAgregar = new System.Windows.Forms.Button();
            this.LCodigoPro = new System.Windows.Forms.Label();
            this.LNombreSelec = new System.Windows.Forms.Label();
            this.LCodigoSelec = new System.Windows.Forms.Label();
            this.LProductoSec = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBCodigo = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.LCodigo = new System.Windows.Forms.Label();
            this.DGVProducto = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.PProductoSelec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducto)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.PProductoSelec);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DGVProducto);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 158;
            this.splitContainer1.TabIndex = 0;
            // 
            // PProductoSelec
            // 
            this.PProductoSelec.BackColor = System.Drawing.Color.Gray;
            this.PProductoSelec.Controls.Add(this.LAdvertencia);
            this.PProductoSelec.Controls.Add(this.LNombrePro);
            this.PProductoSelec.Controls.Add(this.BAgregar);
            this.PProductoSelec.Controls.Add(this.LCodigoPro);
            this.PProductoSelec.Controls.Add(this.LNombreSelec);
            this.PProductoSelec.Controls.Add(this.LCodigoSelec);
            this.PProductoSelec.Controls.Add(this.LProductoSec);
            this.PProductoSelec.Location = new System.Drawing.Point(109, 92);
            this.PProductoSelec.Name = "PProductoSelec";
            this.PProductoSelec.Size = new System.Drawing.Size(528, 63);
            this.PProductoSelec.TabIndex = 7;
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
            this.LNombrePro.ForeColor = System.Drawing.Color.Green;
            this.LNombrePro.Location = new System.Drawing.Point(263, 33);
            this.LNombrePro.Name = "LNombrePro";
            this.LNombrePro.Size = new System.Drawing.Size(118, 13);
            this.LNombrePro.TabIndex = 4;
            this.LNombrePro.Text = "nombreSelecionado";
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
            this.LCodigoPro.ForeColor = System.Drawing.Color.Green;
            this.LCodigoPro.Location = new System.Drawing.Point(69, 33);
            this.LCodigoPro.Name = "LCodigoPro";
            this.LCodigoPro.Size = new System.Drawing.Size(115, 13);
            this.LCodigoPro.TabIndex = 3;
            this.LCodigoPro.Text = "codigoSelecionado";
            // 
            // LNombreSelec
            // 
            this.LNombreSelec.AutoSize = true;
            this.LNombreSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombreSelec.Location = new System.Drawing.Point(203, 33);
            this.LNombreSelec.Name = "LNombreSelec";
            this.LNombreSelec.Size = new System.Drawing.Size(54, 13);
            this.LNombreSelec.TabIndex = 2;
            this.LNombreSelec.Text = "Nombre:";
            // 
            // LCodigoSelec
            // 
            this.LCodigoSelec.AutoSize = true;
            this.LCodigoSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCodigoSelec.Location = new System.Drawing.Point(13, 33);
            this.LCodigoSelec.Name = "LCodigoSelec";
            this.LCodigoSelec.Size = new System.Drawing.Size(50, 13);
            this.LCodigoSelec.TabIndex = 1;
            this.LCodigoSelec.Text = "Codigo:";
            // 
            // LProductoSec
            // 
            this.LProductoSec.AutoSize = true;
            this.LProductoSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProductoSec.Location = new System.Drawing.Point(32, 4);
            this.LProductoSec.Name = "LProductoSec";
            this.LProductoSec.Size = new System.Drawing.Size(137, 13);
            this.LProductoSec.TabIndex = 0;
            this.LProductoSec.Text = "Producto seleccionado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar por:";
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(299, 28);
            this.TBNombre.MaxLength = 30;
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(124, 20);
            this.TBNombre.TabIndex = 4;
            this.TBNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBNombre_KeyUp);
            // 
            // TBCodigo
            // 
            this.TBCodigo.Location = new System.Drawing.Point(96, 28);
            this.TBCodigo.MaxLength = 8;
            this.TBCodigo.Name = "TBCodigo";
            this.TBCodigo.Size = new System.Drawing.Size(124, 20);
            this.TBCodigo.TabIndex = 3;
            this.TBCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCodigo_KeyPress);
            this.TBCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCodigo_KeyUp);
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.Location = new System.Drawing.Point(239, 31);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(54, 13);
            this.LNombre.TabIndex = 1;
            this.LNombre.Text = "Nombre:";
            // 
            // LCodigo
            // 
            this.LCodigo.AutoSize = true;
            this.LCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCodigo.Location = new System.Drawing.Point(40, 31);
            this.LCodigo.Name = "LCodigo";
            this.LCodigo.Size = new System.Drawing.Size(50, 13);
            this.LCodigo.TabIndex = 0;
            this.LCodigo.Text = "Código:";
            // 
            // DGVProducto
            // 
            this.DGVProducto.AllowUserToAddRows = false;
            this.DGVProducto.AllowUserToDeleteRows = false;
            this.DGVProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVProducto.Location = new System.Drawing.Point(0, 0);
            this.DGVProducto.Name = "DGVProducto";
            this.DGVProducto.ReadOnly = true;
            this.DGVProducto.Size = new System.Drawing.Size(800, 288);
            this.DGVProducto.TabIndex = 0;
            this.DGVProducto.Click += new System.EventHandler(this.DGVProducto_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.LCodigo);
            this.panel2.Controls.Add(this.TBNombre);
            this.panel2.Controls.Add(this.LNombre);
            this.panel2.Controls.Add(this.TBCodigo);
            this.panel2.Location = new System.Drawing.Point(109, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 62);
            this.panel2.TabIndex = 8;
            // 
            // Ver_productos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ver_productos";
            this.Text = "Productos";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.PProductoSelec.ResumeLayout(false);
            this.PProductoSelec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBCodigo;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LCodigo;
        private System.Windows.Forms.DataGridView DGVProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BAgregar;
        private System.Windows.Forms.Panel PProductoSelec;
        private System.Windows.Forms.Label LNombrePro;
        private System.Windows.Forms.Label LCodigoPro;
        private System.Windows.Forms.Label LNombreSelec;
        private System.Windows.Forms.Label LCodigoSelec;
        private System.Windows.Forms.Label LProductoSec;
        private System.Windows.Forms.Label LAdvertencia;
        private System.Windows.Forms.Panel panel2;
    }
}