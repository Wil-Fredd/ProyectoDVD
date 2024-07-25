
using System;

namespace Proyecto_POO.Models
{

	public class Clientes
	{
		private int cedula;
		
		public int Cedula
		{
			get { return cedula; }
			set { cedula = value; }
		}
		
		private string nombres;
		
		public string Nombres
		{
			get { return nombres; }
			set { nombres = value; }
		}
		
		private string apellidos;
		
		public string Apellidos
		{
			get { return apellidos; }
			set { apellidos = value; }
		}
		
		private string fechaN;
		
		public string FechaN
		{
			get { return fechaN; }
			set { fechaN = value; }
		}
		
		private string direccionH;
		
		public string DireccionH
		{
			get { return direccionH; }
			set { direccionH = value; }
		}
		
		private string correo;
		
		public string Correo
		{
			get { return correo; }
			set { correo = value; }
		}
		
		private int telefono;
		
		public int Telefono
		{
			get { return telefono; }
			set { telefono = value; }
		}
		
		private int n_residencia;
		
		public int N_Residencia
		{
			get { return n_residencia; }
			set { n_residencia = value; }
		}
		
		private string fecha_registro;
		
		public string Fecha_Registro
		{
			get { return fecha_registro; }
			set { fecha_registro = value; }
		}
	}
}
