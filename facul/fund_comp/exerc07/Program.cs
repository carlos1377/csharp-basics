double vboleto, pjuros;
Console.WriteLine($"Digite o valor do boleto a ser pago: ");
vboleto = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Digite o percentual do juros aplicado: ");
pjuros = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o número de dias em atraso: ");
int ndias = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"O valor da prestação é: {vboleto + (vboleto * (pjuros/100)) * ndias}");

