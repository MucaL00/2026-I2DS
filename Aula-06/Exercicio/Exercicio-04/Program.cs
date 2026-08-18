/*Crie uma `Queue<string>` simulando uma fila de atendimento em um caixa.

1. Adicione o nome de **5 pessoas** à fila;
2. Remova as **2 primeiras pessoas**, simulando o atendimento;
3. Imprima as pessoas que ainda permanecem na fila.
*/


internal class Program
{
    private static void Main(string[] args)
    {
        Queue<string> fila = new Queue<string>();

        fila.Enqueue("Ana");
        fila.Enqueue("Joao");
        fila.Enqueue("Pedro");
        fila.Enqueue("Dias");
        fila.Enqueue("Neto");

        fila.Dequeue();
        fila.Dequeue();

        foreach (var pessoas in fila)
        {
            Console.WriteLine(pessoas);
        }

    }
}