//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CovalcoWebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alumno
    {
		public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }

		public Alumno()	{}
		public Alumno(string nombre, string apellidos, string dni)
		{
			Nombre = nombre;
			Apellidos = apellidos;
			Dni = dni;
		}
	}
}