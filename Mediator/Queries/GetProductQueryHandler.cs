using MediatR;
using MediatR_Mediator_Pattern.Mediator.Queries.VM;

namespace MediatR_Mediator_Pattern.Mediator.Queries
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, GetProductVm>
    {
        public Task<GetProductVm> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            //Get product from db...
            var vm  = new GetProductVm
            {
                Id = Guid.NewGuid(),
                Name = "Car"
            };
            return Task.FromResult(vm);
        }
    }
}
