
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Proyecto_POO.Models;
using System.IO;

namespace Proyecto_POO.Forms
{
	public partial class FrmIngresos : Form
	{
		
		List<Prestamo> listPrestamo = new List<Prestamo>();
		float total = 0.0f;
		public FrmIngresos()
		{
			InitializeComponent();
			transferirDatosPrestamo();
			cargarDatos();
			calcularMonto();
		}
		
		
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			DialogResult Respuesta = MessageBox.Show("¿Estás seguro que deseas salir?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (Respuesta == DialogResult.Yes)
				{
					Dispose();
				}			
		}
		
		private void cargarDatos()
		{
				foreach (Prestamo prestamos in listPrestamo) 
				{
				int datos = dgvIngresos.Rows.Add();
				dgvIngresos.Rows[datos].Cells["FechaI"].Value = prestamos.Fecha;
				dgvIngresos.Rows[datos].Cells["FechaD"].Value = prestamos.FechaDevol;
				dgvIngresos.Rows[datos].Cells["TipoM"].Value = prestamos.Tipo;
				dgvIngresos.Rows[datos].Cells["MontoTotal"].Value = prestamos.Precio;
				int dias = prestamos.Dias;
				int cantidad = prestamos.Cantidad;
				float precio = 0.66666666666f;
				if (prestamos.Tipo == "Película en Blu-ray")
					{
						total = (precio * cantidad) * dias;
						prestamos.Precio = total;
					}
				if (prestamos.Tipo == "Juego para cónsola")
					{
						precio = 0.5f;
						total = (precio * cantidad) * dias;
						prestamos.Precio = total;
					}
				if (prestamos.Tipo == "Colección de pistas MP3")
					{
						precio = 0.28571428571f;
						total = (precio * cantidad) * dias;
						prestamos.Precio = total;
					}
				}
				
				
		}
	
		private void calcularMonto()
		{
			float resultado = 0f;
			foreach (System.Windows.Forms.DataGridViewRow row in dgvIngresos.Rows)
			{
				resultado += Convert.ToSingle(row.Cells["MontoTotal"].Value);
			}
			lblMontoT.Text = resultado.ToString() + "$";
		}
		private void transferirDatosPrestamo()
		{
			if (File.Exists("archivoPrestamo.txt"))
			{
				string[] lineas = File.ReadAllLines("archivoPrestamo.txt");
			foreach (string linea in lineas) 
			{
				string[] partes = linea.Split(';');
				Prestamo x = new Prestamo() {Cedula = int.Parse(partes[0]), Nombres = partes[1], Apellidos = partes[2], DireccionH = partes[3], Fecha = partes[4], FechaDevol = partes[5], Codigo = partes[6], Titulo = partes[7], Tipo = partes[8], Cantidad = int.Parse(partes[9]), Precio = int.Parse(partes[10])};
				listPrestamo.Add(x);
				
			}
			}
		}
		

		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
	}
}
