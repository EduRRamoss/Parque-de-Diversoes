namespace ParqueDeDiversaoAPI.Entities;

public class Setor :  BaseEntity<int, string>

{
    public string? descricaoSetor { get; set; }
    public double? valorLiquidoArrecadado { get; set; }
    public virtual IEnumerable<Barraquinha>? barraquinhas { get; set; }
    public virtual IEnumerable<Atracao>? atracoes { get; set; }
}
