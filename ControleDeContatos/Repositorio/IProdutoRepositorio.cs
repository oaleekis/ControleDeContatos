using ControleDeContatos.Models;

namespace ControleDeContatos.Repositorio
{
    public interface IProdutoRepositorio
    {
        ProdutoModel ListarPorId(int id);
        List<ProdutoModel> BuscarTodos();
        ProdutoModel Adicionar(ProdutoModel contato);
        ProdutoModel Atualizar(ProdutoModel contato);
        bool Apagar(int id);
    }
}
