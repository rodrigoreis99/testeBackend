using Autofac;

namespace appDDD.infraestructure.CrossCutting.InjecaoIndependenciaIOC
{
    public class ModeleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIOC.Load(builder);
        }
    }
}