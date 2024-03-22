using System;

namespace EncapsulamentoAula
{
    public class Produto
    {
        private string _nome;
        private int _quant;
        private double _preco;

        public Produto(string nome, int quant, double preco){
            _nome = nome;
            _quant = quant;
            _preco = preco;
        }

        public string GetNome(){
            return _nome;
        }
        
        public void SetNome(string nome){
            if (string.IsNullOrWhiteSpace(nome) || nome.Length < 3) {
                return;
            } else {
                _nome = nome;
            }
        }

        public int GetQuantidade(){
            return _quant;
        }

        public void SetQuantidade(int quant){
            if (quant < 0){
                Console.WriteLine("Erro. Quantidade não pode ser negativa.");
                return;
            } else {
                _quant = quant;
            }
        }

        public double GetPreco(){
            return _preco;
        }

        public void SetPreco(double preco){
            if (preco < 0){
                Console.WriteLine("Erro. Preço não pode ser negativo.");
                return;
            } else {
                _preco = preco;
            }
        }

        public override string ToString()
        {
            return $"LIVRO\n\tNome: {_nome}\n\tPreço Unitário: {_preco}\n\tQuantidade: {_quant}";
        }
    }
}