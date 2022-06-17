using Library.Application.CQRS.Commands;
using Library.Application.Interfaces.Repositories;
using Library.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.CQRS.Handlers
{
    public class AddBookCommandHandler : IRequestHandler<AddBookCommand>
    {
        private readonly IBookRepository bookRepository;

        public AddBookCommandHandler(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public async Task<Unit> Handle(AddBookCommand request, CancellationToken cancellationToken)
        {
            await bookRepository.AddAsync(new Book { Name = request.BookSaveDto.Name, Author = request.BookSaveDto.Author, Count = request.BookSaveDto.Count });

            return Unit.Value;
        }
    }
}
