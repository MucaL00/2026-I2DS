
using System;

internal class Program
{
    public class Personagem
    {
        public string Nome { get; private set; }
        public int Nivel { get; protected set; }
        public int Forca { get; protected set; }
        public int Vida { get; protected set; }

        public Personagem(string nome, int nivel, int forca, int vida)
        {
            Nome = nome;
            Nivel = nivel;
            Forca = forca;
            Vida = vida;
        }

        public virtual void Apresentar()
        {
            Console.WriteLine($"{Nome} - Nível {Nivel} - Vida: {Vida}");
        }

        public virtual void Atacar(Personagem alvo)
        {
            Console.WriteLine($"{Nome} atacou {alvo.Nome}!");

            alvo.ReceberDano(Forca);
        }

        public virtual void Defender()
        {
            Console.WriteLine($"{Nome} está se defendendo!");
        }

        public void ReceberDano(int dano)
        {
            Vida -= dano;

            if (Vida < 0)
                Vida = 0;

            Console.WriteLine($"{Nome} recebeu {dano} de dano!");
            Console.WriteLine($"Vida restante: {Vida}");
        }
    }

    public class Guerreiro : Personagem
    {
        public Guerreiro(string nome)
            : base(nome, 1, 15, 100)
        {
        }

        public override void Atacar(Personagem alvo)
        {
            int dano = Forca + 5;

            Console.WriteLine($"{Nome} atacou com a espada!");

            alvo.ReceberDano(dano);
        }
    }

    public class Mago : Personagem
    {
        public Mago(string nome)
            : base(nome, 1, 20, 70)
        {
        }

        public override void Atacar(Personagem alvo)
        {
            int dano = Forca;

            Console.WriteLine($"{Nome} lançou uma bola de fogo!");

            alvo.ReceberDano(dano);
        }
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("=== MINI RPG ===");

        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("\nEscolha sua classe:");
        Console.WriteLine("1 - Guerreiro");
        Console.WriteLine("2 - Mago");

        Console.Write("Escolha: ");
        string escolha = Console.ReadLine();

        Personagem jogador;

        if (escolha == "1")
            jogador = new Guerreiro(nome);
        else
            jogador = new Mago(nome);

        Personagem inimigo =
            new Personagem("Goblin", 1, 10, 50);

        Console.Clear();

        Console.WriteLine("=== BATALHA ===");

        jogador.Apresentar();
        inimigo.Apresentar();

        while (jogador.Vida > 0 && inimigo.Vida > 0)
        {
            Console.WriteLine("\nO que você deseja fazer?");
            Console.WriteLine("1 - Atacar");
            Console.WriteLine("2 - Defender");

            Console.Write("Escolha: ");
            string acao = Console.ReadLine();

            if (acao == "1")
            {
                jogador.Atacar(inimigo);
            }
            else if (acao == "2")
            {
                jogador.Defender();
            }

            if (inimigo.Vida > 0)
            {
                inimigo.Atacar(jogador);
            }
        }

        Console.WriteLine();

        if (jogador.Vida > 0)
        {
            Console.WriteLine("🎉 VOCÊ VENCEU!");
        }
        else
        {
            Console.WriteLine("💀 VOCÊ PERDEU!");
        }
    }
}

