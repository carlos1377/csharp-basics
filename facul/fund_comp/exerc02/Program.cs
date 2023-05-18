string nome, endereco, telefone;
Console.WriteLine("Digite seu nome: ");
nome = Console.ReadLine() ?? "0";
Console.WriteLine("Digite seu endereço: ");
endereco = Console.ReadLine() ?? "0";
Console.WriteLine("Digite seu telefone: ");
telefone = Console.ReadLine() ?? "0";
Console.WriteLine($"Seu nome é {nome}, de endereço: {endereco} e telefone {telefone}");

