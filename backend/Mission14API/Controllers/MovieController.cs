using Microsoft.AspNetCore.Mvc;
using Mission14API.Data;
using Mission14API.Models;
using System.Linq;

namespace Mission14API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private MoviesDbContext context;
        //constructor
        public MovieController(MoviesDbContext temp) 
        {
            context = temp;
        }
        public IEnumerable<Movie> Get()
        {
            //convert to an array and then return x
            var x = context.Movies.ToArray();

            
            return context.Movies
                .Where(x => x.Edited == "Yes")
                .OrderBy(x => x.Title)
                .ToArray();
        }

        
    }
}
