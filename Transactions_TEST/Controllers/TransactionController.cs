using DBDataAccess.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Transactions_TEST.Commands;
using Transactions_TEST.Enumeratons;
using Transactions_TEST.Models;
using Transactions_TEST.Queries;

namespace Transactions_TEST.Controllers
{
    [Route("api/Authorize")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TransactionController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<List<TransactionResponseModel>> Get()
        {
            return await _mediator.Send(new GetAllTransactionsQuery());
        }

        [HttpGet("{id}")]
        public async Task<TransactionResponseModel> Get([FromRoute]Guid id)
        {
            return await _mediator.Send(new GetTransactionByIdQuery(id));
        }

        [HttpPost]

        public async Task<ResponseModel> Post([FromBody]InsertTransactionRequestModel transaction)
        {
            return await _mediator.Send(new InsertTransactionCommand(transaction));

        }

        [HttpPost("{id}/voids")]

        public async Task<ResponseModel> AvoidedTransaction([FromRoute]Guid id, [FromBody] string orderRef)
        {
            return await _mediator.Send(new UpdateTransactioCommand(id, orderRef, StatusEnum.Voided));

        }

        [HttpPost("{id}/capture")]

        public async Task<ResponseModel> CapturedTransaction([FromRoute] Guid id, [FromBody] string orderRef)
        {
            return await _mediator.Send(new UpdateTransactioCommand(id, orderRef, StatusEnum.Captured));

        }
    }
}
