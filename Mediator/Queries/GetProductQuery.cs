using MediatR;
using MediatR_Mediator_Pattern.Mediator.Queries.VM;

namespace MediatR_Mediator_Pattern.Mediator.Queries
{
    public class GetProductQuery:IRequest<GetProductVm>
    {
        public Guid Id { get; set; }


    }
}
