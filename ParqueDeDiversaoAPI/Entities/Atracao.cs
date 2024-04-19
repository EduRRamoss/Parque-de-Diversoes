
namespace ParqueDeDiversaoAPI.Entities;

public class Atracao : BaseEntity<int, string>
{
    public string? descricaoAtracao { get; set; }
    public double? valorLiquidoArrecadado { get; set; }
    public double? valorBrutoArrecadado { get; set; }
    public double? valorCustoDeManutencao { get; set; }

    public bool? aberto { get; set; }
    public int? entradasVendidas { get; set; }
    public double? custoDeEntrada { get; set; }

    public int setorCodigo { get; set; }
    public Setor setor { get; set; }
}
