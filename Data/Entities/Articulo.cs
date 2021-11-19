using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaArtesaniasMarielos.Data.Entities
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public int Stock { get; set; }

        public int StockMinimo { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int TA_IdSubCategoria { get; set; }
        public int TA_IdTalla_Medida { get; set; }
        public int TA_IdEtapa { get; set; }
        public int TA_IdGenero { get; set; }
        public int TA_IdMaterial { get; set; }

        public virtual ICollection<DetalleVenta> DetalleVentas { get; set; }
        public virtual SubCategoria SubCategoria { get; set; }
        public virtual Talla_Medida Talla_Medida { get; set; }
        public virtual Etapa Etapa { get; set; }

        public virtual Genero Genero { get; set; }
        public virtual Material Material { get; set; }
    }
}
