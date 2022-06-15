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
    public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, BookViewDto>
    {
        private readonly IBookRepository bookRepository;

        public GetBookByIdQueryHandler(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public async Task<BookViewDto> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
        {
            var book = await bookRepository.GetByIdAsync(request.Id);

            //TODO:mappimg
            BookViewDto bookViewDto = new BookViewDto();
            bookViewDto.Id = book.Id;   
            bookViewDto.Name = book.Name;
            bookViewDto.Author = book.Author;

            return bookViewDto;
        }
    }
}
