using FluentValidation;
using Transactions_TEST.Commands;

namespace Transactions_TEST.Validation
{
    public class InsertTransactionCommandValidator : AbstractValidator<InsertTransactionCommand>
    {
        public InsertTransactionCommandValidator()
        {
            RuleFor(x => x.Transaction.Amount)
                .NotNull()
                .GreaterThan(0);

            RuleFor(x => x.Transaction.Currency)
               .NotEmpty()
               .MaximumLength(3);


            RuleFor(x => x.Transaction.CardholderNumber)
               .NotEmpty()
               .MaximumLength(16);
               
            RuleFor(x => x.Transaction.HolderName)
               .NotEmpty()
               .MaximumLength(50);

            RuleFor(x => x.Transaction.OrderRef)
               .NotEmpty()
               .MaximumLength(50);

            RuleFor(x => x.Transaction.CVV)
               .NotNull();

            RuleFor(x => x.Transaction.ExpMonth)
               .NotNull();

            RuleFor(x => x.Transaction.ExpYear)
               .NotNull();
        }
    }
}
