using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Voucher
    {
        public string codigo { get; set; }
        public int idCliente { get; set; }
        public DateTime fechaCanje { get; set; }
        public string idArticulo { get; set; }
    }
}
