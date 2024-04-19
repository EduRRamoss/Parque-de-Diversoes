using System.ComponentModel.DataAnnotations;

namespace ParqueDeDiversaoAPI.Entities;

public class Login : BaseEntity<int, string>
{
    [Required]
    [MaxLength(10)]
    [MinLength(1)]
    [RegularExpression(@"^[A-Z]+$", 
    ErrorMessage = "Apenas sao permitidos letras e devem ser em CAIXA ALTA!")]
    public string usuario { get; set; }

    [Required]
    [MaxLength(15)]
    [MinLength(8)]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$",
    ErrorMessage = "A senha deve ser COMPLEXA!")]
    public string senha { get; set; }

    public bool? isAdmin { get; set; }

    public Login()
    {
        isAdmin = false;
    }
}
