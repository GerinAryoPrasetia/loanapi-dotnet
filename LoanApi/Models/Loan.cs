namespace LoanApi.Models;

public class Loan
{
    public Loan(
        Guid id,
        string jenisPinjaman,
        bool status,
        DateTime applicationDate,
        int nominalPinjaman)
    {
        //enforce invariants
        Id = id;
        JenisPinjaman = jenisPinjaman;
        Status = status;
        ApplicationDate = applicationDate;
        NominalPinjaman = nominalPinjaman;
    }

    public Guid Id { get; }
    public string JenisPinjaman { get; }
    public bool Status { get; }
    public DateTime ApplicationDate { get; }
    public int NominalPinjaman { get; }
}

public enum JenisPinjaman
{
    Auto, Housing, Personal, Agriculture
}