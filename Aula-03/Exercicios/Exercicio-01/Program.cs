internal class Program
{
    private static void Main(string[] args)
    {
        int celcius;
        Console.WriteLine("Digite a temperatura em Celcius: ");
        celcius = int.Parse(Console.ReadLine());

        double Fahrenheit = (celcius * 9 / 5) + 32;

        Console.WriteLine(celcius + " Em graus Fharenheit é igual a " + Fahrenheit);

    }
}