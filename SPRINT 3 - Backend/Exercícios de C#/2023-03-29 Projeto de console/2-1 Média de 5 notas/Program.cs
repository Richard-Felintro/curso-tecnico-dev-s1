Console.WriteLine(@$"
 ________  ________  ___       ________  ___  ___  ___       ________  ________  ________  ________  ________     
|\   ____\|\   __  \|\  \     |\   ____\|\  \|\  \|\  \     |\   __  \|\   ___ \|\   __  \|\   __  \|\   __  \    
\ \  \___|\ \  \|\  \ \  \    \ \  \___|\ \  \\\  \ \  \    \ \  \|\  \ \  \_|\ \ \  \|\  \ \  \|\  \ \  \|\  \   
 \ \  \    \ \   __  \ \  \    \ \  \    \ \  \\\  \ \  \    \ \   __  \ \  \ \\ \ \  \\\  \ \   _  _\ \   __  \  
  \ \  \____\ \  \ \  \ \  \____\ \  \____\ \  \\\  \ \  \____\ \  \ \  \ \  \_\\ \ \  \\\  \ \  \\  \\ \  \ \  \ 
   \ \_______\ \__\ \__\ \_______\ \_______\ \_______\ \_______\ \__\ \__\ \_______\ \_______\ \__\\ _\\ \__\ \__\
    \|_______|\|__|\|__|\|_______|\|_______|\|_______|\|_______|\|__|\|__|\|_______|\|_______|\|__|\|__|\|__|\|__|
                       ________  _______           ________   ________  _________  ________                       
                      |\   ___ \|\  ___ \         |\   ___  \|\   __  \|\___   ___\\   __  \                      
                      \ \  \_|\ \ \   __/|        \ \  \\ \  \ \  \|\  \|___ \  \_\ \  \|\  \                     
                       \ \  \ \\ \ \  \_|/__       \ \  \\ \  \ \  \\\  \   \ \  \ \ \   __  \                    
                        \ \  \_\\ \ \  \_|\ \       \ \  \\ \  \ \  \\\  \   \ \  \ \ \  \ \  \                   
                         \ \_______\ \_______\       \ \__\\ \__\ \_______\   \ \__\ \ \__\ \__\                  
                          \|_______|\|_______|        \|__| \|__|\|_______|    \|__|  \|__|\|__|                  
                                                                                                                  ");
Console.WriteLine($"Informe a primeira nota: ");
float nota1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a segunda nota: ");
float nota2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a terceira nota: ");
float nota3 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a quarta nota: ");
float nota4 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe a quinta nota: ");
float nota5 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2 + nota3 + nota4 + nota5)/5;

Console.WriteLine($"Sua média é {media}.");