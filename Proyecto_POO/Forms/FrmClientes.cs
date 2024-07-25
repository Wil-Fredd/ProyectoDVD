
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using Proyecto_POO.Models;
using System.IO;

namespace Proyecto_POO.Forms
{
	public partial class FrmClientes : Form
	{
		List<Clientes> listClientes = new List<Clientes>();
		public FrmClientes()
		{
			InitializeComponent();
			if (File.Exists("archivoClientes.txt"))
			{
				transferirDatos();
				cargarDatos();
			}
			
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
			if (miCliente != null)
			{
				erpError.SetError(txtCedula, "La Cédula de Identidad se encuentra registrada en la lista");
				txtCedula.Focus();
				return;
			}
			if (validarNombres() == false)
			{
				return;
			}
			if (validarApellidos() == false)
			{
				return;
			}
			if (validarDireccionH() == false)
			{
				return;
			}
			if (validarCorreo() == false)
			{
				return;
			}
			if (validarTelefono() == false)
			{
				return;
			}
			if (validarNumeroResidencia() == false)
			{
				return;
			}
			
			Clientes misClientes = new Clientes();
			misClientes.Cedula = Convert.ToInt32(txtCedula.Text);
			misClientes.Nombres = txtNombres.Text;
			misClientes.Apellidos = txtApellidos.Text;
			misClientes.FechaN = dtpFecha.Text;
			misClientes.DireccionH = txtDireccionH.Text;
			misClientes.Correo = txtCorreo.Text;
			misClientes.Telefono = Convert.ToInt32(txtTelefono.Text);
			misClientes.N_Residencia = Convert.ToInt32(txtNumeroResidencia.Text);
			listClientes.Add(misClientes);
			GuardarDatos();
			Clear();
		}
		
		private void GuardarDatos()
		{
			StreamWriter archivoClientes = new StreamWriter("archivoClientes.txt", true);
			archivoClientes.WriteLine(txtCedula.Text + ";" + txtNombres.Text + ";" + txtApellidos.Text + ";" + dtpFecha.Text + ";" + txtDireccionH.Text + ";" + txtCorreo.Text + ";" + txtTelefono.Text + ";" + txtNumeroResidencia.Text);
			archivoClientes.Close();
		}
		
