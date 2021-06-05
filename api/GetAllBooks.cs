using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Demo.BooksStore.Interfaces;

namespace Demo.BooksStore
{
  public class GetAllBooks
  {

    private readonly IConnectionStrings _connectionStrings;
    private readonly IBooksDataRepository _booksDataRepository;

    public GetAllBooks(IConnectionStrings connectionStrings, IBooksDataRepository booksDataRepository)
    {
      _connectionStrings = connectionStrings ?? throw new ArgumentNullException(nameof(connectionStrings));

      _booksDataRepository = booksDataRepository ?? throw new ArgumentNullException(nameof(booksDataRepository));
    }

    [FunctionName("GetAllBooks")]
    public async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
        ILogger log)
    {
      log.LogInformation("C# HTTP trigger function request received for Get All Books.");

            var booksList = await _booksDataRepository
                        .GetAllBooks(_connectionStrings.SqlServerConnectionString)
                        .ConfigureAwait(false);

            log.LogInformation("C# HTTP trigger function Get All Books.");

            return new OkObjectResult(booksList);
    }
  }
}
