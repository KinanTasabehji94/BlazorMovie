using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BlazorMovies.Client.Helpers;
using Blazor.FileReader;
using BlazorMovies.Client.Repositories;
using Microsoft.AspNetCore.Components.Authorization;
using BlazorMovies.Client.Auth;

namespace BlazorMovies.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<IHttpService, HttpService>();
            builder.Services.AddScoped<IGenreRepository, GenreRepository>();
            builder.Services.AddScoped<IPersonRepository, PersonRepository>();
            builder.Services.AddScoped<IMoviesRepository, MoviesRepository>();
            builder.Services.AddScoped<IRatingRepository, RatingRepository>();

            builder.Services.AddScoped<IBookRepository, BookRepository>();


            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<JWTAuthenticationStateProvider>();
            builder.Services.AddScoped<IAccountsRepository, AccountsRepository>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<AuthenticationStateProvider, JWTAuthenticationStateProvider>(
                            provider => provider.GetRequiredService<JWTAuthenticationStateProvider>());
            builder.Services.AddScoped<ILoginService, JWTAuthenticationStateProvider>(
                provider => provider.GetRequiredService<JWTAuthenticationStateProvider>());

            //Add Services Here 
            builder.Services.AddTransient<IRepository, RepositoryMemory>();
            builder.Services.AddFileReaderService(options => options.InitializeOnFirstCall = true);

            await builder.Build().RunAsync();
        }
    }
}
