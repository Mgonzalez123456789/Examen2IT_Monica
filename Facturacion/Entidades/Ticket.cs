using System;

namespace Entidades
{
    public class Tickect
    {
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public string Cliente { get; set; }
        public String TipoSoporte { get; set; }
        public String DescripcionSolicitud { get; set; }
        public String DescripcionRespuesta { get; set; }
        public decimal Precio { get; set; }
        public decimal ISV { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }

        public Tickect()
        {
        }

        public Tickect(DateTime fecha, string usuario, string cliente, string tipoSoporte, string descripcionSolicitud, string descripcionRespuesta, decimal precio, decimal iSV, decimal descuento, decimal total)
        {
            Fecha = fecha;
            Usuario = usuario;
            Cliente = cliente;
            TipoSoporte = tipoSoporte;
            DescripcionSolicitud = descripcionSolicitud;
            DescripcionRespuesta = descripcionRespuesta;
            Precio = precio;
            ISV = iSV;
            Descuento = descuento;
            Total = total;
        }
    }


}
