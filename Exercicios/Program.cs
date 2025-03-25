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
    return n1 + n2;
}

int resultado = Somar(5, 3);

Console.WriteLine(resultado);

//Crie uma função chamada MostrarMensagem que exibe uma mensagem fixa no console.

void MostrarMensagem()
{
    Console.WriteLine("Este e um programa de C# com funcoes!");
}

MostrarMensagem();

//Crie uma função chamada CalcularMedia que recebe três notas como parâmetros e retorna a média delas.

double CalcularMedia(double n1, double n2, double n3)
{
    return (n1 + n2 + n3) / 3;
}

double media = CalcularMedia(7.5, 8.0, 6.5);
Console.WriteLine("Média: " + media);

//Crie uma função chamada EhPar que recebe um número inteiro e retorna true se ele for par e false se for ímpar.

bool EhPar(int n1)
{
    if (n1 % 2 == 0)
    {
        return true;
    }
    else 
    {
        return false;
    }
}

bool resultado1 = EhPar(9);
Console.WriteLine(resultado1);

//Crie uma função chamada CelsiusParaFahrenheit que recebe uma temperatura em graus Celsius e retorna o equivalente em Fahrenheit.

double CelsiusParaFahrenheit(double n1)
{

    double F = (n1 * 9 / 5) + 32;
    return F;
}
double fahrenheit = CelsiusParaFahrenheit(25);
Console.WriteLine(fahrenheit + " Fahrenheit");

//Crie uma função chamada ContarVogais que recebe uma string e retorna a quantidade de vogais (a, e, i, o, u) na palavra.



