using appDDD.domain.core.Interfaces.Repositorys;
using appDDD.domain.core.Interfaces.Services;
using appDDD.domain.Entitys;

namespace appDDD.domain.services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente repositoryCliente;

        public ServiceCliente(IRepositoryCliente repositoryCliente) : base(repositoryCliente)

        {
            this.repositoryCliente = repositoryCliente;
        }
    }
}