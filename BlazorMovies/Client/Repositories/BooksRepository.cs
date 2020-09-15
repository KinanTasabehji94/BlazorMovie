using BlazorMovies.Client.Helpers;
using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly IHttpService httpService;
        private readonly string url = "api/books";

        public BookRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task CreateBook(Book Book)
        {
            var response = await httpService.Post(url, Book);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteBook(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task<Book> GetBook(int id)
        {
            var response = await httpService.Get<Book>($"{url}/{id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<List<Book>> GetBooks()
        {
            var response = await httpService.Get<List<Book>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task UpdateBook(Book Book)
        {
            var response = await httpService.Put(url, Book);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
