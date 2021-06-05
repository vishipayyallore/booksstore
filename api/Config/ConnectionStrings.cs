using Demo.BooksStore.Interfaces;
using System;

namespace Demo.BooksStore.Config
{

  public class ConnectionStrings : IConnectionStrings
  {
    public ConnectionStrings()
    {
      SqlServerConnectionString = Environment
        .GetEnvironmentVariable("SqlServerConnection", EnvironmentVariableTarget.Process);

      SqlServerConnectionString1 = Environment
        .GetEnvironmentVariable("SQLAZURECONNSTR_SqlServerConnection", EnvironmentVariableTarget.Process);

      Console.WriteLine($"SqlServerConnectionString = {SqlServerConnectionString}");
      Console.WriteLine($"SqlServerConnectionString1 = {SqlServerConnectionString1}");
    }


    public string SqlServerConnectionString { get; }
    public string SqlServerConnectionString1 { get; }
  }

}
