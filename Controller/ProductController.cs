using MediatR;
using MediatR_Mediator_Pattern.Mediator.Commands;
using MediatR_Mediator_Pattern.Mediator.Queries;
using MediatR_Mediator_Pattern.Mediator.Queries.VM;
using Microsoft.AspNetCore.Mvc;

namespace MediatR_Mediator_Pattern.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;
        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid Id)
        {
            var query = new GetProductVm { Id = Id };
            return Ok(await mediator.Send(query));
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllProductQuery();
            return Ok(await mediator.Send(query));
        }
        [HttpPost]
        [Route("Post")]
        public async Task<IActionResult> Post(CreateProductComm comm)
        {
            return Ok(await mediator.Send(comm));
        }

    }
}
