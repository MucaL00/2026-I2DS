/*
Crie um `Dictionary<int, string>` representando um **cardápio de lanchonete**.

- A chave deve representar o **código do produto**;
- O valor deve representar o **nome do produto**;
- Cadastre pelo menos **4 produtos**.

Utilize `foreach` para imprimir os produtos no seguinte formato:
*/
internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, string> cardapio = new Dictionary<int, string>
        {
            { 1, "Hambúrguer" },
            { 2, "Batata Frita" },
            { 3, "Refrigerante" },
            { 4, "Milkshake" }
        };

        foreach (KeyValuePair<int, string> produto in cardapio)
        {
            Console.WriteLine($"{produto.Key} - {produto.Value}");
        }
    }
}