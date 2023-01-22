namespace Condição_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool gostoDeGoiaba = true;
            //if (gostoDeGoiaba == false)
            //{
            //    Console.WriteLine("Eu compro");
            //}
            //else
            //{
            //    Console.WriteLine("Eu não compro");
            //}

            int time = 10;

            string resultado = (time < 12) ? "Bom dia" : "Boa Tarde";

            Console.WriteLine(resultado); 

            //if (time < 12)
            //{
            //    Console.WriteLine("Bom dia");
            //}    
            //else if (time < 18)
            //{
            //    Console.WriteLine("Boa tarde");
            //}
            //else
            //{
            //    Console.WriteLine("Boa noite");
            //}

        }   
    }
}