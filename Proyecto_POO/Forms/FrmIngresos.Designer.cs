
namespace Proyecto_POO.Forms
{
	partial class FrmIngresos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngresos));
			this.dgvIngresos = new System.Windows.Forms.DataGridView();
			this.FechaI = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TipoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSalir = new System.Windows.Forms.Button();
			this.lblMontoT = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvIngresos
			// 
			this.dgvIngresos.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.dgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvIngresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.FechaI,
									this.FechaD,
									this.TipoM,
									this.MontoTotal});
			this.dgvIngresos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dgvIngresos.Location = new System.Drawing.Point(-6, -1);
			this.dgvIngresos.Margin = new System.Windows.Forms.Padding(4);
			this.dgvIngresos.Name = "dgvIngresos";
			this.dgvIngresos.ReadOnly = true;
			this.dgvIngresos.Size = new System.Drawing.Size(548, 669);
			this.dgvIngresos.TabIndex = 0;
			// 
			// FechaI
			// 
			this.FechaI.HeaderText = "Fecha de Ingreso";
			this.FechaI.Name = "FechaI";
			this.FechaI.ReadOnly = true;
			// 
			// FechaD
			// 
			this.FechaD.HeaderText = "Fecha de Devolución";
			this.FechaD.Name = "FechaD";
			this.FechaD.ReadOnly = true;
			// 
			// TipoM
			// 
			this.TipoM.HeaderText = "Tipo de medio";
			this.TipoM.Name = "TipoM";
			this.TipoM.ReadOnly = true;
			// 
			// MontoTotal
			// 
			this.MontoTotal.HeaderText = "Monto";
			this.MontoTotal.Name = "MontoTotal";
			this.MontoTotal.ReadOnly = true;
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.Red;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.ForeColor = System.Drawing.Color.White;
			this.btnSalir.Location = new System.Drawing.Point(812, 13);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(92, 38);
			this.btnSalir.TabIndex = 9;
			this.btnSalir.Text = "SALIR";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// lblMontoT
			// 
			this.lblMontoT.BackColor = System.Drawing.Color.ForestGreen;
			this.lblMontoT.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMontoT.ForeColor = System.Drawing.Color.Transparent;
			this.lblMontoT.Location = new System.Drawing.Point(810, 614);
			this.lblMontoT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMontoT.Name = "lblMontoT";
			this.lblMontoT.Size = new System.Drawing.Size(94, 40);
			this.lblMontoT.TabIndex = 10;
			this.lblMontoT.Text = "0$";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.ForestGreen;
			this.pictureBox1.Location = new System.Drawing.Point(549, 503);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(356, 151);
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.ForestGreen;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(549, 503);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(211, 65);
			this.label1.TabIndex = 12;
			this.label1.Text = "SUBTOTAL";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(549, 58);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(371, 358);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 13;
			this.pictureBox2.TabStop = false;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Century Schoolbook", 19.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
												| System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(562, 349);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(370, 77);
			this.label2.TabIndex = 14;
			this.label2.Text = " ULTRADVD C.A ";
			// 
			// FrmIngresos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(917, 666);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblMontoT);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.dgvIngresos);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmIngresos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UltraDVD";
			((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblMontoT;
		private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
		private System.Windows.Forms.DataGridViewTextBoxColumn TipoM;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaD;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaI;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.DataGridView dgvIngresos;
	}
}
