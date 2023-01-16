using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }

        private decimal _PrecioBruto;

        public decimal PrecioBruto
        {
            get
            {
                _PrecioBruto = PrecioCosto * Convert.ToDecimal(1 + this.Margen);
                return _PrecioBruto;
            }
        }

        private decimal _PrecioVenta;
        public decimal PrecioVenta
        {
            get
            {
                _PrecioVenta = PrecioBruto * Convert.ToDecimal(1 + this.IVA);
                return _PrecioVenta;
            }
        }
        public string Proveedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }



    }
}
