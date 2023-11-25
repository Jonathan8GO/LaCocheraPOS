namespace LaCochera
{
    partial class BAJA_EMPLEADO
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
            this.GBXBajaEmp = new System.Windows.Forms.GroupBox();
            this.BTNBajaEmp = new System.Windows.Forms.Button();
            this.TXTIDEmpBaja = new System.Windows.Forms.TextBox();
            this.LBLIDEmp = new System.Windows.Forms.Label();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.GBXBajaEmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBXBajaEmp
            // 
            this.GBXBajaEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GBXBajaEmp.Controls.Add(this.BTNBajaEmp);
            this.GBXBajaEmp.Controls.Add(this.TXTIDEmpBaja);
            this.GBXBajaEmp.Controls.Add(this.LBLIDEmp);
            this.GBXBajaEmp.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBXBajaEmp.ForeColor = System.Drawing.Color.Black;
            this.GBXBajaEmp.Location = new System.Drawing.Point(98, 154);
            this.GBXBajaEmp.Name = "GBXBajaEmp";
            this.GBXBajaEmp.Size = new System.Drawing.Size(604, 143);
            this.GBXBajaEmp.TabIndex = 2;
            this.GBXBajaEmp.TabStop = false;
            this.GBXBajaEmp.Text = "Baja Empleado";
            // 
            // BTNBajaEmp
            // 
            this.BTNBajaEmp.Location = new System.Drawing.Point(411, 47);
            this.BTNBajaEmp.Name = "BTNBajaEmp";
            this.BTNBajaEmp.Size = new System.Drawing.Size(118, 39);
            this.BTNBajaEmp.TabIndex = 4;
            this.BTNBajaEmp.Text = "Baja";
            this.BTNBajaEmp.UseVisualStyleBackColor = true;
            this.BTNBajaEmp.Click += new System.EventHandler(this.BTNBajaEmp_Click);
            // 
            // TXTIDEmpBaja
            // 
            this.TXTIDEmpBaja.Location = new System.Drawing.Point(145, 44);
            this.TXTIDEmpBaja.Name = "TXTIDEmpBaja";
            this.TXTIDEmpBaja.Size = new System.Drawing.Size(222, 36);
            this.TXTIDEmpBaja.TabIndex = 2;
            // 
            // LBLIDEmp
            // 
            this.LBLIDEmp.AutoSize = true;
            this.LBLIDEmp.Location = new System.Drawing.Point(32, 47);
            this.LBLIDEmp.Name = "LBLIDEmp";
            this.LBLIDEmp.Size = new System.Drawing.Size(41, 28);
            this.LBLIDEmp.TabIndex = 0;
            this.LBLIDEmp.Text = "ID ";
            // 
            // BTNSalir
            // 
            this.BTNSalir.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSalir.Location = new System.Drawing.Point(522, 325);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(105, 39);
            this.BTNSalir.TabIndex = 3;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // BAJA_EMPLEADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaCochera.Properties.Resources.FONDOHAMBURGUESA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.GBXBajaEmp);
            this.Name = "BAJA_EMPLEADO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAJA EMPLEADO";
            this.GBXBajaEmp.ResumeLayout(false);
            this.GBXBajaEmp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBXBajaEmp;
        private System.Windows.Forms.Button BTNBajaEmp;
        private System.Windows.Forms.TextBox TXTIDEmpBaja;
        private System.Windows.Forms.Label LBLIDEmp;
        private System.Windows.Forms.Button BTNSalir;
    }
}