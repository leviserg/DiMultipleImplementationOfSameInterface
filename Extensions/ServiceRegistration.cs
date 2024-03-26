using DiMultipleImplementationOfSameInterface.Services.Implementations;
using DiMultipleImplementationOfSameInterface.Services.Interfaces;

namespace DiMultipleImplementationOfSameInterface.Extensions
{
    public static class ServiceRegistration
    {
        public static void AddDependentServices(this IServiceCollection services)
        {

            //services.AddTransient<INumberService, ThreeNumberService>();
            //services.AddTransient<INumberService, RandomNumberService>();

            /*
             * Keyed Service registration added in .NET 8
             * 
            services.AddKeyedTransient<INumberService, ThreeNumberService>("three"); // AddKeyedScoped
            services.AddKeyedTransient<INumberService, FiveNumberService>("five");
            services.AddKeyedTransient<INumberService, RandomNumberService>("random");
            */

            /*
             * Resolve Service registration in earlier versions using IEnumerable Service collection - example in NumbersController
            */

            services.AddTransient<INumberService, ThreeNumberService>(); // AddScoped
            services.AddTransient<INumberService, FiveNumberService>();
            services.AddTransient<INumberService, RandomNumberService>();


            /*
             * Descriptive registration style
             * 
            ServiceDescriptor numberServiceDescriptor = new(
                serviceType: typeof(INumberService),
                implementationType: typeof(RandomNumberService),
                lifetime: ServiceLifetime.Transient
            );

            services.TryAddEnumerable(numberServiceDescriptor); // will check the uniqueness registration of the service implementation and skip if it is registered already
            */


            services.AddControllers();

            // Swagger

            services.AddEndpointsApiExplorer();

            services.AddSwaggerGen();

        }
    }
}
