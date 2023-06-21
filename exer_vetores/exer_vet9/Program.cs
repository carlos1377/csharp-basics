
int num = 0;
int Calculo(int c){
    int teste = c % 2;
    if (teste == 0){
        teste = 1;
    }
    else if(teste == 1){
        teste = 0;
    }
    return teste;
}

Console.WriteLine("Digite o valor para verificar se é positivo ou negativo:");
num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Calculo(num));