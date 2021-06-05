using Demo.BooksStore.Config;
using Demo.BooksStore.Interfaces;
// using Demo.BooksStore.Repositories;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;


[assembly: FunctionsStartup(typeof(Demo.BooksStore.Startup))]
namespace Demo.BooksStore
{

  public class Startup : FunctionsStartup
  {

    public override void Configure(IFunctionsHostBuilder builder)
    {
      builder.Services.AddSingleton<IConnectionStrings, ConnectionStrings>();

      builder.Services.AddTransient<IBooksDataRepository, BooksDataRepository>();
    }

  }

}
