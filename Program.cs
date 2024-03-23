using System;

namespace EncapsulamentoAula
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto("Tijela", 1.99);
            Produto p2 = new Produto("Mc Book Wind", 999.90, 100 );
            Produto p3 = new Produto("Aprenda C# hoje!", 99.99, 10);
            Console.WriteLine(p1.Nome);

            p1.Nome = "Tupperware";
            p1.Preco = -142;
        }
    }
}
