
using LoanApi.Contracts.Loan;
using LoanApi.Models;
using LoanApi.Services.Loans;
using Microsoft.AspNetCore.Mvc;

namespace LoanApi.Controllers;

[ApiController]
[Route("[controller]")]
public class LoanApiController : ControllerBase
{
    private readonly ILoanService _loanService;

    public LoanApiController(ILoanService loanService)
    {
        _loanService = loanService;
    }
    [HttpPost]
    public IActionResult CreateLoan(CreateLoanRequest request)
    {
        var loan = new Loan(
            Guid.NewGuid(),
            request.JenisPinjaman,
            request.Status,
            request.ApplicationDate,
            request.NominalPinjaman
        );

        // TODO: Save loan to db
        _loanService.CreateLoan(loan);

        var response = new LoanResponse(
            loan.Id,
            loan.JenisPinjaman,
            loan.Status,
            loan.NominalPinjaman,
            loan.ApplicationDate
        );
        return CreatedAtAction(
            nameof(GetLoan),
            routeValues: new { id = loan.Id },
            response);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetLoan(Guid id)
    {
        Loan loan = _loanService.GetLoan(id);

        var response = new LoanResponse(
            loan.Id,
            loan.JenisPinjaman,
            loan.Status,
            loan.NominalPinjaman,
            loan.ApplicationDate
        );
        return Ok(response);
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpsertLoan(Guid id, UpsertLoanRequest request)
    {
        var loan = new Loan(
            id,
            request.JenisPinjaman,
            request.status,
            request.application_date,
            request.nominal
        );

        _loanService.UpsertLoan(loan);
        //TODO: return 201 if new loan created
        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteLoan(Guid id)
    {
        _loanService.DeleteLoan(id);
        return NoContent();
    }
}