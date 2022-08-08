using apiDDD.application;
using apiDDD.application.Interfaces;
using apiDDD.application.Interfaces.Mappers;
using apiDDD.application.Mappers;
using appDDD.domain.core.Interfaces.Repositorys;
using appDDD.domain.core.Interfaces.Services;
using appDDD.domain.services;
using appDDD.infraestructure.Data.Repositorys;
using Autofac;

namespace appDDD.infraestructure.CrossCutting.InjecaoIndependenciaIOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            builder.RegisterType<MapperCLiente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();

            #endregion IOC
        }
    }
}