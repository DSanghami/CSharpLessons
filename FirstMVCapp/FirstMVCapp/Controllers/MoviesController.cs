using FirstMVCapp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCapp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: MoviesController
        public ActionResult Index()
        {
            List<Movies> movieList = MoviesRepository.GetMovieList();
            return View(movieList);
        }

        // GET: MoviesController/Details/5
        public ActionResult Details(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("Index");
            }
            Movies movies = MoviesRepository.GetMoviesById(id);
            return View(movies);
        }

        // GET: MoviesController/Create
        public ActionResult Create()
        {
            Movies movie = new Movies();
            return View(movie);
        }

        // POST: MoviesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Movies pMovie)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    MoviesRepository.AddNewMovies(pMovie);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MoviesController/Edit/5
        public ActionResult Edit(int id)
        {
            

                if (id <= 0)
                {
                    return RedirectToAction("Index");
                }
                Movies movie = MoviesRepository.GetMoviesById(id);
                return View(movie);
            
        }

        // POST: MoviesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection, Movies pmovies)
        {
            Console.WriteLine(ModelState.IsValid);

            try
            {
                if (ModelState.IsValid)
                {
                    MoviesRepository.UpdateMovies(id, pmovies);
                }


                

                    return RedirectToAction(nameof(Index));   

            }
            catch
            {
                return View();
            }
        }

        // GET: MoviesController/Delete/5
        public ActionResult Delete(int id)
        {

            if (id <= 0)
            {
                return RedirectToAction("Index");
            }



            Movies movie = MoviesRepository.GetMoviesById(id);
            return View(movie);
        }

        // POST: MoviesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            if (ModelState.IsValid)
            {
                MoviesRepository.DeletMovies(id);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
