namespace EntradadeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é o seu nome: ");
            string nomePessoa = Console.ReadLine();

            Console.Write("Qual é a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Olá " + nomePessoa + ", Seja Bem-vindo(a) ");
            Console.WriteLine("Minha idade é: " + idade + " anos");

        }
    }
}