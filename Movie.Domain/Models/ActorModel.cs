using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Movie.Models
{
    public class ActorModel
    {
        public long Id  { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public IEnumerable<MovieModel> Movies { get; set; } 

    }
}
