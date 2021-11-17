using System;
using System.Collections.Generic;
using System.Text;

namespace ApliEmpleados
{
  public class BaseAtri
  {
        private int Cedula;
        public int CEDULA
        {
            get { return Cedula; }
            set { Cedula = value; }
        }

        private int Codigo;
        public int CODIGO
        {
            get { return Codigo; }
            set { Codigo = value; }
        }

        private string Nombre;
        public string NOMBRE
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        private string Apellido;
        public string APELLIDO
        {
            get { return Apellido; }
            set { Apellido = value; }
        }

        private string Email;
        public string EMAIL
        {
            get { return Email; }
            set { Email = value; }
        }

        private int Telefono;
        public int TELEFONO
        {
            get { return Telefono; }
            set { Telefono = value; }
        }

        private string Departamento;
        public string DEPARTAMENTO
        {
            get { return Departamento; }
            set { Departamento = value; }
        }


        private string Cargo;
        public string CARGO
        {
            get { return Cargo; }
            set { Cargo = value; }
        }

        private int PrecioPorHoras;
        public int PRECIOPORHORAS
        {
            get { return PrecioPorHoras; }
            set { PrecioPorHoras = value; }
        }

        private int HorasLaboradas;
        public int HORASLABORADAS
        {
            get { return HorasLaboradas; }
            set { HorasLaboradas = value; }
        }
       
  }
}
