namespace ReservaVuelos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCodigoVuelo = new System.Windows.Forms.TextBox();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.txtAsientosDisponibles = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewVuelos = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Asientos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Origen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Destino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAgregarVuelo = new System.Windows.Forms.Button();
            this.txtCodigoReserva = new System.Windows.Forms.TextBox();
            this.txtCantidadReservas = new System.Windows.Forms.TextBox();
            this.btnReservarVuelo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelCantidadReservas = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodigoVuelo
            // 
            this.txtCodigoVuelo.Location = new System.Drawing.Point(29, 117);
            this.txtCodigoVuelo.Name = "txtCodigoVuelo";
            this.txtCodigoVuelo.Size = new System.Drawing.Size(199, 26);
            this.txtCodigoVuelo.TabIndex = 1;
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(261, 117);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(276, 26);
            this.dtpFechaSalida.TabIndex = 6;
            // 
            // txtAsientosDisponibles
            // 
            this.txtAsientosDisponibles.Location = new System.Drawing.Point(566, 117);
            this.txtAsientosDisponibles.Name = "txtAsientosDisponibles";
            this.txtAsientosDisponibles.Size = new System.Drawing.Size(204, 26);
            this.txtAsientosDisponibles.TabIndex = 7;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(29, 177);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(355, 26);
            this.txtOrigen.TabIndex = 8;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(415, 177);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(355, 26);
            this.txtDestino.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(305, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 55);
            this.label1.TabIndex = 10;
            this.label1.Text = "Registro";
            // 
            // listViewVuelos
            // 
            this.listViewVuelos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Fecha,
            this.Asientos,
            this.Origen,
            this.Destino});
            this.listViewVuelos.FullRowSelect = true;
            this.listViewVuelos.GridLines = true;
            this.listViewVuelos.HideSelection = false;
            this.listViewVuelos.Location = new System.Drawing.Point(29, 281);
            this.listViewVuelos.Name = "listViewVuelos";
            this.listViewVuelos.Size = new System.Drawing.Size(737, 249);
            this.listViewVuelos.TabIndex = 11;
            this.listViewVuelos.UseCompatibleStateImageBehavior = false;
            this.listViewVuelos.View = System.Windows.Forms.View.Details;
            // 
            // Codigo
            // 
            this.Codigo.Text = "Código";
            this.Codigo.Width = 100;
            // 
            // Fecha
            // 
            this.Fecha.Text = "Fecha";
            this.Fecha.Width = 100;
            // 
            // Asientos
            // 
            this.Asientos.Text = "Asientos";
            this.Asientos.Width = 100;
            // 
            // Origen
            // 
            this.Origen.Text = "Origen";
            this.Origen.Width = 100;
            // 
            // Destino
            // 
            this.Destino.Text = "Destino";
            this.Destino.Width = 100;
            // 
            // btnAgregarVuelo
            // 
            this.btnAgregarVuelo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregarVuelo.Location = new System.Drawing.Point(302, 224);
            this.btnAgregarVuelo.Name = "btnAgregarVuelo";
            this.btnAgregarVuelo.Size = new System.Drawing.Size(185, 34);
            this.btnAgregarVuelo.TabIndex = 12;
            this.btnAgregarVuelo.Text = "Agregar";
            this.btnAgregarVuelo.UseVisualStyleBackColor = false;
            this.btnAgregarVuelo.Click += new System.EventHandler(this.btnAgregarVuelo_Click);
            // 
            // txtCodigoReserva
            // 
            this.txtCodigoReserva.Location = new System.Drawing.Point(28, 636);
            this.txtCodigoReserva.Name = "txtCodigoReserva";
            this.txtCodigoReserva.Size = new System.Drawing.Size(276, 26);
            this.txtCodigoReserva.TabIndex = 13;
            // 
            // txtCantidadReservas
            // 
            this.txtCantidadReservas.Location = new System.Drawing.Point(330, 634);
            this.txtCantidadReservas.Name = "txtCantidadReservas";
            this.txtCantidadReservas.Size = new System.Drawing.Size(261, 26);
            this.txtCantidadReservas.TabIndex = 14;
            // 
            // btnReservarVuelo
            // 
            this.btnReservarVuelo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReservarVuelo.Location = new System.Drawing.Point(617, 630);
            this.btnReservarVuelo.Name = "btnReservarVuelo";
            this.btnReservarVuelo.Size = new System.Drawing.Size(146, 34);
            this.btnReservarVuelo.TabIndex = 15;
            this.btnReservarVuelo.Text = "Reservar";
            this.btnReservarVuelo.UseVisualStyleBackColor = false;
            this.btnReservarVuelo.Click += new System.EventHandler(this.btnReservarVuelo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(27, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(257, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fecha de salida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(562, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Asientos disponibles";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlText;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(25, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Origen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlText;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(411, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Destino";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlText;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(26, 613);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Código";
            // 
            // labelCantidadReservas
            // 
            this.labelCantidadReservas.AutoSize = true;
            this.labelCantidadReservas.BackColor = System.Drawing.SystemColors.ControlText;
            this.labelCantidadReservas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCantidadReservas.Location = new System.Drawing.Point(336, 611);
            this.labelCantidadReservas.Name = "labelCantidadReservas";
            this.labelCantidadReservas.Size = new System.Drawing.Size(159, 20);
            this.labelCantidadReservas.TabIndex = 23;
            this.labelCantidadReservas.Text = "Cantidad de asientos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(292, 542);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(306, 83);
            this.label9.TabIndex = 24;
            this.label9.Text = "Reserva";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(792, 698);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelCantidadReservas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReservarVuelo);
            this.Controls.Add(this.txtCantidadReservas);
            this.Controls.Add(this.txtCodigoReserva);
            this.Controls.Add(this.btnAgregarVuelo);
            this.Controls.Add(this.listViewVuelos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.txtAsientosDisponibles);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.txtCodigoVuelo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoVuelo;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.TextBox txtAsientosDisponibles;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewVuelos;
        private System.Windows.Forms.Button btnAgregarVuelo;
        private System.Windows.Forms.TextBox txtCodigoReserva;
        private System.Windows.Forms.TextBox txtCantidadReservas;
        private System.Windows.Forms.Button btnReservarVuelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelCantidadReservas;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Fecha;
        private System.Windows.Forms.ColumnHeader Asientos;
        private System.Windows.Forms.ColumnHeader Origen;
        private System.Windows.Forms.ColumnHeader Destino;
        private System.Windows.Forms.Label label9;
    }
}

