
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Proyecto_POO.Models;
using System.IO;

namespace Proyecto_POO.Forms
{
	public partial class FrmPrestamos : Form
	{
		List<Clientes> listClientes = new List<Clientes>();
		List<DVD> listDVD = new List<DVD>();
		List<Prestamo> listPrestamo = new List<Prestamo>();
		float total = 0.0f;
		
		public FrmPrestamos()
		{
			InitializeComponent();
			if (File.Exists("archivoDVD.txt"))
			{
				transferirDatosDVD();
			}
			if (File.Exists("archivoClientes.txt"))
			{
				transferirDatosClientes();
			}
			
			if (File.Exists("archivoPrestamo.txt"))
			{
				transferirDatosPrestamo();
			}
			cargarDatos();
			
		}
		void BtnSalirClick(object sender, EventArgs e)
		{
			DialogResult Respuesta = MessageBox.Show("¿Estás seguro que deseas salir?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (Respuesta == DialogResult.Yes)
				{
					Dispose();
				}				
		}
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			
			if (validarCedula() == false)
			{
				return;
			}
			Clientes miCliente = GetCedula(txtCedula.Text);
			if (miCliente == null)
			{
				erpError.SetError(txtCedula, "La Cédula de Identidad del cliente no se encuentra registrada en la lista de clientes");
				txtCedula.Focus();
				return;
			}
			if (validarCodigo() == false)
			{
				return;
			}
			
			Prestamo prestamo = new Prestamo();
			DVD misDVD = GetDVD(txtCodigo.Text);
			if (misDVD == null)
			{
				erpError.SetError(txtCodigo, "El código no está asignado a ningún DVD de la lista");
				txtCodigo.Focus();
				return;
			}
			if (validarDias() == false)
			{
				return;
			}
			else
			{
				erpError.SetError(txtCodigo, "");
				if (misDVD.Situacion == "No disponible")
				{
					erpError.SetError(txtCodigo, "El DVD no se encuentra disponible para préstamos");
					return;
				}
				else
				{
					int dias = int.Parse(txtDias.Text);
					int cantidad = misDVD.Cantidad;
					float precio = 0.66666666666f;
				prestamo.Cedula = miCliente.Cedula;
				prestamo.Nombres = miCliente.Nombres;
				prestamo.Apellidos = miCliente.Apellidos;
				prestamo.DireccionH = miCliente.DireccionH;
				prestamo.Fecha = dtpFecha.Text;
				prestamo.Codigo = misDVD.Codigo;
				prestamo.Titulo = misDVD.Titulo;
				
				if (misDVD.Tipo == "Película en Blu-ray")
				{
					dtpFechaDevol.Value = dtpFecha.Value.AddDays(dias);
					total = (precio * cantidad) * dias;
					prestamo.Precio = total;
				}
				if (misDVD.Tipo == "Juego para cónsola")
				{
					dtpFechaDevol.Value = dtpFecha.Value.AddDays(dias);
					precio = 0.5f;
					total = (precio * cantidad) * dias;
					prestamo.Precio = total;
				}
				if (misDVD.Tipo == "Colección de pistas MP3")
				{
					precio = 0.28571428571f;
					total = (precio * cantidad) * dias;
					prestamo.Precio = total;
					dtpFechaDevol.Value = dtpFecha.Value.AddDays(dias);
				}
				prestamo.Tipo = misDVD.Tipo;
				prestamo.Cantidad = misDVD.Cantidad;
				total = prestamo.Precio;
				prestamo.FechaDevol = dtpFechaDevol.Text;
				listPrestamo.Add(prestamo);
				
				StreamWriter archivoPrestamo = new StreamWriter("archivoPrestamo.txt", true);
					archivoPrestamo.WriteLine(prestamo.Cedula + ";" + prestamo.Nombres + ";" + prestamo.Apellidos + ";" + prestamo.DireccionH + ";" + prestamo.Fecha + ";" + prestamo.FechaDevol + ";" + prestamo.Codigo + ";" + prestamo.Titulo + ";" + prestamo.Tipo + ";" + prestamo.Cantidad + ";" + prestamo.Precio);
					archivoPrestamo.Close();
				int datos = dgvPrestamos.Rows.Add();
				foreach (Prestamo prestamos in listPrestamo) 
				{
				dgvPrestamos.Rows[datos].Cells["Cedula"].Value = prestamos.Cedula;
				dgvPrestamos.Rows[datos].Cells["Nombres"].Value = prestamos.Nombres;
				dgvPrestamos.Rows[datos].Cells["Apellidos"].Value = prestamos.Apellidos;
				dgvPrestamos.Rows[datos].Cells["Direccion_H"].Value = prestamos.DireccionH;
				dgvPrestamos.Rows[datos].Cells["Fecha"].Value = prestamos.Fecha;
				dgvPrestamos.Rows[datos].Cells["FechaDevol"].Value = prestamos.FechaDevol;
				dgvPrestamos.Rows[datos].Cells["CodigoDVD"].Value = prestamos.Codigo;
				dgvPrestamos.Rows[datos].Cells["Titulo"].Value = prestamos.Titulo;
				dgvPrestamos.Rows[datos].Cells["Tipo_medio"].Value = prestamos.Tipo;
				dgvPrestamos.Rows[datos].Cells["Cantidad"].Value = prestamos.Cantidad;
				dgvPrestamos.Rows[datos].Cells["MontoT"].Value = prestamos.Precio;
				}
				Clear();
				}
			}
		}
		
