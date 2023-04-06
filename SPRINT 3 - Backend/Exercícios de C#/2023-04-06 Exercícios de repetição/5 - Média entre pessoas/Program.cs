// 5. Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:
// A.Total de Homens;      
// B.Total de Mulheres;      
// C.Média de idade dos Homens;      
// D.Média de idade das mulheres.
int masc = 0;
int fem = 0;
int genero = 0;

int idadeM = 0;
int idadeF = 0;
int idadeTotal = 0;

for (int sexoPesquisas = 1; sexoPesquisas <= 10; sexoPesquisas ++){
sexo:
Console.WriteLine($@"Informe seu sexo:
[M] Masculino
[F] Feminino");
string sexo = Console.ReadLine().ToUpper();
switch (sexo){
    case "M":
    genero = 0;
    masc ++;
    break;
    case "F":
    genero = 1;
    fem ++;
    break;
    default:
    goto sexo;
    break;
}
// Console.WriteLine($"Informe seu peso:");
// float inutil = float.Parse(Console.ReadLine());
Console.WriteLine($"Informe sua idade");
int idadeInput = int.Parse(Console.ReadLine());
    idadeTotal += idadeInput;
if (genero == 0){
    idadeM += idadeInput;
}
if (genero == 1){
    idadeF += idadeInput;
}
}
Console.WriteLine($@"
Tem um total de {masc} homens.
Tem um total de {fem} mulheres.
A média de idade entre homens é {idadeM/masc}
A idade média entre mulheres é {idadeF/fem}");
