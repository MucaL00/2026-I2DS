/*
A função deve calcular a **multiplicação entre dois números**.

Teste a função utilizando **3 pares de valores diferentes** e imprima os resultados no console.
**Conceitos:** `Func<>` • Lambda Expression

*/

internal class Program
{
    private static void Main(string[] args)
{
        Func<int, int, int> multiplicar = (a, b) => (a *b);

        int result = multiplicar(5, 5);
        int result2 = multiplicar(4, 4);
        int result3 = multiplicar(3, 3);
    
        Console.WriteLine($"Teste resultado 1: {result}");
        Console.WriteLine($"Teste resultado 1: {result2}");
        Console.WriteLine($"Teste resultado 1: {result3}");
}
}