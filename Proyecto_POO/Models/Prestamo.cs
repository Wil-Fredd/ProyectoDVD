
using System;

namespace Proyecto_POO.Models
{
	public class Prestamo
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
		private string direccionH;
		
		public string DireccionH
		{
			get { return direccionH; }
			set { direccionH = value; }
		}
		
		private string titulo;
		
		public string Titulo
		{
			get { return titulo; }
			set { titulo = value; }
		}
		
		private string fecha;
		
		public string Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}
		private string fechaDevol;
		
		public string FechaDevol
		{
			get { return fechaDevol; }
			set { fechaDevol = value; }
		}
		private string tipo;
		
		public string Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}
		
		private float precio;
		
		public float Precio
		{
			get { return precio; }
			set { precio = value; }
		}
		private string codigo;
		
		public string Codigo
		{
			get { return codigo; }
			set { codigo = value; }
		}
		private int cantidad;
		
		public int Cantidad
		{
			get { return cantidad; }
			set { cantidad = value; }
		}
		
		private int dias;
		
		public int Dias
		{
			get { return dias; }
			set { dias = value; }
		}
	}
}
