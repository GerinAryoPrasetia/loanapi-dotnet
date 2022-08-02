namespace LoanApi.Contracts.Loan;

public record LoanResponse(
    Guid Id,
    string JenisPinjaman,
    bool status,
    int nominal,
    DateTime application_date
);