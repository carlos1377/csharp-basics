int num, calculo;
Console.WriteLine("Digite um número inteiro para saber se ele é par ou ímpar: ");
num = Convert.ToInt32(Console.ReadLine());
calculo = num % 2;
if (calculo == 0){
    Console.WriteLine($"{num} é um número par.");
}
else{
    Console.WriteLine($"{num} é um número ímpar.");
}
