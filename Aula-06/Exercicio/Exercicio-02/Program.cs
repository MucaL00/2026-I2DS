    /*
    1. Insira o número `100` na posição `2`;
    2. Remova o elemento que está na última posição;
    3. Imprima a lista final.

    **Conceitos:** `List<T>` • `Insert()` • `RemoveAt()` • `Count`
    */


    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            numeros.Insert(2, 100);
            numeros.RemoveAt(numeros.Count - 1);

            foreach (int numero in numeros)
            {
                Console.WriteLine(numeros);
            }
        }
    }