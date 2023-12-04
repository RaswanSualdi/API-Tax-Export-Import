
using Microsoft.EntityFrameworkCore;
using WebApplication2.Database;
using Transaction = WebApplication2.Models.Transaction;

namespace WebApplication2.Repositories;

// Di dalam kelas TransactionRepository
public class TransactionRepository
{
    private readonly WebApplication2Context _context;

    public TransactionRepository(WebApplication2Context context)
    {
        _context = context;
    }

    public async Task<Transaction> GetTransactionByHsCodeAsync(string hsCode)
    {
        return await _context.Transactions
            .FirstOrDefaultAsync(t => t.code == hsCode);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
    // Metode lain yang mungkin diperlukan
}
