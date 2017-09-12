using Movie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Repository
{
    public interface ILoginRepository
    {
        List<Login> GetAllRepo();
        Login GetOne(int code);
        void AddLogin(Login login);

        void DeleteLogin(int code);

        void UpdateLogin(int code, Login login);
    }
    public class LoginRepository : ILoginRepository
    {
        private MovieDb _movie;
        public LoginRepository(MovieDb movie)
        {
            _movie = movie;
        }
        public void AddLogin(Login login)
        {
            _movie.Logins.Add(login);
            _movie.SaveChanges();
        }

        public void DeleteLogin(int id)
        {
            Login login = _movie.Logins.FirstOrDefault(p => p.id == id);
            _movie.Logins.Remove(login);
            _movie.SaveChanges();
        }

        public List<Login> GetAllRepo()
        {
            return _movie.Logins.ToList();
        }

        public Login GetOne(int id)
        {
            Login login = _movie.Logins.FirstOrDefault(p => p.id == id);
            return login;
        }

        public void UpdateLogin(int id, Login login)
        {
            Login currentair = _movie.Logins.FirstOrDefault(p => p.id == id);
            _movie.SaveChanges();
        }
    }
}
