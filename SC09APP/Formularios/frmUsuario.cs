using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;

namespace SC09APP
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // esta preguntando si presionaste la tecla de escape
            {
                this.Close();  // cierra el formulario
            }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            this.Text = "Maestro de Usuario Seccion";  // aqui cambio el titulo del formulario
            this.KeyPreview = true;  // habilita las teclas de funciones
        }

        // ---------------------------------------------------------
        // textbox Usuario
        // ---------------------------------------------------------
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F4") // pregunta si haz presionado la tecla F4 
            {
                btnConsulta.PerformClick(); // ira a ejecutar el evento del boton btnConsulta y este cuando lo ejecute volvera aqui
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) // aqui esta preguntando que si la tecla presionada es igual a ENTER
            {
                e.Handled = true;
                if (txtUsuario.Text.Trim() != string.Empty) // Trim() suprime los espacio que estan a los lados del contenido del textbox
                {
                    txtNombre.Focus();  // Focus mueve el cursor hacia el textbox indicado
                }
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != string.Empty) // Trim() suprime los espacio que estan a los lados del contenido del textbox
            {
                BuscarUsuario();  // buscara el usuario en el metodo
            }
        }

        // ---------------------------------------------------------
        // textbox Nombre
        // ---------------------------------------------------------
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) // aqui esta preguntando que si la tecla presionada es igual a ENTER
            {
                e.Handled = true;

                if (txtNombre.Text.Trim() != string.Empty) // Trim() suprime los espacio que estan a los lados del contenido del textbox
                {
                    txtPassword.Focus();  // Focus mueve el cursor hacia el textbox indicado
                }
            }
        }

        // ---------------------------------------------------------
        // textbox password
        // ---------------------------------------------------------
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) // aqui esta preguntando que si la tecla presionada es igual a ENTER
            {
                e.Handled = true;

                if (txtPassword.Text.Trim() != string.Empty) // Trim() suprime los espacio que estan a los lados del contenido del textbox
                {
                    btnGuardar.Focus();  // Focus mueve el cursor hacia el boton indicado
                }
            }
        }

        private void txtPosicion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F4") // pregunta si haz presionado la tecla F4 
            {
                btnPosicion.PerformClick(); // ira a ejecutar el evento del boton btnConsulta y este cuando lo ejecute volvera aqui
            }
        }

        private void txtPosicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) // aqui esta preguntando que si la tecla presionada es igual a ENTER
            {
                e.Handled = true;
                if (txtPosicion.Text.Trim() != string.Empty) // Trim() suprime los espacio que estan a los lados del contenido del textbox
                {
                    btnGuardar.Focus();  // Focus mueve el cursor hacia el boton indicado
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

        

        // ------------------------------------------------------
        // AQUI VAN LOS BOTONES
        // ------------------------------------------------------
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            txtUsuario.Focus();  // envia el cursor a ese textbox

            frmVENUUSER frm = new frmVENUUSER();  // se crea un objeto que representa al formulario 
            DialogResult res = frm.ShowDialog();   // muestra el formulario emergente es decir la consulta que llamamos a dar click en el boton

            if (res == DialogResult.OK)  // aqui pregunta si la variable res tiene un de OK
            {
                txtUsuario.Text = frm.varf1; // asigna el valor contenido en la variable varf1 segun la linea presionada en la consulta
                txtNombre.Text = frm.varf2; // asigna el valor contenido en la variable varf2 segun la linea presionada en la consulta

                BuscarUsuario();
            }
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            txtPosicion.Focus();  // envia el cursor a ese textbox

            frmVENPOS frm = new frmVENPOS();  // se crea un objeto que representa al formulario 
            DialogResult res = frm.ShowDialog();   // muestra el formulario emergente es decir la consulta que llamamos a dar click en el boton

            if (res == DialogResult.OK)  // aqui pregunta si la variable res tiene un de OK
            {
                txtPosicion.Text = frm._varf1; // asigna el valor contenido en la variable varf1 segun la linea presionada en la consulta
                lblPosicion.Text = frm._varf2; // asigna el valor contenido en la variable varf2 segun la linea presionada en la consulta
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != string.Empty)
            {
                if (txtNombre.Text.Trim() != string.Empty)
                {
                    if (txtPassword.Text.Trim() != string.Empty)
                    {
                        GuardarInformacion();
                        LimpiarFormulario();
                        txtUsuario.Focus();
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();  // ejecutara este metodo
            txtUsuario.Focus();  // devuelve el cursor al textbox usuario
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != string.Empty)
            {
                if (txtNombre.Text.Trim() != string.Empty)
                {
                    BorrarUsuario(txtUsuario.Text);
                    LimpiarFormulario();
                    txtUsuario.Focus();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ------------------------------------------------------
        // AQUI LOS METODOS
        // ------------------------------------------------------


        private void GuardarInformacion()
        {
            SqlConnection cnxn = new SqlConnection(cnn.db); // le indica la conexion o la ruta a la base de datos
            cnxn.Open(); // abre la base de datos

            string stQuery = "INSERT INTO USUARIO (NOMBRECORTO, NOMBRECOMPLETO, CORREO, PASSWORD) VALUES (@A1, @A2, @A3, @A4)";
            SqlCommand miQueri = new SqlCommand(stQuery, cnxn);
            miQueri.Parameters.AddWithValue("@A1", txtUsuario.Text);
            miQueri.Parameters.AddWithValue("@A2", txtNombre.Text);
            miQueri.Parameters.AddWithValue("@A3", txtCorreo.Text);
            miQueri.Parameters.AddWithValue("@A4", txtPassword.Text);

            miQueri.ExecuteNonQuery();

            cnxn.Close();
        }

        private void BorrarUsuario(string nUser)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db); // le indica la conexion o la ruta a la base de datos
            cnxn.Open(); // abre la base de datos

            SqlCommand borrar = new SqlCommand("DELETE FROM USUARIO WHERE NOMBRECORTO=@PV", cnxn);
            borrar.Parameters.AddWithValue("@PV", nUser);
            borrar.ExecuteNonQuery();

            cnxn.Close();
        }

        private void BuscarUsuario()
        {
            SqlConnection cnxn = new SqlConnection(cnn.db); // le indica la conexion o la ruta a la base de datos
            cnxn.Open(); // abre la base de datos

            SqlCommand cmnd = new SqlCommand("SELECT * " +
                                             "  FROM USUARIO " +
                                             " WHERE ACTIVO = 'TRUE' " +
                                             "   AND NOMBRECORTO = @PV", cnxn);
            cmnd.Parameters.AddWithValue("@PV", txtUsuario.Text);
            SqlDataReader datos = cmnd.ExecuteReader(); // ejecuta el script de sql para lectura

            if (datos.Read())  // pregunta si trajo datos
            {
                txtUsuario.Text = Convert.ToString(datos["NOMBRECORTO"]);
                txtNombre.Text = Convert.ToString(datos["NOMBRECOMPLETO"]);
                txtCorreo.Text = Convert.ToString(datos["CORREO"]);
                txtPassword.Text = Convert.ToString(datos["PASSWORD"]);
            }

            cmnd.Dispose();
            cnxn.Close();
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
                lblPosicion.Text = Convert.ToString(datos["NOMBREDEPOSICION"]);
            }

            cmnd.Dispose();
            cnxn.Close();
        }

        private void LimpiarFormulario()
        {
            txtUsuario.Clear();
            txtNombre.Clear();
            txtPassword.Clear();
        }

        
    }
}
