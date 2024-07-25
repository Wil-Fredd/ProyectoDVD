
using System;
using System.Drawing;
using System.Windows.Forms;
using Proyecto_POO.Models;
using System.Collections.Generic;
using System.IO;

namespace Proyecto_POO.Forms
{

	public partial class FrmDVD : Form
	{
		List<DVD> listDVD = new List<DVD>();
		
		public FrmDVD()
		{		
			InitializeComponent();
			if (File.Exists("archivoDVD.txt"))
			{
				transferirDatos();
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
			DVD misDVD2 = GetCodigo(txtCodigo.Text);
			if (misDVD2 !=null)
			{
				erpError.SetError(txtCodigo, "El DVD ya está registrado en la lista");
				txtCodigo.Focus();
				return;
			}
			if (validarCodigo() == false)
			{
				return;
			}
			if (validarTitulo() == false)
			{
				return;
			}
			DVD misDVD = GetDVD(txtTitulo.Text);
			if (misDVD != null)
			{
				erpError.SetError(txtTitulo, "El título ya se encuentra registrado en la lista");
				txtTitulo.Focus();
				return;
			}
			if (validarAno() == false)
			{
				return;
			}
			if (validarTipo_Medio() == false)
			{
				return;
			}
			if (validarCantidad() == false)
			{
				return;
			}
			if (validarSituacion_Actual() == false)
			{
				return;
			}
			if (validarDescrip() == false)
			{
				return;
			}
			
			DVD miDVD = new DVD();
			miDVD.Codigo = txtCodigo.Text;
			miDVD.Titulo = txtTitulo.Text;
			miDVD.Ano = txtAno.Text;
			miDVD.Tipo = cmbTipo_Medio.SelectedItem.ToString();
			miDVD.Cantidad = Convert.ToInt32(txtCantidad.Text);
			miDVD.Fecha_I = dtpFechaI.Text;
			miDVD.Situacion = cmbSituacion.SelectedItem.ToString();
			miDVD.Descrip = txtDescrip.Text;
			
			listDVD.Add(miDVD);
			GuardarDatos();
			Clear();
		}
		
		private void GuardarDatos()
		{
			StreamWriter archivoDVD = new StreamWriter("archivoDVD.txt", true);
			archivoDVD.WriteLine(txtCodigo.Text + ";" + txtTitulo.Text + ";" + txtAno.Text + ";" + cmbTipo_Medio.SelectedItem + ";" + txtCantidad.Text + ";" + dtpFechaI.Text + ";" + cmbSituacion.SelectedItem + ";" + txtDescrip.Text);
			archivoDVD.Close();
		}

		void BtnConsultarClick(object sender, EventArgs e)
		{
			if(validarCodigo() == false)
			{
				return;
			}
			DVD misDVD2 = GetCodigo(txtCodigo.Text);
			if (misDVD2 == null)
			{
				erpError.SetError(txtCodigo, "El DVD no está registrado en la lista");
				txtCodigo.Focus();
				return;
			}
				else
				{
				erpError.SetError(txtCodigo, "");
				Clear();
				txtCodigo.Text = misDVD2.Codigo;
				txtTitulo.Text = misDVD2.Titulo;
				txtAno.Text = misDVD2.Ano;
				cmbTipo_Medio.SelectedItem = misDVD2.Tipo;
				txtCantidad.Text = misDVD2.Cantidad.ToString();
				dtpFechaI.Text = misDVD2.Fecha_I;
				cmbSituacion.SelectedItem = misDVD2.Situacion;
				txtDescrip.Text = misDVD2.Descrip;
				pbImage.Image = Image.FromFile(@txtTitulo.Text + ".jpg");
				}
				
			}	
		
		void BtnActualizarClick(object sender, EventArgs e)
		{
			
			Clear();
		}
		
		void BtnTablaClick(object sender, EventArgs e)
		{
			
			FrmTablaRegistro x = new FrmTablaRegistro();
			x.Show();
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{

			if (validarCodigo() == false)
			{
				return;
			}
			DVD miCliente2 = GetCodigo(txtCodigo.Text);
			if (miCliente2 == null)
			{
				erpError.SetError(txtCodigo, "El código no se encuentra registrado en la lista de prestamos");
				txtCodigo.Focus();
				return;
			}
			else
			{
				DialogResult Respuesta = MessageBox.Show("¿Estás seguro que desea eliminar el DVD?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (Respuesta == DialogResult.Yes)
				{
					listDVD.Remove(miCliente2);
					File.Delete("archivoDVD.txt");
					StreamWriter archivoTemp = new StreamWriter("archivoTemp.txt", true);
					foreach (DVD newdvd in listDVD)
					{
						archivoTemp.WriteLine(newdvd.Codigo + ";" + newdvd.Titulo  + ";" + newdvd.Ano  + ";" + newdvd.Tipo  + ";" + newdvd.Cantidad  + ";" + newdvd.Fecha_I  + ";" + newdvd.Situacion  + ";" + newdvd.Descrip);
						
					}
					archivoTemp.Close();
					File.Move("archivoTemp.txt", "archivoDVD.txt");
				}
			}
			Clear();
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
		
		private void transferirNuevosDatos()
		{
			string[] lineas = File.ReadAllLines("archivoTemp.txt");
					foreach (string linea in lineas) 
							{
								string[] partes = linea.Split(';');
								DVD dvd = new DVD() {Codigo = partes[0], Titulo = partes[1], Ano = partes[2], Tipo = partes[3], Cantidad = int.Parse(partes[4]), Fecha_I = partes[5], Situacion = partes[6], Descrip = partes[7]};
								listDVD.Add(dvd);
								}
		}
		private DVD GetDVD(string titulo)
		{
			return listDVD.Find(dvd => dvd.Titulo.Contains(titulo));
		}
		
		private DVD GetCodigo(string codigo)
		{
			return listDVD.Find(dvd => dvd.Codigo.Contains(codigo));
		}
		
		// ------- * LIMPIAR CAMPOS * -----
		private void Clear()
		{
			txtCodigo.Clear();
			txtTitulo.Clear();
			txtAno.Clear();
			txtCantidad.Clear();
			txtDescrip.Clear();
			cmbTipo_Medio.SelectedIndex = 0;
			cmbSituacion.SelectedIndex = 0;
			pbImage.Image = pbImage.Image = null;
		}
		// ------- * VALIDACIONES * -------
		int num;
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
		private bool validarTitulo()
		{
			if(string.IsNullOrEmpty(txtTitulo.Text))
			{
				erpError.SetError(txtTitulo, "Debe ingresar un título");
				txtTitulo.Focus();
				return false;
			}
			else
			{
				erpError.SetError(txtTitulo, "");
				return true;
			}
		}
		private bool validarAno()
		{
			if(string.IsNullOrEmpty(txtAno.Text))
			{
				erpError.SetError(txtAno, "Debe ingresar un año");
				txtAno.Focus();
				return false;
			}
			else
			{
				erpError.SetError(txtAno, "");
				return true;
			}
		}
		private bool validarTipo_Medio()
		{
			if (string.IsNullOrEmpty(cmbTipo_Medio.Text))
			{
				erpError.SetError(cmbTipo_Medio, "Debe ingresar un tipo de medio");
					return false;
			}
			else
			{
				erpError.SetError(cmbTipo_Medio, "");
				return true;
				}
			}
		
		private bool validarCantidad()
		{		
			if(!int.TryParse(txtCantidad.Text, out num) || txtCantidad.Text == "")
			{
				erpError.SetError(txtCantidad, "Debe ingresar un valor númerico");
				txtCantidad.Focus();
				return false;
			}
			else
			{
				erpError.SetError(txtCantidad, "");
				return true;
				}
			}
		private bool validarSituacion_Actual()
		{
			if (string.IsNullOrEmpty(cmbSituacion.Text))
			{
				erpError.SetError(cmbSituacion, "Debe ingresar una opción");
					return false;
			}
			else
			{
				erpError.SetError(cmbSituacion, "");
				return true;
				}
			}
		private bool validarDescrip()
		{
			if(string.IsNullOrEmpty(txtDescrip.Text))
			{
				erpError.SetError(txtDescrip, "Debe ingresar una descripción");
				txtDescrip.Focus();
				return false;
			}
			else
			{
				erpError.SetError(txtDescrip, "");
				return true;
			}
		}
		
	}
}
