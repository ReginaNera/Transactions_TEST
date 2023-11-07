using DBDataAccess.Data;
using MediatR;
using System.Transactions;
using Transactions_TEST.Commands;
using Transactions_TEST.Enumeratons;
using Transactions_TEST.Models;

namespace Transactions_TEST.Handlers
{
    public class UpdateTransactionHandler : IRequestHandler<UpdateTransactioCommand, ResponseModel>
    {
        private readonly ITransactionData _transactionData;

        public UpdateTransactionHandler(ITransactionData transactionData)
        {
            _transactionData = transactionData;
        }

        public async Task<ResponseModel> Handle(UpdateTransactioCommand request, CancellationToken cancellationToken)
        {
            await _transactionData.UpdateTransaction(request.Id, request.OrderRef, (int)request.Status);

            return new ResponseModel() { Id = request.Id, Status = request.Status };
        }
    }
}
