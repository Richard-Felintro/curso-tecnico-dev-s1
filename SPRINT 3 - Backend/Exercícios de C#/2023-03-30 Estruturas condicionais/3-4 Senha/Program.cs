﻿Console.WriteLine($@"
 ________  ___  ________  ___  _________  _______           ________  ___  ___  ________     
|\   ___ \|\  \|\   ____\|\  \|\___   ___\\  ___ \         |\   ____\|\  \|\  \|\   __  \    
\ \  \_|\ \ \  \ \  \___|\ \  \|___ \  \_\ \   __/|        \ \  \___|\ \  \\\  \ \  \|\  \   
 \ \  \ \\ \ \  \ \  \  __\ \  \   \ \  \ \ \  \_|/__       \ \_____  \ \  \\\  \ \   __  \  
  \ \  \_\\ \ \  \ \  \|\  \ \  \   \ \  \ \ \  \_|\ \       \|____|\  \ \  \\\  \ \  \ \  \ 
   \ \_______\ \__\ \_______\ \__\   \ \__\ \ \_______\        ____\_\  \ \_______\ \__\ \__\
    \|_______|\|__|\|_______|\|__|    \|__|  \|_______|       |\_________\|_______|\|__|\|__|
                                                              \|_________|                   
 ________  _______   ________   ___  ___  ________                                           
|\   ____\|\  ___ \ |\   ___  \|\  \|\  \|\   __  \                                          
\ \  \___|\ \   __/|\ \  \\ \  \ \  \\\  \ \  \|\  \                                         
 \ \_____  \ \  \_|/_\ \  \\ \  \ \   __  \ \   __  \                                        
  \|____|\  \ \  \_|\ \ \  \\ \  \ \  \ \  \ \  \ \  \                                       
    ____\_\  \ \_______\ \__\\ \__\ \__\ \__\ \__\ \__\                                      
   |\_________\|_______|\|__| \|__|\|__|\|__|\|__|\|__|                                      
   \|_________|                                                                              
");

senha:
Console.WriteLine($"Beep-boop, sou um robô, digite sua senha: ");

string senha = (Console.ReadLine());

if (senha == "1234") {
    Console.WriteLine($"ACESSO    PERMITIDO    caso    a    senha    seja    válida.");
}

else {
  Console.WriteLine($"ACESSO    NEGADO    caso    a    senha    seja    inválida.");
  goto senha;
}