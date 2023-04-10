using App.Movie.Models;
using App.Movie.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MovieApplication.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActorRepository _actorRepository;

        public ActorController(IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }

        public IActionResult Index()
        {
            var actors = _actorRepository.GetList(x=> x.Id > 0);

            return Ok(actors);
        }

        public IActionResult Add() {
            // just for testing, please add view with form and insert data
            var actor = new ActorModel
            {
                Name = "Suman",
                Address = "Khudunabari"
            };

            _actorRepository.Create(actor);

            return Ok(actor);

        }
    }
}
