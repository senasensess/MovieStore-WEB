using BookStore_ApplicationCore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_ApplicationCore.Interfaces
{
    public interface IMovieService : IRepositoryService<Movie>
    {
    }
}
