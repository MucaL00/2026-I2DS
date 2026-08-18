/*
Crie uma `Stack<string>` simulando o histórico de ações de um editor de texto.

Exemplos de ações:

```
Digitar
Colar
Negrito
Apagar
```

Realize as seguintes operações:

1. Empilhe 4 ações;
2. Desempilhe (`Pop`) as 2 últimas ações;
3. A cada `Pop`, imprima qual ação foi desfeita.

**Conceitos:** `Stack<T>` • `Push()` • `Pop()`

*/

internal class Program
{
    private static void Main(string[] args)
{
    Stack<string> historico = new Stack<string>();

        historico.Push("Digitar");
        historico.Push("Colar");
        historico.Push("Negrito");
        historico.Push("Apagar");
        
        string acaoDesfeita = historico.Pop();
        Console.WriteLine("Ação desfeita: " + acaoDesfeita);

        acaoDesfeita = historico.Pop();
        Console.WriteLine("Ação desfeita: " + acaoDesfeita);
}
}