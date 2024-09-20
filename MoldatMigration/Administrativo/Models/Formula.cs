using System.ComponentModel.DataAnnotations;

namespace MoldatMigration.Administrativo.Models;

public class Formula : Entity
{
	[Key]
	public int CodFormula { get; set; }

	public string Nombre { get; set; }

	public string NombreReal { get; set; }
}
