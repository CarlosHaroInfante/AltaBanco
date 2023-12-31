﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarDeAlta.Servicios;


namespace DarDeAlta.Dtos
{
    /// <summary>
    /// lista donde se encuentran cuales serán los tipos de datos a introducir (int, string, etc).
    /// 171123 - chi
    /// </summary>
    internal class ClientesDto
    {
        //Atributos (Caracteristicas)
        //Son private por defecto

        long idCliente; //PK

        string nombreCliente = "aaaaa";

        string apellidosCliente = "aaaaa";

        string dniCliente = "aaaaa";

        string fchNacimientoCliente = "9999/12/31";

        string emailCliente = "aaaaa";

        int tlfCliente = 111111111;

        string fchAltaCliente = "9999/12/31";

        string fchBajaCliente = "9999/12/31";

       
        //Getter y Setter
        
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string FchNacimientoCliente { get => fchNacimientoCliente; set => fchNacimientoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public int TlfCliente { get => tlfCliente; set => tlfCliente = value; }
        public string FchAltaCliente { get => fchAltaCliente; set => fchAltaCliente = value; }
        public string FchBajaCliente { get => fchBajaCliente; set => fchBajaCliente = value; }

        //Contructores (métodos que crean copias)
        public ClientesDto(long idCliente, string nombreCliente, string apellidosCliente, string dniCliente, string fchNacimientoCliente, string emailCliente, int tlfCliente, string fchAltaCliente)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.dniCliente = dniCliente;
            this.fchNacimientoCliente = fchNacimientoCliente;
            this.emailCliente = emailCliente;
            this.tlfCliente = tlfCliente;
            this.fchAltaCliente = fchAltaCliente;
            
        }

        public ClientesDto() { }

        override
            public string ToString()
            {
            string clienteString = 
            "Nombre: " + this.nombreCliente +
            "Apellidos: " + this.apellidosCliente +
            "DNI: " + this.dniCliente +
            "Fecha de Nacimiento: " + this.fchNacimientoCliente +
            "email: " + this.emailCliente +
            "Telf: " + this.tlfCliente +
            "Fecha de Alta: " + this.fchAltaCliente +
            "Fecha de Baja: " + this.fchBajaCliente;

            return clienteString;
               
             }
    }

    internal class CuentasDto
    {
        long idCuenta;

        string iSBANCuenta = "aaaaa";

        string codigoSwitch = "CSI1SSXX";

        long idCLiente;

        string fechaCuentaAlta = "aaaaa";

        string fechaCuentaBaja = "aaaaa";

        //Getter y Setter
        public long IdCuenta { get => idCuenta; set => idCuenta = value; }
        public string ISBANCuenta { get => iSBANCuenta; set => iSBANCuenta = value; }
        public string CodigoSwitch { get => codigoSwitch; set => codigoSwitch = value; }
        public long IdCLiente { get => idCLiente; set => idCLiente = value; }
        public string FechaCuentaAlta { get => fechaCuentaAlta; set => fechaCuentaAlta = value; }
        public string FechaCuentaBaja { get => fechaCuentaBaja; set => fechaCuentaBaja = value; }


        public CuentasDto(long idCuenta, string iSBANCuenta, string codigoSwitch, long idCLiente, string fechaCuentaAlta, string fechaCuentaBaja)

        {
            this.idCuenta = idCuenta;
            this.iSBANCuenta = iSBANCuenta;
            this.codigoSwitch = codigoSwitch;
            this.idCLiente = idCLiente;
            this.fechaCuentaAlta = fechaCuentaAlta;
            this.fechaCuentaBaja = fechaCuentaBaja;
        }

        public CuentasDto(){}

       /*public string ToString()
        {
            string objeto = this.codigoSwitch + "CSI1SSXX", codigoSwitch;
            return objeto;
        }*/
    }
}
