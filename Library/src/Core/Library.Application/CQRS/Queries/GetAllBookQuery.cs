using Library.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.CQRS.Queries
{
    public class GetAllBookQuery : IRequest<List<BookViewDto>>
    {
    }
}
