using App.Movie.Repositories;
using App.Movie.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Movie
{
    public static class DiConfiguration
    {
        public static IServiceCollection AddMovieServiceConfiguration(this IServiceCollection service)
        {
            service.AddScoped<IMovieRepository, MovieRepository>();
            service.AddScoped<IActorRepository, ActorRepository>();
            return service;
        }
    }
}
