using Introdução_a_POO;

Personagem person1 = new Personagem();

List<Personagem> Personagens = new List<Personagem>(5);
Personagem p1 = new Personagem();
Personagem p2 = new Personagem();
Personagem p3 = new Personagem();
Personagem p4 = new Personagem();
Personagem p5 = new Personagem();

Personagens.Add(p1);
Personagens.Add(p2);
Personagens.Add(p3);
Personagens.Add(p4);
Personagens.Add(p5);

for (var i = 0; i < 5; i++)
{
    Console.WriteLine($"Informe o nome do Personagem :");
    Personagens[i].nome = Console.ReadLine()!;
    Console.WriteLine($"Informe a idade do Personagem :");
    Personagens[i].idade = int.Parse(Console.ReadLine()!);

    Console.WriteLine($"Informe a armadura do Personagem :");
    Personagens[i].armadura = Console.ReadLine()!;
    Console.WriteLine($"Informe a IA do Personagem :");
    Personagens[i].ia = Console.ReadLine()!;
}