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
    public partial class ALTA_VENTA : Form
    {    
        public ALTA_VENTA()
        {
            InitializeComponent();

            CBXSucursal.DataSource = null;
            CBXSucursal.Items.Clear();
            SucursalesDAO objSuc = new SucursalesDAO();
            DataTable tablaSuc = new DataTable();
            objSuc.ConsultarSucursales().Fill(tablaSuc);
            CBXSucursal.DataSource = tablaSuc;
            CBXSucursal.DisplayMember = "NOMBRE_SUC";
            CBXSucursal.ValueMember = "ID_SUCURSAL";

            CBXEmpleado.DataSource = null;
            CBXEmpleado.Items.Clear();
            EmpleadosDAO objEmp = new EmpleadosDAO();
            DataTable tablaEmp = new DataTable();
            objEmp.ConsultarActivosEmp().Fill(tablaEmp);
            CBXEmpleado.DataSource = tablaEmp;
            CBXEmpleado.DisplayMember = "NOMBRE COMPLETO";
            CBXEmpleado.ValueMember = "NO_EMPLEADO";
            


            CBXProducto.DataSource = null;
            CBXProducto.Items.Clear();
            ProductosDAO objProd = new ProductosDAO();
            DataTable tablaProd = new DataTable();
            objProd.ConsultarExistProd().Fill(tablaProd);
            CBXProducto.DataSource = tablaProd;
            CBXProducto.DisplayMember = "NOMBRE";
            CBXProducto.ValueMember = "ID_PRODUCTO";
            comboBox1.DataSource = tablaProd;
            comboBox1.DisplayMember = "PRECIO";
            comboBox1.ValueMember = "PRECIO";

            CBXVent.DataSource = null;
            CBXVent.Items.Clear();
            VentasDAO objVen = new VentasDAO();
            DataTable tablaVen = new DataTable();
            objVen.ConsultarVenta().Fill(tablaVen);
            CBXVent.DataSource = tablaVen;
            CBXVent.DisplayMember = "ID_VENTA";
            CBXVent.ValueMember = "ID_VENTA";

        }


        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CBXMunicipioFK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GBXAltaSucursal_Enter(object sender, EventArgs e)
        {

        }

        private void BTNAgregarSucursal_Click(object sender, EventArgs e)
        {

            VentasModel modelVent = new VentasModel();
            modelVent.IdSucursal = Convert.ToInt32(CBXSucursal.SelectedValue.ToString());
            modelVent.IdEmpleado = Convert.ToInt32(CBXEmpleado.SelectedValue.ToString());

          /* TicketModel modelTick = new TicketModel();
            modelTick.IdProducto = Convert.ToInt32(CBXProducto.SelectedValue.ToString());
            modelTick.PrecioProducto = Convert.ToInt32(comboBox1.Text); 
            int cantidadProd = Convert.ToInt32(TXTCantidad.Text);
            modelTick.Cantidad = cantidadProd;
            int total = (cantidadProd * Convert.ToInt32(comboBox1.Text));
            */

          //  modelVent.TotalVenta = total;            

           // TXTTotal.Text = total.ToString();
            
            VentasDAO objVent = new VentasDAO();
            //TicketDAO objTick = new TicketDAO();
            int resVent = objVent.InsertarVent(modelVent);           
            //int resTick = objTick.InsertarTick(modelTick);


            if (resVent == 1 )
            {
                MessageBox.Show("CORRECTO - VENTA");

            }
         else
            {
                MessageBox.Show("FALLÓ VENTA");
            }


            /*DataTable tabla = new DataTable();
            objTick.ConsultarTicket().Fill(tabla);
            DGVTicket.DataSource = tabla;
            */
        }

        private void Button1_Click(object sender, EventArgs e)
        {


        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

            TicketModel modelTick = new TicketModel();
            modelTick.IdVenta = Convert.ToInt32(CBXVent.SelectedValue.ToString());
            modelTick.IdProducto = Convert.ToInt32(CBXProducto.SelectedValue.ToString());
            modelTick.PrecioProducto = Convert.ToDouble(comboBox1.Text);
            int cantidadProd = Convert.ToInt32(TXTCantidad.Text);
            modelTick.Cantidad = cantidadProd;
            int total = (cantidadProd * Convert.ToInt32(comboBox1.Text));
            modelTick.TotalTick = total;
            TXTTotal.Text = total.ToString();

            TicketDAO objTick = new TicketDAO();
            int resTick = objTick.InsertarTick(modelTick);
            


            if (resTick == 1)
            {
                MessageBox.Show("CORRECTO - TICKET");

                DataTable tabla = new DataTable();
                objTick.ConsultarTicket().Fill(tabla);
                DGVTicket.DataSource = tabla;

            }
            else
            {
                MessageBox.Show("FALLÓ TICKET");
            }

        }
    }

    }

