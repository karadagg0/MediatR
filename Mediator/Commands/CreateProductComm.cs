using MediatR;

namespace MediatR_Mediator_Pattern.Mediator.Commands
{
    public class CreateProductComm:IRequest<Guid>
    {
        public string? Name { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }


        public class CreateProductCommandHandler : IRequestHandler<CreateProductComm, Guid>
        {
            public Task<Guid> Handle(CreateProductComm request, CancellationToken cancellationToken)
            {
                return Task.FromResult(Guid.NewGuid());
                //send data to db
            }
        }
    }
}
