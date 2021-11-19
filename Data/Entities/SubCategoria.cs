using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Entities
{
    public class SubCategoria
    {
        public int IdSubCategoria { get; set; }
        public int CSC_IdCategoria { get; set; }
        public string Descripcion { get; set; }

        public virtual Categoria Categoria { get; set; }

        public virtual ICollection<Articulo> Articulos { get; set; }
    }
}
