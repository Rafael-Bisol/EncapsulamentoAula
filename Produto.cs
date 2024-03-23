using System;

namespace EncapsulamentoAula
{
    public class Produto
    {
        private string _nome; // Atributo
        private double _preco; // Atributo
        public int Quantidade2{get; set;} // Propriedade
        public int Quantidade{get; private set;} // Não vai conseguir mudar o valor, só ler

        public string Nome
        {
            get {
                return _nome;
            }
            set {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3) {
                    Console.WriteLine("Nome nulo ou com menos de 3 caracteres.");
                    return;
                }
                _nome = value;
            }
        }

        public double Preco
        {
            get { return _preco; }
            set {
                if (value < 0) {
                    Console.WriteLine("Preço não pode ser negativo.");
                    return;
                }
                _preco = value;
            }
        }

        public Produto(string nome, double preco){
            Nome = nome;
            Preco = preco;
            Quantidade = 1;
        }
        
        public Produto(string nome, double preco, int quant) : this(nome, preco){
            Quantidade = quant;
        }

        public override string ToString()
        {
            return $"LIVRO\n\tNome: {_nome}\n\tPreço Unitário: {_preco}\n\tQuantidade: {Quantidade}";
        }
    }
}