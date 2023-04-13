static float LeaoFaminto(float renda)
{
    float imposto = 0;
    if (renda > 1500F && renda <= 3500F)
    {
        imposto = 0.2F;
    }
    else if (renda > 3500F && renda <= 6000F)
    {
        imposto = 0.25F;
    }
    else{
        imposto = 0.3F;
    }
    return (float)Math.Round((renda * (1 - imposto)), 2);
}

Console.WriteLine($"~+~+~ CALCULADORA DE IMPOSTO DE RENDA ~+~+~");
Console.WriteLine($"Informe o valor da renda:");
float renda = float.Parse(Console.ReadLine());
Console.WriteLine($"A sua renda final é R${LeaoFaminto(renda)}.");