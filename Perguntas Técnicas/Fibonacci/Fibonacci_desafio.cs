namespace Perguntas_Técnicas.Fibonacci
{
    public class Fibonacci
    {
        public void CalcFibonacci(int x)
        {
            int Fibonacci = 0;
            int A1 = 0;
            int A2 = 1;
            bool resultado;
            do
            {
                Fibonacci = A1 + A2;
                A1 = A2;
                A2 = Fibonacci;
            } while (Fibonacci < x);
            resultado = Fibonacci == x ? true : false;
            Console.WriteLine(resultado);
        }
    }
}

