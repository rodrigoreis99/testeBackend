using apiDDD.application.Dtos;
using appDDD.domain.Entitys;

namespace apiDDD.application.Interfaces.Mappers
{//maperamento dto da itendidade
    public interface IMapperCliente

    {
        Cliente MapperDtoToEntity(ClienteDto clienteDto);

        IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes);

        ClienteDto MapperEntityToDto(Cliente cliente);
    }
}