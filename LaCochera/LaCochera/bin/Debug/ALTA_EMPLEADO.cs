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
    public partial class ALTA_EMPLEADO : Form
    {
        public ALTA_EMPLEADO()
        {
            InitializeComponent();

            CBXSexoEmp.Items.Clear();

            ItemsCBX itemHombre = new ItemsCBX();
            itemHombre.Text = "MASCULINO";
            itemHombre.Value = "M";
            CBXSexoEmp.Items.Add(itemHombre);

            ItemsCBX itemMujer = new ItemsCBX();
            itemMujer.Text = "FEMENINO";
            itemMujer.Value = "F";
            CBXSexoEmp.Items.Add(itemMujer);



            CBXSucursalFK.DataSource = null;
            CBXSucursalFK.Items.Clear();
            SucursalesDAO objSuc = new SucursalesDAO();
            DataTable tabla = new DataTable();
            objSuc.ConsultarSucursales().Fill(tabla);
            CBXSucursalFK.DataSource = tabla;
            CBXSucursalFK.DisplayMember = "NOMBRE_SUC";
            CBXSucursalFK.ValueMember = "ID_SUCURSAL";

        }

        private void GBXAltaProd_Enter(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BTNAgregarEmp_Click(object sender, EventArgs e)
        {

            EmpleadosModel modelEmp = new EmpleadosModel();
            modelEmp.NombreEmpleado = (TXTNombreEmp.Text).ToUpper();
            modelEmp.ApPaterno = (TXTPaternoEmp.Text).ToUpper();
            modelEmp.ApMaterno = (TXTMaternoEmp.Text).ToUpper();
            modelEmp.EdadEmpleado = Convert.ToInt32(TXTEdadEmp.Text);
            modelEmp.SexoEmpleado = (CBXSexoEmp.SelectedItem as ItemsCBX).Value.ToString();
            modelEmp.IdSucursal = Convert.ToInt32(CBXSucursalFK.SelectedValue.ToString());
            EmpleadosDAO objEmpleado = new EmpleadosDAO();
            int res = objEmpleado.InsertarEmp(modelEmp);

            if (res == 1)
            {
                MessageBox.Show("Empleado Agregado");
            }
            else
            {
                MessageBox.Show("ERROR INSERCION DE EMPLEADO");
            }
        }

        private void CBXSexoEmp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
