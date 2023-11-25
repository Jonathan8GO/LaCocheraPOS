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
    public partial class ALTA_SUCURSAL : Form
    {
        public ALTA_SUCURSAL()
        {
            InitializeComponent();

            CBXMunicipioFK.DataSource = null;
            CBXMunicipioFK.Items.Clear();

            SucursalesDAO objSucursal = new SucursalesDAO();
            DataTable tabla = new DataTable();
            objSucursal.ConsultarMunicipios().Fill(tabla);
            CBXMunicipioFK.DataSource = tabla;
            CBXMunicipioFK.DisplayMember = "NOMBRE_MUNICIPIO";
            CBXMunicipioFK.ValueMember = "ID_MUNICIPIO";

        }

        private void TXTNombreProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBLSucursal_Click(object sender, EventArgs e)
        {

        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BTNAgregarSucursal_Click(object sender, EventArgs e)
        {
            SucursalesModel modelSuc = new SucursalesModel();
            modelSuc.NombreSucursal = (TXTNombreSucursal.Text).ToUpper();
            modelSuc.IdMunicipio = Convert.ToInt32(CBXMunicipioFK.SelectedValue.ToString());
            modelSuc.CalleSucursal = (TXTCalleSucursal.Text).ToUpper();

            SucursalesDAO objSuc = new SucursalesDAO();
            int res = objSuc.InsertarSuc(modelSuc);
            if (res == 1)
            {
                MessageBox.Show("Sucursal Agregada");
            }
            else
            {
                MessageBox.Show("ERROR EN INSERCION");
            }
        }





    }
}
