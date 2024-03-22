using System;

namespace EncapsulamentoAula
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto Livro1 = new Produto("Aprenda C# hoje!", 10, 99.99);
            Console.WriteLine(Livro1.GetNome());
        }
    }
}
