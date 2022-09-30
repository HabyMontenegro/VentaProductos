using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Roles
{
    public class ClienteCasual:Cliente
    {
        public ClienteCasual(int Id, string NP, string Ag1, string Ag2, string Ag3, int Nca)
        {

            this.Id = Id;
            this.NombrePersona = NP;
            this.Agregado1 = Ag1;
            this.Agregado2 = Ag2;
            this.Agregado3 = Ag3;
            this.Ncartas = Nca;
        }
        public int Ncartas { get; set; }
    }
}
