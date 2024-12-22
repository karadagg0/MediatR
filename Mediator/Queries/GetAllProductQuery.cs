using MediatR;
using MediatR_Mediator_Pattern.Mediator.Queries.VM;

namespace MediatR_Mediator_Pattern.Mediator.Queries
{
    public class GetAllProductQuery:IRequest<List<GetProductVm>>
    {
        public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetProductVm>>
        {
            public Task<List<GetProductVm>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var model = new GetProductVm()
                {
                    Id = Guid.NewGuid(),
                    Name = "Car"
                }; 
                var model2 = new GetProductVm()
                {
                    Id = Guid.NewGuid(),
                    Name = "Screen"
                };
                return Task.FromResult(new List<GetProductVm> { model, model2 });
            }
        }

    }
}
