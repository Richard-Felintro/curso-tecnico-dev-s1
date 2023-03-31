Console.WriteLine($@"
 _________  ___  ________  ________  ________           ________  _______                             
|\___   ___\\  \|\   __  \|\   __  \|\   ____\         |\   ___ \|\  ___ \                            
\|___ \  \_\ \  \ \  \|\  \ \  \|\  \ \  \___|_        \ \  \_|\ \ \   __/|                           
     \ \  \ \ \  \ \   ____\ \  \\\  \ \_____  \        \ \  \ \\ \ \  \_|/__                         
      \ \  \ \ \  \ \  \___|\ \  \\\  \|____|\  \        \ \  \_\\ \ \  \_|\ \                        
       \ \__\ \ \__\ \__\    \ \_______\____\_\  \        \ \_______\ \_______\                       
        \|__|  \|__|\|__|     \|_______|\_________\        \|_______|\|_______|                       
                                       \|_________|                                                   
 _________  ________  ___  ________  ________   ________  ___  ___  ___       ________  ________      
|\___   ___\\   __  \|\  \|\   __  \|\   ___  \|\   ____\|\  \|\  \|\  \     |\   __  \|\   ____\     
\|___ \  \_\ \  \|\  \ \  \ \  \|\  \ \  \\ \  \ \  \___|\ \  \\\  \ \  \    \ \  \|\  \ \  \___|_    
     \ \  \ \ \   _  _\ \  \ \   __  \ \  \\ \  \ \  \  __\ \  \\\  \ \  \    \ \  \\\  \ \_____  \   
      \ \  \ \ \  \\  \\ \  \ \  \ \  \ \  \\ \  \ \  \|\  \ \  \\\  \ \  \____\ \  \\\  \|____|\  \  
       \ \__\ \ \__\\ _\\ \__\ \__\ \__\ \__\\ \__\ \_______\ \_______\ \_______\ \_______\____\_\  \ 
        \|__|  \|__|\|__|\|__|\|__|\|__|\|__| \|__|\|_______|\|_______|\|_______|\|_______|\_________\
                                                                                          \|_________|
Qual o comprimento da primeira aresta do triângulo: ");
float aresta1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Qual o comprimento da segunda aresta do triângulo: ");
float aresta2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Qual o comprimento da terceira aresta do triângulo: ");
float aresta3 = float.Parse(Console.ReadLine());

if (aresta1 == aresta2 && aresta2 == aresta3){
    Console.WriteLine($"O triângulo em questão é equilátero.");
    
} else if ((aresta1 != aresta2) && (aresta2 != aresta3)){
    Console.WriteLine($"O triângulo em questão é escaleno.");
}

else {
    Console.WriteLine($"O triângulo em questão é isócele.");
}