// Exercício sequencial estrutura de dados
// .6
Console.WriteLine("Digite seu salário base:");
int salariob = Convert.ToInt32(Console.ReadLine());
double bonif = salariob * 0.05;
double impost = salariob * 0.07;
double salariot = salariob + bonif - impost;
Console.WriteLine($"O seu salário total com 5% de bonificação e 7% de impostos pagos será de: {salariot}");

