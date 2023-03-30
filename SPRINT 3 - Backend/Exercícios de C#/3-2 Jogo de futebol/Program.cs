Console.WriteLine($@"
 ________  ________  ___       ________  ________          ________  _______           ________  ________  ___       ________      
|\   ____\|\   __  \|\  \     |\   ___ \|\   __  \        |\   ___ \|\  ___ \         |\   ____\|\   __  \|\  \     |\   ____\     
\ \  \___|\ \  \|\  \ \  \    \ \  \_|\ \ \  \|\  \       \ \  \_|\ \ \   __/|        \ \  \___|\ \  \|\  \ \  \    \ \  \___|_    
 \ \_____  \ \   __  \ \  \    \ \  \ \\ \ \  \\\  \       \ \  \ \\ \ \  \_|/__       \ \  \  __\ \  \\\  \ \  \    \ \_____  \   
  \|____|\  \ \  \ \  \ \  \____\ \  \_\\ \ \  \\\  \       \ \  \_\\ \ \  \_|\ \       \ \  \|\  \ \  \\\  \ \  \____\|____|\  \  
    ____\_\  \ \__\ \__\ \_______\ \_______\ \_______\       \ \_______\ \_______\       \ \_______\ \_______\ \_______\____\_\  \ 
   |\_________\|__|\|__|\|_______|\|_______|\|_______|        \|_______|\|_______|        \|_______|\|_______|\|_______|\_________\
   \|_________|                                                                                                        \|_________|
   
Quantos gols foram marcados pelo primeiro time: ");
int time1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Quantos gols foram marcados pelo segundo time: ");
int time2 = int.Parse(Console.ReadLine());

if (time1 > time2) {
    Console.WriteLine($"O primeiro time é o vencedor, com {time1} gols contra {time2} gols do segundo time");
}

else if (time2 > time1) {
    Console.WriteLine($"O segundo time é o vencedor, com {time2} gols contra {time1} gols do primeiro time!");
}

else {
    Console.WriteLine($"Deu empate, ambos os times marcaram {time1} gols!");
}