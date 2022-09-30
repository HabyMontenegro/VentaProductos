using Entidades.Roles;
using Negocio.Implementaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.FuncionesConsola
{
    public class MetodosCrudClienteCasual
    {
        ServicioClienteCasual SClienteCasual = new ServicioClienteCasual();

        public void CrearClienteCasual()
        {
            int Id = 0;
            string NombrePersona = " ";
            string Agregado1 = " ";
            string Agregado2 = " ";
            string Agregado3 = " ";
            int Ncartas = 0;

            Console.WriteLine("Escriba el ID");
            Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el Nombre: ");
            NombrePersona = Console.ReadLine();

            Console.WriteLine("Escriba el primer producto: ");
            Agregado1 = Console.ReadLine();

            Console.WriteLine("Escriba el segundo agregado: ");
            Agregado2 = Console.ReadLine();

            Console.WriteLine("Escriba el tercer agregado: ");
            Agregado3 = Console.ReadLine();

            Console.WriteLine("Escriba la cantidad de cartar que tendrá su regalo: ");
            Ncartas = int.Parse(Console.ReadLine());

            ClienteCasual clienteCasual = new ClienteCasual(Id, NombrePersona, Agregado1, Agregado2, Agregado3, Ncartas);

            if (clienteCasual == null) { Console.WriteLine("No hay cliente casual registrado"); }
            else
            {
                //IMPLEMENTACION
                SClienteCasual.creare(clienteCasual);

                Console.WriteLine("\nCliente registrado con exito: ");
                Console.Write("\nPRESIONE ENTER PARA CONTINUAR...");
                Console.ReadKey();
            }
        }

        public void EditarClienteCasual()
        {

        }

        public void MostrarClienteCasual()
        {

        }

        public void EliminarClienteCasual()
        {

        }
    }
}
