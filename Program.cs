namespace prueba_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num_jugador = 0, num_enemigo = 0;
            num_enemigo = num_aleatorio();
            do
            {
                inicio();

                if(num_jugador > num_enemigo)
                {

                }
                else if (num_jugador < num_enemigo)
                {

                }
                else
                {

                }

            } while (validar(num_jugador,num_enemigo)) ;

            
        }
        static int num_aleatorio()
        {
            Random num = new Random();
            return num.Next(1,10);
        }
        static bool validar(int num_jugador, int num_enemigo)
        {
            if (num_jugador == num_enemigo) return true;
            else return false;
        }
        static void inicio()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("ADIVINA EL NUMERO");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Rules");
            Console.WriteLine("Tienes 6 intentos\nEl numero estará en un rango de 1 a 10.");

            Console.WriteLine("EMPEZEMOS");
        }
    }
}