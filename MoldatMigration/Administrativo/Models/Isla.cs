using System.ComponentModel.DataAnnotations;

namespace MoldatMigration.Administrativo.Models;

public class Isla : Entity
{
	[Key]
	public int CodIsla { get; set; }

	public string Nombre { get; set; }
}
