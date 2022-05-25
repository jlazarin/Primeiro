using System;


namespace Primeiro
{
    class CalculoInvestimento
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular Poupança");

            double valorInvestido = 3000;
            int contadorMes = 1;

            //rendimento de 0.36% = 0.0036
            while (contadorMes <= 365)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.000014;

                Console.WriteLine("Após " + contadorMes + " dia, o valor será de "
                    + valorInvestido.ToString("F2"));

                contadorMes = contadorMes + 1;
            }

            Console.ReadLine();
        }

    }
}
