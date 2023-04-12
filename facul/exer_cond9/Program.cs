// Exercício condicional Estrutura de Dados
// .9
Console.WriteLine("Digite o dia da primeira data: ");
string dia1 = Console.ReadLine() ?? "0";
Console.WriteLine("Digite o mês da primeira data: ");
string mes1 = Console.ReadLine() ?? "0";
Console.WriteLine("Digite o ano da primeira data: ");
string ano1 = Console.ReadLine() ?? "0";
Console.WriteLine("Digite o dia da segunda data: ");
string dia2 = Console.ReadLine() ?? "0";
Console.WriteLine("Digite o mês da segunda data: ");
string mes2 = Console.ReadLine() ?? "0";
Console.WriteLine("Digite o ano da segunda data: ");
string ano2 = Console.ReadLine() ?? "0";
Console.WriteLine($"a primeira data fornecida é {dia1}/{mes1}/{ano1}");
Console.WriteLine($"a segunda data fornecida é {dia2}/{mes2}/{ano2}");
int data1 = Convert.ToInt32($"{ano1}{mes1}{dia1}");
int data2 = Convert.ToInt32($"{ano2}{mes2}{dia2}");
Console.WriteLine($"{data1} & {data2}");
if(data1 > data2){
    Console.WriteLine("A primeira data é cronologicamente maior que a segunda");
}
else{
    Console.WriteLine("A segunda data é cronologicamente maior que a primeira");
}