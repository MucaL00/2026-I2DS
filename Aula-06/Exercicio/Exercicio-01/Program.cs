/*
Crie uma `List<string>` contendo o nome de **5 cidades brasileiras**.

Utilize `foreach` para percorrer a lista e imprimir cada cidade no console.

**Conceitos:** `List<T>` • `foreach`
*/

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> cidades = new List<string>();

        cidades.Add("São Paulo");
        cidades.Add("Rio de Janeiro");
        cidades.Add("Belo Horizonte");
        cidades.Add("Curitiba");
        cidades.Add("Porto Alegre");

        foreach (var cidade in cidades)
        {
            Console.WriteLine(cidade);
        }
}
}