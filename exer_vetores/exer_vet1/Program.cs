// Execicios vetores 01

int[] vet = new int[5];
Console.WriteLine("Digite o primeiro número do vetor:");
vet[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo número do vetor:");
vet[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o terceiro número do vetor:");
vet[2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o quarto número do vetor:");
vet[3] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o quinto número do vetor:");
vet[4] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("O valor do seu vetor é:");
foreach (int num in vet){
    Console.WriteLine(num);
}