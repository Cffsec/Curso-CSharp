namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Paula ";
            string sobrenome = "Toller";

            string nomeCompleto = String.Concat(nome, sobrenome);
            
            Console.WriteLine(nomeCompleto);
            int posicao = nomeCompleto.IndexOf("T");

            string nomeFinal = nomeCompleto.Substring(posicao);
            Console.WriteLine(nomeFinal);
            Console.WriteLine(nomeFinal.ToUpper());
            Console.WriteLine(nomeFinal.ToLower());

           
            
        }
    }
}