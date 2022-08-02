namespace LoanApi.Contracts.Loan;

public record UpsertLoanRequest(
    string JenisPinjaman,
    bool status,
    int nominal,
    DateTime application_date
);