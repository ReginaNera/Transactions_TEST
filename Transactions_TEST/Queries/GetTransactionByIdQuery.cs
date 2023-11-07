using DBDataAccess.Models;
using MediatR;
using Transactions_TEST.Models;

namespace Transactions_TEST.Queries
{
    public record GetTransactionByIdQuery(Guid Id) : IRequest<TransactionResponseModel>;
  
}
