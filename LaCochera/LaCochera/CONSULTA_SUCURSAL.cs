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
    public partial class CONSULTA_SUCURSAL : Form
    {
        public CONSULTA_SUCURSAL()
        {
            InitializeComponent();
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BTNVConsultaSuc_Click(object sender, EventArgs e)
        {
            SucursalesDAO objSucursales = new SucursalesDAO();
            DataTable tabla = new DataTable();
            objSucursales.ConsultarSucursales().Fill(tabla);
            DGVSucursales.DataSource = tabla;
        }
    }
}
