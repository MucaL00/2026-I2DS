internal class Program
{
    private static void Main(string[] args)
    {
        // Primeiro aluno
        Aluno aluno1 = new Aluno();
        aluno1.RM = 1001;
        aluno1.Nome = "João Silva";
        aluno1.Nascimento = new DateOnly(2008, 5, 15); // ano,mes,dia
        aluno1.Email = "joao@email.com";

        // Segundo aluno
        Aluno aluno2 = new Aluno();
        aluno2.RM = 1002;
        aluno2.Nome = "Maria Santos";
        aluno2.Nascimento = new DateOnly(2007, 8, 22);
        aluno2.Email = "maria@email.com";

        // Terceiro aluno
        Aluno aluno3 = new Aluno();
        aluno3.RM = 1003;
        aluno3.Nome = "Pedro Oliveira";
        aluno3.Nascimento = new DateOnly(2008, 2, 10);
        aluno3.Email = "pedro@email.com";

        // Exibindo os alunos
        Console.WriteLine("=== ALUNOS ===");

        Console.WriteLine("\nAluno 1");
        Console.WriteLine($"RM: {aluno1.RM}");
        Console.WriteLine($"Nome: {aluno1.Nome}");
        Console.WriteLine($"Nascimento: {aluno1.Nascimento:dd/MM/yyyy}");
        Console.WriteLine($"Email: {aluno1.Email}");

        Console.WriteLine("\nAluno 2");
        Console.WriteLine($"RM: {aluno2.RM}");
        Console.WriteLine($"Nome: {aluno2.Nome}");
        Console.WriteLine($"Nascimento: {aluno2.Nascimento:dd/MM/yyyy}");
        Console.WriteLine($"Email: {aluno2.Email}");

        Console.WriteLine("\nAluno 3");
        Console.WriteLine($"RM: {aluno3.RM}");
        Console.WriteLine($"Nome: {aluno3.Nome}");
        Console.WriteLine($"Nascimento: {aluno3.Nascimento:dd/MM/yyyy}");
        Console.WriteLine($"Email: {aluno3.Email}");
    }

    public class Aluno
    {
        public string Nome {get; set;}
        public string Email {get; set;}
        public DateOnly Nascimento {get; set;}
        public int RM {get; set;}
    }
}