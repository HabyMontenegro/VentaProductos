using Entidades.Roles;
using Negocio.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Implementaciones
{
    public class ServicioClienteCasual:IServicioClienteCasual
    {
        public static List<ClienteCasual> ClientesCasuales = new List<ClienteCasual>();
        public bool creare(ClienteCasual NuevoClienteCasual)
        {
            if (NuevoClienteCasual == null) { return false; }
            else { ClientesCasuales.Add(NuevoClienteCasual); return true; }
        }

        public List<ClienteCasual> Read()
        {
            throw new NotImplementedException();
        }
    }
}
