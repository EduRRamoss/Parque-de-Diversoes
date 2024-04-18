
namespace ParqueDeDiversaoAPI.Entities;

public class Atracao : BaseEntity<int, string>
{
    public string? descricaoAtracao { get; set; }
    public float? valorLiquidoArrecadado { get; set; }
    public float? valorBrutoArrecadado { get; set; }
    public float? valorCustoDeManutencao { get; set; }

    public bool? aberto { get; set; }
    public int? entradasVendidas { get; set; }
    public float? custoDeEntrada { get; set; }

    public int setorId { get; set; }
    public Setor setor { get; set; }
}
