using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class MenuPrincipal
    {
        PresentacionP Present = new PresentacionP();
        //Logica.FuncionesConsola.MétodosCrud Crud = new Logica.FuncionesConsola.MétodosCrud();
        public void MostrarMp()
        {
            int op;

            do
            {
                Console.Clear();

                Console.WriteLine("1. Crear archivo cliente (Solo primera vez)");
                Console.WriteLine("2. Mostrar lista clientes");
                Console.WriteLine("3. Agregar Cliente");
                Console.WriteLine("4. Modificar Información");
                Console.WriteLine("5. Eliminar Cliente");
                Console.WriteLine("6. Salir");

                Console.WriteLine("Escoja una opción: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:

                        Present.MenuSecundario();

                        break;

                    case 2:

                        break;

                    case 3:

                        break;

                    case 4:

                        break;

                    case 5:

                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("GRACIAS, VUELVA PRONTO");
                        Console.ReadKey();

                        break;
                }

            } while (op != 6);
        }
    }
}
