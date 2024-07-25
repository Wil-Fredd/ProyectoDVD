
using System;
using System.Drawing;
using System.Windows.Forms;
using Proyecto_POO.Models;
using System.Collections.Generic;
using System.IO;


namespace Proyecto_POO.Forms
{
	public partial class FrmTablaRegistro : Form
	{
		
		List<DVD> listDVD = new List<DVD>();
		
		public FrmTablaRegistro()
		{	
			InitializeComponent();
			
			if(File.Exists("archivoDVD.txt"))
			{
				transferirDatos();
				cargarDatos();
			}
				
		}
		
		private void transferirDatos()
		{
			string[] lineas = File.ReadAllLines("archivoDVD.txt");
			foreach (string linea in lineas) 
			{
				string[] partes = linea.Split(';');
				DVD dvd = new DVD() {Codigo = partes[0], Titulo = partes[1], Ano = partes[2], Tipo = partes[3], Cantidad = int.Parse(partes[4]), Fecha_I = partes[5], Situacion = partes[6], Descrip = partes[7]};
				listDVD.Add(dvd);
			}
		}
		
		private void cargarDatos()
		{
				foreach (DVD dvd in listDVD) 
				{
				int datos = dgvDVD.Rows.Add();
				dgvDVD.Rows[datos].Cells["Codigo"].Value = dvd.Codigo;
				dgvDVD.Rows[datos].Cells["Titulo"].Value = dvd.Titulo;
				dgvDVD.Rows[datos].Cells["Lanzamiento"].Value = dvd.Ano;
				dgvDVD.Rows[datos].Cells["Tipo"].Value = dvd.Tipo;
				dgvDVD.Rows[datos].Cells["Cantidad"].Value = dvd.Cantidad;
				dgvDVD.Rows[datos].Cells["FechaI"].Value = dvd.Fecha_I;
				dgvDVD.Rows[datos].Cells["Situacion"].Value =dvd.Situacion;
				dgvDVD.Rows[datos].Cells["Descripcion"].Value = dvd.Descrip;
				}
		}
		
	}
}
