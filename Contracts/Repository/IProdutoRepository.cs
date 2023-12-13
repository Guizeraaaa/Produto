using Produto.Entity;


namespace Produto.Contracts.Repository
{
    public interface IProdutoRepository
    {
     Task Add(ProdutoEntity produto);
    Task upda(ProdutoEntity produto);
    Task Delete(ProdutoEntity produto);

    Task<ProdutoEntity> GetById(int id);
    
    Task<ProdutoEntity> GetByName(string name);

        Task<IEnumerable<ProdutoEntity>> Get();
    }
}
