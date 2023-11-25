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
    public partial class BAJA_EMPLEADO : Form
    {
        public BAJA_EMPLEADO()
        {
            InitializeComponent();
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BTNBajaEmp_Click(object sender, EventArgs e)
        {
            EmpleadosModel modelEmp= new EmpleadosModel();
            modelEmp.IdEmpleado = Convert.ToInt32(TXTIDEmpBaja.Text);
            EmpleadosDAO objEmpleado = new EmpleadosDAO();
            int Res = objEmpleado.BajaEmp(modelEmp);
            if (Res == 1)
            {
                MessageBox.Show("Producto Eliminado");
            }
            else
            {
                MessageBox.Show("ERROR AL ELIMINAR EMPLEADO");
            }
        }
    }
}
