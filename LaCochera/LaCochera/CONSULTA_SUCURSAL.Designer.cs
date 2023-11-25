namespace LaCochera
{
    partial class CONSULTA_SUCURSAL
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
            this.GBXConsultaSuc = new System.Windows.Forms.GroupBox();
            this.BTNVConsultaSuc = new System.Windows.Forms.Button();
            this.DGVSucursales = new System.Windows.Forms.DataGridView();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.GBXConsultaSuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // GBXConsultaSuc
            // 
            this.GBXConsultaSuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GBXConsultaSuc.Controls.Add(this.BTNVConsultaSuc);
            this.GBXConsultaSuc.Controls.Add(this.DGVSucursales);
            this.GBXConsultaSuc.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBXConsultaSuc.ForeColor = System.Drawing.Color.Black;
            this.GBXConsultaSuc.Location = new System.Drawing.Point(65, 134);
            this.GBXConsultaSuc.Name = "GBXConsultaSuc";
            this.GBXConsultaSuc.Size = new System.Drawing.Size(647, 197);
            this.GBXConsultaSuc.TabIndex = 4;
            this.GBXConsultaSuc.TabStop = false;
            this.GBXConsultaSuc.Text = "Sucursales";
            // 
            // BTNVConsultaSuc
            // 
            this.BTNVConsultaSuc.Location = new System.Drawing.Point(539, 88);
            this.BTNVConsultaSuc.Name = "BTNVConsultaSuc";
            this.BTNVConsultaSuc.Size = new System.Drawing.Size(82, 40);
            this.BTNVConsultaSuc.TabIndex = 1;
            this.BTNVConsultaSuc.Text = "Check";
            this.BTNVConsultaSuc.UseVisualStyleBackColor = true;
            this.BTNVConsultaSuc.Click += new System.EventHandler(this.BTNVConsultaSuc_Click);
            // 
            // DGVSucursales
            // 
            this.DGVSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSucursales.Location = new System.Drawing.Point(35, 49);
            this.DGVSucursales.Name = "DGVSucursales";
            this.DGVSucursales.Size = new System.Drawing.Size(483, 131);
            this.DGVSucursales.TabIndex = 0;
            // 
            // BTNSalir
            // 
            this.BTNSalir.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSalir.Location = new System.Drawing.Point(581, 365);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(105, 39);
            this.BTNSalir.TabIndex = 5;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // CONSULTA_SUCURSAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaCochera.Properties.Resources.FONDOHAMBURGUESA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.GBXConsultaSuc);
            this.Name = "CONSULTA_SUCURSAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTA SUCURSAL";
            this.GBXConsultaSuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSucursales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBXConsultaSuc;
        private System.Windows.Forms.Button BTNVConsultaSuc;
        private System.Windows.Forms.DataGridView DGVSucursales;
        private System.Windows.Forms.Button BTNSalir;
    }
}