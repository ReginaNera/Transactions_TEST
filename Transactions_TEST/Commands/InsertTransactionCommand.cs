using DBDataAccess.Models;
using MediatR;
using Transactions_TEST.Models;

namespace Transactions_TEST.Commands
{
    public record InsertTransactionCommand(InsertTransactionRequestModel Transaction) : IRequest<ResponseModel>;
   
}
