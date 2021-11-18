using System;
using Volo.Abp.DependencyInjection;

namespace ConsoleAppAbpBackgroundJobs
{
    public class HelloWorldService : ITransientDependency
    {
        public void SayHello()
        {
            Console.WriteLine("Hello World!");
        }
    }


}
