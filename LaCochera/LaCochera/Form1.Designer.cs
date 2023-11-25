namespace LaCochera
{
    partial class LaCochera
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AltaProdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BajaProdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ConsultaProdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AltaVentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ConsultaVentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AltaEmpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.BajaEmpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ConsultaEmpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AltaSucToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.ConsultaSucToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductosToolStripMenuItem,
            this.VentasToolStripMenuItem,
            this.EmpleadosToolStripMenuItem,
            this.SucursalesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "MenuStrip";
            // 
            // ProductosToolStripMenuItem
            // 
            this.ProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AltaProdToolStripMenuItem,
            this.toolStripSeparator1,
            this.BajaProdToolStripMenuItem,
            this.toolStripSeparator2,
            this.ConsultaProdToolStripMenuItem});
            this.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem";
            this.ProductosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.ProductosToolStripMenuItem.Text = "PRODUCTOS";
            this.ProductosToolStripMenuItem.Click += new System.EventHandler(this.PRODUCTOSToolStripMenuItem_Click);
            // 
            // AltaProdToolStripMenuItem
            // 
            this.AltaProdToolStripMenuItem.Image = global::LaCochera.Properties.Resources.ALTA;
            this.AltaProdToolStripMenuItem.Name = "AltaProdToolStripMenuItem";
            this.AltaProdToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.AltaProdToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.AltaProdToolStripMenuItem.Text = "ALTA";
            this.AltaProdToolStripMenuItem.Click += new System.EventHandler(this.AltaProdToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // BajaProdToolStripMenuItem
            // 
            this.BajaProdToolStripMenuItem.Image = global::LaCochera.Properties.Resources.BAJA;
            this.BajaProdToolStripMenuItem.Name = "BajaProdToolStripMenuItem";
            this.BajaProdToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.BajaProdToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.BajaProdToolStripMenuItem.Text = "MODIFICAR";
            this.BajaProdToolStripMenuItem.Click += new System.EventHandler(this.BajaProdToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(179, 6);
            // 
            // ConsultaProdToolStripMenuItem
            // 
            this.ConsultaProdToolStripMenuItem.Image = global::LaCochera.Properties.Resources.CONSULTAR;
            this.ConsultaProdToolStripMenuItem.Name = "ConsultaProdToolStripMenuItem";
            this.ConsultaProdToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.ConsultaProdToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ConsultaProdToolStripMenuItem.Text = "CONSULTAR";
            this.ConsultaProdToolStripMenuItem.Click += new System.EventHandler(this.ConsultaProdToolStripMenuItem_Click);
            // 
            // VentasToolStripMenuItem
            // 
            this.VentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AltaVentToolStripMenuItem,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.ConsultaVentToolStripMenuItem});
            this.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem";
            this.VentasToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.VentasToolStripMenuItem.Text = "VENTAS";
            // 
            // AltaVentToolStripMenuItem
            // 
            this.AltaVentToolStripMenuItem.Image = global::LaCochera.Properties.Resources.ALTA;
            this.AltaVentToolStripMenuItem.Name = "AltaVentToolStripMenuItem";
            this.AltaVentToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.AltaVentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AltaVentToolStripMenuItem.Text = "ALTA";
            this.AltaVentToolStripMenuItem.Click += new System.EventHandler(this.AltaVentToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(155, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(155, 6);
            // 
            // ConsultaVentToolStripMenuItem
            // 
            this.ConsultaVentToolStripMenuItem.Image = global::LaCochera.Properties.Resources.CONSULTAR;
            this.ConsultaVentToolStripMenuItem.Name = "ConsultaVentToolStripMenuItem";
            this.ConsultaVentToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.ConsultaVentToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ConsultaVentToolStripMenuItem.Text = "CONSULTA";
            this.ConsultaVentToolStripMenuItem.Click += new System.EventHandler(this.CONSULTAToolStripMenuItem_Click);
            // 
            // EmpleadosToolStripMenuItem
            // 
            this.EmpleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AltaEmpToolStripMenuItem,
            this.toolStripSeparator5,
            this.BajaEmpToolStripMenuItem2,
            this.toolStripSeparator6,
            this.ConsultaEmpToolStripMenuItem1});
            this.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem";
            this.EmpleadosToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.EmpleadosToolStripMenuItem.Text = "EMPLEADOS";
            // 
            // AltaEmpToolStripMenuItem
            // 
            this.AltaEmpToolStripMenuItem.Image = global::LaCochera.Properties.Resources.ALTA;
            this.AltaEmpToolStripMenuItem.Name = "AltaEmpToolStripMenuItem";
            this.AltaEmpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.AltaEmpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AltaEmpToolStripMenuItem.Text = "ALTA";
            this.AltaEmpToolStripMenuItem.Click += new System.EventHandler(this.AltaEmpToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(168, 6);
            // 
            // BajaEmpToolStripMenuItem2
            // 
            this.BajaEmpToolStripMenuItem2.Image = global::LaCochera.Properties.Resources.BAJA;
            this.BajaEmpToolStripMenuItem2.Name = "BajaEmpToolStripMenuItem2";
            this.BajaEmpToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.BajaEmpToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.BajaEmpToolStripMenuItem2.Text = "MODIFICAR";
            this.BajaEmpToolStripMenuItem2.Click += new System.EventHandler(this.BajaEmpToolStripMenuItem2_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(168, 6);
            // 
            // ConsultaEmpToolStripMenuItem1
            // 
            this.ConsultaEmpToolStripMenuItem1.Image = global::LaCochera.Properties.Resources.CONSULTAR;
            this.ConsultaEmpToolStripMenuItem1.Name = "ConsultaEmpToolStripMenuItem1";
            this.ConsultaEmpToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.ConsultaEmpToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ConsultaEmpToolStripMenuItem1.Text = "CONSULTA";
            this.ConsultaEmpToolStripMenuItem1.Click += new System.EventHandler(this.ConsultaEmpToolStripMenuItem1_Click);
            // 
            // SucursalesToolStripMenuItem
            // 
            this.SucursalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AltaSucToolStripMenuItem1,
            this.toolStripSeparator7,
            this.toolStripSeparator8,
            this.ConsultaSucToolStripMenuItem2});
            this.SucursalesToolStripMenuItem.Name = "SucursalesToolStripMenuItem";
            this.SucursalesToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.SucursalesToolStripMenuItem.Text = "SUCURSALES";
            // 
            // AltaSucToolStripMenuItem1
            // 
            this.AltaSucToolStripMenuItem1.Image = global::LaCochera.Properties.Resources.ALTA;
            this.AltaSucToolStripMenuItem1.Name = "AltaSucToolStripMenuItem1";
            this.AltaSucToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.AltaSucToolStripMenuItem1.Text = "ALTA";
            this.AltaSucToolStripMenuItem1.Click += new System.EventHandler(this.AltaSucToolStripMenuItem1_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(130, 6);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(130, 6);
            // 
            // ConsultaSucToolStripMenuItem2
            // 
            this.ConsultaSucToolStripMenuItem2.Image = global::LaCochera.Properties.Resources.CONSULTAR;
            this.ConsultaSucToolStripMenuItem2.Name = "ConsultaSucToolStripMenuItem2";
            this.ConsultaSucToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.ConsultaSucToolStripMenuItem2.Text = "CONSULTA";
            this.ConsultaSucToolStripMenuItem2.Click += new System.EventHandler(this.ConsultaSucToolStripMenuItem2_Click);
            // 
            // BTNSalir
            // 
            this.BTNSalir.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSalir.Location = new System.Drawing.Point(556, 137);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(105, 39);
            this.BTNSalir.TabIndex = 1;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // LaCochera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LaCochera.Properties.Resources.FONDOHAMBURGUESA;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LaCochera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "La Cochera";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AltaProdToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem BajaProdToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ConsultaProdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AltaVentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultaVentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SucursalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem AltaEmpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem BajaEmpToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem ConsultaEmpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AltaSucToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem ConsultaSucToolStripMenuItem2;
        private System.Windows.Forms.Button BTNSalir;
    }
}

