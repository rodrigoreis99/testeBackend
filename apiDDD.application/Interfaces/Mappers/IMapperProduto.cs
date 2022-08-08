using apiDDD.application.Dtos;
using appDDD.domain.Entitys;

namespace apiDDD.application.Interfaces.Mappers
{
    public interface IMapperProduto
    {
        Produto MapperDtoToEntity(ProdutoDto produtoDto);

        IEnumerable<ProdutoDto> MapperListClientesDto(IEnumerable<Produto> produto);

        ProdutoDto MapperEntityToDto(Produto produto);
    }
}