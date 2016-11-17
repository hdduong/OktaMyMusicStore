using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMusic1.Models;

namespace MyMusic1.Controllers
{
    public class StoreController : Controller
    {
        private MusicStoreEntities _storeDB = new MusicStoreEntities();
        // GET: Store
        public ActionResult Index()
        {
            var genres = _storeDB.Genres.ToList();
            return View(genres);
        }


        public ActionResult Browse(string genre)
        {
            // generating follwing sql 
            //LEFT OUTER JOIN [dbo].[Albums] AS [Extent2] ON [Limit1].[GenreId] = [Extent2].[GenreId]
            var genreModel = _storeDB.Genres.Include("Albums").Single(x => x.Name.ToLower().Equals(genre.ToLower()));
            
            return View(genreModel);
        }
    

        public ActionResult Details(int id)
        {
            var album = _storeDB.Albums.Find(id);
            return View(album);
        }
    }
}