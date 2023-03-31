bool identico = false;
Console.WriteLine($@"
 ________  ________  _____ ______   ________  ________  ________  ________  ________  ________  ________            
|\   ____\|\   __  \|\   _ \  _   \|\   __  \|\   __  \|\   __  \|\   __  \|\   ____\|\   __  \|\   __  \           
\ \  \___|\ \  \|\  \ \  \\\__\ \  \ \  \|\  \ \  \|\  \ \  \|\  \ \  \|\  \ \  \___|\ \  \|\  \ \  \|\  \          
 \ \  \    \ \  \\\  \ \  \\|__| \  \ \   ____\ \   __  \ \   _  _\ \   __  \ \  \    \ \   __  \ \  \\\  \         
  \ \  \____\ \  \\\  \ \  \    \ \  \ \  \___|\ \  \ \  \ \  \\  \\ \  \ \  \ \  \____\ \  \ \  \ \  \\\  \        
   \ \_______\ \_______\ \__\    \ \__\ \__\    \ \__\ \__\ \__\\ _\\ \__\ \__\ \_______\ \__\ \__\ \_______\       
    \|_______|\|_______|\|__|     \|__|\|__|     \|__|\|__|\|__|\|__|\|__|\|__|\|_______|\|__|\|__|\|_______|       
        ________  _______           ________   ___  ___  _____ ______   _______   ________  ________  ________      
       |\   ___ \|\  ___ \         |\   ___  \|\  \|\  \|\   _ \  _   \|\  ___ \ |\   __  \|\   __  \|\   ____\     
       \ \  \_|\ \ \   __/|        \ \  \\ \  \ \  \\\  \ \  \\\__\ \  \ \   __/|\ \  \|\  \ \  \|\  \ \  \___|_    
        \ \  \ \\ \ \  \_|/__       \ \  \\ \  \ \  \\\  \ \  \\|__| \  \ \  \_|/_\ \   _  _\ \  \\\  \ \_____  \   
         \ \  \_\\ \ \  \_|\ \       \ \  \\ \  \ \  \\\  \ \  \    \ \  \ \  \_|\ \ \  \\  \\ \  \\\  \|____|\  \  
          \ \_______\ \_______\       \ \__\\ \__\ \_______\ \__\    \ \__\ \_______\ \__\\ _\\ \_______\____\_\  \ 
           \|_______|\|_______|        \|__| \|__|\|_______|\|__|     \|__|\|_______|\|__|\|__|\|_______|\_________\
                                                                                                        \|_________|
Informe o primeiro número: ");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o segundo número: ");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o terceiro número: ");
int numero3 = int.Parse(Console.ReadLine());

if (numero1 > numero2 && numero1 > numero3){
    Console.WriteLine($"O primeiro número é o maior entre eles");
}

else if (numero2 > numero1 && numero2 > numero3){
    Console.WriteLine($"O segundo número é o maior entre eles");
}

else if (numero3 > numero1 && numero3 > numero2){
    Console.WriteLine($"O terceiro número é o maior entre eles");
}

else {
    identico = true;
    goto identico;
}


if (numero1 < numero2 && numero1 < numero3){
    Console.WriteLine($"e o primeiro número é o menor entre eles");
}

else if (numero2 < numero1 && numero2 < numero3){
    Console.WriteLine($"e o segundo número é o menor entre eles");
}

else{
    Console.WriteLine($"e o terceiro número é o menor entre eles");
}

identico:
if (identico == true) {
    Console.WriteLine($"Todos os valores são identicos");
}