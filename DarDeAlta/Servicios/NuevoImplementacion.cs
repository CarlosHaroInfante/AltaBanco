using DarDeAlta.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DarDeAlta.Servicios
{
    internal class NuevoImplementacion : NuevoInterfaz
    {


        public void darAltaCliente(List<ClientesDto> listaAntigua) { 
       

            ClientesDto clienteNuevo = new ClientesDto();
             listaAntigua.Add(clienteNuevo);
        
        
        /// <summary>
        /// Implementación donde se pondrán los datos del usuario y lo añadirá a la lista.
        /// 171123 - chi
        /// </summary>
       
            

            Console.WriteLine("Datos del usuario");

            Console.WriteLine("ID: ");
            clienteNuevo.IdCliente = Convert.ToInt64(Console.ReadLine());
            long idClient = clienteNuevo.IdCliente;

            Console.WriteLine("Nombre: ");
            clienteNuevo.NombreCliente = Console.ReadLine();

            Console.WriteLine("Apellidos: ");
            clienteNuevo.ApellidosCliente = Console.ReadLine();

            Console.WriteLine("DNI: ");
            clienteNuevo.DniCliente = Console.ReadLine();

            Console.WriteLine("Fecha de nacimiento: ");
            clienteNuevo.FchNacimientoCliente = Console.ReadLine();

            Console.WriteLine("email: ");
            clienteNuevo.EmailCliente = Console.ReadLine();

            Console.WriteLine("Tlf: ");
            clienteNuevo.TlfCliente = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fecha de Alta: ");
            clienteNuevo.FchAltaCliente = Console.ReadLine();

           

        }



    }
}
