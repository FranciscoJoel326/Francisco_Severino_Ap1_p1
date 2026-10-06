using System.ComponentModel.DataAnnotations;

namespace P1_AP1_FranciscoSeverino.Models;

public class Autores
{
    [Key]
    public int IdAutor { get; set; }

    [Required(ErrorMessage = "El campo Nombres es obligatorio")]
    public string Nombres { get; set; } = string.Empty;

    [Required(ErrorMessage = "El campo Nacionalidad es obligatorio")]
    public string Nacionalidad { get; set; } = string.Empty;

    public DateTime FechaNacimiento { get; set; } = DateTime.Today;

    [Range(0, 999999999, ErrorMessage = "El Sueldo debe ser mayor o igual a 0")]
    public decimal Sueldo { get; set; }
}
