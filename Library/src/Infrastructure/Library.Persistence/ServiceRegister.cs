using Library.Application.Interfaces.Repositories;
using Library.Persistence.Context;
using Library.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistence
{
    public static class ServiceRegister
    {
        public static void AddPersistenceServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(s =>
            {
                s.UseInMemoryDatabase("myDb");
            });

            serviceCollection.AddTransient<IBookRepository, BookRepository>();
        }
    }
}
