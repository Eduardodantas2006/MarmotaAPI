using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarmotaApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static MarmotaApi.Models.ConexaoDbContext;

namespace MarmotaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
       
     private readonly MoviesDbContext _db;

        public MovieController(MoviesDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public List<Movie> Get()
        {
            return _db.Movies.ToList();
        }

        [HttpGet("{id}")]
        public Movie Get(int Id)
        {
            return _db.Movies.Find(Id);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Movie obj)
        {
            _db.Movies.Add(obj);
            _db.SaveChanges();
            return new ObjectResult("Filme Incluido na Agenda!");

        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody]Movie obj)
        {
            _db.Entry(obj).State = EntityState.Modified;
            _db.SaveChanges();
            return new ObjectResult("Filme Alterado na agenda com sucesso!");
        }



        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _db.Movies.Remove(_db.Movies.Find(id));
            _db.SaveChanges();
            return new ObjectResult("Filme excluido da agenda com sucesso!");
            
        }
    }
}

