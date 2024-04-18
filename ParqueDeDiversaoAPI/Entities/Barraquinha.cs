
namespace ParqueDeDiversaoAPI.Entities;

public class Barraquinha : BaseEntity<int, string>
{
    public string? descricaoBarraquinha { get; set; }
    public float? valorLiquidoArrecadado { get; set; }
    public float? valorBrutoArrecadado { get; set; }
    public float? valorCustoDeOperacao { get; set; }

    public bool? aberto { get; set; }

    public int setorId { get; set; }
    public Setor setor { get; set; }
}
