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

    }


}
