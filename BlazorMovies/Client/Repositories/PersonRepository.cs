using BlazorMovies.Client.Helpers;
using BlazorMovies.Shared.DTOs;
using BlazorMovies.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/people";
        public PersonRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<Person> GetPerson(int id)
        {
            return await httpService.GetHelper<Person>($"{url}/{id}");
        }
        public async Task<PaginatedResponse<List<Person>>> GetPeople(PaginationDTO paginationDTO)
        {
            return await httpService.GetHelper<List<Person>>(url, paginationDTO);
        }

        public async Task<List<Person>> GetPeopleByName(string searchText)
        {
            var response = await httpService.Get<List<Person>>($"{url}/search/{searchText}");
            if (!response.Success) { throw new ApplicationException(await response.GetBody()); }
            return response.Response;
        }

        public async Task CreatePerson(Person person)
        {
            var response = await httpService.Post(url, person);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdatePerosn(Person person)
        {
            var response = await httpService.Put(url, person);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
        public async Task DeletePerson(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
