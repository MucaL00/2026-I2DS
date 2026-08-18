using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
        aluno1.Nome = "Carlos";
        aluno1.Idade = 19;
        
        Aluno aluno2 = new Aluno();
        aluno2.Nome = "Pafuncio";
        aluno2.Idade = 20;

        Aluno aluno3 = new Aluno();
        aluno3.Nome = "Cleber";
        aluno3.Idade = 39;

        Aluno aluno4 = new Aluno();
        aluno4.Nome = "giovani";
        aluno4.Idade = 13;

        Aluno aluno5 = new Aluno();
        aluno5.Nome = "cristiano";
        aluno5.Idade = 30;

        List<Aluno> listAlunos = new List<Aluno>();
        listAlunos.Add(aluno1);
        listAlunos.Add(aluno2);
        listAlunos.Add(aluno3);
        listAlunos.Add(aluno4);
        listAlunos.Add(aluno5);

        Console.WriteLine("=== ALUNOS ===");
        foreach (var aluno in listAlunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Idade}");
        }

        Console.WriteLine();
            listAlunos[1].Idade = 8;
            listAlunos.Remove(aluno5);
        foreach (var aluno in listAlunos)
        {
            Console.WriteLine($"{aluno.Nome} - {aluno.Idade}");
        }
    }

    public class Aluno
    {
        public string? Nome{get;set;}
        public int? Idade{get;set;}
    }
}