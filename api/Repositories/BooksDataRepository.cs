using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Demo.BooksStore.Data;

namespace Demo.BooksStore.Interfaces
{

  public class BooksDataRepository : IBooksDataRepository
  {
    public async Task<IEnumerable<Book>> GetAllBooks(string connectionString)
    {
      List<Book> booksList = new List<Book>();

      using (SqlConnection connection = new SqlConnection(connectionString))
      {

        SqlCommand command = new SqlCommand()
        {
          CommandText = "[dbo].[usp_get_all_books]",
          Connection = connection,
          CommandType = CommandType.StoredProcedure
        };

        connection.Open();
        SqlDataReader dataReader = await command.ExecuteReaderAsync().ConfigureAwait(false);

        if (dataReader.HasRows)
        {
          while (await dataReader.ReadAsync().ConfigureAwait(false))
          {
            booksList.Add(
                new Book
                {
                  Id = dataReader.GetInt32(0),

                  PictureUrl = dataReader.GetString(1),

                  Title = dataReader.GetString(2),

                  Author = dataReader.GetString(3),

                  IsActive = dataReader.GetBoolean(4),

                  ISBN = dataReader.GetString(5),

                  Pages = (int)dataReader.GetDecimal(6),

                }
                );
          }

        }
      }

      return booksList;
    }

  }

}
