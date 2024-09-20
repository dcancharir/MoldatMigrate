using System.ComponentModel.DataAnnotations;

namespace MoldatMigration.Administrativo.Models;

public class Moneda
{
	[Key]
	public int CodMoneda { get; set; }

	public string Nombre { get; set; }

	public string CodIso { get; set; }

	public string Simbolo { get; set; }

	public int Predeterminado { get; set; }

	public int Boveda { get; set; }
}
