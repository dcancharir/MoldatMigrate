using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoldatMigration.AdministrativoDataWarehouse.Models;
[Table("Juego")]
public class JuegoDW
{
	[Key]
	public int CodJuego { get; set; }

	public int CodMarcaMaquina { get; set; }

	public string? Nombre { get; set; }

	public string? JuegosAlternos { get; set; }

	public int CodRD { get; set; }
}
