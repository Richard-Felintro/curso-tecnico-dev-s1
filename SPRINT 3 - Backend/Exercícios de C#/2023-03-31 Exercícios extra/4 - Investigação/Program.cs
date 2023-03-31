int r1 = 0;
int r2 = 0;
int r3 = 0;
int r4 = 0;
int r5 = 0;
Console.WriteLine($@"
 ___  ________   ___      ___ _______   ________  _________  ___  ________  ________  ________  ________  ________     
|\  \|\   ___  \|\  \    /  /|\  ___ \ |\   ____\|\___   ___\\  \|\   ____\|\   __  \|\   ____\|\   __  \|\   __  \    
\ \  \ \  \\ \  \ \  \  /  / | \   __/|\ \  \___|\|___ \  \_\ \  \ \  \___|\ \  \|\  \ \  \___|\ \  \|\  \ \  \|\  \   
 \ \  \ \  \\ \  \ \  \/  / / \ \  \_|/_\ \_____  \   \ \  \ \ \  \ \  \  __\ \   __  \ \  \    \ \   __  \ \  \\\  \  
  \ \  \ \  \\ \  \ \    / /   \ \  \_|\ \|____|\  \   \ \  \ \ \  \ \  \|\  \ \  \ \  \ \  \____\ \  \ \  \ \  \\\  \ 
   \ \__\ \__\\ \__\ \__/ /     \ \_______\____\_\  \   \ \__\ \ \__\ \_______\ \__\ \__\ \_______\ \__\ \__\ \_______\
    \|__|\|__| \|__|\|__|/       \|_______|\_________\   \|__|  \|__|\|_______|\|__|\|__|\|_______|\|__|\|__|\|_______|
                                          \|_________|                                                                 ");
Console.WriteLine($@"Bom dia, gostaria de fazer algumas perguntas ao senhor sobre o ocorrido, 
responda apenas com true ou false.");

Console.WriteLine($"Telefonou para a vítima?");
bool q1 = bool.Parse(Console.ReadLine());
if (q1 == true) {
    r1 = 1;
}

Console.WriteLine($"Esteve no local do crime?");
bool q2 = bool.Parse(Console.ReadLine());
if (q2 == true) {
    r2 = 1;
}

Console.WriteLine($"Mora perto da vítima?");
bool q3 = bool.Parse(Console.ReadLine());
if (q3 == true) {
    r3 = 1;
}

Console.WriteLine($"Devia para a vítima?");
bool q4 = bool.Parse(Console.ReadLine());
if (q4 == true) {
    r4 = 1;
}

Console.WriteLine($"Já trabalhou com a vítima?");
bool q5 = bool.Parse(Console.ReadLine());
if (q5 == true) {
    r5 = 1;
}

int suspeita = r1 + r2 + r3 + r4 + r5;

if (suspeita == 2) {
    Console.WriteLine($"~~~~~ Você é suspeito ~~~~~");
}
else if (suspeita == 3 || suspeita == 4) {
    Console.WriteLine($"~~~~~ Você é um cumplice ~~~~~");
}
else if (suspeita == 5) {
    Console.WriteLine($"~~~~~ VOCÊ É O CULPADO! ~~~~~");
}
else {
    Console.WriteLine($"~~~~~ Você é inocente! ~~~~~");
}