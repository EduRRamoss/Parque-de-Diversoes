
namespace ParqueDeDiversaoAPI.Entities;

public class Barraquinha : BaseEntity<int, string>
{
    public string? descricaoBarraquinha { get; set; }
    public double? valorLiquidoArrecadado { get; set; }
    public double? valorBrutoArrecadado { get; set; }
    public double? valorCustoDeOperacao { get; set; }

    public bool? aberto { get; set; }

    public int setorCodigo { get; set; }
    public Setor setor { get; set; }
}
