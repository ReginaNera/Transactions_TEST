using DBDataAccess.Models;
using MediatR;
using Transactions_TEST.Models;

namespace Transactions_TEST.Queries
{
    public record GetAllTransactionsQuery() : IRequest<List<TransactionResponseModel>>;
 
}
