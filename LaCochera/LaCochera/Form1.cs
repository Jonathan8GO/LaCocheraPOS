using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaCochera
{
    public partial class LaCochera : Form
    {
        public LaCochera()
        {
            InitializeComponent();
        }

        private void CONSULTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONSULTA_VENTA ventanaConsultaVenta = new CONSULTA_VENTA();
            ventanaConsultaVenta.Show();
        }

        private void PRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void AltaProdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ALTA_PRODUCTO ventanaAltaProd = new ALTA_PRODUCTO();
            ventanaAltaProd.ShowDialog();
        }

        private void BajaProdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BAJA_PRODUCTO ventanaBajaProd = new BAJA_PRODUCTO();
            ventanaBajaProd.ShowDialog();
        }

        private void ConsultaProdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CONSULTA_PRODUCTO ventanaConsultaProd = new CONSULTA_PRODUCTO();
            ventanaConsultaProd.Show();
        }

        private void AltaVentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ALTA_VENTA ventanaAltaVenta = new ALTA_VENTA();
            ventanaAltaVenta.ShowDialog();
        }

        private void AltaEmpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ALTA_EMPLEADO ventanaAltaEmp = new ALTA_EMPLEADO();
            ventanaAltaEmp.ShowDialog();
        }

        private void BajaEmpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BAJA_EMPLEADO ventanaBajaEmp = new BAJA_EMPLEADO();
            ventanaBajaEmp.ShowDialog();
        }

        private void ConsultaEmpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CONSULTA_EMPLEADO ventanaConsultaEmp = new CONSULTA_EMPLEADO();
            ventanaConsultaEmp.Show();
        }

        private void AltaSucToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ALTA_SUCURSAL ventanaAltaSuc = new ALTA_SUCURSAL();
            ventanaAltaSuc.ShowDialog();
        }

        private void ConsultaSucToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CONSULTA_SUCURSAL ventanaConsultaSuc = new CONSULTA_SUCURSAL();
            ventanaConsultaSuc.ShowDialog();
        }
    }
}
