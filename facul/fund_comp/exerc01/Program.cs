int idade, ano_nasc, ano;
Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine() ?? "0";
Console.WriteLine("Digite sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());
DateTime now = DateTime.Now;
ano = Convert.ToInt32(now.Year);
ano_nasc = ano - idade;
Console.WriteLine($"{nome}, seu ano de nascimento é : {ano_nasc}!");