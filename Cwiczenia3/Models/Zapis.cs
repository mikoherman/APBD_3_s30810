namespace LinqConsoleLab.PL.Models;

public sealed class Zapis
{
    public int Id { get; set; }

    public int StudentId { get; set; }

    public int PrzedmiotId { get; set; }

    public DateTime DataZapisu { get; set; }

    public double? OcenaKoncowa { get; set; }

    public bool CzyAktywny { get; set; }

    public override string ToString() =>
        $"{Id} {StudentId} {PrzedmiotId} {DataZapisu} " +
        $"{(OcenaKoncowa is null ? "brak" : OcenaKoncowa)} {CzyAktywny}";
}
