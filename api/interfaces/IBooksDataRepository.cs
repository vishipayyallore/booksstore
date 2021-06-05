using System.Collections.Generic;
using System.Threading.Tasks;
using Demo.BooksStore.Data;

namespace Demo.BooksStore.Interfaces
{

  public interface IBooksDataRepository
  {
    Task<IEnumerable<Book>> GetAllBooks(string connectionString);
  }

}
