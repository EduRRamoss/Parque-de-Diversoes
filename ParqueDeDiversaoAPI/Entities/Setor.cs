namespace ParqueDeDiversaoAPI.Entities;

public class Setor :  BaseEntity<int, string>

{
    public string? descricaoSetor { get; set; }
    public float? valorLiquidoArrecadado { get; set; }
    public IEnumerable<Barraquinha>? Barraquinhas { get; set; }
    public IEnumerable<Atracao>? Atracoes { get; set; }
}
