using Demo.BooksStore.Interfaces;
using System;

namespace Demo.BooksStore.Config
{

  public class ConnectionStrings : IConnectionStrings
  {
    public ConnectionStrings()
    {
      SqlServerConnectionString = Environment
          .GetEnvironmentVariable("SQLAZURECONNSTR_SqlServerConnection", EnvironmentVariableTarget.Process);
    }


    public string SqlServerConnectionString { get; }
  }

}
