// Exercício sequencial estrutura de dados
// .5


Console.WriteLine("Digite o seu salário: ");
int salario = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o reajuste que você receberá (sem o '%'): ");
double reajuste = Convert.ToDouble(Console.ReadLine());
double reaj = reajuste / 100;
double reajsalar = salario + (salario * reaj);
Console.WriteLine($"Seu novo salário será: {reajsalar}");
