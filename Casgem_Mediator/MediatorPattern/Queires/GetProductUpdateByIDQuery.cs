using MediatR;

namespace Casgem_Mediator.MediatorPattern.Queires
{
    public class GetProductUpdateByIDQuery : IRequest
    {
        public int ID { get; set; }
    }
}
