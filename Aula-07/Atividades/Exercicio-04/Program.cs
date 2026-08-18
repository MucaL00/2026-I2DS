/*## 🟢 Exercício 04 — Fila de Atendimento

Crie um sistema simples de atendimento utilizando:

```csharp
Queue<string>
```

Adicione inicialmente os seguintes clientes:

- João
- Maria
- Carlos
- Ana
- Pedro

O programa deve:

1. Exibir a fila.
2. Atender o primeiro cliente.
3. Informar quem foi atendido.
4. Exibir a fila restante.
5. Permitir adicionar um novo cliente.

**Conceito principal:** FIFO — First-In, First-Out.
*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=== Fila Pauta Super-Market ===");
        Queue<string> filaPauta = new Queue<string>();

        filaPauta.Enqueue("joão");
        filaPauta.Enqueue("Maria");
        filaPauta.Enqueue("Carlos");
        filaPauta.Enqueue("Ana");
        filaPauta.Enqueue("Pedro");

        Console.WriteLine();
        foreach (var pessoa in filaPauta)
        {
            Console.WriteLine(pessoa);
        }

        string pessoaRetirada = filaPauta.Dequeue();
        Console.WriteLine();
        Console.WriteLine($"A pessoa atendida foi: {pessoaRetirada}");

        foreach (var pessoa in filaPauta);

        foreach (var pessoa in filaPauta)
        {
            Console.WriteLine(pessoa);
        }
        Console.WriteLine();
        Console.WriteLine("=== Adicionando nova pessoa da Fila ===");
        filaPauta.Enqueue("DIPA DI PAULA");

        Console.WriteLine();
        foreach (var pessoa in filaPauta)
        {
            Console.WriteLine(pessoa);
        }
    }
}