namespace LaCochera
{
    partial class ALTA_EMPLEADO
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
            this.CBXSucursalFK = new System.Windows.Forms.ComboBox();
            this.LBLSucursal = new System.Windows.Forms.Label();
            this.CBXSexoEmp = new System.Windows.Forms.ComboBox();
            this.LBLSexoEmp = new System.Windows.Forms.Label();
            this.TXTEdadEmp = new System.Windows.Forms.TextBox();
            this.LBLEdadEmp = new System.Windows.Forms.Label();
            this.TXTMaternoEmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNAgregarEmp = new System.Windows.Forms.Button();
            this.TXTPaternoEmp = new System.Windows.Forms.TextBox();
            this.TXTNombreEmp = new System.Windows.Forms.TextBox();
            this.LBLPaternoEmp = new System.Windows.Forms.Label();
            this.LBLNombreEmp = new System.Windows.Forms.Label();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.GBXAltaProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBXAltaProd
            // 
            this.GBXAltaProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GBXAltaProd.Controls.Add(this.CBXSucursalFK);
            this.GBXAltaProd.Controls.Add(this.LBLSucursal);
            this.GBXAltaProd.Controls.Add(this.CBXSexoEmp);
            this.GBXAltaProd.Controls.Add(this.LBLSexoEmp);
            this.GBXAltaProd.Controls.Add(this.TXTEdadEmp);
            this.GBXAltaProd.Controls.Add(this.LBLEdadEmp);
            this.GBXAltaProd.Controls.Add(this.TXTMaternoEmp);
            this.GBXAltaProd.Controls.Add(this.label1);
            this.GBXAltaProd.Controls.Add(this.BTNAgregarEmp);
            this.GBXAltaProd.Controls.Add(this.TXTPaternoEmp);
            this.GBXAltaProd.Controls.Add(this.TXTNombreEmp);
            this.GBXAltaProd.Controls.Add(this.LBLPaternoEmp);
            this.GBXAltaProd.Controls.Add(this.LBLNombreEmp);
            this.GBXAltaProd.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBXAltaProd.ForeColor = System.Drawing.Color.Black;
            this.GBXAltaProd.Location = new System.Drawing.Point(98, 105);
            this.GBXAltaProd.Name = "GBXAltaProd";
            this.GBXAltaProd.Size = new System.Drawing.Size(604, 258);
            this.GBXAltaProd.TabIndex = 1;
            this.GBXAltaProd.TabStop = false;
            this.GBXAltaProd.Text = "Registrar Empleado";
            this.GBXAltaProd.Enter += new System.EventHandler(this.GBXAltaProd_Enter);
            // 
            // CBXSucursalFK
            // 
            this.CBXSucursalFK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXSucursalFK.FormattingEnabled = true;
            this.CBXSucursalFK.Items.AddRange(new object[] {
            "M",
            "F"});
            this.CBXSucursalFK.Location = new System.Drawing.Point(471, 204);
            this.CBXSucursalFK.Name = "CBXSucursalFK";
            this.CBXSucursalFK.Size = new System.Drawing.Size(121, 36);
            this.CBXSucursalFK.TabIndex = 12;
            // 
            // LBLSucursal
            // 
            this.LBLSucursal.AutoSize = true;
            this.LBLSucursal.Location = new System.Drawing.Point(373, 207);
            this.LBLSucursal.Name = "LBLSucursal";
            this.LBLSucursal.Size = new System.Drawing.Size(92, 28);
            this.LBLSucursal.TabIndex = 11;
            this.LBLSucursal.Text = "Sucursal";
            this.LBLSucursal.Click += new System.EventHandler(this.Label3_Click);
            // 
            // CBXSexoEmp
            // 
            this.CBXSexoEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXSexoEmp.FormattingEnabled = true;
            this.CBXSexoEmp.Location = new System.Drawing.Point(471, 152);
            this.CBXSexoEmp.Name = "CBXSexoEmp";
            this.CBXSexoEmp.Size = new System.Drawing.Size(121, 36);
            this.CBXSexoEmp.TabIndex = 10;
            this.CBXSexoEmp.SelectedIndexChanged += new System.EventHandler(this.CBXSexoEmp_SelectedIndexChanged);
            // 
            // LBLSexoEmp
            // 
            this.LBLSexoEmp.AutoSize = true;
            this.LBLSexoEmp.Location = new System.Drawing.Point(385, 155);
            this.LBLSexoEmp.Name = "LBLSexoEmp";
            this.LBLSexoEmp.Size = new System.Drawing.Size(56, 28);
            this.LBLSexoEmp.TabIndex = 9;
            this.LBLSexoEmp.Text = "Sexo";
            // 
            // TXTEdadEmp
            // 
            this.TXTEdadEmp.Location = new System.Drawing.Point(145, 204);
            this.TXTEdadEmp.Name = "TXTEdadEmp";
            this.TXTEdadEmp.Size = new System.Drawing.Size(222, 36);
            this.TXTEdadEmp.TabIndex = 8;
            // 
            // LBLEdadEmp
            // 
            this.LBLEdadEmp.AutoSize = true;
            this.LBLEdadEmp.Location = new System.Drawing.Point(37, 204);
            this.LBLEdadEmp.Name = "LBLEdadEmp";
            this.LBLEdadEmp.Size = new System.Drawing.Size(61, 28);
            this.LBLEdadEmp.TabIndex = 7;
            this.LBLEdadEmp.Text = "Edad";
            // 
            // TXTMaternoEmp
            // 
            this.TXTMaternoEmp.Location = new System.Drawing.Point(145, 152);
            this.TXTMaternoEmp.Name = "TXTMaternoEmp";
            this.TXTMaternoEmp.Size = new System.Drawing.Size(222, 36);
            this.TXTMaternoEmp.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 56);
            this.label1.TabIndex = 5;
            this.label1.Text = "Apellido\r\nMaterno\r\n";
            // 
            // BTNAgregarEmp
            // 
            this.BTNAgregarEmp.Location = new System.Drawing.Point(442, 70);
            this.BTNAgregarEmp.Name = "BTNAgregarEmp";
            this.BTNAgregarEmp.Size = new System.Drawing.Size(118, 39);
            this.BTNAgregarEmp.TabIndex = 4;
            this.BTNAgregarEmp.Text = "Agregar";
            this.BTNAgregarEmp.UseVisualStyleBackColor = true;
            this.BTNAgregarEmp.Click += new System.EventHandler(this.BTNAgregarEmp_Click);
            // 
            // TXTPaternoEmp
            // 
            this.TXTPaternoEmp.Location = new System.Drawing.Point(145, 96);
            this.TXTPaternoEmp.Name = "TXTPaternoEmp";
            this.TXTPaternoEmp.Size = new System.Drawing.Size(222, 36);
            this.TXTPaternoEmp.TabIndex = 3;
            // 
            // TXTNombreEmp
            // 
            this.TXTNombreEmp.Location = new System.Drawing.Point(145, 44);
            this.TXTNombreEmp.Name = "TXTNombreEmp";
            this.TXTNombreEmp.Size = new System.Drawing.Size(222, 36);
            this.TXTNombreEmp.TabIndex = 2;
            // 
            // LBLPaternoEmp
            // 
            this.LBLPaternoEmp.AutoSize = true;
            this.LBLPaternoEmp.Location = new System.Drawing.Point(37, 85);
            this.LBLPaternoEmp.Name = "LBLPaternoEmp";
            this.LBLPaternoEmp.Size = new System.Drawing.Size(90, 56);
            this.LBLPaternoEmp.TabIndex = 1;
            this.LBLPaternoEmp.Text = "Apellido\r\nPaterno\r\n";
            // 
            // LBLNombreEmp
            // 
            this.LBLNombreEmp.AutoSize = true;
            this.LBLNombreEmp.Location = new System.Drawing.Point(32, 47);
            this.LBLNombreEmp.Name = "LBLNombreEmp";
            this.LBLNombreEmp.Size = new System.Drawing.Size(86, 28);
            this.LBLNombreEmp.TabIndex = 0;
            this.LBLNombreEmp.Text = "Nombre";
            // 
            // BTNSalir
            // 
            this.BTNSalir.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSalir.Location = new System.Drawing.Point(553, 390);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(105, 39);
            this.BTNSalir.TabIndex = 2;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // ALTA_EMPLEADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaCochera.Properties.Resources.FONDOHAMBURGUESA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.GBXAltaProd);
            this.HelpButton = true;
            this.Name = "ALTA_EMPLEADO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALTA EMPLEADO";
            this.GBXAltaProd.ResumeLayout(false);
            this.GBXAltaProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBXAltaProd;
        private System.Windows.Forms.TextBox TXTMaternoEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNAgregarEmp;
        private System.Windows.Forms.TextBox TXTPaternoEmp;
        private System.Windows.Forms.TextBox TXTNombreEmp;
        private System.Windows.Forms.Label LBLPaternoEmp;
        private System.Windows.Forms.Label LBLNombreEmp;
        private System.Windows.Forms.ComboBox CBXSucursalFK;
        private System.Windows.Forms.Label LBLSucursal;
        private System.Windows.Forms.ComboBox CBXSexoEmp;
        private System.Windows.Forms.Label LBLSexoEmp;
        private System.Windows.Forms.TextBox TXTEdadEmp;
        private System.Windows.Forms.Label LBLEdadEmp;
        private System.Windows.Forms.Button BTNSalir;
    }
}