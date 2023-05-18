double[] neg = new double[5];
int i = 0;
Console.WriteLine("Digite 5 números:");
neg[0] = Convert.ToDouble(Console.ReadLine());
neg[1] = Convert.ToDouble(Console.ReadLine());
neg[2] = Convert.ToDouble(Console.ReadLine());
neg[3] = Convert.ToDouble(Console.ReadLine());
neg[4] = Convert.ToDouble(Console.ReadLine());

foreach(double num in neg){
    
    if(num < 0){
        Console.WriteLine($"{num} é negativo");
        i++;
    }
}
Console.WriteLine($"{i} números são negativos");