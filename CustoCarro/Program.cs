using System;

namespace CustoCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor de fabrica do carro :");
            double vfabrica = Double.Parse(Console.ReadLine());
            double vfabimp = vfabrica * 0.46;
            double vloja = vfabrica * 0.29;
            Console.WriteLine($"O imposto de fabricação do carro é de R$ {vfabimp} e o valor na loja esta R$ {vloja+vfabimp+vfabrica} ");
        }
    }
}
