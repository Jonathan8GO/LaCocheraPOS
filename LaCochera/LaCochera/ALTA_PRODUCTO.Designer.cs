namespace LaCochera
{
    partial class ALTA_PRODUCTO
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
            this.GBXAltaProd = new System.Windows.Forms.GroupBox();
            this.BTNAgregarProd = new System.Windows.Forms.Button();
            this.TXTPrecioProd = new System.Windows.Forms.TextBox();
            this.TXTNombreProd = new System.Windows.Forms.TextBox();
            this.LBLPrecioProd = new System.Windows.Forms.Label();
            this.LBLNombreProd = new System.Windows.Forms.Label();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.GBXAltaProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBXAltaProd
            // 
            this.GBXAltaProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GBXAltaProd.Controls.Add(this.BTNAgregarProd);
            this.GBXAltaProd.Controls.Add(this.TXTPrecioProd);
            this.GBXAltaProd.Controls.Add(this.TXTNombreProd);
            this.GBXAltaProd.Controls.Add(this.LBLPrecioProd);
            this.GBXAltaProd.Controls.Add(this.LBLNombreProd);
            this.GBXAltaProd.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBXAltaProd.ForeColor = System.Drawing.Color.Black;
            this.GBXAltaProd.Location = new System.Drawing.Point(114, 33);
            this.GBXAltaProd.Name = "GBXAltaProd";
            this.GBXAltaProd.Size = new System.Drawing.Size(604, 240);
            this.GBXAltaProd.TabIndex = 0;
            this.GBXAltaProd.TabStop = false;
            this.GBXAltaProd.Text = "Registrar Producto";
            // 
            // BTNAgregarProd
            // 
            this.BTNAgregarProd.Location = new System.Drawing.Point(442, 70);
            this.BTNAgregarProd.Name = "BTNAgregarProd";
            this.BTNAgregarProd.Size = new System.Drawing.Size(118, 39);
            this.BTNAgregarProd.TabIndex = 4;
            this.BTNAgregarProd.Text = "Agregar";
            this.BTNAgregarProd.UseVisualStyleBackColor = true;
            this.BTNAgregarProd.Click += new System.EventHandler(this.BTNAgregarProd_Click);
            // 
            // TXTPrecioProd
            // 
            this.TXTPrecioProd.Location = new System.Drawing.Point(145, 96);
            this.TXTPrecioProd.Name = "TXTPrecioProd";
            this.TXTPrecioProd.Size = new System.Drawing.Size(222, 36);
            this.TXTPrecioProd.TabIndex = 3;
            // 
            // TXTNombreProd
            // 
            this.TXTNombreProd.Location = new System.Drawing.Point(145, 44);
            this.TXTNombreProd.Name = "TXTNombreProd";
            this.TXTNombreProd.Size = new System.Drawing.Size(222, 36);
            this.TXTNombreProd.TabIndex = 2;
            // 
            // LBLPrecioProd
            // 
            this.LBLPrecioProd.AutoSize = true;
            this.LBLPrecioProd.Location = new System.Drawing.Point(37, 96);
            this.LBLPrecioProd.Name = "LBLPrecioProd";
            this.LBLPrecioProd.Size = new System.Drawing.Size(70, 28);
            this.LBLPrecioProd.TabIndex = 1;
            this.LBLPrecioProd.Text = "Precio";
            // 
            // LBLNombreProd
            // 
            this.LBLNombreProd.AutoSize = true;
            this.LBLNombreProd.Location = new System.Drawing.Point(32, 47);
            this.LBLNombreProd.Name = "LBLNombreProd";
            this.LBLNombreProd.Size = new System.Drawing.Size(86, 28);
            this.LBLNombreProd.TabIndex = 0;
            this.LBLNombreProd.Text = "Nombre";
            // 
            // BTNSalir
            // 
            this.BTNSalir.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSalir.Location = new System.Drawing.Point(569, 318);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(105, 39);
            this.BTNSalir.TabIndex = 2;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // ALTA_PRODUCTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaCochera.Properties.Resources.FONDOHAMBURGUESA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.GBXAltaProd);
            this.Name = "ALTA_PRODUCTO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ALTA PRODUCTO";
            this.Load += new System.EventHandler(this.ALTA_PRODUCTO_Load);
            this.GBXAltaProd.ResumeLayout(false);
            this.GBXAltaProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBXAltaProd;
        private System.Windows.Forms.Label LBLNombreProd;
        private System.Windows.Forms.Label LBLPrecioProd;
        private System.Windows.Forms.Button BTNAgregarProd;
        private System.Windows.Forms.TextBox TXTPrecioProd;
        private System.Windows.Forms.TextBox TXTNombreProd;
        private System.Windows.Forms.Button BTNSalir;
    }
}