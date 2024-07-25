/*
 * Created by SharpDevelop.
 * User: gabri
 * Date: 22/5/2023
 * Time: 3:36 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Proyecto_POO.Forms
{
	partial class FrmTablaRegistro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTablaRegistro));
			this.dgvDVD = new System.Windows.Forms.DataGridView();
			this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Lanzamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaI = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Situacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvDVD)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDVD
			// 
			this.dgvDVD.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.dgvDVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDVD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Codigo,
									this.Titulo,
									this.Lanzamiento,
									this.Tipo,
									this.Cantidad,
									this.FechaI,
									this.Situacion,
									this.Descripcion});
			this.dgvDVD.GridColor = System.Drawing.SystemColors.MenuText;
			this.dgvDVD.Location = new System.Drawing.Point(26, 3);
			this.dgvDVD.Name = "dgvDVD";
			this.dgvDVD.ReadOnly = true;
			this.dgvDVD.RowTemplate.Height = 24;
			this.dgvDVD.Size = new System.Drawing.Size(1128, 517);
			this.dgvDVD.TabIndex = 0;
			// 
			// Codigo
			// 
			this.Codigo.HeaderText = "Código";
			this.Codigo.Name = "Codigo";
			this.Codigo.ReadOnly = true;
			// 
			// Titulo
			// 
			this.Titulo.HeaderText = "Título";
			this.Titulo.Name = "Titulo";
			this.Titulo.ReadOnly = true;
			// 
			// Lanzamiento
			// 
			this.Lanzamiento.HeaderText = "Año de lanzamiento";
			this.Lanzamiento.Name = "Lanzamiento";
			this.Lanzamiento.ReadOnly = true;
			// 
			// Tipo
			// 
			this.Tipo.HeaderText = "Tipo de medio";
			this.Tipo.Name = "Tipo";
			this.Tipo.ReadOnly = true;
			// 
			// Cantidad
			// 
			this.Cantidad.HeaderText = "Cantidad en existencia";
			this.Cantidad.Name = "Cantidad";
			this.Cantidad.ReadOnly = true;
			// 
			// FechaI
			// 
			this.FechaI.HeaderText = "Fecha de ingreso";
			this.FechaI.Name = "FechaI";
			this.FechaI.ReadOnly = true;
			// 
			// Situacion
			// 
			this.Situacion.HeaderText = "Situación actual";
			this.Situacion.Name = "Situacion";
			this.Situacion.ReadOnly = true;
			// 
			// Descripcion
			// 
			this.Descripcion.HeaderText = "Descripción del medio";
			this.Descripcion.Name = "Descripcion";
			this.Descripcion.ReadOnly = true;
			// 
			// FrmTablaRegistro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 549);
			this.Controls.Add(this.dgvDVD);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmTablaRegistro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tabla De Registro";
			((System.ComponentModel.ISupportInitialize)(this.dgvDVD)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Situacion;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaI;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Lanzamiento;
		private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
		private System.Windows.Forms.DataGridView dgvDVD;
	}
}
