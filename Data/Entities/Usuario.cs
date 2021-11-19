using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Entities
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int TU_IdRol { get; set; }
        public string Nombre_Apellido { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Clave { get; set; }
        public string ConfirmarClave { get; set; }

        public virtual Rol Rol { get; set; }

        public virtual ICollection<Venta> Ventas { get; set; }
    }
}
