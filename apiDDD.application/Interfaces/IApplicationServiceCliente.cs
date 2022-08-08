using apiDDD.application.Dtos;

namespace apiDDD.application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Add(ClienteDto clienteDto);

        void Update(ClienteDto clienteDto);

        void Remove(ClienteDto cliente);

        IEnumerable<ClienteDto> GetAll();

        ClienteDto GetById(int id);
    }
}