using AutoMapper;
using DBDataAccess.Data;
using DBDataAccess.Models;
using MediatR;
using Transactions_TEST.Commands;
using Transactions_TEST.Enumeratons;
using Transactions_TEST.Models;

namespace Transactions_TEST.Handlers
{
    public class InsertTransactionHandler : IRequestHandler<InsertTransactionCommand, ResponseModel>
    {
        private readonly ITransactionData _transactionData;
        private readonly IMapper _mapper;

        public InsertTransactionHandler(ITransactionData transactionData, IMapper mapper)
        {
            _transactionData = transactionData;
            _mapper = mapper;
        }

        public async Task<ResponseModel> Handle(InsertTransactionCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var transaction = _mapper.Map<TransactionModel>(request.Transaction);
                transaction.Id = Guid.NewGuid();
                transaction.Status = (int)StatusEnum.Authorize;
                 await _transactionData.InsertTransaction(transaction);
                
                 return new ResponseModel() { Id = transaction.Id, Status = StatusEnum.Authorize };
             
            }catch(Exception ex)
            {
                throw ex;
            }
        }

     
    }
}
