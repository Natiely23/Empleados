using System;
using System.Collections.Generic;
using System.Text;

namespace ApliEmpleados
{
    public class Menu:  BaseAtri
    {
        private int Menuu;
        private int SALARIO;

        private List<BaseAtri> ListaEmpleado;

        public void despleagar()
        {
            ListaEmpleado = new List<BaseAtri>();

            do
            {
                do
                {
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.WriteLine("APLICACION PARA REGISTRAR EMPLEADOS");
                    Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    Console.WriteLine();
                    Console.WriteLine("1- Crear Trabajador Gerencial");
                    Console.WriteLine("2- Crear Trabajador Administrativo ");
                    Console.WriteLine("3- Crear Trabajador Operativo");
                    Console.WriteLine("4- Recibo de pago");
                    Console.WriteLine("5- Lista de trabajadores");
                    Console.WriteLine("6- Salir");
                    Console.WriteLine();
                    Console.WriteLine("***********************************");
                    Console.WriteLine("Ingrese el numero para elegir la opcion: ");

                    Menuu = Convert.ToInt32(Console.ReadLine());

                    if (Menuu < 1 || Menuu > 6)
                    {
                        Console.WriteLine("Ingrese una opcion valida [1-6]");
                    }


                } while (Menuu < 1 || Menuu > 6);

                switch (Menuu)
                {
                    case 1:
                        {
                            //Registro de empleado gerencial 
                            Console.Clear();
                            Console.Write("Cedula: ");
                            CEDULA = int.Parse(Console.ReadLine());
                            Gerencial.GetGerencial(CEDULA);

                            Console.Write("Codigo: ");
                            CODIGO = int.Parse(Console.ReadLine());
                            Gerencial.GetGerencial(CODIGO);

                            Console.Write("Nombre: ");
                            NOMBRE = Console.ReadLine();
                            Gerencial.GetGerencial1(NOMBRE);

                            Console.Write("Apellido: ");
                            APELLIDO = Console.ReadLine();
                            Gerencial.GetGerencial1(APELLIDO);

                            Console.Write("Email: ");
                            EMAIL = Console.ReadLine();
                            Gerencial.GetGerencial1(EMAIL);

                            Console.Write("Telefono: ");
                            TELEFONO = int.Parse(Console.ReadLine());
                            Gerencial.GetGerencial(TELEFONO);

                            Console.Write("Departamento: ");
                            DEPARTAMENTO = Console.ReadLine();
                            Gerencial.GetGerencial1(DEPARTAMENTO);

                            Console.Write("Cargo: ");
                            CARGO = Console.ReadLine();
                            Gerencial.GetGerencial1(CARGO);

                            Console.Write("Precio Por Horas: ");
                            PRECIOPORHORAS = int.Parse(Console.ReadLine());
                            Gerencial.GetGerencial(PRECIOPORHORAS);

                            Console.Write("Horas Laboradas: ");
                            HORASLABORADAS = int.Parse(Console.ReadLine());
                            Gerencial.GetGerencial(HORASLABORADAS);

                            SALARIO = HORASLABORADAS * PRECIOPORHORAS;
                            Console.WriteLine("SU SALARIO ES: " + SALARIO + " CON EL BONO DE UN 50% " + SALARIO * 0.50);
                            break;
                        }
                    case 2:
                        {
                            //Registro de empleado Administrativo 
                            Console.Clear();
                            Administrativo admin = new Administrativo();

                            Console.Write("Cedula: ");
                            admin.CEDULA = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Codigo: ");
                            admin.CODIGO = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Nombre: ");
                            admin.NOMBRE = Console.ReadLine();

                            Console.Write("Apellido: ");
                            admin.APELLIDO = Console.ReadLine();

                            Console.Write("Email: ");
                            admin.EMAIL = Console.ReadLine();

                            Console.Write("Telefono: ");
                            admin.TELEFONO = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Departamento: ");
                            admin.DEPARTAMENTO = Console.ReadLine();

                            Console.Write("Cargo: ");
                            admin.CARGO = Console.ReadLine();

                            Console.Write("Precio Por Horas: ");
                            admin.PRECIOPORHORAS = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Horas Laboradas: ");
                            admin.HORASLABORADAS = Convert.ToInt32(Console.ReadLine());

                            SALARIO = admin.HORASLABORADAS * admin.PRECIOPORHORAS;
                            Console.WriteLine("SU SALARIO ES: " + SALARIO + " CON EL BONO DE UN 25% " + SALARIO * 0.25); 

                            break;
                        }
                    case 3:
                        {
                            //Registro de empleado Operativo 
                            Console.Clear();
                            Operativo opera = new Operativo();

                            Console.Write("Cedula: ");
                            opera.CEDULA = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Codigo: ");
                            opera.CODIGO = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Nombre: ");
                            opera.NOMBRE = Console.ReadLine();

                            Console.Write("Apellido: ");
                            opera.APELLIDO = Console.ReadLine();

                            Console.Write("Email: ");
                            opera.EMAIL = Console.ReadLine();

                            Console.Write("Telefono: ");
                            opera.TELEFONO = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Departamento: ");
                            opera.DEPARTAMENTO = Console.ReadLine();

                            Console.Write("Cargo: ");
                            opera.CARGO = Console.ReadLine();

                            Console.Write("Precio Por Horas: ");
                            opera.PRECIOPORHORAS = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Horas Laboradas: ");
                            opera.HORASLABORADAS = Convert.ToInt32(Console.ReadLine());

                            SALARIO = opera.HORASLABORADAS * opera.PRECIOPORHORAS;
                            Console.WriteLine("SU SALARIO ES: " + SALARIO + " CON EL BONO DE UN 10% " + SALARIO * 0.10);
                            break;
                        }
                    case 4:
                        {
                            //recibo de pago
                            Console.WriteLine("Ingrese el codigo a buscar: ");
                            int CodigoBuscar = Convert.ToInt32(Console.ReadLine());

                            foreach (BaseAtri n in ListaEmpleado)
                            {
                                if (n.CODIGO == CodigoBuscar)
                                {
                                    Console.WriteLine("----------------------------------");
                                    Console.WriteLine("Cedula: " + n.CEDULA);
                                    Console.WriteLine("Codigo: " + n.CODIGO);
                                    Console.WriteLine("Nombre: " + n.NOMBRE);
                                    Console.WriteLine("Apellido: " + n.APELLIDO);
                                    Console.WriteLine("Email: " + n.EMAIL);
                                    Console.WriteLine("Telefono: " + n.TELEFONO);
                                    Console.WriteLine("Departamento: " + n.DEPARTAMENTO);
                                    Console.WriteLine("Cargo: " + n.CARGO);
                                    Console.WriteLine("Precio por hora: " + n.PRECIOPORHORAS);
                                    Console.WriteLine("Horas laboradas: " + n.HORASLABORADAS);
                                    Console.WriteLine("Salario: $ " + SALARIO);
                                    Console.WriteLine("----------------------------------");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("NO SE HAN ENCONTRADOS EMPLEADOS");
                                }

                            }
                            break;
                        }

                    case 5:
                        {
                            foreach (BaseAtri n in ListaEmpleado)
                            {

                                Console.WriteLine("----------------------------------");
                                Console.WriteLine("Cedula: " + n.CEDULA);
                                Console.WriteLine("Codigo: " + n.CODIGO);
                                Console.WriteLine("Nombre: " + n.NOMBRE);
                                Console.WriteLine("Apellido: " + n.APELLIDO);
                                Console.WriteLine("Email: " + n.EMAIL);
                                Console.WriteLine("Telefono: " + n.TELEFONO);
                                Console.WriteLine("Departamento: " + n.DEPARTAMENTO);
                                Console.WriteLine("Cargo: " + n.CARGO);
                                Console.WriteLine("Precio por hora: " + n.PRECIOPORHORAS);
                                Console.WriteLine("Horas laboradas: " + n.HORASLABORADAS);
                                Console.WriteLine("Salario: $ " + SALARIO);
                                Console.WriteLine("----------------------------------");
                                break;

                            }

                            break;
                        }
                    case 6:
                        {
                            //Salir 
                            Console.WriteLine("Gracia por registrarse, YA ES UNO DE NOSOTROS!!");
                            Console.ReadKey();
                            break;
                        }   
                }
            } while (Menuu != 6);

        }
    }
}
