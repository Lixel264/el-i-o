using System;

namespace Elñiño
{
    class Program
    {
        static void Main(string[] args)
        {
            string cedula;
            int contraseña;
            string salir;
            do
            {
                Console.WriteLine("\nSi quieres salir de la aplicación digite una S, si quieres continuar presione *Enter.*");
                salir = Console.ReadLine();
                if (salir == "s" || salir == "S")
                {
                    Console.WriteLine("\nSALISTE CON EXITO. \n");
                    break;
                }
                else while (salir == "")
                    {
                        Console.Write("Ingrese su número de cédula: ");
                        cedula = Console.ReadLine();
                        Console.Write("Ingrese su contraseña: ");
                        contraseña = int.Parse(Console.ReadLine());
                        while (contraseña < 0)
                        {
                            Console.Write("\nNo se permiten números negativos. \n" + "Intentalo de nuevo. \n" + "\n");
                            Console.Write("Ingrese su contraseña: ");
                            contraseña = int.Parse(Console.ReadLine());
                        }
                        if (cedula == "000-1234567-0" && contraseña == 2604)
                        {
                            Console.WriteLine("\nBienvenido: Stuart Estévez.\n" + "\nUsername: 000-1234567-0." + "\nClave: 2604." + "\nEstado: Activo. \n" + "Rol: Supervisor. \n" + "Fecha de creación: 26/4/2001. \n");
                            Console.WriteLine("\nSi quieres salir pon una S");
                            salir = Console.ReadLine();
                            if (salir == "s" || salir == "S")
                            {
                                Console.WriteLine("\nSALISTE CON EXITO. \n");
                                break;
                            }
                        }
                        else
                        {

                            if (cedula == "111-1234567-1" && contraseña == 3103)
                            {
                                Console.WriteLine("\nEsta cuenta está inactiva, vuelve a validar otra cuenta. \n");
                                Console.WriteLine("\nPresiona S para salir");
                                salir = Console.ReadLine();
                                if (salir == "s" || salir == "S")
                                {
                                    Console.WriteLine("\nSALISTE CON EXITO. \n");
                                    break;
                                }
                            }
                            else
                            {

                                if (cedula == "222-1234567-2" && contraseña == 2703)
                                {
                                    Console.WriteLine("\nBienvenido: Adrian Estévez.\n" + "\nUsername: 111-1234567-1." + "\nClave: 2703." + "\nEstado: Activo. \n" + "Rol: Vendedor. \n" + "Fecha de creación: 27/3/2001. \n");
                                    Console.WriteLine("\nSi quieres salir pon una S");
                                    salir = Console.ReadLine();
                                    if (salir == "s" || salir == "S")
                                    {
                                        Console.WriteLine("\nSALISTE CON EXITO. \n");
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nEl número de cédula y/o contraseña es incorrecta. \n" + "Intentalo de nuevo. (Presiona *ENTER* para continuar o S para salir)");
                                    salir = Console.ReadLine();
                                    if (salir == "s" || salir == "S")
                                    {
                                        Console.WriteLine("\nSALISTE CON EXITO. \n");
                                        break;
                                    }
                                }
                            }
                        }
                    }
            } while (salir == "s" || salir == "S");
            Console.ReadKey();

        }
    }
}
