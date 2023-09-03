using BookStore_ApplicationCore.Entities.Concrete;
using BookStore_ApplicationCore.Interfaces;
using BookStore_Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Infrastructure.Data
{
    public class CategoryService : EfRepository<Category>, ICategoryService
    {
        public CategoryService(AppDbContext context) : base(context)
        {
        }
    }
}
