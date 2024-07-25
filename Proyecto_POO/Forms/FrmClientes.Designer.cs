
namespace Proyecto_POO.Forms
{
	partial class FrmClientes
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
			this.btnSalir = new System.Windows.Forms.Button();
			this.txtCedula = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombres = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtApellidos = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDireccionH = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtNumeroResidencia = new System.Windows.Forms.TextBox();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
			this.dgvClientes = new System.Windows.Forms.DataGridView();
			this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DireccionH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NumeroR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnEliminar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.Red;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.Color.White;
			this.btnSalir.Location = new System.Drawing.Point(823, 8);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(92, 38);
			this.btnSalir.TabIndex = 8;
			this.btnSalir.Text = "SALIR";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// txtCedula
			// 
			this.txtCedula.Location = new System.Drawing.Point(255, 16);
			this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.Size = new System.Drawing.Size(210, 22);
			this.txtCedula.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 16);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(237, 28);
			this.label1.TabIndex = 9;
			this.label1.Text = "Cédula de Identidad:";
			// 
			// txtNombres
			// 
			this.txtNombres.Location = new System.Drawing.Point(255, 70);
			this.txtNombres.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombres.Name = "txtNombres";
			this.txtNombres.Size = new System.Drawing.Size(210, 22);
			this.txtNombres.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 70);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(237, 28);
			this.label2.TabIndex = 11;
			this.label2.Text = "Nombres:";
			// 
			// txtApellidos
			// 
			this.txtApellidos.Location = new System.Drawing.Point(255, 117);
			this.txtApellidos.Margin = new System.Windows.Forms.Padding(4);
			this.txtApellidos.Name = "txtApellidos";
			this.txtApellidos.Size = new System.Drawing.Size(210, 22);
			this.txtApellidos.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 117);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(237, 28);
			this.label3.TabIndex = 13;
			this.label3.Text = "Apellidos:";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(10, 168);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(237, 28);
			this.label4.TabIndex = 15;
			this.label4.Text = "Fecha de nacimiento:";
			// 
			// dtpFecha
			// 
			this.dtpFecha.Location = new System.Drawing.Point(255, 170);
			this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(259, 22);
			this.dtpFecha.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(10, 217);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(263, 28);
			this.label5.TabIndex = 17;
			this.label5.Text = "Dirección de habitación:";
			// 
			// txtDireccionH
			// 
			this.txtDireccionH.Location = new System.Drawing.Point(281, 217);
			this.txtDireccionH.Margin = new System.Windows.Forms.Padding(4);
			this.txtDireccionH.Name = "txtDireccionH";
			this.txtDireccionH.Size = new System.Drawing.Size(184, 22);
			this.txtDireccionH.TabIndex = 18;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(13, 261);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(263, 28);
			this.label6.TabIndex = 19;
			this.label6.Text = "Correo electrónico:";
			// 
			// txtCorreo
			// 
			this.txtCorreo.Location = new System.Drawing.Point(255, 267);
			this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(210, 22);
			this.txtCorreo.TabIndex = 20;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(10, 307);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(263, 28);
			this.label7.TabIndex = 21;
			this.label7.Text = "Número telefónico:";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(255, 307);
			this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(210, 22);
			this.txtTelefono.TabIndex = 22;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(13, 351);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(263, 28);
			this.label8.TabIndex = 23;
			this.label8.Text = "Número de residencia:";
			// 
			// txtNumeroResidencia
			// 
			this.txtNumeroResidencia.Location = new System.Drawing.Point(255, 355);
			this.txtNumeroResidencia.Margin = new System.Windows.Forms.Padding(4);
			this.txtNumeroResidencia.Name = "txtNumeroResidencia";
			this.txtNumeroResidencia.Size = new System.Drawing.Size(210, 22);
			this.txtNumeroResidencia.TabIndex = 24;
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.Location = new System.Drawing.Point(719, 97);
			this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(129, 38);
			this.btnRegistrar.TabIndex = 25;
			this.btnRegistrar.Text = "REGISTRAR";
			this.btnRegistrar.UseVisualStyleBackColor = false;
			this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrarClick);
			// 
			// btnConsultar
			// 
			this.btnConsultar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultar.Location = new System.Drawing.Point(719, 161);
			this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(129, 45);
			this.btnConsultar.TabIndex = 26;
			this.btnConsultar.Text = "CONSULTAR";
			this.btnConsultar.UseVisualStyleBackColor = false;
			this.btnConsultar.Click += new System.EventHandler(this.BtnConsultarClick);
			// 
			// btnActualizar
			// 
			this.btnActualizar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizar.Location = new System.Drawing.Point(719, 224);
			this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(129, 40);
			this.btnActualizar.TabIndex = 27;
			this.btnActualizar.Text = "ACTUALIZAR";
			this.btnActualizar.UseVisualStyleBackColor = false;
			this.btnActualizar.Click += new System.EventHandler(this.BtnActualizarClick);
			// 
			// erpError
			// 
			this.erpError.ContainerControl = this;
			// 
			// dgvClientes
			// 
			this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Cedula,
									this.Nombres,
									this.Apellidos,
									this.FechaN,
									this.DireccionH,
									this.Correo,
									this.Telefono,
									this.NumeroR});
			this.dgvClientes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dgvClientes.Location = new System.Drawing.Point(25, 407);
			this.dgvClientes.Margin = new System.Windows.Forms.Padding(4);
			this.dgvClientes.Name = "dgvClientes";
			this.dgvClientes.ReadOnly = true;
			this.dgvClientes.Size = new System.Drawing.Size(860, 220);
			this.dgvClientes.TabIndex = 28;
			// 
			// Cedula
			// 
			this.Cedula.HeaderText = "Cédula de Identidad";
			this.Cedula.Name = "Cedula";
			this.Cedula.ReadOnly = true;
			// 
			// Nombres
			// 
			this.Nombres.HeaderText = "Nombres";
			this.Nombres.Name = "Nombres";
			this.Nombres.ReadOnly = true;
			// 
			// Apellidos
			// 
			this.Apellidos.HeaderText = "Apellidos";
			this.Apellidos.Name = "Apellidos";
			this.Apellidos.ReadOnly = true;
			// 
			// FechaN
			// 
			this.FechaN.HeaderText = "Fecha de nacimiento";
			this.FechaN.Name = "FechaN";
			this.FechaN.ReadOnly = true;
			// 
			// DireccionH
			// 
			this.DireccionH.HeaderText = "Direccion de habitación";
			this.DireccionH.Name = "DireccionH";
			this.DireccionH.ReadOnly = true;
			// 
			// Correo
			// 
			this.Correo.HeaderText = "Correo electrónico";
			this.Correo.Name = "Correo";
			this.Correo.ReadOnly = true;
			// 
			// Telefono
			// 
			this.Telefono.HeaderText = "Número telefónico";
			this.Telefono.Name = "Telefono";
			this.Telefono.ReadOnly = true;
			// 
			// NumeroR
			// 
			this.NumeroR.HeaderText = "Número de residencia";
			this.NumeroR.Name = "NumeroR";
			this.NumeroR.ReadOnly = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.ForeColor = System.Drawing.Color.Red;
			this.btnEliminar.Location = new System.Drawing.Point(719, 283);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(129, 38);
			this.btnEliminar.TabIndex = 36;
			this.btnEliminar.Text = "ELIMINAR";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// FrmClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(917, 666);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.dgvClientes);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.txtNumeroResidencia);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtCorreo);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtDireccionH);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtApellidos);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNombres);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCedula);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSalir);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmClientes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UltraDVD";
			((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.DataGridViewTextBoxColumn NumeroR;
		private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
		private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
		private System.Windows.Forms.DataGridViewTextBoxColumn DireccionH;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaN;
		private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
		private System.Windows.Forms.DataGridView dgvClientes;
		private System.Windows.Forms.ErrorProvider erpError;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.TextBox txtNumeroResidencia;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtDireccionH;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtApellidos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNombres;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCedula;
		private System.Windows.Forms.Button btnSalir;
	}
}
