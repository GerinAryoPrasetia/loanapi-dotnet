using LoanApi.Services.Loans;

var builder = WebApplication.CreateBuilder(args);

{
    builder.Services.AddControllers();
    builder.Services.AddScoped<ILoanService, LoanService>();
}

var app = builder.Build();

{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}

