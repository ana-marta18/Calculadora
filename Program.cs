using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1=null;
        //Creamos un do while para poder repetir nuestras operaciones
        do{ 
        //Bienvenida al programa 
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("    Bienvenido a la calculadora      ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");
        //Creamos el menú de opciones
            Console.WriteLine("Elige la operación que desees realizar \n"+
            "\n1.---Suma"+
            "\n2.---Resta"+
            "\n3.---Multiplicación"+
            "\n4.---División");
            Console.WriteLine("");
            s1 = Console.ReadLine();
            switch(s1){

                case "1":
            //creamos la función suma
                Console.WriteLine("Suma");
                Console.WriteLine("----");
            //Definimos las variables
                float num1, num2;
            //Se crean espacios para ingresar las variables
                Console.WriteLine("Ingrese el primer número");
                num1 = int.Parse(Console.ReadLine());
                 Console.WriteLine("Ingrese el segundo número");
                num2 = int.Parse(Console.ReadLine());
            //Se crea el proceso de la operación
                Console.WriteLine($"La suma de ambos números seria: {num1} + {num2} = {num1 + num2}");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("");
            break;

                case "2":
            //creamos la función resta
                Console.WriteLine("Resta");
                Console.WriteLine("-----");
            //Definimos las variables
                float nu1, nu2;
            //Se crean espacios para ingresar las variables
                Console.WriteLine("Ingrese el primer número");
                nu1 = int.Parse(Console.ReadLine());
                 Console.WriteLine("Ingrese el segundo número");
                nu2 = int.Parse(Console.ReadLine());
            //Se crea el proceso de la operación
                Console.WriteLine($"La resta de ambos números seria: {nu1} - {nu2} = {nu1 - nu2}");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("");
            break;

                case "3":
            //creamos la función resta
                Console.WriteLine("Multipliclación");
                Console.WriteLine("---------------");
            //Definimos las variables
                float n1, n2;
            //Se crean espacios para ingresar las variables
                Console.WriteLine("Ingrese el primer número");
                n1 = int.Parse(Console.ReadLine());
                 Console.WriteLine("Ingrese el segundo número");
                n2 = int.Parse(Console.ReadLine());
            //Se crea el proceso de la operación
                Console.WriteLine($"La multiplicación de ambos números seria: {n1} * {n2} = {n1 * n2}");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("");
            break;

                case "4":
            //creamos la función división
                Console.WriteLine("División");
                Console.WriteLine("--------");
            //Definimos las variables
                float numero1, numero2, residuo;
            //Se crean espacios para ingresar las variables
                Console.WriteLine("Ingrese el primer número");
                numero1 = int.Parse(Console.ReadLine());
                 Console.WriteLine("Ingrese el segundo número");
                numero2 = int.Parse(Console.ReadLine());
            //Se crea el proceso de la operación
                residuo = numero1 % numero2;
                if 
                (numero2 !=0)
                Console.WriteLine($"La división de ambos números seria: {numero1} / {numero2} = {numero1 / numero2} y el residuo es : " + residuo);
                else 
                Console.WriteLine("---¡Error! estos números no se pueden dividir---");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("");
            break;
            }
            //Se crea la opción para continuar o salir del programa
            Console.WriteLine("Desea continuar ejecutando esta operación responde con un si o un no");
            s1 = Console.ReadLine();
            } while(s1== "Si"||s1=="si" );
         { 
         Console.ReadKey();
       }
        }
    }
}
