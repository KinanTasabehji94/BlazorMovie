using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Repositories
{
    public interface IBookRepository
    {
        Task CreateBook(Book Book);
        Task<Book> GetBook(int id);
        Task<List<Book>> GetBooks();
        Task UpdateBook(Book Book);
        Task DeleteBook(int Id);
    }
}
