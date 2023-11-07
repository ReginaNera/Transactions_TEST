using AutoMapper;
using DBDataAccess.Data;
using DBDataAccess.Models;
using MediatR;
using Transactions_TEST.Models;
using Transactions_TEST.Queries;

namespace Transactions_TEST.Handlers
{
    public class GetTransactionByIdHandler : IRequestHandler<GetTransactionByIdQuery, TransactionResponseModel>
    {
        private readonly ITransactionData _transactionData;
        private readonly IMapper _mapper;

        public GetTransactionByIdHandler(IMapper mapper, ITransactionData transactionData)
        {
            _mapper = mapper;
            _transactionData = transactionData;
        }

        public async Task<TransactionResponseModel> Handle(GetTransactionByIdQuery request, CancellationToken cancellationToken)
        {
            var results = _transactionData.GetTransaction(request.Id).Result;
            var output = _mapper.Map<TransactionResponseModel>(results);
            return output;

        }
    }
}
