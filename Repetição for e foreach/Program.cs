namespace Repetição_for_e_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 8; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            //string[] carros = { "Fusca", "Chevrolet", "Palio" };

            //foreach(string y in carros)
            //{
            //    Console.WriteLine(y);
            //}

        }
    }
}