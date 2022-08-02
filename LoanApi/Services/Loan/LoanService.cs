using LoanApi.Models;

namespace LoanApi.Services.Loans;

public class LoanService : ILoanService
{
    //Untuk saat ini masih menggunakan memory
    //TODO: Store ke db menggunakan entity framework
    private static readonly Dictionary<Guid, Loan> _loans = new();
    public void CreateLoan(Loan loan)
    {
        // key = loan.id, value = loan
        _loans.Add(loan.Id, loan);
    }

    public void DeleteLoan(Guid id)
    {
        _loans.Remove(id);
    }

    public Loan GetLoan(Guid id)
    {
        return _loans[id];
    }

    public void UpsertLoan(Loan loan)
    {
        _loans[loan.Id] = loan;
    }
}