﻿Console.WriteLine($@"
 ___      ___ ________  ________  ________  ___               ________  ___  ___                 
|\  \    /  /|\   __  \|\   ____\|\   __  \|\  \             |\   __  \|\  \|\  \                
\ \  \  /  / | \  \|\  \ \  \___|\ \  \|\  \ \  \            \ \  \|\  \ \  \\\  \               
 \ \  \/  / / \ \  \\\  \ \  \  __\ \   __  \ \  \            \ \  \\\  \ \  \\\  \              
  \ \    / /   \ \  \\\  \ \  \|\  \ \  \ \  \ \  \____        \ \  \\\  \ \  \\\  \             
   \ \__/ /     \ \_______\ \_______\ \__\ \__\ \_______\       \ \_______\ \_______\            
    \|__|/       \|_______|\|_______|\|__|\|__|\|_______|        \|_______|\|_______|            
 ________  ________  ________   ________  ________  ________  ________   _________  _______      
|\   ____\|\   __  \|\   ___  \|\   ____\|\   __  \|\   __  \|\   ___  \|\___   ___\\  ___ \     
\ \  \___|\ \  \|\  \ \  \\ \  \ \  \___|\ \  \|\  \ \  \|\  \ \  \\ \  \|___ \  \_\ \   __/|    
 \ \  \    \ \  \\\  \ \  \\ \  \ \_____  \ \  \\\  \ \   __  \ \  \\ \  \   \ \  \ \ \  \_|/__  
  \ \  \____\ \  \\\  \ \  \\ \  \|____|\  \ \  \\\  \ \  \ \  \ \  \\ \  \   \ \  \ \ \  \_|\ \ 
   \ \_______\ \_______\ \__\\ \__\____\_\  \ \_______\ \__\ \__\ \__\\ \__\   \ \__\ \ \_______\
    \|_______|\|_______|\|__| \|__|\_________\|_______|\|__|\|__|\|__| \|__|    \|__|  \|_______|
                                  \|_________|                                                   
Digite uma letra: ");
string letra = Console.ReadLine();
if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u") {
   Console.WriteLine($"Esta letra é uma vogal");
}
else {
   Console.WriteLine($"Esta letra é uma consoante (ou não é uma letra)");
}