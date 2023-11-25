namespace LaCochera
{
    partial class CONSULTA_EMPLEADO
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
            this.GBXEmpActivos = new System.Windows.Forms.GroupBox();
            this.BTNEmpActivos = new System.Windows.Forms.Button();
            this.DGVEmpActivos = new System.Windows.Forms.DataGridView();
            this.GBXEmpInactivos = new System.Windows.Forms.GroupBox();
            this.BTNEmpInactivos = new System.Windows.Forms.Button();
            this.DGVEmpInactivos = new System.Windows.Forms.DataGridView();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.GBXEmpActivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmpActivos)).BeginInit();
            this.GBXEmpInactivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmpInactivos)).BeginInit();
            this.SuspendLayout();
            // 
            // GBXEmpActivos
            // 
            this.GBXEmpActivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GBXEmpActivos.Controls.Add(this.BTNEmpActivos);
            this.GBXEmpActivos.Controls.Add(this.DGVEmpActivos);
            this.GBXEmpActivos.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBXEmpActivos.ForeColor = System.Drawing.Color.Black;
            this.GBXEmpActivos.Location = new System.Drawing.Point(98, 36);
            this.GBXEmpActivos.Name = "GBXEmpActivos";
            this.GBXEmpActivos.Size = new System.Drawing.Size(647, 197);
            this.GBXEmpActivos.TabIndex = 2;
            this.GBXEmpActivos.TabStop = false;
            this.GBXEmpActivos.Text = "Empleados Activos";
            // 
            // BTNEmpActivos
            // 
            this.BTNEmpActivos.Location = new System.Drawing.Point(539, 88);
            this.BTNEmpActivos.Name = "BTNEmpActivos";
            this.BTNEmpActivos.Size = new System.Drawing.Size(82, 40);
            this.BTNEmpActivos.TabIndex = 1;
            this.BTNEmpActivos.Text = "Check";
            this.BTNEmpActivos.UseVisualStyleBackColor = true;
            this.BTNEmpActivos.Click += new System.EventHandler(this.BTNEmpActivos_Click);
            // 
            // DGVEmpActivos
            // 
            this.DGVEmpActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEmpActivos.Location = new System.Drawing.Point(35, 49);
            this.DGVEmpActivos.Name = "DGVEmpActivos";
            this.DGVEmpActivos.Size = new System.Drawing.Size(483, 131);
            this.DGVEmpActivos.TabIndex = 0;
            this.DGVEmpActivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVEmpActivos_CellContentClick);
            // 
            // GBXEmpInactivos
            // 
            this.GBXEmpInactivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GBXEmpInactivos.Controls.Add(this.BTNEmpInactivos);
            this.GBXEmpInactivos.Controls.Add(this.DGVEmpInactivos);
            this.GBXEmpInactivos.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBXEmpInactivos.ForeColor = System.Drawing.Color.Black;
            this.GBXEmpInactivos.Location = new System.Drawing.Point(98, 262);
            this.GBXEmpInactivos.Name = "GBXEmpInactivos";
            this.GBXEmpInactivos.Size = new System.Drawing.Size(647, 182);
            this.GBXEmpInactivos.TabIndex = 3;
            this.GBXEmpInactivos.TabStop = false;
            this.GBXEmpInactivos.Text = "Empleados Inactivos";
            // 
            // BTNEmpInactivos
            // 
            this.BTNEmpInactivos.Location = new System.Drawing.Point(539, 75);
            this.BTNEmpInactivos.Name = "BTNEmpInactivos";
            this.BTNEmpInactivos.Size = new System.Drawing.Size(82, 42);
            this.BTNEmpInactivos.TabIndex = 2;
            this.BTNEmpInactivos.Text = "Check";
            this.BTNEmpInactivos.UseVisualStyleBackColor = true;
            this.BTNEmpInactivos.Click += new System.EventHandler(this.BTNEmpInactivos_Click);
            // 
            // DGVEmpInactivos
            // 
            this.DGVEmpInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEmpInactivos.Location = new System.Drawing.Point(35, 49);
            this.DGVEmpInactivos.Name = "DGVEmpInactivos";
            this.DGVEmpInactivos.Size = new System.Drawing.Size(483, 118);
            this.DGVEmpInactivos.TabIndex = 0;
            // 
            // BTNSalir
            // 
            this.BTNSalir.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSalir.Location = new System.Drawing.Point(614, 476);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(105, 39);
            this.BTNSalir.TabIndex = 4;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // CONSULTA_EMPLEADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaCochera.Properties.Resources.FONDOHAMBURGUESA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 509);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.GBXEmpInactivos);
            this.Controls.Add(this.GBXEmpActivos);
            this.Name = "CONSULTA_EMPLEADO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTA EMPLEADO";
            this.GBXEmpActivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmpActivos)).EndInit();
            this.GBXEmpInactivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmpInactivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBXEmpActivos;
        private System.Windows.Forms.DataGridView DGVEmpActivos;
        private System.Windows.Forms.GroupBox GBXEmpInactivos;
        private System.Windows.Forms.Button BTNEmpActivos;
        private System.Windows.Forms.Button BTNEmpInactivos;
        private System.Windows.Forms.DataGridView DGVEmpInactivos;
        private System.Windows.Forms.Button BTNSalir;
    }
}