using Library.Application.Interfaces.Repositories;
using Library.Domain.Entities;
using Library.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistence.Repositories
{
    public class BookRepository : BaseRepository<Book>,IBookRepository
    {
        public BookRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
