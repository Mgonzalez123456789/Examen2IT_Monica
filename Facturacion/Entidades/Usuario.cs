using System;

namespace Entidades
{
    public class Usuario
    {
        public string CodigoUsuario { get; set; }

        public string Nombre { get; set; }

        public string Correo { get; set; }

        public DateTime FechaCreacion { get; set; }

        public string Rol { get; set; }

        public bool EstadoActivo { get; set; }

        public Usuario()
        {
        }

        public Usuario(string codigoUsuario, string nombre, string correo, DateTime fechaCreacion, string rol, bool estadoActivo)
        {
            CodigoUsuario = codigoUsuario;
            Nombre = nombre;
            Correo = correo;
            FechaCreacion = fechaCreacion;
            Rol = rol;
            EstadoActivo = estadoActivo;
        }
    }

}
