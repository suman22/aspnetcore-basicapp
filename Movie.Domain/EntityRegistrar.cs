using App.Movie.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Movie
{
    public static class EntityRegistrar
    {
        public static ModelBuilder AddMovieEntity(this ModelBuilder builder)
        {
            builder.Entity<ActorModel>();
            builder.Entity<MovieModel>();
            return builder;
        }
    }
}
