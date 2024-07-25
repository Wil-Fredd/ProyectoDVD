
using System;

namespace Proyecto_POO.Models
{
	public class DVD
	{
		private string codigo;
		
		public string Codigo
		{
			get { return codigo; }
			set { codigo = value; }
		}
		
		private string titulo;
		
		public string Titulo
		{
			get { return titulo; }
			set { titulo = value; }
		}
		
		private string ano;
		
		public string Ano
		{
			get { return ano; }
			set { ano = value; }
		}
		
		private string tipo;
		
		public string Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}
		
		private string descrip;
		
		public string Descrip
		{
			get { return descrip; }
			set { descrip = value; }
		}
		
		private int cantidad;
		
		public int Cantidad
		{
			get { return cantidad; }
			set { cantidad = value; }
		}
		
		private string situacion;
		
		public string Situacion
		{
			get { return situacion; }
			set { situacion = value; }
		}
		
		private string fechaI;
		
		public string Fecha_I
		{
			get { return fechaI; }
			set { fechaI = value; }
		}
	}
}
