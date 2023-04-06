// 2. Faça um programa que leia um nome de usuário e a sua senha e não aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a pedir as informações.

string nome = "0";
string senha = "0";
while (nome == senha){
Console.WriteLine($"Informe o seu nome:");
nome = Console.ReadLine();
Console.WriteLine($"Informe sua senha:");
senha = Console.ReadLine();
if (nome == senha){
    Console.WriteLine($"Seu nome e senha não podem ser iguais.");
}
}
Console.WriteLine($"Valores válidos");