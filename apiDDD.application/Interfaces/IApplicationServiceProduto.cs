using apiDDD.application.Dtos;

namespace apiDDD.application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void ADD(ProdutoDto produtoDto);

        void Update(ProdutoDto produtoDto);

        void Remove(ProdutoDto produtoDto);

        IEnumerable<ProdutoDto> GetAll();

        ProdutoDto GetById(int id);
    }
}