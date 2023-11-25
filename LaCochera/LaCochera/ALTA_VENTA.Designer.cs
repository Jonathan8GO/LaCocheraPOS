namespace LaCochera
{
    partial class ALTA_VENTA
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
            this.GBXAltaVenta = new System.Windows.Forms.GroupBox();
            this.CBXVent = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.TXTCantidad = new System.Windows.Forms.TextBox();
            this.LBLCantidad = new System.Windows.Forms.Label();
            this.LBLPrecio = new System.Windows.Forms.Label();
            this.CBXProducto = new System.Windows.Forms.ComboBox();
            this.LBLProducto = new System.Windows.Forms.Label();
            this.CBXEmpleado = new System.Windows.Forms.ComboBox();
            this.LBLEmpleado = new System.Windows.Forms.Label();
            this.CBXSucursal = new System.Windows.Forms.ComboBox();
            this.LBLSucursal = new System.Windows.Forms.Label();
            this.BTNAgregar = new System.Windows.Forms.Button();
            this.TXTTotal = new System.Windows.Forms.TextBox();
            this.LBLTotal = new System.Windows.Forms.Label();
            this.DGVTicket = new System.Windows.Forms.DataGridView();
            this.GBXAltaVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // GBXAltaVenta
            // 
            this.GBXAltaVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GBXAltaVenta.Controls.Add(this.CBXVent);
            this.GBXAltaVenta.Controls.Add(this.button1);
            this.GBXAltaVenta.Controls.Add(this.comboBox1);
            this.GBXAltaVenta.Controls.Add(this.BTNSalir);
            this.GBXAltaVenta.Controls.Add(this.TXTCantidad);
            this.GBXAltaVenta.Controls.Add(this.LBLCantidad);
            this.GBXAltaVenta.Controls.Add(this.LBLPrecio);
            this.GBXAltaVenta.Controls.Add(this.CBXProducto);
            this.GBXAltaVenta.Controls.Add(this.LBLProducto);
            this.GBXAltaVenta.Controls.Add(this.CBXEmpleado);
            this.GBXAltaVenta.Controls.Add(this.LBLEmpleado);
            this.GBXAltaVenta.Controls.Add(this.CBXSucursal);
            this.GBXAltaVenta.Controls.Add(this.LBLSucursal);
            this.GBXAltaVenta.Controls.Add(this.BTNAgregar);
            this.GBXAltaVenta.Controls.Add(this.TXTTotal);
            this.GBXAltaVenta.Controls.Add(this.LBLTotal);
            this.GBXAltaVenta.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBXAltaVenta.ForeColor = System.Drawing.Color.Black;
            this.GBXAltaVenta.Location = new System.Drawing.Point(105, 23);
            this.GBXAltaVenta.Name = "GBXAltaVenta";
            this.GBXAltaVenta.Size = new System.Drawing.Size(601, 313);
            this.GBXAltaVenta.TabIndex = 2;
            this.GBXAltaVenta.TabStop = false;
            this.GBXAltaVenta.Text = "Registrar Venta";
            this.GBXAltaVenta.Enter += new System.EventHandler(this.GBXAltaSucursal_Enter);
            // 
            // CBXVent
            // 
            this.CBXVent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXVent.FormattingEnabled = true;
            this.CBXVent.Items.AddRange(new object[] {
            "M",
            "F"});
            this.CBXVent.Location = new System.Drawing.Point(391, 35);
            this.CBXVent.Name = "CBXVent";
            this.CBXVent.Size = new System.Drawing.Size(187, 36);
            this.CBXVent.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 39);
            this.button1.TabIndex = 24;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboBox1.Location = new System.Drawing.Point(144, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 36);
            this.comboBox1.TabIndex = 23;
            // 
            // BTNSalir
            // 
            this.BTNSalir.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSalir.Location = new System.Drawing.Point(442, 145);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(118, 39);
            this.BTNSalir.TabIndex = 3;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // TXTCantidad
            // 
            this.TXTCantidad.Location = new System.Drawing.Point(144, 227);
            this.TXTCantidad.Name = "TXTCantidad";
            this.TXTCantidad.Size = new System.Drawing.Size(222, 36);
            this.TXTCantidad.TabIndex = 22;
            // 
            // LBLCantidad
            // 
            this.LBLCantidad.AutoSize = true;
            this.LBLCantidad.Location = new System.Drawing.Point(31, 230);
            this.LBLCantidad.Name = "LBLCantidad";
            this.LBLCantidad.Size = new System.Drawing.Size(100, 28);
            this.LBLCantidad.TabIndex = 21;
            this.LBLCantidad.Text = "Cantidad";
            // 
            // LBLPrecio
            // 
            this.LBLPrecio.AutoSize = true;
            this.LBLPrecio.Location = new System.Drawing.Point(31, 185);
            this.LBLPrecio.Name = "LBLPrecio";
            this.LBLPrecio.Size = new System.Drawing.Size(70, 28);
            this.LBLPrecio.TabIndex = 19;
            this.LBLPrecio.Text = "Precio";
            // 
            // CBXProducto
            // 
            this.CBXProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXProducto.FormattingEnabled = true;
            this.CBXProducto.Items.AddRange(new object[] {
            "M",
            "F"});
            this.CBXProducto.Location = new System.Drawing.Point(144, 137);
            this.CBXProducto.Name = "CBXProducto";
            this.CBXProducto.Size = new System.Drawing.Size(222, 36);
            this.CBXProducto.TabIndex = 18;
            // 
            // LBLProducto
            // 
            this.LBLProducto.AutoSize = true;
            this.LBLProducto.Location = new System.Drawing.Point(31, 145);
            this.LBLProducto.Name = "LBLProducto";
            this.LBLProducto.Size = new System.Drawing.Size(99, 28);
            this.LBLProducto.TabIndex = 17;
            this.LBLProducto.Text = "Producto";
            // 
            // CBXEmpleado
            // 
            this.CBXEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXEmpleado.FormattingEnabled = true;
            this.CBXEmpleado.Items.AddRange(new object[] {
            "M",
            "F"});
            this.CBXEmpleado.Location = new System.Drawing.Point(144, 86);
            this.CBXEmpleado.Name = "CBXEmpleado";
            this.CBXEmpleado.Size = new System.Drawing.Size(222, 36);
            this.CBXEmpleado.TabIndex = 16;
            // 
            // LBLEmpleado
            // 
            this.LBLEmpleado.AutoSize = true;
            this.LBLEmpleado.Location = new System.Drawing.Point(31, 94);
            this.LBLEmpleado.Name = "LBLEmpleado";
            this.LBLEmpleado.Size = new System.Drawing.Size(106, 28);
            this.LBLEmpleado.TabIndex = 15;
            this.LBLEmpleado.Text = "Empleado";
            // 
            // CBXSucursal
            // 
            this.CBXSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBXSucursal.FormattingEnabled = true;
            this.CBXSucursal.Items.AddRange(new object[] {
            "M",
            "F"});
            this.CBXSucursal.Location = new System.Drawing.Point(144, 35);
            this.CBXSucursal.Name = "CBXSucursal";
            this.CBXSucursal.Size = new System.Drawing.Size(222, 36);
            this.CBXSucursal.TabIndex = 14;
            this.CBXSucursal.SelectedIndexChanged += new System.EventHandler(this.CBXMunicipioFK_SelectedIndexChanged);
            // 
            // LBLSucursal
            // 
            this.LBLSucursal.AutoSize = true;
            this.LBLSucursal.Location = new System.Drawing.Point(31, 43);
            this.LBLSucursal.Name = "LBLSucursal";
            this.LBLSucursal.Size = new System.Drawing.Size(92, 28);
            this.LBLSucursal.TabIndex = 13;
            this.LBLSucursal.Text = "Sucursal";
            // 
            // BTNAgregar
            // 
            this.BTNAgregar.Location = new System.Drawing.Point(442, 83);
            this.BTNAgregar.Name = "BTNAgregar";
            this.BTNAgregar.Size = new System.Drawing.Size(118, 39);
            this.BTNAgregar.TabIndex = 4;
            this.BTNAgregar.Text = "Agregar";
            this.BTNAgregar.UseVisualStyleBackColor = true;
            this.BTNAgregar.Click += new System.EventHandler(this.BTNAgregarSucursal_Click);
            // 
            // TXTTotal
            // 
            this.TXTTotal.Location = new System.Drawing.Point(144, 270);
            this.TXTTotal.Name = "TXTTotal";
            this.TXTTotal.ReadOnly = true;
            this.TXTTotal.Size = new System.Drawing.Size(222, 36);
            this.TXTTotal.TabIndex = 2;
            // 
            // LBLTotal
            // 
            this.LBLTotal.AutoSize = true;
            this.LBLTotal.Location = new System.Drawing.Point(31, 273);
            this.LBLTotal.Name = "LBLTotal";
            this.LBLTotal.Size = new System.Drawing.Size(93, 28);
            this.LBLTotal.TabIndex = 0;
            this.LBLTotal.Text = "Subtotal";
            // 
            // DGVTicket
            // 
            this.DGVTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTicket.Location = new System.Drawing.Point(141, 352);
            this.DGVTicket.Name = "DGVTicket";
            this.DGVTicket.Size = new System.Drawing.Size(524, 150);
            this.DGVTicket.TabIndex = 3;
            // 
            // ALTA_VENTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaCochera.Properties.Resources.FONDOHAMBURGUESA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.DGVTicket);
            this.Controls.Add(this.GBXAltaVenta);
            this.Name = "ALTA_VENTA";
            this.Text = "ALTA VENTA";
            this.GBXAltaVenta.ResumeLayout(false);
            this.GBXAltaVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTicket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBXAltaVenta;
        private System.Windows.Forms.ComboBox CBXSucursal;
        private System.Windows.Forms.Label LBLSucursal;
        private System.Windows.Forms.Button BTNAgregar;
        private System.Windows.Forms.TextBox TXTTotal;
        private System.Windows.Forms.Label LBLTotal;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.ComboBox CBXEmpleado;
        private System.Windows.Forms.Label LBLEmpleado;
        private System.Windows.Forms.ComboBox CBXProducto;
        private System.Windows.Forms.Label LBLProducto;
        private System.Windows.Forms.Label LBLPrecio;
        private System.Windows.Forms.TextBox TXTCantidad;
        private System.Windows.Forms.Label LBLCantidad;
        private System.Windows.Forms.DataGridView DGVTicket;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CBXVent;
    }
}