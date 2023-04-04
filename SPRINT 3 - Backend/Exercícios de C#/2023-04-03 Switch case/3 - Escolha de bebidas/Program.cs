Console.WriteLine($@"
 ________  _______   ________  ___  ________  ________  ________      
|\   __  \|\  ___ \ |\   __  \|\  \|\   ___ \|\   __  \|\   ____\     
\ \  \|\ /\ \   __/|\ \  \|\ /\ \  \ \  \_|\ \ \  \|\  \ \  \___|_    
 \ \   __  \ \  \_|/_\ \   __  \ \  \ \  \ \\ \ \   __  \ \_____  \   
  \ \  \|\  \ \  \_|\ \ \  \|\  \ \  \ \  \_\\ \ \  \ \  \|____|\  \  
   \ \_______\ \_______\ \_______\ \__\ \_______\ \__\ \__\____\_\  \ 
    \|_______|\|_______|\|_______|\|__|\|_______|\|__|\|__|\_________\
                                                          \|_________|");
selecao:
Console.WriteLine($@"
o--+--Escolha sua bebida--+--o
| [1] Coca-cola              |
| [2] Pepsi                  |
| [3] Fanta                  |
| [4] Monster                |
o--+--+--+--+-<>-+--+--+--+--o");

int bebidaNum = int.Parse(Console.ReadLine());
string bebida = "null";

switch (bebidaNum){
    case 1:
    bebida = "a Coca-cola";
    break;
    case 2:
    bebida = "a Pepsi";
    break;
    case 3:
    bebida = "a Fanta";
    break;
    case 4:
    bebida = " Monster";
    break;
    default:
    Console.WriteLine($"Valor inválido");
    goto selecao;
    return;
}
Console.WriteLine($"Você quer um{bebida} com ou sem gelo adicional?");
gelo:
Console.WriteLine($@"Digite:
[1] Se quer gelo adicional
[2] Se não quer gelo adicional");

int geloNum = int.Parse(Console.ReadLine());
string comGelo = "null";

switch (geloNum){
    case 1:
    comGelo = "com";
    break;
    case 2:
    comGelo = "sem";
    break;
    default:
    Console.WriteLine($"Valor inválido");
    goto gelo;
}
Console.WriteLine($"Um{bebida} {comGelo} gelo adicional chegando!");