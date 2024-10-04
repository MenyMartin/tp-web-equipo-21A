using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Categoria
    {
        public int IdCat { get; set; }
        public string DescripcionCat { get; set; }


        public override string ToString()
        {
            return DescripcionCat;
        }


    }
}
