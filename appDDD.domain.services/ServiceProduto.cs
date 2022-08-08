using appDDD.domain.core.Interfaces.Repositorys;
using appDDD.domain.core.Interfaces.Services;
using appDDD.domain.Entitys;

namespace appDDD.domain.services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto repositoryProduto;

        public ServiceProduto(IRepositoryProduto repositoryProduto)
            : base(repositoryProduto)
        {
            this.repositoryProduto = repositoryProduto;
        }
    }
}