
using LoanApi.Models;

namespace LoanApi.Services.Loans;

public interface ILoanService
{
    void CreateLoan(Loan loan);
    Loan GetLoan(Guid id);
    void UpsertLoan(Loan loan);
    void DeleteLoan(Guid id);
}