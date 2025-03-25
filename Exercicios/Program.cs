//Crie uma função chamada Saudacao que recebe um nome como parâmetro e exibe uma mensagem de boas-vindas.


using System.Security.Cryptography.X509Certificates;

string Saudacao(string nome)
{
    string msg = $"Ola, {nome}! Bem-vindo !";

    return msg;
}

Console.WriteLine(Saudacao("Carlos"));

//Crie uma função chamada Soma que recebe dois números inteiros como parâmetros e retorna a soma deles.

int Somar(int n1, int n2)
{
    int resultado = n1 + n2;

    return resultado;
}

Console.WriteLine(Somar(5, 3));

//Crie uma função chamada MostrarMensagem que exibe uma mensagem fixa no console.

void MostrarMensagem()
{
    Console.WriteLine("Este e um programa de C# com funcoes!");
}

MostrarMensagem();

//Crie uma função chamada CalcularMedia que recebe três notas como parâmetros e retorna a média delas.

double CalcularMedia(double n1, double n2, double n3)
{
    double media = (n1 + n2 + n3) / 3;
    return media;
}


Console.WriteLine(CalcularMedia(7.5, 8.0, 6.5));

//Crie uma função chamada EhPar que recebe um número inteiro e retorna true se ele for par e false se for ímpar.

bool EhPar(int n1)
{
    bool resultado1;
    if (n1 % 2 == 0)
    {
        resultado1 = true;
        return resultado1;
    }
    else 
    {
        resultado1 = false;
        return resultado1;
    }
}

Console.WriteLine(EhPar(9));

//Crie uma função chamada CelsiusParaFahrenheit que recebe uma temperatura em graus Celsius e retorna o equivalente em Fahrenheit.

double CelsiusParaFahrenheit(double n1)
{

    double F = (n1 * 9 / 5) + 32;
    return F;
}
double fahrenheit = CelsiusParaFahrenheit(25);
Console.WriteLine(fahrenheit + " Fahrenheit");

//Crie uma função chamada ContarVogais que recebe uma string e retorna a quantidade de vogais (a, e, i, o, u) na palavra.



