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
    public partial class CONSULTA_EMPLEADO : Form
    {
        public CONSULTA_EMPLEADO()
        {
            InitializeComponent();
        }

        private void DGVEmpActivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BTNEmpActivos_Click(object sender, EventArgs e)
        {
            EmpleadosDAO objEmpleados = new EmpleadosDAO();
            DataTable tabla = new DataTable();
            objEmpleados.ConsultarActivosEmp().Fill(tabla);
            DGVEmpActivos.DataSource = tabla;
        }

        private void BTNEmpInactivos_Click(object sender, EventArgs e)
        {
            EmpleadosDAO objEmpleados = new EmpleadosDAO();
            DataTable tabla = new DataTable();
            objEmpleados.ConsultarInactivosEmp().Fill(tabla);
            DGVEmpInactivos.DataSource = tabla;
        }
    }
}
