namespace prueba_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num_jugador = 0, num_enemigo = 0;
            num_enemigo = num_aleatorio();
          //  Console.WriteLine(num_enemigo); Console.ReadKey();

            for (int i = 0; i < 6; i++)
            {
                Console.Clear();
                inicio(i);



                num_jugador = num(1, 10);

                if (num_jugador < num_enemigo)
                {
                    Console.WriteLine("Un poco mas");
                }
                else if (num_jugador > num_enemigo)
                {
                    Console.WriteLine("Un poco menos");
                }

                else
                {
                    break;
                }
                Console.ReadKey();
            }
            
            if (validar(num_jugador, num_enemigo)) Console.WriteLine("\nHas ganado...\n");
            else Console.WriteLine("\nHas perdido... pipipi\n");
            Console.WriteLine("GAME OVER");

        }
        static int num_aleatorio()
        {
            Random num = new Random();
            return num.Next(1, 10);
        }
        static bool validar(int num_jugador, int num_enemigo)
        {
            if (num_jugador == num_enemigo) return true;
            else return false;
        }
        static void inicio(int num)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("ADIVINA EL NUMERO");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Rules");
            Console.WriteLine("Tienes 6 intentos\nEl numero estará en un rango de 1 a 10.");

            Console.WriteLine($"EMPEZEMOS\n\nIntento numero {num + 1}");
        }
        static int num(int num_min, int num_max)
        {

            int numero;

            do
            {

                Console.Write($"\nIngresa un número entre {num_min} y {num_max}: ");

            } while (!int.TryParse(Console.ReadLine(), out numero) || !Numero_ran(numero, num_min, num_max));
            return numero;

            static bool Numero_ran(int numero, int num_min, int num_max)
            {
                if (numero >= num_min)
                {
                    if (numero <= num_max)
                    {
                        return true;
                    }
                    else return false;
                }
                else return false;

            }

        }
    }
}