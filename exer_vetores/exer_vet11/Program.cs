int Calculo(int a, int b, int c)
{
int soma = 0;        
for (int i = b; i <= c; i++)
{
    if (i % a == 0)
    {
        soma += i;
    }
}
        
return soma;
}

Console.Write("Digite o valor de a: ");
int a = Convert.ToInt32(Console.ReadLine());
while(a <= 1)
{
    Console.WriteLine("Digite um valor válido!");
    a = Convert.ToInt32(Console.ReadLine());
    if(a > 1)
    {
        break;
    }
}
Console.Write("Digite o valor de b: ");
int b = Convert.ToInt32(Console.ReadLine());        
Console.Write("Digite o valor de c: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O resultado é: {Calculo(a, b, c)}");