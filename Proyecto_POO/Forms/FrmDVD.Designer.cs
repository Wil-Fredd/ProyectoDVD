
namespace Proyecto_POO.Forms
{
	partial class FrmDVD
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDVD));
			this.label1 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTitulo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAno = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSalir = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbTipo_Medio = new System.Windows.Forms.ComboBox();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.btnConsultar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtDescrip = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.pbImage = new System.Windows.Forms.PictureBox();
			this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
			this.dtpFechaI = new System.Windows.Forms.DateTimePicker();
			this.cmbSituacion = new System.Windows.Forms.ComboBox();
			this.btnTabla = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 64);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(237, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "Código del producto: ";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(258, 68);
			this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(200, 22);
			this.txtCodigo.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(322, -2);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(264, 41);
			this.label2.TabIndex = 2;
			this.label2.Text = "GESTION DE DVD";
			// 
			// txtTitulo
			// 
			this.txtTitulo.Location = new System.Drawing.Point(258, 128);
			this.txtTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtTitulo.Name = "txtTitulo";
			this.txtTitulo.Size = new System.Drawing.Size(200, 22);
			this.txtTitulo.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 128);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(237, 28);
			this.label3.TabIndex = 3;
			this.label3.Text = "Título: ";
			// 
			// txtAno
			// 
			this.txtAno.Location = new System.Drawing.Point(258, 181);
			this.txtAno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtAno.Name = "txtAno";
			this.txtAno.Size = new System.Drawing.Size(200, 22);
			this.txtAno.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 177);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(237, 28);
			this.label4.TabIndex = 5;
			this.label4.Text = "Año de lanzamiento:";
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.Red;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.Color.White;
			this.btnSalir.Location = new System.Drawing.Point(822, 13);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(92, 38);
			this.btnSalir.TabIndex = 7;
			this.btnSalir.Text = "SALIR";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(13, 228);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(237, 28);
			this.label5.TabIndex = 8;
			this.label5.Text = "Tipo de medio:";
			// 
			// cmbTipo_Medio
			// 
			this.cmbTipo_Medio.FormattingEnabled = true;
			this.cmbTipo_Medio.Items.AddRange(new object[] {
									"",
									"Película en Blu-ray",
									"Juego para cónsola",
									"Colección de pistas MP3"});
			this.cmbTipo_Medio.Location = new System.Drawing.Point(258, 232);
			this.cmbTipo_Medio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmbTipo_Medio.Name = "cmbTipo_Medio";
			this.cmbTipo_Medio.Size = new System.Drawing.Size(200, 24);
			this.cmbTipo_Medio.TabIndex = 9;
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnRegistrar.Location = new System.Drawing.Point(716, 81);
			this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(128, 47);
			this.btnRegistrar.TabIndex = 10;
			this.btnRegistrar.Text = "REGISTRAR";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrarClick);
			// 
			// btnConsultar
			// 
			this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConsultar.Location = new System.Drawing.Point(716, 144);
			this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnConsultar.Name = "btnConsultar";
			this.btnConsultar.Size = new System.Drawing.Size(128, 42);
			this.btnConsultar.TabIndex = 11;
			this.btnConsultar.Text = "CONSULTAR";
			this.btnConsultar.UseVisualStyleBackColor = true;
			this.btnConsultar.Click += new System.EventHandler(this.BtnConsultarClick);
			// 
			// btnActualizar
			// 
			this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActualizar.Location = new System.Drawing.Point(716, 203);
			this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(128, 44);
			this.btnActualizar.TabIndex = 12;
			this.btnActualizar.Text = "ACTUALIZAR";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.BtnActualizarClick);
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(258, 285);
			this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(200, 22);
			this.txtCantidad.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(13, 285);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(255, 28);
			this.label6.TabIndex = 13;
			this.label6.Text = "Cantidad en existencia:";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(13, 346);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(237, 28);
			this.label7.TabIndex = 15;
			this.label7.Text = "Fecha de ingreso:";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(13, 408);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(237, 28);
			this.label8.TabIndex = 17;
			this.label8.Text = "Situación actual:";
			// 
			// txtDescrip
			// 
			this.txtDescrip.Location = new System.Drawing.Point(69, 507);
			this.txtDescrip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtDescrip.Multiline = true;
			this.txtDescrip.Name = "txtDescrip";
			this.txtDescrip.Size = new System.Drawing.Size(408, 136);
			this.txtDescrip.TabIndex = 21;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(155, 464);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(237, 28);
			this.label9.TabIndex = 20;
			this.label9.Text = "Descripción:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(621, 373);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(237, 28);
			this.label10.TabIndex = 22;
			this.label10.Text = "Imagen referencial";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pbImage
			// 
			this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbImage.Enabled = false;
			this.pbImage.Location = new System.Drawing.Point(621, 412);
			this.pbImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pbImage.Name = "pbImage";
			this.pbImage.Size = new System.Drawing.Size(237, 231);
			this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbImage.TabIndex = 23;
			this.pbImage.TabStop = false;
			// 
			// erpError
			// 
			this.erpError.ContainerControl = this;
			// 
			// dtpFechaI
			// 
			this.dtpFechaI.Location = new System.Drawing.Point(212, 352);
			this.dtpFechaI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dtpFechaI.Name = "dtpFechaI";
			this.dtpFechaI.Size = new System.Drawing.Size(265, 22);
			this.dtpFechaI.TabIndex = 24;
			// 
			// cmbSituacion
			// 
			this.cmbSituacion.FormattingEnabled = true;
			this.cmbSituacion.Items.AddRange(new object[] {
									"",
									"Disponible",
									"No disponible"});
			this.cmbSituacion.Location = new System.Drawing.Point(258, 412);
			this.cmbSituacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmbSituacion.Name = "cmbSituacion";
			this.cmbSituacion.Size = new System.Drawing.Size(200, 24);
			this.cmbSituacion.TabIndex = 25;
			// 
			// btnTabla
			// 
			this.btnTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTabla.Location = new System.Drawing.Point(716, 263);
			this.btnTabla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnTabla.Name = "btnTabla";
			this.btnTabla.Size = new System.Drawing.Size(128, 50);
			this.btnTabla.TabIndex = 26;
			this.btnTabla.Text = "VER REGISTRO";
			this.btnTabla.UseVisualStyleBackColor = true;
			this.btnTabla.Click += new System.EventHandler(this.BtnTablaClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.ForeColor = System.Drawing.Color.Red;
			this.btnEliminar.Location = new System.Drawing.Point(578, 177);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(118, 41);
			this.btnEliminar.TabIndex = 27;
			this.btnEliminar.Text = "ELIMINAR";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// FrmDVD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(917, 666);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnTabla);
			this.Controls.Add(this.cmbSituacion);
			this.Controls.Add(this.dtpFechaI);
			this.Controls.Add(this.pbImage);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtDescrip);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnConsultar);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.cmbTipo_Medio);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.txtAno);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtTitulo);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FrmDVD";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UltraDVD";
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnTabla;
		private System.Windows.Forms.ComboBox cmbSituacion;
		private System.Windows.Forms.DateTimePicker dtpFechaI;
		private System.Windows.Forms.ErrorProvider erpError;
		private System.Windows.Forms.PictureBox pbImage;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtDescrip;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.ComboBox cmbTipo_Medio;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtAno;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTitulo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label1;
	}
}
