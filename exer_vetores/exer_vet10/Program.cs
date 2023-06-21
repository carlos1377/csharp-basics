int j = 0;
int CalculoEN(int x, int y){
    if (x < y)
    {
        for (int i = x + 1; i < y; i++){
            j += i;
        }
    }
    if (x > y)
    {
        for (int i = y; i < x; i++){
            j += i;
        }
    }
    return j;
}
Console.WriteLine("Digite dois números inteiros: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CalculoEN(x, y));