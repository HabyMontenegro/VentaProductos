using Entidades.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Servicios
{
    public interface IServicioClienteCasual
    {
        bool creare(ClienteCasual NuevoClienteCasual);

        List<ClienteCasual> Read();
    }
}
