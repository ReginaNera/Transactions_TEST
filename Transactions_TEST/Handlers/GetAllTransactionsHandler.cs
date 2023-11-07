using AutoMapper;
using DBDataAccess.Data;
using DBDataAccess.DbAccess;
using DBDataAccess.Models;
using MediatR;
using Transactions_TEST.Models;
using Transactions_TEST.Queries;

namespace Transactions_TEST.Handlers
{
    public class GetAllTransactionsHandler : IRequestHandler<GetAllTransactionsQuery, List<TransactionResponseModel>>
    {
        private readonly ITransactionData _transactionData;
        private readonly IMapper _mapper;

        public GetAllTransactionsHandler(ITransactionData transactionData, IMapper mapper)
        {
            _transactionData = transactionData;
            _mapper = mapper;
        }

        public async Task<List<TransactionResponseModel>> Handle(GetAllTransactionsQuery request, CancellationToken cancellationToken)
        {
            var results = _transactionData.GetTransactions().Result;
            var output = _mapper.Map<List<TransactionResponseModel>>(results.ToList());
            return output;
        }
    }
}
