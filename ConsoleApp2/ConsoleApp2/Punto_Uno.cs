using System;
using System.Globalization;
using System.Linq;

namespace ConsoleApp2
{
    public class Punto_Uno
    {

        public static void Operacion_Uno()
        {
            string valores = "";
            int suma = 0, mul = 0;
            int[] val = new int[4];
            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine($"Ingrese el Valor {i}");
                valores = Console.ReadLine();
                val[i] = Convert.ToInt32(valores);
            }
            suma += (val[0] + val[1]);
            mul += (val[2] * val[3]);
            Console.WriteLine($"La suma de los dos primeros Numero es = {suma}");
            Console.WriteLine($"La multiplicacion es = {mul}");
            Console.ReadKey();

        }
        public static void Operacion_Dos()
        {

            int suma = 0;
            double pro = 0;
            int[] val = new int[] { 8, 2, 2, 4 };
            for (int i = 0; i < val.Length; i++)
            {
                suma += (val[i]);
            }
            pro = suma / val.Length;
            Console.WriteLine($"La suma de los dos primeros Numero es = {suma}");
            Console.WriteLine($"El promedio es = {pro}");
            Console.ReadKey();

        }

        public static void Operacion_tres()
        {
            string precio = "", cant = "";
            double PrecioTotal = 0;
            Console.WriteLine("Ingrese el Precio del Producto");
            precio = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad del Producto");
            cant = Console.ReadLine();
            PrecioTotal = (double.Parse(precio) * double.Parse(cant));
            Console.WriteLine($"El precio Total es de {PrecioTotal}");
            Console.ReadKey();

        }
        public static void Operacion_Cuatro()
        {

            Console.WriteLine("Hola Julian Bienvenido a Medellin");
            Console.ReadKey();

        }

        public static void Operacion_Cinco()
        {
            double area = 0, altura = 0, resultado = 0;
            resultado = (area * altura) / 2;
            Console.WriteLine($"el area del triangulo es {resultado}");
            Console.ReadKey();

        }

        public static void Operacion_Sexto()
        {
            double resultado = 0;
            string numero;
            Console.WriteLine("Ingrese el numero");
            numero = Console.ReadLine();
            resultado = Convert.ToDouble(numero);

            if (resultado > 0)
            {
                Console.WriteLine("El numero es positivo");
            }
            else
            {
                Console.WriteLine("El numero es negativo");
            }

            Console.ReadKey();

        }
        //linQ
        public static void Operacion_SieteLinQ()
        {

            int[] val = new int[5];
            int v, max = val[0], min = val[0];
            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine($"Ingrese el Valor {i}");
                v = int.Parse(Console.ReadLine());
                val[i] = v;
            }
            Console.WriteLine($"El numero mayor es {val.Max()}");
            Console.WriteLine($"El numero menor es {val.Min()}");
            Console.ReadKey();

        }
        public static void Operacion_Siete()
        {

            int[] val = new int[5];
            int v;
            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine($"Ingrese el Valor {i}");
                v = int.Parse(Console.ReadLine());
                val[i] = v;
            }
            int max = val[0], min = val[0];
            for (int i = 0; i < val.Length; i++)
            {
                if (val[i] > max)
                {
                    max = val[i];
                }
                else if (val[i] < min)
                {

                    min = val[i];
                }
            }
            Console.WriteLine($"El numero mayor es {max}");
            Console.WriteLine($"El numero menor es {min}");
            Console.ReadKey();

        }

        public static void Operacion_Ocho()
        {
            CultureInfo culture = new CultureInfo("en-US");
            string num = "";
            decimal[] val = new decimal[5];
            decimal total = 0;

            for (int i = 0; i < val.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero {i}");
                num = Console.ReadLine();
                val[i] = decimal.Parse(num, culture);
            }

            total = val.Sum() / val.Length;
            Console.WriteLine($"El promedio de los numeros es: {total}");
            Console.ReadKey();

        }
        public static void Operacion_Nueve()
        {

            int[] val = new int[] { 2, 8, 2, 2, 4, -8, -1, 5, -1, -4 };
            int positivo = 0;
            int nega = 0;

            for (int i = 0; i < val.Length; i++)
            {
                if (val[i] > 0)
                {
                    positivo++;
                }
                else
                    nega++;
            }
            Console.WriteLine($"La cantidad de numeros positivos son  {positivo}");
            Console.WriteLine($"La cantidad de numeros negativos son  {nega}");
            Console.ReadKey();

        }
        public static void Operacion_Diez()
        {
            CultureInfo culture = new CultureInfo("en-US");
            string var = "";
            double num = 0;

            Console.WriteLine("Ingrese el numero");
            var = Console.ReadLine();
            num = double.Parse(var, culture);

            if ((num % 2) == 0)
            {
                Console.WriteLine("el numero es positivo");
            }
            else
            {
                Console.WriteLine("El numero es negativo");
            }

            Console.ReadKey();
        }

        public static void Operacion_Once()
        {
            Console.WriteLine("Ingresa Grados Centigrados");

            double c = Convert.ToDouble(Console.ReadLine());

            double f = (c * 9 / 5) + (32);

            Console.WriteLine(c + "ºC equivale a " + f + "ºF");

            Console.ReadLine();
            Console.ReadKey();
        }

        public static void Operacion_Doce()
        {
            string nombre = "", edad = "";
            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad");
            edad = Console.ReadLine();

            Console.WriteLine($"te llamas {nombre} y tienes {edad} años");
            Console.ReadKey();

        }

        public static void Operacion_trece()
        {
            CultureInfo culture = new CultureInfo("en-US");
            string dinero = "";
            double capital = 0;

            Console.WriteLine("Ingrese la cantidad a invertir");
            dinero = Console.ReadLine();
            capital = (double.Parse(dinero, culture) * 2) / 100;

            Console.WriteLine($"la cantidad ganada mensual es de {capital}");
            Console.ReadKey();

        }

        public static void Operacion_Catorce()
        {
            string dia = "", mes = "", ano = "";
            Console.WriteLine("Ingrese el año de nacimiento");
            ano = Console.ReadLine();

            Console.WriteLine("Ingrese el mes de nacimiento");
            mes = Console.ReadLine();
            Console.WriteLine("Ingrese el dia de nacimiento");
            dia = Console.ReadLine();
            DateTime date_1 = new DateTime(int.Parse(ano), int.Parse(mes), int.Parse(dia));
            DateTime date_2 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            TimeSpan Diff_dates = date_2.Subtract(date_1);
            int total = Diff_dates.Days / 360;
            Console.WriteLine("Edad: " + total);
            Console.ReadKey();
        }
    }
}
