﻿Console.WriteLine($@"
 ________  ________  ___       ________  ___  ___  ___       ________  ________  ________  ________  ________      
|\   ____\|\   __  \|\  \     |\   ____\|\  \|\  \|\  \     |\   __  \|\   ___ \|\   __  \|\   __  \|\   __  \     
\ \  \___|\ \  \|\  \ \  \    \ \  \___|\ \  \\\  \ \  \    \ \  \|\  \ \  \_|\ \ \  \|\  \ \  \|\  \ \  \|\  \    
 \ \  \    \ \   __  \ \  \    \ \  \    \ \  \\\  \ \  \    \ \   __  \ \  \ \\ \ \  \\\  \ \   _  _\ \   __  \   
  \ \  \____\ \  \ \  \ \  \____\ \  \____\ \  \\\  \ \  \____\ \  \ \  \ \  \_\\ \ \  \\\  \ \  \\  \\ \  \ \  \  
   \ \_______\ \__\ \__\ \_______\ \_______\ \_______\ \_______\ \__\ \__\ \_______\ \_______\ \__\\ _\\ \__\ \__\ 
    \|_______|\|__|\|__|\|_______|\|_______|\|_______|\|_______|\|__|\|__|\|_______|\|_______|\|__|\|__|\|__|\|__| 
         ________  _______           ________  ___  ________  ________  ___  ___  ___       ________  ________      
        |\   ___ \|\  ___ \         |\   ____\|\  \|\   __  \|\   ____\|\  \|\  \|\  \     |\   __  \|\   ____\     
        \ \  \_|\ \ \   __/|        \ \  \___|\ \  \ \  \|\  \ \  \___|\ \  \\\  \ \  \    \ \  \|\  \ \  \___|_    
         \ \  \ \\ \ \  \_|/__       \ \  \    \ \  \ \   _  _\ \  \    \ \  \\\  \ \  \    \ \  \\\  \ \_____  \   
          \ \  \_\\ \ \  \_|\ \       \ \  \____\ \  \ \  \\  \\ \  \____\ \  \\\  \ \  \____\ \  \\\  \|____|\  \  
           \ \_______\ \_______\       \ \_______\ \__\ \__\\ _\\ \_______\ \_______\ \_______\ \_______\____\_\  \ 
            \|_______|\|_______|        \|_______|\|__|\|__|\|__|\|_______|\|_______|\|_______|\|_______|\_________\
                                                                                                        \|_________|
Informe o raio do círculo: ");
float raio = float.Parse(Console.ReadLine());

float diametro = raio * 2;

float circum = diametro * (float)(Math.PI);

float area = raio * raio * (float)(Math.PI);

Console.WriteLine($@"A circunferência em questão tem:
Diametro = {diametro};
Comprimento = {circum};
Area = {area}.");