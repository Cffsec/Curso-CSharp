namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] carros = { "Fusca", "Brasilia", "Onix", "Palio" };
            int[] numeros = { 1, 2, 3, 4 };


            //carros[2] = "Ferrari";
            //Console.WriteLine(carros[2]);

            for (int i = 0; i < carros.Length; i++)
            {
                Console.WriteLine(carros[i]);
            }
        }
    }
}