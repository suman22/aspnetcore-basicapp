using App.Base.GenericRepository;
using App.Movie.Models;
using App.Movie.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Movie.Repositories
{
    public class ActorRepository : GenericRepository<ActorModel>, IActorRepository
    {
        public ActorRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
