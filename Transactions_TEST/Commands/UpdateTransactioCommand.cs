using MediatR;
using Transactions_TEST.Enumeratons;
using Transactions_TEST.Models;

namespace Transactions_TEST.Commands
{
    public record UpdateTransactioCommand(Guid Id, string OrderRef, StatusEnum Status) : IRequest<ResponseModel>;

}
