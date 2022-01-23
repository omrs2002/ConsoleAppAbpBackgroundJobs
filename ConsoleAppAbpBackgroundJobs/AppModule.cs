using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ConsoleAppAbpBackgroundJobs
{
    //Add dependency to the AbpAutofacModule
    [DependsOn(typeof(AbpAutofacModule))] 
    public class AppModule : AbpModule
    {



    }


}
