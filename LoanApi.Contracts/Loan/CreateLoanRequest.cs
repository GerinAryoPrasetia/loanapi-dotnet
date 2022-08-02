namespace LoanApi.Contracts.Loan;

public record CreateLoanRequest(
    string JenisPinjaman,
    bool Status,
    int NominalPinjaman,
    DateTime ApplicationDate
);