internal class Program
{
    private static void Main(string[] args)
    {
        int num1;
        int num2;

        Console.WriteLine("Digite o primeiro número: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("1 - soma");
        Console.WriteLine("1 - subtração");
        Console.WriteLine("1 - multiplicação");
        Console.WriteLine("1 - divisão");  

        string operacao;

        Console.WriteLine("Selecione uma operação: ");
        operacao = Console.ReadLine();

            switch (operacao)
        {
            case "1": 
                Console.WriteLine(num1 + num2);
                break;
            case "2": 
                Console.WriteLine(num1 - num2);
                break;
            case "3": 
                Console.WriteLine(num1 * num2);
                break;
            case "4": 
                Console.WriteLine(num1 / num2);
                break;
            default:
                Console.WriteLine();
                break;
        }
    }
}