using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movie.Repository;
using Movie.Model;

namespace Movie.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        IMovieRepository _movieRepository;
        public ValuesController(IMovieRepository movieRepository)
        {
            this._movieRepository = movieRepository;
        }
        // GET api/values
        [HttpGet]

        public List<FavMovie> Get()
        {

            List<FavMovie> list = _movieRepository.GetAll();
            return list;
        }

        //public IEnumerable<string> Get()
        //{
        //    _movieRepository.a
        //    //return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]FavMovie famo)
        {
            _movieRepository.Add(famo);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]FavMovie value)
        {
            _movieRepository.Update(id, value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _movieRepository.delete(id);
        }
    }
}
