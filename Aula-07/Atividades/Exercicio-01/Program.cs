internal class Program
{
    public class Frutas
    {
        public string? Fruits {get; set;}

    }
    private static void Main(string[] args)
    {
        Console.WriteLine("===== LISTA DE FRUTAS!=====");

        List<Frutas> listaFrutas = new List<Frutas>();

        Frutas fruta1 = new Frutas{Fruits = "Banana"};
        Frutas fruta2 = new Frutas{Fruits = "Maçã"};
        Frutas fruta3 = new Frutas{Fruits = "Laranja"};
        Frutas fruta4 = new Frutas{Fruits = "Uva"};
        Frutas fruta5 = new Frutas{Fruits = "Jatoba"};
        Frutas fruta6 = new Frutas{Fruits = "abacatudo"};

        listaFrutas.Add(fruta1);
        listaFrutas.Add(fruta2); 
        listaFrutas.Add(fruta3);
        listaFrutas.Add(fruta4); 
        listaFrutas.Add(fruta5);

        foreach (var item in listaFrutas)
        {
            Console.WriteLine($"{item.Fruits}");
        }
            Console.WriteLine();

        listaFrutas.Add(fruta6);

        Console.WriteLine("===== NOVA LISTA COM A FRUTA 06! =====");

        foreach (var item in listaFrutas)
        {
            Console.WriteLine($"{item.Fruits}");
        }
    }
}