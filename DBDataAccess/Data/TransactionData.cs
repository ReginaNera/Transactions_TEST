using DBDataAccess.DbAccess;
using DBDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBDataAccess.Data
{
    public class TransactionData : ITransactionData
    {
        private readonly ISQLDataAccess _db;

        public TransactionData(ISQLDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<TransactionModel>> GetTransactions() =>
            _db.LoadData<TransactionModel, dynamic>("dbo.sp_GetAllTransactions", new { });

        public async Task<TransactionModel?> GetTransaction(Guid id)
        {
            var results = await _db.LoadData<TransactionModel, dynamic>("dbo.sp_GetTransaction", new { Id = id });
            return results.FirstOrDefault();
        }

        public async Task InsertTransaction(TransactionModel transaction) =>
            await _db.SaveData("dbo.sp_InsertTransaction",
                new {transaction.Id, transaction.Amount, transaction.Currency, transaction.CardholderNumber, transaction.HolderName, transaction.ExpMonth, transaction.ExpYear, transaction.CVV, transaction.OrderRef, transaction.Status });

        public Task UpdateTransaction(Guid id, string orderRef, int status) =>
            _db.SaveData("dbo.sp_UpdateTransaction", new { id, status, orderRef });
    }
}