		void BtnConsultarClick(object sender, EventArgs e)
		{
			if (validarCedula() == false)
			{
				return;
			}
			if (validarCodigo() == false)
			{
				return;
			}
			Prestamo miCliente = GetCedulaC(txtCedula.Text);
			Prestamo miCliente2 = GetCodigo(txtCodigo.Text);
			if (miCliente == null)
			{
				erpError.SetError(txtCedula, "La Cédula de Identidad del cliente no se encuentra registrada en la lista de clientes");
				txtCedula.Focus();
				return;
			}
			else if (miCliente2 == null)
			{
				erpError.SetError(txtCodigo, "El código no se encuentra registrado en la lista de prestamos");
				txtCodigo.Focus();
				return;
			}
			else
			{
				erpError.SetError(txtCedula, "");
				txtCedula.Text = miCliente2.Cedula.ToString();
				dtpFecha.Text = miCliente2.Fecha;
				dtpFechaDevol.Text = miCliente2.FechaDevol;
				txtDias.Text = miCliente.Dias.ToString();
				txtCodigo.Text = miCliente2.Codigo;
			}
		}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if (validarCedula() == false)
			{
				return;
			}
			if (validarCodigo() == false)
			{
				return;
			}
			Prestamo miCliente = GetCedulaC(txtCedula.Text);
			Prestamo miCliente2 = GetCodigo(txtCodigo.Text);
			if (miCliente == null)
			{
				erpError.SetError(txtCedula, "La Cédula de Identidad del cliente no se encuentra registrada en la lista de clientes");
				txtCedula.Focus();
				return;
			}
			else if (miCliente2 == null)
			{
				erpError.SetError(txtCodigo, "El código no se encuentra registrado en la lista de prestamos");
				txtCodigo.Focus();
				return;
			}
			else
			{
				DialogResult Respuesta = MessageBox.Show("¿Estás seguro que desea eliminar el registro?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (Respuesta == DialogResult.Yes)
				{
					listPrestamo.Remove(miCliente2);
					File.Delete("archivoPrestamo.txt");
					StreamWriter archivoTemp = new StreamWriter("archivoTemp.txt", true);
					foreach (Prestamo newPrestamo in listPrestamo)
					{
						archivoTemp.WriteLine(newPrestamo.Cedula + ";" + newPrestamo.Nombres + ";" + newPrestamo.Apellidos + ";" + newPrestamo.DireccionH + ";" + newPrestamo.Fecha + ";" + newPrestamo.FechaDevol + ";" + newPrestamo.Codigo + ";" + newPrestamo.Titulo + ";" + newPrestamo.Tipo + ";" + newPrestamo.Cantidad + ";" + newPrestamo.Precio);
					}
					archivoTemp.Close();
					File.Move("archivoTemp.txt", "archivoPrestamo.txt");
				}
			}
			Clear();
		}
		private void cargarDatos()
		{
				foreach (Prestamo prestamos in listPrestamo) 
				{
				int datos = dgvPrestamos.Rows.Add();
				dgvPrestamos.Rows[datos].Cells["Cedula"].Value = prestamos.Cedula;
				dgvPrestamos.Rows[datos].Cells["Nombres"].Value = prestamos.Nombres;
				dgvPrestamos.Rows[datos].Cells["Apellidos"].Value = prestamos.Apellidos;
				dgvPrestamos.Rows[datos].Cells["Direccion_H"].Value = prestamos.DireccionH;
				dgvPrestamos.Rows[datos].Cells["Fecha"].Value = prestamos.Fecha;
				dgvPrestamos.Rows[datos].Cells["FechaDevol"].Value = prestamos.FechaDevol;
				dgvPrestamos.Rows[datos].Cells["CodigoDVD"].Value = prestamos.Codigo;
				dgvPrestamos.Rows[datos].Cells["Titulo"].Value = prestamos.Titulo;
				dgvPrestamos.Rows[datos].Cells["Tipo_medio"].Value = prestamos.Tipo;
				dgvPrestamos.Rows[datos].Cells["Cantidad"].Value = prestamos.Cantidad;
				dgvPrestamos.Rows[datos].Cells["MontoT"].Value = prestamos.Precio;
				}
		}
		
