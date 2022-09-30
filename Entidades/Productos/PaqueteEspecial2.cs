using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PaqueteEspecial2:ProductoClienteRegular
    {
        public int CantidadPeluches { get; set; }
        public string ColorPeluches { get; set; }
        public int CantidadRetratos { get; set; }
    }
}
