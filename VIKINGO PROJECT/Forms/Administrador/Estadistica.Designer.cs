namespace VIKINGO_PROJECT.Forms.Administrador
{
    partial class Estadistica
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BGenerarRep = new System.Windows.Forms.Button();
            this.LBuscar = new System.Windows.Forms.Button();
            this.DTHasta = new System.Windows.Forms.DateTimePicker();
            this.DTDesde = new System.Windows.Forms.DateTimePicker();
            this.RBFecha = new System.Windows.Forms.RadioButton();
            this.RBMenosVendidos = new System.Windows.Forms.RadioButton();
            this.RBMasVendidos = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LCantidadCli = new System.Windows.Forms.Label();
            this.LCliente = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LCantidadVentas = new System.Windows.Forms.Label();
            this.LCantidadVendida = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LCantidadMar = new System.Windows.Forms.Label();
            this.LMarcas = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LCantidadCat = new System.Windows.Forms.Label();
            this.LCantegoria = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LCantidadPro = new System.Windows.Forms.Label();
            this.LTituloProc = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LTotalTitulo = new System.Windows.Forms.Label();
            this.LTotal = new System.Windows.Forms.Label();
            this.LTituloGrafCat = new System.Windows.Forms.Label();
            this.LTituloGrafProd = new System.Windows.Forms.Label();
            this.chartProdPreferido = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartProdCategoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdPreferido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdCategoria)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.BGenerarRep);
            this.splitContainer1.Panel1.Controls.Add(this.LBuscar);
            this.splitContainer1.Panel1.Controls.Add(this.DTHasta);
            this.splitContainer1.Panel1.Controls.Add(this.DTDesde);
            this.splitContainer1.Panel1.Controls.Add(this.RBFecha);
            this.splitContainer1.Panel1.Controls.Add(this.RBMenosVendidos);
            this.splitContainer1.Panel1.Controls.Add(this.RBMasVendidos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel6);
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.LTituloGrafCat);
            this.splitContainer1.Panel2.Controls.Add(this.LTituloGrafProd);
            this.splitContainer1.Panel2.Controls.Add(this.chartProdPreferido);
            this.splitContainer1.Panel2.Controls.Add(this.chartProdCategoria);
            this.splitContainer1.Size = new System.Drawing.Size(1084, 561);
            this.splitContainer1.SplitterDistance = 117;
            this.splitContainer1.TabIndex = 0;
            // 
            // BGenerarRep
            // 
            this.BGenerarRep.Location = new System.Drawing.Point(486, 67);
            this.BGenerarRep.Name = "BGenerarRep";
            this.BGenerarRep.Size = new System.Drawing.Size(129, 23);
            this.BGenerarRep.TabIndex = 11;
            this.BGenerarRep.Text = "Generar Reporte";
            this.BGenerarRep.UseVisualStyleBackColor = true;
            this.BGenerarRep.Click += new System.EventHandler(this.BGenerarRep_Click);
            // 
            // LBuscar
            // 
            this.LBuscar.Location = new System.Drawing.Point(964, 44);
            this.LBuscar.Name = "LBuscar";
            this.LBuscar.Size = new System.Drawing.Size(75, 23);
            this.LBuscar.TabIndex = 10;
            this.LBuscar.Text = "Buscar";
            this.LBuscar.UseVisualStyleBackColor = true;
            this.LBuscar.Click += new System.EventHandler(this.LBuscar_Click);
            // 
            // DTHasta
            // 
            this.DTHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTHasta.Location = new System.Drawing.Point(843, 57);
            this.DTHasta.Name = "DTHasta";
            this.DTHasta.Size = new System.Drawing.Size(97, 20);
            this.DTHasta.TabIndex = 9;
            // 
            // DTDesde
            // 
            this.DTDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTDesde.Location = new System.Drawing.Point(843, 31);
            this.DTDesde.Name = "DTDesde";
            this.DTDesde.Size = new System.Drawing.Size(97, 20);
            this.DTDesde.TabIndex = 8;
            // 
            // RBFecha
            // 
            this.RBFecha.AutoSize = true;
            this.RBFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBFecha.Location = new System.Drawing.Point(722, 34);
            this.RBFecha.Name = "RBFecha";
            this.RBFecha.Size = new System.Drawing.Size(115, 17);
            this.RBFecha.TabIndex = 7;
            this.RBFecha.Text = "Filtrar por fecha";
            this.RBFecha.UseVisualStyleBackColor = true;
            this.RBFecha.CheckedChanged += new System.EventHandler(this.RBFecha_CheckedChanged);
            // 
            // RBMenosVendidos
            // 
            this.RBMenosVendidos.AutoSize = true;
            this.RBMenosVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBMenosVendidos.Location = new System.Drawing.Point(415, 34);
            this.RBMenosVendidos.Name = "RBMenosVendidos";
            this.RBMenosVendidos.Size = new System.Drawing.Size(200, 17);
            this.RBMenosVendidos.TabIndex = 6;
            this.RBMenosVendidos.Text = "Los productos menos vendidos";
            this.RBMenosVendidos.UseVisualStyleBackColor = true;
            this.RBMenosVendidos.CheckedChanged += new System.EventHandler(this.RBCategoria_CheckedChanged);
            // 
            // RBMasVendidos
            // 
            this.RBMasVendidos.AutoSize = true;
            this.RBMasVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBMasVendidos.Location = new System.Drawing.Point(106, 34);
            this.RBMasVendidos.Name = "RBMasVendidos";
            this.RBMasVendidos.Size = new System.Drawing.Size(186, 17);
            this.RBMasVendidos.TabIndex = 5;
            this.RBMasVendidos.Text = "Los productos mas vendidos";
            this.RBMasVendidos.UseVisualStyleBackColor = true;
            this.RBMasVendidos.CheckedChanged += new System.EventHandler(this.RBTodo_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.LCantidadCli);
            this.panel6.Controls.Add(this.LCliente);
            this.panel6.Location = new System.Drawing.Point(893, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(169, 64);
            this.panel6.TabIndex = 7;
            // 
            // LCantidadCli
            // 
            this.LCantidadCli.AutoSize = true;
            this.LCantidadCli.Location = new System.Drawing.Point(23, 35);
            this.LCantidadCli.Name = "LCantidadCli";
            this.LCantidadCli.Size = new System.Drawing.Size(49, 13);
            this.LCantidadCli.TabIndex = 14;
            this.LCantidadCli.Text = "Cantidad";
            // 
            // LCliente
            // 
            this.LCliente.AutoSize = true;
            this.LCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCliente.Location = new System.Drawing.Point(23, 9);
            this.LCliente.Name = "LCliente";
            this.LCliente.Size = new System.Drawing.Size(123, 13);
            this.LCliente.TabIndex = 14;
            this.LCliente.Text = "Cantidad de clientes";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.LCantidadVentas);
            this.panel5.Controls.Add(this.LCantidadVendida);
            this.panel5.Location = new System.Drawing.Point(718, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(169, 64);
            this.panel5.TabIndex = 7;
            // 
            // LCantidadVentas
            // 
            this.LCantidadVentas.AutoSize = true;
            this.LCantidadVentas.Location = new System.Drawing.Point(20, 35);
            this.LCantidadVentas.Name = "LCantidadVentas";
            this.LCantidadVentas.Size = new System.Drawing.Size(49, 13);
            this.LCantidadVentas.TabIndex = 13;
            this.LCantidadVentas.Text = "Cantidad";
            // 
            // LCantidadVendida
            // 
            this.LCantidadVendida.AutoSize = true;
            this.LCantidadVendida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantidadVendida.Location = new System.Drawing.Point(20, 9);
            this.LCantidadVendida.Name = "LCantidadVendida";
            this.LCantidadVendida.Size = new System.Drawing.Size(117, 13);
            this.LCantidadVendida.TabIndex = 13;
            this.LCantidadVendida.Text = "Cantidad de ventas";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.LCantidadMar);
            this.panel4.Controls.Add(this.LMarcas);
            this.panel4.Location = new System.Drawing.Point(543, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(169, 64);
            this.panel4.TabIndex = 7;
            // 
            // LCantidadMar
            // 
            this.LCantidadMar.AutoSize = true;
            this.LCantidadMar.Location = new System.Drawing.Point(19, 35);
            this.LCantidadMar.Name = "LCantidadMar";
            this.LCantidadMar.Size = new System.Drawing.Size(49, 13);
            this.LCantidadMar.TabIndex = 12;
            this.LCantidadMar.Text = "Cantidad";
            // 
            // LMarcas
            // 
            this.LMarcas.AutoSize = true;
            this.LMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMarcas.Location = new System.Drawing.Point(19, 9);
            this.LMarcas.Name = "LMarcas";
            this.LMarcas.Size = new System.Drawing.Size(119, 13);
            this.LMarcas.TabIndex = 12;
            this.LMarcas.Text = "Cantidad de marcas";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LCantidadCat);
            this.panel3.Controls.Add(this.LCantegoria);
            this.panel3.Location = new System.Drawing.Point(368, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 64);
            this.panel3.TabIndex = 8;
            // 
            // LCantidadCat
            // 
            this.LCantidadCat.AutoSize = true;
            this.LCantidadCat.Location = new System.Drawing.Point(18, 35);
            this.LCantidadCat.Name = "LCantidadCat";
            this.LCantidadCat.Size = new System.Drawing.Size(49, 13);
            this.LCantidadCat.TabIndex = 11;
            this.LCantidadCat.Text = "Cantidad";
            // 
            // LCantegoria
            // 
            this.LCantegoria.AutoSize = true;
            this.LCantegoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantegoria.Location = new System.Drawing.Point(18, 9);
            this.LCantegoria.Name = "LCantegoria";
            this.LCantegoria.Size = new System.Drawing.Size(132, 13);
            this.LCantegoria.TabIndex = 11;
            this.LCantegoria.Text = "Cantidad de categoria";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LCantidadPro);
            this.panel2.Controls.Add(this.LTituloProc);
            this.panel2.Location = new System.Drawing.Point(193, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 64);
            this.panel2.TabIndex = 7;
            // 
            // LCantidadPro
            // 
            this.LCantidadPro.AutoSize = true;
            this.LCantidadPro.Location = new System.Drawing.Point(24, 35);
            this.LCantidadPro.Name = "LCantidadPro";
            this.LCantidadPro.Size = new System.Drawing.Size(49, 13);
            this.LCantidadPro.TabIndex = 9;
            this.LCantidadPro.Text = "Cantidad";
            // 
            // LTituloProc
            // 
            this.LTituloProc.AutoSize = true;
            this.LTituloProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloProc.Location = new System.Drawing.Point(15, 9);
            this.LTituloProc.Name = "LTituloProc";
            this.LTituloProc.Size = new System.Drawing.Size(135, 13);
            this.LTituloProc.TabIndex = 10;
            this.LTituloProc.Text = "Cantidad de productos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LTotalTitulo);
            this.panel1.Controls.Add(this.LTotal);
            this.panel1.Location = new System.Drawing.Point(18, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 64);
            this.panel1.TabIndex = 6;
            // 
            // LTotalTitulo
            // 
            this.LTotalTitulo.AutoSize = true;
            this.LTotalTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotalTitulo.Location = new System.Drawing.Point(44, 9);
            this.LTotalTitulo.Name = "LTotalTitulo";
            this.LTotalTitulo.Size = new System.Drawing.Size(85, 13);
            this.LTotalTitulo.TabIndex = 9;
            this.LTotalTitulo.Text = "Total vendido";
            // 
            // LTotal
            // 
            this.LTotal.AutoSize = true;
            this.LTotal.Location = new System.Drawing.Point(44, 35);
            this.LTotal.Name = "LTotal";
            this.LTotal.Size = new System.Drawing.Size(31, 13);
            this.LTotal.TabIndex = 3;
            this.LTotal.Text = "Total";
            // 
            // LTituloGrafCat
            // 
            this.LTituloGrafCat.AutoSize = true;
            this.LTituloGrafCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloGrafCat.Location = new System.Drawing.Point(77, 90);
            this.LTituloGrafCat.Name = "LTituloGrafCat";
            this.LTituloGrafCat.Size = new System.Drawing.Size(176, 13);
            this.LTituloGrafCat.TabIndex = 5;
            this.LTituloGrafCat.Text = "Las 5 categoria mas vendidas";
            // 
            // LTituloGrafProd
            // 
            this.LTituloGrafProd.AutoSize = true;
            this.LTituloGrafProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloGrafProd.Location = new System.Drawing.Point(651, 70);
            this.LTituloGrafProd.Name = "LTituloGrafProd";
            this.LTituloGrafProd.Size = new System.Drawing.Size(186, 13);
            this.LTituloGrafProd.TabIndex = 4;
            this.LTituloGrafProd.Text = "Los 10 productos mas vendidos";
            // 
            // chartProdPreferido
            // 
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Maroon;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX2.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartProdPreferido.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProdPreferido.Legends.Add(legend1);
            this.chartProdPreferido.Location = new System.Drawing.Point(508, 90);
            this.chartProdPreferido.Name = "chartProdPreferido";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartProdPreferido.Series.Add(series1);
            this.chartProdPreferido.Size = new System.Drawing.Size(504, 312);
            this.chartProdPreferido.TabIndex = 2;
            this.chartProdPreferido.Text = "chart1";
            // 
            // chartProdCategoria
            // 
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.Name = "ChartArea1";
            this.chartProdCategoria.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartProdCategoria.Legends.Add(legend2);
            this.chartProdCategoria.Location = new System.Drawing.Point(23, 102);
            this.chartProdCategoria.Name = "chartProdCategoria";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartProdCategoria.Series.Add(series2);
            this.chartProdCategoria.Size = new System.Drawing.Size(300, 300);
            this.chartProdCategoria.TabIndex = 1;
            this.chartProdCategoria.Text = "chart1";
            // 
            // Estadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Estadistica";
            this.Text = "Estadistica";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdPreferido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker DTHasta;
        private System.Windows.Forms.DateTimePicker DTDesde;
        private System.Windows.Forms.RadioButton RBFecha;
        private System.Windows.Forms.RadioButton RBMenosVendidos;
        private System.Windows.Forms.RadioButton RBMasVendidos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdCategoria;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdPreferido;
        private System.Windows.Forms.Label LTotal;
        private System.Windows.Forms.Label LTituloGrafCat;
        private System.Windows.Forms.Label LTituloGrafProd;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label LCantidadCli;
        private System.Windows.Forms.Label LCliente;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LCantidadVentas;
        private System.Windows.Forms.Label LCantidadVendida;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LCantidadMar;
        private System.Windows.Forms.Label LMarcas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LCantidadCat;
        private System.Windows.Forms.Label LCantegoria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LCantidadPro;
        private System.Windows.Forms.Label LTituloProc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LTotalTitulo;
        private System.Windows.Forms.Button LBuscar;
        private System.Windows.Forms.Button BGenerarRep;
    }
}