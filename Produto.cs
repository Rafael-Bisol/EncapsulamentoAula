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
    }
}