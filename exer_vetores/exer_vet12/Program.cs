string ConversorSegundos(int s){
    int h = s / 3600;
    int m = (s % 3600) / 60;
    int ssobra = s % 60;

    string resultado = $"Horas: {h}  Minutos: {m}  Segundos: {ssobra}";
    return resultado;
}

Console.WriteLine("Digite o valor em segundos para ser convertido:");
int segundos = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ConversorSegundos(segundos));
