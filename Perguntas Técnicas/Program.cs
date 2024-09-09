using Perguntas_Técnicas.Fibonacci;
using Perguntas_Técnicas.Verificar_String;

// Questão 1
Fibonacci fibonacci = new Fibonacci();

fibonacci.CalcFibonacci(987);
// Fim questão 1

// Questao 2
Desafio_String desafio_String = new Desafio_String();

desafio_String.ContarLetras("Matheus adora avocado");
// Fim questao 2

// Questao 3
int Indice = 12;
int Soma = 0;
int K = 1;

while (K < Indice)
{
    K = K + 1;
    Soma = Soma + K;
}
Console.WriteLine(Soma);

// Soma = 77

// Fim Questao 3