		void BtnConsultarClick(object sender, EventArgs e)
		{
			if (validarCedula() == false)
			{
				return;
			}
			
			Clientes miCliente = GetCedula(txtCedula.Text);
			if (miCliente == null)
			{
				erpError.SetError(txtCedula, "La Cédula de Identidad no está registrada en la lista");
				txtCedula.Focus();
				return;
			}
			else
			{
				erpError.SetError(txtCedula, "");
				txtCedula.Text = miCliente.Cedula.ToString();
				txtNombres.Text = miCliente.Nombres;
				txtApellidos.Text = miCliente.Apellidos;
				dtpFecha.Text = miCliente.FechaN;
				txtDireccionH.Text = miCliente.DireccionH;
				txtCorreo.Text = miCliente.Correo;
				txtTelefono.Text = miCliente.Telefono.ToString();
				txtNumeroResidencia.Text = miCliente.N_Residencia.ToString();
			}
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
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
			else
			{
				DialogResult Respuesta = MessageBox.Show("¿Estás seguro que desea eliminar el cliente?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (Respuesta == DialogResult.Yes)
				{
					listClientes.Remove(miCliente);
					File.Delete("archivoClientes.txt");
					StreamWriter archivoTemp = new StreamWriter("archivoTemp.txt", true);
					foreach (Clientes newClientes in listClientes)
					{
						archivoTemp.WriteLine(newClientes.Cedula + ";" + newClientes.Nombres + ";" + newClientes.Apellidos + ";" + newClientes.FechaN + ";" + newClientes.DireccionH + ";" + newClientes.Correo + ";" + newClientes.Telefono + ";" + newClientes.N_Residencia);
					}
					archivoTemp.Close();
					File.Move("archivoTemp.txt", "archivoClientes.txt");
					Clear();
				}
			}			
		}
		
		private Clientes GetCedula(string cedula)
		{
			return listClientes.Find(micedula => micedula.Cedula.ToString().Contains(cedula));
		}
		
		private void transferirDatos()
		{
			string[] lineas = File.ReadAllLines("archivoClientes.txt");
			foreach (string linea in lineas) 
			{
				string[] partes = linea.Split(';');
				Clientes clientes = new Clientes() {Cedula = int.Parse(partes[0]), Nombres = partes[1], Apellidos = partes[2], FechaN = partes[3], DireccionH = partes[4], Correo = partes[5], Telefono = int.Parse(partes[6]), N_Residencia = int.Parse(partes[7])};
				listClientes.Add(clientes);
			}
		}
		
		private void cargarDatos()
		{
			foreach (Clientes clientes in listClientes) 
				{
				int datos = dgvClientes.Rows.Add();
				dgvClientes.Rows[datos].Cells["Cedula"].Value = clientes.Cedula;
				dgvClientes.Rows[datos].Cells["Nombres"].Value = clientes.Nombres;
				dgvClientes.Rows[datos].Cells["Apellidos"].Value = clientes.Apellidos;
				dgvClientes.Rows[datos].Cells["FechaN"].Value = clientes.FechaN;
				dgvClientes.Rows[datos].Cells["DireccionH"].Value = clientes.DireccionH;
				dgvClientes.Rows[datos].Cells["Correo"].Value = clientes.Correo;
				dgvClientes.Rows[datos].Cells["Telefono"].Value = clientes.Telefono;
				dgvClientes.Rows[datos].Cells["NumeroR"].Value = clientes.N_Residencia;

				}
		}
		
				void BtnActualizarClick(object sender, EventArgs e)
		{
					dgvClientes	.Rows.Clear();
					foreach (Clientes clientes in listClientes) 
				{
				int datos = dgvClientes.Rows.Add();
				dgvClientes.Rows[datos].Cells["Cedula"].Value = clientes.Cedula;
				dgvClientes.Rows[datos].Cells["Nombres"].Value = clientes.Nombres;
				dgvClientes.Rows[datos].Cells["Apellidos"].Value = clientes.Apellidos;
				dgvClientes.Rows[datos].Cells["FechaN"].Value = clientes.FechaN;
				dgvClientes.Rows[datos].Cells["DireccionH"].Value = clientes.DireccionH;
				dgvClientes.Rows[datos].Cells["Correo"].Value = clientes.Correo;
				dgvClientes.Rows[datos].Cells["Telefono"].Value = clientes.Telefono;
				dgvClientes.Rows[datos].Cells["NumeroR"].Value = clientes.N_Residencia;
				}
				Clear();
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
		private bool validarNombres()
		{
			if(string.IsNullOrEmpty(txtNombres.Text))
			{
				erpError.SetError(txtNombres, "Debe ingresar sus nombres");
				txtNombres.Focus();
				return false;
			}
			else
			{
				erpError.SetError(txtNombres, "");
				return true;
			}
		}
		private bool validarApellidos()
		{
			if(string.IsNullOrEmpty(txtApellidos.Text))
			{
				erpError.SetError(txtApellidos, "Debe ingresar sus apellidos");
				txtApellidos.Focus();
				return false;
			}
			else
			{
				erpError.SetError(txtApellidos, "");
				return true;
			}
		}
		private bool validarDireccionH()
		{
			if(string.IsNullOrEmpty(txtDireccionH.Text))
			{
				erpError.SetError(txtDireccionH, "Debe ingresar la dirección de habitación");
				txtDireccionH.Focus();
				return false;
			}
			else
			{
				erpError.SetError(txtDireccionH, "");
				return true;
			}
		}
		
		private bool validarCorreo()
		{
			if(string.IsNullOrEmpty(txtCorreo.Text))
			{
				erpError.SetError(txtCorreo, "Debe ingresar la dirección de habitación");
				txtCorreo.Focus();
				return false;
			}
			else
			{
				erpError.SetError(txtCorreo, "");
				return true;
			}
		}
		private bool validarTelefono()
		{		
			if(!int.TryParse(txtTelefono.Text, out num) || txtTelefono.Text == "")
			{
				erpError.SetError(txtTelefono, "Debe ingresar un valor númerico");
				txtTelefono.Focus();
				return false;
			}
			else
			{
				erpError.SetError(txtTelefono, "");
				return true;
				}
			}
		private bool validarNumeroResidencia()
		{		
			if(!int.TryParse(txtNumeroResidencia.Text, out num) || txtNumeroResidencia.Text == "")
			{
				erpError.SetError(txtNumeroResidencia, "Debe ingresar un valor númerico");
				txtNumeroResidencia.Focus();
				return false;
			}
			else
			{
				erpError.SetError(txtNumeroResidencia, "");
				return true;
				}
			}
		// ------- * LIMPIAR CAMPOS * -----
		private void Clear()
		{
			txtCedula.Clear();
			txtNombres.Clear();
			txtApellidos.Clear();
			txtDireccionH.Clear();
			txtCorreo.Clear();
			txtTelefono.Clear();
			txtNumeroResidencia.Clear();
		}
	}
}
