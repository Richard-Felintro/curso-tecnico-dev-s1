bool valido = true;
       Console.WriteLine(@$"
 ________  ___      ___ ________  ___       ___  ________  ________  ________  ________  ________          ________  _______      
|\   __  \|\  \    /  /|\   __  \|\  \     |\  \|\   ___ \|\   __  \|\   ____\|\   __  \|\   __  \        |\   ___ \|\  ___ \     
\ \  \|\  \ \  \  /  / | \  \|\  \ \  \    \ \  \ \  \_|\ \ \  \|\  \ \  \___|\ \  \|\  \ \  \|\  \       \ \  \_|\ \ \   __/|    
 \ \   __  \ \  \/  / / \ \   __  \ \  \    \ \  \ \  \ \\ \ \   __  \ \  \    \ \   __  \ \  \\\  \       \ \  \ \\ \ \  \_|/__  
  \ \  \ \  \ \    / /   \ \  \ \  \ \  \____\ \  \ \  \_\\ \ \  \ \  \ \  \____\ \  \ \  \ \  \\\  \       \ \  \_\\ \ \  \_|\ \ 
   \ \__\ \__\ \__/ /     \ \__\ \__\ \_______\ \__\ \_______\ \__\ \__\ \_______\ \__\ \__\ \_______\       \ \_______\ \_______\
    \|__|\|__|\|__|/       \|__|\|__|\|_______|\|__|\|_______|\|__|\|__|\|_______|\|__|\|__|\|_______|        \|_______|\|_______|
        ________  ________   ___  ___      ___ _______   ________  ________  ________  ________  ___  ________                 
       |\   __  \|\   ___  \|\  \|\  \    /  /|\  ___ \ |\   __  \|\   ____\|\   __  \|\   __  \|\  \|\   __  \                
       \ \  \|\  \ \  \\ \  \ \  \ \  \  /  / | \   __/|\ \  \|\  \ \  \___|\ \  \|\  \ \  \|\  \ \  \ \  \|\  \               
        \ \   __  \ \  \\ \  \ \  \ \  \/  / / \ \  \_|/_\ \   _  _\ \_____  \ \   __  \ \   _  _\ \  \ \  \\\  \              
         \ \  \ \  \ \  \\ \  \ \  \ \    / /   \ \  \_|\ \ \  \\  \\|____|\  \ \  \ \  \ \  \\  \\ \  \ \  \\\  \             
          \ \__\ \__\ \__\\ \__\ \__\ \__/ /     \ \_______\ \__\\ _\ ____\_\  \ \__\ \__\ \__\\ _\\ \__\ \_______\            
           \|__|\|__|\|__| \|__|\|__|\|__|/       \|_______|\|__|\|__|\_________\|__|\|__|\|__|\|__|\|__|\|_______|            
                                                                     \|_________|                                              ");
reiniciar:
Console.WriteLine($"Qual o seu ano de aniversário?");
int ano = int.Parse(Console.ReadLine());

if (ano < 1900){
       valido = false;
       Console.WriteLine($"~~~~~ VALOR INVÁLIDO : Nenhum ser humano nascido neste ano está vivo atualmente ~~~~~");
       goto reiniciar;
}

else if (ano > 2013){
       Console.WriteLine($"~~~~~ VALOR INVÁLIDO : Este ano ainda não chegou ~~~~~");
       goto reiniciar;
}

else {
       Console.WriteLine($"Qual o número do seu mês de aniversário?");
}
       int mes = int.Parse(Console.ReadLine());

if (mes < 1){
       valido = false;
       Console.WriteLine($"~~~~~ VALOR INVÁLIDO : Meses não podem ser menores que 1 ~~~~~");
       goto reiniciar;
}
else if (mes > 12){
       Console.WriteLine($"~~~~~ VALOR INVÁLIDO : Meses vão de 1 a 12 apenas ~~~~~");
       goto reiniciar;
}
else {
       Console.WriteLine($"Qual o seu dia de aniversário?");
}
       int dia = int.Parse(Console.ReadLine());

if (dia < 1){
       valido = false;
       Console.WriteLine($"~~~~~ VALOR INVÁLIDO : Dias não podem ser abaixo de 1 ~~~~~");
       goto reiniciar;
}

else if (dia > 31){
       valido = false;
       Console.WriteLine($"~~~~~ VALOR INVÁLIDO : Meses tem 31 dias no máximo ~~~~~");
       goto reiniciar;
}
else{
       Console.WriteLine($@"
 ________  ________  _________  ________          ___      ___ ________  ___       ___  ________  ________     
|\   ___ \|\   __  \|\___   ___\\   __  \        |\  \    /  /|\   __  \|\  \     |\  \|\   ___ \|\   __  \    
\ \  \_|\ \ \  \|\  \|___ \  \_\ \  \|\  \       \ \  \  /  / | \  \|\  \ \  \    \ \  \ \  \_|\ \ \  \|\  \   
 \ \  \ \\ \ \   __  \   \ \  \ \ \   __  \       \ \  \/  / / \ \   __  \ \  \    \ \  \ \  \ \\ \ \   __  \  
  \ \  \_\\ \ \  \ \  \   \ \  \ \ \  \ \  \       \ \    / /   \ \  \ \  \ \  \____\ \  \ \  \_\\ \ \  \ \  \ 
   \ \_______\ \__\ \__\   \ \__\ \ \__\ \__\       \ \__/ /     \ \__\ \__\ \_______\ \__\ \_______\ \__\ \__\
    \|_______|\|__|\|__|    \|__|  \|__|\|__|        \|__|/       \|__|\|__|\|_______|\|__|\|_______|\|__|\|__|");
}