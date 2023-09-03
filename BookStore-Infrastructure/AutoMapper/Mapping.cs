using AutoMapper;
using BookStore_ApplicationCore.DTO_s.CategoryDTO;
using BookStore_ApplicationCore.DTO_s.DirectorDTO;
using BookStore_ApplicationCore.DTO_s.MovieDTO;
using BookStore_ApplicationCore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Infrastructure.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Category, AddCategoryDTO>().ReverseMap();
            CreateMap<Category, UpdateCategoryDTO>().ReverseMap();

            CreateMap<Director, AddDirectorDTO>().ReverseMap();
            CreateMap<Director, UpdateDirectorDTO>().ReverseMap();

            CreateMap<Movie, AddMovieDTO>().ReverseMap();
            CreateMap<Movie, UpdateMovieDTO>().ReverseMap();
        }
    }
}
