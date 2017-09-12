using Movie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Repository
{
    public interface IMovieRepository
    {
        void Add(FavMovie fm);
        List<FavMovie> GetAll();
        void delete(int id);
        void Update(int id, FavMovie res);
    }
    public class MovieRepository : IMovieRepository
    {
        MovieDb _mdb;
        public MovieRepository(MovieDb mdb)
        {
            _mdb = mdb;
        }
        public void Add(FavMovie fm)
        {
            _mdb.MovieTable.Add(fm);
            _mdb.SaveChanges();
        }

        public void delete(int id)
        {
            FavMovie res = _mdb.MovieTable.FirstOrDefault(m => m.movieid == id);
            _mdb.MovieTable.Remove(res);
            _mdb.SaveChanges();
        }

        public List<FavMovie> GetAll()
        {
            return _mdb.MovieTable.ToList();
        }

        public void Update(int id, FavMovie res)
        {
            FavMovie fmov = _mdb.MovieTable.FirstOrDefault(m => m.movieid == id);
            fmov.overview = res.overview;
            _mdb.SaveChanges();
        }
    }
}
