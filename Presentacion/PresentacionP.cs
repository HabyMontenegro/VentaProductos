using Negocio.FuncionesConsola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class PresentacionP
    {
        MetodosCrudClienteCasual CRUD = new MetodosCrudClienteCasual();
        public void MenuSecundario()
        {
            int opp;

            do
            {
                Console.WriteLine("1. Archivo Cliente casual");
                Console.WriteLine("2. Archivo cliente Regular");
                Console.WriteLine("3. Salir");
                opp = int.Parse(Console.ReadLine());

                switch (opp)
                {
                    case 1:

                        CRUD.CrearClienteCasual();

                        break;

                    case 2:
                        break;

                    case 3:
                        break;
                }


            } while (opp != 3);
        }
    }
}
