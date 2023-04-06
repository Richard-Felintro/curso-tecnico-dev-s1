// 4. Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
// produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// A.O número de pessoas que responderam SIM.
// B.O número de pessoas que responderam NÃO;
// C.O número de mulheres que responderam SIM;
// D.A porcentagem de homens que responderam NÃO entre todos os homens analisados.

int masc = 0;
int fem = 0;
int mulheresSim = 0;
int homensNao = 0;
int sim = 0;
int nao = 0;
string selecaoSexo = "";

int genero = 0;
for (int sexoPesquisas = 1; sexoPesquisas <= 10; sexoPesquisas ++){
sexo:
Console.WriteLine($@"Informe o seu sexo:
[M] Masculino
[F] Feminino");
selecaoSexo = Console.ReadLine().ToUpper();
switch (selecaoSexo){
    case "M":
    masc ++;
    genero = 0;
    break;
    case "F":
    fem ++;
    genero = 1;
    break;
    default:
    Console.WriteLine($"Valor inválido");
    goto sexo;
    break;
}

gostou:
Console.WriteLine($@"Informe se gostou do produto:
[S] Sim, gostei do produto.
[N] Não gostei do produto.");
string gostou = Console.ReadLine().ToUpper();
switch (gostou){
    case "S":
    if (genero == 1){
    mulheresSim ++;}
    sim ++;
    break;
    case "N":
    if (genero == 0){
    homensNao ++;}
    nao ++;
    break;
    default:
    Console.WriteLine($"Valor inválido");
    goto gostou;
    break;
}
}
Console.WriteLine($@"
Um total de {sim} pessoas responderam que gostaram do produto.
Um total de {nao} pessoas responderam que não gostaram do produto.
Um total de {mulheresSim} mulheres responderam sim.
Um total de {masc/homensNao*100}% dos homens responderam não.");

// 4. Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
// produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// A.O número de pessoas que responderam SIM.
// B.O número de pessoas que responderam NÃO;
// C.O número de mulheres que responderam SIM;
// D.A porcentagem de homens que responderam NÃO entre todos os homens analisados.