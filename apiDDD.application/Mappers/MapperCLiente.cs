using apiDDD.application.Dtos;
using apiDDD.application.Interfaces.Mappers;
using appDDD.domain.Entitys;

namespace apiDDD.application.Mappers
{
    public class MapperCLiente : IMapperCliente
    {

        public Cliente MapperDtoToEntity(ClienteDto clienteDto)
        {
            var cliente = new Cliente()
            {
                Id = clienteDto.Id
            ,
                Nome = clienteDto.Nome
            ,
                Sobrenome = clienteDto.Sobrenome
            ,
                Email = clienteDto.Email
            };

            return cliente;
        }

        public ClienteDto MapperEntityToDto(Cliente cliente)
        {
            var clinteDto = new ClienteDto()
            {
                Id = cliente.Id
                ,
                Nome = cliente.Nome
                ,
                Sobrenome = cliente.Sobrenome
                ,
                Email = cliente.Email
            };
            return clinteDto;
        }

        public IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes)
        {
            var dto = clientes.Select(c => new ClienteDto { Id = c.Id, Nome = c.Nome, Sobrenome = c.Sobrenome, Email = c.Email });
            return dto;
        }
    }
}