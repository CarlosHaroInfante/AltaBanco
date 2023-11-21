using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarDeAlta.Dtos;

namespace DarDeAlta.Servicios
{
    internal class CuentaImplementacion : CuentaInterfaz
    {
        public void nuevaCuenta(List<CuentasDto> cuentaAntigua)
        {
            CuentasDto cuentaNueva = new CuentasDto();
            cuentaAntigua.Add(cuentaNueva);

            Console.WriteLine("Datos de la Cuenta");

            Console.WriteLine("ID: ");
            cuentaNueva.IdCuenta = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("ISBAN: ");
            cuentaNueva.ISBANCuenta = Console.ReadLine();

            Console.WriteLine("Switch: ");
            cuentaNueva.CodigoSwitch = Console.ReadLine();

            Console.WriteLine("Fecha de Alta: ");
            cuentaNueva.FechaCuentaAlta = Console.ReadLine();


            
        }

    }
}
