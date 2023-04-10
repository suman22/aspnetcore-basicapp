using App.Base.GenericRepository;
using App.Movie.Models;
using App.Movie.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace App.Movie.Repositories
{
    public class MovieRepository : GenericRepository<MovieModel>, IMovieRepository
    {
        public MovieRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
