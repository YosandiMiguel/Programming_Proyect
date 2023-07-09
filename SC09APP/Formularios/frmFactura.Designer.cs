
namespace SC09APP
{
    partial class frmFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLimpiaDt = new System.Windows.Forms.Button();
            this.btnBorrarLn = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblSecuencia = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.txtRNC = new System.Windows.Forms.TextBox();
            this.cboLibreImpuesto = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblTotalLn = new System.Windows.Forms.Label();
            this.lblImpuestoLn = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.btnItem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(1136, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(147, 83);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.Location = new System.Drawing.Point(992, 0);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(147, 83);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.Location = new System.Drawing.Point(848, 0);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(147, 83);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Location = new System.Drawing.Point(704, 0);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(147, 83);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(704, 83);
            this.label1.TabIndex = 5;
            this.label1.Text = " Facturacion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnImprimir
            // 
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.Location = new System.Drawing.Point(1280, 0);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(147, 83);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 326);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1410, 250);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnLimpiaDt
            // 
            this.btnLimpiaDt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiaDt.Location = new System.Drawing.Point(300, 582);
            this.btnLimpiaDt.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiaDt.Name = "btnLimpiaDt";
            this.btnLimpiaDt.Size = new System.Drawing.Size(147, 90);
            this.btnLimpiaDt.TabIndex = 14;
            this.btnLimpiaDt.Text = "Limpiar Detalle";
            this.btnLimpiaDt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiaDt.UseVisualStyleBackColor = true;
            // 
            // btnBorrarLn
            // 
            this.btnBorrarLn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrarLn.Location = new System.Drawing.Point(155, 582);
            this.btnBorrarLn.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrarLn.Name = "btnBorrarLn";
            this.btnBorrarLn.Size = new System.Drawing.Size(147, 90);
            this.btnBorrarLn.TabIndex = 13;
            this.btnBorrarLn.Text = "Borrar Linea";
            this.btnBorrarLn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrarLn.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(7, 582);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(147, 90);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar Linea";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(960, 614);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = " Descuentos";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(960, 582);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = " Subtotal";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(960, 678);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = " Total";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(960, 646);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 26);
            this.label5.TabIndex = 17;
            this.label5.Text = " Impuestos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(1173, 678);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(211, 26);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.BackColor = System.Drawing.Color.White;
            this.lblImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImpuesto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblImpuesto.Location = new System.Drawing.Point(1173, 646);
            this.lblImpuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(211, 26);
            this.lblImpuesto.TabIndex = 21;
            this.lblImpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescuento
            // 
            this.lblDescuento.BackColor = System.Drawing.Color.White;
            this.lblDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescuento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescuento.Location = new System.Drawing.Point(1173, 614);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(211, 26);
            this.lblDescuento.TabIndex = 20;
            this.lblDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BackColor = System.Drawing.Color.White;
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSubTotal.Location = new System.Drawing.Point(1173, 582);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(211, 26);
            this.lblSubTotal.TabIndex = 19;
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(14, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 26);
            this.label6.TabIndex = 26;
            this.label6.Text = " RNC";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(14, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 26);
            this.label7.TabIndex = 25;
            this.label7.Text = " Cliente";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(14, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 26);
            this.label8.TabIndex = 24;
            this.label8.Text = " Fecha de Registro";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(14, 96);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 26);
            this.label9.TabIndex = 23;
            this.label9.Text = " Numero de Factura";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(14, 224);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 25);
            this.label10.TabIndex = 27;
            this.label10.Text = " Libre de Impuestos";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.Color.White;
            this.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFecha.Location = new System.Drawing.Point(228, 128);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(214, 26);
            this.lblFecha.TabIndex = 29;
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSecuencia
            // 
            this.lblSecuencia.BackColor = System.Drawing.Color.White;
            this.lblSecuencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSecuencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSecuencia.Location = new System.Drawing.Point(228, 96);
            this.lblSecuencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecuencia.Name = "lblSecuencia";
            this.lblSecuencia.Size = new System.Drawing.Size(214, 26);
            this.lblSecuencia.TabIndex = 28;
            this.lblSecuencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.BackColor = System.Drawing.Color.White;
            this.lblNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNombreCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreCliente.Location = new System.Drawing.Point(491, 160);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(541, 26);
            this.lblNombreCliente.TabIndex = 30;
            this.lblNombreCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(228, 160);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCliente.Multiline = true;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(214, 26);
            this.txtCliente.TabIndex = 31;
            this.txtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            this.txtCliente.Leave += new System.EventHandler(this.txtCliente_Leave);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(441, 160);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(43, 26);
            this.btnCliente.TabIndex = 32;
            this.btnCliente.Text = "...";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // txtRNC
            // 
            this.txtRNC.Location = new System.Drawing.Point(228, 192);
            this.txtRNC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRNC.Multiline = true;
            this.txtRNC.Name = "txtRNC";
            this.txtRNC.Size = new System.Drawing.Size(214, 26);
            this.txtRNC.TabIndex = 33;
            this.txtRNC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRNC_KeyPress);
            this.txtRNC.Leave += new System.EventHandler(this.txtRNC_Leave);
            // 
            // cboLibreImpuesto
            // 
            this.cboLibreImpuesto.FormattingEnabled = true;
            this.cboLibreImpuesto.Location = new System.Drawing.Point(228, 224);
            this.cboLibreImpuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboLibreImpuesto.Name = "cboLibreImpuesto";
            this.cboLibreImpuesto.Size = new System.Drawing.Size(93, 24);
            this.cboLibreImpuesto.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(14, 269);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 26);
            this.label12.TabIndex = 36;
            this.label12.Text = " Item";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(199, 269);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(441, 26);
            this.label13.TabIndex = 37;
            this.label13.Text = "Descripcion";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(640, 269);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 26);
            this.label14.TabIndex = 38;
            this.label14.Text = "Cantidad";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(939, 269);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 26);
            this.label15.TabIndex = 39;
            this.label15.Text = "Descuento";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(1088, 269);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(149, 26);
            this.label16.TabIndex = 40;
            this.label16.Text = "Impuesto";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(1237, 269);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(147, 26);
            this.label17.TabIndex = 41;
            this.label17.Text = "Total Ln";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(789, 269);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(149, 26);
            this.label18.TabIndex = 42;
            this.label18.Text = "Precio";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.BackColor = System.Drawing.Color.White;
            this.lblDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescripcion.Location = new System.Drawing.Point(199, 294);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(441, 26);
            this.lblDescripcion.TabIndex = 44;
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrecio
            // 
            this.lblPrecio.BackColor = System.Drawing.Color.White;
            this.lblPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.Location = new System.Drawing.Point(789, 294);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(150, 26);
            this.lblPrecio.TabIndex = 46;
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalLn
            // 
            this.lblTotalLn.BackColor = System.Drawing.Color.White;
            this.lblTotalLn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalLn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalLn.Location = new System.Drawing.Point(1237, 294);
            this.lblTotalLn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalLn.Name = "lblTotalLn";
            this.lblTotalLn.Size = new System.Drawing.Size(147, 26);
            this.lblTotalLn.TabIndex = 47;
            this.lblTotalLn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblImpuestoLn
            // 
            this.lblImpuestoLn.BackColor = System.Drawing.Color.White;
            this.lblImpuestoLn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImpuestoLn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblImpuestoLn.Location = new System.Drawing.Point(1088, 294);
            this.lblImpuestoLn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImpuestoLn.Name = "lblImpuestoLn";
            this.lblImpuestoLn.Size = new System.Drawing.Size(150, 26);
            this.lblImpuestoLn.TabIndex = 48;
            this.lblImpuestoLn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(14, 294);
            this.txtItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtItem.Multiline = true;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(143, 26);
            this.txtItem.TabIndex = 49;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(640, 294);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(150, 26);
            this.txtCantidad.TabIndex = 50;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(939, 294);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescuento.Multiline = true;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(150, 26);
            this.txtDescuento.TabIndex = 51;
            // 
            // btnItem
            // 
            this.btnItem.Location = new System.Drawing.Point(156, 294);
            this.btnItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(43, 26);
            this.btnItem.TabIndex = 52;
            this.btnItem.Text = "...";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1385, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 52);
            this.button1.TabIndex = 53;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(447, 582);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 90);
            this.button2.TabIndex = 54;
            this.button2.Text = "Inserta Linea";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 719);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnItem);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.lblImpuestoLn);
            this.Controls.Add(this.lblTotalLn);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboLibreImpuesto);
            this.Controls.Add(this.txtRNC);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblSecuencia);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblImpuesto);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiaDt);
            this.Controls.Add(this.btnBorrarLn);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFactura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFactura_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLimpiaDt;
        private System.Windows.Forms.Button btnBorrarLn;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblSecuencia;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.TextBox txtRNC;
        private System.Windows.Forms.ComboBox cboLibreImpuesto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTotalLn;
        private System.Windows.Forms.Label lblImpuestoLn;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}