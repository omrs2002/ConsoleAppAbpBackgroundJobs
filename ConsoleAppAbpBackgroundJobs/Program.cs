using System;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;


namespace ConsoleAppAbpBackgroundJobs
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var application = AbpApplicationFactory.Create<AppModule>())
            {
                application.Initialize();

                //Resolve a service and use it
                var helloWorldService =  application.ServiceProvider.GetService<HelloWorldService>();
                helloWorldService.SayHello();

                Console.WriteLine("Press ENTER to stop application...");
                //Console.ReadLine();
            }
        }
    }

}
