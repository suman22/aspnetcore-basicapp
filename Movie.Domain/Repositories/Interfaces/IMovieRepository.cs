using App.Base.GenericRepository;
using App.Movie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Movie.Repositories.Interfaces
{
    public interface IMovieRepository : IGenericRepository<MovieModel>
    {
    }
}