		private Clientes GetCedula(string cedula)
		{
			return listClientes.Find(micedula => micedula.Cedula.ToString().Contains(cedula));
		}
		private Prestamo GetCedulaC(string cedula)
		{
			return listPrestamo.Find(micedula => micedula.Cedula.ToString().Contains(cedula));
		}
		private DVD GetDVD(string codigo)
		{
			return listDVD.Find(dvd => dvd.Codigo.Contains(codigo));
		}
		private Prestamo GetCodigo(string codigo)
		{
			return listPrestamo.Find(dvd => dvd.Codigo.Contains(codigo));
		}
		private void transferirDatosClientes()
		{
			if (File.Exists("archivoClientes.txt"))
			{
				string[] lineas = File.ReadAllLines("archivoClientes.txt");
			foreach (string linea in lineas) 
				{
				string[] partes = linea.Split(';');
				Clientes clientes = new Clientes() {Cedula = int.Parse(partes[0]), Nombres = partes[1], Apellidos = partes[2], FechaN = partes[3], DireccionH = partes[4], Correo = partes[5], Telefono = int.Parse(partes[6]), N_Residencia = int.Parse(partes[7])};
				listClientes.Add(clientes);
				}
			}
		}
		private void transferirDatosDVD()
		{
			if (File.Exists("archivoDVD.txt"))
			{
				string[] lineas = File.ReadAllLines("archivoDVD.txt");
			foreach (string linea in lineas) 
			{
				string[] partes = linea.Split(';');
				DVD dvd = new DVD() {Codigo = partes[0], Titulo = partes[1], Ano = partes[2], Tipo = partes[3], Cantidad = int.Parse(partes[4]), Fecha_I = partes[5], Situacion = partes[6], Descrip = partes[7]};
				listDVD.Add(dvd);
			}
			}
			
		}
		private void transferirDatosPrestamo()
		{
			string[] lineas = File.ReadAllLines("archivoPrestamo.txt");
			foreach (string linea in lineas) 
			{
				string[] partes = linea.Split(';');
				Prestamo x = new Prestamo() {Cedula = int.Parse(partes[0]), Nombres = partes[1], Apellidos = partes[2], DireccionH = partes[3], Fecha = partes[4], FechaDevol = partes[5], Codigo = partes[6], Titulo = partes[7], Tipo = partes[8], Cantidad = int.Parse(partes[9]), Precio = int.Parse(partes[10])};
				listPrestamo.Add(x);
			}
		}
		void BtnActualizarClick(object sender, EventArgs e)
		{
			dgvPrestamos.Rows.Clear();
			foreach (Prestamo prestamos in listPrestamo) 
				{
				int datos = dgvPrestamos.Rows.Add();
				dgvPrestamos.Rows[datos].Cells["Cedula"].Value = prestamos.Cedula;
				dgvPrestamos.Rows[datos].Cells["Nombres"].Value = prestamos.Nombres;
				dgvPrestamos.Rows[datos].Cells["Apellidos"].Value = prestamos.Apellidos;
				dgvPrestamos.Rows[datos].Cells["Direccion_H"].Value = prestamos.DireccionH;
				dgvPrestamos.Rows[datos].Cells["Fecha"].Value = prestamos.Fecha;
				dgvPrestamos.Rows[datos].Cells["FechaDevol"].Value = prestamos.FechaDevol;
				dgvPrestamos.Rows[datos].Cells["CodigoDVD"].Value = prestamos.Codigo;
				dgvPrestamos.Rows[datos].Cells["Titulo"].Value = prestamos.Titulo;
				dgvPrestamos.Rows[datos].Cells["Tipo_medio"].Value = prestamos.Tipo;
				dgvPrestamos.Rows[datos].Cells["Cantidad"].Value = prestamos.Cantidad;
				dgvPrestamos.Rows[datos].Cells["MontoT"].Value = prestamos.Precio;
				}
			Clear();
			
		}
		// ------- * LIMPIAR CAMPOS * -------
		private void Clear()
		{
			txtCedula.Clear();
			txtDias.Clear();
			txtCodigo.Clear();
		}
		// ------- * VALIDACIONES * -------
		int num;
		private bool validarCedula()
		{		
			if(!int.TryParse(txtCedula.Text, out num) || txtCedula.Text == "")
			{
				erpError.SetError(txtCedula, "Debe ingresar un valor númerico");
				txtCedula.Focus();
				return false;
			}
			else
			{
				erpError.SetError(txtCedula, "");
				return true;
				}
			}
		private bool validarCodigo()
		{
			if(string.IsNullOrEmpty(txtCodigo.Text))
			{
				erpError.SetError(txtCodigo, "Debe ingresar un código");
				txtCodigo.Focus();
				return false;
			}
			else
			{
				erpError.SetError(txtCodigo, "");
				return true;
			}
		}
		private bool validarDias()
		{		
			if(!int.TryParse(txtDias.Text, out num) || txtDias.Text == "")
			{
				erpError.SetError(txtDias, "Debe ingresar un valor númerico");
				txtDias.Focus();
				return false;
			}
			else
			{
				erpError.SetError(txtDias, "");
				return true;
				}
			}
	}
}
