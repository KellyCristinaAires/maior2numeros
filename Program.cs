using System;

namespace maior2numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            double MaiorValor = 0;

            Console.Write("Digite o 1ºvalor: ");
            valor = double.Parse(Console.ReadLine());
            
            if (valor > MaiorValor)
            {
               MaiorValor = valor;
               
            }
                
           Console.Write("Digite O 2ºvalor; ");
           valor = double.Parse(Console.ReadLine());

           if (valor > MaiorValor)
           {
           MaiorValor = valor;
           }
            
          Console.WriteLine($" O maior numero digitado é: {MaiorValor}");
        }
    }
}
