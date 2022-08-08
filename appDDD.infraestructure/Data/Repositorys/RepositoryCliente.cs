using appDDD.domain.core.Interfaces.Repositorys;

namespace appDDD.infraestructure.Data.Repositorys
{
    public class RepositoryCliente : RepositoryBase<domain.Entitys.Cliente>, IRepositoryCliente
    {
        private readonly SqlContext sqlContext;

        public RepositoryCliente(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}