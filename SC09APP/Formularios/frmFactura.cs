using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace SC09APP
{
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            this.Text = "Factura Cliente";  // aqui cambio el titulo del formulario
            this.KeyPreview = true;  // habilita las teclas de funciones

            // -------------------------------------------------------
            // agregamos la data al combobox
            // -------------------------------------------------------
            List<Item> lista = new List<Item>();  // creamos un contenedor el cual le colocaremos la data para el comboBox

            lista.Add(new Item("Si", 0));    // agrega este item a la lista
            lista.Add(new Item("No", 1));

            cboLibreImpuesto.Text = "Si";

            cboLibreImpuesto.DisplayMember = "Name";  // por aqui recibe/envia el nombre
            cboLibreImpuesto.ValueMember = "Value";   // por aqui recibe/envia el indice
            cboLibreImpuesto.DataSource = lista;      // le insertamos la data al comboBox
        }

        private void frmFactura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // esta preguntando si presionaste la tecla de escape
            {
                this.Close();  // cierra el formulario
            }
        }

        // ----------------------------------------------------
        // TextBox
        // ----------------------------------------------------
        private void txtCliente_Leave(object sender, EventArgs e)
        {
            if (txtCliente.Text.Trim() != string.Empty) // Trim() suprime los espacio que estan a los lados del contenido del textbox
            {
               lblNombreCliente.Text = Busco.Clientes(txtCliente.Text);  // buscara EL Nombre del cliente
            }
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) // aqui esta preguntando que si la tecla presionada es igual a ENTER
            {
                e.Handled = true;
                if (txtCliente.Text.Trim() != string.Empty) // Trim() suprime los espacio que estan a los lados del contenido del textbox
                {
                    txtRNC.Focus();  // Focus mueve el cursor hacia el textbox indicado
                }
            }
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F4") // pregunta si haz presionado la tecla F4 
            {
                btnCliente.PerformClick(); // ira a ejecutar el evento del boton btnConsulta y este cuando lo ejecute volvera aqui
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            txtCliente.Focus();  // envia el cursor a ese textbox

            frmVENCTE frm = new frmVENCTE();  // se crea un objeto que representa al formulario 
            DialogResult res = frm.ShowDialog();   // muestra el formulario emergente es decir la consulta que llamamos a dar click en el boton

            if (res == DialogResult.OK)  // aqui pregunta si la variable res tiene un de OK
            {
                txtCliente.Text = frm.varf1; // asigna el valor contenido en la variable varf1 segun la linea presionada en la consulta
                lblNombreCliente.Text = frm.varf2; // asigna el valor contenido en la variable varf2 segun la linea presionada en la consulta
            }
        }

        private void txtRNC_Leave(object sender, EventArgs e)
        {
            if (txtRNC.Text.Trim() != string.Empty) // Trim() suprime los espacio que estan a los lados del contenido del textbox
            {
                //lblNombreCliente.Text = Busco.RNC(txtCliente.Text);  // buscara EL Nombre del cliente
            }
        }

        private void txtRNC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) // aqui esta preguntando que si la tecla presionada es igual a ENTER
            {
                e.Handled = true;
                if (txtRNC.Text.Trim() != string.Empty) // Trim() suprime los espacio que estan a los lados del contenido del textbox
                {
                    cboLibreImpuesto.Focus();  // Focus mueve el cursor hacia el textbox indicado
                }
            }
        }


        // ----------------------------------------------------
        // Botones
        // ----------------------------------------------------
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            txtItem.Focus();  // envia el cursor a ese textbox

            frmVENITEM frm = new frmVENITEM();  // se crea un objeto que representa al formulario 
            DialogResult res = frm.ShowDialog();   // muestra el formulario emergente es decir la consulta que llamamos a dar click en el boton

            if (res == DialogResult.OK)  // aqui pregunta si la variable res tiene un de OK
            {
                txtItem.Text = frm.varf1; // asigna el valor contenido en la variable varf1 segun la linea presionada en la consulta
                lblDescripcion.Text = frm.varf2; // asigna el valor contenido en la variable varf2 segun la linea presionada en la consulta
            }
        }
    }
}
