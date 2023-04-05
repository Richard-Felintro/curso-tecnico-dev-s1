Console.WriteLine($@"
 ___      ___ ________  ___       ___  ________  ________  ________  ________  ________     
|\  \    /  /|\   __  \|\  \     |\  \|\   ___ \|\   __  \|\   ____\|\   __  \|\   __  \    
\ \  \  /  / | \  \|\  \ \  \    \ \  \ \  \_|\ \ \  \|\  \ \  \___|\ \  \|\  \ \  \|\  \   
 \ \  \/  / / \ \   __  \ \  \    \ \  \ \  \ \\ \ \   __  \ \  \    \ \   __  \ \  \\\  \  
  \ \    / /   \ \  \ \  \ \  \____\ \  \ \  \_\\ \ \  \ \  \ \  \____\ \  \ \  \ \  \\\  \ 
   \ \__/ /     \ \__\ \__\ \_______\ \__\ \_______\ \__\ \__\ \_______\ \__\ \__\ \_______\
    \|__|/       \|__|\|__|\|_______|\|__|\|_______|\|__|\|__|\|_______|\|__|\|__|\|_______|");
string nome = "";
while (nome == ""){
    Console.WriteLine($"Informe seu nome:");
    nome = Console.ReadLine();
}

int idade = -1;
while (idade < 0 || idade > 100){
    Console.WriteLine($"Informe sua idade (entre 0 a 100):");
    idade = int.Parse(Console.ReadLine());
}

float salario = -1;
while (salario <= 0){
    Console.WriteLine($"Informe seu salário (maior que 0):");
    salario = float.Parse(Console.ReadLine());
}

bool estadoValido = false;
string estadoCivilVis = "";
Console.WriteLine($"-+-+-Informe seu estado civil-+-+-");
while (estadoValido == false){
Console.WriteLine($@"
o--+--+--<o>--+--+--o
| [S] Solteiro      |
| [C] Casado        |
| [V] Viúvo         |
| [D] Divorciado    |
0--+--+--<o>--+--+--o
");
string estadoCivil = Console.ReadLine().ToUpper();
    switch (estadoCivil){
    case "S":
    estadoCivilVis = "Solteiro";
    estadoValido = true;
    break;
    case "C":
    estadoCivilVis = "Casado";
    estadoValido = true;
    break;
    case "V":
    estadoCivilVis = "Viúvo";
    estadoValido = true;
    break;
    case "D":
    estadoCivilVis = "Divorciado";
    estadoValido = true;
    break;
    default:
    Console.WriteLine($"-+-+-Estado civil inválido-+-+-");
    break;
}
}
Console.WriteLine($@"
 INFORMAÇÕES   VÁLIDADAS
        Nome : {nome}
       Idade : {idade}
     Salário : {salario}
Estado civíl : {estadoCivilVis}");