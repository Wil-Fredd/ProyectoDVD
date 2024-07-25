
namespace Proyecto_POO.Forms
{
	partial class FrmPrestamos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrestamos));
			this.txtCedula = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.dgvPrestamos = new System.Windows.Forms.DataGridView();
			this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Direccion_H = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaDevol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CodigoDVD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo_Medio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MontoT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.dtpFechaDevol = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDias = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
			this.SuspendLayout();
			// 
			// txtCedula
			// 
			this.txtCedula.Location = new System.Drawing.Point(264, 71);
			this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtCedula.Name = "txtCedula";
			this.txtCedula.Size = new System.Drawing.Size(204, 22);
			this.txtCedula.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 67);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(237, 28);
			this.label1.TabIndex = 11;
			this.label1.Text = "Cédula de Identidad:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 173);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(203, 28);
			this.label2.TabIndex = 13;
			this.label2.Text = "Fecha de registro:";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(264, 297);
			this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(204, 22);
			this.txtCodigo.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 291);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(237, 28);
			this.label3.TabIndex = 15;
			this.label3.Text = "Código del medio: ";
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.BackColor = System.Drawing.Color.White;
			this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.Location = new System.Drawing.Point(698, 89);
			this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(128, 38);
			this.btnRegistrar.TabIndex = 26;
			this.btnRegistrar.Text = "REGISTRAR";
			this.btnRegistrar.UseVisualStyleBackColor = false;
			this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrarClick);
			// 
			// erpError
			// 
			this.erpError.ContainerControl = this;
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.Red;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.Color.White;
			this.btnSalir.Location = new System.Drawing.Point(812, 8);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(92, 38);
			this.btnSalir.TabIndex = 27;
			this.btnSalir.Text = "SALIR";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// btnConsultar
			// 
			this.btnConsultar.BackColor = System.Drawing.Color.White;
			this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultar.Location = new System.Drawing.Point(698, 145);
			this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(128, 39);
			this.btnConsultar.TabIndex = 30;
			this.btnConsultar.Text = "CONSULTAR";
			this.btnConsultar.UseVisualStyleBackColor = false;
			this.btnConsultar.Click += new System.EventHandler(this.BtnConsultarClick);
			// 
			// lblPrecio
			// 
			this.lblPrecio.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrecio.Location = new System.Drawing.Point(748, 213);
			this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(64, 28);
			this.lblPrecio.TabIndex = 32;
			// 
			// dgvPrestamos
			// 
			this.dgvPrestamos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Cedula,
									this.Nombres,
									this.Apellidos,
									this.Direccion_H,
									this.Fecha,
									this.FechaDevol,
									this.CodigoDVD,
									this.Titulo,
									this.Tipo_Medio,
									this.Cantidad,
									this.MontoT});
			this.dgvPrestamos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dgvPrestamos.Location = new System.Drawing.Point(16, 348);
			this.dgvPrestamos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgvPrestamos.Name = "dgvPrestamos";
			this.dgvPrestamos.ReadOnly = true;
			this.dgvPrestamos.Size = new System.Drawing.Size(885, 318);
			this.dgvPrestamos.TabIndex = 33;
			// 
			// Cedula
			// 
			this.Cedula.HeaderText = "Cédula del Cliente";
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
			// Direccion_H
			// 
			this.Direccion_H.HeaderText = "Direción de Habitación";
			this.Direccion_H.Name = "Direccion_H";
			this.Direccion_H.ReadOnly = true;
			// 
			// Fecha
			// 
			this.Fecha.HeaderText = "Fecha de registro";
			this.Fecha.Name = "Fecha";
			this.Fecha.ReadOnly = true;
			// 
			// FechaDevol
			// 
			this.FechaDevol.HeaderText = "Fecha de devolución";
			this.FechaDevol.Name = "FechaDevol";
			this.FechaDevol.ReadOnly = true;
			// 
			// CodigoDVD
			// 
			this.CodigoDVD.HeaderText = "Código del DVD";
			this.CodigoDVD.Name = "CodigoDVD";
			this.CodigoDVD.ReadOnly = true;
			// 
			// Titulo
			// 
			this.Titulo.HeaderText = "Título del DVD";
			this.Titulo.Name = "Titulo";
			this.Titulo.ReadOnly = true;
			// 
			// Tipo_Medio
			// 
			this.Tipo_Medio.HeaderText = "Tipo de medio";
			this.Tipo_Medio.Name = "Tipo_Medio";
			this.Tipo_Medio.ReadOnly = true;
			// 
			// Cantidad
			// 
			this.Cantidad.HeaderText = "Cantidad de existencia";
			this.Cantidad.Name = "Cantidad";
			this.Cantidad.ReadOnly = true;
			// 
			// MontoT
			// 
			this.MontoT.HeaderText = "Monto Total ($)";
			this.MontoT.Name = "MontoT";
			this.MontoT.ReadOnly = true;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Location = new System.Drawing.Point(255, 175);
			this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(267, 22);
			this.dtpFecha.TabIndex = 34;
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.White;
			this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.ForeColor = System.Drawing.Color.Red;
			this.btnEliminar.Location = new System.Drawing.Point(698, 267);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(128, 34);
			this.btnEliminar.TabIndex = 35;
			this.btnEliminar.Text = "ELIMINAR";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// dtpFechaDevol
			// 
			this.dtpFechaDevol.Enabled = false;
			this.dtpFechaDevol.Location = new System.Drawing.Point(257, 236);
			this.dtpFechaDevol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dtpFechaDevol.Name = "dtpFechaDevol";
			this.dtpFechaDevol.Size = new System.Drawing.Size(265, 22);
			this.dtpFechaDevol.TabIndex = 36;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 230);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(252, 28);
			this.label4.TabIndex = 38;
			this.label4.Text = "Fecha de devolución:";
			// 
			// btnActualizar
			// 
			this.btnActualizar.BackColor = System.Drawing.Color.White;
			this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizar.Location = new System.Drawing.Point(698, 208);
			this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(128, 33);
			this.btnActualizar.TabIndex = 39;
			this.btnActualizar.Text = "ACTUALIZAR";
			this.btnActualizar.UseVisualStyleBackColor = false;
			this.btnActualizar.Click += new System.EventHandler(this.BtnActualizarClick);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 120);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(237, 28);
			this.label5.TabIndex = 40;
			this.label5.Text = "Días de préstamo:";
			// 
			// txtDias
			// 
			this.txtDias.Location = new System.Drawing.Point(264, 124);
			this.txtDias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtDias.Name = "txtDias";
			this.txtDias.Size = new System.Drawing.Size(204, 22);
			this.txtDias.TabIndex = 41;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.White;
			this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label6.Location = new System.Drawing.Point(341, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(256, 38);
			this.label6.TabIndex = 42;
			this.label6.Text = "  PRESTAMOS ";
			// 
			// FrmPrestamos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(917, 666);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtDias);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.dtpFechaDevol);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.dtpFecha);
			this.Controls.Add(this.dgvPrestamos);
			this.Controls.Add(this.lblPrecio);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCedula);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label4);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FrmPrestamos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UltraDVD";
			this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
			((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDias;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpFechaDevol;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaDevol;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
		private System.Windows.Forms.DataGridViewTextBoxColumn MontoT;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Medio;
		private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDVD;
		private System.Windows.Forms.DataGridViewTextBoxColumn Direccion_H;
		private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
		private System.Windows.Forms.DataGridView dgvPrestamos;
		private System.Windows.Forms.Label lblPrecio;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.ErrorProvider erpError;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCedula;
	}
}
