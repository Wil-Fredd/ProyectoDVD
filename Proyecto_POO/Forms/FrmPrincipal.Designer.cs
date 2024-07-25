
namespace Proyecto_POO
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnDVD = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnClientes = new System.Windows.Forms.Button();
			this.btnPrestamos = new System.Windows.Forms.Button();
			this.btnIngresos = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// btnDVD
			// 
			this.btnDVD.BackColor = System.Drawing.Color.White;
			this.btnDVD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDVD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDVD.Location = new System.Drawing.Point(296, 280);
			this.btnDVD.Name = "btnDVD";
			this.btnDVD.Size = new System.Drawing.Size(139, 31);
			this.btnDVD.TabIndex = 0;
			this.btnDVD.Text = "GESTION DE DVD";
			this.btnDVD.UseVisualStyleBackColor = false;
			this.btnDVD.Click += new System.EventHandler(this.BtnDVDClick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Century Schoolbook", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
												| System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(1, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(281, 63);
			this.label1.TabIndex = 1;
			this.label1.Text = " ULTRADVD C.A ";
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.Red;
			this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnSalir.Location = new System.Drawing.Point(676, 11);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(70, 41);
			this.btnSalir.TabIndex = 2;
			this.btnSalir.Text = "SALIR";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// btnClientes
			// 
			this.btnClientes.BackColor = System.Drawing.Color.White;
			this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClientes.Location = new System.Drawing.Point(393, 348);
			this.btnClientes.Name = "btnClientes";
			this.btnClientes.Size = new System.Drawing.Size(187, 33);
			this.btnClientes.TabIndex = 3;
			this.btnClientes.Text = "GESTION DE CLIENTES";
			this.btnClientes.UseVisualStyleBackColor = false;
			this.btnClientes.Click += new System.EventHandler(this.BtnClientesClick);
			// 
			// btnPrestamos
			// 
			this.btnPrestamos.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrestamos.Location = new System.Drawing.Point(271, 414);
			this.btnPrestamos.Name = "btnPrestamos";
			this.btnPrestamos.Size = new System.Drawing.Size(182, 33);
			this.btnPrestamos.TabIndex = 4;
			this.btnPrestamos.Text = "GESTION DE PRESTAMOS";
			this.btnPrestamos.UseVisualStyleBackColor = false;
			this.btnPrestamos.Click += new System.EventHandler(this.BtnPrestamosClick);
			// 
			// btnIngresos
			// 
			this.btnIngresos.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIngresos.Location = new System.Drawing.Point(135, 485);
			this.btnIngresos.Name = "btnIngresos";
			this.btnIngresos.Size = new System.Drawing.Size(182, 33);
			this.btnIngresos.TabIndex = 5;
			this.btnIngresos.Text = "CONSULTA DE INGRESOS";
			this.btnIngresos.UseVisualStyleBackColor = false;
			this.btnIngresos.Click += new System.EventHandler(this.BtnIngresosClick);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(1, 3);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(227, 236);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(20, 177);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(208, 63);
			this.label2.TabIndex = 8;
			this.label2.Text = "EST                         2023";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Century", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(67, 193);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 94);
			this.label3.TabIndex = 9;
			this.label3.Text = "Tecnology\r\n Advanced";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(772, 571);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.btnIngresos);
			this.Controls.Add(this.btnPrestamos);
			this.Controls.Add(this.btnClientes);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnDVD);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UltraDVD";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btnIngresos;
		private System.Windows.Forms.Button btnPrestamos;
		private System.Windows.Forms.Button btnClientes;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDVD;
	}
}
