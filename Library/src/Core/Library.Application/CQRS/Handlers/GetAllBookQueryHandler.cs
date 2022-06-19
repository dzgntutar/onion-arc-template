using Library.Application.CQRS.Queries;
using Library.Application.Dtos;
using Library.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.CQRS.Handlers
{
    public class GetAllBookQueryHandler : IRequestHandler<GetAllBookQuery, List<BookViewDto>>
    {
        private readonly IBookRepository bookRepository;

        public GetAllBookQueryHandler(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public async Task<List<BookViewDto>> Handle(GetAllBookQuery request, CancellationToken cancellationToken)
        {
            var books = await bookRepository.GetAllAsync();

            //TODO : mapping
            return books.Select(s => new BookViewDto
            {
                Id = s.Id,
                Name = s.Name,
                Author = s.Author,
            }).ToList();
        }
    }
}
