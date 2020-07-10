using System;

namespace Elñiño
{
    class Program
    {
        static void Main(string[] args)
        {
            string cedula;
            int contraseña;

            do
            {
                Console.Write("Ingrese su número de cédula: ");
                cedula = Console.ReadLine();
                Console.Write("Ingrese su contraseña: ");
                contraseña = int.Parse(Console.ReadLine());
                while(contraseña < 0)
                {
                    Console.Write("\nNo se permiten números negativos. \n" + "Intentalo de nuevo. \n" + "\n");
                    Console.Write("Ingrese su contraseña: ");
                    contraseña = int.Parse(Console.ReadLine());
                }
                if (cedula == "000-1234567-0" && contraseña == 2604)
                {
                    Console.WriteLine("\nBienvenido Stuart Estévez. *SUPERVISOR* \n");
                }
                else
                {

                    if (cedula == "111-1234567-1" && contraseña == 3103)
                    {
                        Console.WriteLine("\nBienvenido Steven Estévez. *ADMINISTRADOR* \n");
                    }
                    else
                    {

                        if (cedula == "222-1234567-2" && contraseña == 2703)
                        {
                            Console.WriteLine("\nBienvenido Adrian Estévez. *VENDEDOR* \n");
                        }
                        else
                        {
                            Console.WriteLine("\nEl número de cédula y/o contraseña es incorrecta. \n" + "Intentalo de nuevo. \n");
                        }
                    }
                }
            } while (contraseña == 0);

        }
    }
}
