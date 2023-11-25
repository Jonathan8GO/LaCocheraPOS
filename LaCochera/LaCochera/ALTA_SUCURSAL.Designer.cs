namespace LaCochera
{
    partial class ALTA_SUCURSAL
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
            this.GBXAltaSucursal = new System.Windows.Forms.GroupBox();
            this.CBXMunicipioFK = new System.Windows.Forms.ComboBox();
            this.LBLMunicipio = new System.Windows.Forms.Label();
            this.BTNAgregarSucursal = new System.Windows.Forms.Button();
            this.TXTCalleSucursal = new System.Windows.Forms.TextBox();
            this.TXTNombreSucursal = new System.Windows.Forms.TextBox();
            this.LBLCalleSucursal = new System.Windows.Forms.Label();
            this.LBLNombreSucursal = new System.Windows.Forms.Label();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.GBXAltaSucursal.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBXAltaSucursal
            // 
            this.GBXAltaSucursal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GBXAltaSucursal.Controls.Add(this.CBXMunicipioFK);
            this.GBXAltaSucursal.Controls.Add(this.LBLMunicipio);
            this.GBXAltaSucursal.Controls.Add(this.BTNAgregarSucursal);
            this.GBXAltaSucursal.Controls.Add(this.TXTCalleSucursal);
            this.GBXAltaSucursal.Controls.Add(this.TXTNombreSucursal);
            this.GBXAltaSucursal.Controls.Add(this.LBLCalleSucursal);
            this.GBXAltaSucursal.Controls.Add(this.LBLNombreSucursal);
            this.GBXAltaSucursal.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBXAltaSucursal.ForeColor = System.Drawing.Color.Black;
            this.GBXAltaSucursal.Location = new System.Drawing.Point(99, 106);
            this.GBXAltaSucursal.Name = "GBXAltaSucursal";
            this.GBXAltaSucursal.Size = new System.Drawing.Size(604, 224);
            this.GBXAltaSucursal.TabIndex = 1;
            this.GBXAltaSucursal.TabStop = false;
            this.GBXAltaSucursal.Text = "Registrar Sucursal";
            // 
            // CBXMunicipioFK
            // 
            this.CBXMunicipioFK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXMunicipioFK.FormattingEnabled = true;
            this.CBXMunicipioFK.Items.AddRange(new object[] {
            "M",
            "F"});
            this.CBXMunicipioFK.Location = new System.Drawing.Point(150, 146);
            this.CBXMunicipioFK.Name = "CBXMunicipioFK";
            this.CBXMunicipioFK.Size = new System.Drawing.Size(222, 36);
            this.CBXMunicipioFK.TabIndex = 14;
            // 
            // LBLMunicipio
            // 
            this.LBLMunicipio.AutoSize = true;
            this.LBLMunicipio.Location = new System.Drawing.Point(37, 154);
            this.LBLMunicipio.Name = "LBLMunicipio";
            this.LBLMunicipio.Size = new System.Drawing.Size(107, 28);
            this.LBLMunicipio.TabIndex = 13;
            this.LBLMunicipio.Text = "Municipio";
            this.LBLMunicipio.Click += new System.EventHandler(this.LBLSucursal_Click);
            // 
            // BTNAgregarSucursal
            // 
            this.BTNAgregarSucursal.Location = new System.Drawing.Point(442, 70);
            this.BTNAgregarSucursal.Name = "BTNAgregarSucursal";
            this.BTNAgregarSucursal.Size = new System.Drawing.Size(118, 39);
            this.BTNAgregarSucursal.TabIndex = 4;
            this.BTNAgregarSucursal.Text = "Agregar";
            this.BTNAgregarSucursal.UseVisualStyleBackColor = true;
            this.BTNAgregarSucursal.Click += new System.EventHandler(this.BTNAgregarSucursal_Click);
            // 
            // TXTCalleSucursal
            // 
            this.TXTCalleSucursal.Location = new System.Drawing.Point(150, 96);
            this.TXTCalleSucursal.Name = "TXTCalleSucursal";
            this.TXTCalleSucursal.Size = new System.Drawing.Size(222, 36);
            this.TXTCalleSucursal.TabIndex = 3;
            // 
            // TXTNombreSucursal
            // 
            this.TXTNombreSucursal.Location = new System.Drawing.Point(150, 44);
            this.TXTNombreSucursal.Name = "TXTNombreSucursal";
            this.TXTNombreSucursal.Size = new System.Drawing.Size(222, 36);
            this.TXTNombreSucursal.TabIndex = 2;
            this.TXTNombreSucursal.TextChanged += new System.EventHandler(this.TXTNombreProd_TextChanged);
            // 
            // LBLCalleSucursal
            // 
            this.LBLCalleSucursal.AutoSize = true;
            this.LBLCalleSucursal.Location = new System.Drawing.Point(37, 96);
            this.LBLCalleSucursal.Name = "LBLCalleSucursal";
            this.LBLCalleSucursal.Size = new System.Drawing.Size(59, 28);
            this.LBLCalleSucursal.TabIndex = 1;
            this.LBLCalleSucursal.Text = "Calle";
            // 
            // LBLNombreSucursal
            // 
            this.LBLNombreSucursal.AutoSize = true;
            this.LBLNombreSucursal.Location = new System.Drawing.Point(32, 47);
            this.LBLNombreSucursal.Name = "LBLNombreSucursal";
            this.LBLNombreSucursal.Size = new System.Drawing.Size(86, 28);
            this.LBLNombreSucursal.TabIndex = 0;
            this.LBLNombreSucursal.Text = "Nombre";
            // 
            // BTNSalir
            // 
            this.BTNSalir.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSalir.Location = new System.Drawing.Point(554, 371);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(105, 39);
            this.BTNSalir.TabIndex = 2;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // ALTA_SUCURSAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaCochera.Properties.Resources.FONDOHAMBURGUESA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.GBXAltaSucursal);
            this.Name = "ALTA_SUCURSAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALTA SUCURSAL";
            this.GBXAltaSucursal.ResumeLayout(false);
            this.GBXAltaSucursal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBXAltaSucursal;
        private System.Windows.Forms.Button BTNAgregarSucursal;
        private System.Windows.Forms.TextBox TXTCalleSucursal;
        private System.Windows.Forms.TextBox TXTNombreSucursal;
        private System.Windows.Forms.Label LBLCalleSucursal;
        private System.Windows.Forms.Label LBLNombreSucursal;
        private System.Windows.Forms.ComboBox CBXMunicipioFK;
        private System.Windows.Forms.Label LBLMunicipio;
        private System.Windows.Forms.Button BTNSalir;
    }
}