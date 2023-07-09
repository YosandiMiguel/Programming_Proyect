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
    public partial class frmPosiciones : Form
    {
        public frmPosiciones()
        {
            InitializeComponent();
        }

        private void frmPosiciones_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // esta preguntando si presionaste la tecla de escape
            {
                this.Close();  // cierra el formulario
            }
        }

        private void frmPosiciones_Load(object sender, EventArgs e)
        {
            this.Text = "Maestro de Puesto de trabajo";  // aqui cambio el titulo del formulario
            this.KeyPreview = true;  // habilita las teclas de funciones
        }

        private void txtPosicion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F4") // pregunta si haz presionado la tecla F4 
            {
                btnConsulta.PerformClick(); // ira a ejecutar el evento del boton btnConsulta y este cuando lo ejecute volvera aqui
            }
        }

        private void txtPosicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) // aqui esta preguntando que si la tecla presionada es igual a ENTER
            {
                e.Handled = true;
                if (txtPosicion.Text.Trim() != string.Empty) // Trim() suprime los espacio que estan a los lados del contenido del textbox
                {
                    txtNombre.Focus();  // Focus mueve el cursor hacia el boton indicado
                }
            }
        }

        private void txtPosicion_Leave(object sender, EventArgs e)
        {
            if (txtPosicion.Text.Trim() != string.Empty) // Trim() suprime los espacio que estan a los lados del contenido del textbox
            {
                BuscarPosicion();  // buscara la posicion en el metodo
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) // aqui esta preguntando que si la tecla presionada es igual a ENTER
            {
                e.Handled = true;

                if (txtNombre.Text.Trim() != string.Empty) // Trim() suprime los espacio que estan a los lados del contenido del textbox
                {
                    txtFabrica.Focus();  // Focus mueve el cursor hacia el textbox indicado
                }
            }
        }

        private void txtFabrica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) // aqui esta preguntando que si la tecla presionada es igual a ENTER
            {
                e.Handled = true;
                if (txtFabrica.Text.Trim() != string.Empty) // Trim() suprime los espacio que estan a los lados del contenido del textbox
                {
                    btnGuardar.Focus();  // Focus mueve el cursor hacia el boton indicado
                }
            }
        }

        private void txtFabrica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F4") // pregunta si haz presionado la tecla F4 
            {
                btnFabrica.PerformClick(); // ira a ejecutar el evento del boton btnConsulta y este cuando lo ejecute volvera aqui
            }
        }

        private void txtFabrica_Leave(object sender, EventArgs e)
        {
            if (txtFabrica.Text.Trim() != string.Empty)
            {
                lblFabrica.Text = Busco.Fabricas(txtFabrica.Text);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPosicion.Text.Trim() != string.Empty)
            {
                if (txtNombre.Text.Trim() != string.Empty)
                {
                        GuardarInformacion();
                        LimpiarFormulario();
                        txtPosicion.Focus();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtPosicion.Text.Trim() != string.Empty)
            {
                if (txtNombre.Text.Trim() != string.Empty)
                {
                    BorrarUsuario(txtPosicion.Text);
                    LimpiarFormulario();
                    txtPosicion.Focus();
                }
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            txtPosicion.Focus();  // envia el cursor a ese textbox

            frmVENPOS frm = new frmVENPOS();  // se crea un objeto que representa al formulario 
            DialogResult res = frm.ShowDialog();   // muestra el formulario emergente es decir la consulta que llamamos a dar click en el boton

            //if (res == DialogResult.OK)  // aqui pregunta si la variable res tiene un de OK
            //{
                txtPosicion.Text = frm._varf1; // asigna el valor contenido en la variable varf1 segun la linea presionada en la consulta
                txtNombre.Text = frm._varf2; // asigna el valor contenido en la variable varf2 segun la linea presionada en la consulta
            //}
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarFormulario()
        {
            txtPosicion.Clear();
            txtNombre.Clear();
            txtPosicion.Focus();
        }

        private void BuscarPosicion()
        {
            SqlConnection cnxn = new SqlConnection(cnn.db); // le indica la conexion o la ruta a la base de datos
            cnxn.Open(); // abre la base de datos

            SqlCommand cmnd = new SqlCommand("SELECT IDPOSICION, NOMBREDEPOSICION " +
                                             "  FROM POSICIONES " +
                                             " WHERE IDPOSICION = @PV", cnxn);
            cmnd.Parameters.AddWithValue("@PV", txtPosicion.Text);
            SqlDataReader datos = cmnd.ExecuteReader(); // ejecuta el script de sql para lectura

            if (datos.Read())  // pregunta si trajo datos
            {
                txtPosicion.Text = Convert.ToString(datos["IDPOSICION"]);
                txtNombre.Text = Convert.ToString(datos["NOMBREDEPOSICION"]);
            }

            cmnd.Dispose();
            cnxn.Close();
        }

        private void GuardarInformacion()
        {
            SqlConnection cnxn = new SqlConnection(cnn.db); // le indica la conexion o la ruta a la base de datos
            cnxn.Open(); // abre la base de datos

            string stQuery = "INSERT INTO POSICIONES (IDPOSICION, NOMBREDEPOSICION) VALUES (@A1, @A2)";
            SqlCommand miQueri = new SqlCommand(stQuery, cnxn);
            miQueri.Parameters.AddWithValue("@A1", txtPosicion.Text);
            miQueri.Parameters.AddWithValue("@A2", txtNombre.Text);

            miQueri.ExecuteNonQuery();

            cnxn.Close();
        }

        private void BorrarUsuario(string nUser)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db); // le indica la conexion o la ruta a la base de datos
            cnxn.Open(); // abre la base de datos

            SqlCommand borrar = new SqlCommand("DELETE FROM POSICIONES WHERE IDPOSICION=@PV", cnxn);
            borrar.Parameters.AddWithValue("@PV", nUser);
            borrar.ExecuteNonQuery();

            cnxn.Close();
        }


    }
}
