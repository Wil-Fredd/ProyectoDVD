
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Proyecto_POO.Forms;

namespace Proyecto_POO
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			DialogResult Respuesta = MessageBox.Show("¿Estás seguro que deseas salir?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (Respuesta == DialogResult.Yes)
				{
					Dispose();
				}			
		}
		
		void BtnDVDClick(object sender, EventArgs e)
		{
			FrmDVD DVD = new FrmDVD();
			DVD.Show();
		}
		
		void BtnClientesClick(object sender, EventArgs e)
		{
			FrmClientes Clientes = new FrmClientes();
			Clientes.Show();
		}
		
		void BtnPrestamosClick(object sender, EventArgs e)
		{
			FrmPrestamos Prestamos = new FrmPrestamos();
			Prestamos.Show();
		}
		
		
		
		void BtnIngresosClick(object sender, EventArgs e)
		{
			FrmIngresos Ingresos = new FrmIngresos();
			Ingresos.Show();
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			
		}
	}
}
