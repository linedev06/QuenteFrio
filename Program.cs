// See https://aka.ms/new-console-template for more information
Random random = new Random();
int aleatorio = random.Next (1, 100);
int resultado = 1;
int tentativa = 0;

txt(" --- Quente Frio ---");
Thread.Sleep(1000);
txt("gerando numero ");
Thread.Sleep(1000);
txt("numero aleatorio gerado ");
Thread.Sleep(1000);
txt("Digite o numero gerado entre 1 e 100");

while (resultado != aleatorio)
{
    resultado = int.Parse(Console.ReadLine()!);
    int distancia;
    distancia = Math.Abs(resultado - aleatorio); 
    tentativa++;
 
   if (aleatorio >= 0 && aleatorio <= 100)
   {
    if (tentativa > 7)
    {
        txt("Suas tentativas acabaram: ");
        return;
    } 
    else if (distancia <= 3 && distancia >= 1 )
    {
     txt("Esta pelando");
    }
    else if (distancia > 30)
    {
     txt("Esta congelando");
    }
    else 
    {
     txt("Esta congelando");
     distancia2();
    }
   }
}

Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine($"Parabéns, você acertou o número aleatório! O número era ({aleatorio}), a quantidade de tentativas foram ({tentativa}).");

Console.ResetColor();


void txt(string txt)
{
Console.WriteLine(txt);
}


void distancia2()
{
    if (resultado - aleatorio < 0)
    {
        Console.WriteLine("O número aleatório é maior que o número digitado.");
        Console.WriteLine("");
    }
    else 
    {
        Console.WriteLine("O número aleatório é menor que o número digitado.");
        Console.WriteLine("");
    }
}