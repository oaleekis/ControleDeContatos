namespace ControleDeContatos.Models
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal PrecoCompra { get; set; }
        public decimal PrecoVenda { get; set; }
        public int Quantidade { get; set; }

        public decimal TotalParaVenda()
        {
            return PrecoVenda * Quantidade;
        }

    }

}
