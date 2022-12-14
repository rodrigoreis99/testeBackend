using apiDDD.application.Dtos;
using apiDDD.application.Interfaces.Mappers;
using appDDD.domain.Entitys;

namespace apiDDD.application.Mappers
{
    public class MapperProduto : IMapperProduto
    {
        public Produto MapperDtoToEntity(ProdutoDto produtoDto)
        {
            var produto = new Produto()
            {
                Id = produtoDto.Id
                ,
                Nome = produtoDto.Nome
                ,
                Valor = produtoDto.Valor
            };

            return produto;
        }

        public ProdutoDto MapperEntityToDto(Produto produto)
        {
            var produtoDto = new ProdutoDto()
            {
                Id = produto.Id
                ,
                Nome = produto.Nome
                ,
                Valor = produto.Valor
            };

            return produtoDto;
        }

        public IEnumerable<ProdutoDto> MapperListClientesDto(IEnumerable<Produto> produtos)
        {
            var dto = produtos.Select(p => new ProdutoDto { Id = p.Id, Nome = p.Nome, Valor = p.Valor });
            return dto;
        }
    }
}