using System.ComponentModel.DataAnnotations;

namespace MoldatMigration.Administrativo.Models;

public class Juego
{
	[Key]
	public int CodJuego { get; set; }

	public int CodMarcaMaquina { get; set; }

	public string? Nombre { get; set; }

	public string? JuegosAlternos { get; set; }

	public int CodRD { get; set; }
}
