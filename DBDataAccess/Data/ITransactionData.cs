using DBDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBDataAccess.Data
{
    public interface ITransactionData
    {
        Task<IEnumerable<TransactionModel>> GetTransactions();
        Task<TransactionModel?> GetTransaction(Guid id);
        Task InsertTransaction(TransactionModel transaction);
        Task UpdateTransaction(Guid id, string orderReg, int status);
    }
}
