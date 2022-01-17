using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de impostos!");

            Imposto iss = new Iss();
            Imposto icms = new Icms();
            Imposto iccc = new Iccc();

            //O calculador serve para caso haja alguma outra regra de negócio
            //Se não houver, ela não é necessária
            var calculador = new CalculadorDeImpostos();

            var orcamento = new Orcamento(100);

            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(orcamento, iccc);

            Console.WriteLine(iss.Calcula(orcamento));
            Console.WriteLine(icms.Calcula(orcamento));
            Console.WriteLine(iccc.Calcula(orcamento));

            Console.ReadKey();
        }
    }
}
