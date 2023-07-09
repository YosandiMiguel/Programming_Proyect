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
    public partial class frmVENITEM : Form
    {
        public string varf1; // variable publica usada para transportar la data elegida al dar doble click en la grilla
        public string varf2; // variable publica usada para transportar la data elegida al dar doble click en la grilla

        public frmVENITEM()
        {
            InitializeComponent();
        }

        private void frmVENITEM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // esta preguntando si presionaste la tecla de escape
            {
                this.Close();  // cierra el formulario
            }
        }

        private void frmVENITEM_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; // activa las teclas de funciones

            Estilodgv();  // hace un llamado a esta funcion
        }

        private void Estilodgv()
        {
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersVisible = true;
            this.dgv.RowHeadersVisible = false;

            this.dgv.Columns.Add("Col00", "Item");
            this.dgv.Columns.Add("Col01", "Descripcion");

            DataGridViewColumn
            column = dgv.Columns[0]; column.Width = 150;  // le esta indicando el ancho de la columna
            column = dgv.Columns[1]; column.Width = 600;  // le esta indicando el ancho de la columna

            // dgv es el nombre de la grilla
            this.dgv.BorderStyle = BorderStyle.None;
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            this.dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            this.dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            this.dgv.BackgroundColor = Color.LightGray;

            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 6, 0, 6);
            this.dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
            this.dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) // aqui esta preguntando que si la tecla presionada es igual a ENTER
            {
                e.Handled = true;
                if (txtBuscar.Text.Trim() != string.Empty) // Trim() suprime los espacio que estan a los lados del contenido del textbox
                {
                    btnBuscar.PerformClick();  // Focus mueve el cursor hacia el textbox indicado
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarDatos();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            { //Data grid View 
                varf1 = dgv.CurrentRow.Cells[0].Value.ToString();  // selecciona el valor contenido en la celda actual de la columna 0 de la fila seleccionada
                varf2 = dgv.CurrentRow.Cells[1].Value.ToString();  // selecciona el valor contenido en la celda actual de la columna 1 de la fila seleccionada

                this.Close();
            }
            catch
            {
                //
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSeleccionar.PerformClick();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarDatos()
        {
            // dgv es el nombre de la grilla  
            this.dgv.Rows.Clear();  // Limpia la grilla
            this.dgv.Refresh();     // actualiza la grilla

            SqlConnection conexion = new SqlConnection(cnn.db);
            conexion.Open();   // abre la conexion a la Base de Datos
            SqlCommand sqCmd = new SqlCommand("SELECT ITEM, DESCRIPCION "
                                            + "  FROM PRODUCTOS "
                                            + " WHERE DESCRIPCION LIKE '%" + txtBuscar.Text + "%'"
                                            + " ORDER BY DESCRIPCION ASC", conexion);
            SqlDataReader recordset = sqCmd.ExecuteReader();

            try
            {
                while (recordset.Read())
                {  // no es fin de archivo true false
                    dgv.Rows.Add();                                                          // aqui le suma 1 a la fila, es decir x = x + 1 
                    int xRows = dgv.Rows.Count - 1;                                          // aqui le resto 1 para me indique la fila correcta en donde estoy

                    dgv[0, xRows].Value = Convert.ToString(recordset["ITEM"]);         // escribe en la grilla, en la celda 0 y en la fila (x), el contenido del campo IDDEPARTAMENTO     de la tabla DEPARTAMENTO
                    dgv[1, xRows].Value = Convert.ToString(recordset["DESCRIPCION"]);   // escribe en la grilla, en la celda 1 y en la fila (x), el contenido del campo NOMBREDEPARTAMENTO de la tabla DEPARTAMENTO
                }
            }
            catch
            {
                //
            }

            sqCmd.Dispose();    // libera el espacio de memoria ocupado con la data recopilada
            conexion.Close();   // cierra la conexion a la base de datos
        }
    }
}
