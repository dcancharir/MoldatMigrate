using System.ComponentModel.DataAnnotations;

namespace MoldatMigration.Administrativo.Models;

public class Zona : Entity
{
	[Key]
	public int CodZona { get; set; }

	public string Nombre { get; set; }

}
