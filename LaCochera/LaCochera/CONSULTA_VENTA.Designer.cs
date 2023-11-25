namespace LaCochera
{
    partial class CONSULTA_VENTA
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
            this.GBXConsultaVentas = new System.Windows.Forms.GroupBox();
            this.BTNVConsultaVentas = new System.Windows.Forms.Button();
            this.DGVVentas = new System.Windows.Forms.DataGridView();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.GBXConsultaVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // GBXConsultaVentas
            // 
            this.GBXConsultaVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GBXConsultaVentas.Controls.Add(this.BTNVConsultaVentas);
            this.GBXConsultaVentas.Controls.Add(this.DGVVentas);
            this.GBXConsultaVentas.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBXConsultaVentas.ForeColor = System.Drawing.Color.Black;
            this.GBXConsultaVentas.Location = new System.Drawing.Point(77, 127);
            this.GBXConsultaVentas.Name = "GBXConsultaVentas";
            this.GBXConsultaVentas.Size = new System.Drawing.Size(647, 197);
            this.GBXConsultaVentas.TabIndex = 5;
            this.GBXConsultaVentas.TabStop = false;
            this.GBXConsultaVentas.Text = "Ventas";
            // 
            // BTNVConsultaVentas
            // 
            this.BTNVConsultaVentas.Location = new System.Drawing.Point(539, 88);
            this.BTNVConsultaVentas.Name = "BTNVConsultaVentas";
            this.BTNVConsultaVentas.Size = new System.Drawing.Size(82, 40);
            this.BTNVConsultaVentas.TabIndex = 1;
            this.BTNVConsultaVentas.Text = "Check";
            this.BTNVConsultaVentas.UseVisualStyleBackColor = true;
            // 
            // DGVVentas
            // 
            this.DGVVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVVentas.Location = new System.Drawing.Point(35, 49);
            this.DGVVentas.Name = "DGVVentas";
            this.DGVVentas.Size = new System.Drawing.Size(483, 131);
            this.DGVVentas.TabIndex = 0;
            // 
            // BTNSalir
            // 
            this.BTNSalir.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSalir.Location = new System.Drawing.Point(593, 374);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(105, 39);
            this.BTNSalir.TabIndex = 6;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // CONSULTA_VENTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaCochera.Properties.Resources.FONDOHAMBURGUESA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.GBXConsultaVentas);
            this.Name = "CONSULTA_VENTA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTA VENTA";
            this.GBXConsultaVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBXConsultaVentas;
        private System.Windows.Forms.Button BTNVConsultaVentas;
        private System.Windows.Forms.DataGridView DGVVentas;
        private System.Windows.Forms.Button BTNSalir;
    }
}