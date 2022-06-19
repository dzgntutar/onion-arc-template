using Library.Application.CQRS.Commands;
using Library.Application.CQRS.Handlers;
using Library.Application.CQRS.Queries;
using Library.Application.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMediator mediator;

        public BooksController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok( await mediator.Send(new GetAllBookQuery()));
        }

        [HttpPost]
        public async Task<IActionResult> Post(BookSaveDto bookSaveDto)
        {
            await mediator.Send(new AddBookCommand { BookSaveDto = bookSaveDto });
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            return Ok(await mediator.Send(new GetBookByIdQuery { Id=id}));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await mediator.Send(new DeleteBookCommand { Id = id });
            return Ok(); 
        }
        
    }
}
