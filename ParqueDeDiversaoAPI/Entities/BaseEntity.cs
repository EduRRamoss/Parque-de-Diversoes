namespace ParqueDeDiversaoAPI.Entities;

public class BaseEntity<Tcodigo, Tnome>
{
    public Tcodigo? codigo { get; set; }
    public Tnome nome { get; set; }
}
